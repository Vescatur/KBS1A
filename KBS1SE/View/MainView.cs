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
    public partial class MainView : Form
    {
        Character character;
        Controller controller;
        public MainView()
        {
            
           InitializeComponent();
           this.KeyPreview = true;
           character = new Character();
            controller = new Controller(character);
           userControl11.MyCharacter = character;
        }

        
        
        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.Move(100, 100);
            Debug.WriteLine("current speed = " + character.Speed);
            Debug.WriteLine("current position = " + character.Position);
        }
    }
}
