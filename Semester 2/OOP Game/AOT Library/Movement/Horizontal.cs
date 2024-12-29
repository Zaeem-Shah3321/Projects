using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOTLibrary
{
    public class Horizontal : IMovement
    {
        private int Speed;
        private Point Boundary;
        private Direction Direction;
        private int OffSet = 70;
        public Horizontal(int speed, Point boundary, Direction direction)
        {
            this.Speed = speed;
            this.Boundary = boundary;
            this.Direction = direction;
        }

        public Point Move(Point location)
        {
            if ((location.X + OffSet) >= Boundary.X)
            {
                Direction = Direction.Left;
            }
            
            else if (location.X-OffSet <= 0)
            {
                Direction = Direction.Right;
            }
            if (Direction == Direction.Left)
            {
                location.X -= Speed;
            }
            else if (Direction == Direction.Right)
            {
                location.X += Speed;
            }
                return location;
        }
    }
}
