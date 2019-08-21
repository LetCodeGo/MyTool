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
    public partial class AbortIgnoreDialog : Form
    {
        public AbortIgnoreDialog(string text, string caption)
        {
            InitializeComponent();

            this.ControlBox = false;

            int locationX = (this.Width - this.panelText.Width) / 2;
            int locationY = (this.Height - this.panelButton.Height -
                this.panelText.Height - SystemInformation.CaptionHeight - 8) / 2;
            this.panelText.Location = new Point(locationX, locationY);

            SetFormSize(text);

            this.Text = caption;
            this.labelText.Text = text;
        }

        private void SetFormSize(string text)
        {
            string[] strs = text.Trim(new char[] { '\n' })
                .Replace("\r", "").Split(new char[] { '\n' });

            Size[] sizes = new Size[strs.Length];

            for (int i = 0; i < strs.Length; i++)
            {
                sizes[i] = TextRenderer.MeasureText(strs[i], this.labelText.Font);
            }

            int rowCapacity = 0;
            int rowReal = 0;
            int number = 0;

            int setWidth = 0;
            int setHeight = 0;

            do
            {
                rowReal = 0;
                setWidth = this.panelText.Width + number * 10;
                setHeight = this.panelText.Height + (int)(number * 6.18);
                rowCapacity = setHeight / sizes[0].Height;

                foreach (Point pt in sizes)
                {
                    if (pt.X <= this.panelText.Width) rowReal++;
                    else rowReal += (int)Math.Ceiling((double)pt.X / this.panelText.Width);
                }

                number++;
            }
            while (rowCapacity < rowReal);

            this.Width += (setWidth - this.panelText.Width);
            this.Height += (setHeight - this.panelText.Height);
        }

        // 鼠标双击标题栏消息
        private const int WM_NCLBUTTONDBLCLK = 0xA3;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                // 屏蔽双击最大化
                case WM_NCLBUTTONDBLCLK:
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void buttonIgnore_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }
    }
}
