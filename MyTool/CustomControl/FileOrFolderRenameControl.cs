using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyTool.Setting;
using System.Text.RegularExpressions;
using System.IO;
using static MyTool.FileOrFolderRenameSetting;

namespace MyTool
{
    public partial class FileOrFolderRenameControl : UserControl
    {
        private Dictionary<string, int> regexOriginalDic = null;
        private Dictionary<string, int> regexTargetDic = null;
        private Dictionary<string, int> searchDic = null;
        private Dictionary<string, int> replaceDic = null;

        private FileOrFolderRenameSetting fileOrFolderRenameSetting = null;

        private int reNameRowCount = 0;
        private int pasteRowCount = 0;

        private Action CheckBoxTopMostNoChecked = null;
        private Action CheckBoxTopMostRestoreChecked = null;

        public FileOrFolderRenameControl(
            Action CheckBoxTopMostNoChecked, Action CheckBoxTopMostRestoreChecked)
        {
            InitializeComponent();

            this.CheckBoxTopMostNoChecked = CheckBoxTopMostNoChecked;
            this.CheckBoxTopMostRestoreChecked = CheckBoxTopMostRestoreChecked;
        }

        private void FileOrFolderRenameControl_Load(object sender, EventArgs e)
        {
            this.gridView.AllowUserToResizeRows = false;

            this.fileOrFolderRenameSetting =
                Setting.GetInstance().settingData.fileOrFolderRenameSetting;

            this.radioButtonDragFile.Checked = (
                this.fileOrFolderRenameSetting.dragType == DragType.FILE);
            this.radioButtonDragFolder.Checked = (
                this.fileOrFolderRenameSetting.dragType == DragType.FOLDER);

            this.comboBoxDragFileOption.Items.Clear();
            this.comboBoxDragFileOption.Items.AddRange(
                FileOrFolderRenameSetting.DragFileShowTexts);
            this.comboBoxDragFileOption.SelectedIndex =
                (int)this.fileOrFolderRenameSetting.getFileFromDirectoryType;
            this.comboBoxDragFileOption.Enabled = this.radioButtonDragFile.Checked;

            this.radioButtonRegex.Checked = (
                this.fileOrFolderRenameSetting.renameType ==
                FileOrFolderRenameType.REGEX);
            this.radioButtonSearchAndReplace.Checked = (
                this.fileOrFolderRenameSetting.renameType ==
                FileOrFolderRenameType.REPLACE);
            this.radioButtonPaste.Checked = (
                this.fileOrFolderRenameSetting.renameType ==
                FileOrFolderRenameType.PASTE);

            this.regexOriginalDic = new Dictionary<string, int>();
            SetComboBoxRegexSearchPaste(
                fileOrFolderRenameSetting.regexOriginal,
                this.regexOriginalDic,
                this.comboBoxRegexOriginal);

            this.regexTargetDic = new Dictionary<string, int>();
            SetComboBoxRegexSearchPaste(
                fileOrFolderRenameSetting.regexTarget,
                this.regexTargetDic,
                this.comboBoxRegexTarget);

            this.searchDic = new Dictionary<string, int>();
            SetComboBoxRegexSearchPaste(
                fileOrFolderRenameSetting.replaceOriginal,
                this.searchDic,
                this.comboBoxSearch);

            this.replaceDic = new Dictionary<string, int>();
            SetComboBoxRegexSearchPaste(
                fileOrFolderRenameSetting.replaceTarget,
                this.replaceDic,
                this.comboBoxReplace);

            this.checkBoxNotIgnoreCase.Checked =
                fileOrFolderRenameSetting.replaceNotIgnoreCase;
            this.checkBoxReplaceOnce.Checked =
                fileOrFolderRenameSetting.replaceOnce;

            this.comboBoxManager.Items.Clear();
            this.comboBoxManager.Items.AddRange(
                FileOrFolderRenameSetting.ManagerShowTexts);
            this.comboBoxManager.SelectedIndex =
                this.fileOrFolderRenameSetting.managerSelectedIndex;

            this.buttonPaste.Enabled =
                (fileOrFolderRenameSetting.renameType == FileOrFolderRenameType.PASTE);
            this.buttonPreview.Enabled =
                !(fileOrFolderRenameSetting.renameType == FileOrFolderRenameType.PASTE);
        }

