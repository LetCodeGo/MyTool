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
using System.Diagnostics;
using static MyTool.FileMatchSetting;

namespace MyTool
{
    public partial class FileMatchSettingControl : UserControl
    {
        private FileMatchSetting fileMatchSetting = null;
        private SavePresetDialog.SavePresetState savePresetFormState =
            SavePresetDialog.SavePresetState.CANCEL;

        private List<bool> fileNameIncludeItemTypeList = new List<bool>();
        private List<bool> fileNameExcludeItemTypeList = new List<bool>();

        public delegate void SetFileMatchCombox(
            List<string> itemsList, int selectedIndex);
        public SetFileMatchCombox setFileMatchCombox = null;

        public FileMatchSettingControl()
        {
            InitializeComponent();
        }

        private void SettingControl_Load(object sender, EventArgs e)
        {
            this.toolStripMenuItemPresetLoad.Image = this.imageListPreset.Images[0];
            this.toolStripMenuItemPresetRename.Image = this.imageListPreset.Images[1];
            this.toolStripMenuItemPresetRepeat.Image = this.imageListPreset.Images[2];
            this.toolStripMenuItemPresetDelete.Image = this.imageListPreset.Images[3];

            this.textBoxPresetItemRename.AutoSize = false;
            this.textBoxPresetItemRename.Visible = false;

            this.comboBoxFileNameIncludeInputType.SelectedIndex = 0;
            this.comboBoxFileNameExcludeInputType.SelectedIndex = 0;

            fileMatchSetting = Setting.GetInstance().settingData.fileMatchSetting;
            Debug.Assert(fileMatchSetting != null);

            if (fileMatchSetting.SelectedFileMatch == null)
            {
                // 用第一个
                fileMatchSetting.SelectedName = fileMatchSetting[0].Name;
            }

            InitControl();
        }

        private void InitControl()
        {
            this.listBoxPreset.Items.Clear();
            this.listBoxPreset.SelectionMode = SelectionMode.One;
            this.listBoxPreset.Items.AddRange(
                fileMatchSetting.GetAllFileMatchName());
            this.listBoxPreset.SelectedItem =
                fileMatchSetting.SelectedName;

            FileMatch selectedFileMatch = fileMatchSetting.SelectedFileMatch;

            this.checkedListBoxFileNameInclude.Items.Clear();
            this.fileNameIncludeItemTypeList.Clear();
            selectedFileMatch.FileNameIncludeList.ForEach(x =>
            {
                int index = this.checkedListBoxFileNameInclude.Items.Add(x.Rule);
                this.fileNameIncludeItemTypeList.Add(x.IsWildcard);
                this.checkedListBoxFileNameInclude.SetItemChecked(index, x.IsSelected);
            });
            this.checkedListBoxFileNameInclude.SelectedIndex =
                this.checkedListBoxFileNameInclude.Items.Count - 1;

            this.checkedListBoxFileNameExclude.Items.Clear();
            this.fileNameExcludeItemTypeList.Clear();
            selectedFileMatch.FileNameExcludeList.ForEach(x =>
            {
                int index = this.checkedListBoxFileNameExclude.Items.Add(x.Rule);
                this.fileNameExcludeItemTypeList.Add(x.IsWildcard);
                this.checkedListBoxFileNameExclude.SetItemChecked(index, x.IsSelected);
            });
            this.checkedListBoxFileNameExclude.SelectedIndex =
                this.checkedListBoxFileNameExclude.Items.Count - 1;

            this.buttonFileNameIncludeDelete.Enabled = (
                this.checkedListBoxFileNameInclude.SelectedIndex != -1);
            this.buttonFileNameExcludeDelete.Enabled = (
                this.checkedListBoxFileNameExclude.SelectedIndex != -1);

            this.checkBoxFileAttrExcludeReadOnly.Checked =
                selectedFileMatch.FileAttrExcludeReadOnly;
            this.checkBoxFileAttrExcludeHidden.Checked =
                selectedFileMatch.FileAttrExcludeHidden;
            this.checkBoxFileAttrExcludeSystem.Checked =
                selectedFileMatch.FileAttrExcludeSystem;

            this.checkBoxFileSizeGreaterThan.Checked =
                selectedFileMatch.FileSizeMinMatch.Enabled;
            this.textBoxFileSizeGreaterThanInput.Text =
                selectedFileMatch.FileSizeMinMatch.Size.ToString();
            this.comboBoxFileSizeGreaterThanUnit.Text =
                selectedFileMatch.FileSizeMinMatch.Unit;

            this.checkBoxFileSizeLessThan.Checked =
                selectedFileMatch.FileSizeMaxMatch.Enabled;
            this.textBoxFileSizeLessThanInput.Text =
                selectedFileMatch.FileSizeMaxMatch.Size.ToString();
            this.comboBoxFileSizeLessThanUnit.Text =
                selectedFileMatch.FileSizeMaxMatch.Unit;
        }

