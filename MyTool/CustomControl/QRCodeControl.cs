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
using System.Text.RegularExpressions;

namespace MyTool
{
    public partial class QRCodeControl : UserControl
    {
        private Action CheckBoxTopMostNoChecked = null;
        private Action CheckBoxTopMostRestoreChecked = null;

        public QRCodeControl(
            Action CheckBoxTopMostNoChecked, Action CheckBoxTopMostRestoreChecked)
        {
            InitializeComponent();

            this.CheckBoxTopMostNoChecked = CheckBoxTopMostNoChecked;
            this.CheckBoxTopMostRestoreChecked = CheckBoxTopMostRestoreChecked;
        }

        private void BtnToUp_Click(object sender, EventArgs e)
        {
            this.textBoxStringInput.Text = this.textBoxStringInput.Text.ToUpper();
        }

        private void BtnToLow_Click(object sender, EventArgs e)
        {
            this.textBoxStringInput.Text = this.textBoxStringInput.Text.ToLower();
        }

        private void BtnFirstCharUp_Click(object sender, EventArgs e)
        {
            this.textBoxStringInput.Text =
                System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(
                    this.textBoxStringInput.Text);
        }

        private void BtnMergeBlank_Click(object sender, EventArgs e)
        {
            this.textBoxStringInput.Text =
                Regex.Replace(this.textBoxStringInput.Text, "\\s{2,}", " ");
        }

        private void BtnReplaceAll_Click(object sender, EventArgs e)
        {
            this.textBoxStringInput.Text =
                this.textBoxStringInput.Text.Replace(
                    this.textBoxReplaceFrom.Text, this.textBoxRepalceTo.Text);
        }

        private void BtnReplaceLimitChar_Click(object sender, EventArgs e)
        {
            this.textBoxStringInput.Text =
                GetFileOrFolder.ReplaceLimitedChar(this.textBoxStringInput.Text);
        }

        private void BtnStringToQRCode_Click(object sender, EventArgs e)
        {
            try
            {
                this.CheckBoxTopMostNoChecked?.Invoke();

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(
                    this.textBoxStringInput.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(8);

                QRCodeForm form = new QRCodeForm(qrCodeImage);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.CheckBoxTopMostRestoreChecked?.Invoke();
            }
        }
    }
}
