namespace atm
{
<<<<<<< HEAD
    public partial class mesazhet
=======
    partial class mesazhet
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
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
<<<<<<< HEAD
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
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesazhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVeprim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            // requestsDataGridView
            this.requestsDataGridView.AllowUserToAddRows = false;
            this.requestsDataGridView.AllowUserToDeleteRows = false;
            this.requestsDataGridView.AutoGenerateColumns = false;
            this.requestsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.requestsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.requestsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 70, 130);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(0, 70, 130);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.requestsDataGridView.ColumnHeadersHeight = 40;
            this.requestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.requestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNga,
            this.colShuma,
            this.colMesazhi,
            this.colData,
            this.colStatusi,
            this.colVeprim});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requestsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requestsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.requestsDataGridView.EnableHeadersVisualStyles = false;
            this.requestsDataGridView.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.requestsDataGridView.Location = new System.Drawing.Point(20, 80);
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.ReadOnly = true;
            this.requestsDataGridView.RowHeadersVisible = false;
            this.requestsDataGridView.RowTemplate.Height = 35;
            this.requestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestsDataGridView.Size = new System.Drawing.Size(865, 350);
            this.requestsDataGridView.TabIndex = 0;

            // colId
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;

            // colNga
            this.colNga.DataPropertyName = "Nga";
            this.colNga.HeaderText = "Nga";
            this.colNga.Name = "colNga";
            this.colNga.ReadOnly = true;
            this.colNga.Width = 120;

            // colShuma
            this.colShuma.DataPropertyName = "Shuma";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "N2";
            this.colShuma.DefaultCellStyle = dataGridViewCellStyle4;
            this.colShuma.HeaderText = "Shuma";
            this.colShuma.Name = "colShuma";
            this.colShuma.ReadOnly = true;
            this.colShuma.Width = 100;

            // colMesazhi
            this.colMesazhi.DataPropertyName = "Mesazhi";
            this.colMesazhi.HeaderText = "Mesazhi";
            this.colMesazhi.Name = "colMesazhi";
            this.colMesazhi.ReadOnly = true;
            this.colMesazhi.Width = 200;

            // colData
            this.colData.DataPropertyName = "Data";
            dataGridViewCellStyle5.Format = "g";
            this.colData.DefaultCellStyle = dataGridViewCellStyle5;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 120;

            // colStatusi
            this.colStatusi.DataPropertyName = "Statusi";
            this.colStatusi.HeaderText = "Statusi";
            this.colStatusi.Name = "colStatusi";
            this.colStatusi.ReadOnly = true;
            this.colStatusi.Width = 100;

            // colVeprim
            this.colVeprim.HeaderText = "Veprim";
            this.colVeprim.Name = "colVeprim";
            this.colVeprim.ReadOnly = true;
            this.colVeprim.Width = 160;
            // Note: The buttons will be added programmatically in the code-behind file

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 70, 130);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 4;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Mesazhet";

            // panelFooter
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelFooter.Controls.Add(this.btnRefresh);
            this.panelFooter.Controls.Add(this.btnReturn);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 430);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 60);
            this.panelFooter.TabIndex = 5;

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(650, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Rifresko";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // btnReturn
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(50, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 35);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Kthehu";
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.UseVisualStyleBackColor = false;

            // mesazhet
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 490);
            this.Controls.Add(this.requestsDataGridView);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mesazhet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesazhet";
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
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
<<<<<<< HEAD
        private Panel panel1;
        private Button btnReturn;
        private Button btnRefresh;
        private Label label1;
=======
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReturn;
>>>>>>> a092db196e4a5a0106bf5b9b99cae4e4311421b7
    }
}