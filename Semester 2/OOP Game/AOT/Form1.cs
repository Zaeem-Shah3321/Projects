using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using AOTLibrary;


namespace GravityGame
{
    public partial class Form1 : Form
    {
        public static Game game;
        public static int Score;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            game = Game.GetGameInstance(this);

            System.Drawing.Point boundary = new System.Drawing.Point(this.Width - 50, this.Height-100);

            game.addGameObject(Properties.Resources.cls,GameObjectType.Player, 40, 80, new Movement(10, boundary));
            game.addGameObject(Properties.Resources.armmor, GameObjectType.Enemy, 420, 370, new ZigZag(10, boundary));
            game.addGameObject(Properties.Resources.warh, GameObjectType.Enemy, 120, 100, new Horizontal(10, boundary,Direction.Right));
            game.addGameObject(Properties.Resources.jawt,GameObjectType.Enemy, 200, 50, new Vertical(10, boundary,Direction.Down));
            game.addGameObject(Properties.Resources.beast, GameObjectType.Enemy, 400, 400, new Vertical(10, boundary, Direction.Up));
            Collisionss collisionDetection1 = new Collisionss(GameObjectType.Player,GameObjectType.Enemy,Collisions.DecreaseHealth);
            Collisionss collisionDetection2 = new Collisionss(GameObjectType.PlayerFire, GameObjectType.Enemy, Collisions.Kill);
            Collisionss collisionDetection3 = new Collisionss(GameObjectType.EnemyFire, GameObjectType.Player, Collisions.DecreaseHealthPlayer);
            game.AddCollisionDetection(collisionDetection1);
            game.AddCollisionDetection(collisionDetection2);
            game.AddCollisionDetection(collisionDetection3);
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                game.FirePlayer(Properties.Resources.Playerfire);
            }
            game.RemoveGameObject();
            game.update();
            Score = ((game.GetEnemiesCount() - game.EnemiesCount()) * 1);
            label3.Text = Score.ToString();
            if (game.EnemiesCount() == 0 || game.PlayersCount() == 0)
            {
                this.Close();
                Form gameover = new EndPage();
                gameover.Show();
            }
        }


        private void Enemyfiring_Tick(object sender, EventArgs e)
        {
            game.FireEnemy(Properties.Resources.EnemyFire);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
