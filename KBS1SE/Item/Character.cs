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

        public Character(Vector position, Vector size, Vector speed) : base(position, size, speed)
        {
        }
    }
}