        private void SetComboBoxRegexSearchPaste(
            ComboBoxSet comboBoxSet,
            Dictionary<string, int> itemDic,
            ComboBox comboBox)
        {
            int selectedIndex = -1;

            if (comboBoxSet != null)
            {
                comboBoxSet.ItemList.ForEach(x =>
                {
                    itemDic.Add(x.Item, x.Count);
                });

                selectedIndex = comboBoxSet.SelectedIndex;
            }

            comboBox.Items.Clear();
            comboBox.Items.AddRange(itemDic.Keys.ToArray());

            if (selectedIndex >= 0 && selectedIndex < comboBox.Items.Count)
                comboBox.SelectedIndex = selectedIndex;
        }

        public void SaveConfig()
        {
            // 当前页面还没加载
            if (fileOrFolderRenameSetting == null) return;

            fileOrFolderRenameSetting.dragType =
                this.radioButtonDragFile.Checked ? DragType.FILE : DragType.FOLDER;

            fileOrFolderRenameSetting.getFileFromDirectoryType =
                (GetFileOrFolder.GetFileFromDirectoryType)
                this.comboBoxDragFileOption.SelectedIndex;

            fileOrFolderRenameSetting.renameType =
                this.radioButtonRegex.Checked ?
                FileOrFolderRenameType.REGEX :
                (this.radioButtonSearchAndReplace.Checked ?
                FileOrFolderRenameType.REPLACE :
                FileOrFolderRenameType.PASTE);

            fileOrFolderRenameSetting.regexOriginal =
                GetComboBoxRegexSearchPasteData(
                    this.regexOriginalDic, this.comboBoxRegexOriginal);
            fileOrFolderRenameSetting.regexTarget =
                GetComboBoxRegexSearchPasteData(
                    this.regexTargetDic, this.comboBoxRegexTarget);
            fileOrFolderRenameSetting.replaceOriginal =
                GetComboBoxRegexSearchPasteData(
                    this.searchDic, this.comboBoxSearch);
            fileOrFolderRenameSetting.replaceTarget =
                GetComboBoxRegexSearchPasteData(
                    this.replaceDic, this.comboBoxReplace);

            fileOrFolderRenameSetting.replaceNotIgnoreCase =
                this.checkBoxNotIgnoreCase.Checked;
            fileOrFolderRenameSetting.replaceOnce =
                this.checkBoxReplaceOnce.Checked;

            fileOrFolderRenameSetting.managerSelectedIndex =
                this.comboBoxManager.SelectedIndex;
        }

        private ComboBoxSet GetComboBoxRegexSearchPasteData(
            Dictionary<string, int> itemDic,
            ComboBox comboBox)
        {
            ComboBoxSet comboBoxToSet = new ComboBoxSet();
            if (comboBox.SelectedIndex >= 0 &&
                comboBox.SelectedIndex < comboBox.Items.Count)
            {
                comboBoxToSet.SelectedIndex = comboBox.SelectedIndex;
            }
            else comboBoxToSet.SelectedIndex = 0;

            comboBoxToSet.ItemList = new List<ItemAndCount>();

            foreach (KeyValuePair<string, int> kv in itemDic)
                comboBoxToSet.ItemList.Add(
                    new ItemAndCount() { Item = kv.Key, Count = kv.Value });

            return comboBoxToSet;
        }

        private void radioButtonPaste_CheckedChanged(object sender, EventArgs e)
        {
            fileOrFolderRenameSetting.renameType =
                this.radioButtonRegex.Checked ?
                FileOrFolderRenameType.REGEX :
                (this.radioButtonSearchAndReplace.Checked ?
                FileOrFolderRenameType.REPLACE :
                FileOrFolderRenameType.PASTE);

            this.buttonPaste.Enabled = this.radioButtonPaste.Checked;
            this.buttonPreview.Enabled = !this.radioButtonPaste.Checked;
        }

