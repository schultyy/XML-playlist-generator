using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XML_Playlist_Generator
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btBrowseRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select your Folder with albums";
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.ShowNewFolderButton = false;
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtRootfolder.Text = dialog.SelectedPath;
            }
        }

        private void btBrowseFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.AutoUpgradeEnabled = true;
            dialog.DefaultExt = "xml";
            dialog.Filter = "Xml - File | *.xml";
            dialog.OverwritePrompt = true;
            dialog.Title = "Where do you want to save your playlist?";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPlaylist.Text = dialog.FileName;
            }
        }
    }
}
