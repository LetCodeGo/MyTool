using System;
using System.Collections;
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
    public partial class ManagerComboBoxItemDialog : Form
    {
        private Action<Dictionary<string, int>, int> callBackAction = null;
        private Dictionary<string, int> itemDic = null;
        private List<string> itemList = null;
        private bool isLimitCharAllowed = false;

        public ManagerComboBoxItemDialog(
            Dictionary<string, int> itemDic, int selectedIndex,
            Action<Dictionary<string, int>, int> callBack,
            bool isLimitCharAllowed = false)
        {
            InitializeComponent();

            this.itemDic = itemDic;
            this.itemList = this.itemDic.Keys.ToList();
            this.callBackAction = callBack;
            this.isLimitCharAllowed = isLimitCharAllowed;

            if (itemList != null)
            {
                this.listBox.Items.AddRange(
                    this.itemList.ToArray());
            }
            if (selectedIndex >= 0 &&
                selectedIndex < this.listBox.Items.Count)
                this.listBox.SelectedIndex = selectedIndex;
            else this.buttonDelete.Enabled = false;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonDelete.Enabled = (this.listBox.SelectedIndex != -1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string inputText = this.textBoxInput.Text;
            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("不能是空白字符", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if ((!this.isLimitCharAllowed) &&
                GetFileOrFolder.IsInputContainLimitedChar(inputText))
            {
                DialogResult dialogRestul = MessageBox.Show(
                    string.Format(
                        "输入字符串中含有限制字符 \"{0}\" ，\n转成对应全角字符 \"{1}\" ？",
                        new string(GetFileOrFolder.limitedChars),
                        new string(GetFileOrFolder.replaceChars)), "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogRestul == DialogResult.Yes)
                {
                    inputText = GetFileOrFolder.ReplaceLimitedChar(inputText);
                }
                else return;
            }

            if (this.itemList.Contains(inputText))
            {
                MessageBox.Show(string.Format("已存在\n\"{0}\"",
                    inputText), "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                this.listBox.Items.Add(inputText);
                this.itemList.Add(inputText);
                this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.listBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                this.listBox.Items.RemoveAt(selectedIndex);
                this.itemList.RemoveAt(selectedIndex);

                selectedIndex--;
                if (selectedIndex < 0)
                    selectedIndex += this.listBox.Items.Count;

                this.listBox.SelectedIndex = selectedIndex;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> rstDic = new Dictionary<string, int>();
            this.itemList.ForEach(x =>
            {
                rstDic.Add(x,
                    this.itemDic.ContainsKey(x) ? this.itemDic[x] : 0);
            });
            this.itemDic = rstDic;

            callBackAction?.Invoke(
                this.itemDic, this.listBox.SelectedIndex);
            this.Close();
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonAdd_Click(null, null);
            }
        }
    }
}
