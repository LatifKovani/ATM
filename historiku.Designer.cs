using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace atm
{
    partial class historiku
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiku));
            transactionsDataGridView = new DataGridView();
            returnButton = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.AllowUserToAddRows = false;
            transactionsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Pro Regular", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            transactionsDataGridView.BackgroundColor = Color.FromArgb(217, 217, 217);
            transactionsDataGridView.BorderStyle = BorderStyle.None;
            transactionsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            transactionsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 7, 20);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SF Pro Regular", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 7, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            transactionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            transactionsDataGridView.ColumnHeadersHeight = 40;
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SF Pro Regular", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            transactionsDataGridView.EnableHeadersVisualStyles = false;
            transactionsDataGridView.GridColor = Color.FromArgb(230, 230, 230);
            transactionsDataGridView.Location = new Point(20, 80);
            transactionsDataGridView.Name = "transactionsDataGridView";
            transactionsDataGridView.ReadOnly = true;
            transactionsDataGridView.RowHeadersVisible = false;
            transactionsDataGridView.RowHeadersWidth = 51;
            transactionsDataGridView.RowTemplate.Height = 35;
            transactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionsDataGridView.Size = new Size(1072, 427);
            transactionsDataGridView.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.None;
            returnButton.BackColor = Color.FromArgb(180, 190, 201);
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            returnButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new System.Drawing.Font("SF Pro Regular", 14F);
            returnButton.ForeColor = Color.Black;
            returnButton.Location = new Point(928, 524);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(164, 40);
            returnButton.TabIndex = 1;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += ReturnButton_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("SF Pro Regular", 14F);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(232, 40);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Historia e Transaksioneve";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(transactionsDataGridView);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(returnButton);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 576);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(950, -1);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // historiku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 247);
            ClientSize = new Size(1111, 576);
            Controls.Add(panel1);
            Name = "historiku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historia e Transaksioneve";
            Load += TransactionHistory_Load;
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private DataGridView transactionsDataGridView;
        private Button returnButton;
        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}