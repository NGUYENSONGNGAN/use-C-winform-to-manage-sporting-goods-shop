namespace giaodien
{
    partial class FormThongKeThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeThuChi));
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView5 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle5 = new DevExpress.XtraCharts.ChartTitle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.bt_XuatExcel = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtThu = new System.Windows.Forms.RadioButton();
            this.rbtChi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbNam);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 99);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn năm";
            // 
            // cbbNam
            // 
            this.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNam.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(39, 41);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(222, 35);
            this.cbbNam.TabIndex = 0;
            this.cbbNam.SelectedValueChanged += new System.EventHandler(this.cbbNam_SelectedValueChanged);
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
            this.bt_XuatExcel.Location = new System.Drawing.Point(863, 111);
            this.bt_XuatExcel.Name = "bt_XuatExcel";
            this.bt_XuatExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bt_XuatExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_XuatExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_XuatExcel.OnHoverImage = null;
            this.bt_XuatExcel.OnPressedColor = System.Drawing.Color.Black;
            this.bt_XuatExcel.Radius = 7;
            this.bt_XuatExcel.Size = new System.Drawing.Size(329, 55);
            this.bt_XuatExcel.TabIndex = 49;
            this.bt_XuatExcel.Text = "Xuất Excel";
            this.bt_XuatExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_XuatExcel.Click += new System.EventHandler(this.bt_XuatExcel_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1195, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 51;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 30);
            this.panel1.TabIndex = 52;
            // 
            // rbtThu
            // 
            this.rbtThu.AutoSize = true;
            this.rbtThu.Location = new System.Drawing.Point(43, 56);
            this.rbtThu.Name = "rbtThu";
            this.rbtThu.Size = new System.Drawing.Size(140, 28);
            this.rbtThu.TabIndex = 53;
            this.rbtThu.TabStop = true;
            this.rbtThu.Text = "Thống kê thu";
            this.rbtThu.UseVisualStyleBackColor = true;
            this.rbtThu.CheckedChanged += new System.EventHandler(this.rbtThu_CheckedChanged);
            // 
            // rbtChi
            // 
            this.rbtChi.AutoSize = true;
            this.rbtChi.Location = new System.Drawing.Point(43, 119);
            this.rbtChi.Name = "rbtChi";
            this.rbtChi.Size = new System.Drawing.Size(139, 28);
            this.rbtChi.TabIndex = 54;
            this.rbtChi.TabStop = true;
            this.rbtChi.Text = "Thống kê chi";
            this.rbtChi.UseVisualStyleBackColor = true;
            this.rbtChi.CheckedChanged += new System.EventHandler(this.rbtChi_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtChi);
            this.groupBox2.Controls.Add(this.rbtThu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(91, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 184);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thu/ Chi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1567, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(18, 23);
            this.dataGridView1.TabIndex = 56;
            // 
            // chartControl2
            // 
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram5;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(47, 253);
            this.chartControl2.Name = "chartControl2";
            series5.Name = "Series 1";
            sideBySideBarSeriesView5.ColorEach = true;
            series5.View = sideBySideBarSeriesView5;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartControl2.SeriesTemplate.SeriesColorizer = null;
            this.chartControl2.Size = new System.Drawing.Size(1143, 533);
            this.chartControl2.TabIndex = 47;
            chartTitle5.Text = "Biểu Đồ Thể Hiện Tổng Tiền Thu / Chi Theo Năm";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle5});
            // 
            // FormThongKeThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 810);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_XuatExcel);
            this.Controls.Add(this.chartControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThongKeThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKeThuChi";
            this.Load += new System.EventHandler(this.FormThongKeThuChi_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbNam;
        private Guna.UI.WinForms.GunaButton bt_XuatExcel;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtThu;
        private System.Windows.Forms.RadioButton rbtChi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}