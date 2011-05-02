namespace MusicLieBerry.Objects
{
    public class Album : MlbTreeNode
    {
        public int ReleaseYear { get; set; }
        public string AlbumName { get; set; }
        public string ContributingArtists { get; set; }
    }
}