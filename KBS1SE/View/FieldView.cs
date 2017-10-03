using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using KBS1SE.Item;

namespace KBS1SE.View
{
    public partial class FieldView : UserControl
    {
        public FieldView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private Field myField;

        public Field MyField
        {
            get { return myField; }
            set { myField = value; }
        }

        public void KoppelModelEnMaakObserver(Field field)
        {
            myField = field;
            MyField.ItemAction += UpdatePanel;
        }

        public void UpdatePanel(object sender)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(this.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            if (Field.ItemList != null)
            {
                SolidBrush brush;
                foreach (Item.Item item in Field.ItemList)
                {
                    brush = new SolidBrush(item.Color);
                    e.Graphics.FillRectangle(brush, Convert.ToInt32(item.Position.X), Convert.ToInt32(item.Position.Y), Convert.ToInt32(item.Size.X), Convert.ToInt32(item.Size.Y));
                    e.Graphics.DrawRectangle(Pens.Black, Convert.ToInt32(item.Position.X), Convert.ToInt32(item.Position.Y), Convert.ToInt32(item.Size.X), Convert.ToInt32(item.Size.Y));
                }
            }
        }
    }
}