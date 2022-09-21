using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arup_Renamer
{
    public partial class Form1 : Form
    {
        private string DirPath {
            set { textBox_FolderPath.Text = value; } 
            get { return textBox_FolderPath.Text; }
        } 

        private Dictionary<string, string> FileDictionary;

        public Form1()
        {
            InitializeComponent();
            DirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _ = PopulateList();
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

        /// <summary>
        /// Load Functions
        /// </summary>
        /// <returns>Functions to hand the opening and loading of a folder</returns>
        /// <code>
        /// 
        public void RenameKey<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey fromKey, TKey toKey)
        {
            TValue value = dic[fromKey];
            dic.Remove(fromKey);
            dic[toKey] = value;
        }


        private void UpdateList() {
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
                FileDictionary = files.ToDictionary(k => Path.GetFileName(k), v => v);
                UpdateList();
                //foreach (string file in FileDictionary.Keys) checkedListBox_files.Items.Add(file);
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

        private void buttonPrepend_Click(object sender, EventArgs e)
        {

        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {

        }
    }
}
