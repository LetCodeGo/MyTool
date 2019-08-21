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
    public partial class SavePresetDialog : Form
    {
        public enum SavePresetState
        {
            COVER,
            CREATE,
            CANCEL,
        }
        public delegate void SavePresetFormState(SavePresetState state);
        public SavePresetFormState savePresetFormStateAction = null;
        private SavePresetState savePresetState = SavePresetState.CANCEL;

        public SavePresetDialog(string coverName)
        {
            InitializeComponent();

            this.labelPrompt.Text =
                string.Format("覆盖已存在预设“{0}”？", coverName);
        }

        /// <summary>  
        /// 设置透明按钮样式  
        /// </summary>  
        private void SetBtnStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.LightGray;
        }

        private void SettingControlSavePresetForm_Load(
            object sender, EventArgs e)
        {
            SetBtnStyle(this.buttonCover);
            SetBtnStyle(this.buttonCreate);

            this.buttonCover.MouseHover += Button_MouseHover;
            this.buttonCover.MouseLeave += Button_MouseLeave;
            this.buttonCreate.MouseHover += Button_MouseHover;
            this.buttonCreate.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void buttonCover_Click(object sender, EventArgs e)
        {
            this.savePresetState = SavePresetState.COVER;
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.savePresetState = SavePresetState.CREATE;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.savePresetState = SavePresetState.CANCEL;
            this.Close();
        }

        private void SettingControlSavePresetForm_FormClosed(
            object sender, FormClosedEventArgs e)
        {
            savePresetFormStateAction?.Invoke(this.savePresetState);
        }
    }
}
