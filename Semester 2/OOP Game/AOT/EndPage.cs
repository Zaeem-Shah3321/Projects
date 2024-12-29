using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOTLibrary;


namespace GravityGame
{
    public partial class EndPage : Form
    {
        public EndPage()
        {
            InitializeComponent();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            if (Form1.game.PlayersCount() == 0)
                StatusLabel.Text = "TITAN ATE YOU";
            if (Form1.game.EnemiesCount() == 0)
                StatusLabel.Text = "TITANS DESTROYED";
            ScoreLabel.Text = (Form1.Score).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
