using System;
using System.IO;
using System.Windows.Forms;
using MusicLieBerry.Properties;

namespace MusicLieBerry.Managers
{
    public class TreeCreator
    {
        public static TreeNode CreateTreeWithPath(string path)
        {
            if(!string.IsNullOrWhiteSpace(path))
            {
                if (Directory.Exists(path))
                {
                    TreeNode root = new TreeNode();
                    root.Text = "root";
                    string[] artistsPath = Directory.GetDirectories(path);
                    foreach (string artistPath in artistsPath)
                    {
                        TreeNode artistNode = new TreeNode();
                        DirectoryInfo di = new DirectoryInfo(artistPath);
                        artistNode.Text = di.Name;
                        root.Nodes.Add(artistNode);
                        string[] albumsPath = Directory.GetDirectories(artistPath);
                        foreach (string albumPath in albumsPath)
                        {
                            TreeNode albumNode = new TreeNode();
                            di = new DirectoryInfo(albumPath);
                            albumNode.Text = di.Name;
                            artistNode.Nodes.Add(albumNode);
                            string[] songsPath = Directory.GetFiles(albumPath);
                            foreach (string songPath in songsPath)
                            {
                                TreeNode songNode = new TreeNode();
                                FileInfo fi = new FileInfo(songPath);
                                songNode.Text = fi.Name;
                                albumNode.Nodes.Add(songNode);

                            }
                        }
                    }
                    return root;    
                }
                throw new Exception(Resources.TreeCreator_Ex_NonexistingPath);
            }
            throw new Exception(Resources.TreeCreator_Ex_EmptyPath);
        }
    }
}