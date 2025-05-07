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
            labelWelcome.Location = new Point(30, 30);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 20);
            labelWelcome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(145, 229);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(384, 229);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(570, 229);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(145, 277);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 8;
            // 
            // qkyqu
            // 
            qkyqu.Font = new Font("Segoe UI", 12F);
            qkyqu.Location = new Point(390, 390);
            qkyqu.Name = "qkyqu";
            qkyqu.Size = new Size(171, 62);
            qkyqu.TabIndex = 9;
            qkyqu.Text = "Çkyçu";
            qkyqu.UseVisualStyleBackColor = true;
            qkyqu.Click += qkyqu_Click;
            // 
            // terheqja
            // 
            terheqja.Font = new Font("Segoe UI", 12F);
            terheqja.Location = new Point(561, 164);
            terheqja.Name = "terheqja";
            terheqja.Size = new Size(193, 62);
            terheqja.TabIndex = 10;
            terheqja.Text = "Tërheqje e mjeteve";
            terheqja.UseVisualStyleBackColor = true;
            // 
            // bilanci
            // 
            bilanci.Font = new Font("Segoe UI", 12F);
            bilanci.Location = new Point(191, 164);
            bilanci.Name = "bilanci";
            bilanci.Size = new Size(193, 62);
            bilanci.TabIndex = 11;
            bilanci.Text = "Shiko bilancin";
            bilanci.UseVisualStyleBackColor = true;
            // 
            // transfer
            // 
            transfer.Font = new Font("Segoe UI", 12F);
            transfer.Location = new Point(561, 287);
            transfer.Name = "transfer";
            transfer.Size = new Size(193, 62);
            transfer.TabIndex = 12;
            transfer.Text = "Transfer i mjeteve";
            transfer.UseVisualStyleBackColor = true;
            // 
            // deponim
            // 
            deponim.Font = new Font("Segoe UI", 12F);
            deponim.Location = new Point(191, 287);
            deponim.Name = "deponim";
            deponim.Size = new Size(193, 62);
            deponim.TabIndex = 13;
            deponim.Text = "Deponim i mjeteve";
            deponim.UseVisualStyleBackColor = true;
            deponim.Click += deponim_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 543);
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