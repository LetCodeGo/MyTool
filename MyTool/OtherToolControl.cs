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

namespace MyTool
{
    public partial class OtherToolControl : UserControl
    {
        public OtherToolControl()
        {
            InitializeComponent();

            this.btnTorrent.Visible = false;
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
                this.tbFrom.Text = string.Join(";", strFiles);
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

            string[] strFromList = this.tbFrom.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

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

            string[] strFromList = this.tbFrom.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

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

        private void btnTorrent_DragDrop(object sender, DragEventArgs e)
        {
            string[] strFiles = e.Data.GetData("FileDrop") as string[];
            string strUnDeal = "";
            int countOfDeal = 0;

            foreach (string strPath in strFiles)
            {
                if (strPath.ToLower().EndsWith(".torrent"))
                {
                    var parser = new BencodeNET.Parsing.BencodeParser();
                    var torrent = parser.Parse<BencodeNET.Torrents.Torrent>(strPath);

                    if (torrent != null)
                    {
                        if (torrent.FileMode == BencodeNET.Torrents.TorrentFileMode.Unknown)
                        {
                            strUnDeal += (strPath + "\r\n");
                            continue;
                        }

                        string displayName = torrent.DisplayName;
                        bool isFolder = (torrent.FileMode == BencodeNET.Torrents.TorrentFileMode.Multi);

                        // 连续的算一个
                        int countOfBlank = 0;
                        int countOfDot = 0;
                        bool blankFlag = false, dotFlag = false;

                        string displayNameTemp = displayName;
                        if (!isFolder)
                        {
                            displayNameTemp = displayName.Substring(0, displayName.LastIndexOf('.'));
                        }
                        displayNameTemp.Trim(new char[] { ' ', '.' });
                        foreach (char ch in displayNameTemp)
                        {
                            if (ch == ' ')
                            {
                                blankFlag = true;
                                if (dotFlag)
                                {
                                    countOfDot++;
                                    dotFlag = false;
                                }
                            }
                            else if (ch == '.')
                            {
                                dotFlag = true;
                                if (blankFlag)
                                {
                                    countOfBlank++;
                                    blankFlag = false;
                                }
                            }
                            else
                            {
                                if (dotFlag) countOfDot++;
                                if (blankFlag) countOfBlank++;

                                dotFlag = false;
                                blankFlag = false;
                            }
                        }

                        string preString = Path.GetFileNameWithoutExtension(strPath) +
                            (countOfDot > countOfBlank ? "." : " ");

                        BencodeNET.Objects.BDictionary torrentBDic = torrent.ToBDictionary();
                        BString bStrInfo = new BString("info");
                        BString bStrName = new BString("name");
                        BString bStrFiles = new BString("files");
                        BString bStrLength = new BString("length");
                        BString bStrPath = new BString("path");

                        BDictionary infoBDic = torrentBDic[bStrInfo] as BDictionary;
                        string newDisplayName = "";

                        if (torrent.FileMode == BencodeNET.Torrents.TorrentFileMode.Multi)
                        {
                            newDisplayName = preString + infoBDic[bStrName].ToString();
                            infoBDic[bStrName] = new BString(newDisplayName);
                        }
                        else
                        {
                            BDictionary fileDBic = new BDictionary();
                            fileDBic.Add("length", Convert.ToInt64(infoBDic[bStrLength].ToString()));
                            fileDBic.Add("path", new BList(new string[] { infoBDic[bStrName].ToString() }));

                            BList<BDictionary> filesBList = new BList<BDictionary>();
                            filesBList.Add(fileDBic);

                            infoBDic.Add(bStrFiles, filesBList);
                            infoBDic.Remove(bStrLength);

                            string fileName = infoBDic[bStrName].ToString();
                            string fielNameWithOutExt = fileName.Substring(0, fileName.LastIndexOf('.'));
                            newDisplayName = preString + fielNameWithOutExt;
                            infoBDic[bStrName] = new BString(newDisplayName);
                        }

                        BencodeNET.Torrents.Torrent newTorrent = parser.Parse<BencodeNET.Torrents.Torrent>(torrentBDic.EncodeAsBytes());

                        using (FileStream fs = new FileStream(
                            Path.Combine(Path.GetDirectoryName(strPath),
                            newDisplayName + ".torrent"), FileMode.Create))
                        {
                            byte[] bytes = newTorrent.EncodeAsBytes();
                            fs.Write(bytes, 0, bytes.Length);
                            fs.Flush();

                            countOfDeal++;
                        }
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(strUnDeal)) Helper.OpenEdit(strUnDeal);

            MessageBox.Show(string.Format("已处理 {0} 项", countOfDeal));
        }

        private void btnTorrent_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                string[] strFiles = e.Data.GetData("FileDrop") as string[];
                foreach (string strPath in strFiles)
                {
                    if (File.Exists(strPath) && strPath.ToLower().EndsWith(".torrent"))
                    {
                        e.Effect = DragDropEffects.Link;
                        return;
                    }
                }
            }
        }

        private void btnTorrent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请把torrent文件拖到此处！");
        }
    }
}
