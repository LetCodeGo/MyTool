namespace MyTool
{
    partial class FileOrFolderRenameControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRegexTarget = new System.Windows.Forms.ComboBox();
            this.comboBoxRegexOriginal = new System.Windows.Forms.ComboBox();
            this.radioButtonRegex = new System.Windows.Forms.RadioButton();
            this.radioButtonPaste = new System.Windows.Forms.RadioButton();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDragFileOption = new System.Windows.Forms.ComboBox();
            this.radioButtonDragFolder = new System.Windows.Forms.RadioButton();
            this.radioButtonDragFile = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchAndReplace = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxReplaceOnce = new System.Windows.Forms.CheckBox();
            this.checkBoxNotIgnoreCase = new System.Windows.Forms.CheckBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.comboBoxReplace = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonManager = new System.Windows.Forms.Button();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowDrop = true;
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnRename,
            this.ColumnResult});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.GridColor = System.Drawing.Color.DarkGray;
            this.gridView.Location = new System.Drawing.Point(3, 105);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 23;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(894, 448);
            this.gridView.TabIndex = 4;
            this.gridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridView_DragDrop);
            this.gridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridView_DragEnter);
            // 
            // ColumnIndex
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnIndex.FillWeight = 20F;
            this.ColumnIndex.HeaderText = "索引";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnRename
            // 
            this.ColumnRename.FillWeight = 79.18781F;
            this.ColumnRename.HeaderText = "待命名";
            this.ColumnRename.Name = "ColumnRename";
            this.ColumnRename.ReadOnly = true;
            this.ColumnRename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnResult
            // 
            this.ColumnResult.FillWeight = 79.18781F;
            this.ColumnResult.HeaderText = "重命名为";
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            this.ColumnResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // comboBoxRegexTarget
            // 
            this.comboBoxRegexTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRegexTarget.Location = new System.Drawing.Point(53, 44);
            this.comboBoxRegexTarget.Name = "comboBoxRegexTarget";
            this.comboBoxRegexTarget.Size = new System.Drawing.Size(140, 20);
            this.comboBoxRegexTarget.TabIndex = 11;
            // 
            // comboBoxRegexOriginal
            // 
            this.comboBoxRegexOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRegexOriginal.Location = new System.Drawing.Point(53, 19);
            this.comboBoxRegexOriginal.Name = "comboBoxRegexOriginal";
            this.comboBoxRegexOriginal.Size = new System.Drawing.Size(140, 20);
            this.comboBoxRegexOriginal.TabIndex = 10;
            // 
            // radioButtonRegex
            // 
            this.radioButtonRegex.AutoSize = true;
            this.radioButtonRegex.Checked = true;
            this.radioButtonRegex.Location = new System.Drawing.Point(4, 19);
            this.radioButtonRegex.Name = "radioButtonRegex";
            this.radioButtonRegex.Size = new System.Drawing.Size(83, 16);
            this.radioButtonRegex.TabIndex = 12;
            this.radioButtonRegex.TabStop = true;
            this.radioButtonRegex.Text = "正则表达式";
            this.radioButtonRegex.UseVisualStyleBackColor = true;
            this.radioButtonRegex.CheckedChanged += new System.EventHandler(this.radioButtonRegex_CheckedChanged);
            // 
            // radioButtonPaste
            // 
            this.radioButtonPaste.AutoSize = true;
            this.radioButtonPaste.Location = new System.Drawing.Point(4, 69);
            this.radioButtonPaste.Name = "radioButtonPaste";
            this.radioButtonPaste.Size = new System.Drawing.Size(83, 16);
            this.radioButtonPaste.TabIndex = 13;
            this.radioButtonPaste.Text = "剪贴板粘贴";
            this.radioButtonPaste.UseVisualStyleBackColor = true;
            this.radioButtonPaste.CheckedChanged += new System.EventHandler(this.radioButtonPaste_CheckedChanged);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Location = new System.Drawing.Point(6, 19);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(108, 20);
            this.buttonPaste.TabIndex = 14;
            this.buttonPaste.Text = "剪贴板粘贴";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(6, 44);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(108, 20);
            this.buttonPreview.TabIndex = 15;
            this.buttonPreview.Text = "预览";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(6, 67);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(108, 20);
            this.buttonApply.TabIndex = 16;
            this.buttonApply.Text = "应用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDragFileOption);
            this.groupBox1.Controls.Add(this.radioButtonDragFolder);
            this.groupBox1.Controls.Add(this.radioButtonDragFile);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 96);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "拖曳添加类型";
            // 
            // comboBoxDragFileOption
            // 
            this.comboBoxDragFileOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDragFileOption.Items.AddRange(new object[] {
            "仅当前目录",
            "包含子目录"});
            this.comboBoxDragFileOption.Location = new System.Drawing.Point(6, 67);
            this.comboBoxDragFileOption.Name = "comboBoxDragFileOption";
            this.comboBoxDragFileOption.Size = new System.Drawing.Size(88, 20);
            this.comboBoxDragFileOption.TabIndex = 14;
            // 
            // radioButtonDragFolder
            // 
            this.radioButtonDragFolder.AutoSize = true;
            this.radioButtonDragFolder.Location = new System.Drawing.Point(21, 44);
            this.radioButtonDragFolder.Name = "radioButtonDragFolder";
            this.radioButtonDragFolder.Size = new System.Drawing.Size(59, 16);
            this.radioButtonDragFolder.TabIndex = 1;
            this.radioButtonDragFolder.Text = "文件夹";
            this.radioButtonDragFolder.UseVisualStyleBackColor = true;
            // 
            // radioButtonDragFile
            // 
            this.radioButtonDragFile.AutoSize = true;
            this.radioButtonDragFile.Checked = true;
            this.radioButtonDragFile.Location = new System.Drawing.Point(21, 19);
            this.radioButtonDragFile.Name = "radioButtonDragFile";
            this.radioButtonDragFile.Size = new System.Drawing.Size(59, 16);
            this.radioButtonDragFile.TabIndex = 0;
            this.radioButtonDragFile.TabStop = true;
            this.radioButtonDragFile.Text = "文  件";
            this.radioButtonDragFile.UseVisualStyleBackColor = true;
            this.radioButtonDragFile.CheckedChanged += new System.EventHandler(this.radioButtonDragFile_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSearchAndReplace);
            this.groupBox2.Controls.Add(this.radioButtonPaste);
            this.groupBox2.Controls.Add(this.radioButtonRegex);
            this.groupBox2.Location = new System.Drawing.Point(109, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 96);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "命名方式";
            // 
            // radioButtonSearchAndReplace
            // 
            this.radioButtonSearchAndReplace.AutoSize = true;
            this.radioButtonSearchAndReplace.Location = new System.Drawing.Point(4, 44);
            this.radioButtonSearchAndReplace.Name = "radioButtonSearchAndReplace";
            this.radioButtonSearchAndReplace.Size = new System.Drawing.Size(83, 16);
            this.radioButtonSearchAndReplace.TabIndex = 14;
            this.radioButtonSearchAndReplace.Text = "查找并替换";
            this.radioButtonSearchAndReplace.UseVisualStyleBackColor = true;
            this.radioButtonSearchAndReplace.CheckedChanged += new System.EventHandler(this.radioButtonSearchAndReplace_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBoxRegexOriginal);
            this.groupBox3.Controls.Add(this.comboBoxRegexTarget);
            this.groupBox3.Location = new System.Drawing.Point(206, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 96);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "正则表达式（全文匹配）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "目标：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "原始：";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.checkBoxReplaceOnce);
            this.groupBox4.Controls.Add(this.checkBoxNotIgnoreCase);
            this.groupBox4.Controls.Add(this.comboBoxSearch);
            this.groupBox4.Controls.Add(this.comboBoxReplace);
            this.groupBox4.Location = new System.Drawing.Point(411, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 96);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查找并替换";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "替换为：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "查找：";
            // 
            // checkBoxReplaceOnce
            // 
            this.checkBoxReplaceOnce.AutoSize = true;
            this.checkBoxReplaceOnce.Location = new System.Drawing.Point(97, 70);
            this.checkBoxReplaceOnce.Name = "checkBoxReplaceOnce";
            this.checkBoxReplaceOnce.Size = new System.Drawing.Size(132, 16);
            this.checkBoxReplaceOnce.TabIndex = 15;
            this.checkBoxReplaceOnce.Text = "每个文件仅替换一次";
            this.checkBoxReplaceOnce.UseVisualStyleBackColor = true;
            this.checkBoxReplaceOnce.CheckedChanged += new System.EventHandler(this.checkBoxReplaceOnce_CheckedChanged);
            // 
            // checkBoxNotIgnoreCase
            // 
            this.checkBoxNotIgnoreCase.AutoSize = true;
            this.checkBoxNotIgnoreCase.Location = new System.Drawing.Point(9, 70);
            this.checkBoxNotIgnoreCase.Name = "checkBoxNotIgnoreCase";
            this.checkBoxNotIgnoreCase.Size = new System.Drawing.Size(84, 16);
            this.checkBoxNotIgnoreCase.TabIndex = 14;
            this.checkBoxNotIgnoreCase.Text = "区分大小写";
            this.checkBoxNotIgnoreCase.UseVisualStyleBackColor = true;
            this.checkBoxNotIgnoreCase.CheckedChanged += new System.EventHandler(this.checkBoxNotIgnoreCase_CheckedChanged);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Location = new System.Drawing.Point(61, 19);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(165, 20);
            this.comboBoxSearch.TabIndex = 12;
            // 
            // comboBoxReplace
            // 
            this.comboBoxReplace.Location = new System.Drawing.Point(61, 44);
            this.comboBoxReplace.Name = "comboBoxReplace";
            this.comboBoxReplace.Size = new System.Drawing.Size(165, 20);
            this.comboBoxReplace.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.buttonManager);
            this.groupBox5.Controls.Add(this.comboBoxManager);
            this.groupBox5.Location = new System.Drawing.Point(649, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(121, 96);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "管理输入输出";
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(7, 44);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(108, 20);
            this.buttonManager.TabIndex = 15;
            this.buttonManager.Text = "编辑";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager.Location = new System.Drawing.Point(7, 19);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(108, 20);
            this.comboBoxManager.TabIndex = 13;
            this.comboBoxManager.SelectedIndexChanged += new System.EventHandler(this.comboBoxManager_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.buttonPaste);
            this.groupBox6.Controls.Add(this.buttonPreview);
            this.groupBox6.Controls.Add(this.buttonApply);
            this.groupBox6.Location = new System.Drawing.Point(776, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(121, 96);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "操作";
            // 
            // FileOrFolderRenameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileOrFolderRenameControl";
            this.Size = new System.Drawing.Size(900, 556);
            this.Load += new System.EventHandler(this.FileOrFolderRenameControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.ComboBox comboBoxRegexTarget;
        private System.Windows.Forms.ComboBox comboBoxRegexOriginal;
        private System.Windows.Forms.RadioButton radioButtonRegex;
        private System.Windows.Forms.RadioButton radioButtonPaste;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDragFolder;
        private System.Windows.Forms.RadioButton radioButtonDragFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSearchAndReplace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxReplaceOnce;
        private System.Windows.Forms.CheckBox checkBoxNotIgnoreCase;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxDragFileOption;
    }
}
