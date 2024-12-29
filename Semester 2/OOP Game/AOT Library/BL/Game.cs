using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AOTLibrary
{
    public class Game
    {
        private Form FormReference;
        private static Game GameInstance;
        private List<Collisionss> CollisionDetections;
        private List<GameObject> GameObjects;
        private int PlayerCount;
        private int EnemyCount;
        private int FireTurn;
        private Game(Form form)
        {
            this.FormReference = form;
            GameObjects = new List<GameObject>();
            CollisionDetections = new List<Collisionss>();
            PlayerCount = 0;
            EnemyCount = 0;
            FireTurn = 0;
        }
        public static Game GetGameInstance(Form form)
        {
            if (GameInstance == null)
            {
                GameInstance = new Game(form);
            }
            return GameInstance;
        }
        public void addGameObject(Image img, GameObjectType type, int Left, int Top, IMovement controller)
        {
            if (!(type == GameObjectType.Player && PlayerCount > 0) || (type == GameObjectType.Enemy && EnemyCount > 5))
            {
                if (type == GameObjectType.Player)
                {
                    PlayerCount++;
                }
                else if (type == GameObjectType.Enemy)
                {
                    EnemyCount++;
                }
                GameObject gameobject = new GameObject(FormReference, img, type, Left, Top, controller);
                FormReference.Controls.Add(gameobject.Pb);
                GameObjects.Add(gameobject);
            }
        }

        public void update()
        {

            foreach (GameObject gameobject in GameObjects)
            {
                gameobject.Update();
                foreach (Collisionss collision in CollisionDetections)
                {
                    collision.checkCollision(GameObjects);
                }
            }

        }
        public void AddCollisionDetection(Collisionss collision)
        {
            CollisionDetections.Add(collision);
        }
        public int PlayersCount()
        {
            List<GameObject> Players = new List<GameObject>();

            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetGameObjectType() == GameObjectType.Player)
                {
                    Players.Add(gameobject);
                }
            }
            return Players.Count;
        }
        public void FireEnemy(Image img)
        {
            List<GameObject> Enemies = new List<GameObject>();
            int left = 0, top = 0;
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetGameObjectType() == GameObjectType.Enemy)
                {
                    Enemies.Add(gameobject);
                }
            }
            if (Enemies != null && Enemies.Count > FireTurn)
            {
                GameObject enemy = Enemies[FireTurn % 4];
                left = enemy.Pb.Left - 3;
                top = (enemy.Pb.Top) + (enemy.Pb.Height / 2);
                addGameObject(img, GameObjectType.EnemyFire, left, top, new FireMovement(30, new Point(FormReference.Width, FormReference.Height), Direction.Left));
            }
            else if (Enemies.Count != 0)
            {
                FireTurn--;
            }
        }
        public void RemoveGameObject()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetHealth() == 0 || gameobject.Pb.Location.X > FormReference.Width || gameobject.Pb.Location.Y > FormReference.Height)
                {

                    GameObjects.Remove(gameobject);
                    FormReference.Controls.Remove(gameobject.Pb);
                }
            }
        }
        public int GetEnemiesCount()
        {
            return EnemyCount;
        }
        public int EnemiesCount()
        {
            List<GameObject> Enemies = new List<GameObject>();

            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetGameObjectType() == GameObjectType.Enemy)
                {
                    Enemies.Add(gameobject);
                }
            }
            return Enemies.Count;
        }
        public void FirePlayer(Image img)
        {
            int left = 0, top = 0;
            foreach (GameObject gameobject in GameObjects)
            {
                if (gameobject.GetGameObjectType() == GameObjectType.Player)
                {
                    left = gameobject.Pb.Left + gameobject.Pb.Width;
                    top = (gameobject.Pb.Top) + (gameobject.Pb.Width / 2);
                    break;
                }
            }
            addGameObject(img, GameObjectType.PlayerFire, left, top, new FireMovement(20, new Point(FormReference.Width, FormReference.Height), Direction.Right));
        }
    }
}