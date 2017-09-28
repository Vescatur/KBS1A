﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace KBS1SE.Item
{
    public abstract class Item
    {

        // declare een delegate for the ItemAction event
        public delegate void ItemActionHander(object sender);

        // declare de ItemActoin event via de delegate
        public event ItemActionHander ItemAction;

        private Vector position;  //De x-as en Y-as positie van de Item. 
                        //Hoe hoger de waardes des te meer ze rechts beneden zijn
        
        public Vector Position
        {
            get { return position; }
            set { position = Vector.Add(position, value); }
        }

        
        private int size; // de size van de item

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        private Vector speed;

        public Vector Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public Item()
        {           
            
        }
        public abstract ETouchAction OnTouch(Item touchedItem);
    }
}
