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
using System.Diagnostics;
using BencodeNET.Objects;
using System.Text.RegularExpressions;

namespace MyTool
{
    public partial class OtherToolControl : UserControl
    {
        private struct TextMatchFormatParam
        {
            public string TextMatch;
            public string TextFormat;
        }

        private Encoding textEncodingSelected = null;
        private TextEncodingSelectForm.EncodingSelectForNoBom encodingSelectForNoBom =
            TextEncodingSelectForm.EncodingSelectForNoBom.OK;

        private Action CheckBoxTopMostNoChecked = null;
        private Action CheckBoxTopMostRestoreChecked = null;

        public OtherToolControl(
            Action CheckBoxTopMostNoChecked, Action CheckBoxTopMostRestoreChecked)
        {
            InitializeComponent();

            this.CheckBoxTopMostNoChecked = CheckBoxTopMostNoChecked;
            this.CheckBoxTopMostRestoreChecked = CheckBoxTopMostRestoreChecked;

            richTextBoxCompare1.AllowDrop = true;
            richTextBoxCompare1.DragEnter += new DragEventHandler(richTextBoxCompare1_DragEnter);
            richTextBoxCompare1.DragDrop += new DragEventHandler(richTextBoxCompare1_DragDrop);

            richTextBoxCompare2.AllowDrop = true;
            richTextBoxCompare2.DragEnter += new DragEventHandler(richTextBoxCompare2_DragEnter);
            richTextBoxCompare2.DragDrop += new DragEventHandler(richTextBoxCompare2_DragDrop);
        }

        private void btnCompletedBluRayFolder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请把蓝光文件夹拖到此处！");
        }

