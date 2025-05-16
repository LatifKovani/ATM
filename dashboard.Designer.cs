namespace atm
{
    partial class dashboard
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            button1 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
=======
            button1 = new Button();
            button3 = new Button();
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            SuspendLayout();
            // 
            // button1
            // 
<<<<<<< HEAD
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(180, 190, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 19F);
            button1.Location = new Point(623, 408);
            button1.Name = "button1";
            button1.Size = new Size(261, 77);
            button1.TabIndex = 0;
            button1.Text = "Regjistrohu";
            button1.UseVisualStyleBackColor = false;
=======
            button1.Location = new Point(460, 292);
            button1.Name = "button1";
            button1.Size = new Size(198, 63);
            button1.TabIndex = 0;
            button1.Text = "Regjistrohu";
            button1.UseVisualStyleBackColor = true;
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            button1.Click += button1_Click;
            // 
            // button3
            // 
<<<<<<< HEAD
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(180, 190, 201);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 19F);
            button3.Location = new Point(250, 408);
            button3.Name = "button3";
            button3.Size = new Size(261, 77);
=======
            button3.Location = new Point(155, 292);
            button3.Name = "button3";
            button3.Size = new Size(198, 63);
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            button3.TabIndex = 2;
            button3.Text = "Kyçu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
<<<<<<< HEAD
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1111, 405);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 5;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 24F);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
=======
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            Text = "dashboard";
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
<<<<<<< HEAD
        private PictureBox pictureBox2;
        private Panel panel1;
=======
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
    }
}