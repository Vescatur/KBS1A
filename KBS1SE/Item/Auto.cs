using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KBS1SE.Item
{
    public class Auto : Item
    {
        // declare een delegate for the ItemAction event
        public delegate void ItemActionHander(object sender);

        // declare de ItemActoin event via de delegate
        public event ItemActionHander ItemAction;

        public Auto(int a, int b, Character character) : base(a - 50, b - 50, 0, 0, 50, 50, System.Drawing.Color.Red)
        {
            myCharacter = character;
        }
        private Character myCharacter;
        public override void Move(int x, int y)
        {
            if (myCharacter.Position.X < Position.X)
            {
                Speed = new Vector(-1, Speed.Y);

            }
            else if (myCharacter.Position.X > Position.X)
            {
                Speed = new Vector(1, Speed.Y);
            }
            else
            {
                Speed = new Vector(0, Speed.Y);
            }
            if (myCharacter.Position.Y < Position.Y)
            {
                Speed = new Vector(Speed.X, -1);

            }
            else if (myCharacter.Position.Y > Position.Y)
            {
                Speed = new Vector(Speed.X, 1);
            }
            else
            {
                Speed = new Vector(Speed.X, 0);
            }
            Position = Vector.Add(Position, Speed);
        }
        public override ETouchAction OnTouch(Item touchedItem)
        {
            throw new NotImplementedException();
        }
    }
}

