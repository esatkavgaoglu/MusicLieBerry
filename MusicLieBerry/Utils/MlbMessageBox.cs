using System.Windows.Forms;
using MusicLieBerry.Properties;

namespace MusicLieBerry.Utils
{
    public class MlbMessageBox
    {
        public static void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, Resources.MessageBox_ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}