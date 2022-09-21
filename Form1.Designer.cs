﻿namespace Arup_Renamer
{
    partial class Form1
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
            this.checkedListBox_files = new System.Windows.Forms.CheckedListBox();
            this.textBox_FolderPath = new System.Windows.Forms.TextBox();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.textBoxAffixWhat = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonPrepend = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.tabControlEditOptions = new System.Windows.Forms.TabControl();
            this.tabPageAffix = new System.Windows.Forms.TabPage();
            this.labelAffixWhat = new System.Windows.Forms.Label();
            this.tabPageReplace = new System.Windows.Forms.TabPage();
            this.buttonReplaceReplace = new System.Windows.Forms.Button();
            this.labelReplaceWith = new System.Windows.Forms.Label();
            this.labelFindWhat = new System.Windows.Forms.Label();
            this.textBoxReplaceWith = new System.Windows.Forms.TextBox();
            this.textBoxFindWhat = new System.Windows.Forms.TextBox();
            this.buttonSearchDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControlEditOptions.SuspendLayout();
            this.tabPageAffix.SuspendLayout();
            this.tabPageReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox_files
            // 
            this.checkedListBox_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_files.CheckOnClick = true;
            this.checkedListBox_files.FormattingEnabled = true;
            this.checkedListBox_files.Location = new System.Drawing.Point(8, 160);
            this.checkedListBox_files.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox_files.Name = "checkedListBox_files";
            this.checkedListBox_files.ScrollAlwaysVisible = true;
            this.checkedListBox_files.Size = new System.Drawing.Size(668, 480);
            this.checkedListBox_files.Sorted = true;
            this.checkedListBox_files.TabIndex = 0;
            this.checkedListBox_files.UseTabStops = false;
            // 
            // textBox_FolderPath
            // 
            this.textBox_FolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FolderPath.Location = new System.Drawing.Point(8, 652);
            this.textBox_FolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_FolderPath.Name = "textBox_FolderPath";
            this.textBox_FolderPath.Size = new System.Drawing.Size(535, 22);
            this.textBox_FolderPath.TabIndex = 1;
            this.textBox_FolderPath.Text = "C:\\";
            this.textBox_FolderPath.TextChanged += new System.EventHandler(this.textBox_FolderPath_TextChanged);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_OpenFile.Location = new System.Drawing.Point(601, 651);
            this.button_OpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(76, 28);
            this.button_OpenFile.TabIndex = 2;
            this.button_OpenFile.Text = "Open";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(8, 128);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectAll.TabIndex = 3;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Location = new System.Drawing.Point(113, 128);
            this.buttonDeselectAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(100, 28);
            this.buttonDeselectAll.TabIndex = 4;
            this.buttonDeselectAll.Text = "Deselect All";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            this.buttonDeselectAll.Click += new System.EventHandler(this.buttonDeselectAll_Click);
            // 
            // textBoxAffixWhat
            // 
            this.textBoxAffixWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAffixWhat.Location = new System.Drawing.Point(92, 23);
            this.textBoxAffixWhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAffixWhat.Name = "textBoxAffixWhat";
            this.textBoxAffixWhat.Size = new System.Drawing.Size(392, 22);
            this.textBoxAffixWhat.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 38);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // buttonAppend
            // 
            this.buttonAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAppend.Location = new System.Drawing.Point(579, 22);
            this.buttonAppend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(77, 28);
            this.buttonAppend.TabIndex = 8;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonPrepend
            // 
            this.buttonPrepend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrepend.Location = new System.Drawing.Point(493, 22);
            this.buttonPrepend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrepend.Name = "buttonPrepend";
            this.buttonPrepend.Size = new System.Drawing.Size(77, 28);
            this.buttonPrepend.TabIndex = 9;
            this.buttonPrepend.Text = "Prepend";
            this.buttonPrepend.UseVisualStyleBackColor = true;
            this.buttonPrepend.Click += new System.EventHandler(this.buttonPrepend_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(8, 684);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(669, 28);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // tabControlEditOptions
            // 
            this.tabControlEditOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEditOptions.Controls.Add(this.tabPageAffix);
            this.tabControlEditOptions.Controls.Add(this.tabPageReplace);
            this.tabControlEditOptions.Location = new System.Drawing.Point(8, 10);
            this.tabControlEditOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlEditOptions.Name = "tabControlEditOptions";
            this.tabControlEditOptions.SelectedIndex = 0;
            this.tabControlEditOptions.Size = new System.Drawing.Size(669, 106);
            this.tabControlEditOptions.TabIndex = 11;
            // 
            // tabPageAffix
            // 
            this.tabPageAffix.Controls.Add(this.labelAffixWhat);
            this.tabPageAffix.Controls.Add(this.textBoxAffixWhat);
            this.tabPageAffix.Controls.Add(this.buttonPrepend);
            this.tabPageAffix.Controls.Add(this.buttonAppend);
            this.tabPageAffix.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAffix.Name = "tabPageAffix";
            this.tabPageAffix.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAffix.Size = new System.Drawing.Size(661, 77);
            this.tabPageAffix.TabIndex = 0;
            this.tabPageAffix.Text = "Affix";
            this.tabPageAffix.UseVisualStyleBackColor = true;
            // 
            // labelAffixWhat
            // 
            this.labelAffixWhat.AutoSize = true;
            this.labelAffixWhat.Location = new System.Drawing.Point(9, 28);
            this.labelAffixWhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAffixWhat.Name = "labelAffixWhat";
            this.labelAffixWhat.Size = new System.Drawing.Size(64, 16);
            this.labelAffixWhat.TabIndex = 10;
            this.labelAffixWhat.Text = "Affix what:";
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.buttonReplaceReplace);
            this.tabPageReplace.Controls.Add(this.labelReplaceWith);
            this.tabPageReplace.Controls.Add(this.labelFindWhat);
            this.tabPageReplace.Controls.Add(this.textBoxReplaceWith);
            this.tabPageReplace.Controls.Add(this.textBoxFindWhat);
            this.tabPageReplace.Location = new System.Drawing.Point(4, 25);
            this.tabPageReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageReplace.Size = new System.Drawing.Size(661, 77);
            this.tabPageReplace.TabIndex = 1;
            this.tabPageReplace.Text = "Replace";
            this.tabPageReplace.UseVisualStyleBackColor = true;
            // 
            // buttonReplaceReplace
            // 
            this.buttonReplaceReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplaceReplace.Location = new System.Drawing.Point(551, 38);
            this.buttonReplaceReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReplaceReplace.Name = "buttonReplaceReplace";
            this.buttonReplaceReplace.Size = new System.Drawing.Size(100, 28);
            this.buttonReplaceReplace.TabIndex = 4;
            this.buttonReplaceReplace.Text = "Replace";
            this.buttonReplaceReplace.UseVisualStyleBackColor = true;
            this.buttonReplaceReplace.Click += new System.EventHandler(this.buttonReplaceReplace_Click);
            // 
            // labelReplaceWith
            // 
            this.labelReplaceWith.AutoSize = true;
            this.labelReplaceWith.Location = new System.Drawing.Point(11, 43);
            this.labelReplaceWith.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReplaceWith.Name = "labelReplaceWith";
            this.labelReplaceWith.Size = new System.Drawing.Size(87, 16);
            this.labelReplaceWith.TabIndex = 3;
            this.labelReplaceWith.Text = "Replace with:";
            // 
            // labelFindWhat
            // 
            this.labelFindWhat.AutoSize = true;
            this.labelFindWhat.Location = new System.Drawing.Point(28, 11);
            this.labelFindWhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFindWhat.Name = "labelFindWhat";
            this.labelFindWhat.Size = new System.Drawing.Size(70, 16);
            this.labelFindWhat.TabIndex = 2;
            this.labelFindWhat.Text = "Find What:";
            // 
            // textBoxReplaceWith
            // 
            this.textBoxReplaceWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplaceWith.Location = new System.Drawing.Point(115, 38);
            this.textBoxReplaceWith.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxReplaceWith.Name = "textBoxReplaceWith";
            this.textBoxReplaceWith.Size = new System.Drawing.Size(427, 22);
            this.textBoxReplaceWith.TabIndex = 1;
            // 
            // textBoxFindWhat
            // 
            this.textBoxFindWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFindWhat.Location = new System.Drawing.Point(115, 6);
            this.textBoxFindWhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFindWhat.Name = "textBoxFindWhat";
            this.textBoxFindWhat.Size = new System.Drawing.Size(427, 22);
            this.textBoxFindWhat.TabIndex = 0;
            // 
            // buttonSearchDirectory
            // 
            this.buttonSearchDirectory.Image = global::Arup_Renamer.Properties.Resources.FolderOpened;
            this.buttonSearchDirectory.Location = new System.Drawing.Point(552, 651);
            this.buttonSearchDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchDirectory.Name = "buttonSearchDirectory";
            this.buttonSearchDirectory.Size = new System.Drawing.Size(48, 28);
            this.buttonSearchDirectory.TabIndex = 12;
            this.buttonSearchDirectory.UseVisualStyleBackColor = true;
            this.buttonSearchDirectory.Click += new System.EventHandler(this.buttonSearchDirectory_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 727);
            this.Controls.Add(this.buttonSearchDirectory);
            this.Controls.Add(this.tabControlEditOptions);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDeselectAll);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.textBox_FolderPath);
            this.Controls.Add(this.checkedListBox_files);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(527, 334);
            this.Name = "Form1";
            this.Text = "Arup Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControlEditOptions.ResumeLayout(false);
            this.tabPageAffix.ResumeLayout(false);
            this.tabPageAffix.PerformLayout();
            this.tabPageReplace.ResumeLayout(false);
            this.tabPageReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_files;
        private System.Windows.Forms.TextBox textBox_FolderPath;
        private System.Windows.Forms.Button button_OpenFile;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonPrepend;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAffixWhat;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TabControl tabControlEditOptions;
        private System.Windows.Forms.TabPage tabPageAffix;
        private System.Windows.Forms.TabPage tabPageReplace;
        private System.Windows.Forms.Label labelReplaceWith;
        private System.Windows.Forms.Label labelFindWhat;
        private System.Windows.Forms.TextBox textBoxReplaceWith;
        private System.Windows.Forms.TextBox textBoxFindWhat;
        private System.Windows.Forms.Button buttonReplaceReplace;
        private System.Windows.Forms.Label labelAffixWhat;
        private System.Windows.Forms.Button buttonSearchDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
