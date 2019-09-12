using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace MyTool
{
    public partial class QRCodeControl : UserControl
    {
        public QRCodeControl()
        {
            InitializeComponent();
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip;
        }

        private void BtnToUp_Click(object sender, EventArgs e)
        {
            this.textBox.Text = this.textBox.Text.ToUpper();
        }

        private void BtnToLow_Click(object sender, EventArgs e)
        {
            this.textBox.Text = this.textBox.Text.ToLower();
        }

        private void BtnFirstCharUp_Click(object sender, EventArgs e)
        {
            this.textBox.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.textBox.Text);
        }

        private void BtnToQRCode_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(
                this.textBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(8);
            this.pictureBox.Image = qrCodeImage;
        }

        private void ToolStripMenuItemSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "图片保存";
            saveImageDialog.Filter = "*.png|*.png";

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox.Image.Save(saveImageDialog.FileName);
            }
        }
    }
}
