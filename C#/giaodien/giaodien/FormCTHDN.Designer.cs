namespace giaodien
{
    partial class FormCTHDN
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTHDN));
            this.dgvCTHDN = new Guna.UI.WinForms.GunaDataGridView();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPham_FormCTHDN = new giaodien.SanPham_FormCTHDN();
            this.sizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.size_FormCTHDN = new giaodien.Size_FormCTHDN();
            this.mauSacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mauSac_FormCTHDN = new giaodien.MauSac_FormCTHDN();
            this.sanPhamTableAdapter = new giaodien.SanPham_FormCTHDNTableAdapters.SanPhamTableAdapter();
            this.sizeTableAdapter = new giaodien.Size_FormCTHDNTableAdapters.SizeTableAdapter();
            this.mauSacTableAdapter = new giaodien.MauSac_FormCTHDNTableAdapters.MauSacTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.SanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ma_Size = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPham_FormCTHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_FormCTHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSac_FormCTHDN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTHDN
            // 
            this.dgvCTHDN.AllowUserToAddRows = false;
            this.dgvCTHDN.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTHDN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHDN.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTHDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHDN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHDN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHDN.ColumnHeadersHeight = 41;
            this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCTHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SanPham,
            this.Ma_Size,
            this.MauSac,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHDN.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHDN.EnableHeadersVisualStyles = false;
            this.dgvCTHDN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCTHDN.Location = new System.Drawing.Point(0, 30);
            this.dgvCTHDN.Name = "dgvCTHDN";
            this.dgvCTHDN.ReadOnly = true;
            this.dgvCTHDN.RowHeadersVisible = false;
            this.dgvCTHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHDN.Size = new System.Drawing.Size(914, 361);
            this.dgvCTHDN.TabIndex = 0;
            this.dgvCTHDN.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvCTHDN.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTHDN.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHDN.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHDN.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHDN.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHDN.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHDN.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCTHDN.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCTHDN.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHDN.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHDN.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHDN.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCTHDN.ThemeStyle.HeaderStyle.Height = 41;
            this.dgvCTHDN.ThemeStyle.ReadOnly = true;
            this.dgvCTHDN.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCTHDN.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHDN.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHDN.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHDN.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCTHDN.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCTHDN.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.sanPham_FormCTHDN;
            // 
            // sanPham_FormCTHDN
            // 
            this.sanPham_FormCTHDN.DataSetName = "SanPham_FormCTHDN";
            this.sanPham_FormCTHDN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sizeBindingSource
            // 
            this.sizeBindingSource.DataMember = "Size";
            this.sizeBindingSource.DataSource = this.size_FormCTHDN;
            // 
            // size_FormCTHDN
            // 
            this.size_FormCTHDN.DataSetName = "Size_FormCTHDN";
            this.size_FormCTHDN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mauSacBindingSource
            // 
            this.mauSacBindingSource.DataMember = "MauSac";
            this.mauSacBindingSource.DataSource = this.mauSac_FormCTHDN;
            // 
            // mauSac_FormCTHDN
            // 
            this.mauSac_FormCTHDN.DataSetName = "MauSac_FormCTHDN";
            this.mauSac_FormCTHDN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // sizeTableAdapter
            // 
            this.sizeTableAdapter.ClearBeforeFill = true;
            // 
            // mauSacTableAdapter
            // 
            this.mauSacTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 30);
            this.panel1.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(869, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 0;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // SanPham
            // 
            this.SanPham.DataPropertyName = "Ma_SP";
            this.SanPham.DataSource = this.sanPhamBindingSource;
            this.SanPham.DisplayMember = "Ten";
            this.SanPham.HeaderText = "Sản phẩm";
            this.SanPham.Name = "SanPham";
            this.SanPham.ReadOnly = true;
            this.SanPham.ValueMember = "Ma";
            // 
            // Ma_Size
            // 
            this.Ma_Size.DataPropertyName = "Ma_Size";
            this.Ma_Size.DataSource = this.sizeBindingSource;
            this.Ma_Size.DisplayMember = "TenSize";
            this.Ma_Size.HeaderText = "Size";
            this.Ma_Size.Name = "Ma_Size";
            this.Ma_Size.ReadOnly = true;
            this.Ma_Size.ValueMember = "Ma";
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "Ma_MauSac";
            this.MauSac.DataSource = this.mauSacBindingSource;
            this.MauSac.DisplayMember = "TenMau";
            this.MauSac.HeaderText = "Màu sắc";
            this.MauSac.Name = "MauSac";
            this.MauSac.ReadOnly = true;
            this.MauSac.ValueMember = "Ma";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // FormCTHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 391);
            this.Controls.Add(this.dgvCTHDN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCTHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCTHDN";
            this.Load += new System.EventHandler(this.FormCTHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPham_FormCTHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_FormCTHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSac_FormCTHDN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvCTHDN;
        private SanPham_FormCTHDN sanPham_FormCTHDN;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private SanPham_FormCTHDNTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private Size_FormCTHDN size_FormCTHDN;
        private System.Windows.Forms.BindingSource sizeBindingSource;
        private Size_FormCTHDNTableAdapters.SizeTableAdapter sizeTableAdapter;
        private MauSac_FormCTHDN mauSac_FormCTHDN;
        private System.Windows.Forms.BindingSource mauSacBindingSource;
        private MauSac_FormCTHDNTableAdapters.MauSacTableAdapter mauSacTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ma_Size;
        private System.Windows.Forms.DataGridViewComboBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}