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
        private string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private Dictionary<string, string> FileDictionary;

        public Form1()
        {
            InitializeComponent();
            textBox_FolderPath.Text = dirPath;
            PopulateList();
        }

        private async Task<bool> PopulateList() {
            try {
                //string[] files = Directory.GetFiles(dirPath, "*", SearchOption.AllDirectories);
                List<string> files = new List<string>(Directory.GetFiles(dirPath, "*", SearchOption.TopDirectoryOnly));
                FileDictionary = files.ToDictionary(k => Path.GetFileName(k), v => v);
                //Dictionary<string, string> fileDictionary = new Dictionary<string, string>();
                foreach (string file in FileDictionary.Keys) checkedListBox_files.Items.Add(file);
                return true;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Checker(bool state)
        {
            for (int i = 0; i < checkedListBox_files.Items.Count; i++)
                checkedListBox_files.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            Checker(true);
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            Checker(false);
        }
    }
}
