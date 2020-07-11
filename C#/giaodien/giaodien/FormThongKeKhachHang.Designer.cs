namespace giaodien
{
    partial class FormThongKeKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.dgvThongTin = new Guna.UI.WinForms.GunaDataGridView();
            this.bt_XuatExcel = new Guna.UI.WinForms.GunaButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 30);
            this.panel1.TabIndex = 54;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1234, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 0;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AllowUserToAddRows = false;
            this.dgvThongTin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvThongTin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTin.ColumnHeadersHeight = 40;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TenKH,
            this.SanPham,
            this.TenMau,
            this.TenSize,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongTin.EnableHeadersVisualStyles = false;
            this.dgvThongTin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvThongTin.Location = new System.Drawing.Point(0, 73);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.ReadOnly = true;
            this.dgvThongTin.RowHeadersVisible = false;
            this.dgvThongTin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTin.Size = new System.Drawing.Size(1279, 461);
            this.dgvThongTin.TabIndex = 55;
            this.dgvThongTin.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvThongTin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvThongTin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvThongTin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvThongTin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongTin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongTin.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvThongTin.ThemeStyle.ReadOnly = true;
            this.dgvThongTin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvThongTin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongTin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTin.ThemeStyle.RowsStyle.Height = 22;
            this.dgvThongTin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvThongTin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // bt_XuatExcel
            // 
            this.bt_XuatExcel.AnimationHoverSpeed = 0.07F;
            this.bt_XuatExcel.AnimationSpeed = 0.03F;
            this.bt_XuatExcel.BackColor = System.Drawing.Color.Transparent;
            this.bt_XuatExcel.BaseColor = System.Drawing.Color.Transparent;
            this.bt_XuatExcel.BorderColor = System.Drawing.Color.Black;
            this.bt_XuatExcel.FocusedColor = System.Drawing.Color.Empty;
            this.bt_XuatExcel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XuatExcel.ForeColor = System.Drawing.Color.Black;
            this.bt_XuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("bt_XuatExcel.Image")));
            this.bt_XuatExcel.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_XuatExcel.Location = new System.Drawing.Point(484, 540);
            this.bt_XuatExcel.Name = "bt_XuatExcel";
            this.bt_XuatExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bt_XuatExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_XuatExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_XuatExcel.OnHoverImage = null;
            this.bt_XuatExcel.OnPressedColor = System.Drawing.Color.Black;
            this.bt_XuatExcel.Radius = 7;
            this.bt_XuatExcel.Size = new System.Drawing.Size(329, 55);
            this.bt_XuatExcel.TabIndex = 56;
            this.bt_XuatExcel.Text = "Xuất Excel";
            this.bt_XuatExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_XuatExcel.Click += new System.EventHandler(this.bt_XuatExcel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(413, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 37);
            this.label7.TabIndex = 57;
            this.label7.Text = "Thống kê khách hàng đã mua gì";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Hóa đơn";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // SanPham
            // 
            this.SanPham.DataPropertyName = "SP";
            this.SanPham.HeaderText = "Sản phẩm";
            this.SanPham.Name = "SanPham";
            this.SanPham.ReadOnly = true;
            // 
            // TenMau
            // 
            this.TenMau.DataPropertyName = "TenMau";
            this.TenMau.HeaderText = "Màu";
            this.TenMau.Name = "TenMau";
            this.TenMau.ReadOnly = true;
            // 
            // TenSize
            // 
            this.TenSize.DataPropertyName = "TenSize";
            this.TenSize.HeaderText = "Size";
            this.TenSize.Name = "TenSize";
            this.TenSize.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // FormThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 601);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_XuatExcel);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThongKeKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKeKhachHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDataGridView dgvThongTin;
        private Guna.UI.WinForms.GunaButton bt_XuatExcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}