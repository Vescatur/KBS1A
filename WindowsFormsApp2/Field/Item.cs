using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBS1SE.model
{
    public class Item
    {

        // declare een delegate for the ItemAction event
        public delegate void ItemActionHander(object sender);

        // declare de ItemActoin event via de delegate
        public event ItemActionHander ItemAction;

        private int x;  //De x-as positie van de Item. 
                        //Hoe hoger het getal hoe meer naar rechts het is
        
        public int X
        {
            get { return x; }
            set { x = value; if (ItemAction != null) ItemAction(this); }
        }

        private int dx; //snelheid waarmee de item beweegt in de x-as

        public int Dx
        {
            get { return dx; }
            set { dx = value; if (ItemAction != null) ItemAction(this); }
        }

        private int y;  //De y as positie van de Item. 
                        //Hoe hoger het getal hoe lager het is

        public int Y
        {
            get { return y; }
            set { y = value; if (ItemAction != null) ItemAction(this); }
        }

        private int dy; //snelheid waarmee de item beweegt in de y-as
        public int Dy
        {
            get { return dy; }
            set { dy = value; if (ItemAction != null) ItemAction(this); }
        }

        private int width;  // breedte van de item

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int heigth;

        public int Heigth   // hoogte van de item
        {
            get { return heigth; }
            set { heigth = value; }
        }

        public Item(int a, int b, int c, int d)
        {           
            Width = a*10;
            Heigth = b*10;
            X = c;
            Y = d;
        }

    }
}
