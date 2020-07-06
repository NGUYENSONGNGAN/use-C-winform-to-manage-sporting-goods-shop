namespace giaodien
{
    partial class FormThongTinSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongTinSP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new Guna.UI.WinForms.GunaGradientButton();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbSoMa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new Guna.UI.WinForms.GunaDataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_LoaiSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.loaiSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiSP_FormThongTinSP = new giaodien.LoaiSP_FormThongTinSP();
            this.loaiSPTableAdapter = new giaodien.LoaiSP_FormThongTinSPTableAdapters.LoaiSPTableAdapter();
            this.txtTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDonGia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTimKiem = new Guna.UI.WinForms.GunaLineTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSua = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThem = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            this.pic_SanPham = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSP_FormThongTinSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 44);
            this.panel1.TabIndex = 28;
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
            this.btnQuayLai.Size = new System.Drawing.Size(187, 44);
            this.btnQuayLai.TabIndex = 74;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMa.Location = new System.Drawing.Point(16, 386);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 29);
            this.lbMa.TabIndex = 33;
            this.lbMa.Text = "Mã";
            // 
            // lbSoMa
            // 
            this.lbSoMa.AutoSize = true;
            this.lbSoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoMa.Location = new System.Drawing.Point(165, 386);
            this.lbSoMa.Name = "lbSoMa";
            this.lbSoMa.Size = new System.Drawing.Size(29, 31);
            this.lbSoMa.TabIndex = 34;
            this.lbSoMa.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 654);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Đơn giá";
            // 
            // cbbLoai
            // 
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(171, 470);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(452, 39);
            this.cbbLoai.TabIndex = 54;
            this.cbbLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLoai_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Loại";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(8, 42);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(281, 263);
            this.treeView1.TabIndex = 57;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 311);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeight = 40;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.DonGia,
            this.Ma_LoaiSP});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvSanPham.Location = new System.Drawing.Point(352, 50);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(711, 311);
            this.dgvSanPham.TabIndex = 59;
            this.dgvSanPham.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSanPham.ThemeStyle.ReadOnly = true;
            this.dgvSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
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
            // Ma_LoaiSP
            // 
            this.Ma_LoaiSP.DataPropertyName = "Ma_LoaiSP";
            this.Ma_LoaiSP.DataSource = this.loaiSPBindingSource;
            this.Ma_LoaiSP.DisplayMember = "Ten";
            this.Ma_LoaiSP.HeaderText = "Loại";
            this.Ma_LoaiSP.Name = "Ma_LoaiSP";
            this.Ma_LoaiSP.ReadOnly = true;
            this.Ma_LoaiSP.ValueMember = "Ma";
            // 
            // loaiSPBindingSource
            // 
            this.loaiSPBindingSource.DataMember = "LoaiSP";
            this.loaiSPBindingSource.DataSource = this.loaiSP_FormThongTinSP;
            // 
            // loaiSP_FormThongTinSP
            // 
            this.loaiSP_FormThongTinSP.DataSetName = "LoaiSP_FormThongTinSP";
            this.loaiSP_FormThongTinSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiSPTableAdapter
            // 
            this.loaiSPTableAdapter.ClearBeforeFill = true;
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTen.HintText = "Nhập vào tên";
            this.txtTen.isPassword = false;
            this.txtTen.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTen.LineThickness = 6;
            this.txtTen.Location = new System.Drawing.Point(171, 536);
            this.txtTen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(452, 57);
            this.txtTen.TabIndex = 86;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonGia.HintForeColor = System.Drawing.Color.Empty;
            this.txtDonGia.HintText = "Nhập vào đơn giá";
            this.txtDonGia.isPassword = false;
            this.txtDonGia.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDonGia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDonGia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDonGia.LineThickness = 6;
            this.txtDonGia.Location = new System.Drawing.Point(171, 626);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(452, 57);
            this.txtDonGia.TabIndex = 87;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonGia.OnValueChanged += new System.EventHandler(this.txtDonGia_OnValueChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox2_KeyPress);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.FocusedLineColor = System.Drawing.Color.Aqua;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.LineColor = System.Drawing.Color.RoyalBlue;
            this.txtTimKiem.Location = new System.Drawing.Point(352, 379);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.Size = new System.Drawing.Size(632, 60);
            this.txtTimKiem.TabIndex = 92;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(990, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.AnimationHoverSpeed = 0.07F;
            this.btnChonAnh.AnimationSpeed = 0.03F;
            this.btnChonAnh.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnChonAnh.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnChonAnh.BorderColor = System.Drawing.Color.Black;
            this.btnChonAnh.FocusedColor = System.Drawing.Color.Empty;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.DimGray;
            this.btnChonAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnChonAnh.Image")));
            this.btnChonAnh.ImageSize = new System.Drawing.Size(45, 45);
            this.btnChonAnh.Location = new System.Drawing.Point(692, 660);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnChonAnh.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnChonAnh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChonAnh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChonAnh.OnHoverImage = null;
            this.btnChonAnh.OnPressedColor = System.Drawing.Color.Black;
            this.btnChonAnh.Size = new System.Drawing.Size(371, 49);
            this.btnChonAnh.TabIndex = 90;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnSua.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DimGray;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(45, 45);
            this.btnSua.Location = new System.Drawing.Point(297, 751);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnSua.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(189, 57);
            this.btnSua.TabIndex = 89;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(23, 751);
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
            this.btnHuy.Location = new System.Drawing.Point(874, 751);
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
            this.btnLuu.Location = new System.Drawing.Point(576, 751);
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
            // pic_SanPham
            // 
            this.pic_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_SanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_SanPham.Location = new System.Drawing.Point(692, 445);
            this.pic_SanPham.Name = "pic_SanPham";
            this.pic_SanPham.Size = new System.Drawing.Size(371, 238);
            this.pic_SanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SanPham.TabIndex = 32;
            this.pic_SanPham.TabStop = false;
            // 
            // FormThongTinSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 820);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSoMa);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.pic_SanPham);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThongTinSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongTinSP";
            this.Load += new System.EventHandler(this.FormThongTinSP_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSP_FormThongTinSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_SanPham;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbSoMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TreeView treeView1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaGradientButton btnQuayLai;
        private Guna.UI.WinForms.GunaDataGridView dgvSanPham;
        private LoaiSP_FormThongTinSP loaiSP_FormThongTinSP;
        private System.Windows.Forms.BindingSource loaiSPBindingSource;
        private LoaiSP_FormThongTinSPTableAdapters.LoaiSPTableAdapter loaiSPTableAdapter;
        private Guna.UI.WinForms.GunaGradientButton btnThem;
        private Guna.UI.WinForms.GunaGradientButton btnHuy;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDonGia;
        private Guna.UI.WinForms.GunaGradientButton btnSua;
        private Guna.UI.WinForms.GunaGradientButton btnChonAnh;
        private Guna.UI.WinForms.GunaLineTextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ma_LoaiSP;
    }
}