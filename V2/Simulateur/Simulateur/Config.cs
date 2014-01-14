using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Simulateur.Comportement;
using System.IO;
namespace Simulateur
{
    public partial class Config : Form
    {
        private ComportementLectureMusic PlayMusic = new ComportementLectureMusic();
        public Config()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Config_Load(object sender, EventArgs e)
        {
           
            string MP3=Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+@"\Sound\music.mp3";

            PlayMusic.PlayMP3(MP3);
            PlayMusic.Play();

        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Config_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
