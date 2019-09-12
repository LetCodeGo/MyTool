namespace MyTool
{
    partial class FileMatchSettingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMatchSettingControl));
            this.textBoxPresetItemRename = new System.Windows.Forms.TextBox();
            this.groupBoxFolderCurrentSetting = new System.Windows.Forms.GroupBox();
            this.groupBoxFolderFileSize = new System.Windows.Forms.GroupBox();
            this.comboBoxFileSizeLessThanUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxFileSizeGreaterThanUnit = new System.Windows.Forms.ComboBox();
            this.textBoxFileSizeLessThanInput = new System.Windows.Forms.TextBox();
            this.textBoxFileSizeGreaterThanInput = new System.Windows.Forms.TextBox();
            this.checkBoxFileSizeLessThan = new System.Windows.Forms.CheckBox();
            this.checkBoxFileSizeGreaterThan = new System.Windows.Forms.CheckBox();
            this.groupBoxFolderFileAttrExclude = new System.Windows.Forms.GroupBox();
            this.checkBoxFileAttrExcludeSystem = new System.Windows.Forms.CheckBox();
            this.checkBoxFileAttrExcludeHidden = new System.Windows.Forms.CheckBox();
            this.checkBoxFileAttrExcludeReadOnly = new System.Windows.Forms.CheckBox();
            this.groupBoxFolderFileNameExclude = new System.Windows.Forms.GroupBox();
            this.comboBoxFileNameExcludeInputType = new System.Windows.Forms.ComboBox();
            this.checkedListBoxFileNameExclude = new System.Windows.Forms.CheckedListBox();
            this.buttonFileNameExcludeDelete = new System.Windows.Forms.Button();
            this.buttonFileNameExcludeAdd = new System.Windows.Forms.Button();
            this.textBoxFileNameExcludeInput = new System.Windows.Forms.TextBox();
            this.groupBoxFolderFileNameInclude = new System.Windows.Forms.GroupBox();
            this.comboBoxFileNameIncludeInputType = new System.Windows.Forms.ComboBox();
            this.checkedListBoxFileNameInclude = new System.Windows.Forms.CheckedListBox();
            this.buttonFileNameIncludeDelete = new System.Windows.Forms.Button();
            this.buttonFileNameIncludeAdd = new System.Windows.Forms.Button();
            this.textBoxFileNameIncludeInput = new System.Windows.Forms.TextBox();
            this.buttonPresentSave = new System.Windows.Forms.Button();
            this.buttonPresetLoad = new System.Windows.Forms.Button();
            this.listBoxPreset = new System.Windows.Forms.ListBox();
            this.contextMenuStripPreset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPresetLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPresetRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPresetRepeat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPresetDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListPreset = new System.Windows.Forms.ImageList(this.components);
            this.labelSavedProset = new System.Windows.Forms.Label();
            this.groupBoxFolderCurrentSetting.SuspendLayout();
            this.groupBoxFolderFileSize.SuspendLayout();
            this.groupBoxFolderFileAttrExclude.SuspendLayout();
            this.groupBoxFolderFileNameExclude.SuspendLayout();
            this.groupBoxFolderFileNameInclude.SuspendLayout();
            this.contextMenuStripPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPresetItemRename
            // 
            this.textBoxPresetItemRename.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPresetItemRename.Location = new System.Drawing.Point(10, 465);
            this.textBoxPresetItemRename.Name = "textBoxPresetItemRename";
            this.textBoxPresetItemRename.Size = new System.Drawing.Size(70, 21);
            this.textBoxPresetItemRename.TabIndex = 6;
            this.textBoxPresetItemRename.Visible = false;
            this.textBoxPresetItemRename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPresetItemRename_KeyPress);
            this.textBoxPresetItemRename.Leave += new System.EventHandler(this.textBoxPresetItemRename_Leave);
            // 
            // groupBoxFolderCurrentSetting
            // 
            this.groupBoxFolderCurrentSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxFolderCurrentSetting.Controls.Add(this.groupBoxFolderFileSize);
            this.groupBoxFolderCurrentSetting.Controls.Add(this.groupBoxFolderFileAttrExclude);
            this.groupBoxFolderCurrentSetting.Controls.Add(this.groupBoxFolderFileNameExclude);
            this.groupBoxFolderCurrentSetting.Controls.Add(this.groupBoxFolderFileNameInclude);
            this.groupBoxFolderCurrentSetting.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFolderCurrentSetting.Location = new System.Drawing.Point(290, 9);
            this.groupBoxFolderCurrentSetting.Name = "groupBoxFolderCurrentSetting";
            this.groupBoxFolderCurrentSetting.Size = new System.Drawing.Size(504, 484);
            this.groupBoxFolderCurrentSetting.TabIndex = 3;
            this.groupBoxFolderCurrentSetting.TabStop = false;
            this.groupBoxFolderCurrentSetting.Text = "当前设置";
            // 
            // groupBoxFolderFileSize
            // 
            this.groupBoxFolderFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFolderFileSize.Controls.Add(this.comboBoxFileSizeLessThanUnit);
            this.groupBoxFolderFileSize.Controls.Add(this.comboBoxFileSizeGreaterThanUnit);
            this.groupBoxFolderFileSize.Controls.Add(this.textBoxFileSizeLessThanInput);
            this.groupBoxFolderFileSize.Controls.Add(this.textBoxFileSizeGreaterThanInput);
            this.groupBoxFolderFileSize.Controls.Add(this.checkBoxFileSizeLessThan);
            this.groupBoxFolderFileSize.Controls.Add(this.checkBoxFileSizeGreaterThan);
            this.groupBoxFolderFileSize.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFolderFileSize.Location = new System.Drawing.Point(6, 82);
            this.groupBoxFolderFileSize.Name = "groupBoxFolderFileSize";
            this.groupBoxFolderFileSize.Size = new System.Drawing.Size(492, 53);
            this.groupBoxFolderFileSize.TabIndex = 1;
            this.groupBoxFolderFileSize.TabStop = false;
            this.groupBoxFolderFileSize.Text = "文件大小";
            // 
            // comboBoxFileSizeLessThanUnit
            // 
            this.comboBoxFileSizeLessThanUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileSizeLessThanUnit.FormattingEnabled = true;
            this.comboBoxFileSizeLessThanUnit.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.comboBoxFileSizeLessThanUnit.Location = new System.Drawing.Point(297, 22);
            this.comboBoxFileSizeLessThanUnit.Name = "comboBoxFileSizeLessThanUnit";
            this.comboBoxFileSizeLessThanUnit.Size = new System.Drawing.Size(40, 20);
            this.comboBoxFileSizeLessThanUnit.TabIndex = 5;
            // 
            // comboBoxFileSizeGreaterThanUnit
            // 
            this.comboBoxFileSizeGreaterThanUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileSizeGreaterThanUnit.FormattingEnabled = true;
            this.comboBoxFileSizeGreaterThanUnit.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.comboBoxFileSizeGreaterThanUnit.Location = new System.Drawing.Point(132, 22);
            this.comboBoxFileSizeGreaterThanUnit.Name = "comboBoxFileSizeGreaterThanUnit";
            this.comboBoxFileSizeGreaterThanUnit.Size = new System.Drawing.Size(40, 20);
            this.comboBoxFileSizeGreaterThanUnit.TabIndex = 4;
            // 
            // textBoxFileSizeLessThanInput
            // 
            this.textBoxFileSizeLessThanInput.Location = new System.Drawing.Point(245, 21);
            this.textBoxFileSizeLessThanInput.Name = "textBoxFileSizeLessThanInput";
            this.textBoxFileSizeLessThanInput.Size = new System.Drawing.Size(50, 21);
            this.textBoxFileSizeLessThanInput.TabIndex = 3;
            // 
            // textBoxFileSizeGreaterThanInput
            // 
            this.textBoxFileSizeGreaterThanInput.Location = new System.Drawing.Point(80, 21);
            this.textBoxFileSizeGreaterThanInput.Name = "textBoxFileSizeGreaterThanInput";
            this.textBoxFileSizeGreaterThanInput.Size = new System.Drawing.Size(50, 21);
            this.textBoxFileSizeGreaterThanInput.TabIndex = 2;
            // 
            // checkBoxFileSizeLessThan
            // 
            this.checkBoxFileSizeLessThan.AutoSize = true;
            this.checkBoxFileSizeLessThan.Location = new System.Drawing.Point(214, 24);
            this.checkBoxFileSizeLessThan.Name = "checkBoxFileSizeLessThan";
            this.checkBoxFileSizeLessThan.Size = new System.Drawing.Size(30, 16);
            this.checkBoxFileSizeLessThan.TabIndex = 1;
            this.checkBoxFileSizeLessThan.Text = "<";
            this.checkBoxFileSizeLessThan.UseVisualStyleBackColor = true;
            // 
            // checkBoxFileSizeGreaterThan
            // 
            this.checkBoxFileSizeGreaterThan.AutoSize = true;
            this.checkBoxFileSizeGreaterThan.Location = new System.Drawing.Point(49, 24);
            this.checkBoxFileSizeGreaterThan.Name = "checkBoxFileSizeGreaterThan";
            this.checkBoxFileSizeGreaterThan.Size = new System.Drawing.Size(30, 16);
            this.checkBoxFileSizeGreaterThan.TabIndex = 0;
            this.checkBoxFileSizeGreaterThan.Text = ">";
            this.checkBoxFileSizeGreaterThan.UseVisualStyleBackColor = true;
            // 
            // groupBoxFolderFileAttrExclude
            // 
            this.groupBoxFolderFileAttrExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFolderFileAttrExclude.Controls.Add(this.checkBoxFileAttrExcludeSystem);
            this.groupBoxFolderFileAttrExclude.Controls.Add(this.checkBoxFileAttrExcludeHidden);
            this.groupBoxFolderFileAttrExclude.Controls.Add(this.checkBoxFileAttrExcludeReadOnly);
            this.groupBoxFolderFileAttrExclude.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFolderFileAttrExclude.Location = new System.Drawing.Point(6, 20);
            this.groupBoxFolderFileAttrExclude.Name = "groupBoxFolderFileAttrExclude";
            this.groupBoxFolderFileAttrExclude.Size = new System.Drawing.Size(492, 53);
            this.groupBoxFolderFileAttrExclude.TabIndex = 0;
            this.groupBoxFolderFileAttrExclude.TabStop = false;
            this.groupBoxFolderFileAttrExclude.Text = "文件属性排除";
            // 
            // checkBoxFileAttrExcludeSystem
            // 
            this.checkBoxFileAttrExcludeSystem.AutoSize = true;
            this.checkBoxFileAttrExcludeSystem.Location = new System.Drawing.Point(267, 24);
            this.checkBoxFileAttrExcludeSystem.Name = "checkBoxFileAttrExcludeSystem";
            this.checkBoxFileAttrExcludeSystem.Size = new System.Drawing.Size(48, 16);
            this.checkBoxFileAttrExcludeSystem.TabIndex = 2;
            this.checkBoxFileAttrExcludeSystem.Text = "系统";
            this.checkBoxFileAttrExcludeSystem.UseVisualStyleBackColor = true;
            // 
            // checkBoxFileAttrExcludeHidden
            // 
            this.checkBoxFileAttrExcludeHidden.AutoSize = true;
            this.checkBoxFileAttrExcludeHidden.Location = new System.Drawing.Point(165, 24);
            this.checkBoxFileAttrExcludeHidden.Name = "checkBoxFileAttrExcludeHidden";
            this.checkBoxFileAttrExcludeHidden.Size = new System.Drawing.Size(48, 16);
            this.checkBoxFileAttrExcludeHidden.TabIndex = 1;
            this.checkBoxFileAttrExcludeHidden.Text = "隐藏";
            this.checkBoxFileAttrExcludeHidden.UseVisualStyleBackColor = true;
            // 
            // checkBoxFileAttrExcludeReadOnly
            // 
            this.checkBoxFileAttrExcludeReadOnly.AutoSize = true;
            this.checkBoxFileAttrExcludeReadOnly.Location = new System.Drawing.Point(63, 24);
            this.checkBoxFileAttrExcludeReadOnly.Name = "checkBoxFileAttrExcludeReadOnly";
            this.checkBoxFileAttrExcludeReadOnly.Size = new System.Drawing.Size(48, 16);
            this.checkBoxFileAttrExcludeReadOnly.TabIndex = 0;
            this.checkBoxFileAttrExcludeReadOnly.Text = "只读";
            this.checkBoxFileAttrExcludeReadOnly.UseVisualStyleBackColor = true;
            // 
            // groupBoxFolderFileNameExclude
            // 
            this.groupBoxFolderFileNameExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFolderFileNameExclude.Controls.Add(this.comboBoxFileNameExcludeInputType);
            this.groupBoxFolderFileNameExclude.Controls.Add(this.checkedListBoxFileNameExclude);
            this.groupBoxFolderFileNameExclude.Controls.Add(this.buttonFileNameExcludeDelete);
            this.groupBoxFolderFileNameExclude.Controls.Add(this.buttonFileNameExcludeAdd);
            this.groupBoxFolderFileNameExclude.Controls.Add(this.textBoxFileNameExcludeInput);
            this.groupBoxFolderFileNameExclude.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFolderFileNameExclude.Location = new System.Drawing.Point(6, 312);
            this.groupBoxFolderFileNameExclude.Name = "groupBoxFolderFileNameExclude";
            this.groupBoxFolderFileNameExclude.Size = new System.Drawing.Size(492, 165);
            this.groupBoxFolderFileNameExclude.TabIndex = 1;
            this.groupBoxFolderFileNameExclude.TabStop = false;
            this.groupBoxFolderFileNameExclude.Text = "文件名排除";
            // 
            // comboBoxFileNameExcludeInputType
            // 
            this.comboBoxFileNameExcludeInputType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxFileNameExcludeInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileNameExcludeInputType.FormattingEnabled = true;
            this.comboBoxFileNameExcludeInputType.Items.AddRange(new object[] {
            "通配符",
            "正则表达式"});
            this.comboBoxFileNameExcludeInputType.Location = new System.Drawing.Point(6, 139);
            this.comboBoxFileNameExcludeInputType.Name = "comboBoxFileNameExcludeInputType";
            this.comboBoxFileNameExcludeInputType.Size = new System.Drawing.Size(100, 20);
            this.comboBoxFileNameExcludeInputType.TabIndex = 9;
            // 
            // checkedListBoxFileNameExclude
            // 
            this.checkedListBoxFileNameExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFileNameExclude.CheckOnClick = true;
            this.checkedListBoxFileNameExclude.FormattingEnabled = true;
            this.checkedListBoxFileNameExclude.Location = new System.Drawing.Point(6, 20);
            this.checkedListBoxFileNameExclude.Name = "checkedListBoxFileNameExclude";
            this.checkedListBoxFileNameExclude.Size = new System.Drawing.Size(480, 116);
            this.checkedListBoxFileNameExclude.TabIndex = 8;
            this.checkedListBoxFileNameExclude.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFileNameExclude_SelectedIndexChanged);
            // 
            // buttonFileNameExcludeDelete
            // 
            this.buttonFileNameExcludeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileNameExcludeDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFileNameExcludeDelete.Location = new System.Drawing.Point(462, 137);
            this.buttonFileNameExcludeDelete.Name = "buttonFileNameExcludeDelete";
            this.buttonFileNameExcludeDelete.Size = new System.Drawing.Size(24, 23);
            this.buttonFileNameExcludeDelete.TabIndex = 7;
            this.buttonFileNameExcludeDelete.Text = "-";
            this.buttonFileNameExcludeDelete.UseVisualStyleBackColor = true;
            this.buttonFileNameExcludeDelete.Click += new System.EventHandler(this.buttonFileNameExcludeDelete_Click);
            // 
            // buttonFileNameExcludeAdd
            // 
            this.buttonFileNameExcludeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileNameExcludeAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFileNameExcludeAdd.Location = new System.Drawing.Point(433, 137);
            this.buttonFileNameExcludeAdd.Name = "buttonFileNameExcludeAdd";
            this.buttonFileNameExcludeAdd.Size = new System.Drawing.Size(24, 23);
            this.buttonFileNameExcludeAdd.TabIndex = 6;
            this.buttonFileNameExcludeAdd.Text = "+";
            this.buttonFileNameExcludeAdd.UseVisualStyleBackColor = true;
            this.buttonFileNameExcludeAdd.Click += new System.EventHandler(this.buttonFileNameExcludeAdd_Click);
            // 
            // textBoxFileNameExcludeInput
            // 
            this.textBoxFileNameExcludeInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileNameExcludeInput.Location = new System.Drawing.Point(112, 138);
            this.textBoxFileNameExcludeInput.Name = "textBoxFileNameExcludeInput";
            this.textBoxFileNameExcludeInput.Size = new System.Drawing.Size(315, 21);
            this.textBoxFileNameExcludeInput.TabIndex = 5;
            this.textBoxFileNameExcludeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFileNameExcludeInput_KeyPress);
            // 
            // groupBoxFolderFileNameInclude
            // 
            this.groupBoxFolderFileNameInclude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFolderFileNameInclude.Controls.Add(this.comboBoxFileNameIncludeInputType);
            this.groupBoxFolderFileNameInclude.Controls.Add(this.checkedListBoxFileNameInclude);
            this.groupBoxFolderFileNameInclude.Controls.Add(this.buttonFileNameIncludeDelete);
            this.groupBoxFolderFileNameInclude.Controls.Add(this.buttonFileNameIncludeAdd);
            this.groupBoxFolderFileNameInclude.Controls.Add(this.textBoxFileNameIncludeInput);
            this.groupBoxFolderFileNameInclude.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFolderFileNameInclude.Location = new System.Drawing.Point(6, 141);
            this.groupBoxFolderFileNameInclude.Name = "groupBoxFolderFileNameInclude";
            this.groupBoxFolderFileNameInclude.Size = new System.Drawing.Size(492, 165);
            this.groupBoxFolderFileNameInclude.TabIndex = 0;
            this.groupBoxFolderFileNameInclude.TabStop = false;
            this.groupBoxFolderFileNameInclude.Text = "文件名匹配";
            // 
            // comboBoxFileNameIncludeInputType
            // 
            this.comboBoxFileNameIncludeInputType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxFileNameIncludeInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileNameIncludeInputType.FormattingEnabled = true;
            this.comboBoxFileNameIncludeInputType.Items.AddRange(new object[] {
            "通配符",
            "正则表达式"});
            this.comboBoxFileNameIncludeInputType.Location = new System.Drawing.Point(6, 139);
            this.comboBoxFileNameIncludeInputType.Name = "comboBoxFileNameIncludeInputType";
            this.comboBoxFileNameIncludeInputType.Size = new System.Drawing.Size(100, 20);
            this.comboBoxFileNameIncludeInputType.TabIndex = 5;
            // 
            // checkedListBoxFileNameInclude
            // 
            this.checkedListBoxFileNameInclude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFileNameInclude.CheckOnClick = true;
            this.checkedListBoxFileNameInclude.FormattingEnabled = true;
            this.checkedListBoxFileNameInclude.Location = new System.Drawing.Point(6, 20);
            this.checkedListBoxFileNameInclude.Name = "checkedListBoxFileNameInclude";
            this.checkedListBoxFileNameInclude.Size = new System.Drawing.Size(480, 116);
            this.checkedListBoxFileNameInclude.TabIndex = 4;
            this.checkedListBoxFileNameInclude.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFileNameInclude_SelectedIndexChanged);
            // 
            // buttonFileNameIncludeDelete
            // 
            this.buttonFileNameIncludeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileNameIncludeDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFileNameIncludeDelete.Location = new System.Drawing.Point(462, 137);
            this.buttonFileNameIncludeDelete.Name = "buttonFileNameIncludeDelete";
            this.buttonFileNameIncludeDelete.Size = new System.Drawing.Size(24, 23);
            this.buttonFileNameIncludeDelete.TabIndex = 3;
            this.buttonFileNameIncludeDelete.Text = "-";
            this.buttonFileNameIncludeDelete.UseVisualStyleBackColor = true;
            this.buttonFileNameIncludeDelete.Click += new System.EventHandler(this.buttonFileNameIncludeDelete_Click);
            // 
            // buttonFileNameIncludeAdd
            // 
            this.buttonFileNameIncludeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileNameIncludeAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFileNameIncludeAdd.Location = new System.Drawing.Point(433, 137);
            this.buttonFileNameIncludeAdd.Name = "buttonFileNameIncludeAdd";
            this.buttonFileNameIncludeAdd.Size = new System.Drawing.Size(24, 23);
            this.buttonFileNameIncludeAdd.TabIndex = 2;
            this.buttonFileNameIncludeAdd.Text = "+";
            this.buttonFileNameIncludeAdd.UseVisualStyleBackColor = true;
            this.buttonFileNameIncludeAdd.Click += new System.EventHandler(this.buttonFileNameIncludeAdd_Click);
            // 
            // textBoxFileNameIncludeInput
            // 
            this.textBoxFileNameIncludeInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileNameIncludeInput.Location = new System.Drawing.Point(112, 138);
            this.textBoxFileNameIncludeInput.Name = "textBoxFileNameIncludeInput";
            this.textBoxFileNameIncludeInput.Size = new System.Drawing.Size(315, 21);
            this.textBoxFileNameIncludeInput.TabIndex = 1;
            this.textBoxFileNameIncludeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFileNameIncludeInput_KeyPress);
            // 
            // buttonPresentSave
            // 
            this.buttonPresentSave.Location = new System.Drawing.Point(247, 170);
            this.buttonPresentSave.Name = "buttonPresentSave";
            this.buttonPresentSave.Size = new System.Drawing.Size(37, 40);
            this.buttonPresentSave.TabIndex = 2;
            this.buttonPresentSave.Text = "保存 <<";
            this.buttonPresentSave.UseVisualStyleBackColor = true;
            this.buttonPresentSave.Click += new System.EventHandler(this.buttonPresentSave_Click);
            // 
            // buttonPresetLoad
            // 
            this.buttonPresetLoad.Location = new System.Drawing.Point(247, 104);
            this.buttonPresetLoad.Name = "buttonPresetLoad";
            this.buttonPresetLoad.Size = new System.Drawing.Size(37, 40);
            this.buttonPresetLoad.TabIndex = 1;
            this.buttonPresetLoad.Text = "载入 >>";
            this.buttonPresetLoad.UseVisualStyleBackColor = true;
            this.buttonPresetLoad.Click += new System.EventHandler(this.buttonPresetLoad_Click);
            // 
            // listBoxPreset
            // 
            this.listBoxPreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPreset.ContextMenuStrip = this.contextMenuStripPreset;
            this.listBoxPreset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxPreset.FormattingEnabled = true;
            this.listBoxPreset.ItemHeight = 16;
            this.listBoxPreset.Location = new System.Drawing.Point(3, 27);
            this.listBoxPreset.Name = "listBoxPreset";
            this.listBoxPreset.Size = new System.Drawing.Size(238, 468);
            this.listBoxPreset.TabIndex = 0;
            // 
            // contextMenuStripPreset
            // 
            this.contextMenuStripPreset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPresetLoad,
            this.toolStripMenuItemPresetRename,
            this.toolStripMenuItemPresetRepeat,
            this.toolStripMenuItemPresetDelete});
            this.contextMenuStripPreset.Name = "contextMenuStripPreset";
            this.contextMenuStripPreset.Size = new System.Drawing.Size(113, 92);
            // 
            // toolStripMenuItemPresetLoad
            // 
            this.toolStripMenuItemPresetLoad.Name = "toolStripMenuItemPresetLoad";
            this.toolStripMenuItemPresetLoad.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemPresetLoad.Text = "载入";
            this.toolStripMenuItemPresetLoad.Click += new System.EventHandler(this.toolStripMenuItemPresetLoad_Click);
            // 
            // toolStripMenuItemPresetRename
            // 
            this.toolStripMenuItemPresetRename.Name = "toolStripMenuItemPresetRename";
            this.toolStripMenuItemPresetRename.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemPresetRename.Text = "重命名";
            this.toolStripMenuItemPresetRename.Click += new System.EventHandler(this.toolStripMenuItemPresetRename_Click);
            // 
            // toolStripMenuItemPresetRepeat
            // 
            this.toolStripMenuItemPresetRepeat.Name = "toolStripMenuItemPresetRepeat";
            this.toolStripMenuItemPresetRepeat.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemPresetRepeat.Text = "重复";
            this.toolStripMenuItemPresetRepeat.Click += new System.EventHandler(this.toolStripMenuItemPresetRepeat_Click);
            // 
            // toolStripMenuItemPresetDelete
            // 
            this.toolStripMenuItemPresetDelete.Name = "toolStripMenuItemPresetDelete";
            this.toolStripMenuItemPresetDelete.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemPresetDelete.Text = "删除";
            this.toolStripMenuItemPresetDelete.Click += new System.EventHandler(this.toolStripMenuItemPresetDelete_Click);
            // 
            // imageListPreset
            // 
            this.imageListPreset.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPreset.ImageStream")));
            this.imageListPreset.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPreset.Images.SetKeyName(0, "PresetLoad.png");
            this.imageListPreset.Images.SetKeyName(1, "PresetRename.png");
            this.imageListPreset.Images.SetKeyName(2, "PresetRepeat.png");
            this.imageListPreset.Images.SetKeyName(3, "PresetDelete.png");
            // 
            // labelSavedProset
            // 
            this.labelSavedProset.AutoSize = true;
            this.labelSavedProset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSavedProset.Location = new System.Drawing.Point(10, 9);
            this.labelSavedProset.Name = "labelSavedProset";
            this.labelSavedProset.Size = new System.Drawing.Size(70, 12);
            this.labelSavedProset.TabIndex = 4;
            this.labelSavedProset.Text = "已保存预设";
            // 
            // FileMatchSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSavedProset);
            this.Controls.Add(this.textBoxPresetItemRename);
            this.Controls.Add(this.listBoxPreset);
            this.Controls.Add(this.groupBoxFolderCurrentSetting);
            this.Controls.Add(this.buttonPresentSave);
            this.Controls.Add(this.buttonPresetLoad);
            this.Name = "FileMatchSettingControl";
            this.Size = new System.Drawing.Size(800, 496);
            this.Load += new System.EventHandler(this.SettingControl_Load);
            this.groupBoxFolderCurrentSetting.ResumeLayout(false);
            this.groupBoxFolderFileSize.ResumeLayout(false);
            this.groupBoxFolderFileSize.PerformLayout();
            this.groupBoxFolderFileAttrExclude.ResumeLayout(false);
            this.groupBoxFolderFileAttrExclude.PerformLayout();
            this.groupBoxFolderFileNameExclude.ResumeLayout(false);
            this.groupBoxFolderFileNameExclude.PerformLayout();
            this.groupBoxFolderFileNameInclude.ResumeLayout(false);
            this.groupBoxFolderFileNameInclude.PerformLayout();
            this.contextMenuStripPreset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFolderCurrentSetting;
        private System.Windows.Forms.GroupBox groupBoxFolderFileSize;
        private System.Windows.Forms.ComboBox comboBoxFileSizeLessThanUnit;
        private System.Windows.Forms.ComboBox comboBoxFileSizeGreaterThanUnit;
        private System.Windows.Forms.TextBox textBoxFileSizeLessThanInput;
        private System.Windows.Forms.TextBox textBoxFileSizeGreaterThanInput;
        private System.Windows.Forms.CheckBox checkBoxFileSizeLessThan;
        private System.Windows.Forms.CheckBox checkBoxFileSizeGreaterThan;
        private System.Windows.Forms.GroupBox groupBoxFolderFileAttrExclude;
        private System.Windows.Forms.CheckBox checkBoxFileAttrExcludeSystem;
        private System.Windows.Forms.CheckBox checkBoxFileAttrExcludeHidden;
        private System.Windows.Forms.CheckBox checkBoxFileAttrExcludeReadOnly;
        private System.Windows.Forms.GroupBox groupBoxFolderFileNameExclude;
        private System.Windows.Forms.CheckedListBox checkedListBoxFileNameExclude;
        private System.Windows.Forms.Button buttonFileNameExcludeDelete;
        private System.Windows.Forms.Button buttonFileNameExcludeAdd;
        private System.Windows.Forms.TextBox textBoxFileNameExcludeInput;
        private System.Windows.Forms.GroupBox groupBoxFolderFileNameInclude;
        private System.Windows.Forms.CheckedListBox checkedListBoxFileNameInclude;
        private System.Windows.Forms.Button buttonFileNameIncludeDelete;
        private System.Windows.Forms.Button buttonFileNameIncludeAdd;
        private System.Windows.Forms.TextBox textBoxFileNameIncludeInput;
        private System.Windows.Forms.Button buttonPresentSave;
        private System.Windows.Forms.Button buttonPresetLoad;
        private System.Windows.Forms.ListBox listBoxPreset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPreset;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPresetLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPresetRename;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPresetRepeat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPresetDelete;
        private System.Windows.Forms.ImageList imageListPreset;
        private System.Windows.Forms.TextBox textBoxPresetItemRename;
        private System.Windows.Forms.Label labelSavedProset;
        private System.Windows.Forms.ComboBox comboBoxFileNameExcludeInputType;
        private System.Windows.Forms.ComboBox comboBoxFileNameIncludeInputType;
    }
}
