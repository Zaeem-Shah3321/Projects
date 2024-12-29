using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;

namespace AOTLibrary
{
    public class Movement:IMovement
    {
        private int Speed;
        private System.Drawing.Point Boundary;
        private int limit = 70;

        public Movement(int speed, System.Drawing.Point boundary)
        {
            this.Speed = speed;
            this.Boundary = boundary;
        }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if ((location.Y + limit) <= Boundary.Y && Keyboard.IsKeyPressed(Key.DownArrow))
            {
                location.Y += Speed;
            }

            else if (location.Y - limit >= 0 && Keyboard.IsKeyPressed(Key.UpArrow))
            {
                location.Y -= Speed;
            }
            else if (location.X - limit >= 0 && Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                location.X -= Speed;
            }
            if ((location.X + limit) <= Boundary.X && Keyboard.IsKeyPressed(Key.RightArrow))
            {
                location.X+= Speed;
            }
            return location;
        }
    }
}