        private void buttonPresetLoad_Click(object sender, EventArgs e)
        {
            fileMatchSetting.SelectedName =
                this.listBoxPreset.SelectedItem.ToString();

            InitControl();
        }

        private void buttonPresentSave_Click(object sender, EventArgs e)
        {
            if (this.listBoxPreset.SelectedIndex != -1)
            {
                SavePresetDialog savePresetForm =
                    new SavePresetDialog(
                        this.listBoxPreset.SelectedItem.ToString());
                savePresetForm.savePresetFormStateAction =
                    this.SetSavePresetFormState;
                savePresetForm.ShowDialog();

                SavePreset();
            }
            else
            {
                this.savePresetFormState =
                    SavePresetDialog.SavePresetState.CREATE;
                SavePreset();
            }
        }

        private void SetSavePresetFormState(
            SavePresetDialog.SavePresetState state)
        {
            this.savePresetFormState = state;
        }

        private void SavePreset()
        {
            if (this.savePresetFormState ==
                SavePresetDialog.SavePresetState.CANCEL) return;

            List<FileNameMatch> fileNameIncludeList = new List<FileNameMatch>();
            List<FileNameMatch> fileNameExcludeList = new List<FileNameMatch>();

            for (int i = 0; i < this.checkedListBoxFileNameInclude.Items.Count; i++)
            {
                fileNameIncludeList.Add(new FileNameMatch()
                {
                    IsSelected = this.checkedListBoxFileNameInclude.GetItemChecked(i),
                    IsWildcard = this.fileNameIncludeItemTypeList[i],
                    Rule = this.checkedListBoxFileNameInclude.Items[i].ToString()
                });
            }
            for (int i = 0; i < this.checkedListBoxFileNameExclude.Items.Count; i++)
            {
                fileNameExcludeList.Add(new FileNameMatch()
                {
                    IsSelected = this.checkedListBoxFileNameExclude.GetItemChecked(i),
                    IsWildcard = this.fileNameExcludeItemTypeList[i],
                    Rule = this.checkedListBoxFileNameExclude.Items[i].ToString()
                });
            }

            FileMatch fileMatch = new FileMatch();
            fileMatch.FileNameIncludeList = fileNameIncludeList;
            fileMatch.FileNameExcludeList = fileNameExcludeList;
            fileMatch.FileAttrExcludeReadOnly =
                this.checkBoxFileAttrExcludeReadOnly.Checked;
            fileMatch.FileAttrExcludeHidden =
                this.checkBoxFileAttrExcludeHidden.Checked;
            fileMatch.FileAttrExcludeSystem =
                this.checkBoxFileAttrExcludeSystem.Checked;

            fileMatch.FileSizeMinMatch = new FileSizeMatch()
            {
                Enabled = this.checkBoxFileSizeGreaterThan.Checked,
                Size = Convert.ToInt64(this.textBoxFileSizeGreaterThanInput.Text),
                Unit = this.comboBoxFileSizeGreaterThanUnit.Text
            };
            fileMatch.FileSizeMaxMatch = new FileSizeMatch()
            {
                Enabled = this.checkBoxFileSizeLessThan.Checked,
                Size = Convert.ToInt64(this.textBoxFileSizeLessThanInput.Text),
                Unit = this.comboBoxFileSizeLessThanUnit.Text
            };

            fileMatch.Name = "";

            if (this.savePresetFormState ==
                SavePresetDialog.SavePresetState.COVER)
            {
                string coverName = this.listBoxPreset.SelectedItem.ToString();
                int selectedIndex = fileMatchSetting.SelectedIndex;
                fileMatchSetting.SelectedName = coverName;

                fileMatch.Name = coverName;
                fileMatchSetting[selectedIndex] = fileMatch;
            }
            else
            {
                string newName = GetNewName("新建预设");
                fileMatchSetting.SelectedName = newName;
                fileMatch.Name = newName;
                fileMatchSetting.FileMatchList.Add(fileMatch);

                this.listBoxPreset.Items.Add(newName);
                this.listBoxPreset.SelectedIndex = this.listBoxPreset.Items.Count - 1;

                PresetRename(
                    this.listBoxPreset.SelectedIndex,
                    this.listBoxPreset.SelectedItem.ToString());
            }
        }

