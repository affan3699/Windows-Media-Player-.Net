namespace WindowsMediaPlayer
{
    partial class mediaPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaPlayerForm));
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.playListButton = new System.Windows.Forms.Button();
            this.nowPlayingButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.songLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeBar.BackColor = System.Drawing.Color.AliceBlue;
            this.volumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeBar.Location = new System.Drawing.Point(564, 56);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(223, 45);
            this.volumeBar.TabIndex = 4;
            this.volumeBar.Value = 50;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.playListButton);
            this.panel1.Controls.Add(this.nowPlayingButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 599);
            this.panel1.TabIndex = 5;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox.Location = new System.Drawing.Point(3, 425);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(177, 22);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // playListButton
            // 
            this.playListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playListButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playListButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playListButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playListButton.Image = ((System.Drawing.Image)(resources.GetObject("playListButton.Image")));
            this.playListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playListButton.Location = new System.Drawing.Point(0, 453);
            this.playListButton.Name = "playListButton";
            this.playListButton.Size = new System.Drawing.Size(239, 48);
            this.playListButton.TabIndex = 1;
            this.playListButton.Text = "PLAYLIST";
            this.playListButton.UseVisualStyleBackColor = true;
            this.playListButton.Click += new System.EventHandler(this.playListButton_Click);
            this.playListButton.MouseEnter += new System.EventHandler(this.playListButton_MouseEnter);
            this.playListButton.MouseLeave += new System.EventHandler(this.playListButton_MouseLeave);
            // 
            // nowPlayingButton
            // 
            this.nowPlayingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nowPlayingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nowPlayingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowPlayingButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlayingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nowPlayingButton.Image = global::WindowsMediaPlayer.Properties.Resources.play__2_;
            this.nowPlayingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nowPlayingButton.Location = new System.Drawing.Point(0, 501);
            this.nowPlayingButton.Name = "nowPlayingButton";
            this.nowPlayingButton.Size = new System.Drawing.Size(239, 48);
            this.nowPlayingButton.TabIndex = 1;
            this.nowPlayingButton.Text = "NOW PLAYING";
            this.nowPlayingButton.UseVisualStyleBackColor = true;
            this.nowPlayingButton.Click += new System.EventHandler(this.nowPlayingButton_Click);
            this.nowPlayingButton.MouseEnter += new System.EventHandler(this.nowPlayingButton_MouseEnter);
            this.nowPlayingButton.MouseLeave += new System.EventHandler(this.nowPlayingButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseButton.Image = global::WindowsMediaPlayer.Properties.Resources.Load_icon;
            this.browseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseButton.Location = new System.Drawing.Point(0, 549);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(239, 48);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "BROWSE SONGS";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            this.browseButton.MouseEnter += new System.EventHandler(this.browseButton_MouseEnter);
            this.browseButton.MouseLeave += new System.EventHandler(this.browseButton_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.totalTimeLabel);
            this.panel2.Controls.Add(this.currentTimeLabel);
            this.panel2.Controls.Add(this.shuffleButton);
            this.panel2.Controls.Add(this.repeatButton);
            this.panel2.Controls.Add(this.songLabel);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.volumeBar);
            this.panel2.Controls.Add(this.playButton);
            this.panel2.Controls.Add(this.stopButton);
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.previousButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(241, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 109);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(711, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "/";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalTimeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalTimeLabel.Location = new System.Drawing.Point(734, 32);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(41, 21);
            this.totalTimeLabel.TabIndex = 12;
            this.totalTimeLabel.Text = "0:00";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentTimeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.currentTimeLabel.Location = new System.Drawing.Point(664, 32);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(41, 21);
            this.currentTimeLabel.TabIndex = 11;
            this.currentTimeLabel.Text = "0:00";
            // 
            // shuffleButton
            // 
            this.shuffleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.Image = global::WindowsMediaPlayer.Properties.Resources.shuffle__1_;
            this.shuffleButton.Location = new System.Drawing.Point(58, 64);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(48, 44);
            this.shuffleButton.TabIndex = 10;
            this.shuffleButton.Text = "0";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.repeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatButton.Image = global::WindowsMediaPlayer.Properties.Resources.repeat;
            this.repeatButton.Location = new System.Drawing.Point(4, 63);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(48, 44);
            this.repeatButton.TabIndex = 9;
            this.repeatButton.Text = "0";
            this.repeatButton.UseVisualStyleBackColor = true;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.songLabel.Location = new System.Drawing.Point(5, 30);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(14, 21);
            this.songLabel.TabIndex = 7;
            this.songLabel.Text = ".";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::WindowsMediaPlayer.Properties.Resources.speaker;
            this.pictureBox2.Location = new System.Drawing.Point(511, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(-1, -1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(791, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Image = global::WindowsMediaPlayer.Properties.Resources.play;
            this.playButton.Location = new System.Drawing.Point(405, 58);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(48, 44);
            this.playButton.TabIndex = 1;
            this.playButton.Text = ".";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Image = global::WindowsMediaPlayer.Properties.Resources.stop;
            this.stopButton.Location = new System.Drawing.Point(248, 58);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(48, 44);
            this.stopButton.TabIndex = 1;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this.stopButton.MouseEnter += new System.EventHandler(this.stopButton_MouseEnter);
            this.stopButton.MouseLeave += new System.EventHandler(this.stopButton_MouseLeave);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Image = global::WindowsMediaPlayer.Properties.Resources.forward;
            this.NextButton.Location = new System.Drawing.Point(457, 56);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(48, 44);
            this.NextButton.TabIndex = 3;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseEnter += new System.EventHandler(this.NextButton_MouseEnter);
            this.NextButton.MouseLeave += new System.EventHandler(this.NextButton_MouseLeave);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Image = global::WindowsMediaPlayer.Properties.Resources.backward;
            this.previousButton.Location = new System.Drawing.Point(349, 58);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(48, 44);
            this.previousButton.TabIndex = 3;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            this.previousButton.MouseEnter += new System.EventHandler(this.previousButton_MouseEnter);
            this.previousButton.MouseLeave += new System.EventHandler(this.previousButton_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // playList
            // 
            this.playList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playList.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.playList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playList.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playList.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 20;
            this.playList.Location = new System.Drawing.Point(241, 0);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(789, 480);
            this.playList.TabIndex = 8;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(1030, 599);
            this.windowsMediaPlayer.TabIndex = 0;
            this.windowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.windowsMediaPlayer_PlayStateChange);
            // 
            // mediaPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 599);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mediaPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button playListButton;
        private System.Windows.Forms.Button nowPlayingButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label label1;
    }
}

