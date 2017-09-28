using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBS1SE
{
    public class Character : Item.Item
    {
        public override ETouchAction OnTouch(Item.Item touchedItem)
        {
            throw new NotImplementedException();
        }
        public Character() : base(0, 0, 0, 0, 5, 5, System.Drawing.Color.Green) { }

    }
}
