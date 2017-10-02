using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Windows.Forms;
using KBS1SE.Item;

namespace KBS1SE.View
{
    public partial class FieldView : UserControl
    {
        private Field field;
        private Character myCharacter;
        public Character MyCharacter
        {
            get { return myCharacter; }
            set { myCharacter = value; }
        }

        public FieldView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public void KoppelFieldToView(Field field)
        {
            this.field = field;
        }

//        protected override void OnPaint(PaintEventArgs e)
//        {
//            double X = this.Width;
//            double Y = this.Height;
//            if (field != null)
//            {
//                List<Item.Item> fieldItems = field.Items;
//                base.OnPaint(e);
//                e.Graphics.Clear(this.BackColor);
//                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
//                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
//                SolidBrush myBrush = new SolidBrush(Color.Red);
//                for (int i = 0; i < fieldItems.Count; i++)
//                {
//                    Item.Item item = fieldItems[i];
//                    Vector PixelPostion = GetPixelFromVector(item.Position, X, Y);
//                    Vector PixelSize = GetPixelFromVector(item.Size, X, Y);
//                    e.Graphics.FillRectangle(myBrush,
//                        new Rectangle((int) PixelPostion.X, (int) PixelPostion.Y, (int) PixelSize.X,
//                            (int) PixelSize.Y));
//                }
//            }
//        }

        public void KoppelSpelerEnMaakPanelObserver(Character character)
        {
            myCharacter = character;
            MyCharacter.ItemAction += UpdatePanel;
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
            if (myCharacter != null)
            {
                e.Graphics.FillRectangle(Brushes.Green, Convert.ToInt32(MyCharacter.Position.X),
                    Convert.ToInt32(MyCharacter.Position.Y), Convert.ToInt32(myCharacter.Size.X),
                    Convert.ToInt32(myCharacter.Size.Y));
                e.Graphics.DrawRectangle(Pens.Green, Convert.ToInt32(MyCharacter.Position.X),
                    Convert.ToInt32(MyCharacter.Position.Y), Convert.ToInt32(myCharacter.Size.X),
                    Convert.ToInt32(myCharacter.Size.Y));
            }
        }

        private Vector GetPixelFromVector(Vector Vector, double X, double Y)
        {
            return new Vector(Vector.X / 100 * X, Vector.Y / 100 * Y);
        }
    }
}