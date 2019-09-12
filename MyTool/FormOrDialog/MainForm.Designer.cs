namespace MyTool
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.checkBoxDragWithAppend = new System.Windows.Forms.CheckBox();
            this.comboBoxFileMatch = new System.Windows.Forms.ComboBox();
            this.labelFileMatch = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Setting.png");
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 557);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.checkBoxDragWithAppend);
            this.panelContainer.Controls.Add(this.comboBoxFileMatch);
            this.panelContainer.Controls.Add(this.labelFileMatch);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(984, 554);
            this.panelContainer.TabIndex = 3;
            // 
            // checkBoxDragWithAppend
            // 
            this.checkBoxDragWithAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDragWithAppend.AutoSize = true;
            this.checkBoxDragWithAppend.Location = new System.Drawing.Point(617, 6);
            this.checkBoxDragWithAppend.Name = "checkBoxDragWithAppend";
            this.checkBoxDragWithAppend.Size = new System.Drawing.Size(84, 16);
            this.checkBoxDragWithAppend.TabIndex = 5;
            this.checkBoxDragWithAppend.Text = "拖曳时追加";
            this.checkBoxDragWithAppend.UseVisualStyleBackColor = true;
            this.checkBoxDragWithAppend.CheckedChanged += new System.EventHandler(this.checkBoxDragWithAppend_CheckedChanged);
            // 
            // comboBoxFileMatch
            // 
            this.comboBoxFileMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFileMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileMatch.FormattingEnabled = true;
            this.comboBoxFileMatch.Location = new System.Drawing.Point(771, 3);
            this.comboBoxFileMatch.Name = "comboBoxFileMatch";
            this.comboBoxFileMatch.Size = new System.Drawing.Size(210, 20);
            this.comboBoxFileMatch.TabIndex = 2;
            this.comboBoxFileMatch.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileMatch_SelectedIndexChanged);
            // 
            // labelFileMatch
            // 
            this.labelFileMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileMatch.AutoSize = true;
            this.labelFileMatch.Location = new System.Drawing.Point(704, 7);
            this.labelFileMatch.Name = "labelFileMatch";
            this.labelFileMatch.Size = new System.Drawing.Size(65, 12);
            this.labelFileMatch.TabIndex = 1;
            this.labelFileMatch.Text = "文件匹配：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ComboBox comboBoxFileMatch;
        private System.Windows.Forms.Label labelFileMatch;
        private System.Windows.Forms.CheckBox checkBoxDragWithAppend;
    }
}

