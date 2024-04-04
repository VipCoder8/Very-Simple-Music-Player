namespace Test
{
    partial class MusicPlayer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileChooser = new System.Windows.Forms.OpenFileDialog();
            this.musicPanel = new System.Windows.Forms.Panel();
            this.playStop = new System.Windows.Forms.CheckBox();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.soundVolume = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.musicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // fileChooser
            // 
            this.fileChooser.Filter = "MP3 File(*.mp3)|*.mp3|OGG File(*.ogg)|*.ogg|WAV File(*.wav)|*.wav";
            // 
            // musicPanel
            // 
            this.musicPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.musicPanel.Controls.Add(this.soundVolume);
            this.musicPanel.Controls.Add(this.playStop);
            this.musicPanel.Controls.Add(this.musicTrackBar);
            this.musicPanel.Location = new System.Drawing.Point(0, 27);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(343, 424);
            this.musicPanel.TabIndex = 1;
            this.musicPanel.Visible = false;
            // 
            // playStop
            // 
            this.playStop.AutoSize = true;
            this.playStop.Location = new System.Drawing.Point(158, 339);
            this.playStop.Name = "playStop";
            this.playStop.Size = new System.Drawing.Size(46, 17);
            this.playStop.TabIndex = 1;
            this.playStop.Text = "Play";
            this.playStop.UseVisualStyleBackColor = true;
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.Location = new System.Drawing.Point(12, 288);
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(319, 45);
            this.musicTrackBar.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.soundVolume.Location = new System.Drawing.Point(3, 339);
            this.soundVolume.Name = "trackBar1";
            this.soundVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.soundVolume.Size = new System.Drawing.Size(45, 85);
            this.soundVolume.TabIndex = 2;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.musicPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MusicPlayer";
            this.Text = "MediaPlayer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.musicPanel.ResumeLayout(false);
            this.musicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog fileChooser;
        private System.Windows.Forms.Panel musicPanel;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.CheckBox playStop;
        private System.Windows.Forms.TrackBar soundVolume;
    }
}