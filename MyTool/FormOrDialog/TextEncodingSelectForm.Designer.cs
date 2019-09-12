namespace MyTool
{
    partial class TextEncodingSelectForm
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemUTF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGB18030 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBig5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShiftJIS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOKWithAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSkip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSkipAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 28);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(960, 539);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUTF8,
            this.toolStripMenuItemGB18030,
            this.toolStripMenuItemBig5,
            this.toolStripMenuItemShiftJIS,
            this.toolStripMenuItemOK,
            this.toolStripMenuItemOKWithAll,
            this.toolStripMenuItemSkip,
            this.toolStripMenuItemSkipAll});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItemUTF8
            // 
            this.toolStripMenuItemUTF8.Name = "toolStripMenuItemUTF8";
            this.toolStripMenuItemUTF8.Size = new System.Drawing.Size(110, 21);
            this.toolStripMenuItemUTF8.Text = "使用 UTF-8 编码";
            this.toolStripMenuItemUTF8.Click += new System.EventHandler(this.toolStripMenuItemUTF8_Click);
            // 
            // toolStripMenuItemGB18030
            // 
            this.toolStripMenuItemGB18030.Name = "toolStripMenuItemGB18030";
            this.toolStripMenuItemGB18030.Size = new System.Drawing.Size(128, 21);
            this.toolStripMenuItemGB18030.Text = "使用 GB18030 编码";
            this.toolStripMenuItemGB18030.Click += new System.EventHandler(this.toolStripMenuItemGB18030_Click);
            // 
            // toolStripMenuItemBig5
            // 
            this.toolStripMenuItemBig5.Name = "toolStripMenuItemBig5";
            this.toolStripMenuItemBig5.Size = new System.Drawing.Size(102, 21);
            this.toolStripMenuItemBig5.Text = "使用 Big5 编码";
            this.toolStripMenuItemBig5.Click += new System.EventHandler(this.toolStripMenuItemBig5_Click);
            // 
            // toolStripMenuItemShiftJIS
            // 
            this.toolStripMenuItemShiftJIS.Name = "toolStripMenuItemShiftJIS";
            this.toolStripMenuItemShiftJIS.Size = new System.Drawing.Size(122, 21);
            this.toolStripMenuItemShiftJIS.Text = "使用 Shift-JIS 编码";
            this.toolStripMenuItemShiftJIS.Click += new System.EventHandler(this.toolStripMenuItemShiftJIS_Click);
            // 
            // toolStripMenuItemOK
            // 
            this.toolStripMenuItemOK.Name = "toolStripMenuItemOK";
            this.toolStripMenuItemOK.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemOK.Text = "确定";
            this.toolStripMenuItemOK.Click += new System.EventHandler(this.toolStripMenuItemOK_Click);
            // 
            // toolStripMenuItemOKWithAll
            // 
            this.toolStripMenuItemOKWithAll.Name = "toolStripMenuItemOKWithAll";
            this.toolStripMenuItemOKWithAll.Size = new System.Drawing.Size(206, 21);
            this.toolStripMenuItemOKWithAll.Text = "确定（此后无BOM的也用此编码）";
            this.toolStripMenuItemOKWithAll.Click += new System.EventHandler(this.toolStripMenuItemOKWithAll_Click);
            // 
            // toolStripMenuItemSkip
            // 
            this.toolStripMenuItemSkip.Name = "toolStripMenuItemSkip";
            this.toolStripMenuItemSkip.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemSkip.Text = "跳过";
            this.toolStripMenuItemSkip.Click += new System.EventHandler(this.toolStripMenuItemSkip_Click);
            // 
            // toolStripMenuItemSkipAll
            // 
            this.toolStripMenuItemSkipAll.Name = "toolStripMenuItemSkipAll";
            this.toolStripMenuItemSkipAll.Size = new System.Drawing.Size(182, 21);
            this.toolStripMenuItemSkipAll.Text = "跳过（此后无BOM的也跳过）";
            this.toolStripMenuItemSkipAll.Click += new System.EventHandler(this.toolStripMenuItemSkipAll_Click);
            // 
            // TextEncodingSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "TextEncodingSelectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TextEncodingSelectForm";
            this.Load += new System.EventHandler(this.TextEncodingSelectForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUTF8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOK;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGB18030;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBig5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShiftJIS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSkip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOKWithAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSkipAll;
    }
}