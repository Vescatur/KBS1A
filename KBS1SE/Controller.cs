using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KBS1SE
{
    public class Controller
    {
        Character character;

        public Controller(Character character)
        {
            this.character = character;
        }

        // Verplaats speler met een stap van Dx en Dy per tijdseenheid.
        public void Move(int MaxX, int MaxY)
        {
            if(character.Position.X + character.Speed.X > MaxX ){
                character.Speed = new Vector(MaxX - character.Position.X, character.Speed.Y);
            }
            if (character.Position.Y + character.Speed.Y > MaxY)
            {
                character.Speed = new Vector(character.Speed.X, MaxY - character.Position.Y);
            }
            character.Position = character.Speed;
        }
    }
}
