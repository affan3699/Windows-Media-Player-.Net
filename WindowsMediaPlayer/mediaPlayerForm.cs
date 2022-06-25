using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsMediaPlayer
{
    public partial class mediaPlayerForm : Form
    {
        SongLinkedList s; // declaring object of linked list
        bool stopButtonClicked = false; // tells wheater stopbutton is clicked or not, intially not clicked
        bool repeat = false, shuffle = false; // for repeat and shuffle button
        List<string> list = new List<string>(); // for searching

        public mediaPlayerForm()
        {
            s = new SongLinkedList(); // creating declared object of linkedlist
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "MP3 MP4| *.mp3;*.mp4;*.m4a;*.MP3;*.MP4;*.M4A";
            dialog.Multiselect = true; // we can choose multiple items, in one click
            string[] files, onlyFileName;

            if (dialog.ShowDialog() == DialogResult.OK) // ShowDialog method give us the screen to browsse, and in general every result of dialog box saves in DialogResult
            {
                files = dialog.FileNames; // saving all song paths into files array
                onlyFileName = dialog.SafeFileNames; // saving only songname in array

                for (int i = 0; i < files.Length; i++)
                {
                    //playList.Items.Add(onlyFileName[i]);
                    s.newSong(files[i], onlyFileName[i]); // adding each songpath and songname in linkedlist
                }

                createPlaylist(); // add all names of songs in listBox(PlayList)

                if (playButton.Text.Equals("."))
                {
                    playButton.Text = ",";
                    windowsMediaPlayer.URL = s.playSong(); // getting first song path, URl is a method, which needs path of file or song
                    windowsMediaPlayer.Ctlcontrols.play();
                    //playButton.Image = Image.FromFile("D:/DSA Project/WindowsMediaPlayer/WindowsMediaPlayer/Resources/pause.png");
                    playButton.Image = Properties.Resources.pause;
                    songLabel.Text = s.songName(); // displaying song name
                    timer1.Start();
                }
            }
        }

        private void createPlaylist()
        {
            /*In short, this func is displaying all songs in listbox using forward traversal logic*/

            playList.Items.Clear(); // everytime this func calls, whole playlist is cleared.
            SongNode playlist = new SongNode();
            SongNode temp = new SongNode();

            playlist = s.getPlaylist(); //getplaylist returns first element of linked list i.e firstSongname
            temp = s.getPlaylist(); // same, but for traversing

            while (playlist.next != temp)
            {
                playList.Items.Add(playlist.songName);
                list.Add(playlist.songName); // add songnames in list also, for searching
                playlist = playlist.next;
            }

            playList.Items.Add(playlist.songName);
            list.Add(playlist.songName);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            /*if(s.playSong() == "0")
            {
                browseButton_Click(null, null);
                return;
            }*/

            if (s.checkPlaylistEmpty() == true) // checking if a user first press playbutton, so if playlist is empty, dialog box will auto will open
            {
                browseButton_Click(null, null); // calling browseButtonClick event
                return;
            }

            if (playButton.Text.Equals("."))
            {
                playButton.Text = ",";
                windowsMediaPlayer.Ctlcontrols.play();
                //playButton.Image = Image.FromFile("D:/DSA Project/WindowsMediaPlayer/WindowsMediaPlayer/Resources/pause.png");
                playButton.Image = Properties.Resources.pause;
                songLabel.Text = s.songName();
                timer1.Start();
            }

            else
            {

                playButton.Text = ".";
                windowsMediaPlayer.Ctlcontrols.pause();
                //playButton.Image = Image.FromFile("D:/DSA Project/WindowsMediaPlayer/WindowsMediaPlayer/Resources/play (2).png");
                playButton.Image = Properties.Resources.play__2_;
                timer1.Stop();
            }

        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            stopButtonClicked = true;
            windowsMediaPlayer.Ctlcontrols.stop();
            //playButton.Image = Image.FromFile(@"D:/DSA Project/WindowsMediaPlayer/WindowsMediaPlayer/Resources/play (2).png");
            playButton.Image = Properties.Resources.play__2_;
            playButton.Text = ".";
            songLabel.Text = "";
            timer1.Stop();
            progressBar1.Value = 0;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.URL = s.nextSong();
            windowsMediaPlayer.Ctlcontrols.play();
            songLabel.Text = s.nextSongName();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.URL = s.prevSong();
            windowsMediaPlayer.Ctlcontrols.play();
            songLabel.Text = s.prevSongName();
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            windowsMediaPlayer.settings.volume = volumeBar.Value;
        }

        private void nowPlayingButton_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.BringToFront();
        }

        private void playListButton_Click(object sender, EventArgs e)
        {
            playList.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = Convert.ToInt32(windowsMediaPlayer.Ctlcontrols.currentItem.duration);
            progressBar1.Value = Convert.ToInt32(windowsMediaPlayer.Ctlcontrols.currentPosition);
            timer1.Interval = 1000; // 1 Second
            currentTimeLabel.Text = windowsMediaPlayer.Ctlcontrols.currentPositionString; // currentTime of song playing
            totalTimeLabel.Text = windowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString(); // total time of song
            shuffled();
        }

        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = playList.SelectedIndex;

            if (index >= 0)
            {
                string songName = playList.Items[index].ToString();
                string songPath = s.searchSongPath(songName);
                windowsMediaPlayer.URL = songPath;
                windowsMediaPlayer.Ctlcontrols.play();
                songLabel.Text = songName;
                playButton.Image = Properties.Resources.pause;
                playButton.Text = ",";
                timer1.Start();
            }

        }

        private void playListButton_MouseEnter(object sender, EventArgs e)
        {
            playListButton.BackColor = Color.AliceBlue;
        }

        private void playListButton_MouseLeave(object sender, EventArgs e)
        {
            playListButton.BackColor = Color.DodgerBlue;
        }

        private void nowPlayingButton_MouseEnter(object sender, EventArgs e)
        {
            nowPlayingButton.BackColor = Color.AliceBlue;
        }

        private void nowPlayingButton_MouseLeave(object sender, EventArgs e)
        {
            nowPlayingButton.BackColor = Color.DodgerBlue;
        }

        private void browseButton_MouseEnter(object sender, EventArgs e)
        {
            browseButton.BackColor = Color.AliceBlue;
        }

        private void browseButton_MouseLeave(object sender, EventArgs e)
        {
            browseButton.BackColor = Color.DodgerBlue;
        }

        private void stopButton_MouseEnter(object sender, EventArgs e)
        {
            stopButton.BackColor = Color.AliceBlue;
        }

        private void stopButton_MouseLeave(object sender, EventArgs e)
        {
            stopButton.BackColor = Color.DodgerBlue;
        }

        private void previousButton_MouseEnter(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.AliceBlue;
        }

        private void previousButton_MouseLeave(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.DodgerBlue;
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.AliceBlue;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.DodgerBlue;
        }

        private void NextButton_MouseEnter(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.AliceBlue;
        }

        private void NextButton_MouseLeave(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.DodgerBlue;
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            if (repeatButton.Text.Equals("0"))
            {
                repeat = true;
                repeatButton.Text = "1";
                repeatButton.BackColor = Color.White;

                shuffle = false;
                shuffleButton.Text = "0";
                shuffleButton.BackColor = Color.DodgerBlue;
            }

            else
            {
                repeat = false;
                repeatButton.Text = "0";
                repeatButton.BackColor = Color.DodgerBlue;
            }
        }

        private void windowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (repeat == true && shuffle == false && windowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (stopButtonClicked == false) // checking if a user has clicked stop button
                {
                    windowsMediaPlayer.Ctlcontrols.play();
                }

                else
                {
                    stopButtonClicked = false;
                }

            }

            /*else if (shuffle == true && windowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (stopButtonClicked == false)
                {
                    MessageBox.Show("hello");
                    string songPath = s.shuffle(3);
                    windowsMediaPlayer.URL = songPath;
                    windowsMediaPlayer.Ctlcontrols.play();
                    songLabel.Text = s.songName();
                }

                else
                {
                    stopButtonClicked = false;
                }

            }*/
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            if (shuffleButton.Text.Equals("0"))
            {
                shuffle = true;
                shuffleButton.Text = "1";
                shuffleButton.BackColor = Color.White;

                repeat = false;
                repeatButton.Text = "0";
                repeatButton.BackColor = Color.DodgerBlue;
            }

            else
            {
                shuffle = false;
                shuffleButton.Text = "0";
                shuffleButton.BackColor = Color.DodgerBlue;
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            /*int mousePos = e.X;
            int value = mousePos / progressBar1.Width;
            int max = progressBar1.Maximum;
            int min = progressBar1.Minimum;
            value = min + value * (max - min);
            progressBar1.Value = value;*/
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            playList.Items.Clear();

            foreach (string item in list)
            {
                if (item.Contains(searchTextBox.Text.ToLower()) || item.Contains(searchTextBox.Text.ToUpper()))
                {
                    playList.Items.Add(item);
                }
            }
        }

        private void shuffled()
        {
            if (shuffle == true && repeat == false && windowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (stopButtonClicked == false) // checking if a user has clicked stop button
                {
                    Random random = new Random();
                    int PlaylistCount = s.countPlaylist();
                    int num = random.Next(PlaylistCount);
                    string songPath = s.shuffle(num);
                    windowsMediaPlayer.URL = songPath;
                    windowsMediaPlayer.Ctlcontrols.play();
                    songLabel.Text = s.songName();
                }

                else
                {
                    stopButtonClicked = false;
                }

            }
        }
    }
}
