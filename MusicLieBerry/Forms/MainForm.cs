using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MusicLieBerry.Objects;
using MusicLieBerry.Properties;
using MusicLieBerry.Extensions;
using MusicLieBerry.Utils;

namespace MusicLieBerry.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        #region ToolStripMenu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOperation();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog(this);
        }
        #endregion

        #region ToolStrip
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewOperation();
        }
        #endregion

        #region ToolOperations
        private void NewOperation()
        {
            string selectedPath = FolderBrowserDialogUtil.InitFolderBrowserDialogForNew(folderBrowserDialog).ShowFolderBrowserDialog();
            folderBrowserDialog.Reset();
            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                MessageBox.Show("Selected path : " + selectedPath);
            }

        }
        #endregion


    }
}
