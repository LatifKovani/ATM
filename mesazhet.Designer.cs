namespace atm
{
    public partial class mesazhet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mesazhet));
            requestsDataGridView = new DataGridView();
            colVeprim = new DataGridViewButtonColumn();
            panel1 = new Panel();
            label1 = new Label();
            btnReturn = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // requestsDataGridView
            // 
            requestsDataGridView.AllowUserToAddRows = false;
            requestsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle1.Font = new Font("SF Pro Regular", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            requestsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            requestsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            requestsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestsDataGridView.BackgroundColor = Color.FromArgb(217, 217, 217);
            requestsDataGridView.BorderStyle = BorderStyle.None;
            requestsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            requestsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(200, 30, 30);
            dataGridViewCellStyle2.Font = new Font("SF Pro Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(180, 20, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            requestsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            requestsDataGridView.ColumnHeadersHeight = 40;
            requestsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            requestsDataGridView.Columns.AddRange(new DataGridViewColumn[] { colVeprim });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle3.Font = new Font("SF Pro Regular", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            requestsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            requestsDataGridView.EnableHeadersVisualStyles = false;
            requestsDataGridView.GridColor = Color.FromArgb(230, 230, 230);
            requestsDataGridView.Location = new Point(18, 53);
            requestsDataGridView.Name = "requestsDataGridView";
            requestsDataGridView.ReadOnly = true;
            requestsDataGridView.RowHeadersVisible = false;
            requestsDataGridView.RowHeadersWidth = 51;
            requestsDataGridView.RowTemplate.Height = 35;
            requestsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            requestsDataGridView.Size = new Size(1076, 456);
            requestsDataGridView.TabIndex = 0;
            // 
            // colVeprim
            // 
            colVeprim.HeaderText = "Veprim";
            colVeprim.MinimumWidth = 6;
            colVeprim.Name = "colVeprim";
            colVeprim.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(requestsDataGridView);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(btnRefresh);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Regular", 19F);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 36);
            label1.TabIndex = 4;
            label1.Text = "Mesazhet";
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.None;
            btnReturn.BackColor = Color.FromArgb(180, 190, 201);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("SF Pro Regular", 14F);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Location = new Point(18, 526);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(164, 40);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Kthehu";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.None;
            btnRefresh.BackColor = Color.FromArgb(180, 190, 201);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("SF Pro Regular", 14F);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(930, 526);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(164, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Rifresko";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // mesazhet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel1);
            Font = new Font("SF Pro Regular", 9F);
            MinimumSize = new Size(702, 385);
            Name = "mesazhet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesazhet";
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView requestsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShuma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesazhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusi;
        private System.Windows.Forms.DataGridViewButtonColumn colVeprim;
        private Panel panel1;
        private Button btnReturn;
        private Button btnRefresh;
        private Label label1;
    }
}