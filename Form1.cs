using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arup_Renamer
{
    public partial class Form1 : Form
    {
        private const string VersionNumber = "Beta 1.0";
        private const string ApplicationName = "Arup Renamer";
        private string WindowName { 
            get { return $"{ApplicationName} {VersionNumber} | {DirName}"; }
        }

        //Directory Path
        private string DirPath {
            set { 
                textBox_FolderPath.Text = value;
                this.Text = WindowName;
            } 
            get { return textBox_FolderPath.Text; }
        } 
        private string DirName {
            get { return DirPath.Substring(DirPath.LastIndexOf('\\') + 1); }
        }

        private Dictionary<string, string> FileDictionary;

        public Form1()
        {
            InitializeComponent();
            DirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _ = PopulateList();
            toolTips.SetToolTip(buttonRevert, "Revert Changes");
            toolTips.SetToolTip(buttonApply , "Applies Name Changes to Files");
        }
        
        //Checking Boxes in the List
        private void Checker(bool state)
        {
            for (int i = 0; i < checkedListBox_files.Items.Count; i++)
                checkedListBox_files.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
        }
        private void buttonSelectAll_Click(object sender, EventArgs e) { 
            Checker(true); 
        }
        private void buttonDeselectAll_Click(object sender, EventArgs e) { 
            Checker(false); 
        }
        
        //Used for Renaming Keys in the Dicontnary
        public static void RenameKey<TKey, TValue>(IDictionary<TKey, TValue> dic, TKey fromKey, TKey toKey)
        {
            TValue value = dic[fromKey];
            dic.Remove(fromKey);
            dic[toKey] = value;
        }

        //Just Refreshes the Checkbox List and doesn't touch the dictonary.
        private void UpdateList() {
            checkedListBox_files.Items.Clear();
            foreach (string file in FileDictionary.Keys) checkedListBox_files.Items.Add(file);
        }

        private async Task<bool> PopulateList()
        {
            button_OpenFile.Text = "Open";
            checkedListBox_files.Items.Clear();
            try
            {
                //string[] files = Directory.GetFiles(dirPath, "*", SearchOption.AllDirectories);
                List<string> files = new List<string>(Directory.GetFiles(DirPath, "*", SearchOption.TopDirectoryOnly));
                if (checkBoxExtensions.Checked) {
                    FileDictionary = files.ToDictionary(k => Path.GetFileName(k), v => v);
                }
                else {
                    FileDictionary = files.ToDictionary(k => Path.GetFileNameWithoutExtension(k), v => v);
                }
                //FileDictionary = files.ToDictionary(k => Path.GetFileName(k), v => v);
                UpdateList();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private async void button_OpenFile_Click(object sender, EventArgs e)
        {
            DirPath = textBox_FolderPath.Text;
            checkedListBox_files.Items.Clear();
            await PopulateList();
        }

        private async void buttonSearchDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                DirPath = folderBrowserDialog.SelectedPath;
                await PopulateList();
            }
        }

        private void textBox_FolderPath_TextChanged(object sender, EventArgs e)
        {
            button_OpenFile.Text = "Load";
        }
        /// </code>
        /// 
        
        //Button Functions
        private void buttonReplaceReplace_Click(object sender, EventArgs e)
        {
            foreach (Object item in checkedListBox_files.CheckedItems) {

                if (item.ToString().Contains(textBoxFindWhat.Text)) {
                    string newString = item.ToString().Replace(textBoxFindWhat.Text, textBoxReplaceWith.Text);
                    RenameKey(FileDictionary, item.ToString(), newString);
                }
            }
            UpdateList();
        }

        private string[] splitExtension(string fileName) {
            int index = fileName.LastIndexOf('.');
            string[] arr = { 
                fileName.Substring(0, index), 
                fileName.Substring(index) 
            };
            return arr;
        }


        private void buttonPrepend_Click(object sender, EventArgs e)
        {
            foreach (Object item in checkedListBox_files.CheckedItems)
            {
                string newString = textBoxAffixWhat.Text + item.ToString();
                RenameKey(FileDictionary, item.ToString(), newString);
            }
            UpdateList();
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            foreach (Object item in checkedListBox_files.CheckedItems)
            {
                string newString;
                if (checkBoxExtensions.Checked) {
                    newString = item.ToString().Insert(item.ToString().LastIndexOf('.'), textBoxAffixWhat.Text);
                }
                else {
                    newString = item.ToString() + textBoxAffixWhat.Text;
                }
                RenameKey(FileDictionary, item.ToString(), newString);
            }
            UpdateList();
        }

        //Apply Changes
        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            progressBarApply.Value = 0;
            progressBarApply.Visible = true;
            progressBarApply.Maximum = FileDictionary.Count();
            int i = 0; //Number of Changes Made
            foreach (KeyValuePair<string, string> entry in FileDictionary) {
                if (entry.Key != Path.GetFileName(entry.Value)) {
                    FileInfo fi = new FileInfo(entry.Value);
                    if (fi.Exists) {
                        string newName = $"{Path.GetDirectoryName(entry.Value)}\\{entry.Key}";
                        fi.MoveTo(newName);
                        i++;
                    }
                }
                progressBarApply.PerformStep();
            }
            progressBarApply.Visible = false;
            this.Enabled = true;
            string message = $"Successfully updated {i} file names.";
            SystemSounds.Exclamation.Play();
            MessageBox.Show(message, "Complete",
                    MessageBoxButtons.OK);
        }

        private void checkBoxExtensions_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            PopulateList();
        }
    }
}