        private void radioButtonSearchAndReplace_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonPaste_CheckedChanged(sender, e);
        }

        private void radioButtonRegex_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonPaste_CheckedChanged(sender, e);
        }

        private void radioButtonDragFile_CheckedChanged(object sender, EventArgs e)
        {
            fileOrFolderRenameSetting.dragType =
                this.radioButtonDragFile.Checked ? DragType.FILE : DragType.FOLDER;

            this.comboBoxDragFileOption.Enabled =
                this.radioButtonDragFile.Checked;
        }

        private void checkBoxNotIgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            fileOrFolderRenameSetting.replaceNotIgnoreCase =
                this.checkBoxNotIgnoreCase.Checked;
        }

        private void checkBoxReplaceOnce_CheckedChanged(object sender, EventArgs e)
        {
            fileOrFolderRenameSetting.replaceOnce =
                this.checkBoxReplaceOnce.Checked;
        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileOrFolderRenameSetting.managerSelectedIndex =
                this.comboBoxManager.SelectedIndex;
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> itemDic = null;
            int selectedIndex = -1;
            bool isLimitCharAllowed = false;

            switch (this.comboBoxManager.SelectedIndex)
            {
                case 0:
                    itemDic = this.regexOriginalDic;
                    selectedIndex = this.comboBoxRegexOriginal.SelectedIndex;
                    break;
                case 1:
                    itemDic = this.regexTargetDic;
                    selectedIndex = this.comboBoxRegexTarget.SelectedIndex;
                    isLimitCharAllowed = true;
                    break;
                case 2:
                    itemDic = this.searchDic;
                    selectedIndex = this.comboBoxSearch.SelectedIndex;
                    break;
                case 3:
                    itemDic = this.replaceDic;
                    selectedIndex = this.comboBoxReplace.SelectedIndex;
                    break;
                default:
                    break;
            }

            this.CheckBoxTopMostNoChecked?.Invoke();

            ManagerComboBoxItemDialog form =
                new ManagerComboBoxItemDialog(
                    itemDic,
                    selectedIndex,
                    SetComboBoxCallBack,
                    isLimitCharAllowed);
            form.ShowDialog();

            this.CheckBoxTopMostRestoreChecked?.Invoke();
        }

        private void SetComboBoxCallBack(
            Dictionary<string, int> itemDic, int selectedIndex)
        {
            ComboBox comboBox = null;

            switch (this.comboBoxManager.SelectedIndex)
            {
                case 0:
                    this.regexOriginalDic = itemDic;
                    comboBox = this.comboBoxRegexOriginal;
                    break;
                case 1:
                    this.regexTargetDic = itemDic;
                    comboBox = this.comboBoxRegexTarget;
                    break;
                case 2:
                    this.searchDic = itemDic;
                    comboBox = this.comboBoxSearch;
                    break;
                case 3:
                    this.replaceDic = itemDic;
                    comboBox = this.comboBoxReplace;
                    break;
                default:
                    break;
            }

            comboBox.Items.Clear();
            comboBox.Items.AddRange(itemDic.Keys.ToArray());

            if (selectedIndex >= 0 && selectedIndex < comboBox.Items.Count)
                comboBox.SelectedIndex = selectedIndex;
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

            if (e.X >= xPoint1 && e.X <= xPoint2)
            {
                List<string> fileOrFolderList = new List<string>();
                // 获取文件
                if (this.radioButtonDragFile.Checked)
                {
                    fileOrFolderList = GetFileOrFolder.GetFilesFromPathList(
                        e.Data.GetData("FileDrop") as string[],
                        Setting.GetInstance().GetCurrentMatchRule(),
                        fileOrFolderRenameSetting.getFileFromDirectoryType);
                }
                else
                {
                    string[] dragList = e.Data.GetData("FileDrop") as string[];
                    foreach (string drapPath in dragList)
                    {
                        if (Directory.Exists(drapPath))
                            fileOrFolderList.Add(drapPath);
                    }
                }

                bool isAppend = Setting.GetInstance().settingData.isDragWithAppend;
                if (!isAppend)
                {
                    for (; reNameRowCount > pasteRowCount; reNameRowCount--)
                    {
                        this.gridView.Rows.RemoveAt(reNameRowCount - 1);
                    }
                    for (; reNameRowCount > 0; reNameRowCount--)
                    {
                        this.gridView.Rows[reNameRowCount - 1].Cells[1].Value = null;
                        this.gridView.Rows[reNameRowCount - 1].Cells[1].Tag = null;
                    }
                }
                else
                {
                    // 移除重复文件或文件夹
                    for (int i = 0; i < reNameRowCount; i++)
                    {
                        string existFileOrFolderPath = Path.Combine(
                                this.gridView.Rows[i].Cells[1].Tag.ToString(),
                                this.gridView.Rows[i].Cells[1].Value.ToString());
                        int existIndex = fileOrFolderList.IndexOf(existFileOrFolderPath);
                        if (existIndex != -1)
                        {
                            fileOrFolderList.RemoveAt(existIndex);
                        }
                    }
                }

                fileOrFolderList.ForEach(x =>
                {
                    int lastBackslashIndex = x.LastIndexOf('\\');
                    string fileName = x.Substring(lastBackslashIndex + 1);
                    string folderName = x.Substring(0, lastBackslashIndex);

                    if (reNameRowCount == this.gridView.Rows.Count)
                    {
                        this.gridView.Rows.Add();
                    }

                    this.gridView.Rows[reNameRowCount].Cells[0].Value = reNameRowCount + 1;
                    // 记录是文件还是文件夹（true 文件，false 文件夹）
                    this.gridView.Rows[reNameRowCount].Cells[0].Tag = this.radioButtonDragFile.Checked; ;
                    this.gridView.Rows[reNameRowCount].Cells[1].Value = fileName;
                    this.gridView.Rows[reNameRowCount].Cells[1].Tag = folderName;

                    reNameRowCount++;
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

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                string clipString = (string)iData.GetData(DataFormats.Text);
                if (GetFileOrFolder.IsInputContainLimitedChar(clipString))
                {
                    DialogResult dialogRestul = MessageBox.Show(
                        string.Format(
                        "剪贴板中含有限制字符 \"{0}\" ，\n转成对应全角字符 \"{1}\" ？",
                        new string(GetFileOrFolder.limitedChars),
                        new string(GetFileOrFolder.replaceChars)), "提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogRestul == DialogResult.Yes)
                    {
                        clipString = GetFileOrFolder.ReplaceLimitedChar(clipString);
                    }
                    else return;
                }

                List<string> pasteList = clipString.Replace("\r", "").Split(
                    new string[] { "\n" },
                    StringSplitOptions.RemoveEmptyEntries).ToList()
                    .ConvertAll(x => x.Trim());

                bool isAppend = Setting.GetInstance().settingData.isDragWithAppend;
                if (!isAppend)
                {
                    for (; pasteRowCount > reNameRowCount; pasteRowCount--)
                    {
                        this.gridView.Rows.RemoveAt(pasteRowCount - 1);
                    }
                    for (; pasteRowCount > 0; pasteRowCount--)
                    {
                        this.gridView.Rows[pasteRowCount - 1].Cells[2].Value = null;
                    }
                }
                pasteList.ForEach(x =>
                {
                    if (pasteRowCount == this.gridView.Rows.Count)
                    {
                        this.gridView.Rows.Add();
                    }

                    this.gridView.Rows[pasteRowCount].Cells[0].Value = pasteRowCount + 1;
                    this.gridView.Rows[pasteRowCount].Cells[2].Value = x;

                    pasteRowCount++;
                });
                for (int i = pasteRowCount; i < this.gridView.Rows.Count; i++)
                {
                    this.gridView.Rows[i].Cells[2].Value = null;
                }
            }
            else
            {
                MessageBox.Show("剪贴板没文本内容，请先复制到剪贴板！",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private string GetCustomGrammarString(string grammarString, int index)
        {
            Regex regexCountNum = new Regex(@"^.*(\?index\?(\d+)\?(\d+)\?).*$");
            Match matchCountNum = regexCountNum.Match(grammarString);

            while (matchCountNum.Success &&
                (matchCountNum.Groups.Count - 1) % 3 == 0)
            {
                int count = (matchCountNum.Groups.Count - 1) / 3;
                for (int j = 0; j < count; j++)
                {
                    int numberOfDigits =
                        Convert.ToInt32(matchCountNum.Groups[3 * j + 2].Value);
                    int startNumber =
                        Convert.ToInt32(matchCountNum.Groups[3 * j + 3].Value);

                    Regex regexReplace = new Regex(
                        Regex.Escape(matchCountNum.Groups[3 * j + 1].Value));

                    grammarString = regexReplace.Replace(grammarString,
                        (startNumber + index).ToString().PadLeft(
                            numberOfDigits, '0'), 1);
                }
                matchCountNum = regexCountNum.Match(grammarString);
            }

            return grammarString;
        }

        private Dictionary<int, string> GetRegexOrReplaceTargetDictionary()
        {
            if (this.radioButtonPaste.Checked) return null;

            Dictionary<int, string> indexAndTargetDic = new Dictionary<int, string>();

            if (this.radioButtonRegex.Checked)
            {
                Regex regex = new Regex(this.comboBoxRegexOriginal.Text);

                for (int i = 0; i < this.gridView.Rows.Count; i++)
                {
                    Match match = regex.Match(
                        this.gridView.Rows[i].Cells[1].Value.ToString());
                    if (match.Success)
                    {
                        try
                        {
                            string[] strs = new string[match.Groups.Count - 1];
                            for (int j = 1; j < match.Groups.Count; j++)
                                strs[j - 1] = match.Groups[j].Value;
                            indexAndTargetDic.Add(i,
                                string.Format(this.comboBoxRegexTarget.Text, strs));
                        }
                        catch (Exception ex)
                        {
                            this.CheckBoxTopMostNoChecked?.Invoke();

                            AbortIgnoreDialog abortIgnoreDialog = new AbortIgnoreDialog(
                                string.Format(
                                    "第 \"{0}\" 行正则表达式匹配错误，\n\n\"{1}\"",
                                    i + 1, ex.Message), "提示");
                            DialogResult dr = abortIgnoreDialog.ShowDialog();

                            this.CheckBoxTopMostRestoreChecked?.Invoke();

                            if (dr == DialogResult.Abort)
                                return null;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.gridView.Rows.Count; i++)
                {
                    indexAndTargetDic.Add(i,
                        this.gridView.Rows[i].Cells[1].Value.ToString().Replace(
                            this.comboBoxSearch.Text,
                            this.comboBoxReplace.Text));
                }
            }

            List<int> keys = indexAndTargetDic.Keys.ToList();
            foreach (int i in keys)
            {
                indexAndTargetDic[i] =
                        GetCustomGrammarString(indexAndTargetDic[i], i);
            }

            return indexAndTargetDic;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (this.radioButtonPaste.Checked) return;

            for (; pasteRowCount > reNameRowCount; pasteRowCount--)
            {
                this.gridView.Rows.RemoveAt(pasteRowCount - 1);
            }
            pasteRowCount = 0;

            if (this.radioButtonRegex.Checked)
            {
                for (int i = 0; i < this.gridView.Rows.Count; i++)
                {
                    this.gridView.Rows[i].Cells[2].Value =
                            "-----  regex match failed  -----";
                }
            }

            Dictionary<int, string> indexAndTargetDic =
                GetRegexOrReplaceTargetDictionary();

            foreach (KeyValuePair<int, string> kv in indexAndTargetDic)
            {
                this.gridView.Rows[kv.Key].Cells[2].Value =
                        GetCustomGrammarString(kv.Value, kv.Key);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> indexAndTargetDic = null;
            List<int> completedList = new List<int>();
            string strLog = string.Empty;

            try
            {
                this.Enabled = false;

                if (this.radioButtonPaste.Checked)
                {
                    int realRowCount = Math.Min(this.reNameRowCount, this.pasteRowCount);
                    indexAndTargetDic = new Dictionary<int, string>();

                    for (int i = 0; i < realRowCount; i++)
                    {
                        string strExt = GetFileOrFolder.GetFileExtension(
                            this.gridView.Rows[i].Cells[1].Value.ToString());
                        if (!string.IsNullOrWhiteSpace(strExt)) strExt = ("." + strExt);

                        indexAndTargetDic.Add(i, Path.Combine(
                            this.gridView.Rows[i].Cells[1].Tag.ToString(),
                            this.gridView.Rows[i].Cells[2].Value.ToString() + strExt));
                    }
                }
                else
                {
                    for (; pasteRowCount > reNameRowCount; pasteRowCount--)
                    {
                        this.gridView.Rows.RemoveAt(pasteRowCount - 1);
                    }
                    pasteRowCount = 0;

                    if (this.radioButtonRegex.Checked)
                    {
                        for (int i = 0; i < this.gridView.Rows.Count; i++)
                        {
                            this.gridView.Rows[i].Cells[2].Value =
                                    "-----  regex match failed  -----";
                        }
                    }

                    indexAndTargetDic = GetRegexOrReplaceTargetDictionary();
                }

                foreach (KeyValuePair<int, string> kv in indexAndTargetDic)
                {
                    bool abortFlag = false;
                    bool ignoreFlag = false;
                    bool isFile = Convert.ToBoolean(this.gridView.Rows[kv.Key].Cells[0].Tag);
                    string sourcePath = Path.Combine(
                        this.gridView.Rows[kv.Key].Cells[1].Tag.ToString(),
                        this.gridView.Rows[kv.Key].Cells[1].Value.ToString());
                    string targetPath = Path.Combine(
                        this.gridView.Rows[kv.Key].Cells[1].Tag.ToString(),
                        kv.Value);

                    while ((!abortFlag) && (!ignoreFlag) &&
                        (!(isFile ? File.Exists(sourcePath) : Directory.Exists(sourcePath))))
                    {
                        DialogResult dialogResult =
                            MessageBox.Show(string.Format(
                                "源{0}\n\"{1}\"\n不存在！",
                                isFile ? "文件" : "文件夹", sourcePath), "提示",
                            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Abort)
                            abortFlag = true;
                        else if (dialogResult == DialogResult.Ignore)
                            ignoreFlag = true;
                    }

                    while ((!abortFlag) && (!ignoreFlag) &&
                        (isFile ? File.Exists(targetPath) : Directory.Exists(targetPath)))
                    {
                        DialogResult dialogResult =
                            MessageBox.Show(string.Format(
                                "目标{0}\n\"{1}\"\n已存在！",
                                isFile ? "文件" : "文件夹", targetPath), "提示",
                            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Abort)
                            abortFlag = true;
                        else if (dialogResult == DialogResult.Ignore)
                            ignoreFlag = true;
                    }

                    if (abortFlag) break;
                    else if (!ignoreFlag)
                    {
                        if (isFile) File.Move(sourcePath, targetPath);
                        else Directory.Move(sourcePath, targetPath);

                        completedList.Add(kv.Key);
                        strLog += (string.Format("[{0}] => [{1}]",
                            sourcePath, targetPath) + Environment.NewLine);
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

                if (this.radioButtonPaste.Checked)
                    pasteRowCount -= completedList.Count;

                reNameRowCount -= completedList.Count;

                for (int i = 0; i < this.gridView.Rows.Count; i++)
                    this.gridView.Rows[i].Cells[0].Value = i + 1;

                this.Enabled = true;
            }

            Helper.OpenEdit(strLog);
        }
    }
}
