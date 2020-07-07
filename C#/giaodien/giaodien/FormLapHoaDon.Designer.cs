namespace giaodien
{
    partial class FormLapHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new Guna.UI.WinForms.GunaGradientButton();
            this.dgvCTHDX = new Guna.UI.WinForms.GunaDataGridView();
            this.SanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPham_FormLapHoaDon = new giaodien.SanPham_FormLapHoaDon();
            this.Ma_Size = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.size_FormLapHoaDon = new giaodien.Size_FormLapHoaDon();
            this.Mau = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mauSacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mauSac_FormLapHoaDon = new giaodien.MauSac_FormLapHoaDon();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sizeTableAdapter = new giaodien.Size_FormLapHoaDonTableAdapters.SizeTableAdapter();
            this.mauSacTableAdapter = new giaodien.MauSac_FormLapHoaDonTableAdapters.MauSacTableAdapter();
            this.btnThem = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            this.sanPhamTableAdapter = new giaodien.SanPham_FormLapHoaDonTableAdapters.SanPhamTableAdapter();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbThanhVien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbMau = new System.Windows.Forms.ComboBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.cbbSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTren = new System.Windows.Forms.Label();
            this.lbSoLuongTon = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPham_FormLapHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_FormLapHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSac_FormLapHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.AnimationHoverSpeed = 0.07F;
            this.btnQuayLai.AnimationSpeed = 0.03F;
            this.btnQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnQuayLai.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnQuayLai.BorderColor = System.Drawing.Color.Black;
            this.btnQuayLai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuayLai.FocusedColor = System.Drawing.Color.Empty;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btnQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.Image")));
            this.btnQuayLai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQuayLai.Location = new System.Drawing.Point(0, 0);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnQuayLai.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnQuayLai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnQuayLai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnQuayLai.OnHoverImage = null;
            this.btnQuayLai.OnPressedColor = System.Drawing.Color.Black;
            this.btnQuayLai.Size = new System.Drawing.Size(187, 42);
            this.btnQuayLai.TabIndex = 73;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // dgvCTHDX
            // 
            this.dgvCTHDX.AllowUserToAddRows = false;
            this.dgvCTHDX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTHDX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHDX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHDX.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCTHDX.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.ThanhTien,
            this.Xoa});
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
            this.dgvCTHDX.Location = new System.Drawing.Point(487, 226);
            this.dgvCTHDX.Name = "dgvCTHDX";
            this.dgvCTHDX.ReadOnly = true;
            this.dgvCTHDX.RowHeadersVisible = false;
            this.dgvCTHDX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHDX.Size = new System.Drawing.Size(802, 375);
            this.dgvCTHDX.TabIndex = 1;
            this.dgvCTHDX.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHDX.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHDX.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
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
            this.dgvCTHDX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHDX_CellContentClick);
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
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.sanPham_FormLapHoaDon;
            // 
            // sanPham_FormLapHoaDon
            // 
            this.sanPham_FormLapHoaDon.DataSetName = "SanPham_FormLapHoaDon";
            this.sanPham_FormLapHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sizeBindingSource
            // 
            this.sizeBindingSource.DataMember = "Size";
            this.sizeBindingSource.DataSource = this.size_FormLapHoaDon;
            // 
            // size_FormLapHoaDon
            // 
            this.size_FormLapHoaDon.DataSetName = "Size_FormLapHoaDon";
            this.size_FormLapHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // mauSacBindingSource
            // 
            this.mauSacBindingSource.DataMember = "MauSac";
            this.mauSacBindingSource.DataSource = this.mauSac_FormLapHoaDon;
            // 
            // mauSac_FormLapHoaDon
            // 
            this.mauSac_FormLapHoaDon.DataSetName = "MauSac_FormLapHoaDon";
            this.mauSac_FormLapHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // sizeTableAdapter
            // 
            this.sizeTableAdapter.ClearBeforeFill = true;
            // 
            // mauSacTableAdapter
            // 
            this.mauSacTableAdapter.ClearBeforeFill = true;
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnThem.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DimGray;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThem.Location = new System.Drawing.Point(487, 619);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnThem.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(189, 57);
            this.btnThem.TabIndex = 85;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnHuy.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.DimGray;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageSize = new System.Drawing.Size(45, 45);
            this.btnHuy.Location = new System.Drawing.Point(1085, 619);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnHuy.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Size = new System.Drawing.Size(189, 57);
            this.btnHuy.TabIndex = 84;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnLuu.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.DimGray;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLuu.Location = new System.Drawing.Point(794, 619);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnLuu.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(189, 57);
            this.btnLuu.TabIndex = 83;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lbSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDienThoai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSoDienThoai.Location = new System.Drawing.Point(996, 67);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(36, 39);
            this.lbSoDienThoai.TabIndex = 93;
            this.lbSoDienThoai.Text = "0";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.BackColor = System.Drawing.Color.Transparent;
            this.lbMaHD.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaHD.Location = new System.Drawing.Point(277, 64);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(36, 40);
            this.lbMaHD.TabIndex = 87;
            this.lbMaHD.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 86;
            this.label1.Text = "Hóa đơn ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 39);
            this.label6.TabIndex = 89;
            this.label6.Text = "Khách hàng";
            // 
            // lbThanhVien
            // 
            this.lbThanhVien.AutoSize = true;
            this.lbThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.lbThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbThanhVien.Location = new System.Drawing.Point(996, 140);
            this.lbThanhVien.Name = "lbThanhVien";
            this.lbThanhVien.Size = new System.Drawing.Size(36, 39);
            this.lbThanhVien.TabIndex = 92;
            this.lbThanhVien.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(763, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 39);
            this.label9.TabIndex = 91;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(763, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 39);
            this.label8.TabIndex = 90;
            this.label8.Text = "Thành viên";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.BackColor = System.Drawing.Color.Transparent;
            this.lbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTenKH.Location = new System.Drawing.Point(277, 140);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(36, 39);
            this.lbTenKH.TabIndex = 94;
            this.lbTenKH.Text = "0";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(149, 418);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(136, 38);
            this.txtSoLuong.TabIndex = 103;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(15, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 24);
            this.label10.TabIndex = 102;
            this.label10.Text = "Đơn giá";
            // 
            // cbbMau
            // 
            this.cbbMau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMau.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMau.ForeColor = System.Drawing.Color.Navy;
            this.cbbMau.FormattingEnabled = true;
            this.cbbMau.Location = new System.Drawing.Point(149, 349);
            this.cbbMau.Name = "cbbMau";
            this.cbbMau.Size = new System.Drawing.Size(307, 40);
            this.cbbMau.TabIndex = 101;
            this.cbbMau.SelectedValueChanged += new System.EventHandler(this.cbbMau_SelectedValueChanged);
            // 
            // cbbSize
            // 
            this.cbbSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSize.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSize.ForeColor = System.Drawing.Color.Navy;
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(149, 287);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(307, 40);
            this.cbbSize.TabIndex = 100;
            this.cbbSize.SelectedValueChanged += new System.EventHandler(this.cbbSize_SelectedValueChanged);
            // 
            // cbbSP
            // 
            this.cbbSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSP.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSP.ForeColor = System.Drawing.Color.Navy;
            this.cbbSP.FormattingEnabled = true;
            this.cbbSP.Location = new System.Drawing.Point(149, 226);
            this.cbbSP.Name = "cbbSP";
            this.cbbSP.Size = new System.Drawing.Size(307, 40);
            this.cbbSP.TabIndex = 99;
            this.cbbSP.SelectedValueChanged += new System.EventHandler(this.cbbSP_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 98;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 97;
            this.label4.Text = "Màu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 96;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Sản phẩm";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDonGia.Location = new System.Drawing.Point(145, 503);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(22, 24);
            this.lbDonGia.TabIndex = 104;
            this.lbDonGia.Text = "0";
            this.lbDonGia.TextChanged += new System.EventHandler(this.lbDonGia_TextChanged);
            // 
            // lbTren
            // 
            this.lbTren.AutoSize = true;
            this.lbTren.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTren.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTren.Location = new System.Drawing.Point(286, 416);
            this.lbTren.Name = "lbTren";
            this.lbTren.Size = new System.Drawing.Size(27, 40);
            this.lbTren.TabIndex = 105;
            this.lbTren.Text = "/";
            // 
            // lbSoLuongTon
            // 
            this.lbSoLuongTon.AutoSize = true;
            this.lbSoLuongTon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongTon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSoLuongTon.Location = new System.Drawing.Point(319, 421);
            this.lbSoLuongTon.Name = "lbSoLuongTon";
            this.lbSoLuongTon.Size = new System.Drawing.Size(30, 32);
            this.lbSoLuongTon.TabIndex = 106;
            this.lbSoLuongTon.Text = "0";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbThanhTien.Location = new System.Drawing.Point(191, 565);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(31, 34);
            this.lbThanhTien.TabIndex = 108;
            this.lbThanhTien.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 565);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 34);
            this.label11.TabIndex = 107;
            this.label11.Text = "Thành tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AnimationHoverSpeed = 0.07F;
            this.btnThanhToan.AnimationSpeed = 0.03F;
            this.btnThanhToan.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnThanhToan.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnThanhToan.BorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.FocusedColor = System.Drawing.Color.Empty;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.DimGray;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThanhToan.Location = new System.Drawing.Point(19, 619);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnThanhToan.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnThanhToan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThanhToan.OnHoverImage = null;
            this.btnThanhToan.OnPressedColor = System.Drawing.Color.Black;
            this.btnThanhToan.Size = new System.Drawing.Size(437, 57);
            this.btnThanhToan.TabIndex = 109;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // FormLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 706);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbSoLuongTon);
            this.Controls.Add(this.lbTren);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbMau);
            this.Controls.Add(this.cbbSize);
            this.Controls.Add(this.cbbSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.lbSoDienThoai);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbThanhVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvCTHDX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLapHoaDon";
            this.Load += new System.EventHandler(this.FormLapHoaDon_Load);
            this.Click += new System.EventHandler(this.FormLapHoaDon_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPham_FormLapHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_FormLapHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauSac_FormLapHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton btnQuayLai;
        private Guna.UI.WinForms.GunaDataGridView dgvCTHDX;
        private Size_FormLapHoaDon size_FormLapHoaDon;
        private System.Windows.Forms.BindingSource sizeBindingSource;
        private Size_FormLapHoaDonTableAdapters.SizeTableAdapter sizeTableAdapter;
        private MauSac_FormLapHoaDon mauSac_FormLapHoaDon;
        private System.Windows.Forms.BindingSource mauSacBindingSource;
        private MauSac_FormLapHoaDonTableAdapters.MauSacTableAdapter mauSacTableAdapter;
        private Guna.UI.WinForms.GunaGradientButton btnThem;
        private Guna.UI.WinForms.GunaGradientButton btnHuy;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private SanPham_FormLapHoaDon sanPham_FormLapHoaDon;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private SanPham_FormLapHoaDonTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbThanhVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbMau;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.ComboBox cbbSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTren;
        private System.Windows.Forms.Label lbSoLuongTon;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaGradientButton btnThanhToan;
        private System.Windows.Forms.DataGridViewComboBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ma_Size;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}