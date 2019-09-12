namespace MyTool
{
    partial class SavePresetDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrompt = new System.Windows.Forms.Label();
            this.buttonCover = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrompt.ForeColor = System.Drawing.Color.Blue;
            this.labelPrompt.Location = new System.Drawing.Point(16, 13);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(249, 19);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "覆盖已存在预设“默认”？";
            // 
            // buttonCover
            // 
            this.buttonCover.BackColor = System.Drawing.Color.Transparent;
            this.buttonCover.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCover.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCover.ForeColor = System.Drawing.Color.Blue;
            this.buttonCover.Image = global::MyTool.Properties.Resources.ArrowRight;
            this.buttonCover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCover.Location = new System.Drawing.Point(40, 52);
            this.buttonCover.Name = "buttonCover";
            this.buttonCover.Size = new System.Drawing.Size(300, 40);
            this.buttonCover.TabIndex = 1;
            this.buttonCover.Text = "覆盖";
            this.buttonCover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCover.UseVisualStyleBackColor = false;
            this.buttonCover.Click += new System.EventHandler(this.buttonCover_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Blue;
            this.buttonCreate.Image = global::MyTool.Properties.Resources.ArrowRight;
            this.buttonCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreate.Location = new System.Drawing.Point(40, 112);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(300, 40);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "创建一个新的预设";
            this.buttonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SettingControlSavePresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 209);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCover);
            this.Controls.Add(this.labelPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingControlSavePresetForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件夹扫描设置 - 保存预设";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingControlSavePresetForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingControlSavePresetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonCover;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
    }
}