namespace Arup_Renamer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonPrepend = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.tabControlEditOptions = new System.Windows.Forms.TabControl();
            this.tabPageAffix = new System.Windows.Forms.TabPage();
            this.tabPageReplace = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.checkedListBox_files.Location = new System.Drawing.Point(6, 130);
            this.checkedListBox_files.Name = "checkedListBox_files";
            this.checkedListBox_files.ScrollAlwaysVisible = true;
            this.checkedListBox_files.Size = new System.Drawing.Size(502, 394);
            this.checkedListBox_files.Sorted = true;
            this.checkedListBox_files.TabIndex = 0;
            this.checkedListBox_files.UseTabStops = false;
            // 
            // textBox_FolderPath
            // 
            this.textBox_FolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FolderPath.Location = new System.Drawing.Point(69, 530);
            this.textBox_FolderPath.Name = "textBox_FolderPath";
            this.textBox_FolderPath.Size = new System.Drawing.Size(439, 20);
            this.textBox_FolderPath.TabIndex = 1;
            this.textBox_FolderPath.Text = "C:\\";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_OpenFile.Location = new System.Drawing.Point(6, 529);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(57, 23);
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
            this.buttonSelectAll.Location = new System.Drawing.Point(6, 104);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 3;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Location = new System.Drawing.Point(85, 104);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDeselectAll.TabIndex = 4;
            this.buttonDeselectAll.Text = "Deselect All";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            this.buttonDeselectAll.Click += new System.EventHandler(this.buttonDeselectAll_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(167, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Multi-Select";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(69, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 20);
            this.textBox1.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // buttonAppend
            // 
            this.buttonAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAppend.Location = new System.Drawing.Point(434, 18);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(58, 23);
            this.buttonAppend.TabIndex = 8;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            // 
            // buttonPrepend
            // 
            this.buttonPrepend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrepend.Location = new System.Drawing.Point(370, 18);
            this.buttonPrepend.Name = "buttonPrepend";
            this.buttonPrepend.Size = new System.Drawing.Size(58, 23);
            this.buttonPrepend.TabIndex = 9;
            this.buttonPrepend.Text = "Prepend";
            this.buttonPrepend.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(6, 556);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(502, 23);
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
            this.tabControlEditOptions.Location = new System.Drawing.Point(6, 8);
            this.tabControlEditOptions.Name = "tabControlEditOptions";
            this.tabControlEditOptions.SelectedIndex = 0;
            this.tabControlEditOptions.Size = new System.Drawing.Size(502, 86);
            this.tabControlEditOptions.TabIndex = 11;
            // 
            // tabPageAffix
            // 
            this.tabPageAffix.Controls.Add(this.label3);
            this.tabPageAffix.Controls.Add(this.textBox1);
            this.tabPageAffix.Controls.Add(this.buttonPrepend);
            this.tabPageAffix.Controls.Add(this.buttonAppend);
            this.tabPageAffix.Location = new System.Drawing.Point(4, 22);
            this.tabPageAffix.Name = "tabPageAffix";
            this.tabPageAffix.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffix.Size = new System.Drawing.Size(494, 60);
            this.tabPageAffix.TabIndex = 0;
            this.tabPageAffix.Text = "Affix";
            this.tabPageAffix.UseVisualStyleBackColor = true;
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.button1);
            this.tabPageReplace.Controls.Add(this.label2);
            this.tabPageReplace.Controls.Add(this.label1);
            this.tabPageReplace.Controls.Add(this.textBox3);
            this.tabPageReplace.Controls.Add(this.textBox2);
            this.tabPageReplace.Location = new System.Drawing.Point(4, 22);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReplace.Size = new System.Drawing.Size(494, 60);
            this.tabPageReplace.TabIndex = 1;
            this.tabPageReplace.Text = "Replace";
            this.tabPageReplace.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(86, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(86, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find What:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace with:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(413, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Replace";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Affix what:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 591);
            this.Controls.Add(this.tabControlEditOptions);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonDeselectAll);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.textBox_FolderPath);
            this.Controls.Add(this.checkedListBox_files);
            this.MinimumSize = new System.Drawing.Size(400, 280);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_OpenFile;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonPrepend;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TabControl tabControlEditOptions;
        private System.Windows.Forms.TabPage tabPageAffix;
        private System.Windows.Forms.TabPage tabPageReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

