namespace giaodien
{
    partial class FormThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_TenSach = new Guna.UI.WinForms.GunaLabel();
            this.dgvCTHDX = new Guna.UI.WinForms.GunaDataGridView();
            this.label_ToTal = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.ptbQR = new System.Windows.Forms.PictureBox();
            this.bt_ThanhToan = new Guna.UI.WinForms.GunaGradientButton();
            this.sanPham_FormThanhToan = new giaodien.SanPham_FormThanhToan();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new giaodien.SanPham_FormThanhToanTableAdapters.SanPhamTableAdapter();
            this.size_FormThanhToan = new giaodien.Size_FormThanhToan();
            this.sizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeTableAdapter = new giaodien.Size_FormThanhToanTableAdapters.SizeTableAdapter();
            this.mauSac_FormThanhToan = new giaodien.MauSac_FormThanhToan();
            this.mauSacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mauSacTableAdapter = new giaodien.MauSac_FormThanhToanTableAdapters.MauSacTableAdapter();
            this.SanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ma_Size = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPham_FormThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_FormThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSac_FormThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TenSach
            // 
            this.lb_TenSach.AutoSize = true;
            this.lb_TenSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.lb_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenSach.ForeColor = System.Drawing.Color.Black;
            this.lb_TenSach.Location = new System.Drawing.Point(529, 9);
            this.lb_TenSach.Name = "lb_TenSach";
            this.lb_TenSach.Size = new System.Drawing.Size(294, 55);
            this.lb_TenSach.TabIndex = 56;
            this.lb_TenSach.Text = "Thanh Toán";
            // 
            // dgvCTHDX
            // 
            this.dgvCTHDX.AllowUserToAddRows = false;
            this.dgvCTHDX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTHDX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHDX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHDX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.dgvCTHDX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTHDX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHDX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHDX.ColumnHeadersHeight = 45;
            this.dgvCTHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SanPham,
            this.Ma_Size,
            this.Mau,
            this.SoLuong,
            this.ThanhTien});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHDX.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTHDX.EnableHeadersVisualStyles = false;
            this.dgvCTHDX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCTHDX.Location = new System.Drawing.Point(65, 67);
            this.dgvCTHDX.Name = "dgvCTHDX";
            this.dgvCTHDX.ReadOnly = true;
            this.dgvCTHDX.RowHeadersVisible = false;
            this.dgvCTHDX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHDX.Size = new System.Drawing.Size(1144, 386);
            this.dgvCTHDX.TabIndex = 57;
            this.dgvCTHDX.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHDX.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.dgvCTHDX.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCTHDX.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCTHDX.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHDX.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHDX.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHDX.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHDX.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvCTHDX.ThemeStyle.ReadOnly = true;
            this.dgvCTHDX.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCTHDX.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHDX.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHDX.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHDX.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCTHDX.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCTHDX.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // label_ToTal
            // 
            this.label_ToTal.AutoSize = true;
            this.label_ToTal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ToTal.Location = new System.Drawing.Point(474, 513);
            this.label_ToTal.Name = "label_ToTal";
            this.label_ToTal.Size = new System.Drawing.Size(134, 31);
            this.label_ToTal.TabIndex = 63;
            this.label_ToTal.Text = "Tổng Tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(474, 554);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(28, 31);
            this.lbTongTien.TabIndex = 64;
            this.lbTongTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(882, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(886, 540);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(345, 183);
            this.txtGhiChu.TabIndex = 69;
            this.txtGhiChu.Text = "";
            // 
            // ptbQR
            // 
            this.ptbQR.Location = new System.Drawing.Point(65, 459);
            this.ptbQR.Name = "ptbQR";
            this.ptbQR.Size = new System.Drawing.Size(264, 264);
            this.ptbQR.TabIndex = 68;
            this.ptbQR.TabStop = false;
            // 
            // bt_ThanhToan
            // 
            this.bt_ThanhToan.AnimationHoverSpeed = 0.07F;
            this.bt_ThanhToan.AnimationSpeed = 0.03F;
            this.bt_ThanhToan.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.bt_ThanhToan.BaseColor2 = System.Drawing.Color.Transparent;
            this.bt_ThanhToan.BorderColor = System.Drawing.Color.Black;
            this.bt_ThanhToan.FocusedColor = System.Drawing.Color.Empty;
            this.bt_ThanhToan.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.bt_ThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("bt_ThanhToan.Image")));
            this.bt_ThanhToan.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_ThanhToan.Location = new System.Drawing.Point(480, 636);
            this.bt_ThanhToan.Name = "bt_ThanhToan";
            this.bt_ThanhToan.OnHoverBaseColor1 = System.Drawing.Color.Gainsboro;
            this.bt_ThanhToan.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.bt_ThanhToan.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.bt_ThanhToan.OnHoverForeColor = System.Drawing.Color.Black;
            this.bt_ThanhToan.OnHoverImage = null;
            this.bt_ThanhToan.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.bt_ThanhToan.Size = new System.Drawing.Size(261, 60);
            this.bt_ThanhToan.TabIndex = 65;
            this.bt_ThanhToan.Text = "Hoàn Tất Thanh Toán";
            this.bt_ThanhToan.Click += new System.EventHandler(this.bt_ThanhToan_Click);
            // 
            // sanPham_FormThanhToan
            // 
            this.sanPham_FormThanhToan.DataSetName = "SanPham_FormThanhToan";
            this.sanPham_FormThanhToan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.sanPham_FormThanhToan;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // size_FormThanhToan
            // 
            this.size_FormThanhToan.DataSetName = "Size_FormThanhToan";
            this.size_FormThanhToan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sizeBindingSource
            // 
            this.sizeBindingSource.DataMember = "Size";
            this.sizeBindingSource.DataSource = this.size_FormThanhToan;
            // 
            // sizeTableAdapter
            // 
            this.sizeTableAdapter.ClearBeforeFill = true;
            // 
            // mauSac_FormThanhToan
            // 
            this.mauSac_FormThanhToan.DataSetName = "MauSac_FormThanhToan";
            this.mauSac_FormThanhToan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mauSacBindingSource
            // 
            this.mauSacBindingSource.DataMember = "MauSac";
            this.mauSacBindingSource.DataSource = this.mauSac_FormThanhToan;
            // 
            // mauSacTableAdapter
            // 
            this.mauSacTableAdapter.ClearBeforeFill = true;
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
            // Mau
            // 
            this.Mau.DataPropertyName = "Ma_MauSac";
            this.Mau.DataSource = this.mauSacBindingSource;
            this.Mau.DisplayMember = "TenMau";
            this.Mau.HeaderText = "Màu";
            this.Mau.Name = "Mau";
            this.Mau.ReadOnly = true;
            this.Mau.ValueMember = "Ma";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1273, 735);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.ptbQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ThanhToan);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label_ToTal);
            this.Controls.Add(this.dgvCTHDX);
            this.Controls.Add(this.lb_TenSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPham_FormThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_FormThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSac_FormThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lb_TenSach;
        private Guna.UI.WinForms.GunaDataGridView dgvCTHDX;
        private System.Windows.Forms.Label label_ToTal;
        private System.Windows.Forms.Label lbTongTien;
        private Guna.UI.WinForms.GunaGradientButton bt_ThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbQR;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private SanPham_FormThanhToan sanPham_FormThanhToan;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private SanPham_FormThanhToanTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private Size_FormThanhToan size_FormThanhToan;
        private System.Windows.Forms.BindingSource sizeBindingSource;
        private Size_FormThanhToanTableAdapters.SizeTableAdapter sizeTableAdapter;
        private MauSac_FormThanhToan mauSac_FormThanhToan;
        private System.Windows.Forms.BindingSource mauSacBindingSource;
        private MauSac_FormThanhToanTableAdapters.MauSacTableAdapter mauSacTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ma_Size;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}