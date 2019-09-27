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
    public partial class QRCodeForm : Form
    {
        public QRCodeForm(Bitmap qrCodeImage)
        {
            InitializeComponent();

            this.pictureBox.ContextMenuStrip = this.contextMenuStrip;

            int width = qrCodeImage.Width;
            if (width > 400)
            {
                width = 400;
                this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.Size = new Size(width + 40, width + 63);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.pictureBox.Image = qrCodeImage;
        }

        private void ToolStripMenuItemSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "保存图片";
            saveImageDialog.Filter = "*.png|*.png";

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox.Image.Save(saveImageDialog.FileName);
            }
        }
    }
}
