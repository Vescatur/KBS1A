using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBS1SE.Item
{
    public class Field
    {
        public static List<Item> ItemList = new List<Item>();

      

        public void Move(int x, int y)
        {
            foreach (Item item in ItemList)
            {
                item.Move(x, y);

            }
        }
    }
}
