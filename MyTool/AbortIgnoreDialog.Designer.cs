namespace MyTool
{
    partial class AbortIgnoreDialog
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
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonIgnore = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAbort
            // 
            this.buttonAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbort.Location = new System.Drawing.Point(115, 19);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(95, 30);
            this.buttonAbort.TabIndex = 0;
            this.buttonAbort.Text = "中止";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonIgnore
            // 
            this.buttonIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIgnore.Location = new System.Drawing.Point(247, 19);
            this.buttonIgnore.Name = "buttonIgnore";
            this.buttonIgnore.Size = new System.Drawing.Size(95, 30);
            this.buttonIgnore.TabIndex = 1;
            this.buttonIgnore.Text = "忽略";
            this.buttonIgnore.UseVisualStyleBackColor = true;
            this.buttonIgnore.Click += new System.EventHandler(this.buttonIgnore_Click);
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.panelButton.Controls.Add(this.buttonAbort);
            this.panelButton.Controls.Add(this.buttonIgnore);
            this.panelButton.Location = new System.Drawing.Point(-4, 101);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(377, 62);
            this.panelButton.TabIndex = 2;
            // 
            // panelText
            // 
            this.panelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelText.Controls.Add(this.labelText);
            this.panelText.Location = new System.Drawing.Point(49, 28);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(272, 45);
            this.panelText.TabIndex = 3;
            // 
            // labelText
            // 
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(0, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(272, 45);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "labelText";
            // 
            // AbortIgnoreDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 162);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AbortIgnoreDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AbortIgnoreDialog";
            this.panelButton.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonIgnore;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Label labelText;
    }
}