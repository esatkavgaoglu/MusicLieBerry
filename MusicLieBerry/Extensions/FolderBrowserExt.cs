using System.Windows.Forms;

namespace MusicLieBerry.Extensions
{
    public static class FolderBrowserExt
    {
        public static string ShowFolderBrowserDialog(this FolderBrowserDialog folderBrowser)
        {
            folderBrowser.ShowDialog();
            return folderBrowser.SelectedPath;
        }
    }
}