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
            this.textBoxStringInput = new System.Windows.Forms.TextBox();
            this.btnToUp = new System.Windows.Forms.Button();
            this.btnToLow = new System.Windows.Forms.Button();
            this.btnFirstCharUp = new System.Windows.Forms.Button();
            this.btnStringToQRCode = new System.Windows.Forms.Button();
            this.groupBoxString = new System.Windows.Forms.GroupBox();
            this.btnReplaceLimitChar = new System.Windows.Forms.Button();
            this.textBoxRepalceTo = new System.Windows.Forms.TextBox();
            this.textBoxReplaceFrom = new System.Windows.Forms.TextBox();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnMergeBlank = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxString.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStringInput
            // 
            this.textBoxStringInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStringInput.Location = new System.Drawing.Point(53, 18);
            this.textBoxStringInput.Name = "textBoxStringInput";
            this.textBoxStringInput.Size = new System.Drawing.Size(735, 21);
            this.textBoxStringInput.TabIndex = 0;
            // 
            // btnToUp
            // 
            this.btnToUp.Location = new System.Drawing.Point(53, 45);
            this.btnToUp.Name = "btnToUp";
            this.btnToUp.Size = new System.Drawing.Size(82, 25);
            this.btnToUp.TabIndex = 1;
            this.btnToUp.Text = "全部大写";
            this.btnToUp.UseVisualStyleBackColor = true;
            this.btnToUp.Click += new System.EventHandler(this.BtnToUp_Click);
            // 
            // btnToLow
            // 
            this.btnToLow.Location = new System.Drawing.Point(141, 45);
            this.btnToLow.Name = "btnToLow";
            this.btnToLow.Size = new System.Drawing.Size(82, 25);
            this.btnToLow.TabIndex = 2;
            this.btnToLow.Text = "全部小写";
            this.btnToLow.UseVisualStyleBackColor = true;
            this.btnToLow.Click += new System.EventHandler(this.BtnToLow_Click);
            // 
            // btnFirstCharUp
            // 
            this.btnFirstCharUp.Location = new System.Drawing.Point(229, 45);
            this.btnFirstCharUp.Name = "btnFirstCharUp";
            this.btnFirstCharUp.Size = new System.Drawing.Size(82, 25);
            this.btnFirstCharUp.TabIndex = 3;
            this.btnFirstCharUp.Text = "首字母大写";
            this.btnFirstCharUp.UseVisualStyleBackColor = true;
            this.btnFirstCharUp.Click += new System.EventHandler(this.BtnFirstCharUp_Click);
            // 
            // btnStringToQRCode
            // 
            this.btnStringToQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStringToQRCode.Location = new System.Drawing.Point(53, 105);
            this.btnStringToQRCode.Name = "btnStringToQRCode";
            this.btnStringToQRCode.Size = new System.Drawing.Size(735, 25);
            this.btnStringToQRCode.TabIndex = 4;
            this.btnStringToQRCode.Text = "生成二维码";
            this.btnStringToQRCode.UseVisualStyleBackColor = true;
            this.btnStringToQRCode.Click += new System.EventHandler(this.BtnStringToQRCode_Click);
            // 
            // groupBoxString
            // 
            this.groupBoxString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxString.Controls.Add(this.btnReplaceLimitChar);
            this.groupBoxString.Controls.Add(this.textBoxRepalceTo);
            this.groupBoxString.Controls.Add(this.textBoxReplaceFrom);
            this.groupBoxString.Controls.Add(this.btnReplaceAll);
            this.groupBoxString.Controls.Add(this.btnMergeBlank);
            this.groupBoxString.Controls.Add(this.label2);
            this.groupBoxString.Controls.Add(this.label1);
            this.groupBoxString.Controls.Add(this.textBoxStringInput);
            this.groupBoxString.Controls.Add(this.btnStringToQRCode);
            this.groupBoxString.Controls.Add(this.btnFirstCharUp);
            this.groupBoxString.Controls.Add(this.btnToUp);
            this.groupBoxString.Controls.Add(this.btnToLow);
            this.groupBoxString.Location = new System.Drawing.Point(3, 3);
            this.groupBoxString.Name = "groupBoxString";
            this.groupBoxString.Size = new System.Drawing.Size(794, 143);
            this.groupBoxString.TabIndex = 6;
            this.groupBoxString.TabStop = false;
            this.groupBoxString.Text = "字符串处理";
            // 
            // btnReplaceLimitChar
            // 
            this.btnReplaceLimitChar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplaceLimitChar.Location = new System.Drawing.Point(317, 74);
            this.btnReplaceLimitChar.Name = "btnReplaceLimitChar";
            this.btnReplaceLimitChar.Size = new System.Drawing.Size(471, 25);
            this.btnReplaceLimitChar.TabIndex = 10;
            this.btnReplaceLimitChar.Text = "系统限制字符转为对应全角字符（如 \\/:*?\"<>| 对应 ＼／：＊？“＜＞｜）";
            this.btnReplaceLimitChar.UseVisualStyleBackColor = true;
            this.btnReplaceLimitChar.Click += new System.EventHandler(this.BtnReplaceLimitChar_Click);
            // 
            // textBoxRepalceTo
            // 
            this.textBoxRepalceTo.Location = new System.Drawing.Point(141, 76);
            this.textBoxRepalceTo.Name = "textBoxRepalceTo";
            this.textBoxRepalceTo.Size = new System.Drawing.Size(82, 21);
            this.textBoxRepalceTo.TabIndex = 9;
            // 
            // textBoxReplaceFrom
            // 
            this.textBoxReplaceFrom.Location = new System.Drawing.Point(53, 76);
            this.textBoxReplaceFrom.Name = "textBoxReplaceFrom";
            this.textBoxReplaceFrom.Size = new System.Drawing.Size(82, 21);
            this.textBoxReplaceFrom.TabIndex = 8;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(229, 74);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(82, 25);
            this.btnReplaceAll.TabIndex = 5;
            this.btnReplaceAll.Text = "全部替换";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.BtnReplaceAll_Click);
            // 
            // btnMergeBlank
            // 
            this.btnMergeBlank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeBlank.Location = new System.Drawing.Point(317, 45);
            this.btnMergeBlank.Name = "btnMergeBlank";
            this.btnMergeBlank.Size = new System.Drawing.Size(471, 25);
            this.btnMergeBlank.TabIndex = 6;
            this.btnMergeBlank.Text = "连续空格合并为一个";
            this.btnMergeBlank.UseVisualStyleBackColor = true;
            this.btnMergeBlank.Click += new System.EventHandler(this.BtnMergeBlank_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入：";
            // 
            // QRCodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxString);
            this.Name = "QRCodeControl";
            this.Size = new System.Drawing.Size(800, 496);
            this.groupBoxString.ResumeLayout(false);
            this.groupBoxString.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStringInput;
        private System.Windows.Forms.Button btnToUp;
        private System.Windows.Forms.Button btnToLow;
        private System.Windows.Forms.Button btnFirstCharUp;
        private System.Windows.Forms.Button btnStringToQRCode;
        private System.Windows.Forms.GroupBox groupBoxString;
        private System.Windows.Forms.Button btnReplaceLimitChar;
        private System.Windows.Forms.TextBox textBoxRepalceTo;
        private System.Windows.Forms.TextBox textBoxReplaceFrom;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnMergeBlank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
