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
using KBS1SE.Item;

namespace KBS1SE.View
{
        public partial class HeadView : Form
        {
            Field field;
            Character character;
            Goal goal;
            Start start;
            Auto auto;
            public HeadView()
            {

                InitializeComponent();
                this.KeyPreview = true;
                goal = new Goal(this.fieldView1.ClientSize.Width, this.fieldView1.ClientSize.Height);
                start = new Start();
                character = new Character();
                auto = new Auto(this.fieldView1.ClientSize.Width, this.fieldView1.ClientSize.Height, character);
                field = new Field();
                fieldView1.KoppelModelEnMaakObserver(field);
                userControl11.MyCharacter = character;

            }
            private void MainTimer_Tick(object sender, EventArgs e)
            {
                field.Move(this.fieldView1.ClientSize.Width, this.fieldView1.ClientSize.Height);
            }
        }
    }