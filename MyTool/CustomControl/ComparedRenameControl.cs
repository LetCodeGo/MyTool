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
using static MyTool.Setting;
using static MyTool.ComparedRenameSetting;
using static MyTool.GetFileOrFolder;

namespace MyTool
{
    public partial class ComparedRenameControl : UserControl
    {
        private int referRowCount = 0;
        private int reNameRowCount = 0;
        private Dictionary<string, int> addedSuffixDic = null;
        private ComparedRenameSetting comparedRenameSetting = null;

        public ComparedRenameControl()
        {
            InitializeComponent();
        }

        private void ComparedRenameControl_Load(object sender, EventArgs e)
        {
            this.gridView.AllowUserToResizeRows = false;

            this.comparedRenameSetting =
                Setting.GetInstance().settingData.comparedRenameSetting;

            this.radioButtonRename.Checked =
                (this.comparedRenameSetting.renameType ==
                ComparedRenameType.LOCAL_RENAME);
            this.radioButtonRenameWithCopy.Checked =
                (this.comparedRenameSetting.renameType ==
                ComparedRenameType.COPY_RENAME);

            this.radioButtonTopDirectoryOnly.Checked =
                (this.comparedRenameSetting.getFileFromDirectoryType ==
                GetFileFromDirectoryType.TOP_DIRECTORY_ONLY);
            this.radioButtonAllDirectories.Checked =
                (this.comparedRenameSetting.getFileFromDirectoryType ==
                GetFileFromDirectoryType.ALL_DIRECTORIES);

            this.addedSuffixDic = new Dictionary<string, int>();
            ComboBoxSet comboBoxSet = comparedRenameSetting.addedSuffix;
            int selectedIndex = -1;

            if (comboBoxSet != null)
            {
                comboBoxSet.ItemList.ForEach(x =>
                {
                    this.addedSuffixDic.Add(x.Item, x.Count);
                });

                selectedIndex = comboBoxSet.SelectedIndex;
            }

            SetComboBoxCallBack(
                this.addedSuffixDic,
                selectedIndex);
        }

        private void buttonSuffixManager_Click(object sender, EventArgs e)
        {
            ManagerComboBoxItemDialog form =
                new ManagerComboBoxItemDialog(
                    this.addedSuffixDic,
                    this.comboBoxAppendSuffix.SelectedIndex,
                    SetComboBoxCallBack);
            form.ShowDialog();
        }

        private void SetComboBoxCallBack(
            Dictionary<string, int> itemDic, int selectedIndex)
        {
            this.addedSuffixDic = itemDic;

            this.comboBoxAppendSuffix.Items.Clear();
            this.comboBoxAppendSuffix.Items.AddRange(itemDic.Keys.ToArray());

            if (selectedIndex >= 0 &&
                selectedIndex < this.comboBoxAppendSuffix.Items.Count)
                this.comboBoxAppendSuffix.SelectedIndex = selectedIndex;
        }

        public void SaveConfig()
        {
            // 当前页面还没加载
            if (this.comparedRenameSetting == null) return;

            this.comparedRenameSetting.renameType =
                this.radioButtonRename.Checked ?
                ComparedRenameType.LOCAL_RENAME :
                ComparedRenameType.COPY_RENAME;

            this.comparedRenameSetting.getFileFromDirectoryType =
                this.radioButtonTopDirectoryOnly.Checked ?
                GetFileFromDirectoryType.TOP_DIRECTORY_ONLY :
                GetFileFromDirectoryType.ALL_DIRECTORIES;

            ComboBoxSet comboBoxSet = new ComboBoxSet();
            if (this.comboBoxAppendSuffix.SelectedIndex >= 0 &&
                this.comboBoxAppendSuffix.SelectedIndex < this.comboBoxAppendSuffix.Items.Count)
            {
                comboBoxSet.SelectedIndex = this.comboBoxAppendSuffix.SelectedIndex;
            }
            else comboBoxSet.SelectedIndex = 0;

            comboBoxSet.ItemList = new List<ItemAndCount>();

            foreach (KeyValuePair<string, int> kv in this.addedSuffixDic)
                comboBoxSet.ItemList.Add(
                    new ItemAndCount() { Item = kv.Key, Count = kv.Value });

            this.comparedRenameSetting.addedSuffix = comboBoxSet;
        }

