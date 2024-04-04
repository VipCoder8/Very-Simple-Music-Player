using NAudio.Wave;
using System;
using System.Threading;
using System.Windows.Forms;
namespace Test {
    public partial class MusicPlayer : Form {
        WaveOut woe;
        MediaFoundationReader mfr;
        bool isMoved;
        public MusicPlayer() {
            InitializeComponent();
            FormClosed += (sender, e) => {
                Environment.Exit(0);
            };
            this.openFileToolStripMenuItem.Click += OpenAFile;
            this.playStop.Click += playStopMusic;
            this.soundVolume.ValueChanged += changeVolume;
            this.musicTrackBar.MouseDown += musicTrackBarMouseDown;
            this.musicTrackBar.MouseUp += musicTrackBarMouseUp;
        }
        public void OpenAFile(object sender, EventArgs e) {
            DialogResult result = this.fileChooser.ShowDialog();
            if (result == DialogResult.OK) {
                mfr = new MediaFoundationReader(this.fileChooser.FileName);
                woe = new WaveOut();
                woe.DeviceNumber = 0;
                woe.Init(mfr);
                woe.Volume = 0.3f;
                musicTrackBar.SetRange(0, (int)mfr.TotalTime.TotalSeconds);
                this.musicPanel.Visible = true;
                updateTrackBar();

            }
        }
        public void updateTrackBar() {
            musicTrackBar.Value = 0;
            playStop.Text = "Play";
            playStop.Checked = false;
            new Thread(() => {
                while (true) {
                    while (playStop.Text == "Stop") {
                        musicTrackBar.BeginInvoke(new Action(() => {
                            if (musicTrackBar.Value < mfr.TotalTime.TotalSeconds - 1) {
                                if (!isMoved) {
                                    musicTrackBar.Value = (int)mfr.CurrentTime.TotalSeconds;
                                }
                            }
                        }));
                        Thread.Sleep(1000);
                    }
                    Thread.Sleep(100);
                }
            }).Start();
            woe.PlaybackStopped += (sender, e) => {
                musicTrackBar.Value = 0;
                playStop.Text = "Play";
                playStop.Checked = false;
                woe.Stop();
                mfr.Position = 0;
            };
        }
        public void playStopMusic(object sender, EventArgs e) {
            if (playStop.Text == "Play") {
                woe.Play();
                playStop.Text = "Stop";
            }
            else if (playStop.Text == "Stop") {
                woe.Pause();
                playStop.Text = "Play";
            }
        }
        public void musicTrackBarMouseDown(object sender, EventArgs e) {
            isMoved = true;
        }
        public void musicTrackBarMouseUp(object sender, EventArgs e) {
            mfr.Position = (long)(musicTrackBar.Value * mfr.WaveFormat.AverageBytesPerSecond);
            isMoved = false;
        }
        public void changeVolume(object semder, EventArgs e) {
            woe.Volume = this.soundVolume.Value / 10.0f;
        }
    }
}