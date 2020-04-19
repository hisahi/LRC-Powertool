namespace LRCPowertool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenMusic = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMediaSeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.splitContainerEditMainControls = new System.Windows.Forms.SplitContainer();
            this.splitContainerEditListOutput = new System.Windows.Forms.SplitContainer();
            this.listViewLines = new LRCPowertool.HeaderlessListView();
            this.columnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripTextLines = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenTxt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveTxt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDuplicateLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveUpLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveDownLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLinesClear = new System.Windows.Forms.ToolStripButton();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelEditControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNextLine = new System.Windows.Forms.Button();
            this.buttonAddBlank = new System.Windows.Forms.Button();
            this.buttonUndoLine = new System.Windows.Forms.Button();
            this.buttonPrevLine = new System.Windows.Forms.Button();
            this.buttonSkipLine = new System.Windows.Forms.Button();
            this.buttonLineRewind = new System.Windows.Forms.Button();
            this.buttonEarlier = new System.Windows.Forms.Button();
            this.buttonLater = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTimeOffset = new System.Windows.Forms.NumericUpDown();
            this.buttonJumpTo = new System.Windows.Forms.Button();
            this.tabPageMetadata = new System.Windows.Forms.TabPage();
            this.buttonAutoFill = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMetaLength = new System.Windows.Forms.TextBox();
            this.textBoxMetaSongwriter = new System.Windows.Forms.TextBox();
            this.textBoxMetaArtist = new System.Windows.Forms.TextBox();
            this.textBoxMetaAlbum = new System.Windows.Forms.TextBox();
            this.textBoxMetaTitle = new System.Windows.Forms.TextBox();
            this.textBoxMetaLrcBy = new System.Windows.Forms.TextBox();
            this.textBoxMetaEditor = new System.Windows.Forms.TextBox();
            this.textBoxMetaEditorVersion = new System.Windows.Forms.TextBox();
            this.numericUpDownMetaOffsetMs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPagePreview = new System.Windows.Forms.TabPage();
            this.textBoxPreviewLyrics = new System.Windows.Forms.TextBox();
            this.tabPageNotepad = new System.Windows.Forms.TabPage();
            this.textBoxNotepad = new System.Windows.Forms.TextBox();
            this.toolStripNotepad = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCopyToLyricList = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMainControls = new System.Windows.Forms.SplitContainer();
            this.labelVolume = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonRewindAll = new System.Windows.Forms.Button();
            this.buttonSkip30 = new System.Windows.Forms.Button();
            this.buttonBack30 = new System.Windows.Forms.Button();
            this.buttonSkip3 = new System.Windows.Forms.Button();
            this.buttonBack3 = new System.Windows.Forms.Button();
            this.buttonStopRewind = new System.Windows.Forms.Button();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.trackBarSeek = new System.Windows.Forms.TrackBar();
            this.timerEditUpdateElapsed = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogLrc = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogTxt = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogMusic = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogLrc = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogTxt = new System.Windows.Forms.SaveFileDialog();
            this.timerPreviewUpdateElapsed = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditMainControls)).BeginInit();
            this.splitContainerEditMainControls.Panel1.SuspendLayout();
            this.splitContainerEditMainControls.Panel2.SuspendLayout();
            this.splitContainerEditMainControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditListOutput)).BeginInit();
            this.splitContainerEditListOutput.Panel1.SuspendLayout();
            this.splitContainerEditListOutput.Panel2.SuspendLayout();
            this.splitContainerEditListOutput.SuspendLayout();
            this.toolStripTextLines.SuspendLayout();
            this.flowLayoutPanelEditControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeOffset)).BeginInit();
            this.tabPageMetadata.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetaOffsetMs)).BeginInit();
            this.tabPagePreview.SuspendLayout();
            this.tabPageNotepad.SuspendLayout();
            this.toolStripNotepad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainControls)).BeginInit();
            this.splitContainerMainControls.Panel1.SuspendLayout();
            this.splitContainerMainControls.Panel2.SuspendLayout();
            this.splitContainerMainControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenuStrip.Size = new System.Drawing.Size(724, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openMusicToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeMusicToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::LRCPowertool.Properties.Resources.iconnew;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::LRCPowertool.Properties.Resources.iconopen;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openMusicToolStripMenuItem
            // 
            this.openMusicToolStripMenuItem.Image = global::LRCPowertool.Properties.Resources.iconmusic;
            this.openMusicToolStripMenuItem.Name = "openMusicToolStripMenuItem";
            this.openMusicToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openMusicToolStripMenuItem.Text = "Select Music";
            this.openMusicToolStripMenuItem.Click += new System.EventHandler(this.openMusicToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::LRCPowertool.Properties.Resources.iconsave;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeMusicToolStripMenuItem
            // 
            this.closeMusicToolStripMenuItem.Name = "closeMusicToolStripMenuItem";
            this.closeMusicToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeMusicToolStripMenuItem.Text = "Close Music";
            this.closeMusicToolStripMenuItem.Click += new System.EventHandler(this.closeMusicToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyboardHelpToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // keyboardHelpToolStripMenuItem
            // 
            this.keyboardHelpToolStripMenuItem.Name = "keyboardHelpToolStripMenuItem";
            this.keyboardHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keyboardHelpToolStripMenuItem.Text = "&Keyboard Help";
            this.keyboardHelpToolStripMenuItem.Click += new System.EventHandler(this.keyboardHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.toolStripButtonOpenMusic,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.helpToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToolStrip.Size = new System.Drawing.Size(724, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::LRCPowertool.Properties.Resources.iconnew;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = global::LRCPowertool.Properties.Resources.iconopen;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open (Lyrics File)";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripButtonOpenMusic
            // 
            this.toolStripButtonOpenMusic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenMusic.Image = global::LRCPowertool.Properties.Resources.iconmusic;
            this.toolStripButtonOpenMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenMusic.Name = "toolStripButtonOpenMusic";
            this.toolStripButtonOpenMusic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenMusic.Text = "Select &Music";
            this.toolStripButtonOpenMusic.Click += new System.EventHandler(this.toolStripButtonOpenMusic_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::LRCPowertool.Properties.Resources.iconsave;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = global::LRCPowertool.Properties.Resources.iconhelp;
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Keyboard He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMediaSeek});
            this.statusStrip.Location = new System.Drawing.Point(0, 679);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(724, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Click += new System.EventHandler(this.statusStrip_Click);
            // 
            // toolStripStatusMediaSeek
            // 
            this.toolStripStatusMediaSeek.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusMediaSeek.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusMediaSeek.Name = "toolStripStatusMediaSeek";
            this.toolStripStatusMediaSeek.Size = new System.Drawing.Size(147, 17);
            this.toolStripStatusMediaSeek.Text = "--:-- / --:-- [STOP]";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageEdit);
            this.mainTabControl.Controls.Add(this.tabPageMetadata);
            this.mainTabControl.Controls.Add(this.tabPagePreview);
            this.mainTabControl.Controls.Add(this.tabPageNotepad);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(724, 542);
            this.mainTabControl.TabIndex = 3;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.splitContainerEditMainControls);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(716, 516);
            this.tabPageEdit.TabIndex = 0;
            this.tabPageEdit.Text = "Edit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // splitContainerEditMainControls
            // 
            this.splitContainerEditMainControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEditMainControls.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerEditMainControls.Location = new System.Drawing.Point(3, 3);
            this.splitContainerEditMainControls.Name = "splitContainerEditMainControls";
            this.splitContainerEditMainControls.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEditMainControls.Panel1
            // 
            this.splitContainerEditMainControls.Panel1.Controls.Add(this.splitContainerEditListOutput);
            // 
            // splitContainerEditMainControls.Panel2
            // 
            this.splitContainerEditMainControls.Panel2.Controls.Add(this.flowLayoutPanelEditControls);
            this.splitContainerEditMainControls.Size = new System.Drawing.Size(710, 510);
            this.splitContainerEditMainControls.SplitterDistance = 417;
            this.splitContainerEditMainControls.TabIndex = 0;
            // 
            // splitContainerEditListOutput
            // 
            this.splitContainerEditListOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEditListOutput.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEditListOutput.Name = "splitContainerEditListOutput";
            // 
            // splitContainerEditListOutput.Panel1
            // 
            this.splitContainerEditListOutput.Panel1.Controls.Add(this.listViewLines);
            this.splitContainerEditListOutput.Panel1.Controls.Add(this.toolStripTextLines);
            // 
            // splitContainerEditListOutput.Panel2
            // 
            this.splitContainerEditListOutput.Panel2.Controls.Add(this.textBoxOutput);
            this.splitContainerEditListOutput.Size = new System.Drawing.Size(710, 417);
            this.splitContainerEditListOutput.SplitterDistance = 349;
            this.splitContainerEditListOutput.TabIndex = 0;
            // 
            // listViewLines
            // 
            this.listViewLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderText});
            this.listViewLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLines.HideSelection = false;
            this.listViewLines.LabelEdit = true;
            this.listViewLines.Location = new System.Drawing.Point(0, 25);
            this.listViewLines.MultiSelect = false;
            this.listViewLines.Name = "listViewLines";
            this.listViewLines.Size = new System.Drawing.Size(349, 392);
            this.listViewLines.TabIndex = 0;
            this.listViewLines.UseCompatibleStateImageBehavior = false;
            this.listViewLines.View = System.Windows.Forms.View.Details;
            this.listViewLines.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewLines_AfterLabelEdit);
            this.listViewLines.Click += new System.EventHandler(this.listViewLines_Click);
            // 
            // columnHeaderText
            // 
            this.columnHeaderText.Text = "Text";
            this.columnHeaderText.Width = 326;
            // 
            // toolStripTextLines
            // 
            this.toolStripTextLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenTxt,
            this.toolStripButtonSaveTxt,
            this.toolStripSeparator8,
            this.toolStripButtonAddLine,
            this.toolStripButtonDuplicateLine,
            this.toolStripButtonDeleteLine,
            this.toolStripButtonMoveUpLine,
            this.toolStripButtonMoveDownLine,
            this.toolStripButtonLinesClear});
            this.toolStripTextLines.Location = new System.Drawing.Point(0, 0);
            this.toolStripTextLines.Name = "toolStripTextLines";
            this.toolStripTextLines.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripTextLines.Size = new System.Drawing.Size(349, 25);
            this.toolStripTextLines.TabIndex = 1;
            this.toolStripTextLines.Text = "toolStrip1";
            // 
            // toolStripButtonOpenTxt
            // 
            this.toolStripButtonOpenTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenTxt.Image = global::LRCPowertool.Properties.Resources.iconopen;
            this.toolStripButtonOpenTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenTxt.Name = "toolStripButtonOpenTxt";
            this.toolStripButtonOpenTxt.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenTxt.Text = "Import from Text File";
            this.toolStripButtonOpenTxt.Click += new System.EventHandler(this.toolStripButtonOpenTxt_Click);
            // 
            // toolStripButtonSaveTxt
            // 
            this.toolStripButtonSaveTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveTxt.Image = global::LRCPowertool.Properties.Resources.iconsave;
            this.toolStripButtonSaveTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveTxt.Name = "toolStripButtonSaveTxt";
            this.toolStripButtonSaveTxt.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveTxt.Text = "Export to Text File";
            this.toolStripButtonSaveTxt.Click += new System.EventHandler(this.toolStripButtonSaveTxt_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAddLine
            // 
            this.toolStripButtonAddLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddLine.Image")));
            this.toolStripButtonAddLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddLine.Name = "toolStripButtonAddLine";
            this.toolStripButtonAddLine.Size = new System.Drawing.Size(33, 22);
            this.toolStripButtonAddLine.Text = "Add";
            this.toolStripButtonAddLine.ToolTipText = "Add new line";
            this.toolStripButtonAddLine.Click += new System.EventHandler(this.toolStripButtonAddLine_Click);
            // 
            // toolStripButtonDuplicateLine
            // 
            this.toolStripButtonDuplicateLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDuplicateLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDuplicateLine.Image")));
            this.toolStripButtonDuplicateLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDuplicateLine.Name = "toolStripButtonDuplicateLine";
            this.toolStripButtonDuplicateLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDuplicateLine.Text = "x2";
            this.toolStripButtonDuplicateLine.ToolTipText = "Duplicate current line";
            this.toolStripButtonDuplicateLine.Click += new System.EventHandler(this.toolStripButtonDuplicateLine_Click);
            // 
            // toolStripButtonDeleteLine
            // 
            this.toolStripButtonDeleteLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteLine.Image")));
            this.toolStripButtonDeleteLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteLine.Name = "toolStripButtonDeleteLine";
            this.toolStripButtonDeleteLine.Size = new System.Drawing.Size(28, 22);
            this.toolStripButtonDeleteLine.Text = "Del";
            this.toolStripButtonDeleteLine.ToolTipText = "Delete current line";
            this.toolStripButtonDeleteLine.Click += new System.EventHandler(this.toolStripButtonDeleteLine_Click);
            // 
            // toolStripButtonMoveUpLine
            // 
            this.toolStripButtonMoveUpLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMoveUpLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveUpLine.Image")));
            this.toolStripButtonMoveUpLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveUpLine.Name = "toolStripButtonMoveUpLine";
            this.toolStripButtonMoveUpLine.Size = new System.Drawing.Size(26, 22);
            this.toolStripButtonMoveUpLine.Text = "Up";
            this.toolStripButtonMoveUpLine.ToolTipText = "Move current line up";
            this.toolStripButtonMoveUpLine.Click += new System.EventHandler(this.toolStripButtonMoveUpLine_Click);
            // 
            // toolStripButtonMoveDownLine
            // 
            this.toolStripButtonMoveDownLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMoveDownLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveDownLine.Image")));
            this.toolStripButtonMoveDownLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveDownLine.Name = "toolStripButtonMoveDownLine";
            this.toolStripButtonMoveDownLine.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonMoveDownLine.Text = "Down";
            this.toolStripButtonMoveDownLine.ToolTipText = "Move current line down";
            this.toolStripButtonMoveDownLine.Click += new System.EventHandler(this.toolStripButtonMoveDownLine_Click);
            // 
            // toolStripButtonLinesClear
            // 
            this.toolStripButtonLinesClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLinesClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLinesClear.Image")));
            this.toolStripButtonLinesClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLinesClear.Name = "toolStripButtonLinesClear";
            this.toolStripButtonLinesClear.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonLinesClear.Text = "Clear";
            this.toolStripButtonLinesClear.ToolTipText = "Remove all lines";
            this.toolStripButtonLinesClear.Click += new System.EventHandler(this.toolStripButtonLinesClear_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AcceptsReturn = true;
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.HideSelection = false;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(357, 417);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.WordWrap = false;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            this.textBoxOutput.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOutput_Validating);
            // 
            // flowLayoutPanelEditControls
            // 
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonNextLine);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonAddBlank);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonUndoLine);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonPrevLine);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonSkipLine);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonLineRewind);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonEarlier);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonLater);
            this.flowLayoutPanelEditControls.Controls.Add(this.label1);
            this.flowLayoutPanelEditControls.Controls.Add(this.numericUpDownTimeOffset);
            this.flowLayoutPanelEditControls.Controls.Add(this.buttonJumpTo);
            this.flowLayoutPanelEditControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEditControls.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelEditControls.Name = "flowLayoutPanelEditControls";
            this.flowLayoutPanelEditControls.Size = new System.Drawing.Size(710, 89);
            this.flowLayoutPanelEditControls.TabIndex = 0;
            // 
            // buttonNextLine
            // 
            this.buttonNextLine.Location = new System.Drawing.Point(3, 3);
            this.buttonNextLine.Name = "buttonNextLine";
            this.buttonNextLine.Size = new System.Drawing.Size(75, 23);
            this.buttonNextLine.TabIndex = 0;
            this.buttonNextLine.Text = "Next Line";
            this.buttonNextLine.UseVisualStyleBackColor = true;
            this.buttonNextLine.Click += new System.EventHandler(this.buttonNextLine_Click);
            // 
            // buttonAddBlank
            // 
            this.buttonAddBlank.Location = new System.Drawing.Point(84, 3);
            this.buttonAddBlank.Name = "buttonAddBlank";
            this.buttonAddBlank.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBlank.TabIndex = 1;
            this.buttonAddBlank.Text = "Add Blank";
            this.buttonAddBlank.UseVisualStyleBackColor = true;
            this.buttonAddBlank.Click += new System.EventHandler(this.buttonAddBlank_Click);
            // 
            // buttonUndoLine
            // 
            this.buttonUndoLine.Location = new System.Drawing.Point(165, 3);
            this.buttonUndoLine.Name = "buttonUndoLine";
            this.buttonUndoLine.Size = new System.Drawing.Size(75, 23);
            this.buttonUndoLine.TabIndex = 2;
            this.buttonUndoLine.Text = "Undo Line";
            this.buttonUndoLine.UseVisualStyleBackColor = true;
            this.buttonUndoLine.Click += new System.EventHandler(this.buttonUndoLine_Click);
            // 
            // buttonPrevLine
            // 
            this.buttonPrevLine.Location = new System.Drawing.Point(246, 3);
            this.buttonPrevLine.Name = "buttonPrevLine";
            this.buttonPrevLine.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevLine.TabIndex = 3;
            this.buttonPrevLine.Text = "Prev Line";
            this.buttonPrevLine.UseVisualStyleBackColor = true;
            this.buttonPrevLine.Click += new System.EventHandler(this.buttonPrevLine_Click);
            // 
            // buttonSkipLine
            // 
            this.buttonSkipLine.Location = new System.Drawing.Point(327, 3);
            this.buttonSkipLine.Name = "buttonSkipLine";
            this.buttonSkipLine.Size = new System.Drawing.Size(75, 23);
            this.buttonSkipLine.TabIndex = 4;
            this.buttonSkipLine.Text = "Skip Line";
            this.buttonSkipLine.UseVisualStyleBackColor = true;
            this.buttonSkipLine.Click += new System.EventHandler(this.buttonSkipLine_Click);
            // 
            // buttonLineRewind
            // 
            this.buttonLineRewind.Location = new System.Drawing.Point(408, 3);
            this.buttonLineRewind.Name = "buttonLineRewind";
            this.buttonLineRewind.Size = new System.Drawing.Size(75, 23);
            this.buttonLineRewind.TabIndex = 5;
            this.buttonLineRewind.Text = "Line Rewind";
            this.buttonLineRewind.UseVisualStyleBackColor = true;
            this.buttonLineRewind.Click += new System.EventHandler(this.buttonLineRewind_Click);
            // 
            // buttonEarlier
            // 
            this.buttonEarlier.Location = new System.Drawing.Point(489, 3);
            this.buttonEarlier.Name = "buttonEarlier";
            this.buttonEarlier.Size = new System.Drawing.Size(75, 23);
            this.buttonEarlier.TabIndex = 8;
            this.buttonEarlier.Text = "Earlier";
            this.buttonEarlier.UseVisualStyleBackColor = true;
            this.buttonEarlier.Click += new System.EventHandler(this.buttonEarlier_Click);
            // 
            // buttonLater
            // 
            this.flowLayoutPanelEditControls.SetFlowBreak(this.buttonLater, true);
            this.buttonLater.Location = new System.Drawing.Point(570, 3);
            this.buttonLater.Name = "buttonLater";
            this.buttonLater.Size = new System.Drawing.Size(75, 23);
            this.buttonLater.TabIndex = 9;
            this.buttonLater.Text = "Later";
            this.buttonLater.UseVisualStyleBackColor = true;
            this.buttonLater.Click += new System.EventHandler(this.buttonLater_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Offset (ms):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownTimeOffset
            // 
            this.numericUpDownTimeOffset.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownTimeOffset.Location = new System.Drawing.Point(85, 33);
            this.numericUpDownTimeOffset.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownTimeOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTimeOffset.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownTimeOffset.Name = "numericUpDownTimeOffset";
            this.numericUpDownTimeOffset.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownTimeOffset.TabIndex = 7;
            this.numericUpDownTimeOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTimeOffset.Value = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            // 
            // buttonJumpTo
            // 
            this.buttonJumpTo.Location = new System.Drawing.Point(165, 32);
            this.buttonJumpTo.Name = "buttonJumpTo";
            this.buttonJumpTo.Size = new System.Drawing.Size(75, 23);
            this.buttonJumpTo.TabIndex = 10;
            this.buttonJumpTo.Text = "Jump To";
            this.buttonJumpTo.UseVisualStyleBackColor = true;
            this.buttonJumpTo.Click += new System.EventHandler(this.buttonJumpTo_Click);
            // 
            // tabPageMetadata
            // 
            this.tabPageMetadata.AutoScroll = true;
            this.tabPageMetadata.Controls.Add(this.buttonAutoFill);
            this.tabPageMetadata.Controls.Add(this.tableLayoutPanel1);
            this.tabPageMetadata.Location = new System.Drawing.Point(4, 22);
            this.tabPageMetadata.Name = "tabPageMetadata";
            this.tabPageMetadata.Size = new System.Drawing.Size(646, 516);
            this.tabPageMetadata.TabIndex = 2;
            this.tabPageMetadata.Text = "Metadata";
            this.tabPageMetadata.UseVisualStyleBackColor = true;
            // 
            // buttonAutoFill
            // 
            this.buttonAutoFill.Location = new System.Drawing.Point(345, 289);
            this.buttonAutoFill.Name = "buttonAutoFill";
            this.buttonAutoFill.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoFill.TabIndex = 9;
            this.buttonAutoFill.Text = "Auto-Fill";
            this.buttonAutoFill.UseVisualStyleBackColor = true;
            this.buttonAutoFill.Click += new System.EventHandler(this.buttonAutoFill_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaLength, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaSongwriter, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaArtist, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaAlbum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaLrcBy, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaEditor, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetaEditorVersion, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMetaOffsetMs, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Editor Version";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Editor Program";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Global Offset (ms)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "LRC File made by";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Track Length";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lyricist";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Title";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Album";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMetaLength
            // 
            this.textBoxMetaLength.Location = new System.Drawing.Point(103, 127);
            this.textBoxMetaLength.Name = "textBoxMetaLength";
            this.textBoxMetaLength.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaLength.TabIndex = 4;
            this.textBoxMetaLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMetaLength.TextChanged += new System.EventHandler(this.textBoxMetaLength_TextChanged);
            // 
            // textBoxMetaSongwriter
            // 
            this.textBoxMetaSongwriter.Location = new System.Drawing.Point(103, 96);
            this.textBoxMetaSongwriter.Name = "textBoxMetaSongwriter";
            this.textBoxMetaSongwriter.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaSongwriter.TabIndex = 3;
            this.textBoxMetaSongwriter.TextChanged += new System.EventHandler(this.textBoxMetaSongwriter_TextChanged);
            // 
            // textBoxMetaArtist
            // 
            this.textBoxMetaArtist.Location = new System.Drawing.Point(103, 3);
            this.textBoxMetaArtist.Name = "textBoxMetaArtist";
            this.textBoxMetaArtist.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaArtist.TabIndex = 0;
            this.textBoxMetaArtist.TextChanged += new System.EventHandler(this.textBoxMetaArtist_TextChanged);
            // 
            // textBoxMetaAlbum
            // 
            this.textBoxMetaAlbum.Location = new System.Drawing.Point(103, 34);
            this.textBoxMetaAlbum.Name = "textBoxMetaAlbum";
            this.textBoxMetaAlbum.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaAlbum.TabIndex = 1;
            this.textBoxMetaAlbum.TextChanged += new System.EventHandler(this.textBoxMetaAlbum_TextChanged);
            // 
            // textBoxMetaTitle
            // 
            this.textBoxMetaTitle.Location = new System.Drawing.Point(103, 65);
            this.textBoxMetaTitle.Name = "textBoxMetaTitle";
            this.textBoxMetaTitle.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaTitle.TabIndex = 2;
            this.textBoxMetaTitle.TextChanged += new System.EventHandler(this.textBoxMetaTitle_TextChanged);
            // 
            // textBoxMetaLrcBy
            // 
            this.textBoxMetaLrcBy.Location = new System.Drawing.Point(103, 158);
            this.textBoxMetaLrcBy.Name = "textBoxMetaLrcBy";
            this.textBoxMetaLrcBy.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaLrcBy.TabIndex = 5;
            this.textBoxMetaLrcBy.TextChanged += new System.EventHandler(this.textBoxMetaLrcBy_TextChanged);
            // 
            // textBoxMetaEditor
            // 
            this.textBoxMetaEditor.Location = new System.Drawing.Point(103, 220);
            this.textBoxMetaEditor.Name = "textBoxMetaEditor";
            this.textBoxMetaEditor.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaEditor.TabIndex = 7;
            this.textBoxMetaEditor.TextChanged += new System.EventHandler(this.textBoxMetaEditor_TextChanged);
            // 
            // textBoxMetaEditorVersion
            // 
            this.textBoxMetaEditorVersion.Location = new System.Drawing.Point(103, 251);
            this.textBoxMetaEditorVersion.Name = "textBoxMetaEditorVersion";
            this.textBoxMetaEditorVersion.Size = new System.Drawing.Size(314, 20);
            this.textBoxMetaEditorVersion.TabIndex = 8;
            this.textBoxMetaEditorVersion.TextChanged += new System.EventHandler(this.textBoxMetaEditorVersion_TextChanged);
            // 
            // numericUpDownMetaOffsetMs
            // 
            this.numericUpDownMetaOffsetMs.Location = new System.Drawing.Point(103, 189);
            this.numericUpDownMetaOffsetMs.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownMetaOffsetMs.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMetaOffsetMs.Name = "numericUpDownMetaOffsetMs";
            this.numericUpDownMetaOffsetMs.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMetaOffsetMs.TabIndex = 6;
            this.numericUpDownMetaOffsetMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMetaOffsetMs.ValueChanged += new System.EventHandler(this.numericUpDownMetaOffsetMs_ValueChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artist";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPagePreview
            // 
            this.tabPagePreview.Controls.Add(this.textBoxPreviewLyrics);
            this.tabPagePreview.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreview.Name = "tabPagePreview";
            this.tabPagePreview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreview.Size = new System.Drawing.Size(646, 516);
            this.tabPagePreview.TabIndex = 1;
            this.tabPagePreview.Text = "Preview";
            this.tabPagePreview.UseVisualStyleBackColor = true;
            // 
            // textBoxPreviewLyrics
            // 
            this.textBoxPreviewLyrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPreviewLyrics.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreviewLyrics.HideSelection = false;
            this.textBoxPreviewLyrics.Location = new System.Drawing.Point(3, 3);
            this.textBoxPreviewLyrics.Multiline = true;
            this.textBoxPreviewLyrics.Name = "textBoxPreviewLyrics";
            this.textBoxPreviewLyrics.ReadOnly = true;
            this.textBoxPreviewLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPreviewLyrics.Size = new System.Drawing.Size(640, 510);
            this.textBoxPreviewLyrics.TabIndex = 0;
            this.textBoxPreviewLyrics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageNotepad
            // 
            this.tabPageNotepad.Controls.Add(this.textBoxNotepad);
            this.tabPageNotepad.Controls.Add(this.toolStripNotepad);
            this.tabPageNotepad.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotepad.Name = "tabPageNotepad";
            this.tabPageNotepad.Size = new System.Drawing.Size(646, 516);
            this.tabPageNotepad.TabIndex = 3;
            this.tabPageNotepad.Text = "Notepad";
            this.tabPageNotepad.UseVisualStyleBackColor = true;
            // 
            // textBoxNotepad
            // 
            this.textBoxNotepad.AcceptsReturn = true;
            this.textBoxNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNotepad.Location = new System.Drawing.Point(0, 25);
            this.textBoxNotepad.Multiline = true;
            this.textBoxNotepad.Name = "textBoxNotepad";
            this.textBoxNotepad.Size = new System.Drawing.Size(646, 491);
            this.textBoxNotepad.TabIndex = 0;
            // 
            // toolStripNotepad
            // 
            this.toolStripNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCopyToLyricList});
            this.toolStripNotepad.Location = new System.Drawing.Point(0, 0);
            this.toolStripNotepad.Name = "toolStripNotepad";
            this.toolStripNotepad.Size = new System.Drawing.Size(646, 25);
            this.toolStripNotepad.TabIndex = 1;
            this.toolStripNotepad.Text = "toolStrip1";
            // 
            // toolStripButtonCopyToLyricList
            // 
            this.toolStripButtonCopyToLyricList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCopyToLyricList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyToLyricList.Image")));
            this.toolStripButtonCopyToLyricList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyToLyricList.Name = "toolStripButtonCopyToLyricList";
            this.toolStripButtonCopyToLyricList.Size = new System.Drawing.Size(96, 22);
            this.toolStripButtonCopyToLyricList.Text = "Copy to lyric list";
            this.toolStripButtonCopyToLyricList.Click += new System.EventHandler(this.toolStripButtonCopyToLyricList_Click);
            // 
            // splitContainerMainControls
            // 
            this.splitContainerMainControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainControls.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMainControls.IsSplitterFixed = true;
            this.splitContainerMainControls.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMainControls.Name = "splitContainerMainControls";
            this.splitContainerMainControls.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainControls.Panel1
            // 
            this.splitContainerMainControls.Panel1.Controls.Add(this.mainTabControl);
            // 
            // splitContainerMainControls.Panel2
            // 
            this.splitContainerMainControls.Panel2.Controls.Add(this.labelVolume);
            this.splitContainerMainControls.Panel2.Controls.Add(this.trackBarVolume);
            this.splitContainerMainControls.Panel2.Controls.Add(this.buttonRewindAll);
            this.splitContainerMainControls.Panel2.Controls.Add(this.buttonSkip30);
            this.splitContainerMainControls.Panel2.Controls.Add(this.buttonBack30);
            this.splitContainerMainControls.Panel2.Controls.Add(this.buttonSkip3);
            this.splitContainerMainControls.Panel2.Controls.Add(this.buttonBack3);
            this.splitContainerMainControls.Panel2.Controls.Add(this.buttonStopRewind);
            this.splitContainerMainControls.Panel2.Controls.Add(this.buttonPlayPause);
            this.splitContainerMainControls.Panel2.Controls.Add(this.trackBarSeek);
            this.splitContainerMainControls.Size = new System.Drawing.Size(724, 630);
            this.splitContainerMainControls.SplitterDistance = 542;
            this.splitContainerMainControls.TabIndex = 0;
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.Location = new System.Drawing.Point(601, 3);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(30, 23);
            this.labelVolume.TabIndex = 9;
            this.labelVolume.Text = "VOL";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.LargeChange = 20;
            this.trackBarVolume.Location = new System.Drawing.Point(627, 3);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(97, 45);
            this.trackBarVolume.SmallChange = 5;
            this.trackBarVolume.TabIndex = 8;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // buttonRewindAll
            // 
            this.buttonRewindAll.Location = new System.Drawing.Point(293, 2);
            this.buttonRewindAll.Name = "buttonRewindAll";
            this.buttonRewindAll.Size = new System.Drawing.Size(33, 23);
            this.buttonRewindAll.TabIndex = 7;
            this.buttonRewindAll.Text = "<<";
            this.buttonRewindAll.UseVisualStyleBackColor = true;
            this.buttonRewindAll.Click += new System.EventHandler(this.buttonRewindAll_Click);
            // 
            // buttonSkip30
            // 
            this.buttonSkip30.Location = new System.Drawing.Point(254, 2);
            this.buttonSkip30.Name = "buttonSkip30";
            this.buttonSkip30.Size = new System.Drawing.Size(33, 23);
            this.buttonSkip30.TabIndex = 6;
            this.buttonSkip30.Text = "+30";
            this.buttonSkip30.UseVisualStyleBackColor = true;
            this.buttonSkip30.Click += new System.EventHandler(this.buttonSkip30_Click);
            // 
            // buttonBack30
            // 
            this.buttonBack30.Location = new System.Drawing.Point(215, 2);
            this.buttonBack30.Name = "buttonBack30";
            this.buttonBack30.Size = new System.Drawing.Size(33, 23);
            this.buttonBack30.TabIndex = 5;
            this.buttonBack30.Text = "-30";
            this.buttonBack30.UseVisualStyleBackColor = true;
            this.buttonBack30.Click += new System.EventHandler(this.buttonBack30_Click);
            // 
            // buttonSkip3
            // 
            this.buttonSkip3.Location = new System.Drawing.Point(176, 2);
            this.buttonSkip3.Name = "buttonSkip3";
            this.buttonSkip3.Size = new System.Drawing.Size(33, 23);
            this.buttonSkip3.TabIndex = 4;
            this.buttonSkip3.Text = "+3";
            this.buttonSkip3.UseVisualStyleBackColor = true;
            this.buttonSkip3.Click += new System.EventHandler(this.buttonSkip3_Click);
            // 
            // buttonBack3
            // 
            this.buttonBack3.Location = new System.Drawing.Point(137, 3);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(33, 23);
            this.buttonBack3.TabIndex = 3;
            this.buttonBack3.Text = "-3";
            this.buttonBack3.UseVisualStyleBackColor = true;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // buttonStopRewind
            // 
            this.buttonStopRewind.Location = new System.Drawing.Point(88, 3);
            this.buttonStopRewind.Name = "buttonStopRewind";
            this.buttonStopRewind.Size = new System.Drawing.Size(43, 23);
            this.buttonStopRewind.TabIndex = 2;
            this.buttonStopRewind.Text = "Stop";
            this.buttonStopRewind.UseVisualStyleBackColor = true;
            this.buttonStopRewind.Click += new System.EventHandler(this.buttonStopRewind_Click);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Location = new System.Drawing.Point(7, 3);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayPause.TabIndex = 1;
            this.buttonPlayPause.Text = "Play/Pause";
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // trackBarSeek
            // 
            this.trackBarSeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSeek.Enabled = false;
            this.trackBarSeek.Location = new System.Drawing.Point(0, 32);
            this.trackBarSeek.Maximum = 0;
            this.trackBarSeek.Name = "trackBarSeek";
            this.trackBarSeek.Size = new System.Drawing.Size(724, 45);
            this.trackBarSeek.TabIndex = 0;
            this.trackBarSeek.TickFrequency = 16;
            this.trackBarSeek.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSeek.ValueChanged += new System.EventHandler(this.trackBarSeek_ValueChanged);
            this.trackBarSeek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarSeek_MouseDown);
            this.trackBarSeek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarSeek_MouseUp);
            // 
            // timerEditUpdateElapsed
            // 
            this.timerEditUpdateElapsed.Enabled = true;
            this.timerEditUpdateElapsed.Interval = 20;
            this.timerEditUpdateElapsed.Tick += new System.EventHandler(this.timerEditUpdateElapsed_Tick);
            // 
            // openFileDialogLrc
            // 
            this.openFileDialogLrc.Filter = "Lyrics files (*.lrc)|*.lrc|All files|*.*";
            this.openFileDialogLrc.Title = "Open LRC file";
            this.openFileDialogLrc.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLrc_FileOk);
            // 
            // openFileDialogTxt
            // 
            this.openFileDialogTxt.Filter = "Text files (*.txt)|*.txt|All files|*.*";
            this.openFileDialogTxt.Title = "Open TXT file";
            this.openFileDialogTxt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogTxt_FileOk);
            // 
            // openFileDialogMusic
            // 
            this.openFileDialogMusic.Filter = "Music files|*.mp3;*.flac;*.wav;*.ogg;*.opus;*.m4a|All files|*.*";
            this.openFileDialogMusic.Title = "Open music file";
            this.openFileDialogMusic.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogMusic_FileOk);
            // 
            // saveFileDialogLrc
            // 
            this.saveFileDialogLrc.Filter = "Lyrics files (*.lrc)|*.lrc|All files|*.*";
            this.saveFileDialogLrc.Title = "Save LRC file";
            this.saveFileDialogLrc.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogLrc_FileOk);
            // 
            // saveFileDialogTxt
            // 
            this.saveFileDialogTxt.Filter = "Text files (*.txt)|*.txt|All files|*.*";
            this.saveFileDialogTxt.Title = "Save TXT file";
            this.saveFileDialogTxt.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogTxt_FileOk);
            // 
            // timerPreviewUpdateElapsed
            // 
            this.timerPreviewUpdateElapsed.Enabled = true;
            this.timerPreviewUpdateElapsed.Interval = 10;
            this.timerPreviewUpdateElapsed.Tick += new System.EventHandler(this.timerPreviewUpdateElapsed_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 701);
            this.Controls.Add(this.splitContainerMainControls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = global::LRCPowertool.Properties.Resources.iconmain;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(470, 420);
            this.Name = "MainForm";
            this.Text = "LRC Powertool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPageEdit.ResumeLayout(false);
            this.splitContainerEditMainControls.Panel1.ResumeLayout(false);
            this.splitContainerEditMainControls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditMainControls)).EndInit();
            this.splitContainerEditMainControls.ResumeLayout(false);
            this.splitContainerEditListOutput.Panel1.ResumeLayout(false);
            this.splitContainerEditListOutput.Panel1.PerformLayout();
            this.splitContainerEditListOutput.Panel2.ResumeLayout(false);
            this.splitContainerEditListOutput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditListOutput)).EndInit();
            this.splitContainerEditListOutput.ResumeLayout(false);
            this.toolStripTextLines.ResumeLayout(false);
            this.toolStripTextLines.PerformLayout();
            this.flowLayoutPanelEditControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeOffset)).EndInit();
            this.tabPageMetadata.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetaOffsetMs)).EndInit();
            this.tabPagePreview.ResumeLayout(false);
            this.tabPagePreview.PerformLayout();
            this.tabPageNotepad.ResumeLayout(false);
            this.tabPageNotepad.PerformLayout();
            this.toolStripNotepad.ResumeLayout(false);
            this.toolStripNotepad.PerformLayout();
            this.splitContainerMainControls.Panel1.ResumeLayout(false);
            this.splitContainerMainControls.Panel2.ResumeLayout(false);
            this.splitContainerMainControls.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainControls)).EndInit();
            this.splitContainerMainControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyboardHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.TabPage tabPagePreview;
        private System.Windows.Forms.ToolStripMenuItem openMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenMusic;
        private System.Windows.Forms.SplitContainer splitContainerMainControls;
        private System.Windows.Forms.SplitContainer splitContainerEditListOutput;
        private System.Windows.Forms.SplitContainer splitContainerEditMainControls;
        private LRCPowertool.HeaderlessListView listViewLines;
        private System.Windows.Forms.ToolStrip toolStripTextLines;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenTxt;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonDuplicateLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveUpLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveDownLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEditControls;
        private System.Windows.Forms.Button buttonNextLine;
        private System.Windows.Forms.Button buttonPrevLine;
        private System.Windows.Forms.Button buttonSkipLine;
        private System.Windows.Forms.Button buttonLineRewind;
        private System.Windows.Forms.Button buttonRewindAll;
        private System.Windows.Forms.Button buttonSkip30;
        private System.Windows.Forms.Button buttonBack30;
        private System.Windows.Forms.Button buttonSkip3;
        private System.Windows.Forms.Button buttonBack3;
        private System.Windows.Forms.Button buttonStopRewind;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.TrackBar trackBarSeek;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMediaSeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeOffset;
        private System.Windows.Forms.Button buttonUndoLine;
        private System.Windows.Forms.Button buttonAddBlank;
        private System.Windows.Forms.Timer timerEditUpdateElapsed;
        private System.Windows.Forms.OpenFileDialog openFileDialogLrc;
        private System.Windows.Forms.OpenFileDialog openFileDialogTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialogMusic;
        private System.Windows.Forms.SaveFileDialog saveFileDialogLrc;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTxt;
        private System.Windows.Forms.ToolStripMenuItem closeMusicToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageMetadata;
        private System.Windows.Forms.TextBox textBoxPreviewLyrics;
        private System.Windows.Forms.Timer timerPreviewUpdateElapsed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxMetaArtist;
        private System.Windows.Forms.TextBox textBoxMetaLength;
        private System.Windows.Forms.TextBox textBoxMetaSongwriter;
        private System.Windows.Forms.TextBox textBoxMetaAlbum;
        private System.Windows.Forms.TextBox textBoxMetaTitle;
        private System.Windows.Forms.TextBox textBoxMetaLrcBy;
        private System.Windows.Forms.TextBox textBoxMetaEditor;
        private System.Windows.Forms.TextBox textBoxMetaEditorVersion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMetaOffsetMs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeaderText;
        private System.Windows.Forms.ToolStripButton toolStripButtonLinesClear;
        private System.Windows.Forms.Button buttonAutoFill;
        private System.Windows.Forms.Button buttonEarlier;
        private System.Windows.Forms.Button buttonLater;
        private System.Windows.Forms.TabPage tabPageNotepad;
        private System.Windows.Forms.TextBox textBoxNotepad;
        private System.Windows.Forms.ToolStrip toolStripNotepad;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyToLyricList;
        private System.Windows.Forms.Button buttonJumpTo;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TrackBar trackBarVolume;
    }
}