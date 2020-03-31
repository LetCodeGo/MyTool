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
            this.btnOther = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBatchFiles = new System.Windows.Forms.TextBox();
            this.tbBatchTemplate = new System.Windows.Forms.ComboBox();
            this.btnBatchCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTxtFormatTo3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTxtFormatMatch3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTxtFormatTo2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTxtFormatMatch2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTxtFormatTo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTxtFormatMatch1 = new System.Windows.Forms.ComboBox();
            this.btnTxtFormatToEpub = new System.Windows.Forms.Button();
            this.groupBoxTextCompare = new System.Windows.Forms.GroupBox();
            this.btnTextCompare = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxCompare1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCompare2 = new System.Windows.Forms.RichTextBox();
            this.groupBoxBackOrMove.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTextCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckMediaInfo
            // 
            this.btnCheckMediaInfo.AllowDrop = true;
            this.btnCheckMediaInfo.Location = new System.Drawing.Point(15, 432);
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
            this.btnCompletedBluRayFolder.Location = new System.Drawing.Point(15, 386);
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
            this.groupBoxBackOrMove.Size = new System.Drawing.Size(921, 112);
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
            this.tbFrom.Size = new System.Drawing.Size(822, 21);
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
            this.tbTo.Size = new System.Drawing.Size(822, 21);
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
            // btnOther
            // 
            this.btnOther.AllowDrop = true;
            this.btnOther.Location = new System.Drawing.Point(15, 478);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(156, 40);
            this.btnOther.TabIndex = 34;
            this.btnOther.Text = "其他";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            this.btnOther.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnOther_DragDrop);
            this.btnOther.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnOther_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbBatchFiles);
            this.groupBox1.Controls.Add(this.tbBatchTemplate);
            this.groupBox1.Controls.Add(this.btnBatchCreate);
            this.groupBox1.Location = new System.Drawing.Point(3, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 112);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "批处理生成";
            // 
            // tbBatchFiles
            // 
            this.tbBatchFiles.AllowDrop = true;
            this.tbBatchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBatchFiles.Location = new System.Drawing.Point(12, 20);
            this.tbBatchFiles.Name = "tbBatchFiles";
            this.tbBatchFiles.Size = new System.Drawing.Size(903, 21);
            this.tbBatchFiles.TabIndex = 18;
            this.tbBatchFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbBatchFiles_DragDrop);
            this.tbBatchFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbBatchFiles_DragEnter);
            // 
            // tbBatchTemplate
            // 
            this.tbBatchTemplate.AllowDrop = true;
            this.tbBatchTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBatchTemplate.Items.AddRange(new object[] {
            "\"D:\\\\Citra_3DS\\\\ciatocci\\\\makerom-x86_64.exe\" -ciatocci \"{0}\"",
            "python \"D:\\\\Citra_3DS\\\\ciatocci\\\\3ds_decrypt_v2.py\" \"{0}\""});
            this.tbBatchTemplate.Location = new System.Drawing.Point(12, 49);
            this.tbBatchTemplate.Name = "tbBatchTemplate";
            this.tbBatchTemplate.Size = new System.Drawing.Size(903, 20);
            this.tbBatchTemplate.TabIndex = 16;
            // 
            // btnBatchCreate
            // 
            this.btnBatchCreate.Location = new System.Drawing.Point(12, 77);
            this.btnBatchCreate.Name = "btnBatchCreate";
            this.btnBatchCreate.Size = new System.Drawing.Size(75, 23);
            this.btnBatchCreate.TabIndex = 19;
            this.btnBatchCreate.Text = "生成";
            this.btnBatchCreate.UseVisualStyleBackColor = true;
            this.btnBatchCreate.Click += new System.EventHandler(this.btnBatchCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbTxtFormatTo3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbTxtFormatMatch3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTxtFormatTo2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbTxtFormatMatch2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbTxtFormatTo1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbTxtFormatMatch1);
            this.groupBox2.Controls.Add(this.btnTxtFormatToEpub);
            this.groupBox2.Location = new System.Drawing.Point(3, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 141);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calibre Txt To Epub";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "格式化为";
            // 
            // cbTxtFormatTo3
            // 
            this.cbTxtFormatTo3.AllowDrop = true;
            this.cbTxtFormatTo3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTxtFormatTo3.Items.AddRange(new object[] {
            "\"D:\\\\Citra_3DS\\\\ciatocci\\\\makerom-x86_64.exe\" -ciatocci \"{0}\"",
            "python \"D:\\\\Citra_3DS\\\\ciatocci\\\\3ds_decrypt_v2.py\" \"{0}\""});
            this.cbTxtFormatTo3.Location = new System.Drawing.Point(541, 75);
            this.cbTxtFormatTo3.Name = "cbTxtFormatTo3";
            this.cbTxtFormatTo3.Size = new System.Drawing.Size(374, 20);
            this.cbTxtFormatTo3.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "三级标题";
            // 
            // cbTxtFormatMatch3
            // 
            this.cbTxtFormatMatch3.AllowDrop = true;
            this.cbTxtFormatMatch3.Items.AddRange(new object[] {
            "\"D:\\\\Citra_3DS\\\\ciatocci\\\\makerom-x86_64.exe\" -ciatocci \"{0}\"",
            "python \"D:\\\\Citra_3DS\\\\ciatocci\\\\3ds_decrypt_v2.py\" \"{0}\""});
            this.cbTxtFormatMatch3.Location = new System.Drawing.Point(69, 75);
            this.cbTxtFormatMatch3.Name = "cbTxtFormatMatch3";
            this.cbTxtFormatMatch3.Size = new System.Drawing.Size(374, 20);
            this.cbTxtFormatMatch3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "格式化为";
            // 
            // cbTxtFormatTo2
            // 
            this.cbTxtFormatTo2.AllowDrop = true;
            this.cbTxtFormatTo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTxtFormatTo2.Items.AddRange(new object[] {
            "\"D:\\\\Citra_3DS\\\\ciatocci\\\\makerom-x86_64.exe\" -ciatocci \"{0}\"",
            "python \"D:\\\\Citra_3DS\\\\ciatocci\\\\3ds_decrypt_v2.py\" \"{0}\""});
            this.cbTxtFormatTo2.Location = new System.Drawing.Point(541, 46);
            this.cbTxtFormatTo2.Name = "cbTxtFormatTo2";
            this.cbTxtFormatTo2.Size = new System.Drawing.Size(374, 20);
            this.cbTxtFormatTo2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "二级标题";
            // 
            // cbTxtFormatMatch2
            // 
            this.cbTxtFormatMatch2.AllowDrop = true;
            this.cbTxtFormatMatch2.Items.AddRange(new object[] {
            "\"D:\\\\Citra_3DS\\\\ciatocci\\\\makerom-x86_64.exe\" -ciatocci \"{0}\"",
            "python \"D:\\\\Citra_3DS\\\\ciatocci\\\\3ds_decrypt_v2.py\" \"{0}\""});
            this.cbTxtFormatMatch2.Location = new System.Drawing.Point(69, 46);
            this.cbTxtFormatMatch2.Name = "cbTxtFormatMatch2";
            this.cbTxtFormatMatch2.Size = new System.Drawing.Size(374, 20);
            this.cbTxtFormatMatch2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "格式化为";
            // 
            // cbTxtFormatTo1
            // 
            this.cbTxtFormatTo1.AllowDrop = true;
            this.cbTxtFormatTo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTxtFormatTo1.Items.AddRange(new object[] {
            "\"D:\\\\Citra_3DS\\\\ciatocci\\\\makerom-x86_64.exe\" -ciatocci \"{0}\"",
            "python \"D:\\\\Citra_3DS\\\\ciatocci\\\\3ds_decrypt_v2.py\" \"{0}\""});
            this.cbTxtFormatTo1.Location = new System.Drawing.Point(541, 20);
            this.cbTxtFormatTo1.Name = "cbTxtFormatTo1";
            this.cbTxtFormatTo1.Size = new System.Drawing.Size(374, 20);
            this.cbTxtFormatTo1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "一级标题";
            // 
            // cbTxtFormatMatch1
            // 
            this.cbTxtFormatMatch1.AllowDrop = true;
            this.cbTxtFormatMatch1.Items.AddRange(new object[] {
            "\"D:\\\\Citra_3DS\\\\ciatocci\\\\makerom-x86_64.exe\" -ciatocci \"{0}\"",
            "python \"D:\\\\Citra_3DS\\\\ciatocci\\\\3ds_decrypt_v2.py\" \"{0}\""});
            this.cbTxtFormatMatch1.Location = new System.Drawing.Point(69, 20);
            this.cbTxtFormatMatch1.Name = "cbTxtFormatMatch1";
            this.cbTxtFormatMatch1.Size = new System.Drawing.Size(374, 20);
            this.cbTxtFormatMatch1.TabIndex = 16;
            // 
            // btnTxtFormatToEpub
            // 
            this.btnTxtFormatToEpub.Location = new System.Drawing.Point(12, 101);
            this.btnTxtFormatToEpub.Name = "btnTxtFormatToEpub";
            this.btnTxtFormatToEpub.Size = new System.Drawing.Size(156, 23);
            this.btnTxtFormatToEpub.TabIndex = 19;
            this.btnTxtFormatToEpub.Text = "添加txt文件";
            this.btnTxtFormatToEpub.UseVisualStyleBackColor = true;
            this.btnTxtFormatToEpub.Click += new System.EventHandler(this.btnTxtFormatToEpub_Click);
            // 
            // groupBoxTextCompare
            // 
            this.groupBoxTextCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTextCompare.Controls.Add(this.btnTextCompare);
            this.groupBoxTextCompare.Controls.Add(this.splitContainer1);
            this.groupBoxTextCompare.Location = new System.Drawing.Point(177, 386);
            this.groupBoxTextCompare.Name = "groupBoxTextCompare";
            this.groupBoxTextCompare.Size = new System.Drawing.Size(747, 208);
            this.groupBoxTextCompare.TabIndex = 37;
            this.groupBoxTextCompare.TabStop = false;
            this.groupBoxTextCompare.Text = "文本列对比";
            // 
            // btnTextCompare
            // 
            this.btnTextCompare.Location = new System.Drawing.Point(6, -4);
            this.btnTextCompare.Name = "btnTextCompare";
            this.btnTextCompare.Size = new System.Drawing.Size(91, 21);
            this.btnTextCompare.TabIndex = 38;
            this.btnTextCompare.Text = "文本列对比";
            this.btnTextCompare.UseVisualStyleBackColor = true;
            this.btnTextCompare.Click += new System.EventHandler(this.btnTextCompare_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxCompare1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxCompare2);
            this.splitContainer1.Size = new System.Drawing.Size(741, 188);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // richTextBoxCompare1
            // 
            this.richTextBoxCompare1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCompare1.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCompare1.Name = "richTextBoxCompare1";
            this.richTextBoxCompare1.Size = new System.Drawing.Size(355, 188);
            this.richTextBoxCompare1.TabIndex = 0;
            this.richTextBoxCompare1.Text = "";
            // 
            // richTextBoxCompare2
            // 
            this.richTextBoxCompare2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCompare2.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCompare2.Name = "richTextBoxCompare2";
            this.richTextBoxCompare2.Size = new System.Drawing.Size(382, 188);
            this.richTextBoxCompare2.TabIndex = 0;
            this.richTextBoxCompare2.Text = "";
            // 
            // OtherToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTextCompare);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.groupBoxBackOrMove);
            this.Controls.Add(this.btnCheckMediaInfo);
            this.Controls.Add(this.btnCompletedBluRayFolder);
            this.Name = "OtherToolControl";
            this.Size = new System.Drawing.Size(927, 597);
            this.groupBoxBackOrMove.ResumeLayout(false);
            this.groupBoxBackOrMove.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTextCompare.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBatchFiles;
        private System.Windows.Forms.ComboBox tbBatchTemplate;
        private System.Windows.Forms.Button btnBatchCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTxtFormatTo3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTxtFormatMatch3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTxtFormatTo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTxtFormatMatch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTxtFormatTo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTxtFormatMatch1;
        private System.Windows.Forms.Button btnTxtFormatToEpub;
        private System.Windows.Forms.GroupBox groupBoxTextCompare;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxCompare1;
        private System.Windows.Forms.RichTextBox richTextBoxCompare2;
        private System.Windows.Forms.Button btnTextCompare;
    }
}
