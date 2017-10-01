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

namespace KBS1SE.View
{
    public partial class FieldView : UserControl
    {
        public FieldView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private Character myCharacter;

        public Character MyCharacter
        {
            get { return myCharacter; }
            set { myCharacter = value; }
        }

        public void KoppelSpelerEnMaakPanelObserver(Character character)
        {
            myCharacter = character;
            //Speler.SpelerChanged += new Speler.SpelerChangedHandler(UpdatePanel);
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
                e.Graphics.FillRectangle(Brushes.Green, Convert.ToInt32(MyCharacter.Position.X), Convert.ToInt32(MyCharacter.Position.Y), Convert.ToInt32(myCharacter.Size.X), Convert.ToInt32(myCharacter.Size.Y));
                e.Graphics.DrawRectangle(Pens.Green, Convert.ToInt32(MyCharacter.Position.X), Convert.ToInt32(MyCharacter.Position.Y), Convert.ToInt32(myCharacter.Size.X), Convert.ToInt32(myCharacter.Size.Y));
            }
        }
    }
}