using System;
using System.Windows.Forms;
using MusicLieBerry.Managers;
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
            try
            {
                string selectedPath = FolderBrowserDialogUtil.InitFolderBrowserDialogForNew(folderBrowserDialog).ShowFolderBrowserDialog();
                folderBrowserDialog.Reset();
                if (!string.IsNullOrWhiteSpace(selectedPath))
                {
                    tvMlbTree.Nodes.Clear();
                    tvMlbTree.Nodes.Add(TreeCreator.CreateTreeWithPath(selectedPath));
                }
            }
            catch (Exception ex)
            {
                MlbMessageBox.ShowErrorMessageBox(ex.Message);
            }
        }
        #endregion


    }
}
