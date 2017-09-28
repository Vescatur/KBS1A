using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace KBS1SE.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            Field field = new Field();
            field.AddItemToItems(new Item.Item(new Vector(1,3), new Vector(1, 3), new Vector(1, 3)));
            fieldView1.KoppelFieldToView(field);
        }
    }
}
