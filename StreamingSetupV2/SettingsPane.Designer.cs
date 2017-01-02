namespace StreamingSetupV2
{
    partial class SettingsPane
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
            this.outputDirectoryGroupBox = new System.Windows.Forms.GroupBox();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.outputDirTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.livescoreXMLBrowse = new System.Windows.Forms.Button();
            this.livescoreXMLDir = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resetButton = new System.Windows.Forms.Button();
            this.outputDirectoryGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputDirectoryGroupBox
            // 
            this.outputDirectoryGroupBox.Controls.Add(this.outputBrowseButton);
            this.outputDirectoryGroupBox.Controls.Add(this.outputDirTextBox);
            this.outputDirectoryGroupBox.Location = new System.Drawing.Point(5, 12);
            this.outputDirectoryGroupBox.Name = "outputDirectoryGroupBox";
            this.outputDirectoryGroupBox.Size = new System.Drawing.Size(276, 54);
            this.outputDirectoryGroupBox.TabIndex = 0;
            this.outputDirectoryGroupBox.TabStop = false;
            this.outputDirectoryGroupBox.Text = "Output Directory";
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(195, 19);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputBrowseButton.TabIndex = 1;
            this.outputBrowseButton.Text = "Browse";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // outputDirTextBox
            // 
            this.outputDirTextBox.Enabled = false;
            this.outputDirTextBox.Location = new System.Drawing.Point(6, 21);
            this.outputDirTextBox.Name = "outputDirTextBox";
            this.outputDirTextBox.Size = new System.Drawing.Size(183, 20);
            this.outputDirTextBox.TabIndex = 0;
            this.outputDirTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputDirectoryBrowserDialog
            // 
            this.outputDirectoryBrowserDialog.Description = "Browse for Output Directory";
            this.outputDirectoryBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.outputDirectoryBrowserDialog.SelectedPath = "properties.settings.default.ExportDirectory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.livescoreXMLBrowse);
            this.groupBox1.Controls.Add(this.livescoreXMLDir);
            this.groupBox1.Location = new System.Drawing.Point(5, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livescore XML File";
            // 
            // livescoreXMLBrowse
            // 
            this.livescoreXMLBrowse.Location = new System.Drawing.Point(195, 19);
            this.livescoreXMLBrowse.Name = "livescoreXMLBrowse";
            this.livescoreXMLBrowse.Size = new System.Drawing.Size(75, 23);
            this.livescoreXMLBrowse.TabIndex = 1;
            this.livescoreXMLBrowse.Text = "Browse";
            this.livescoreXMLBrowse.UseVisualStyleBackColor = true;
            this.livescoreXMLBrowse.Click += new System.EventHandler(this.livescoreXMLBrowse_Click);
            // 
            // livescoreXMLDir
            // 
            this.livescoreXMLDir.Enabled = false;
            this.livescoreXMLDir.Location = new System.Drawing.Point(6, 21);
            this.livescoreXMLDir.Name = "livescoreXMLDir";
            this.livescoreXMLDir.Size = new System.Drawing.Size(183, 20);
            this.livescoreXMLDir.TabIndex = 0;
            this.livescoreXMLDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(168, 134);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(103, 30);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(21, 134);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(76, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML Files|*.xml";
            this.openFileDialog1.InitialDirectory = "properties.settings.default.exportDirectory";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(103, 134);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(59, 30);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SettingsPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 177);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputDirectoryGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsPane";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Tag = "";
            this.Text = "Settings";
            this.outputDirectoryGroupBox.ResumeLayout(false);
            this.outputDirectoryGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox outputDirectoryGroupBox;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.TextBox outputDirTextBox;
        private System.Windows.Forms.FolderBrowserDialog outputDirectoryBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button livescoreXMLBrowse;
        private System.Windows.Forms.TextBox livescoreXMLDir;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button resetButton;
    }
}