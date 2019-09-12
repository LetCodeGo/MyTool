namespace MyTool
{
    partial class QRCodeControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnToUp = new System.Windows.Forms.Button();
            this.btnToLow = new System.Windows.Forms.Button();
            this.btnFirstCharUp = new System.Windows.Forms.Button();
            this.btnToQRCode = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSavePicture = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(59, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(594, 21);
            this.textBox.TabIndex = 0;
            // 
            // btnToUp
            // 
            this.btnToUp.Location = new System.Drawing.Point(133, 67);
            this.btnToUp.Name = "btnToUp";
            this.btnToUp.Size = new System.Drawing.Size(80, 30);
            this.btnToUp.TabIndex = 1;
            this.btnToUp.Text = "大写";
            this.btnToUp.UseVisualStyleBackColor = true;
            this.btnToUp.Click += new System.EventHandler(this.BtnToUp_Click);
            // 
            // btnToLow
            // 
            this.btnToLow.Location = new System.Drawing.Point(256, 67);
            this.btnToLow.Name = "btnToLow";
            this.btnToLow.Size = new System.Drawing.Size(80, 30);
            this.btnToLow.TabIndex = 2;
            this.btnToLow.Text = "小写";
            this.btnToLow.UseVisualStyleBackColor = true;
            this.btnToLow.Click += new System.EventHandler(this.BtnToLow_Click);
            // 
            // btnFirstCharUp
            // 
            this.btnFirstCharUp.Location = new System.Drawing.Point(379, 67);
            this.btnFirstCharUp.Name = "btnFirstCharUp";
            this.btnFirstCharUp.Size = new System.Drawing.Size(80, 30);
            this.btnFirstCharUp.TabIndex = 3;
            this.btnFirstCharUp.Text = "首字母大写";
            this.btnFirstCharUp.UseVisualStyleBackColor = true;
            this.btnFirstCharUp.Click += new System.EventHandler(this.BtnFirstCharUp_Click);
            // 
            // btnToQRCode
            // 
            this.btnToQRCode.Location = new System.Drawing.Point(502, 67);
            this.btnToQRCode.Name = "btnToQRCode";
            this.btnToQRCode.Size = new System.Drawing.Size(80, 30);
            this.btnToQRCode.TabIndex = 4;
            this.btnToQRCode.Text = "二维码";
            this.btnToQRCode.UseVisualStyleBackColor = true;
            this.btnToQRCode.Click += new System.EventHandler(this.BtnToQRCode_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(197, 122);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSavePicture});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItemSavePicture
            // 
            this.toolStripMenuItemSavePicture.Name = "toolStripMenuItemSavePicture";
            this.toolStripMenuItemSavePicture.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSavePicture.Text = "保存图片";
            this.toolStripMenuItemSavePicture.Click += new System.EventHandler(this.ToolStripMenuItemSavePicture_Click);
            // 
            // QRCodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnToUp);
            this.Controls.Add(this.btnFirstCharUp);
            this.Controls.Add(this.btnToQRCode);
            this.Controls.Add(this.btnToLow);
            this.Name = "QRCodeControl";
            this.Size = new System.Drawing.Size(800, 496);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnToUp;
        private System.Windows.Forms.Button btnToLow;
        private System.Windows.Forms.Button btnFirstCharUp;
        private System.Windows.Forms.Button btnToQRCode;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSavePicture;
    }
}
