namespace atm
{
    partial class menu
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
            labelWelcome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            qkyqu = new Button();
            terheqja = new Button();
            bilanci = new Button();
            transfer = new Button();
            deponim = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(26, 22);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 15);
            labelWelcome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(127, 172);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(336, 172);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(499, 172);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(127, 208);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 8;
            // 
            // qkyqu
            // 
            qkyqu.Font = new Font("Segoe UI", 12F);
            qkyqu.Location = new Point(341, 292);
            qkyqu.Margin = new Padding(3, 2, 3, 2);
            qkyqu.Name = "qkyqu";
            qkyqu.Size = new Size(150, 46);
            qkyqu.TabIndex = 9;
            qkyqu.Text = "Çkyçu";
            qkyqu.UseVisualStyleBackColor = true;
            qkyqu.Click += qkyqu_Click;
            // 
            // terheqja
            // 
            terheqja.Font = new Font("Segoe UI", 12F);
            terheqja.Location = new Point(491, 123);
            terheqja.Margin = new Padding(3, 2, 3, 2);
            terheqja.Name = "terheqja";
            terheqja.Size = new Size(169, 46);
            terheqja.TabIndex = 10;
            terheqja.Text = "Tërheqje e mjeteve";
            terheqja.UseVisualStyleBackColor = true;
            terheqja.Click += terheqja_Click;
            // 
            // bilanci
            // 
            bilanci.Font = new Font("Segoe UI", 12F);
            bilanci.Location = new Point(167, 123);
            bilanci.Margin = new Padding(3, 2, 3, 2);
            bilanci.Name = "bilanci";
            bilanci.Size = new Size(169, 46);
            bilanci.TabIndex = 11;
            bilanci.Text = "Shiko bilancin";
            bilanci.UseVisualStyleBackColor = true;
            bilanci.Click += bilanci_Click;
            // 
            // transfer
            // 
            transfer.Font = new Font("Segoe UI", 12F);
            transfer.Location = new Point(491, 215);
            transfer.Margin = new Padding(3, 2, 3, 2);
            transfer.Name = "transfer";
            transfer.Size = new Size(169, 46);
            transfer.TabIndex = 12;
            transfer.Text = "Transfer i mjeteve";
            transfer.UseVisualStyleBackColor = true;
            // 
            // deponim
            // 
            deponim.Font = new Font("Segoe UI", 12F);
            deponim.Location = new Point(167, 215);
            deponim.Margin = new Padding(3, 2, 3, 2);
            deponim.Name = "deponim";
            deponim.Size = new Size(169, 46);
            deponim.TabIndex = 13;
            deponim.Text = "Deponim i mjeteve";
            deponim.UseVisualStyleBackColor = true;
            deponim.Click += deponim_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 407);
            Controls.Add(deponim);
            Controls.Add(transfer);
            Controls.Add(bilanci);
            Controls.Add(terheqja);
            Controls.Add(qkyqu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "menu";
            Text = "Tërheqje e mjeteve";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button qkyqu;
        private Button terheqja;
        private Button bilanci;
        private Button transfer;
        private Button deponim;
    }
}