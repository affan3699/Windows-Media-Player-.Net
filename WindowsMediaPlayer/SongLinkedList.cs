namespace WindowsMediaPlayer
{
    class SongLinkedList
    {
        private SongNode head, currentSong, tail;

        public SongLinkedList() => head = tail = currentSong = null;
        public void newSong(string songPath, string songName)
        {
            SongNode temp = new SongNode(songPath, songName);
            SongNode current = new SongNode();

            if (head == null)
            {
                head = temp;
                head.next = head;
                head.prev = head;
                tail = head;
            }

            else
            {
                temp.next = tail.next;
                temp.prev = tail;
                tail.next = temp;
                head.prev = temp;
                tail = temp;
                /*temp.next = head;
                current = head;

                while(current.next != head)
                {
                    current = current.next;
                }

                current.next = temp;*/
            }

            bubbleSort();
        }

        public SongNode getPlaylist()
        {
            //bubbleSort();
            return head;
        }
        public string playSong()
        {
            if (head == null)
            {
                return "0";
            }

            else
            {
                currentSong = head;
                return currentSong.songPath;
            }

        }

        public bool checkPlaylistEmpty()
        {
            if (head == null)
            {
                return true;
            }

            return false;
        }

        public string nextSong()
        {
            currentSong = currentSong.next;
            return currentSong.songPath;
        }

        public string prevSong()
        {
            currentSong = currentSong.prev;
            return currentSong.songPath;
        }

        public string songName()
        {
            return currentSong.songName;
        }

        public string nextSongName()
        {
            return currentSong.songName;
        }

        public string prevSongName()
        {
            return currentSong.songName;
        }

        public string searchSongPath(string songName)
        {
            SongNode current = new SongNode();
            current = head;

            while (current.next != head && current.songName != songName)
            {
                current = current.next;
            }

            if (current != null)
            {
                currentSong = current;
                return current.songPath;
            }

            return "0";
        }

        public string shuffle(int value)
        {
            SongNode current = new SongNode();
            current = head;

            for (int i = 1; i < value; i++)
            {
                current = current.next;
            }

            currentSong = current;
            return current.songPath;
        }

        public int countPlaylist()
        {
            SongNode current = new SongNode();
            current = head;
            int count = 0;

            while (current.next != head)
            {
                current = current.next;
                count++;
            }

            count++;
            return count;

        }

        public void bubbleSort()
        {
            if(head == null)
            {

            }

            else
            {
                int l = countPlaylist();

                for(int i=0; i<l; i++)
                {
                    SongNode prev = null;
                    SongNode current = new SongNode();
                    SongNode temp = new SongNode();
                    current = head;

                    while(current != head && current.next != head)
                    {
                        if(string.Compare(current.songName, current.next.songName) == 1)
                        {
                            if(prev == null)
                            {
                                temp = current.next;
                                current.next = temp.next;
                                temp.next = current;
                                head = prev = temp;
                            }

                            else
                            {
                                temp = current.next;
                                prev.next = temp;
                                current.next = temp.next;
                                temp.next = current;
                            }
                        }

                        prev = current;
                        current = current.next;
                    }
                }
            }
        }
    }
}