        private Point LocationOnScreen(Control ctl)
        {
            Point retval = new Point(0, 0);
            for (; ctl.Parent != null; ctl = ctl.Parent)
            {
                retval.Offset(ctl.Location);
            }
            return new Point(retval.X + 8 + ctl.Location.X,
                retval.Y + SystemInformation.CaptionHeight + ctl.Location.Y);
        }

        private void gridView_DragDrop(object sender, DragEventArgs e)
        {
            Point pt = LocationOnScreen(this.gridView);
            int xPoint1 = pt.X + this.gridView.Columns[0].Width;
            int xPoint2 = xPoint1 + this.gridView.Columns[1].Width;
            int xPoint3 = xPoint2 + this.gridView.Columns[2].Width;

            bool dragValidAsRefer = false;
            bool dragValidAsRename = false;

            // 作为参照文件添加
            if (e.X >= xPoint1 && e.X <= xPoint2)
            {
                dragValidAsRefer = true;
            }
            // 作为命名文件添加
            else if (e.X > xPoint2 && e.X <= xPoint3)
            {
                dragValidAsRename = true;
            }

            if (dragValidAsRefer || dragValidAsRename)
            {
                // 获取文件
                List<string> fileList = GetFileOrFolder.GetFilesFromPathList(
                    e.Data.GetData("FileDrop") as string[],
                    Setting.GetInstance().GetCurrentMatchRule(),
                    comparedRenameSetting.getFileFromDirectoryType);

                bool isAppend = Setting.GetInstance().settingData.isDragWithAppend;
                if (!isAppend)
                {
                    if (dragValidAsRefer)
                    {
                        for (; referRowCount > reNameRowCount; referRowCount--)
                        {
                            this.gridView.Rows.RemoveAt(referRowCount - 1);
                        }
                        for (; referRowCount > 0; referRowCount--)
                        {
                            this.gridView.Rows[referRowCount - 1].Cells[1].Value = null;
                            this.gridView.Rows[referRowCount - 1].Cells[1].Tag = null;
                        }
                    }
                    else
                    {
                        for (; reNameRowCount > referRowCount; reNameRowCount--)
                        {
                            this.gridView.Rows.RemoveAt(reNameRowCount - 1);
                        }
                        for (; reNameRowCount > 0; reNameRowCount--)
                        {
                            this.gridView.Rows[reNameRowCount - 1].Cells[2].Value = null;
                            this.gridView.Rows[reNameRowCount - 1].Cells[2].Tag = null;
                        }
                    }
                }
                else
                {
                    int colIndex = dragValidAsRefer ? 1 : 2;
                    int rowCount = dragValidAsRefer ? referRowCount : reNameRowCount;

                    // 移除重复文件或文件夹
                    for (int i = 0; i < rowCount; i++)
                    {
                        string existFileOrFolderPath = Path.Combine(
                                this.gridView.Rows[i].Cells[colIndex].Tag.ToString(),
                                this.gridView.Rows[i].Cells[colIndex].Value.ToString());
                        int existIndex = fileList.IndexOf(existFileOrFolderPath);
                        if (existIndex != -1)
                        {
                            fileList.RemoveAt(existIndex);
                        }
                    }
                }

                fileList.ForEach(x =>
                {
                    int lastBackslashIndex = x.LastIndexOf('\\');
                    string fileName = x.Substring(lastBackslashIndex + 1);
                    string folderName = x.Substring(0, lastBackslashIndex);

                    if (dragValidAsRefer)
                    {
                        if (referRowCount == this.gridView.Rows.Count)
                        {
                            this.gridView.Rows.Add();
                            this.gridView.Rows[referRowCount].Cells[0].Value = referRowCount + 1;
                        }

                        this.gridView.Rows[referRowCount].Cells[1].Value = fileName;
                        this.gridView.Rows[referRowCount].Cells[1].Tag = folderName;
                        referRowCount++;
                    }
                    else
                    {
                        if (reNameRowCount == this.gridView.Rows.Count)
                        {
                            this.gridView.Rows.Add();
                            this.gridView.Rows[reNameRowCount].Cells[0].Value = reNameRowCount + 1;
                        }

                        this.gridView.Rows[reNameRowCount].Cells[2].Value = fileName;
                        this.gridView.Rows[reNameRowCount].Cells[2].Tag = folderName;
                        reNameRowCount++;
                    }
                });
            }
        }

