namespace KBS1SE
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DownRight = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.DownLeft = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.UpRight = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.UpLeft = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownRight
            // 
            this.DownRight.Location = new System.Drawing.Point(188, 76);
            this.DownRight.Name = "DownRight";
            this.DownRight.Size = new System.Drawing.Size(75, 23);
            this.DownRight.TabIndex = 0;
            this.DownRight.Text = "down right";
            this.DownRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DownRight.UseVisualStyleBackColor = true;
            this.DownRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.DownRight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.DownRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownRight_MouseDown);
            this.DownRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(107, 76);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(75, 23);
            this.Down.TabIndex = 1;
            this.Down.Text = "down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.Down.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down_MouseDown);
            this.Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // DownLeft
            // 
            this.DownLeft.Location = new System.Drawing.Point(26, 76);
            this.DownLeft.Name = "DownLeft";
            this.DownLeft.Size = new System.Drawing.Size(75, 23);
            this.DownLeft.TabIndex = 2;
            this.DownLeft.Text = "down left";
            this.DownLeft.UseVisualStyleBackColor = true;
            this.DownLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.DownLeft.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.DownLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownLeft_MouseDown);
            this.DownLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(188, 47);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(75, 23);
            this.Right.TabIndex = 3;
            this.Right.Text = "right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.Right.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Right_MouseDown);
            this.Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(26, 47);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(75, 23);
            this.Left.TabIndex = 4;
            this.Left.Text = "left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.Left.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_MouseDown);
            this.Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // UpRight
            // 
            this.UpRight.Location = new System.Drawing.Point(188, 18);
            this.UpRight.Name = "UpRight";
            this.UpRight.Size = new System.Drawing.Size(75, 23);
            this.UpRight.TabIndex = 5;
            this.UpRight.Text = "up right";
            this.UpRight.UseVisualStyleBackColor = true;
            this.UpRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.UpRight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.UpRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpRight_MouseDown);
            this.UpRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(107, 18);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 23);
            this.Up.TabIndex = 6;
            this.Up.Text = "up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.Up.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Up_MouseDown);
            this.Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // UpLeft
            // 
            this.UpLeft.Location = new System.Drawing.Point(26, 18);
            this.UpLeft.Name = "UpLeft";
            this.UpLeft.Size = new System.Drawing.Size(75, 23);
            this.UpLeft.TabIndex = 7;
            this.UpLeft.Text = "up left";
            this.UpLeft.UseVisualStyleBackColor = true;
            this.UpLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.UpLeft.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            this.UpLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpLeft_MouseDown);
            this.UpLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpLeft);
            this.panel1.Controls.Add(this.Up);
            this.panel1.Controls.Add(this.UpRight);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.DownLeft);
            this.panel1.Controls.Add(this.Down);
            this.panel1.Controls.Add(this.DownRight);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 112);
            this.panel1.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 33;
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(287, 120);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DownRight;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button DownLeft;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button UpRight;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button UpLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
    }
}
