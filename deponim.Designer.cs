namespace atm
{
    partial class deponim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deponim));
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(180, 190, 201);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("SF Pro Regular", 14F);
            button2.Location = new Point(696, 435);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(221, 51);
            button2.TabIndex = 3;
            button2.Text = "Vazhdo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(180, 190, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SF Pro Regular", 14F);
            button1.Location = new Point(236, 435);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(221, 51);
            button1.TabIndex = 2;
            button1.Text = "Kthehu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SF Pro Regular", 19F);
            textBox1.Location = new Point(334, 288);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Shuma";
            textBox1.Size = new Size(448, 41);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 576);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1111, 280);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // deponim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "deponim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}