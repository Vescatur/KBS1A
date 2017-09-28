using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace KBS1SE
{
    public class Field
    {
       private List<Item.Item> items = new List<Item.Item>();

        public List<Item.Item> Items
        {
            get => items;
        }

        public void AddItemToItems(Item.Item item)
        {
            items.Add(item);
        }
    }
}
