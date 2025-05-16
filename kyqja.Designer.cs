<<<<<<< HEAD
﻿using System.Windows.Forms;

namespace atm
=======
﻿namespace atm
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
{
    partial class kyqja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kyqja));
            Kyqu = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
<<<<<<< HEAD
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
=======
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            SuspendLayout();
            // 
            // Kyqu
            // 
<<<<<<< HEAD
            Kyqu.Anchor = AnchorStyles.None;
            Kyqu.BackColor = Color.FromArgb(180, 190, 201);
            Kyqu.FlatAppearance.BorderSize = 0;
            Kyqu.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            Kyqu.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            Kyqu.FlatStyle = FlatStyle.Flat;
            Kyqu.Font = new Font("Microsoft Sans Serif", 14F);
            Kyqu.Location = new Point(723, 335);
            Kyqu.Margin = new Padding(3, 2, 3, 2);
            Kyqu.Name = "Kyqu";
            Kyqu.Size = new Size(275, 46);
=======
            Kyqu.Font = new Font("Segoe UI", 14F);
            Kyqu.Location = new Point(44, 230);
            Kyqu.Margin = new Padding(3, 2, 3, 2);
            Kyqu.Name = "Kyqu";
            Kyqu.Size = new Size(146, 37);
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            Kyqu.TabIndex = 0;
            Kyqu.Text = "Kyçu";
            Kyqu.UseVisualStyleBackColor = true;
            Kyqu.Click += Kyqu_Click;
            // 
            // textBox1
            // 
<<<<<<< HEAD
            textBox1.Font = new Font("Microsoft Sans Serif", 19F);
            textBox1.Location = new Point(723, 148);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "IBAN";
            textBox1.Size = new Size(275, 36);
=======
            textBox1.Location = new Point(44, 69);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "IBAN";
            textBox1.Size = new Size(247, 36);
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
<<<<<<< HEAD
            textBox2.Font = new Font("Microsoft Sans Serif", 19F);
            textBox2.Location = new Point(723, 261);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "PIN";
            textBox2.Size = new Size(275, 36);
            textBox2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 0);
            linkLabel1.Location = new Point(916, 457);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 24);
=======
            textBox2.Location = new Point(44, 153);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "PIN";
            textBox2.Size = new Size(247, 36);
            textBox2.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(191, 246);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 21);
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Regjistrohu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
<<<<<<< HEAD
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Kyqu);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(688, 457);
            label2.Name = "label2";
            label2.Size = new Size(231, 24);
            label2.TabIndex = 5;
            label2.Text = "Krijoni nje llogari të re ? ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fira Code Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 41, 41);
            label1.Location = new Point(643, 418);
            label1.Name = "label1";
            label1.Size = new Size(439, 24);
            label1.TabIndex = 4;
            label1.Text = "------------   OSE   ------------";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(688, 266);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(37, 30);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(688, 154);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(37, 30);
            panel2.TabIndex = 1;
=======
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Kyqu);
            panel1.Location = new Point(374, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 337);
            panel1.TabIndex = 4;
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
<<<<<<< HEAD
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 89);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(616, 397);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
=======
            pictureBox2.Location = new Point(11, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(9, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 34);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            // kyqja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "kyqja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kyqja";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
=======
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "kyqja";
            Text = "kyqja";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            ResumeLayout(false);
        }

        #endregion

        private Button Kyqu;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
<<<<<<< HEAD
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
=======
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
    }
}