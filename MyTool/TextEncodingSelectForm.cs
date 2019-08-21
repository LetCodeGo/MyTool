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
    public partial class TextEncodingSelectForm : Form
    {
        private Encoding textEncoding = null;
        private string textEncodingString = "UNKNOWN";

        private string filePath = null;
        private byte[] textBytes = null;

        private ToolStripMenuItem preToolStripMenuItem = null;

        public Action<Encoding, EncodingSelectForNoBom> textEncodingSelectResult = null;

        private bool actionConfirm = true;

        public enum EncodingSelectForNoBom
        {
            OK = 0,
            SAME_WITH_ALL,
            SKIP,
            SKIP_ALL
        }

        public TextEncodingSelectForm(string filePath, byte[] textBytes)
        {
            InitializeComponent();

            this.filePath = filePath;
            this.textBytes = textBytes;
        }

        private void TextEncodingSelectForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = this.filePath;

            textEncoding = Encoding.GetEncoding("gb18030");
            textEncodingString = "GB18030";

            this.toolStripMenuItemGB18030.Enabled = false;
            preToolStripMenuItem = this.toolStripMenuItemGB18030;

            UpdateRichTextBox();
        }

        private void UpdateRichTextBox()
        {
            string text = textEncoding.GetString(textBytes);
            this.richTextBox.Text =
                string.Format("******************************  {0}  ******************************\r\n\r\n",
                textEncodingString) + text;
        }

        private void toolStripMenuItemUTF8_Click(object sender, EventArgs e)
        {
            textEncoding = new UTF8Encoding(false);
            textEncodingString = "UTF-8 NO BOM";

            preToolStripMenuItem.Enabled = true;
            this.toolStripMenuItemUTF8.Enabled = false;
            preToolStripMenuItem = this.toolStripMenuItemUTF8;

            UpdateRichTextBox();
        }

        private void toolStripMenuItemGB18030_Click(object sender, EventArgs e)
        {
            textEncoding = Encoding.GetEncoding("gb18030");
            textEncodingString = "GB18030";

            preToolStripMenuItem.Enabled = true;
            this.toolStripMenuItemGB18030.Enabled = false;
            preToolStripMenuItem = this.toolStripMenuItemGB18030;

            UpdateRichTextBox();
        }

        private void toolStripMenuItemBig5_Click(object sender, EventArgs e)
        {
            textEncoding = Encoding.GetEncoding("big5");
            textEncodingString = "BIG5";

            preToolStripMenuItem.Enabled = true;
            this.toolStripMenuItemBig5.Enabled = false;
            preToolStripMenuItem = this.toolStripMenuItemBig5;

            UpdateRichTextBox();
        }

        private void toolStripMenuItemShiftJIS_Click(object sender, EventArgs e)
        {
            textEncoding = Encoding.GetEncoding("shift_jis");
            textEncodingString = "SHIFT-JIS";

            preToolStripMenuItem.Enabled = true;
            this.toolStripMenuItemShiftJIS.Enabled = false;
            preToolStripMenuItem = this.toolStripMenuItemShiftJIS;

            UpdateRichTextBox();
        }

        private void toolStripMenuItemOK_Click(object sender, EventArgs e)
        {
            bool actionCancel = false;

            if (this.actionConfirm)
            {
                if (MessageBox.Show(
                    string.Format("确定使用 \'{0}\' 解码该文件？", textEncodingString),
                    "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.Cancel)
                {
                    actionCancel = true;
                }
            }

            if (!actionCancel)
            {
                textEncodingSelectResult?.Invoke(textEncoding, EncodingSelectForNoBom.OK);
                this.Close();
            }
        }

        private void toolStripMenuItemOKWithAll_Click(object sender, EventArgs e)
        {
            bool actionCancel = false;

            if (this.actionConfirm)
            {
                if (MessageBox.Show(
                    string.Format("确定使用 \'{0}\' 解码该文件及此后所有的不带BOM文件？",
                    textEncodingString),
                    "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.Cancel)
                {
                    actionCancel = true;
                }
            }

            if (!actionCancel)
            {
                textEncodingSelectResult?.Invoke(textEncoding, EncodingSelectForNoBom.SAME_WITH_ALL);
                this.Close();
            }
        }

        private void toolStripMenuItemSkip_Click(object sender, EventArgs e)
        {
            bool actionCancel = false;

            if (this.actionConfirm)
            {
                if (MessageBox.Show(
                    "确定跳过该文件？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.Cancel)
                {
                    actionCancel = true;
                }
            }

            if (!actionCancel)
            {
                textEncoding = null;
                textEncodingString = "UNKNOWN";

                textEncodingSelectResult?.Invoke(textEncoding, EncodingSelectForNoBom.SKIP);
                this.Close();
            }
        }

        private void toolStripMenuItemSkipAll_Click(object sender, EventArgs e)
        {
            bool actionCancel = false;

            if (this.actionConfirm)
            {
                if (MessageBox.Show(
                    "确定跳过该文件及此后所有的不带BOM文件？",
                    "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.Cancel)
                {
                    actionCancel = true;
                }
            }

            if (!actionCancel)
            {
                textEncoding = null;
                textEncodingString = "UNKNOWN";

                textEncodingSelectResult?.Invoke(textEncoding, EncodingSelectForNoBom.SKIP_ALL);
                this.Close();
            }
        }
    }
}
