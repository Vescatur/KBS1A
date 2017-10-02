namespace KBS1SE.View
{
    partial class HeadView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            KBS1SE.Character character2 = new KBS1SE.Character();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadView));
            this.userControl11 = new KBS1SE.UserControl1();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.fieldView1 = new KBS1SE.View.FieldView();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 360);
            character2.Color = System.Drawing.Color.Green;
            character2.Position = ((System.Windows.Vector)(resources.GetObject("character2.Position")));
            character2.Size = ((System.Windows.Vector)(resources.GetObject("character2.Size")));
            character2.Speed = ((System.Windows.Vector)(resources.GetObject("character2.Speed")));
            this.userControl11.MyCharacter = character2;
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(695, 120);
            this.userControl11.TabIndex = 0;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 33;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // fieldView1
            // 
            this.fieldView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldView1.Location = new System.Drawing.Point(0, 0);
            this.fieldView1.Name = "fieldView1";
            this.fieldView1.Size = new System.Drawing.Size(695, 329);
            this.fieldView1.TabIndex = 1;
            // 
            // HeadView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 480);
            this.Controls.Add(this.fieldView1);
            this.Controls.Add(this.userControl11);
            this.Name = "HeadView";
            this.Text = "HeadView";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Timer MainTimer;
        private FieldView fieldView1;
    }
}