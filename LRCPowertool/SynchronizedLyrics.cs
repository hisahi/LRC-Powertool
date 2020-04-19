using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LRCPowertool
{
    public class SynchronizedLyrics
    {
        private int currentIndex;
        private List<double> lineTimes;
        private List<string> lineTexts;
        private List<int> lineIndexes;

        public string Artist = null;
        public string Album = null;
        public string Title = null;
        public string Songwriter = null;
        public string Length = null;
        public string LRCBy = null;
        public int? OffsetMs = null;
        public string Editor = null;
        public string EditorVersion = null;

        public SynchronizedLyrics()
        {
            lineTimes = new List<double>();
            lineTexts = new List<string>();
            RecomputeIndexes();
            ResetIndex();
        }

        // import existing LRC
        public SynchronizedLyrics(string lrcFile)
        {
            ImportText(lrcFile);
            ResetIndex();
        }

        // parse Int32, or return fallback avlue
        private static int ParseIntOr(string number, int fallback)
        {
            if (Int32.TryParse(number, out int result))
                return result;
            else
                return fallback;
        }

        public double Offset => (OffsetMs ?? 0) * 0.001;

        public string RawText => Export(Environment.NewLine, false);
        public string Export() => Export("\n", true);

        public int GetSelectionStart(int index) => index >= 0 ? (index < lineTexts.Count ? lineIndexes[index] : lineIndexes[lineTexts.Count]) : 0;
        public int GetSelectionLength(int index) => index >= 0 && index < lineTexts.Count ? GetSelectionStart(index + 1) - GetSelectionStart(index) - Environment.NewLine.Length : 0;
        public double GetLyricTime(int index) => lineTimes[index];
        public string GetText(int index) => lineTexts[index];

        public int CurrentIndex => currentIndex;
        public int LineCount => lineTimes.Count;
        public string PreviewText => string.Join(Environment.NewLine, lineTexts);

        public int SelectionStart => GetSelectionStart(CurrentIndex);
        public int SelectionLength => GetSelectionLength(CurrentIndex);

        // recompute starting/ending indexes for .PreviewText
        private void RecomputeIndexes()
        {
            List<int> indexes = new List<int>();

            int currentIndex = 0;
            foreach (string line in lineTexts)
            {
                indexes.Add(currentIndex);
                currentIndex += line.Length + Environment.NewLine.Length;
            }
            indexes.Add(currentIndex);

            lineIndexes = indexes;
            Debug.Assert(lineTimes.Count == lineIndexes.Count - 1);
        }

        internal void ImportText(string text)
        {
            char[] bracketRight = new char[] { ']' };
            char[] colon = new char[] { ':' };
            string[] lines = text.Replace("\r", "").Split('\n');
            string currentLine = null;

            List<double> times = new List<double>();
            List<string> texts = new List<string>();

            foreach (string line in lines)
            {
                string xline = line.TrimStart();
                if (LineStartsWithLRCTime(xline))
                {
                    if (currentLine != null)
                        texts.Add(currentLine);

                    xline = xline.Substring(1); // remove '['
                    string[] tok = xline.Split(bracketRight, 2);
                    times.Add(ConvertFromLRCTime(tok[0]));
                    currentLine = tok[1].TrimStart();
                }
                else if (xline.StartsWith("[") && xline.EndsWith("]") && xline.Contains(":") && currentLine == null) // metadata
                {
                    xline = xline.Substring(1, xline.Length - 2).Trim(); // remove '[', ']'
                    string[] tok = xline.Split(colon, 2);
                    switch (tok[0])
                    {
                        case "ar": Artist = tok[1]; break;
                        case "al": Album = tok[1]; break;
                        case "ti": Title = tok[1]; break;
                        case "au": Songwriter = tok[1]; break;
                        case "length": Length = tok[1]; break;
                        case "by": LRCBy = tok[1]; break;
                        case "offset": OffsetMs = ParseIntOr(tok[1], 0); break;
                        case "re": Editor = tok[1]; break;
                        case "ve": EditorVersion = tok[1]; break;
                    }
                }
                else if (line.Length > 0 && currentLine != null)
                {
                    currentLine += "\n" + line;
                }
            }
            if (currentLine != null)
                texts.Add(currentLine);

            lineTimes = times;
            lineTexts = texts;
            Debug.Assert(lineTimes.Count == lineTexts.Count);
            RecomputeIndexes();
        }

        public int AddLine(double time, string line)
        {
            int addIndex = 0;
            while (addIndex < lineTimes.Count && time >= lineTimes[addIndex])
                ++addIndex;
            lineTimes.Insert(addIndex, time);
            lineTexts.Insert(addIndex, line);
            RecomputeIndexes();
            return addIndex;
        }

        public void RemoveLine(int index)
        {
            if (index >= 0 && index < lineTimes.Count)
            {
                lineTimes.RemoveAt(index);
                lineTexts.RemoveAt(index);
                RecomputeIndexes();
            }
        }

        private static readonly Regex lrcTimeValid = new Regex(@"^(\d{1,5}):(\d{2})\.(\d{2})$");
        private static bool IsValidLRCTime(string time)
        {
            return lrcTimeValid.Match(time).Success;
        }

        public static double ConvertFromLRCTime(string time)
        {
            Match reMatch = lrcTimeValid.Match(time);
            if (!reMatch.Success) throw new ArgumentException("Not a valid LRC time");
            int minutes = Int32.Parse(reMatch.Groups[1].Value);
            int seconds = Int32.Parse(reMatch.Groups[2].Value);
            int hundredths = Int32.Parse(reMatch.Groups[3].Value);
            return minutes * 60 + seconds + hundredths * 0.01;
        }

        public static string ConvertToLRCTime(double time)
        {
            int timeSeconds = (int)time;
            int timeHundredths = (int)(time * 100) % 100;
            return (timeSeconds / 60).ToString("D2") + ":" + (timeSeconds % 60).ToString("D2") + "." + timeHundredths.ToString("D2");
        }

        private static bool LineStartsWithLRCTime(string xline)
        {
            int endBracket = xline.IndexOf(']');
            return xline.StartsWith("[") && endBracket > 0 && IsValidLRCTime(xline.Substring(1, endBracket - 1));
        }

        public void ResetIndex()
        {
            currentIndex = -1;
        }

        public void RescanIndex(double elapsed)
        {
            currentIndex = -1;
            DidIndexChange(elapsed);
        }

        private int ReinsertSortForwards(int line)
        {
            double currentTime = lineTimes[line];
            string currentText = lineTexts[line];
            while (line < lineTimes.Count - 1 && currentTime > lineTimes[line + 1])
            {
                lineTimes[line] = lineTimes[line + 1];
                lineTexts[line] = lineTexts[line + 1];
                ++line;
            }
            lineTimes[line] = currentTime;
            lineTexts[line] = currentText;
            RecomputeIndexes();
            return line;
        }

        private int ReinsertSortBackwards(int line)
        {
            double currentTime = lineTimes[line];
            string currentText = lineTexts[line];
            while (line > 0 && currentTime < lineTimes[line - 1])
            {
                lineTimes[line] = lineTimes[line - 1];
                lineTexts[line] = lineTexts[line - 1];
                --line;
            }
            lineTimes[line] = currentTime;
            lineTexts[line] = currentText;
            RecomputeIndexes();
            return line;
        }

        public int ShiftLine(int line, double v)
        {
            lineTimes[line] = Math.Max(0, lineTimes[line] + v);
            if (v > 0)
                return ReinsertSortForwards(line);
            else if (v < 0)
                return ReinsertSortBackwards(line);
            else
                return line;
        }

        public bool DidIndexChange(double elapsed)
        {
            if (CurrentIndex >= lineTexts.Count)
                return false;
            int newIndex = currentIndex;
            double offset = Offset;

            while ((newIndex + 1) < lineTimes.Count && (elapsed - Offset) >= lineTimes[newIndex + 1])
            {
                ++newIndex;
            }

            bool changed = currentIndex != newIndex;
            currentIndex = newIndex;
            return changed;
        }

        private string ExportMetadata()
        {
            List<string> lines = new List<string>();
            string offsetStr = (OffsetMs ?? 0).ToString("+0;-#"); // number always with sign

            if (Artist?.Length > 0) lines.Add($"[ar:{Artist}]");
            if (Album?.Length > 0) lines.Add($"[al:{Album}]");
            if (Title?.Length > 0) lines.Add($"[ti:{Title}]");
            if (Songwriter?.Length > 0) lines.Add($"[au:{Songwriter}]");
            if (Length?.Length > 0) lines.Add($"[length:{Length}]");
            if (LRCBy?.Length > 0) lines.Add($"[by:{LRCBy}]");
            if ((OffsetMs ?? 0) != 0) lines.Add($"[offset:{offsetStr}]");
            if (Editor?.Length > 0) lines.Add($"[re:{Editor}]");
            if (EditorVersion?.Length > 0) lines.Add($"[ve:{EditorVersion}]");
            return lines.Count > 0 ? string.Join("\n", lines) + "\n\n" : "";
        }

        private string Export(string newline, bool includeMetadata)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < lineTimes.Count; ++i)
            {
                result.Add("[" + ConvertToLRCTime(lineTimes[i]) + "] " + lineTexts[i]);
            }
            return (includeMetadata ? ExportMetadata() : "") + string.Join(newline, result);
        }
    }
}
