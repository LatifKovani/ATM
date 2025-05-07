namespace atm
{
    partial class terheqje
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
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 218);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 43);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(74, 3);
            button1.Name = "button1";
            button1.Size = new Size(164, 61);
            button1.TabIndex = 1;
            button1.Text = "Kthehu";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-2, 427);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 67);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(363, 3);
            button2.Name = "button2";
            button2.Size = new Size(164, 61);
            button2.TabIndex = 2;
            button2.Text = "Anulo";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(630, 3);
            button3.Name = "button3";
            button3.Size = new Size(164, 61);
            button3.TabIndex = 3;
            button3.Text = "Vazhdo";
            button3.UseVisualStyleBackColor = true;
            // 
            // terheqje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 493);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "terheqje";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button2;
    }
}