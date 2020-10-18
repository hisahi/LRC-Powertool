using AudioPlayerSample;
using CSCore;
using CSCore.Codecs;
using CSCore.Codecs.OPUS;
using CSCore.MediaFoundation;
using CSCore.SoundOut;
using NVorbisIntegration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRCPowertool
{
    public partial class MainForm : Form
    {
        const bool skipEmptyLines = true;
        private MusicPlayer mp = new MusicPlayer();
        private SynchronizedLyrics lrc = null;
        private Encoding UTF8NOBOM = new UTF8Encoding(false);
        private bool _unsaved = false;
        private string _lrcFile = null;
        private string mediaFileName = null;
        private string programName = "";
        private bool trackBarValueFilter = true;
        private bool trackBarPlayOnUp = false;
        private bool ignoreMetadataChanges = false;

        public MainForm()
        {
            InitializeComponent();
            programName = this.Text;
        }

        public bool Unsaved
        {
            get => _unsaved;
            set
            {
                _unsaved = value;
                UpdateTitle();
            }
        }

        public string FileName
        {
            get => _lrcFile;
            set
            {
                _lrcFile = value;
                UpdateTitle();
            }
        }

        public string MusicFile
        {
            get => mediaFileName;
            set
            {
                mediaFileName = value;
                Control panel = splitContainerMainControls.Panel2;
                foreach (Control control in panel.Controls)
                {
                    control.Enabled = mediaFileName != null;
                }
                labelVolume.Enabled = trackBarVolume.Enabled = true;
                UpdateTitle();
            }
        }

        public static string Version
        {
            get => AssemblyName.GetAssemblyName(System.Reflection.Assembly.GetExecutingAssembly().Location).Version.ToString();
        }

        private void UpdateTitle()
        {
            this.Text = (Unsaved ? "*" : "") + programName + (FileName != null ? " - " + FileName : "") + (MusicFile != null ? " (" + Path.GetFileName(MusicFile) + ")" : "");
        }

        public static double TimeSpanToDouble(TimeSpan ts)
        {
            return ts.TotalSeconds;
        }

        public static TimeSpan DoubleToTimeSpan(double d)
        {
            // tick = 10 ns, so 1 second = 10000000 ticks
            return new TimeSpan((long)(d * 10_000_000));
        }

        public static Control FindFocusedControl(Control control)
        {
            var container = control as IContainerControl;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as IContainerControl;
            }
            return control;
        }

        public static bool DoesControlAcceptInput(Control control)
        {
            return control is TextBoxBase || control is ListView || control is TrackBar || control is UpDownBase;
        }

        private static string FormatTime(double duration)
        {
            int durationSeconds = (int)duration;
            if (durationSeconds < 0) return "--:--";
            return (durationSeconds / 60).ToString("D2") + ":" + (durationSeconds % 60).ToString("D2");
        }

        private string FormatSeekStatus(double position, double total, PlaybackState playbackState)
        {
            string elapsed = FormatTime(position);
            string duration = FormatTime(total);
            string playbackStatus = "";

            switch (playbackState)
            {
                case PlaybackState.Playing:
                    playbackStatus = "PLAY";
                    break;
                case PlaybackState.Paused:
                    playbackStatus = "PAUS";
                    break;
                case PlaybackState.Stopped:
                    playbackStatus = "STOP";
                    break;
            }

            return $"{elapsed} / {duration} [{playbackStatus}]";
        }

        private void UpdateLyricsTextBox()
        {
            textBoxOutput.Text = lrc.RawText;
            outputTextBoxValueChanged = false;
            textBoxPreviewLyrics.Text = lrc.PreviewText;
        }

        private void UpdateLRCMetadataControls()
        {
            ignoreMetadataChanges = true;
            textBoxMetaArtist.Text = lrc.Artist ?? "";
            textBoxMetaAlbum.Text = lrc.Album ?? "";
            textBoxMetaTitle.Text = lrc.Title ?? "";
            textBoxMetaSongwriter.Text = lrc.Songwriter ?? "";
            textBoxMetaLength.Text = lrc.Length ?? "";
            textBoxMetaLrcBy.Text = lrc.LRCBy ?? "";
            numericUpDownMetaOffsetMs.Value = lrc.OffsetMs ?? 0;
            textBoxMetaEditor.Text = lrc.Editor ?? "";
            textBoxMetaEditorVersion.Text = lrc.EditorVersion ?? "";
            ignoreMetadataChanges = false;
        }

        private void SetAutoLRCMeta()
        {
            if (mp.HasMedia)
            {
                try
                {
                    var tfile = TagLib.File.Create(MusicFile);
                    textBoxMetaTitle.Text = tfile.Tag?.Title ?? "";
                    textBoxMetaArtist.Text = tfile.Tag?.JoinedPerformers ?? "";
                    textBoxMetaAlbum.Text = tfile.Tag?.Album ?? "";
                }
                catch (TagLib.UnsupportedFormatException) { }
                catch (TagLib.CorruptFileException) { }
                textBoxMetaLength.Text = SynchronizedLyrics.ConvertToLRCTime(TimeSpanToDouble(mp.Length));
            }
            textBoxMetaEditor.Text = programName;
            textBoxMetaEditorVersion.Text = Version;
        }

        private void DisplayKeyboardHelp()
        {
            MessageBox.Show(@"Left - Seek track back by 3 seconds
Right - Seek track forward by 3 seconds
Shift+Left - Seek track back by 30 seconds
Shift+Right - Seek track forward by 30 seconds
Enter - 'Next Line'
B - 'Add Blank'
Space - 'Play/Pause' (Music)
Esc - 'Stop' (Music)
Q - 'Line Rewind'
A - 'Prev Line'
Z - 'Undo Line'
S - 'Skip Line'
D - 'Earlier'
F - 'Later'

Press the status bar if your key presses aren't registering", "Keyboard Help");
        }

        private void PlayPauseTrack()
        {
            if (mp.HasMedia)
            {
                if (mp.PlaybackState == PlaybackState.Playing)
                    mp.Pause();
                else
                {
                    if (mp.PlaybackState == PlaybackState.Stopped)
                    {
                        mp.Position = new TimeSpan(0);
                        lrc.ResetIndex();
                    }
                    mp.Play();
                    if (ListViewIndex < 0 && listViewLines.Items.Count > 0)
                    {
                        SelectListViewIndex(0, true);
                    }
                }
                timerEditUpdateElapsed.Start();
                if (mainTabControl.SelectedTab == tabPagePreview)
                    timerPreviewUpdateElapsed.Start();
            }
        }

        private void StopTrack()
        {
            if (mp.HasMedia)
            {
                mp.Stop();
                SetTrackPosition(0);
            }
        }

        private void SeekTrack(double by)
        {
            if (mp.HasMedia)
            {
                SetTrackPosition(TimeSpanToDouble(mp.Position) + by);
            }
        }

        private void SetTrackPosition(double position)
        {
            if (mp.HasMedia)
            {
                bool wasPlaying = mp.PlaybackState == PlaybackState.Playing;
                if (wasPlaying) mp.Pause();

                double duration = TimeSpanToDouble(mp.Length);
                if (position < 0) position = 0;
                if (position >= duration)
                {
                    StopTrack();
                    wasPlaying = false;
                }
                else
                    mp.Position = DoubleToTimeSpan(position);

                lrc.RescanIndex(TimeSpanToDouble(mp.Position));
                if (mainTabControl.SelectedTab == tabPagePreview) SelectLRCPreviewLine(lrc.CurrentIndex);

                if (wasPlaying) mp.Play();
                UpdateTrackBar();
            }
        }

        public double LineTime
        {
            get
            {
                if (!mp.HasMedia) return Double.NaN;
                double d = TimeSpanToDouble(mp.Position);
                d += 0.001 * (double)numericUpDownTimeOffset.Value;
                if (d < 0) d = 0;
                return d;
            }
        }

        private bool AllowUnsaved()
        {
            if (!Unsaved) return true;
            DialogResult result = MessageBox.Show(this, "Do you want to save the currently unsaved lyrics file?", "Question", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.No)
                return true;
            if (result == DialogResult.Yes)
                return SaveFile();
            return false;
        }

        private void UpdateLRC()
        {
            Unsaved = true;
            UpdateLyricsTextBox();
            if (mp.HasMedia)
            {
                lrc.RescanIndex(TimeSpanToDouble(mp.Position));
                if (mainTabControl.SelectedTab == tabPagePreview) SelectLRCPreviewLine(lrc.CurrentIndex);
            }
            if (mainTabControl.SelectedTab == tabPageMetadata) UpdateLRCMetadataControls();
        }

        // placeholder is intentionally unused
        private void UpdateLRCOnMetadataChange(object placeholder)
        {
            if (!ignoreMetadataChanges)
                UpdateLRC();
        }

        private void NewLyricsFile()
        {
            lrc = new SynchronizedLyrics();
            UpdateLRC();
            Unsaved = false;
            FileName = null;
            lrc.Editor = programName;
            lrc.EditorVersion = Version;
            saveFileDialogLrc.FileName = "";
            UpdateTitle();
        }

        private bool LoadLRCFrom(string fileName)
        {
            bool fail = false;
            string text = "";
            try
            {
                text = File.ReadAllText(fileName);
            }
            catch (IOException) { fail = true; }
            catch (UnauthorizedAccessException) { fail = true; }
            catch (SecurityException) { fail = true; }

            if (fail)
            {
                MessageBox.Show(this, "Failed to open the given file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            lrc = new SynchronizedLyrics(text);
            FileName = fileName;
            UpdateLRC();
            Unsaved = false;
            return true;
        }

        private bool SaveLRCTo(string fileName)
        {
            AdjustViaOutputTextBox();
            bool fail = false;
            try
            {
                File.WriteAllText(fileName, lrc.Export(), UTF8NOBOM);
            }
            catch (IOException) { fail = true; }
            catch (UnauthorizedAccessException) { fail = true; }
            catch (SecurityException) { fail = true; }

            if (fail)
            {
                MessageBox.Show(this, "Failed to save the given file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Unsaved = false;
            FileName = fileName;
            return true;
        }

        private bool SaveFile()
        {
            if (FileName == null)
                return saveFileDialogLrc.ShowDialog(this) == DialogResult.OK;
            else
                return SaveLRCTo(FileName);
        }

        private bool OpenMusicFile(string fileName)
        {
            try
            {
                mp.Open(fileName);
                if (!mp.HasMedia) throw new InvalidDataException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Cannot open the selected music file.\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            mp.Position = DoubleToTimeSpan(0);
            lrc.RescanIndex(TimeSpanToDouble(mp.Position));
            if (mainTabControl.SelectedTab == tabPagePreview) SelectLRCPreviewLine(lrc.CurrentIndex);
            this.trackBarSeek.Minimum = 0;
            this.trackBarSeek.Maximum = ConvertTrackBarValue(TimeSpanToDouble(mp.Length));
            this.trackBarSeek.Value = 0;
            MusicFile = fileName;
            timerEditUpdateElapsed.Start();
            if (mainTabControl.SelectedTab == tabPagePreview)
                timerPreviewUpdateElapsed.Start();
            if (FileName == null && lrc.Length == null) // autofill length on new files
                lrc.Length = SynchronizedLyrics.ConvertToLRCTime(TimeSpanToDouble(mp.Length));
            if (FileName == null && saveFileDialogLrc.FileName == "") // autosuggest filename on new files
                saveFileDialogLrc.FileName = fileName + ".lrc";
            return true;
        }

        private bool OpenTxtFile(string fileName)
        {
            bool fail = false;
            string[] lines = null;
            try
            {
                lines = File.ReadAllLines(fileName);
            }
            catch (IOException) { fail = true; }
            catch (UnauthorizedAccessException) { fail = true; }
            catch (SecurityException) { fail = true; }

            if (fail)
            {
                MessageBox.Show(this, "Failed to open the given file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                LoadLyricList(lines);
                return true;
            }
        }

        private void LoadLyricList(string[] lines)
        {
            listViewLines.Items.Clear();
            foreach (string line in lines)
                listViewLines.Items.Add(MakeListViewItemWithText(line));

            listViewLines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            if (ListViewIndex < 0 && listViewLines.Items.Count > 0)
            {
                SelectListViewIndex(0, true);
            }
        }

        private bool SaveTxtFile(string fileName)
        {
            bool fail = false;
            try
            {
                File.WriteAllLines(saveFileDialogTxt.FileName, listViewLines.Items.OfType<ListViewItem>().Select(i => GetListViewItemText(i)).ToArray());
            }
            catch (IOException) { fail = true; }
            catch (UnauthorizedAccessException) { fail = true; }
            catch (SecurityException) { fail = true; }

            if (fail)
            {
                MessageBox.Show(this, "Failed to save the given file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return !fail;
        }

        private ListViewItem MakeListViewItemWithText(string text)
        {
            var item = new ListViewItem(text.Length > 256 ? text.Substring(0, 256) : text);
            item.ToolTipText = text;
            return item;
        }

        private string GetListViewItemText(ListViewItem i)
        {
            return i.SubItems[0].Text;
        }

        private int ListViewIndex
        {
            get
            {
                var indices = listViewLines.SelectedIndices;
                if (indices.Count < 1) return -1;
                return indices[0];
            }
        }

        private void AddNewLineToList()
        {
            int newIndex = ListViewIndex;
            if (newIndex < 0) newIndex = listViewLines.Items.Count;
            listViewLines.Items.Insert(newIndex, MakeListViewItemWithText(""));
            SelectListViewIndex(newIndex, true);
            listViewLines.Items[newIndex].BeginEdit();
        }

        private void DuplicateLineInList()
        {
            int index = ListViewIndex;
            if (index >= 0)
                listViewLines.Items.Insert(index + 1, MakeListViewItemWithText(GetListViewItemText(listViewLines.Items[index])));
        }

        private void RemoveLineFromList()
        {
            int index = ListViewIndex;
            if (index >= 0)
                listViewLines.Items.RemoveAt(index);
        }
        
        private void ListViewSwap(int a, int b)
        {
            ListViewItem itemA = listViewLines.Items[a];
            ListViewItem itemB = listViewLines.Items[b];

            listViewLines.Items[a] = itemB;
            listViewLines.Items[b] = itemA;
        }

        private void MoveLineUpInList()
        {
            int index = ListViewIndex;
            if (index > 0)
                ListViewSwap(index, index - 1);
        }

        private void MoveLineDownInList()
        {
            int index = ListViewIndex;
            if (index >= 0 && index < listViewLines.Items.Count - 1)
                ListViewSwap(index, index + 1);
        }

        private void SelectListViewIndex(int index) => SelectListViewIndex(index, false);

        private void SelectListViewIndex(int index, bool center)
        {
            listViewLines.SelectedIndices.Clear();
            listViewLines.Items[index].Selected = true;
            if (center)
            {
                int totalItems = listViewLines.Items.Count;
                int maxY = listViewLines.ClientSize.Height - 1;
                var lastItem = listViewLines.GetItemAt(1, maxY);
                if (lastItem != null)
                {
                    int numberOfVisibleLines = lastItem.Index - listViewLines.TopItem.Index;
                    int topIndex = index - numberOfVisibleLines / 2;
                    int bottomIndex = index + numberOfVisibleLines / 2;

                    if (topIndex >= 0) listViewLines.EnsureVisible(topIndex);
                    if (bottomIndex < totalItems) listViewLines.EnsureVisible(bottomIndex);
                }
                listViewLines.EnsureVisible(index);
            }
        }

        private void NextLine()
        {
            AdjustViaOutputTextBox();
            if (listViewLines.Items.Count < 1)  // add placeholder line if empty
            {
                if (mp.HasMedia)
                {
                    int line = lrc.AddLine(LineTime, "PLACEHOLDER");
                    UpdateLRC();
                    SelectLRCOutputLine(line);
                }
                return;
            }

            int index = ListViewIndex;
            if (index >= 0)
            {
                if (mp.HasMedia)
                {
                    string currentLine = GetListViewItemText(listViewLines.Items[index]);
                    int line = lrc.AddLine(LineTime, currentLine);
                    UpdateLRC();
                    SelectLRCOutputLine(line);
                }
                SkipLine();
            }
        }

        private void PreviousLine()
        {
            int index = ListViewIndex;
            if (index > 0)
            {
                SelectListViewIndex(index - 1, true);
                if (skipEmptyLines) SkipEmptyLinesBackward();
            }
        }

        private void SkipLine()
        {
            int index = ListViewIndex;
            if (index >= 0 && index < listViewLines.Items.Count - 1)
            {
                SelectListViewIndex(index + 1, true);
                if (skipEmptyLines) SkipEmptyLinesForward();
            }
        }

        private void SkipEmptyLinesForward()
        {
            while (true)
            {
                int index = ListViewIndex;
                if (index < 0 || index >= listViewLines.Items.Count - 1)
                    break;
                if (GetListViewItemText(listViewLines.SelectedItems[0]) != "")
                    break;
                SelectListViewIndex(index + 1, true);
            }
        }

        private void SkipEmptyLinesBackward()
        {
            while (true)
            {
                int index = ListViewIndex;
                if (index <= 0)
                    break;
                if (GetListViewItemText(listViewLines.SelectedItems[0]) != "")
                    break;
                SelectListViewIndex(index - 1, true);
            }
        }

        private void UndoLine()
        {
            int index = ListViewIndex;
            int line = GetSelectedOutputLine();
            AdjustViaOutputTextBox();
            if (index >= 0 && line >= 0)
            {
                bool goToPrevious = true;
                goToPrevious = lrc.GetText(line) != "" || GetListViewItemText(listViewLines.SelectedItems[0]) == "";
                if (goToPrevious) PreviousLine();
            }
            if (lrc.LineCount == 0)
                return;
            lrc.RemoveLine(line);
            UpdateLRC();
            --line;
            if (line >= 0)
                SelectLRCOutputLine(line);
        }

        private void AddBlankLine()
        {
            if (mp.HasMedia)
            {
                AdjustViaOutputTextBox();
                int line = lrc.AddLine(LineTime, "");
                UpdateLRC();
                SelectLRCOutputLine(line);
            }
        }

        private void SelectTextBoxAndCenter(TextBoxBase textBox, int start, int length)
        {
            int numVisibleLines = textBox.ClientSize.Height / textBox.Font.Height;
            int lastLine = textBox.Lines.Length - 1;
            if (lastLine < 0) return;

            int newLineCharIndex = textBox.GetFirstCharIndexFromLine(Math.Min(textBox.GetLineFromCharIndex(start) + numVisibleLines / 2, lastLine));

            textBox.Select(0, 0);
            textBox.ScrollToCaret();
            if (newLineCharIndex >= 0)
            {
                textBox.Select(newLineCharIndex, 1);
                textBox.ScrollToCaret();
            }
            textBox.Select(start, 0);
            textBox.ScrollToCaret();
            textBox.Select(start, length);
        }

        private void SelectLRCOutputLine(int line)
        {
            int startIndex = textBoxOutput.GetFirstCharIndexFromLine(line);
            if (startIndex >= 0)
                SelectTextBoxAndCenter(textBoxOutput, startIndex, GetLineLength(textBoxOutput, line));
        }

        private void SelectLRCPreviewLine(int line)
        {
            SelectTextBoxAndCenter(textBoxPreviewLyrics, lrc.GetSelectionStart(line), lrc.GetSelectionLength(line));
        }

        private void MoveEarlier()
        {
            if (lrc.LineCount == 0)
                return;
            AdjustViaOutputTextBox();
            int line = GetSelectedOutputLine();
            line = lrc.ShiftLine(line, -0.05);
            UpdateLRC();
            SelectLRCOutputLine(line);
        }

        private void MoveLater()
        {
            if (lrc.LineCount == 0)
                return;
            AdjustViaOutputTextBox();
            int line = GetSelectedOutputLine();
            line = lrc.ShiftLine(line, +0.05);
            UpdateLRC();
            SelectLRCOutputLine(line);
        }

        private void JumpToSelectedLine()
        {
            if (lrc.LineCount == 0 || !mp.HasMedia)
                return;
            int line = GetSelectedOutputLine();
            SetTrackPosition(lrc.GetLyricTime(line) - 0.25);
            if (mp.PlaybackState != PlaybackState.Playing)
                PlayPauseTrack();
        }

        private int GetSelectedOutputLine()
        {
            //if (CaretAtNewLine()) textBoxOutput.SelectionStart += Environment.NewLine.Length;
            return textBoxOutput.GetLineFromCharIndex(textBoxOutput.SelectionStart);
        }

        private bool CaretAtNewLine()
        {
            int caret = textBoxOutput.SelectionStart;
            if (textBoxOutput.SelectionLength > 0) return false;
            if (textBoxOutput.TextLength - caret <= Environment.NewLine.Length) return false;
            return Environment.NewLine == textBoxOutput.Text.Substring(caret, Environment.NewLine.Length);
        }

        private int GetLineLength(TextBox textBoxOutput, int line)
        {
            int startOfLine = textBoxOutput.GetFirstCharIndexFromLine(line);
            int firstNewLine = textBoxOutput.Text.IndexOf(Environment.NewLine, startOfLine);
            if (firstNewLine < 0) firstNewLine = textBoxOutput.TextLength;
            return firstNewLine - startOfLine;
        }

        private void RewindLines()
        {
            if (listViewLines.Items.Count > 0)
                SelectListViewIndex(0, true);
        }

        private int ConvertTrackBarValue(double d)
        {
            return (int)(d * trackBarSeek.TickFrequency);
        }

        private void UpdateTrackBar()
        {
            trackBarValueFilter = false;
            this.trackBarSeek.Value = ConvertTrackBarValue(TimeSpanToDouble(mp.Position));
            trackBarValueFilter = true;
        }

        private bool outputTextBoxValueChanged = false;
        private void AdjustViaOutputTextBox()
        {
            if (outputTextBoxValueChanged)
            {
                lrc.ImportText(textBoxOutput.Text);
                UpdateLRC();
                outputTextBoxValueChanged = false;
            }
        }

        #region Event handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            // register NVorbis and Concentus listeners
            CodecFactory.Instance.Register("ogg-vorbis", new CodecFactoryEntry(s => new NVorbisSource(s).ToWaveSource(), ".ogg"));
            CodecFactory.Instance.Register("ogg-opus-ext1", new CodecFactoryEntry(s => new OpusSource(s), ".opus"));
            CodecFactory.Instance.Register("ogg-opus-ext2", new CodecFactoryEntry(s => new OpusSource(s), ".ogg"));

            NewLyricsFile();
            UpdateTitle();
            MusicFile = null;
            FileName = null;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopTrack();
            if (!AllowUnsaved())
                e.Cancel = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!DoesControlAcceptInput(FindFocusedControl(this)))
            {
                if (keyData == Keys.Left)
                {
                    SeekTrack(-3);
                    return true;
                }
                if (keyData == Keys.Right)
                {
                    SeekTrack(+3);
                    return true;
                }
                if (keyData == (Keys.Shift | Keys.Left))
                {
                    SeekTrack(-30);
                    return true;
                }
                if (keyData == (Keys.Shift | Keys.Right))
                {
                    SeekTrack(+30);
                    return true;
                }
                if (keyData == Keys.Space)
                {
                    PlayPauseTrack();
                    return true;
                }
                if (keyData == Keys.Escape)
                {
                    StopTrack();
                    return true;
                }
                if (keyData == Keys.Return)
                {
                    NextLine();
                    return true;
                }
                if (keyData == Keys.B)
                {
                    AddBlankLine();
                    return true;
                }
                if (keyData == Keys.Q)
                {
                    RewindLines();
                    return true;
                }
                if (keyData == Keys.A)
                {
                    PreviousLine();
                    return true;
                }
                if (keyData == Keys.Z)
                {
                    UndoLine();
                    return true;
                }
                if (keyData == Keys.S)
                {
                    SkipLine();
                    return true;
                }
                if (keyData == Keys.D)
                {
                    MoveEarlier();
                    return true;
                }
                if (keyData == Keys.F)
                {
                    MoveLater();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonNextLine_Click(object sender, EventArgs e) => NextLine();
        private void buttonPrevLine_Click(object sender, EventArgs e) => PreviousLine();
        private void buttonSkipLine_Click(object sender, EventArgs e) => SkipLine();
        private void buttonUndoLine_Click(object sender, EventArgs e) => UndoLine();
        private void buttonAddBlank_Click(object sender, EventArgs e) => AddBlankLine();
        private void buttonLineRewind_Click(object sender, EventArgs e) => RewindLines();
        private void buttonEarlier_Click(object sender, EventArgs e) => MoveEarlier();
        private void buttonLater_Click(object sender, EventArgs e) => MoveLater();
        private void buttonJumpTo_Click(object sender, EventArgs e) => JumpToSelectedLine();

        private void textBoxOutput_Validating(object sender, CancelEventArgs e)
        {
            AdjustViaOutputTextBox();
        }

        private void timerEditUpdateElapsed_Tick(object sender, EventArgs e)
        {
            if (mp.HasMedia && mp.PlaybackState != CSCore.SoundOut.PlaybackState.Stopped)
            {
                this.toolStripStatusMediaSeek.Text = FormatSeekStatus(TimeSpanToDouble(mp.Position), TimeSpanToDouble(mp.Length), mp.PlaybackState);
                UpdateTrackBar();
            }
            else
            {
                this.toolStripStatusMediaSeek.Text = FormatSeekStatus(-1, mp.HasMedia ? TimeSpanToDouble(mp.Length) : - 1, mp.PlaybackState);
                timerEditUpdateElapsed.Stop();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ad = new AboutDialog();
            ad.ShowDialog(this);
        }

        private void keyboardHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayKeyboardHelp();
        }

        private void openFileDialogMusic_FileOk(object sender, CancelEventArgs e) => e.Cancel = !OpenMusicFile(openFileDialogMusic.FileName);
        private void openFileDialogTxt_FileOk(object sender, CancelEventArgs e) => e.Cancel = !OpenTxtFile(openFileDialogTxt.FileName);
        private void saveFileDialogTxt_FileOk(object sender, CancelEventArgs e) => e.Cancel = !SaveTxtFile(saveFileDialogTxt.FileName);

        private void newToolStripButton_Click(object sender, EventArgs e) { if (AllowUnsaved()) NewLyricsFile(); }
        private void openToolStripButton_Click(object sender, EventArgs e) { if (AllowUnsaved()) openFileDialogLrc.ShowDialog(this); }
        private void toolStripButtonOpenMusic_Click(object sender, EventArgs e) => openFileDialogMusic.ShowDialog(this);
        private void saveToolStripButton_Click(object sender, EventArgs e) => SaveFile();

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            DisplayKeyboardHelp();
        }

        private void buttonPlayPause_Click(object sender, EventArgs e) => PlayPauseTrack();
        private void buttonStopRewind_Click(object sender, EventArgs e) => StopTrack();
        private void buttonBack3_Click(object sender, EventArgs e) => SeekTrack(-3);
        private void buttonSkip3_Click(object sender, EventArgs e) => SeekTrack(3);
        private void buttonBack30_Click(object sender, EventArgs e) => SeekTrack(-30);
        private void buttonSkip30_Click(object sender, EventArgs e) => SeekTrack(30);
        private void buttonRewindAll_Click(object sender, EventArgs e) => SetTrackPosition(0);

        private void newToolStripMenuItem_Click(object sender, EventArgs e) { if (AllowUnsaved()) NewLyricsFile(); }
        private void openToolStripMenuItem_Click(object sender, EventArgs e) { if (AllowUnsaved()) openFileDialogLrc.ShowDialog(this); }
        private void openMusicToolStripMenuItem_Click(object sender, EventArgs e) => openFileDialogMusic.ShowDialog(this);
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile();
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) => saveFileDialogLrc.ShowDialog(this);
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { if (AllowUnsaved()) this.Close(); }

        private void closeMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTrack();
            mp.Close();
            MusicFile = null;
            timerEditUpdateElapsed.Start();
        }

        private void openFileDialogLrc_FileOk(object sender, CancelEventArgs e) => e.Cancel = !LoadLRCFrom(openFileDialogLrc.FileName);
        private void saveFileDialogLrc_FileOk(object sender, CancelEventArgs e) => e.Cancel = !SaveLRCTo(saveFileDialogLrc.FileName);

        private void toolStripButtonOpenTxt_Click(object sender, EventArgs e) => openFileDialogTxt.ShowDialog();
        private void toolStripButtonSaveTxt_Click(object sender, EventArgs e) => saveFileDialogTxt.ShowDialog();

        private void toolStripButtonAddLine_Click(object sender, EventArgs e) => AddNewLineToList();
        private void toolStripButtonDuplicateLine_Click(object sender, EventArgs e) => DuplicateLineInList();
        private void toolStripButtonDeleteLine_Click(object sender, EventArgs e) => RemoveLineFromList();
        private void toolStripButtonMoveUpLine_Click(object sender, EventArgs e) => MoveLineUpInList();
        private void toolStripButtonMoveDownLine_Click(object sender, EventArgs e) => MoveLineDownInList();
        private void toolStripButtonLinesClear_Click(object sender, EventArgs e) => listViewLines.Items.Clear();

        private void trackBarSeek_MouseDown(object sender, MouseEventArgs e)
        {
            trackBarPlayOnUp |= mp.PlaybackState == PlaybackState.Playing;
            if (trackBarPlayOnUp)
                mp.Pause();
        }

        private void trackBarSeek_MouseUp(object sender, MouseEventArgs e)
        {
            if (trackBarPlayOnUp)
            {
                mp.Play();
                timerEditUpdateElapsed.Start();
                if (mainTabControl.SelectedTab == tabPagePreview)
                    timerPreviewUpdateElapsed.Start();
            }
            trackBarPlayOnUp = false;
        }

        private void trackBarSeek_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarValueFilter)
            {
                bool pause = mp.PlaybackState == PlaybackState.Playing;
                if (pause) mp.Pause();
                mp.Position = DoubleToTimeSpan(trackBarSeek.Value / (double)trackBarSeek.TickFrequency);
                lrc.RescanIndex(TimeSpanToDouble(mp.Position));
                if (mainTabControl.SelectedTab == tabPagePreview) SelectLRCPreviewLine(lrc.CurrentIndex);
                if (pause)
                {
                    mp.Play();
                    timerEditUpdateElapsed.Start();
                    if (mainTabControl.SelectedTab == tabPagePreview)
                        timerPreviewUpdateElapsed.Start();
                }
            }
        }

        private void statusStrip_Click(object sender, EventArgs e)
        {
            statusStrip.Select();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustViaOutputTextBox();
            if (mainTabControl.SelectedTab == tabPageEdit)
                timerEditUpdateElapsed.Start();
            else if (mainTabControl.SelectedTab == tabPageMetadata)
                UpdateLRCMetadataControls();
            else if (mainTabControl.SelectedTab == tabPagePreview)
            {
                timerPreviewUpdateElapsed.Start();
                SelectLRCPreviewLine(lrc.CurrentIndex);
            }
        }

        private void timerPreviewUpdateElapsed_Tick(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab != tabPagePreview || !mp.HasMedia)
            {
                timerPreviewUpdateElapsed.Stop();
                return;
            }
            if (lrc.DidIndexChange(TimeSpanToDouble(mp.Position)))
                SelectLRCPreviewLine(lrc.CurrentIndex);
        }

        private void listViewLines_Click(object sender, EventArgs e) => listViewLines.Focus();
        private void listViewLines_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            listViewLines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void textBoxMetaArtist_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.Artist = textBoxMetaArtist.Text);
        private void textBoxMetaAlbum_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.Album = textBoxMetaAlbum.Text);
        private void textBoxMetaTitle_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.Title = textBoxMetaTitle.Text);
        private void textBoxMetaSongwriter_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.Songwriter = textBoxMetaSongwriter.Text);
        private void textBoxMetaLength_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.Length = textBoxMetaLength.Text);
        private void textBoxMetaLrcBy_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.LRCBy = textBoxMetaLrcBy.Text);
        private void textBoxMetaEditor_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.Editor = textBoxMetaEditor.Text);
        private void textBoxMetaEditorVersion_TextChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.EditorVersion = textBoxMetaEditorVersion.Text);
        private void numericUpDownMetaOffsetMs_ValueChanged(object sender, EventArgs e) => UpdateLRCOnMetadataChange(lrc.OffsetMs = (int)numericUpDownMetaOffsetMs.Value);
        private void buttonAutoFill_Click(object sender, EventArgs e) => SetAutoLRCMeta();

        private void toolStripButtonCopyToLyricList_Click(object sender, EventArgs e)
        {
            if (textBoxNotepad.Text != "")
                LoadLyricList(textBoxNotepad.Text.TrimEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None));
            else
                LoadLyricList(new string[] { });
            mainTabControl.SelectedTab = tabPageEdit;
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            outputTextBoxValueChanged = true;
            Unsaved = true;
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            mp.Volume = trackBarVolume.Value;
        }

        #endregion
    }
}
