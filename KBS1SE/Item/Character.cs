using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KBS1SE.Item
{
    public class Character : Item
    {
        

        public override ETouchAction OnTouch(Item touchedItem)
        {
            throw new NotImplementedException();
        }

        public override void Move(int MaxX, int MaxY)
        {
            MaxX -= Convert.ToInt32(Size.X);
            MaxY -= Convert.ToInt32(Size.X);
            Position = Vector.Add(Position, Speed);
            if (Position.X > MaxX)
            {
                Position = new Vector(MaxX, Position.Y);
            }
            if (Position.X < 0)
            {
                Position = new Vector(0, Position.Y);
            }
            if (Position.Y < 0)
            {
                Position = new Vector(Position.X, 0);
            }
            if (Position.Y > MaxY)
            {
                Position = new Vector(Position.X, MaxY);
            }
        }

        public Character() : base(0, 0, 0, 0, 50, 50, System.Drawing.Color.Blue) { }

    }
}
