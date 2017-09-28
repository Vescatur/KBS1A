namespace KBS1SE.control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpButton = new System.Windows.Forms.Button();
            this.UpLeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.UpRightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.DownRightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.DownLeftButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UpButton);
            this.panel1.Controls.Add(this.UpLeftButton);
            this.panel1.Controls.Add(this.RightButton);
            this.panel1.Controls.Add(this.UpRightButton);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Controls.Add(this.DownRightButton);
            this.panel1.Controls.Add(this.DownButton);
            this.panel1.Controls.Add(this.DownLeftButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 216);
            this.panel1.TabIndex = 1;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(74, 4);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(65, 65);
            this.UpButton.TabIndex = 7;
            this.UpButton.Text = "up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // UpLeftButton
            // 
            this.UpLeftButton.Location = new System.Drawing.Point(3, 4);
            this.UpLeftButton.Name = "UpLeftButton";
            this.UpLeftButton.Size = new System.Drawing.Size(65, 65);
            this.UpLeftButton.TabIndex = 6;
            this.UpLeftButton.Text = "up left";
            this.UpLeftButton.UseVisualStyleBackColor = true;
            this.UpLeftButton.Click += new System.EventHandler(this.UpLeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(145, 75);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(65, 65);
            this.RightButton.TabIndex = 5;
            this.RightButton.Text = "right";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // UpRightButton
            // 
            this.UpRightButton.Location = new System.Drawing.Point(145, 4);
            this.UpRightButton.Name = "UpRightButton";
            this.UpRightButton.Size = new System.Drawing.Size(65, 65);
            this.UpRightButton.TabIndex = 4;
            this.UpRightButton.Text = "up right";
            this.UpRightButton.UseVisualStyleBackColor = true;
            this.UpRightButton.Click += new System.EventHandler(this.UpRightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(3, 75);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(65, 65);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click_1);
            // 
            // DownRightButton
            // 
            this.DownRightButton.Location = new System.Drawing.Point(145, 144);
            this.DownRightButton.Name = "DownRightButton";
            this.DownRightButton.Size = new System.Drawing.Size(65, 65);
            this.DownRightButton.TabIndex = 2;
            this.DownRightButton.Text = "down right";
            this.DownRightButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(74, 144);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(65, 65);
            this.DownButton.TabIndex = 1;
            this.DownButton.Text = "down";
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // DownLeftButton
            // 
            this.DownLeftButton.Location = new System.Drawing.Point(3, 144);
            this.DownLeftButton.Name = "DownLeftButton";
            this.DownLeftButton.Size = new System.Drawing.Size(65, 65);
            this.DownLeftButton.TabIndex = 0;
            this.DownLeftButton.Text = "down left";
            this.DownLeftButton.UseVisualStyleBackColor = true;
            this.DownLeftButton.Click += new System.EventHandler(this.DownLeftButton_Click_1);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(228, 226);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button UpLeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button UpRightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button DownRightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button DownLeftButton;
    }
}
