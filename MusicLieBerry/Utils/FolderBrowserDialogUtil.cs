using System;
using System.Windows.Forms;
using MusicLieBerry.Properties;

namespace MusicLieBerry.Utils
{
    public class FolderBrowserDialogUtil
    {
        public static FolderBrowserDialog InitFolderBrowserDialogForNew(FolderBrowserDialog folderBrowserDialog)
        {
            folderBrowserDialog.SelectedPath = null;
            folderBrowserDialog.Description = Resources.MainForm_NewOperation_Select_Root_Folder;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = false;
            return folderBrowserDialog;
        }
    }
}