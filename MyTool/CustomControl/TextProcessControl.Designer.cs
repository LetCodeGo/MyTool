namespace MyTool
{
    partial class TextProcessControl
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
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.rbg2_keep = new System.Windows.Forms.RadioButton();
            this.rbg2_ucs2_be = new System.Windows.Forms.RadioButton();
            this.rbg2_ucs2_le = new System.Windows.Forms.RadioButton();
            this.rbg2_ansi = new System.Windows.Forms.RadioButton();
            this.rbg2_utf8 = new System.Windows.Forms.RadioButton();
            this.rbg2_utf8_bom = new System.Windows.Forms.RadioButton();
            this.groupBoxFileContent = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxChangeSuffix = new System.Windows.Forms.GroupBox();
            this.rbg1_flac = new System.Windows.Forms.RadioButton();
            this.rbg1_ape = new System.Windows.Forms.RadioButton();
            this.rbg1_tak = new System.Windows.Forms.RadioButton();
            this.rbg1_tta = new System.Windows.Forms.RadioButton();
            this.rbg1_wav = new System.Windows.Forms.RadioButton();
            this.rbg1_m4a = new System.Windows.Forms.RadioButton();
            this.rbg1_keep = new System.Windows.Forms.RadioButton();
            this.cbCUEAssociatedFileExtension = new System.Windows.Forms.ComboBox();
            this.cbCUEAssociatedFileNameSync = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbg3_sc = new System.Windows.Forms.RadioButton();
            this.rbg3_tc = new System.Windows.Forms.RadioButton();
            this.rbg3_keep = new System.Windows.Forms.RadioButton();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonCUE = new System.Windows.Forms.Button();
            this.cbNoLimit = new System.Windows.Forms.CheckBox();
            this.groupBoxSearchFileOption = new System.Windows.Forms.GroupBox();
            this.radioButtonTopDirectoryOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonAllDirectories = new System.Windows.Forms.RadioButton();
            this.groupBoxEncoding.SuspendLayout();
            this.groupBoxFileContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxChangeSuffix.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSearchFileOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Controls.Add(this.rbg2_keep);
            this.groupBoxEncoding.Controls.Add(this.rbg2_ucs2_be);
            this.groupBoxEncoding.Controls.Add(this.rbg2_ucs2_le);
            this.groupBoxEncoding.Controls.Add(this.rbg2_ansi);
            this.groupBoxEncoding.Controls.Add(this.rbg2_utf8);
            this.groupBoxEncoding.Controls.Add(this.rbg2_utf8_bom);
            this.groupBoxEncoding.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(598, 66);
            this.groupBoxEncoding.TabIndex = 12;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "文件编码转换为";
            // 
            // rbg2_keep
            // 
            this.rbg2_keep.AutoSize = true;
            this.rbg2_keep.Checked = true;
            this.rbg2_keep.Location = new System.Drawing.Point(501, 29);
            this.rbg2_keep.Name = "rbg2_keep";
            this.rbg2_keep.Size = new System.Drawing.Size(47, 16);
            this.rbg2_keep.TabIndex = 7;
            this.rbg2_keep.TabStop = true;
            this.rbg2_keep.Text = "保持";
            this.rbg2_keep.UseVisualStyleBackColor = true;
            // 
            // rbg2_ucs2_be
            // 
            this.rbg2_ucs2_be.AutoSize = true;
            this.rbg2_ucs2_be.Location = new System.Drawing.Point(327, 29);
            this.rbg2_ucs2_be.Name = "rbg2_ucs2_be";
            this.rbg2_ucs2_be.Size = new System.Drawing.Size(71, 16);
            this.rbg2_ucs2_be.TabIndex = 6;
            this.rbg2_ucs2_be.Text = "UCS-2 BE";
            this.rbg2_ucs2_be.UseVisualStyleBackColor = true;
            // 
            // rbg2_ucs2_le
            // 
            this.rbg2_ucs2_le.AutoSize = true;
            this.rbg2_ucs2_le.Location = new System.Drawing.Point(228, 29);
            this.rbg2_ucs2_le.Name = "rbg2_ucs2_le";
            this.rbg2_ucs2_le.Size = new System.Drawing.Size(71, 16);
            this.rbg2_ucs2_le.TabIndex = 5;
            this.rbg2_ucs2_le.Text = "UCS-2 LE";
            this.rbg2_ucs2_le.UseVisualStyleBackColor = true;
            // 
            // rbg2_ansi
            // 
            this.rbg2_ansi.AutoSize = true;
            this.rbg2_ansi.Location = new System.Drawing.Point(426, 29);
            this.rbg2_ansi.Name = "rbg2_ansi";
            this.rbg2_ansi.Size = new System.Drawing.Size(47, 16);
            this.rbg2_ansi.TabIndex = 4;
            this.rbg2_ansi.Text = "ANSI";
            this.rbg2_ansi.UseVisualStyleBackColor = true;
            // 
            // rbg2_utf8
            // 
            this.rbg2_utf8.AutoSize = true;
            this.rbg2_utf8.Location = new System.Drawing.Point(153, 29);
            this.rbg2_utf8.Name = "rbg2_utf8";
            this.rbg2_utf8.Size = new System.Drawing.Size(47, 16);
            this.rbg2_utf8.TabIndex = 3;
            this.rbg2_utf8.Text = "UTF8";
            this.rbg2_utf8.UseVisualStyleBackColor = true;
            // 
            // rbg2_utf8_bom
            // 
            this.rbg2_utf8_bom.AutoSize = true;
            this.rbg2_utf8_bom.Location = new System.Drawing.Point(48, 29);
            this.rbg2_utf8_bom.Name = "rbg2_utf8_bom";
            this.rbg2_utf8_bom.Size = new System.Drawing.Size(77, 16);
            this.rbg2_utf8_bom.TabIndex = 2;
            this.rbg2_utf8_bom.Text = "UTF-8 BOM";
            this.rbg2_utf8_bom.UseVisualStyleBackColor = true;
            // 
            // groupBoxFileContent
            // 
            this.groupBoxFileContent.Controls.Add(this.groupBox1);
            this.groupBoxFileContent.Location = new System.Drawing.Point(3, 147);
            this.groupBoxFileContent.Name = "groupBoxFileContent";
            this.groupBoxFileContent.Size = new System.Drawing.Size(598, 140);
            this.groupBoxFileContent.TabIndex = 13;
            this.groupBoxFileContent.TabStop = false;
            this.groupBoxFileContent.Text = "CUE文件处理";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxChangeSuffix);
            this.groupBox1.Controls.Add(this.cbCUEAssociatedFileExtension);
            this.groupBox1.Controls.Add(this.cbCUEAssociatedFileNameSync);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 114);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关联文件";
            // 
            // groupBoxChangeSuffix
            // 
            this.groupBoxChangeSuffix.Controls.Add(this.rbg1_flac);
            this.groupBoxChangeSuffix.Controls.Add(this.rbg1_ape);
            this.groupBoxChangeSuffix.Controls.Add(this.rbg1_tak);
            this.groupBoxChangeSuffix.Controls.Add(this.rbg1_tta);
            this.groupBoxChangeSuffix.Controls.Add(this.rbg1_wav);
            this.groupBoxChangeSuffix.Controls.Add(this.rbg1_m4a);
            this.groupBoxChangeSuffix.Controls.Add(this.rbg1_keep);
            this.groupBoxChangeSuffix.Location = new System.Drawing.Point(6, 42);
            this.groupBoxChangeSuffix.Name = "groupBoxChangeSuffix";
            this.groupBoxChangeSuffix.Size = new System.Drawing.Size(574, 66);
            this.groupBoxChangeSuffix.TabIndex = 7;
            this.groupBoxChangeSuffix.TabStop = false;
            this.groupBoxChangeSuffix.Text = "后缀改为";
            // 
            // rbg1_flac
            // 
            this.rbg1_flac.AutoSize = true;
            this.rbg1_flac.Location = new System.Drawing.Point(36, 29);
            this.rbg1_flac.Name = "rbg1_flac";
            this.rbg1_flac.Size = new System.Drawing.Size(47, 16);
            this.rbg1_flac.TabIndex = 0;
            this.rbg1_flac.Text = "FLAC";
            this.rbg1_flac.UseVisualStyleBackColor = true;
            // 
            // rbg1_ape
            // 
            this.rbg1_ape.AutoSize = true;
            this.rbg1_ape.Location = new System.Drawing.Point(448, 29);
            this.rbg1_ape.Name = "rbg1_ape";
            this.rbg1_ape.Size = new System.Drawing.Size(41, 16);
            this.rbg1_ape.TabIndex = 6;
            this.rbg1_ape.Text = "APE";
            this.rbg1_ape.UseVisualStyleBackColor = true;
            // 
            // rbg1_tak
            // 
            this.rbg1_tak.AutoSize = true;
            this.rbg1_tak.Location = new System.Drawing.Point(104, 29);
            this.rbg1_tak.Name = "rbg1_tak";
            this.rbg1_tak.Size = new System.Drawing.Size(41, 16);
            this.rbg1_tak.TabIndex = 1;
            this.rbg1_tak.Text = "TAK";
            this.rbg1_tak.UseVisualStyleBackColor = true;
            // 
            // rbg1_tta
            // 
            this.rbg1_tta.AutoSize = true;
            this.rbg1_tta.Location = new System.Drawing.Point(386, 29);
            this.rbg1_tta.Name = "rbg1_tta";
            this.rbg1_tta.Size = new System.Drawing.Size(41, 16);
            this.rbg1_tta.TabIndex = 5;
            this.rbg1_tta.Text = "TTA";
            this.rbg1_tta.UseVisualStyleBackColor = true;
            // 
            // rbg1_wav
            // 
            this.rbg1_wav.AutoSize = true;
            this.rbg1_wav.Location = new System.Drawing.Point(166, 29);
            this.rbg1_wav.Name = "rbg1_wav";
            this.rbg1_wav.Size = new System.Drawing.Size(41, 16);
            this.rbg1_wav.TabIndex = 2;
            this.rbg1_wav.Text = "WAV";
            this.rbg1_wav.UseVisualStyleBackColor = true;
            // 
            // rbg1_m4a
            // 
            this.rbg1_m4a.AutoSize = true;
            this.rbg1_m4a.Location = new System.Drawing.Point(228, 29);
            this.rbg1_m4a.Name = "rbg1_m4a";
            this.rbg1_m4a.Size = new System.Drawing.Size(137, 16);
            this.rbg1_m4a.TabIndex = 4;
            this.rbg1_m4a.Text = "M4A(Apple Lossless)";
            this.rbg1_m4a.UseVisualStyleBackColor = true;
            // 
            // rbg1_keep
            // 
            this.rbg1_keep.AutoSize = true;
            this.rbg1_keep.Checked = true;
            this.rbg1_keep.Location = new System.Drawing.Point(510, 29);
            this.rbg1_keep.Name = "rbg1_keep";
            this.rbg1_keep.Size = new System.Drawing.Size(47, 16);
            this.rbg1_keep.TabIndex = 3;
            this.rbg1_keep.TabStop = true;
            this.rbg1_keep.Text = "保持";
            this.rbg1_keep.UseVisualStyleBackColor = true;
            // 
            // cbCUEAssociatedFileExtension
            // 
            this.cbCUEAssociatedFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCUEAssociatedFileExtension.FormattingEnabled = true;
            this.cbCUEAssociatedFileExtension.Items.AddRange(new object[] {
            "全部 | (*.*)",
            "FLAC | (*.flac)",
            "TAK | (*.tak)",
            "WAV | (*.wav)",
            "M4A(Apple Lossless) | (*.m4a)",
            "TTA | (*.tta)",
            "APE | (*.ape)"});
            this.cbCUEAssociatedFileExtension.Location = new System.Drawing.Point(139, 17);
            this.cbCUEAssociatedFileExtension.Name = "cbCUEAssociatedFileExtension";
            this.cbCUEAssociatedFileExtension.Size = new System.Drawing.Size(202, 20);
            this.cbCUEAssociatedFileExtension.TabIndex = 15;
            // 
            // cbCUEAssociatedFileNameSync
            // 
            this.cbCUEAssociatedFileNameSync.AutoSize = true;
            this.cbCUEAssociatedFileNameSync.Location = new System.Drawing.Point(359, 20);
            this.cbCUEAssociatedFileNameSync.Name = "cbCUEAssociatedFileNameSync";
            this.cbCUEAssociatedFileNameSync.Size = new System.Drawing.Size(180, 16);
            this.cbCUEAssociatedFileNameSync.TabIndex = 17;
            this.cbCUEAssociatedFileNameSync.Text = "关联文件名改为与文件名相同";
            this.cbCUEAssociatedFileNameSync.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "仅改变后缀：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbg3_sc);
            this.groupBox2.Controls.Add(this.rbg3_tc);
            this.groupBox2.Controls.Add(this.rbg3_keep);
            this.groupBox2.Location = new System.Drawing.Point(3, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 66);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "简繁转换";
            // 
            // rbg3_sc
            // 
            this.rbg3_sc.AutoSize = true;
            this.rbg3_sc.Location = new System.Drawing.Point(48, 31);
            this.rbg3_sc.Name = "rbg3_sc";
            this.rbg3_sc.Size = new System.Drawing.Size(239, 16);
            this.rbg3_sc.TabIndex = 4;
            this.rbg3_sc.Text = "转为简体(注意转换后不要用 big5 编码)";
            this.rbg3_sc.UseVisualStyleBackColor = true;
            // 
            // rbg3_tc
            // 
            this.rbg3_tc.AutoSize = true;
            this.rbg3_tc.Location = new System.Drawing.Point(307, 31);
            this.rbg3_tc.Name = "rbg3_tc";
            this.rbg3_tc.Size = new System.Drawing.Size(71, 16);
            this.rbg3_tc.TabIndex = 5;
            this.rbg3_tc.Text = "转为繁体";
            this.rbg3_tc.UseVisualStyleBackColor = true;
            // 
            // rbg3_keep
            // 
            this.rbg3_keep.AutoSize = true;
            this.rbg3_keep.Checked = true;
            this.rbg3_keep.Location = new System.Drawing.Point(398, 31);
            this.rbg3_keep.Name = "rbg3_keep";
            this.rbg3_keep.Size = new System.Drawing.Size(47, 16);
            this.rbg3_keep.TabIndex = 6;
            this.rbg3_keep.TabStop = true;
            this.rbg3_keep.Text = "保持";
            this.rbg3_keep.UseVisualStyleBackColor = true;
            // 
            // buttonText
            // 
            this.buttonText.AllowDrop = true;
            this.buttonText.Location = new System.Drawing.Point(51, 371);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(299, 51);
            this.buttonText.TabIndex = 14;
            this.buttonText.Text = "普通文本处理（仅处理 txt/srt/ass/ssa/cue 文件）如需处理其他文件请设置文件匹配";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonText_DragDrop);
            this.buttonText.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonText_DragEnter);
            // 
            // buttonCUE
            // 
            this.buttonCUE.AllowDrop = true;
            this.buttonCUE.Location = new System.Drawing.Point(51, 434);
            this.buttonCUE.Name = "buttonCUE";
            this.buttonCUE.Size = new System.Drawing.Size(299, 51);
            this.buttonCUE.TabIndex = 15;
            this.buttonCUE.Text = "CUE文件处理（仅处理 cue 文件）";
            this.buttonCUE.UseVisualStyleBackColor = true;
            this.buttonCUE.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonCUE_DragDrop);
            this.buttonCUE.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonCUE_DragEnter);
            // 
            // cbNoLimit
            // 
            this.cbNoLimit.AutoSize = true;
            this.cbNoLimit.Checked = true;
            this.cbNoLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoLimit.Location = new System.Drawing.Point(401, 389);
            this.cbNoLimit.Name = "cbNoLimit";
            this.cbNoLimit.Size = new System.Drawing.Size(144, 16);
            this.cbNoLimit.TabIndex = 18;
            this.cbNoLimit.Text = "不受全局文件匹配约束";
            this.cbNoLimit.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchFileOption
            // 
            this.groupBoxSearchFileOption.Controls.Add(this.radioButtonTopDirectoryOnly);
            this.groupBoxSearchFileOption.Controls.Add(this.radioButtonAllDirectories);
            this.groupBoxSearchFileOption.Location = new System.Drawing.Point(3, 293);
            this.groupBoxSearchFileOption.Name = "groupBoxSearchFileOption";
            this.groupBoxSearchFileOption.Size = new System.Drawing.Size(598, 66);
            this.groupBoxSearchFileOption.TabIndex = 21;
            this.groupBoxSearchFileOption.TabStop = false;
            this.groupBoxSearchFileOption.Text = "拖曳文件夹搜索文件设置";
            // 
            // radioButtonTopDirectoryOnly
            // 
            this.radioButtonTopDirectoryOnly.AutoSize = true;
            this.radioButtonTopDirectoryOnly.Checked = true;
            this.radioButtonTopDirectoryOnly.Location = new System.Drawing.Point(48, 31);
            this.radioButtonTopDirectoryOnly.Name = "radioButtonTopDirectoryOnly";
            this.radioButtonTopDirectoryOnly.Size = new System.Drawing.Size(83, 16);
            this.radioButtonTopDirectoryOnly.TabIndex = 8;
            this.radioButtonTopDirectoryOnly.TabStop = true;
            this.radioButtonTopDirectoryOnly.Text = "仅当前目录";
            this.radioButtonTopDirectoryOnly.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllDirectories
            // 
            this.radioButtonAllDirectories.AutoSize = true;
            this.radioButtonAllDirectories.Location = new System.Drawing.Point(178, 31);
            this.radioButtonAllDirectories.Name = "radioButtonAllDirectories";
            this.radioButtonAllDirectories.Size = new System.Drawing.Size(83, 16);
            this.radioButtonAllDirectories.TabIndex = 9;
            this.radioButtonAllDirectories.Text = "包含子目录";
            this.radioButtonAllDirectories.UseVisualStyleBackColor = true;
            // 
            // TextProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSearchFileOption);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbNoLimit);
            this.Controls.Add(this.buttonCUE);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.groupBoxFileContent);
            this.Controls.Add(this.groupBoxEncoding);
            this.Name = "TextProcessControl";
            this.Size = new System.Drawing.Size(800, 496);
            this.Load += new System.EventHandler(this.TextProcessControl_Load);
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.groupBoxFileContent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxChangeSuffix.ResumeLayout(false);
            this.groupBoxChangeSuffix.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSearchFileOption.ResumeLayout(false);
            this.groupBoxSearchFileOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.RadioButton rbg2_keep;
        private System.Windows.Forms.RadioButton rbg2_ucs2_be;
        private System.Windows.Forms.RadioButton rbg2_ucs2_le;
        private System.Windows.Forms.RadioButton rbg2_ansi;
        private System.Windows.Forms.RadioButton rbg2_utf8;
        private System.Windows.Forms.RadioButton rbg2_utf8_bom;
        private System.Windows.Forms.GroupBox groupBoxFileContent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbg3_sc;
        private System.Windows.Forms.RadioButton rbg3_tc;
        private System.Windows.Forms.RadioButton rbg3_keep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxChangeSuffix;
        private System.Windows.Forms.RadioButton rbg1_flac;
        private System.Windows.Forms.RadioButton rbg1_ape;
        private System.Windows.Forms.RadioButton rbg1_tak;
        private System.Windows.Forms.RadioButton rbg1_tta;
        private System.Windows.Forms.RadioButton rbg1_wav;
        private System.Windows.Forms.RadioButton rbg1_m4a;
        private System.Windows.Forms.RadioButton rbg1_keep;
        private System.Windows.Forms.ComboBox cbCUEAssociatedFileExtension;
        private System.Windows.Forms.CheckBox cbCUEAssociatedFileNameSync;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonCUE;
        private System.Windows.Forms.CheckBox cbNoLimit;
        private System.Windows.Forms.GroupBox groupBoxSearchFileOption;
        private System.Windows.Forms.RadioButton radioButtonTopDirectoryOnly;
        private System.Windows.Forms.RadioButton radioButtonAllDirectories;
    }
}
