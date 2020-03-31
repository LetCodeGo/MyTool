using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace MyTool
{
    public partial class TextProcessControl : UserControl
    {
        private Encoding textEncodingSelected = null;
        private TextEncodingSelectForm.EncodingSelectForNoBom encodingSelectForNoBom =
            TextEncodingSelectForm.EncodingSelectForNoBom.OK;

        private string strLog = string.Empty;

        private Action CheckBoxTopMostNoChecked = null;
        private Action CheckBoxTopMostRestoreChecked = null;

        public TextProcessControl(
            Action CheckBoxTopMostNoChecked, Action CheckBoxTopMostRestoreChecked)
        {
            InitializeComponent();

            this.CheckBoxTopMostNoChecked = CheckBoxTopMostNoChecked;
            this.CheckBoxTopMostRestoreChecked = CheckBoxTopMostRestoreChecked;
        }

        private void TextProcessControl_Load(object sender, EventArgs e)
        {
            this.cbCUEAssociatedFileExtension.SelectedIndex = 0;
        }

        private void buttonText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void buttonText_DragDrop(object sender, DragEventArgs e)
        {
            string[] dragFileOrFolderPaths = e.Data.GetData("FileDrop") as string[];
            List<string> fileList = null;
            if (this.cbNoLimit.Checked)
            {
                fileList = new List<string>();
                foreach (string strPath in dragFileOrFolderPaths)
                {
                    if (File.Exists(strPath))
                    {
                        bool suffixMatched = false;
                        string[] suffixArray = "*.txt|*.srt|*.ass|*.ssa|*.cue".
                            Split(new char[] { '|', '*' });
                        string strTemp = strPath.ToLower();
                        foreach (string suffix in suffixArray)
                        {
                            if (strTemp.EndsWith(suffix))
                            {
                                suffixMatched = true;
                                break;
                            }
                        }
                        if (suffixMatched) fileList.Add(strPath);
                    }
                    else
                    {
                        fileList.AddRange(Directory.GetFiles(
                            strPath,
                            "*.txt|*.srt|*.ass|*.ssa|*.cue",
                            this.radioButtonTopDirectoryOnly.Checked ?
                            SearchOption.TopDirectoryOnly :
                            SearchOption.AllDirectories));
                    }
                }
            }
            else
            {
                fileList = GetFileOrFolder.GetFilesFromPathList(
                    e.Data.GetData("FileDrop") as string[],
                    Setting.GetInstance().GetCurrentMatchRule(),
                    this.radioButtonTopDirectoryOnly.Checked ?
                    GetFileOrFolder.GetFileFromDirectoryType.TOP_DIRECTORY_ONLY :
                    GetFileOrFolder.GetFileFromDirectoryType.ALL_DIRECTORIES);
            }

            DealWithFiles(fileList, false);
        }

        private void buttonCUE_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void buttonCUE_DragDrop(object sender, DragEventArgs e)
        {
            string[] dragFileOrFolderPaths = e.Data.GetData("FileDrop") as string[];

            List<string> fileList = new List<string>();

            foreach (string strPath in dragFileOrFolderPaths)
            {
                if (File.Exists(strPath))
                {
                    if (strPath.ToLower().EndsWith(".cue")) fileList.Add(strPath);
                }
                else
                {
                    fileList.AddRange(Directory.GetFiles(
                        strPath,
                        "*.cue",
                        this.radioButtonTopDirectoryOnly.Checked ?
                        SearchOption.TopDirectoryOnly :
                        SearchOption.AllDirectories));
                }
            }

            DealWithFiles(fileList, true);
        }

        private void DealWithFiles(List<string> fileList, bool isCueFile)
        {
            strLog = "";

            foreach (string filePath in fileList)
            {
                strLog += ((strLog == "" ? "" : Environment.NewLine) + filePath + Environment.NewLine);

                string strContent = string.Empty;
                Encoding textEncoding = null;

                using (FileStream fs = new FileStream(
                    filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    int fileLength = (int)fs.Length;
                    int bytesLength = Math.Min(fileLength, 10240);
                    byte[] bytes = new byte[bytesLength];

                    fs.Read(bytes, 0, bytes.Length);

                    textEncoding = GetEncoding.GetFileEncodingByBomBytes(bytes);
                    // 没有 BOM
                    if (textEncoding == null)
                    {
                        if (this.encodingSelectForNoBom ==
                            TextEncodingSelectForm.EncodingSelectForNoBom.SAME_WITH_ALL)
                        {
                            textEncoding = this.textEncodingSelected;
                        }
                        else if (this.encodingSelectForNoBom ==
                            TextEncodingSelectForm.EncodingSelectForNoBom.SKIP_ALL)
                        {
                            textEncoding = null;
                        }
                        else
                        {
                            this.CheckBoxTopMostNoChecked?.Invoke();

                            TextEncodingSelectForm form =
                                new TextEncodingSelectForm(filePath, bytes);
                            form.textEncodingSelectResult = this.TextEncodingSelectResult;
                            form.ShowDialog();

                            this.CheckBoxTopMostRestoreChecked?.Invoke();

                            textEncoding = this.textEncodingSelected;
                        }
                    }

                    if (textEncoding != null)
                    {
                        fs.Seek(0, SeekOrigin.Begin);

                        if (isCueFile) strContent = DealWithCueFile(filePath, fs, textEncoding);
                        else strContent = DealWithNormalTextFile(filePath, fs, textEncoding);
                    }
                    else
                    {
                        strLog += ("    跳过" + Environment.NewLine);
                    }
                }

                // textEncoding 为 null 表示 该文件被跳过
                // strContent 为 null 表示 该文件不会被更改
                if (textEncoding != null && strContent != null)
                {
                    Encoding writeEncoding = textEncoding;
                    if (rbg2_utf8_bom.Checked) writeEncoding = new UTF8Encoding(true);
                    else if (rbg2_utf8.Checked) writeEncoding = new UTF8Encoding(false);
                    else if (rbg2_ucs2_le.Checked) writeEncoding = new UnicodeEncoding(false, true);
                    else if (rbg2_ucs2_be.Checked) writeEncoding = new UnicodeEncoding(true, true);
                    else if (rbg2_ansi.Checked) writeEncoding = Encoding.GetEncoding("GB18030");

                    File.WriteAllText(filePath, strContent, writeEncoding);

                    strLog += (string.Format("    编码：[{0}] => [{1}]",
                        GetEncodingString(textEncoding),
                        GetEncodingString(writeEncoding)) + Environment.NewLine);
                }
            }

            Helper.OpenEdit(strLog);
        }

        private string GetEncodingString(Encoding encoding)
        {
            if (encoding.WebName == "utf-8")
            {
                if (encoding.GetPreamble().Length == 0) return "UTF8 NO BOM";
                else return "UTF8-BOM";
            }
            else if (encoding.WebName == "utf-16") return "UCS-2 LE";
            else if (encoding.WebName == "utf-16BE") return "UCS-2 BE";
            else if (encoding.WebName == "GB18030") return "GB18030";
            else if (encoding.WebName == "big5") return "BIG5";
            else if (encoding.WebName == "shift_jis") return "SHIFT-JIS";
            else return encoding.EncodingName;
        }

        private void TextEncodingSelectResult(
            Encoding encoding,
            TextEncodingSelectForm.EncodingSelectForNoBom encodingSelectForNoBom)
        {
            this.textEncodingSelected = encoding;
            this.encodingSelectForNoBom = encodingSelectForNoBom;
        }

        private string DealWithNormalTextFile(string filePath, FileStream fs, Encoding encoding)
        {
            //using (var mm = MemoryMappedFile.CreateFromFile(
            //    fs, null, 0, MemoryMappedFileAccess.Read, HandleInheritability.None, false))
            //{
            //    using (var stream = mm.CreateViewStream(0, 0, MemoryMappedFileAccess.Read))
            //    {
            //        using (var reader = new StreamReader(stream, encoding))
            //        {
            //            using (StreamWriter writer = new StreamWriter("aaa", false, Encoding.UTF8))
            //            {
            //                while (reader.Peek() >= 0)
            //                {
            //                    string str = reader.ReadLine();
            //                    writer.WriteLine(str);
            //                }
            //            }
            //        }
            //    }
            //}
            if (rbg2_keep.Checked && rbg3_keep.Checked)
            {
                strLog += ("    不变" + Environment.NewLine);
                return null;
            }

            string strContent = string.Empty;
            using (StreamReader sr = new StreamReader(fs, encoding))
            {
                strContent = sr.ReadToEnd();
                if (rbg3_sc.Checked)
                {
                    strLog += ("    转为简体" + Environment.NewLine);
                    strContent = Microsoft.VisualBasic.Strings.StrConv(
                        strContent, Microsoft.VisualBasic.VbStrConv.SimplifiedChinese, 0);
                }
                else if (rbg3_tc.Checked)
                {
                    strLog += ("    转为繁体" + Environment.NewLine);
                    strContent = Microsoft.VisualBasic.Strings.StrConv(
                        strContent, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 0);
                }
            }

            return strContent;
        }

        private string DealWithCueFile(string filePath, FileStream fs, Encoding encoding)
        {
            if (rbg2_keep.Checked && rbg3_keep.Checked &&
                rbg1_keep.Checked && (!cbCUEAssociatedFileNameSync.Checked))
            {
                strLog += ("    不变" + Environment.NewLine);
                return null;
            }

            string strContent = string.Empty;

            using (StreamReader sr = new StreamReader(fs, encoding))
            {
                bool setTitleSameWithFolederName = false;
                bool bT = false;
                bool bTrack = false;

                while (sr.Peek() >= 0)
                {
                    string strLine = sr.ReadLine();

                    // 设置专辑名和文件夹名相同
                    if (setTitleSameWithFolederName)
                    {
                        if (strLine.Trim().StartsWith("TRACK")) bTrack = true;
                        if (!bT && !bTrack && strLine.Trim().StartsWith("TITLE"))
                        {
                            int index1 = filePath.LastIndexOf('\\');
                            string folderPath = filePath.Substring(0, index1);
                            int index2 = folderPath.LastIndexOf('\\');
                            strLine = string.Format("TITLE \"{0}\"", folderPath.Substring(index2 + 1));
                            bT = true;

                            strLog += (string.Format("    专辑名改为：\'{0}\'", folderPath.Substring(index2 + 1)) + Environment.NewLine);
                        }
                    }

                    // 设置关联文件
                    if (strLine.Trim().StartsWith("FILE"))
                    {
                        int index1 = strLine.IndexOf("\"");
                        int index2 = strLine.LastIndexOf("\"");
                        // 原始关联文件名
                        string strOriFullName = strLine.Substring(index1 + 1, index2 - index1 - 1);
                        int index3 = strOriFullName.LastIndexOf(".");
                        // 原始关联文件名无后缀
                        string strOriName = strOriFullName.Substring(0, index3);
                        // 原始关联文件名后缀不带 "."
                        string strOriExt = strOriFullName.Substring(index3 + 1);

                        string strDestFullName = "", strDestName = "", strDestExt = "";
                        string strLimitOriSuffix = cbCUEAssociatedFileExtension.Text.Substring(
                            cbCUEAssociatedFileExtension.Text.LastIndexOf('.') + 1).Trim(
                            new char[] { ')', ' ', '）' });
                        if (!rbg1_keep.Checked &&
                            (strLimitOriSuffix == "*" ||
                            strLimitOriSuffix.ToLower() == strOriExt.ToLower()))
                        {
                            if (rbg1_flac.Checked) strDestExt = "flac";
                            else if (rbg1_tak.Checked) strDestExt = "tak";
                            else if (rbg1_wav.Checked) strDestExt = "wav";
                            else if (rbg1_m4a.Checked) strDestExt = "m4a";
                            else if (rbg1_tta.Checked) strDestExt = "tta";
                            else if (rbg1_ape.Checked) strDestExt = "ape";
                        }
                        else strDestExt = strOriExt;

                        if (cbCUEAssociatedFileNameSync.Checked)
                        {
                            int index4 = filePath.LastIndexOf('\\') + 1;
                            int index5 = filePath.LastIndexOf('.');
                            strDestName = filePath.Substring(index4, index5 - index4);
                        }
                        else strDestName = strOriName;

                        strDestFullName = string.Format("{0}.{1}", strDestName, strDestExt);

                        strLine = strLine.Substring(0, index1) + "\"" +
                            strDestFullName + strLine.Substring(index2);

                        strLog += (string.Format("    关联文件：[{0}] => [{1}]", strOriFullName, strDestFullName) + Environment.NewLine);
                    }

                    strContent += (strLine + Environment.NewLine);
                }
            }

            if (rbg3_sc.Checked)
            {
                strLog += ("    转为简体" + Environment.NewLine);
                strContent = Microsoft.VisualBasic.Strings.StrConv(
                    strContent, Microsoft.VisualBasic.VbStrConv.SimplifiedChinese, 0);
            }
            else if (rbg3_tc.Checked)
            {
                strLog += ("    转为繁体" + Environment.NewLine);
                strContent = Microsoft.VisualBasic.Strings.StrConv(
                    strContent, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 0);
            }

            return strContent;
        }
    }
}
