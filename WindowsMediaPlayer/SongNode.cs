namespace WindowsMediaPlayer
{
    class SongNode
    {
        public SongNode next, prev;
        public string songPath, songName;
        public SongNode()
        {
            prev = next = null;
            songName = songPath = "";
        }

        public SongNode(string songPath, string songName)
        {
            this.songName = songName;
            this.songPath = songPath;
            prev = next = null;
        }
    }
}