        private void btnCompletedBluRayFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                string[] strFiles = e.Data.GetData("FileDrop") as string[];
                foreach (string strPath in strFiles)
                {
                    if (Directory.Exists(strPath))
                    {
                        e.Effect = DragDropEffects.Link;
                        return;
                    }
                }
            }
        }

        private void btnCompletedBluRayFolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] strFiles = e.Data.GetData("FileDrop") as string[];

            string[] folders = new string[] {
                @"\BDMV\AUXDATA" ,
                @"\BDMV\BACKUP",
                @"\BDMV\BACKUP\BDJO",
                @"\BDMV\BACKUP\CLIPINF",
                @"\BDMV\BACKUP\JAR",
                @"\BDMV\BACKUP\PLAYLIST",
                @"\BDMV\BDJO",
                @"\BDMV\CLIPINF",
                @"\BDMV\JAR",
                @"\BDMV\META",
                @"\BDMV\PLAYLIST",
                @"\BDMV\STREAM",
                @"\CERTIFICATE",
                @"\CERTIFICATE\BACKUP" };

            foreach (string strPath in strFiles)
            {
                if (Directory.Exists(strPath))
                {
                    string strInfo = string.Empty;
                    foreach (string strTemp in folders)
                    {
                        List<string> strList = strTemp.Split(new char[] { '\\' },
                            StringSplitOptions.RemoveEmptyEntries).ToList();
                        strList.Insert(0, strPath);
                        string checkFolder = Path.Combine(strList.ToArray());

                        if (!Directory.Exists(checkFolder))
                        {
                            Directory.CreateDirectory(checkFolder);
                            strInfo += (strTemp + Environment.NewLine);
                        }
                    }

                    if (string.IsNullOrEmpty(strInfo))
                        MessageBox.Show(string.Format("{0}\r\n目录下的蓝光光盘目录结构完整", strPath));
                    else
                        MessageBox.Show(string.Format("以下目录缺失并已修复\r\n{0}", strInfo));
                }
            }
        }

        private void btnCheckMediaInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请把媒体文件拖到此处！");
        }

        private void btnCheckMediaInfo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                string[] strFiles = e.Data.GetData("FileDrop") as string[];
                foreach (string strPath in strFiles)
                {
                    if (File.Exists(strPath))
                    {
                        e.Effect = DragDropEffects.Link;
                        return;
                    }
                }
            }
        }

        private void btnCheckMediaInfo_DragDrop(object sender, DragEventArgs e)
        {
            string[] strFiles = e.Data.GetData("FileDrop") as string[];

            Debug.Assert(strFiles.Length > 0);

            string filePath = strFiles[0];

            MediaInfoLib.MediaInfo MI = new MediaInfoLib.MediaInfo();
            MI.Open(filePath);
            string mediaInfo = MI.Inform();
            MI.Close();

            Helper.OpenEdit(mediaInfo);
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.tbFrom.Text = dlg.SelectedPath;
            }
        }

        private void tbFrom_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void tbFrom_DragDrop(object sender, DragEventArgs e)
        {
            object Files = e.Data.GetData("FileDrop");
            string[] strFiles = Files as string[];

            bool flag = false;
            string str1 = string.Empty, str2 = string.Empty;

            for (int i = 0; i < strFiles.Length - 1; i++)
            {
                for (int j = 0; j < strFiles.Length - i - 1; j++)
                {
                    if (strFiles[j].IndexOf(strFiles[j + 1]) != -1)
                    {
                        flag = true;
                        str1 = strFiles[j];
                        str2 = strFiles[j + 1];
                        break;
                    }
                }
                if (flag) break;
            }
            if (!flag)
            {
                this.tbFrom.Text = string.Join("|", strFiles);
                return;
            }
            else
            {
                MessageBox.Show(string.Format("{0} 是 {1} 的子文件或文件夹，不能同时添加！", str2, str1));
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.tbTo.Text = dlg.SelectedPath;
            }
        }

        private void tbTo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void tbTo_DragDrop(object sender, DragEventArgs e)
        {
            object Files = e.Data.GetData("FileDrop");
            string[] strFiles = Files as string[];

            foreach (string str in strFiles)
            {
                if (Directory.Exists(str))
                {
                    this.tbTo.Text = str;
                    return;
                }
            }
        }

        private void btnBackupApply_Click(object sender, EventArgs e)
        {
            string strLog = string.Empty;

            string[] strFromList = this.tbFrom.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            if (strFromList.Contains(this.tbTo.Text))
            {
                MessageBox.Show("目的文件夹包含于源文件夹！");
                return;
            }

            List<string> fileList = GetFileOrFolder.GetFilesFromPathList(
                strFromList,
                Setting.GetInstance().GetCurrentMatchRule(),
                GetFileOrFolder.GetFileFromDirectoryType.ALL_DIRECTORIES);

            strLog = string.Format("备份完成，共{0}项，列表如下：\r\n\r\n", fileList.Count);

            foreach (string sourcePath in fileList)
            {
                string strPar = string.Empty;
                foreach (string str in strFromList)
                    if (sourcePath.IndexOf(str) != -1)
                    { strPar = str.Substring(0, str.LastIndexOf('\\')); break; }

                string strDestPath = sourcePath.Replace(strPar, this.tbTo.Text);
                string strDestFolder = strDestPath.Substring(0, strDestPath.LastIndexOf('\\'));
                if (!Directory.Exists(strDestFolder)) Directory.CreateDirectory(strDestFolder);

                File.Copy(sourcePath, strDestPath);
                strLog += (string.Format("[{0}]  ------〉 [{1}]", sourcePath, strDestPath) + Environment.NewLine);
            }

            Helper.OpenEdit(strLog);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string strLog = string.Empty;

            string[] strFromList = this.tbFrom.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            if (strFromList.Contains(this.tbTo.Text))
            {
                MessageBox.Show("目的文件夹包含于源文件夹！");
                return;
            }

            List<string> fileList = GetFileOrFolder.GetFilesFromPathList(
                strFromList,
                Setting.GetInstance().GetCurrentMatchRule(),
                GetFileOrFolder.GetFileFromDirectoryType.ALL_DIRECTORIES);

            strLog = string.Format("移动完成，共{0}项，列表如下：\r\n\r\n", fileList.Count);

            foreach (string sourcePath in fileList)
            {
                string strPar = string.Empty;
                foreach (string str in strFromList)
                    if (sourcePath.IndexOf(str) != -1)
                    { strPar = str.Substring(0, str.LastIndexOf('\\')); break; }

                string strDestPath = sourcePath.Replace(strPar, this.tbTo.Text);
                string strDestFolder = strDestPath.Substring(0, strDestPath.LastIndexOf('\\'));
                if (!Directory.Exists(strDestFolder)) Directory.CreateDirectory(strDestFolder);

                File.Move(sourcePath, strDestPath);
                strLog += (string.Format("[{0}]  ------〉 [{1}]", sourcePath, strDestPath) + Environment.NewLine);
            }

            Helper.OpenEdit(strLog);
        }

        private void btnOther_DragDrop(object sender, DragEventArgs e)
        {
            //string[] strFiles = e.Data.GetData("FileDrop") as string[];
            //string strUnDeal = "";
            //int countOfDeal = 0;

            //foreach (string strPath in strFiles)
            //{
            //    if (strPath.ToLower().EndsWith(".torrent"))
            //    {
            //        var parser = new BencodeNET.Parsing.BencodeParser();
            //        var torrent = parser.Parse<BencodeNET.Torrents.Torrent>(strPath);

            //        if (torrent != null)
            //        {
            //            if (torrent.FileMode == BencodeNET.Torrents.TorrentFileMode.Unknown)
            //            {
            //                strUnDeal += (strPath + "\r\n");
            //                continue;
            //            }

            //            string displayName = torrent.DisplayName;
            //            bool isFolder = (torrent.FileMode == BencodeNET.Torrents.TorrentFileMode.Multi);

            //            // 连续的算一个
            //            int countOfBlank = 0;
            //            int countOfDot = 0;
            //            bool blankFlag = false, dotFlag = false;

            //            string displayNameTemp = displayName;
            //            if (!isFolder)
            //            {
            //                displayNameTemp = displayName.Substring(0, displayName.LastIndexOf('.'));
            //            }
            //            displayNameTemp.Trim(new char[] { ' ', '.' });
            //            foreach (char ch in displayNameTemp)
            //            {
            //                if (ch == ' ')
            //                {
            //                    blankFlag = true;
            //                    if (dotFlag)
            //                    {
            //                        countOfDot++;
            //                        dotFlag = false;
            //                    }
            //                }
            //                else if (ch == '.')
            //                {
            //                    dotFlag = true;
            //                    if (blankFlag)
            //                    {
            //                        countOfBlank++;
            //                        blankFlag = false;
            //                    }
            //                }
            //                else
            //                {
            //                    if (dotFlag) countOfDot++;
            //                    if (blankFlag) countOfBlank++;

            //                    dotFlag = false;
            //                    blankFlag = false;
            //                }
            //            }

            //            string preString = Path.GetFileNameWithoutExtension(strPath) +
            //                (countOfDot > countOfBlank ? "." : " ");

            //            BencodeNET.Objects.BDictionary torrentBDic = torrent.ToBDictionary();
            //            BString bStrInfo = new BString("info");
            //            BString bStrName = new BString("name");
            //            BString bStrFiles = new BString("files");
            //            BString bStrLength = new BString("length");
            //            BString bStrPath = new BString("path");

            //            BDictionary infoBDic = torrentBDic[bStrInfo] as BDictionary;
            //            string newDisplayName = "";

            //            if (torrent.FileMode == BencodeNET.Torrents.TorrentFileMode.Multi)
            //            {
            //                newDisplayName = preString + infoBDic[bStrName].ToString();
            //                infoBDic[bStrName] = new BString(newDisplayName);
            //            }
            //            else
            //            {
            //                BDictionary fileDBic = new BDictionary();
            //                fileDBic.Add("length", Convert.ToInt64(infoBDic[bStrLength].ToString()));
            //                fileDBic.Add("path", new BList(new string[] { infoBDic[bStrName].ToString() }));

            //                BList<BDictionary> filesBList = new BList<BDictionary>();
            //                filesBList.Add(fileDBic);

            //                infoBDic.Add(bStrFiles, filesBList);
            //                infoBDic.Remove(bStrLength);

            //                string fileName = infoBDic[bStrName].ToString();
            //                string fielNameWithOutExt = fileName.Substring(0, fileName.LastIndexOf('.'));
            //                newDisplayName = preString + fielNameWithOutExt;
            //                infoBDic[bStrName] = new BString(newDisplayName);
            //            }

            //            BencodeNET.Torrents.Torrent newTorrent = parser.Parse<BencodeNET.Torrents.Torrent>(torrentBDic.EncodeAsBytes());

            //            using (FileStream fs = new FileStream(
            //                Path.Combine(Path.GetDirectoryName(strPath),
            //                newDisplayName + ".torrent"), FileMode.Create))
            //            {
            //                byte[] bytes = newTorrent.EncodeAsBytes();
            //                fs.Write(bytes, 0, bytes.Length);
            //                fs.Flush();

            //                countOfDeal++;
            //            }
            //        }
            //    }
            //}

            //if (!string.IsNullOrWhiteSpace(strUnDeal)) Helper.OpenEdit(strUnDeal);

            //MessageBox.Show(string.Format("已处理 {0} 项", countOfDeal));

            if (e.Data.GetDataPresent("FileDrop"))
            {
                string strlog = "";

                #region 音频文件二级文件夹检测
                //string[] strFiles = e.Data.GetData("FileDrop") as string[];
                //foreach (string strPath in strFiles)
                //{
                //    string[] s1 = Directory.GetDirectories(strPath);
                //    foreach (string s2 in s1)
                //    {
                //        string[] s3 = Directory.GetDirectories(s2);
                //        if (s3.Length > 0) strlog += (s2 + '\n');
                //    }
                //}
                #endregion

                #region srt文件检测
                string[] strFiles = e.Data.GetData("FileDrop") as string[];
                Dictionary<string, string> moveDic = new Dictionary<string, string>();
                //DateTime date = new DateTime(2020, 5, 21);
                foreach (string strPath in strFiles)
                {
                    string root = Directory.GetDirectoryRoot(strPath);
                    string[] s1 = Directory.GetDirectories(strPath);
                    foreach (string s2 in s1)
                    {
                        DirectoryInfo info = new DirectoryInfo(s2);
                        //if (info.LastWriteTime <= date)
                        {
                            string[] s3 = Directory.GetFiles(s2, "*.srt", SearchOption.TopDirectoryOnly);
                            if (s3 != null && s3.Length > 0)
                            {
                                moveDic.Add(s2, Path.Combine(root, "move",
                                    Path.GetFileName(strPath), Path.GetFileName(s2)));
                            }
                        }

                    }
                }

                foreach (KeyValuePair<string, string> kv in moveDic)
                {
                    if (!Directory.Exists(Path.GetDirectoryName(kv.Value)))
                        Directory.CreateDirectory(Path.GetDirectoryName(kv.Value));
                    try { Directory.Move(kv.Key, kv.Value); }
                    catch { }
                }
                #endregion

                Helper.OpenEdit(strlog);
            }
        }

        private void btnOther_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            MessageBox.Show("拖到此处！");
        }

        private void tbBatchFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                string[] strFiles = e.Data.GetData("FileDrop") as string[];
                this.tbBatchFiles.Text = string.Join(";", strFiles);
            }
        }

        private void tbBatchFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void btnBatchCreate_Click(object sender, EventArgs e)
        {
            string[] strFileList = this.tbBatchFiles.Text.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string strBatch = "";

            foreach (string sourcePath in strFileList)
            {
                strBatch += string.Format(this.tbBatchTemplate.Text + "\r\n",
                    sourcePath.Replace("\\", "\\\\"));
            }
            strBatch += "pause\r\n";

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Bat文件|*.bat";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, strBatch);
            }
        }

        private void TextEncodingSelectResult(
            Encoding encoding,
            TextEncodingSelectForm.EncodingSelectForNoBom encodingSelectForNoBom)
        {
            this.textEncodingSelected = encoding;
            this.encodingSelectForNoBom = encodingSelectForNoBom;
        }

        private void btnTxtFormatToEpub_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Encoding textEncoding = null;

                using (FileStream fs = new FileStream(
                    dlg.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    int fileLength = (int)fs.Length;
                    int bytesLength = Math.Min(fileLength, 10240);
                    byte[] bytes = new byte[bytesLength];

                    fs.Read(bytes, 0, bytes.Length);

                    textEncoding = GetEncoding.GetFileEncodingByBomBytes(bytes);
                    // 没有 BOM
                    if (textEncoding == null)
                    {
                        TextEncodingSelectForm form =
                            new TextEncodingSelectForm(dlg.FileName, bytes);
                        form.textEncodingSelectResult = this.TextEncodingSelectResult;
                        form.ShowDialog();

                        textEncoding = this.textEncodingSelected;
                    }

                    fs.Seek(0, SeekOrigin.Begin);

                    List<TextMatchFormatParam> textMatchFormatParamList =
                        new List<TextMatchFormatParam>();
                    if ((!string.IsNullOrWhiteSpace(cbTxtFormatMatch1.Text)) &&
                        (!string.IsNullOrWhiteSpace(cbTxtFormatTo1.Text)))
                    {
                        textMatchFormatParamList.Add(new TextMatchFormatParam()
                        {
                            TextMatch = cbTxtFormatMatch1.Text.Trim(new char[] { ' ', '\t' }),
                            TextFormat = cbTxtFormatTo1.Text.Trim(new char[] { ' ', '\t' })
                        });

                        if ((!string.IsNullOrWhiteSpace(cbTxtFormatMatch2.Text)) &&
                            (!string.IsNullOrWhiteSpace(cbTxtFormatTo2.Text)))
                        {
                            textMatchFormatParamList.Add(new TextMatchFormatParam()
                            {
                                TextMatch = cbTxtFormatMatch2.Text.Trim(new char[] { ' ', '\t' }),
                                TextFormat = cbTxtFormatTo2.Text.Trim(new char[] { ' ', '\t' })
                            });
                            if ((!string.IsNullOrWhiteSpace(cbTxtFormatMatch3.Text)) &&
                                (!string.IsNullOrWhiteSpace(cbTxtFormatTo3.Text)))
                            {
                                textMatchFormatParamList.Add(new TextMatchFormatParam()
                                {
                                    TextMatch = cbTxtFormatMatch3.Text.Trim(new char[] { ' ', '\t' }),
                                    TextFormat = cbTxtFormatTo3.Text.Trim(new char[] { ' ', '\t' })
                                });
                            }
                        }

                        string strContent = DealWithTxtFormatToEpub(
                            fs, textEncoding, textMatchFormatParamList);

                        SaveFileDialog dlg1 = new SaveFileDialog();
                        dlg1.Filter = "txt|*.txt";

                        if (dlg1.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(dlg1.FileName, strContent, new UTF8Encoding(true));
                            MessageBox.Show("格式化完成");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请设置格式化");
                        return;
                    }
                }
            }
        }

        private string DealWithTxtFormatToEpub(
            FileStream fs, Encoding encoding,
            List<TextMatchFormatParam> textMatchFormatParamList)
        {
            string strContent = string.Empty;

            Dictionary<string, Regex> regexDic = new Dictionary<string, Regex>();
            foreach (TextMatchFormatParam param in textMatchFormatParamList)
            {
                regexDic.Add(param.TextMatch, new Regex(param.TextMatch));
            }

            Dictionary<int, string> levelGapDic = new Dictionary<int, string>();
            levelGapDic.Add(1, "#");
            levelGapDic.Add(2, "#  ");
            levelGapDic.Add(3, "#    ");

            int matchSuccessCount = 0;

            using (StreamReader sr = new StreamReader(fs, encoding))
            {
                while (sr.Peek() >= 0)
                {
                    string strLine = sr.ReadLine().Trim(new char[] { ' ', '\t' });
                    bool lineMatch = false;
                    int level = 1;

                    foreach (TextMatchFormatParam param in textMatchFormatParamList)
                    {
                        Match match = regexDic[param.TextMatch].Match(strLine);

                        if (match.Success)
                        {
                            lineMatch = true;
                            matchSuccessCount++;
                            string[] ss = new string[match.Groups.Count];
                            for (int i = 0; i < match.Groups.Count; i++)
                            {
                                ss[i] = match.Groups[i].Value;
                            }
                            strLine = string.Format(param.TextFormat, ss);
                            break;
                        }

                        level++;
                    }

                    strContent += string.Format("{0}{1}{2}{3}",
                        lineMatch ? Environment.NewLine : "",
                        lineMatch ? levelGapDic[level] : "  ",
                        strLine, Environment.NewLine);
                }
            }

            return strContent;
        }

        private void richTextBoxCompare1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void richTextBoxCompare1_DragDrop(object sender, DragEventArgs e)
        {
            object Files = e.Data.GetData("FileDrop");
            string[] strFiles = Files as string[];
            string[] strNames = new string[strFiles.Length];
            for (int i = 0; i < strFiles.Length; i++)
            {
                strNames[i] = Path.GetFileName(strFiles[i]);
            }

            richTextBoxCompare1.Text = string.Join(Environment.NewLine, strNames);
        }

        private void richTextBoxCompare2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void richTextBoxCompare2_DragDrop(object sender, DragEventArgs e)
        {
            object Files = e.Data.GetData("FileDrop");
            string[] strFiles = Files as string[];
            string[] strNames = new string[strFiles.Length];
            for (int i = 0; i < strFiles.Length; i++)
            {
                strNames[i] = Path.GetFileName(strFiles[i]);
            }

            richTextBoxCompare2.Text = string.Join(Environment.NewLine, strNames);
        }

        private void btnTextCompare_Click(object sender, EventArgs e)
        {
            List<string> ss1 = this.richTextBoxCompare1.Text.Split(
                new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> ss2 = this.richTextBoxCompare2.Text.Split(
                new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string strLog = "";
            foreach (string s1 in ss1)
            {
                if (ss2.IndexOf(s1) == -1) strLog += (s1 + Environment.NewLine);
            }

            Helper.OpenEdit(strLog);
        }

        private void GetAllThumbsDb(DirectoryInfo di, ref List<FileInfo> thumbsDbList)
        {
            try
            {
                thumbsDbList.AddRange(di.GetFiles("Thumbs.db", SearchOption.TopDirectoryOnly));
            }
            catch (System.UnauthorizedAccessException)
            {
                return;
            }

            DirectoryInfo[] childDis = di.GetDirectories();
            foreach (DirectoryInfo childDi in childDis)
            {
                if ((childDi.Attributes & FileAttributes.System) != FileAttributes.System)
                {
                    GetAllThumbsDb(childDi, ref thumbsDbList);
                }
            }
        }

        private void btnThumbsDb_Click(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> ml1 = new List<string>();
            List<string> ml2 = new List<string>();

            string moveDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "thumbs");
            if (!Directory.Exists(moveDir)) Directory.CreateDirectory(moveDir);

            foreach (DriveInfo drive in drives)
            {
                if (drive.Name.StartsWith("C:", StringComparison.OrdinalIgnoreCase)) continue;

                List<FileInfo> thumbsDbList = new List<FileInfo>();
                GetAllThumbsDb(drive.RootDirectory, ref thumbsDbList);

                foreach (FileInfo thumbsDb in thumbsDbList)
                {
                    bool hidden = ((thumbsDb.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden);
                    bool size = (thumbsDb.Length >= 1024 * 1024);

                    if (size && (!hidden))
                    {
                        ml2.Add(thumbsDb.FullName);
                    }
                    else
                    {
                        ml1.Add(thumbsDb.FullName);
                        string name = Helper.ReplaceInvalidChars(thumbsDb.FullName);
                        File.Move(thumbsDb.FullName, Path.Combine(moveDir, name));
                    }
                }
            }

            StringBuilder strLog = new StringBuilder();
            strLog.AppendLine(string.Format("移动项：{0}", ml1.Count));
            strLog.AppendLine(string.Join(Environment.NewLine, ml1));
            strLog.AppendLine();
            strLog.AppendLine(string.Format("未移动项：{0}", ml2.Count));
            strLog.AppendLine(string.Join(Environment.NewLine, ml2));

            LogForm lf = new LogForm(strLog.ToString());
            lf.ShowDialog();
        }
    }
}
