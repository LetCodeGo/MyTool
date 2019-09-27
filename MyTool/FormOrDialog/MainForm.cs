using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool
{
    public partial class MainForm : Form
    {
        private Action SaveControlConfigAction = null;
        private bool CheckBoxTopMostRestoredState = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Tool;

            FileMatchSetting fileMatchSetting =
                    Setting.GetInstance().settingData.fileMatchSetting;

            this.comboBoxFileMatch.Items.Clear();
            this.comboBoxFileMatch.Items.AddRange(
                    fileMatchSetting.GetAllFileMatchName());
            this.comboBoxFileMatch.Text =
                fileMatchSetting.SelectedName;

            this.checkBoxDragWithAppend.Checked =
                Setting.GetInstance().settingData.isDragWithAppend;

            TableControlEx tableControlEx = new TableControlEx();
            tableControlEx.SelectedIndexChanged += TableControlEx_SelectedIndexChanged;
            tableControlEx.Dock = DockStyle.Fill;

            string[] pageNames = new string[] {
                "对比重命名", "重命名",
                "文本处理", "字符串或二维码处理", "其他", "文件匹配设置" };

            foreach (string pageName in pageNames)
            {
                TabPage tp = new TabPage(pageName);
                tp.Dock = DockStyle.Fill;

                Control cl = null;
                switch (pageName)
                {
                    case "对比重命名":
                        cl = new ComparedRenameControl(
                            CheckBoxTopMost_NoChecked, CheckBoxTopMost_RestoreChecked);
                        this.SaveControlConfigAction +=
                            (cl as ComparedRenameControl).SaveConfig;
                        break;
                    case "重命名":
                        cl = new FileOrFolderRenameControl(
                            CheckBoxTopMost_NoChecked, CheckBoxTopMost_RestoreChecked);
                        this.SaveControlConfigAction +=
                            (cl as FileOrFolderRenameControl).SaveConfig;
                        break;
                    case "文本处理":
                        cl = new TextProcessControl(
                            CheckBoxTopMost_NoChecked, CheckBoxTopMost_RestoreChecked);
                        break;
                    case "字符串或二维码处理":
                        cl = new QRCodeControl(
                            CheckBoxTopMost_NoChecked, CheckBoxTopMost_RestoreChecked);
                        break;
                    case "其他":
                        cl = new OtherToolControl(
                            CheckBoxTopMost_NoChecked, CheckBoxTopMost_RestoreChecked);
                        break;
                    case "文件匹配设置":
                        cl = new FileMatchSettingControl(
                            CheckBoxTopMost_NoChecked, CheckBoxTopMost_RestoreChecked);
                        break;
                    default:
                        break;
                }

                if (cl != null)
                {
                    cl.Dock = DockStyle.Fill;
                    tp.Controls.Add(cl);
                }
                tableControlEx.Controls.Add(tp);
            }

            this.panelContainer.Controls.Add(tableControlEx);

            this.TopMost = this.checkBoxTopMost.Checked;
        }

        private void TableControlEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableControlEx tableControlEx = sender as TableControlEx;
            if (tableControlEx.Tag != null &&
                tableControlEx.Tag.ToString() == "文件匹配设置")
            {
                FileMatchSetting fileMatchSetting =
                    Setting.GetInstance().settingData.fileMatchSetting;

                this.comboBoxFileMatch.Items.Clear();
                this.comboBoxFileMatch.Items.AddRange(
                        fileMatchSetting.GetAllFileMatchName());
                this.comboBoxFileMatch.Text =
                    fileMatchSetting.SelectedName;
            }
            tableControlEx.Tag = tableControlEx.SelectedTab.Text;
        }

        private void SetFileMatchCombox(List<string> itemsList, int selectedIndex)
        {
            this.comboBoxFileMatch.Items.Clear();
            this.comboBoxFileMatch.SelectedIndex = selectedIndex;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SaveControlConfigAction?.Invoke();
            Setting.GetInstance().Save();
        }

        private void checkBoxDragWithAppend_CheckedChanged(object sender, EventArgs e)
        {
            Setting.GetInstance().settingData.isDragWithAppend =
                this.checkBoxDragWithAppend.Checked;
        }

        private void comboBoxFileMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting.GetInstance().settingData.fileMatchSetting.SelectedName =
                this.comboBoxFileMatch.SelectedItem.ToString();
        }

        private void CheckBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.checkBoxTopMost.Checked;
        }

        private void CheckBoxTopMost_NoChecked()
        {
            CheckBoxTopMostRestoredState = this.checkBoxTopMost.Checked;
            this.checkBoxTopMost.Checked = false;
        }

        private void CheckBoxTopMost_RestoreChecked()
        {
            this.checkBoxTopMost.Checked = CheckBoxTopMostRestoredState;
        }
    }
}
