using System;

namespace KBS1SE.Item
{
    public class Character : Item
    {
        public override ETouchAction OnTouch(Item touchedItem)
        {
            throw new NotImplementedException();
        }

        public Character() : base(0, 0, 0, 0, 5, 5, System.Drawing.Color.Green) { }

    }
}
