using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOTLibrary
{
    public class Collisionss
    {
        // class for collision detection

        private GameObjectType Object1;
        private GameObjectType Object2;
        private Collisions Action;

        public Collisionss(GameObjectType type1, GameObjectType type2, Collisions action)
        {
            this.Object1 = type1;
            this.Object2 = type2;
            this.Action = action;
        }

        public void checkCollision(List<GameObject> gameobjects)
        {
            foreach (GameObject GO in gameobjects)
            {
                if (GO.GetGameObjectType() == this.Object1)
                {
                    foreach (GameObject GOO in gameobjects)
                    {
                        if (GOO.GetGameObjectType() == this.Object2)
                        {
                            if (GO.Pb.Bounds.IntersectsWith(GOO.Pb.Bounds))
                            {
                                if (Action == Collisions.DecreaseHealth)
                                {
                                    GO.SetHealth(GO.GetHealth() - 1);  
                                }
                                else if (Action == Collisions.DecreaseHealthPlayer)
                                {
                                    GO.SetHealth(0);
                                    GOO.SetHealth(GOO.GetHealth() - 5);
                                }
                                else if (Action == Collisions.Kill)
                                {
                                    GO.SetHealth(0);
                                    GOO.SetHealth(0);  
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }
    }



}

