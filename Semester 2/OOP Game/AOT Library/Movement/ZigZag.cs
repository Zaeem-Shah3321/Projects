using AOTLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTLibrary
{
    public class ZigZag : IMovement
    {
        private int speed;
        private Point boundry;
        private Direction direction;
        private int count;
        private int offset = 90;
        public ZigZag(int speed, Point boundry)
        {
            this.speed = speed;
            this.boundry = boundry;
            this.direction = Direction.Right;
            count = 0;
        }

        public Point Move(Point location)
        {
            if (direction == Direction.Right)
            {
                if (count < 5)
                {
                    location.X += speed;
                    location.Y -= speed;
                }
                else if (count >= 5 && count < 10)
                {
                    location.X += speed;
                    location.Y += speed;
                }
            }
            else if (direction == Direction.Left)
            {
                if (count < 5)
                {
                    location.X -= speed;
                    location.Y += speed;
                }
                else if (count >= 5 && count < 10)
                {
                    location.X -= speed;
                    location.Y -= speed;
                }
            }
            if ((location.X + offset) >= boundry.X)
            {
                direction = Direction.Left;

            }
            else if ((location.X + speed) <= 0)
            {
                direction = Direction.Right;

            }
            if (count == 10)
            {
                count = 0;
            }
            count++;
            return location;
        }


    }
}
