using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GravityGame
{
    public partial class MainPage : Form
    {
        SoundPlayer bg = new SoundPlayer(@"F:\Zaeem\aasf.wav");
        public MainPage()
        {
            bg.Play();
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Play = new Form1();
            Play.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
