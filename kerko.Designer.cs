namespace atm
{
    partial class kerko
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kerko));
            panel2 = new Panel();
            lblTitle = new Label();
            panel1 = new Panel();
            recipientIbanTextBox = new TextBox();
            returnButton = new Button();
            amountTextBox = new TextBox();
            messageTextBox = new TextBox();
            requestButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(recipientIbanTextBox);
            panel2.Controls.Add(returnButton);
            panel2.Controls.Add(amountTextBox);
            panel2.Controls.Add(messageTextBox);
            panel2.Controls.Add(requestButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 576);
            panel2.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(76, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(131, 26);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Kërko Para";
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
            panel1.TabIndex = 6;
            // 
            // recipientIbanTextBox
            // 
            recipientIbanTextBox.Font = new Font("SF Pro Regular", 14F);
            recipientIbanTextBox.Location = new Point(76, 116);
            recipientIbanTextBox.Name = "recipientIbanTextBox";
            recipientIbanTextBox.PlaceholderText = "IBAN i marrësit";
            recipientIbanTextBox.Size = new Size(347, 29);
            recipientIbanTextBox.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.None;
            returnButton.BackColor = Color.FromArgb(180, 190, 201);
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            returnButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("SF Pro Regular", 14F);
            returnButton.ForeColor = Color.Black;
            returnButton.Location = new Point(76, 444);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(150, 40);
            returnButton.TabIndex = 4;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("SF Pro Regular", 14F);
            amountTextBox.Location = new Point(76, 191);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PlaceholderText = "Shuma e kërkuar";
            amountTextBox.Size = new Size(347, 29);
            amountTextBox.TabIndex = 1;
            // 
            // messageTextBox
            // 
            messageTextBox.Font = new Font("SF Pro Regular", 10F);
            messageTextBox.Location = new Point(76, 252);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messageTextBox.Size = new Size(347, 158);
            messageTextBox.TabIndex = 2;
            // 
            // requestButton
            // 
            requestButton.Anchor = AnchorStyles.None;
            requestButton.BackColor = Color.FromArgb(180, 190, 201);
            requestButton.FlatAppearance.BorderSize = 0;
            requestButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            requestButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("SF Pro Regular", 14F);
            requestButton.ForeColor = Color.Black;
            requestButton.Location = new Point(249, 444);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(174, 40);
            requestButton.TabIndex = 4;
            requestButton.Text = "Dërgo Kërkesën";
            requestButton.UseVisualStyleBackColor = false;
            // 
            // kerko
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel2);
            Name = "kerko";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kërko Para";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox messageTextBox;
        private TextBox recipientIbanTextBox;
        private TextBox amountTextBox;
        private Button requestButton;
        private Button returnButton;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel1;
    }
}