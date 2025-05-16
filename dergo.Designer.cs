namespace atm
{
    partial class dergo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dergo));
            send = new Button();
            kthehu = new Button();
            messagebox = new TextBox();
            marresiIBAN = new TextBox();
            shuma = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblTitle = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // send
            // 
            send.Anchor = AnchorStyles.None;
            send.BackColor = Color.FromArgb(180, 190, 201);
            send.FlatAppearance.BorderSize = 0;
            send.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            send.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            send.FlatStyle = FlatStyle.Flat;
            send.Font = new Font("SF Pro Regular", 14F);
            send.Location = new Point(289, 478);
            send.Name = "send";
            send.Size = new Size(150, 40);
            send.TabIndex = 0;
            send.Text = "Dërgo";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // kthehu
            // 
            kthehu.Anchor = AnchorStyles.None;
            kthehu.BackColor = Color.FromArgb(180, 190, 201);
            kthehu.FlatAppearance.BorderSize = 0;
            kthehu.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            kthehu.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            kthehu.FlatStyle = FlatStyle.Flat;
            kthehu.Font = new Font("SF Pro Regular", 14F);
            kthehu.Location = new Point(86, 478);
            kthehu.Name = "kthehu";
            kthehu.Size = new Size(150, 40);
            kthehu.TabIndex = 1;
            kthehu.Text = "Kthehu";
            kthehu.UseVisualStyleBackColor = true;
            kthehu.Click += kthehu_Click;
            // 
            // messagebox
            // 
            messagebox.Font = new Font("SF Pro Regular", 10F);
            messagebox.Location = new Point(86, 266);
            messagebox.Multiline = true;
            messagebox.Name = "messagebox";
            messagebox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messagebox.Size = new Size(353, 141);
            messagebox.TabIndex = 2;
            // 
            // marresiIBAN
            // 
            marresiIBAN.Font = new Font("SF Pro Regular", 13F);
            marresiIBAN.Location = new Point(86, 119);
            marresiIBAN.Name = "marresiIBAN";
            marresiIBAN.PlaceholderText = "IBAN i marrësit";
            marresiIBAN.Size = new Size(353, 31);
            marresiIBAN.TabIndex = 3;
            // 
            // shuma
            // 
            shuma.Font = new Font("SF Pro Regular", 13F);
            shuma.Location = new Point(86, 187);
            shuma.Name = "shuma";
            shuma.PlaceholderText = "Shuma e kërkuar";
            shuma.Size = new Size(353, 31);
            shuma.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(505, 81);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 371);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(shuma);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(messagebox);
            panel2.Controls.Add(marresiIBAN);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(send);
            panel2.Controls.Add(kthehu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 576);
            panel2.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("SF Pro Regular", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(86, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(129, 30);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Dërgo Para";
            // 
            // dergo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel2);
            Name = "dergo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dergo";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button send;
        private Button kthehu;
        private TextBox messagebox;
        private TextBox marresiIBAN;
        private TextBox shuma;
        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
    }
}