        private void textBoxFileNameIncludeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonFileNameIncludeAdd_Click(null, null);
            }
        }

        private void textBoxFileNameExcludeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonFileNameExcludeAdd_Click(null, null);
            }
        }

        private void buttonFileNameIncludeAdd_Click(object sender, EventArgs e)
        {
            int index = this.checkedListBoxFileNameInclude.Items.Add(
                this.textBoxFileNameIncludeInput.Text);
            this.fileNameIncludeItemTypeList.Add(
                this.comboBoxFileNameIncludeInputType.SelectedIndex == 0);
            this.checkedListBoxFileNameInclude.SetItemChecked(index, true);
        }

        private void buttonFileNameIncludeDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.checkedListBoxFileNameInclude.SelectedIndex;
            this.checkedListBoxFileNameInclude.Items.RemoveAt(selectedIndex);
            this.fileNameIncludeItemTypeList.RemoveAt(selectedIndex);
            selectedIndex--;
            if (selectedIndex < 0 && this.checkedListBoxFileNameInclude.Items.Count > 0)
                selectedIndex += this.checkedListBoxFileNameInclude.Items.Count;
            this.checkedListBoxFileNameInclude.SelectedIndex = selectedIndex;
        }

        private void buttonFileNameExcludeAdd_Click(object sender, EventArgs e)
        {
            int index = this.checkedListBoxFileNameExclude.Items.Add(
                this.textBoxFileNameExcludeInput.Text);
            this.fileNameExcludeItemTypeList.Add(
                this.comboBoxFileNameExcludeInputType.SelectedIndex == 0);
            this.checkedListBoxFileNameExclude.SetItemChecked(index, true);
        }

        private void buttonFileNameExcludeDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.checkedListBoxFileNameExclude.SelectedIndex;
            this.checkedListBoxFileNameExclude.Items.RemoveAt(selectedIndex);
            this.fileNameExcludeItemTypeList.RemoveAt(selectedIndex);
            selectedIndex--;
            if (selectedIndex < 0 && this.checkedListBoxFileNameExclude.Items.Count > 0)
                selectedIndex += this.checkedListBoxFileNameExclude.Items.Count;
            this.checkedListBoxFileNameExclude.SelectedIndex = selectedIndex;
        }

        private void toolStripMenuItemPresetLoad_Click(object sender, EventArgs e)
        {
            fileMatchSetting.SelectedName =
                this.listBoxPreset.SelectedItem.ToString();

            InitControl();
        }

        private void toolStripMenuItemPresetRename_Click(object sender, EventArgs e)
        {
            PresetRename(
                this.listBoxPreset.SelectedIndex,
                this.listBoxPreset.SelectedItem.ToString());
        }

        private void PresetRename(int selectedIndex, string originalText)
        {
            Rectangle rectangle = this.listBoxPreset.GetItemRectangle(selectedIndex);
            this.textBoxPresetItemRename.Location = new Point(
                rectangle.X + this.listBoxPreset.Location.X + 2,
                rectangle.Y + this.listBoxPreset.Location.Y + 2);
            this.textBoxPresetItemRename.Width = rectangle.Width;
            this.textBoxPresetItemRename.Height = rectangle.Height;
            this.textBoxPresetItemRename.Text = originalText;
            this.textBoxPresetItemRename.Visible = true;
            this.textBoxPresetItemRename.Focus();
            this.textBoxPresetItemRename.SelectAll();
        }

        private string GetNewName(string baseName)
        {
            string newName = "";
            int i = 1;
            do
            {
                newName = string.Format("{0} ({1})", baseName, i++);
            }
            while (this.listBoxPreset.Items.Contains(newName));

            return newName;
        }

        private void toolStripMenuItemPresetRepeat_Click(object sender, EventArgs e)
        {
            string repeatName = GetNewName(this.listBoxPreset.SelectedItem.ToString());

            FileMatch fileMatch = new FileMatch(fileMatchSetting.SelectedFileMatch);
            fileMatch.Name = repeatName;

            fileMatchSetting.SelectedName = repeatName;
            fileMatchSetting.FileMatchList.Add(fileMatch);

            this.listBoxPreset.Items.Add(repeatName);
            this.listBoxPreset.SelectedIndex = this.listBoxPreset.Items.Count - 1;

            PresetRename(
                this.listBoxPreset.SelectedIndex,
                this.listBoxPreset.SelectedItem.ToString());
        }

        private void toolStripMenuItemPresetDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("这个预设将被删除。要继续吗？",
                "文件夹扫描设置 - 删除预设", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int listBoxSelectedIndex = this.listBoxPreset.SelectedIndex;
                int fileMatchSelectedIndex = fileMatchSetting.SelectedIndex;

                fileMatchSetting.FileMatchList.RemoveAt(fileMatchSelectedIndex);
                this.listBoxPreset.Items.RemoveAt(listBoxSelectedIndex);
            }
        }

        private void textBoxPresetItemRename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                this.textBoxPresetItemRename.Visible = false;
            }
        }

        private void textBoxPresetItemRename_Leave(object sender, EventArgs e)
        {
            int selectedIndex = this.listBoxPreset.SelectedIndex;
            string selectedItem = this.listBoxPreset.SelectedItem.ToString();
            string renameText = this.textBoxPresetItemRename.Text;

            if (selectedItem == renameText) return;

            this.listBoxPreset.Items.RemoveAt(selectedIndex);
            this.listBoxPreset.Items.Insert(selectedIndex, renameText);
            this.listBoxPreset.SelectedIndex = selectedIndex;
            this.textBoxPresetItemRename.Visible = false;

            FileMatch fileMatch = fileMatchSetting[selectedItem];
            Debug.Assert(fileMatch != null);
            fileMatch.Name = renameText;

            if (fileMatchSetting.SelectedName == selectedItem)
            {
                fileMatchSetting.SelectedName = renameText;
            }
        }

        private void checkedListBoxFileNameInclude_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            this.buttonFileNameIncludeDelete.Enabled = (
                this.checkedListBoxFileNameInclude.SelectedIndex != -1);
        }

        private void checkedListBoxFileNameExclude_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            this.buttonFileNameExcludeDelete.Enabled = (
                this.checkedListBoxFileNameExclude.SelectedIndex != -1);
        }
    }
}
