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
            character.Position = Vector.Add(character.Position, character.Speed);
            if (character.Position.X > MaxX)
            {
                character.Position = new Vector(MaxX, character.Position.Y);
            }
            if (character.Position.X < 0)
            {
                character.Position = new Vector(0, character.Position.Y);
            }
            if (character.Position.Y < 0)
            {
                character.Position = new Vector(character.Position.X, 0);
            }
            if (character.Position.Y > MaxY)
            {
                character.Position = new Vector(character.Position.X, MaxY);
            }
        }
    }
}
