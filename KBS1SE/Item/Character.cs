using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KBS1SE
{
    public class Character : Item.Item
    {
        public override ETouchAction OnTouch(Item.Item touchedItem)
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD

        public Character(Vector position, Vector size, Vector speed) : base(position, size, speed)
        {
        }
=======
        public Character() : base(0, 0, 0, 0, 5, 5, System.Drawing.Color.Green) { }

>>>>>>> 23a83df4bb0b3d69286725d72d38894456a59fca
    }
}
