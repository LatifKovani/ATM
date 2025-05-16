namespace atm
{
    partial class regjistrimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regjistrimi));
            Emri = new TextBox();
            RegjistrohuR = new Button();
            pinR = new TextBox();
            ibanR = new TextBox();
            CVC = new TextBox();
            Mbiemri = new TextBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Emri
            // 
            Emri.Font = new Font("Microsoft Sans Serif", 17F);
            Emri.Location = new Point(174, 151);
            Emri.Margin = new Padding(3, 2, 3, 2);
            Emri.Name = "Emri";
            Emri.PlaceholderText = "Emri";
            Emri.Size = new Size(291, 33);
            Emri.TabIndex = 0;
            // 
            // RegjistrohuR
            // 
            RegjistrohuR.BackColor = Color.FromArgb(180, 190, 201);
            RegjistrohuR.FlatAppearance.BorderSize = 0;
            RegjistrohuR.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            RegjistrohuR.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            RegjistrohuR.FlatStyle = FlatStyle.Flat;
            RegjistrohuR.Font = new Font("Microsoft Sans Serif", 14F);
            RegjistrohuR.Location = new Point(615, 363);
            RegjistrohuR.Margin = new Padding(3, 2, 3, 2);
            RegjistrohuR.Name = "RegjistrohuR";
            RegjistrohuR.Size = new Size(292, 50);
            RegjistrohuR.TabIndex = 4;
            RegjistrohuR.Text = "Regjistrohu";
            RegjistrohuR.UseVisualStyleBackColor = true;
            RegjistrohuR.Click += RegjistrohuR_Click;
            // 
            // pinR
            // 
            pinR.Font = new Font("Microsoft Sans Serif", 17F);
            pinR.Location = new Point(615, 266);
            pinR.Margin = new Padding(3, 2, 3, 2);
            pinR.Name = "pinR";
            pinR.PlaceholderText = "PIN";
            pinR.Size = new Size(292, 33);
            pinR.TabIndex = 10;
            // 
            // ibanR
            // 
            ibanR.Font = new Font("Microsoft Sans Serif", 17F);
            ibanR.Location = new Point(175, 266);
            ibanR.Margin = new Padding(3, 2, 3, 2);
            ibanR.Name = "ibanR";
            ibanR.PlaceholderText = "IBAN";
            ibanR.Size = new Size(291, 33);
            ibanR.TabIndex = 11;
            // 
            // CVC
            // 
            CVC.Font = new Font("Microsoft Sans Serif", 17F);
            CVC.Location = new Point(175, 363);
            CVC.Margin = new Padding(3, 2, 3, 2);
            CVC.Name = "CVC";
            CVC.PlaceholderText = "CVC";
            CVC.Size = new Size(291, 33);
            CVC.TabIndex = 12;
            // 
            // Mbiemri
            // 
            Mbiemri.Font = new Font("Microsoft Sans Serif", 17F);
            Mbiemri.Location = new Point(615, 151);
            Mbiemri.Margin = new Padding(3, 2, 3, 2);
            Mbiemri.Name = "Mbiemri";
            Mbiemri.PlaceholderText = "Mbiemri";
            Mbiemri.Size = new Size(292, 33);
            Mbiemri.TabIndex = 13;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.WindowText;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(838, 434);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 24);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kyçu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ibanR);
            panel1.Controls.Add(CVC);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(Mbiemri);
            panel1.Controls.Add(RegjistrohuR);
            panel1.Controls.Add(pinR);
            panel1.Controls.Add(Emri);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 26, 26);
            label1.Location = new Point(615, 434);
            label1.Name = "label1";
            label1.Size = new Size(224, 24);
            label1.TabIndex = 17;
            label1.Text = "Keni krijuar nje llogari ?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(905, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 118);
            panel2.TabIndex = 16;
            // 
            // regjistrimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "regjistrimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Emri;
        private Button RegjistrohuR;
        private TextBox pinR;
        private TextBox ibanR;
        private TextBox CVC;
        private TextBox Mbiemri;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}