using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;
using KBS1SE.Item;

namespace KBS1SE
{
    public partial class UserControl1 : UserControl
    {

        bool up = false;
        bool left = false;
        bool right = false;
        bool down = false;
        public Character MyCharacter { get; set; }

        public UserControl1()
        {
            MyCharacter = new Character();
            InitializeComponent();
        }


        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            up = false;
            down = false;
            right = false;
            left = false;
        }

        private void DownRight_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
            right = true;

        }

        private void Down_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;

        }

        private void DownLeft_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
            left = true;

        }

        private void Left_MouseDown(object sender, MouseEventArgs e)
        {
            left = true;

        }

        private void UpLeft_MouseDown(object sender, MouseEventArgs e)
        {
            up = true;
            left = true;

        }

        private void Up_MouseDown(object sender, MouseEventArgs e)
        {
            up = true;
        }

        private void UpRight_MouseDown(object sender, MouseEventArgs e)
        {
            up = true;
            right = true;

        }

        private void Right_MouseDown(object sender, MouseEventArgs e)
        {
            right = true;

        }

        private void Key_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
        }

        private void Key_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (down && right)
            {
                MyCharacter.Speed = new Vector(5, 5);
            }
            else if (down && left)
            {
                MyCharacter.Speed = new Vector(-5, 5);
            }
            else if (down)
            {
                MyCharacter.Speed = new Vector(0, 5);
            }
            else if (up && right)
            {
                MyCharacter.Speed = new Vector(5, -5);
            }
            else if (up && left)
            {
                MyCharacter.Speed = new Vector(-5, -5);
            }
            else if (up)
            {
                MyCharacter.Speed = new Vector(0, -5);
            }
            else if (right)
            {
                MyCharacter.Speed = new Vector(5, 0);
            }
            else if (left)
            {
                MyCharacter.Speed = new Vector(-5, 0);
            }
            else
            {
                MyCharacter.Speed = new Vector(0, 0);
            }
        }
    }
}
