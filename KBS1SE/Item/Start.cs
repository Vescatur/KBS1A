﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBS1SE.Item
{
    public class Start : Item
    {
        public override void Move(int x, int y)
        {
            Position = Position;
        }

        public override ETouchAction OnTouch(Item touchedItem)
        {
            throw new NotImplementedException();
        }
        public Start() : base(0, 0, 0, 0, 50, 50, System.Drawing.Color.Yellow) { }

    }
}
