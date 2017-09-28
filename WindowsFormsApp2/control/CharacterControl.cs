using KBS1SE.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBS1SE.control
{
    public class CharacterControl
    {
        Character character;

        public CharacterControl(Character character)
        {
            this.character = character;
        }

        // Verplaats character met een stap van Dx en Dy per tijdseenheid.
        public void Move(int beschikbareWidth, int beschikbareHeight)
        {
            character.X += character.Dx;
            if (character.X < 0 && character.Dx < 0)
            {
                character.Dx = -character.Dx;
            }
            else if (character.X + character.Width > beschikbareWidth && character.Dx > 0)
            {
                character.Dx = -character.Dx;
            }

            character.Y += character.Dy;
            if (character.Y < 0 && character.Dy < 0)
            {
                character.Dy = -character.Dy;
            }
            else if (character.Y + character.Heigth > beschikbareHeight && character.Dy > 0)
            {
                character.Dy = -character.Dy;
            }
        }
    }
}

