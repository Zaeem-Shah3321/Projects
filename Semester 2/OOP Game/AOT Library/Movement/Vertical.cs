using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTLibrary
{
    public class Vertical:IMovement
    {
        private int Speed;
        private Point Boundary;
        private Direction Direction;
        private int OffSet = 30;
        public Vertical(int speed, Point boundary, Direction direction)
        {
            this.Speed = speed;
            this.Boundary = boundary;
            this.Direction = direction;
        }

        public Point Move(Point location)
        {
            if ((location.Y + OffSet) >= Boundary.Y)
            {
                Direction = Direction.Up;
            }

            else if (location.Y - OffSet <= 0)
            {
                Direction = Direction.Down;
            }
            if (Direction == Direction.Up)
            {
                location.Y -= Speed;
            }
            else if (Direction == Direction.Down)
            {
                location.Y += Speed;
            }
            return location;
        }
    }
}
