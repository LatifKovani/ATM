namespace atm
{
    partial class kerko
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
            messageTextBox = new TextBox();
            recipientIbanTextBox = new TextBox();
            amountTextBox = new TextBox();
            requestButton = new Button();
            returnButton = new Button();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(512, 121);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messageTextBox.Size = new Size(239, 200);
            messageTextBox.TabIndex = 0;
            // 
            // recipientIbanTextBox
            // 
            recipientIbanTextBox.Location = new Point(143, 121);
            recipientIbanTextBox.Multiline = true;
            recipientIbanTextBox.Name = "recipientIbanTextBox";
            recipientIbanTextBox.PlaceholderText = "IBAN i marrësit";
            recipientIbanTextBox.Size = new Size(249, 43);
            recipientIbanTextBox.TabIndex = 1;
            recipientIbanTextBox.TextChanged += recipientIbanTextBox_TextChanged;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(143, 278);
            amountTextBox.Multiline = true;
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PlaceholderText = "Shuma e kërkuar";
            amountTextBox.Size = new Size(249, 43);
            amountTextBox.TabIndex = 2;
            // 
            // requestButton
            // 
            requestButton.Location = new Point(612, 357);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(139, 46);
            requestButton.TabIndex = 3;
            requestButton.Text = "Kërko";
            requestButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(143, 357);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(139, 46);
            returnButton.TabIndex = 4;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = true;
            // 
            // kerko
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnButton);
            Controls.Add(requestButton);
            Controls.Add(amountTextBox);
            Controls.Add(recipientIbanTextBox);
            Controls.Add(messageTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kerko";
            Text = "Kërko Para";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageTextBox;
        private TextBox recipientIbanTextBox;
        private TextBox amountTextBox;
        private Button requestButton;
        private Button returnButton;
    }
}