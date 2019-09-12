namespace MyTool
{
    partial class ComparedRenameControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRefer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonRenameWithCopy = new System.Windows.Forms.RadioButton();
            this.radioButtonRename = new System.Windows.Forms.RadioButton();
            this.comboBoxAppendSuffix = new System.Windows.Forms.ComboBox();
            this.buttonSuffixManager = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBoxRenameType = new System.Windows.Forms.GroupBox();
            this.groupBoxAddSuffix = new System.Windows.Forms.GroupBox();
            this.groupBoxOperator = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchFileOption = new System.Windows.Forms.GroupBox();
            this.radioButtonTopDirectoryOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonAllDirectories = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBoxRenameType.SuspendLayout();
            this.groupBoxAddSuffix.SuspendLayout();
            this.groupBoxOperator.SuspendLayout();
            this.groupBoxSearchFileOption.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
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
            this.ColumnRefer,
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
            this.gridView.Location = new System.Drawing.Point(3, 79);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 23;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(794, 414);
            this.gridView.TabIndex = 2;
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
            // ColumnRefer
            // 
            this.ColumnRefer.FillWeight = 79.18781F;
            this.ColumnRefer.HeaderText = "参照文件";
            this.ColumnRefer.Name = "ColumnRefer";
            this.ColumnRefer.ReadOnly = true;
            this.ColumnRefer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnRename
            // 
            this.ColumnRename.FillWeight = 79.18781F;
            this.ColumnRename.HeaderText = "命名文件";
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
            // radioButtonRenameWithCopy
            // 
            this.radioButtonRenameWithCopy.AutoSize = true;
            this.radioButtonRenameWithCopy.Location = new System.Drawing.Point(34, 45);
            this.radioButtonRenameWithCopy.Name = "radioButtonRenameWithCopy";
            this.radioButtonRenameWithCopy.Size = new System.Drawing.Size(131, 16);
            this.radioButtonRenameWithCopy.TabIndex = 9;
            this.radioButtonRenameWithCopy.Text = "复制到参照文件目录";
            this.radioButtonRenameWithCopy.UseVisualStyleBackColor = true;
            // 
            // radioButtonRename
            // 
            this.radioButtonRename.AutoSize = true;
            this.radioButtonRename.Checked = true;
            this.radioButtonRename.Location = new System.Drawing.Point(34, 18);
            this.radioButtonRename.Name = "radioButtonRename";
            this.radioButtonRename.Size = new System.Drawing.Size(131, 16);
            this.radioButtonRename.TabIndex = 8;
            this.radioButtonRename.TabStop = true;
            this.radioButtonRename.Text = "直  接  重  命  名";
            this.radioButtonRename.UseVisualStyleBackColor = true;
            this.radioButtonRename.CheckedChanged += new System.EventHandler(this.radioButtonRename_CheckedChanged);
            // 
            // comboBoxAppendSuffix
            // 
            this.comboBoxAppendSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAppendSuffix.FormattingEnabled = true;
            this.comboBoxAppendSuffix.Location = new System.Drawing.Point(6, 18);
            this.comboBoxAppendSuffix.Name = "comboBoxAppendSuffix";
            this.comboBoxAppendSuffix.Size = new System.Drawing.Size(212, 20);
            this.comboBoxAppendSuffix.TabIndex = 7;
            // 
            // buttonSuffixManager
            // 
            this.buttonSuffixManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuffixManager.Location = new System.Drawing.Point(143, 42);
            this.buttonSuffixManager.Name = "buttonSuffixManager";
            this.buttonSuffixManager.Size = new System.Drawing.Size(75, 23);
            this.buttonSuffixManager.TabIndex = 10;
            this.buttonSuffixManager.Text = "管理";
            this.buttonSuffixManager.UseVisualStyleBackColor = true;
            this.buttonSuffixManager.Click += new System.EventHandler(this.buttonSuffixManager_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Location = new System.Drawing.Point(6, 16);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(143, 23);
            this.buttonPreview.TabIndex = 11;
            this.buttonPreview.Text = "预览";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(6, 42);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(143, 23);
            this.buttonApply.TabIndex = 12;
            this.buttonApply.Text = "应用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBoxRenameType
            // 
            this.groupBoxRenameType.Controls.Add(this.radioButtonRename);
            this.groupBoxRenameType.Controls.Add(this.radioButtonRenameWithCopy);
            this.groupBoxRenameType.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRenameType.Name = "groupBoxRenameType";
            this.groupBoxRenameType.Size = new System.Drawing.Size(202, 70);
            this.groupBoxRenameType.TabIndex = 13;
            this.groupBoxRenameType.TabStop = false;
            this.groupBoxRenameType.Text = "命名方式";
            // 
            // groupBoxAddSuffix
            // 
            this.groupBoxAddSuffix.Controls.Add(this.comboBoxAppendSuffix);
            this.groupBoxAddSuffix.Controls.Add(this.buttonSuffixManager);
            this.groupBoxAddSuffix.Location = new System.Drawing.Point(381, 3);
            this.groupBoxAddSuffix.Name = "groupBoxAddSuffix";
            this.groupBoxAddSuffix.Size = new System.Drawing.Size(225, 70);
            this.groupBoxAddSuffix.TabIndex = 14;
            this.groupBoxAddSuffix.TabStop = false;
            this.groupBoxAddSuffix.Text = "在文件名和后缀间添加";
            // 
            // groupBoxOperator
            // 
            this.groupBoxOperator.Controls.Add(this.buttonPreview);
            this.groupBoxOperator.Controls.Add(this.buttonApply);
            this.groupBoxOperator.Location = new System.Drawing.Point(612, 3);
            this.groupBoxOperator.Name = "groupBoxOperator";
            this.groupBoxOperator.Size = new System.Drawing.Size(155, 70);
            this.groupBoxOperator.TabIndex = 15;
            this.groupBoxOperator.TabStop = false;
            this.groupBoxOperator.Text = "操作";
            // 
            // groupBoxSearchFileOption
            // 
            this.groupBoxSearchFileOption.Controls.Add(this.radioButtonTopDirectoryOnly);
            this.groupBoxSearchFileOption.Controls.Add(this.radioButtonAllDirectories);
            this.groupBoxSearchFileOption.Location = new System.Drawing.Point(211, 3);
            this.groupBoxSearchFileOption.Name = "groupBoxSearchFileOption";
            this.groupBoxSearchFileOption.Size = new System.Drawing.Size(164, 70);
            this.groupBoxSearchFileOption.TabIndex = 16;
            this.groupBoxSearchFileOption.TabStop = false;
            this.groupBoxSearchFileOption.Text = "文件夹搜索文件设置";
            // 
            // radioButtonTopDirectoryOnly
            // 
            this.radioButtonTopDirectoryOnly.AutoSize = true;
            this.radioButtonTopDirectoryOnly.Checked = true;
            this.radioButtonTopDirectoryOnly.Location = new System.Drawing.Point(41, 18);
            this.radioButtonTopDirectoryOnly.Name = "radioButtonTopDirectoryOnly";
            this.radioButtonTopDirectoryOnly.Size = new System.Drawing.Size(83, 16);
            this.radioButtonTopDirectoryOnly.TabIndex = 8;
            this.radioButtonTopDirectoryOnly.TabStop = true;
            this.radioButtonTopDirectoryOnly.Text = "仅当前目录";
            this.radioButtonTopDirectoryOnly.UseVisualStyleBackColor = true;
            this.radioButtonTopDirectoryOnly.CheckedChanged += new System.EventHandler(this.radioButtonTopDirectoryOnly_CheckedChanged);
            // 
            // radioButtonAllDirectories
            // 
            this.radioButtonAllDirectories.AutoSize = true;
            this.radioButtonAllDirectories.Location = new System.Drawing.Point(41, 45);
            this.radioButtonAllDirectories.Name = "radioButtonAllDirectories";
            this.radioButtonAllDirectories.Size = new System.Drawing.Size(83, 16);
            this.radioButtonAllDirectories.TabIndex = 9;
            this.radioButtonAllDirectories.Text = "包含子目录";
            this.radioButtonAllDirectories.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUp,
            this.toolStripMenuItemDown,
            this.toolStripMenuItemDelete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // toolStripMenuItemUp
            // 
            this.toolStripMenuItemUp.Name = "toolStripMenuItemUp";
            this.toolStripMenuItemUp.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemUp.Text = "上移";
            // 
            // toolStripMenuItemDown
            // 
            this.toolStripMenuItemDown.Name = "toolStripMenuItemDown";
            this.toolStripMenuItemDown.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemDown.Text = "下移";
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemDelete.Text = "删除";
            // 
            // ComparedRenameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSearchFileOption);
            this.Controls.Add(this.groupBoxOperator);
            this.Controls.Add(this.groupBoxAddSuffix);
            this.Controls.Add(this.groupBoxRenameType);
            this.Controls.Add(this.gridView);
            this.Name = "ComparedRenameControl";
            this.Size = new System.Drawing.Size(800, 496);
            this.Load += new System.EventHandler(this.ComparedRenameControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBoxRenameType.ResumeLayout(false);
            this.groupBoxRenameType.PerformLayout();
            this.groupBoxAddSuffix.ResumeLayout(false);
            this.groupBoxOperator.ResumeLayout(false);
            this.groupBoxSearchFileOption.ResumeLayout(false);
            this.groupBoxSearchFileOption.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.RadioButton radioButtonRenameWithCopy;
        private System.Windows.Forms.RadioButton radioButtonRename;
        private System.Windows.Forms.ComboBox comboBoxAppendSuffix;
        private System.Windows.Forms.Button buttonSuffixManager;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRefer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.GroupBox groupBoxRenameType;
        private System.Windows.Forms.GroupBox groupBoxAddSuffix;
        private System.Windows.Forms.GroupBox groupBoxOperator;
        private System.Windows.Forms.GroupBox groupBoxSearchFileOption;
        private System.Windows.Forms.RadioButton radioButtonTopDirectoryOnly;
        private System.Windows.Forms.RadioButton radioButtonAllDirectories;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDown;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
    }
}
