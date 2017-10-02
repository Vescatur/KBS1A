using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBS1SE.View
{
    public partial class HeadView : Form
    {
        Character character;
        Controller controller;
        public HeadView()
        {
            
            InitializeComponent();
            this.KeyPreview = true;
            character = new Character();
            fieldView1.KoppelSpelerEnMaakPanelObserver(character);
            userControl11.MyCharacter = character;
            controller = new Controller(character);
            
        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {
                controller.Move(this.fieldView1.ClientSize.Width, this.fieldView1.ClientSize.Height);
                
        }
    }
}
