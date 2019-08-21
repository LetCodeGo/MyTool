namespace MyTool
{
    partial class OtherToolControl
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
            this.btnCheckMediaInfo = new System.Windows.Forms.Button();
            this.btnCompletedBluRayFolder = new System.Windows.Forms.Button();
            this.groupBoxBackOrMove = new System.Windows.Forms.GroupBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnBackupApply = new System.Windows.Forms.Button();
            this.btnTorrent = new System.Windows.Forms.Button();
            this.groupBoxBackOrMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckMediaInfo
            // 
            this.btnCheckMediaInfo.AllowDrop = true;
            this.btnCheckMediaInfo.Location = new System.Drawing.Point(15, 229);
            this.btnCheckMediaInfo.Name = "btnCheckMediaInfo";
            this.btnCheckMediaInfo.Size = new System.Drawing.Size(156, 40);
            this.btnCheckMediaInfo.TabIndex = 32;
            this.btnCheckMediaInfo.Text = "查看媒体文件信息";
            this.btnCheckMediaInfo.UseVisualStyleBackColor = true;
            this.btnCheckMediaInfo.Click += new System.EventHandler(this.btnCheckMediaInfo_Click);
            this.btnCheckMediaInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnCheckMediaInfo_DragDrop);
            this.btnCheckMediaInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnCheckMediaInfo_DragEnter);
            // 
            // btnCompletedBluRayFolder
            // 
            this.btnCompletedBluRayFolder.AllowDrop = true;
            this.btnCompletedBluRayFolder.Location = new System.Drawing.Point(15, 164);
            this.btnCompletedBluRayFolder.Name = "btnCompletedBluRayFolder";
            this.btnCompletedBluRayFolder.Size = new System.Drawing.Size(156, 40);
            this.btnCompletedBluRayFolder.TabIndex = 31;
            this.btnCompletedBluRayFolder.Text = "蓝光文件夹补全";
            this.btnCompletedBluRayFolder.UseVisualStyleBackColor = true;
            this.btnCompletedBluRayFolder.Click += new System.EventHandler(this.btnCompletedBluRayFolder_Click);
            this.btnCompletedBluRayFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnCompletedBluRayFolder_DragDrop);
            this.btnCompletedBluRayFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnCompletedBluRayFolder_DragEnter);
            // 
            // groupBoxBackOrMove
            // 
            this.groupBoxBackOrMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBackOrMove.Controls.Add(this.tbFrom);
            this.groupBoxBackOrMove.Controls.Add(this.btnFrom);
            this.groupBoxBackOrMove.Controls.Add(this.btnMove);
            this.groupBoxBackOrMove.Controls.Add(this.btnDestination);
            this.groupBoxBackOrMove.Controls.Add(this.tbTo);
            this.groupBoxBackOrMove.Controls.Add(this.btnBackupApply);
            this.groupBoxBackOrMove.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBackOrMove.Name = "groupBoxBackOrMove";
            this.groupBoxBackOrMove.Size = new System.Drawing.Size(669, 112);
            this.groupBoxBackOrMove.TabIndex = 33;
            this.groupBoxBackOrMove.TabStop = false;
            this.groupBoxBackOrMove.Text = "备份或移动";
            // 
            // tbFrom
            // 
            this.tbFrom.AllowDrop = true;
            this.tbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrom.Location = new System.Drawing.Point(93, 20);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(570, 21);
            this.tbFrom.TabIndex = 18;
            this.tbFrom.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFrom_DragDrop);
            this.tbFrom.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFrom_DragEnter);
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(12, 19);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(75, 23);
            this.btnFrom.TabIndex = 15;
            this.btnFrom.Text = "源";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(93, 77);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 20;
            this.btnMove.Text = "移动";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(12, 48);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(75, 23);
            this.btnDestination.TabIndex = 17;
            this.btnDestination.Text = "到";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // tbTo
            // 
            this.tbTo.AllowDrop = true;
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.Location = new System.Drawing.Point(93, 49);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(570, 21);
            this.tbTo.TabIndex = 16;
            this.tbTo.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbTo_DragDrop);
            this.tbTo.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbTo_DragEnter);
            // 
            // btnBackupApply
            // 
            this.btnBackupApply.Location = new System.Drawing.Point(12, 77);
            this.btnBackupApply.Name = "btnBackupApply";
            this.btnBackupApply.Size = new System.Drawing.Size(75, 23);
            this.btnBackupApply.TabIndex = 19;
            this.btnBackupApply.Text = "备份";
            this.btnBackupApply.UseVisualStyleBackColor = true;
            this.btnBackupApply.Click += new System.EventHandler(this.btnBackupApply_Click);
            // 
            // btnTorrent
            // 
            this.btnTorrent.AllowDrop = true;
            this.btnTorrent.Location = new System.Drawing.Point(15, 302);
            this.btnTorrent.Name = "btnTorrent";
            this.btnTorrent.Size = new System.Drawing.Size(156, 40);
            this.btnTorrent.TabIndex = 34;
            this.btnTorrent.Text = "torrent文件处理";
            this.btnTorrent.UseVisualStyleBackColor = true;
            this.btnTorrent.Click += new System.EventHandler(this.btnTorrent_Click);
            this.btnTorrent.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnTorrent_DragDrop);
            this.btnTorrent.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnTorrent_DragEnter);
            // 
            // OtherToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTorrent);
            this.Controls.Add(this.groupBoxBackOrMove);
            this.Controls.Add(this.btnCheckMediaInfo);
            this.Controls.Add(this.btnCompletedBluRayFolder);
            this.Name = "OtherToolControl";
            this.Size = new System.Drawing.Size(675, 401);
            this.groupBoxBackOrMove.ResumeLayout(false);
            this.groupBoxBackOrMove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckMediaInfo;
        private System.Windows.Forms.Button btnCompletedBluRayFolder;
        private System.Windows.Forms.GroupBox groupBoxBackOrMove;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Button btnBackupApply;
        private System.Windows.Forms.Button btnTorrent;
    }
}
