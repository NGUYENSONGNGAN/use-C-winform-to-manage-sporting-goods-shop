namespace giaodien
{
    partial class FormHDX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHDX));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvHDX = new Guna.UI.WinForms.GunaDataGridView();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHang_FormHDX = new giaodien.KhachHang_FormHDX();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVien_FormHDX = new giaodien.NhanVien_FormHDX();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnBack = new Guna.UI.WinForms.GunaGradientButton();
            this.khachHangTableAdapter = new giaodien.KhachHang_FormHDXTableAdapters.KhachHangTableAdapter();
            this.nhanVienTableAdapter = new giaodien.NhanVien_FormHDXTableAdapters.NhanVienTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTikKiemNangCao = new Guna.UI.WinForms.GunaGradientButton();
            this.txtTimKiem = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ThayDoiTrangThai = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHang_FormHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien_FormHDX)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lbTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(504, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(235, 31);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Hóa đơn bán hàng";
            // 
            // dgvHDX
            // 
            this.dgvHDX.AllowUserToAddRows = false;
            this.dgvHDX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvHDX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDX.BackgroundColor = System.Drawing.Color.White;
            this.dgvHDX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHDX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHDX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHDX.ColumnHeadersHeight = 35;
            this.dgvHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.KhachHang,
            this.Ma_NV,
            this.NgayXuat,
            this.TongTien,
            this.TrangThai,
            this.GhiChu,
            this.Xem,
            this.ThayDoiTrangThai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHDX.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDX.EnableHeadersVisualStyles = false;
            this.dgvHDX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvHDX.Location = new System.Drawing.Point(0, 122);
            this.dgvHDX.Name = "dgvHDX";
            this.dgvHDX.ReadOnly = true;
            this.dgvHDX.RowHeadersVisible = false;
            this.dgvHDX.RowHeadersWidth = 50;
            this.dgvHDX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDX.Size = new System.Drawing.Size(1290, 512);
            this.dgvHDX.TabIndex = 3;
            this.dgvHDX.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvHDX.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvHDX.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHDX.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHDX.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHDX.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHDX.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHDX.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvHDX.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvHDX.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHDX.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHDX.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHDX.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHDX.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvHDX.ThemeStyle.ReadOnly = true;
            this.dgvHDX.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvHDX.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHDX.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHDX.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHDX.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHDX.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvHDX.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHDX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDX_CellContentClick);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.khachHang_FormHDX;
            // 
            // khachHang_FormHDX
            // 
            this.khachHang_FormHDX.DataSetName = "KhachHang_FormHDX";
            this.khachHang_FormHDX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.nhanVien_FormHDX;
            // 
            // nhanVien_FormHDX
            // 
            this.nhanVien_FormHDX.DataSetName = "NhanVien_FormHDX";
            this.nhanVien_FormHDX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnTitle;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnTitle
            // 
            this.pnTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTitle.BackgroundImage")));
            this.pnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Controls.Add(this.btnBack);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.GradientBottomLeft = System.Drawing.Color.White;
            this.pnTitle.GradientBottomRight = System.Drawing.Color.White;
            this.pnTitle.GradientTopLeft = System.Drawing.Color.White;
            this.pnTitle.GradientTopRight = System.Drawing.Color.White;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Quality = 10;
            this.pnTitle.Size = new System.Drawing.Size(1290, 46);
            this.pnTitle.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnBack.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(160, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTikKiemNangCao);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 76);
            this.panel1.TabIndex = 4;
            // 
            // btnTikKiemNangCao
            // 
            this.btnTikKiemNangCao.AnimationHoverSpeed = 0.07F;
            this.btnTikKiemNangCao.AnimationSpeed = 0.03F;
            this.btnTikKiemNangCao.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnTikKiemNangCao.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnTikKiemNangCao.BorderColor = System.Drawing.Color.Black;
            this.btnTikKiemNangCao.FocusedColor = System.Drawing.Color.Empty;
            this.btnTikKiemNangCao.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTikKiemNangCao.ForeColor = System.Drawing.Color.DimGray;
            this.btnTikKiemNangCao.Image = ((System.Drawing.Image)(resources.GetObject("btnTikKiemNangCao.Image")));
            this.btnTikKiemNangCao.ImageSize = new System.Drawing.Size(45, 45);
            this.btnTikKiemNangCao.Location = new System.Drawing.Point(12, 6);
            this.btnTikKiemNangCao.Name = "btnTikKiemNangCao";
            this.btnTikKiemNangCao.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnTikKiemNangCao.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnTikKiemNangCao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTikKiemNangCao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTikKiemNangCao.OnHoverImage = null;
            this.btnTikKiemNangCao.OnPressedColor = System.Drawing.Color.Black;
            this.btnTikKiemNangCao.Size = new System.Drawing.Size(336, 63);
            this.btnTikKiemNangCao.TabIndex = 110;
            this.btnTikKiemNangCao.Text = "Tìm kiếm QR";
            this.btnTikKiemNangCao.Click += new System.EventHandler(this.btnTikKiemNangCao_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BaseColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimKiem.FocusedBorderColor = System.Drawing.Color.Cyan;
            this.txtTimKiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(392, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.Size = new System.Drawing.Size(722, 63);
            this.txtTimKiem.TabIndex = 85;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1154, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã hóa đơn";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // KhachHang
            // 
            this.KhachHang.DataPropertyName = "Ma_KH";
            this.KhachHang.DataSource = this.khachHangBindingSource;
            this.KhachHang.DisplayMember = "Ten";
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            this.KhachHang.ValueMember = "Ma";
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.DataSource = this.nhanVienBindingSource;
            this.Ma_NV.DisplayMember = "Ten";
            this.Ma_NV.HeaderText = "Nhân viên";
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.ReadOnly = true;
            this.Ma_NV.ValueMember = "Ma";
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Đã thanh toán";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // Xem
            // 
            this.Xem.DataPropertyName = "Xem";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.Xem.DefaultCellStyle = dataGridViewCellStyle4;
            this.Xem.HeaderText = "Xem Chi tiết";
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            this.Xem.Text = "Xem";
            this.Xem.UseColumnTextForButtonValue = true;
            // 
            // ThayDoiTrangThai
            // 
            this.ThayDoiTrangThai.HeaderText = "Hủy";
            this.ThayDoiTrangThai.Name = "ThayDoiTrangThai";
            this.ThayDoiTrangThai.ReadOnly = true;
            this.ThayDoiTrangThai.Text = "Hủy";
            this.ThayDoiTrangThai.UseColumnTextForButtonValue = true;
            // 
            // FormHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 634);
            this.Controls.Add(this.dgvHDX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHDX";
            this.Load += new System.EventHandler(this.FormHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHang_FormHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien_FormHDX)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI.WinForms.GunaDataGridView dgvHDX;
        private Guna.UI.WinForms.GunaGradientButton btnBack;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnTitle;
        private KhachHang_FormHDX khachHang_FormHDX;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private KhachHang_FormHDXTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private NhanVien_FormHDX nhanVien_FormHDX;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NhanVien_FormHDXTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradientButton btnTikKiemNangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewComboBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewButtonColumn Xem;
        private System.Windows.Forms.DataGridViewButtonColumn ThayDoiTrangThai;
    }
}