        private void gridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            int realRowCount = Math.Min(referRowCount, reNameRowCount);
            string addedSuffixString =
                GetFileOrFolder.ReplaceLimitedChar(this.comboBoxAppendSuffix.Text);
            if (addedSuffixString != "")
                addedSuffixString = ("." + addedSuffixString);

            for (int i = 0; i < realRowCount; i++)
            {
                string str1 = GetFileOrFolder.GetFileNameWithoutExtension(
                    this.gridView.Rows[i].Cells[1].Value.ToString());
                string str2 = GetFileOrFolder.GetFileExtension(
                    this.gridView.Rows[i].Cells[2].Value.ToString());
                if (str2 != string.Empty) str2 = "." + str2;

                this.gridView.Rows[i].Cells[3].Value = str1 + addedSuffixString + str2;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            List<int> completedList = new List<int>();
            string strLog = string.Empty;

            try
            {
                this.Enabled = false;

                if (referRowCount != reNameRowCount)
                {
                    if (MessageBox.Show(
                        "参照文件与命名文件个数不等，是否继续？", "提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                    {
                        return;
                    }
                }

                int realRowCount = Math.Min(referRowCount, reNameRowCount);
                string addedSuffixString = this.comboBoxAppendSuffix.Text.Trim();

                if (GetFileOrFolder.IsInputContainLimitedChar(addedSuffixString))
                {
                    DialogResult dialogRestul = MessageBox.Show(
                        string.Format(
                            "添加后缀输入字符串中含有限制字符 \"{0}\" ，\n转成对应全角字符 \"{1}\" ？",
                            new string(GetFileOrFolder.limitedChars),
                            new string(GetFileOrFolder.replaceChars)), "提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogRestul == DialogResult.Yes)
                    {
                        addedSuffixString =
                            GetFileOrFolder.ReplaceLimitedChar(addedSuffixString);
                    }
                    else return;
                }

                if (!string.IsNullOrWhiteSpace(addedSuffixString))
                {
                    if (this.addedSuffixDic.ContainsKey(addedSuffixString))
                        this.addedSuffixDic[addedSuffixString]++;
                    else
                    {
                        this.comboBoxAppendSuffix.Items.Add(addedSuffixString);
                        this.addedSuffixDic.Add(addedSuffixString, 1);
                        this.comboBoxAppendSuffix.SelectedIndex =
                            this.comboBoxAppendSuffix.Items.Count - 1;
                    }
                }

                if (addedSuffixString != "")
                    addedSuffixString = ("." + addedSuffixString);

                List<string> targetPathList = new List<string>();

                for (int i = 0; i < realRowCount; i++)
                {
                    string str1 = GetFileOrFolder.GetFileNameWithoutExtension(
                        this.gridView.Rows[i].Cells[1].Value.ToString());
                    string str2 = GetFileOrFolder.GetFileExtension(
                        this.gridView.Rows[i].Cells[2].Value.ToString());
                    if (str2 != string.Empty) str2 = "." + str2;

                    string strT1 = str1 + addedSuffixString + str2;
                    string strT2 = this.gridView.Rows[i].Cells[2].Tag.ToString();
                    if (this.comparedRenameSetting.renameType ==
                        ComparedRenameType.COPY_RENAME)
                        strT2 = this.gridView.Rows[i].Cells[1].Tag.ToString();

                    string targetPath = Path.Combine(strT2, strT1);

                    targetPathList.Add(targetPath);
                }

                for (int i = 0; i < realRowCount; i++)
                {
                    string sourcePath = Path.Combine(
                        this.gridView.Rows[i].Cells[2].Tag.ToString(),
                        this.gridView.Rows[i].Cells[2].Value.ToString());

                    bool abortFlag = false;
                    bool ignoreFlag = false;

                    while ((!abortFlag) && (!ignoreFlag) && (!File.Exists(sourcePath)))
                    {
                        DialogResult dialogResult =
                            MessageBox.Show(string.Format(
                                "源文件\n\"{0}\"\n不存在！", sourcePath), "提示",
                            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Abort)
                            abortFlag = true;
                        else if (dialogResult == DialogResult.Ignore)
                            ignoreFlag = true;
                    }

                    while ((!abortFlag) && (!ignoreFlag) && File.Exists(targetPathList[i]))
                    {
                        DialogResult dialogResult =
                            MessageBox.Show(string.Format(
                                "目标文件\n\"{0}\"\n已存在！", targetPathList[i]), "提示",
                            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Abort)
                            abortFlag = true;
                        else if (dialogResult == DialogResult.Ignore)
                            ignoreFlag = true;
                    }

                    if (abortFlag) break;
                    else if (!ignoreFlag)
                    {
                        while ((!abortFlag) && (!ignoreFlag))
                        {
                            try
                            {
                                if (this.comparedRenameSetting.renameType ==
                                    ComparedRenameType.COPY_RENAME)
                                    File.Copy(sourcePath, targetPathList[i]);
                                else File.Move(sourcePath, targetPathList[i]);
                                completedList.Add(i);
                                strLog += (string.Format("[{0}] => [{1}]", 
                                    sourcePath, targetPathList[i]) + Environment.NewLine);
                                break;
                            }
                            catch (Exception ex)
                            {
                                DialogResult dialogResult = MessageBox.Show(
                                    ex.Message, "提示",
                                    MessageBoxButtons.AbortRetryIgnore,
                                    MessageBoxIcon.Question);

                                if (dialogResult == DialogResult.Abort)
                                    abortFlag = true;
                                else if (dialogResult == DialogResult.Ignore)
                                    ignoreFlag = true;
                            }
                        }

                        if (abortFlag) break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                for (int i = completedList.Count - 1; i >= 0; i--)
                    this.gridView.Rows.RemoveAt(completedList[i]);

                referRowCount -= completedList.Count;
                reNameRowCount -= completedList.Count;

                for (int i = 0; i < this.gridView.Rows.Count; i++)
                    this.gridView.Rows[i].Cells[0].Value = i + 1;

                this.Enabled = true;
            }

            Helper.OpenEdit(strLog);
        }

        private void radioButtonRename_CheckedChanged(object sender, EventArgs e)
        {
            this.comparedRenameSetting.renameType =
                this.radioButtonRename.Checked ?
                ComparedRenameType.LOCAL_RENAME :
                ComparedRenameType.COPY_RENAME;
        }

        private void radioButtonTopDirectoryOnly_CheckedChanged(object sender, EventArgs e)
        {
            this.comparedRenameSetting.getFileFromDirectoryType =
                this.radioButtonTopDirectoryOnly.Checked ?
                GetFileFromDirectoryType.TOP_DIRECTORY_ONLY :
                GetFileFromDirectoryType.ALL_DIRECTORIES;
        }
    }
}
