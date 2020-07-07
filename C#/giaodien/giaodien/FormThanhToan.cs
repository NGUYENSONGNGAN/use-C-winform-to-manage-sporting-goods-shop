using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
        }
        public class TTTT
        {
            public static int Ma;
            public static int MoFormRP;
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        DataClasses1DataContext dt = new DataClasses1DataContext();
        int MaHD;
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mauSac_FormThanhToan.MauSac' table. You can move, or remove it, as needed.
            this.mauSacTableAdapter.Fill(this.mauSac_FormThanhToan.MauSac);
            // TODO: This line of code loads data into the 'size_FormThanhToan.Size' table. You can move, or remove it, as needed.
            this.sizeTableAdapter.Fill(this.size_FormThanhToan.Size);
            // TODO: This line of code loads data into the 'sanPham_FormThanhToan.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sanPham_FormThanhToan.SanPham);
            MaHD = FormLapHoaDon.TTMHDX.Ma;
            TTTT.Ma = MaHD;
            var HDX = dt.selectTTHDX(MaHD).FirstOrDefault();
            MemoryStream stream = new MemoryStream(HDX.MaQR.ToArray());
            Image img = Image.FromStream(stream);
            ptbQR.Image = img;
            int TongTien = Convert.ToInt32( HDX.TongTien);
            lbTongTien.Text = TongTien.ToString("N0", culture);
            dgvCTHDX.AutoGenerateColumns = false;
            dgvCTHDX.DataSource = dt.selectCTHDX(MaHD);
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            if (txtGhiChu.Text.Trim()=="" || txtGhiChu.Text.Trim()==null)
            {
                DialogResult a = MessageBox.Show("Bạn chưa có ghi chú\nBạn có muốn thanh toán luôn không ???", "Thiếu thông tin", MessageBoxButtons.YesNo);
                if (a== DialogResult.Yes)
                {
                    dt.updateghichu(MaHD, txtGhiChu.Text);
                    MessageBox.Show("Thanh toán thành công", "Thanh công");
                    FormRPHDX FRPHDX = new FormRPHDX();
                    FRPHDX.Show();
                    TTTT.Ma = 0;
                    this.Close();
                }    
            }   
            else if (txtGhiChu.Text.Trim()!= ""||txtGhiChu.Text.Trim()!= null)
            {
                dt.updateghichu(MaHD, txtGhiChu.Text);
                MessageBox.Show("Thanh toán thành công", "Thành công");
                TTTT.MoFormRP = 1;
                FormRPHDX FRPHDX = new FormRPHDX();
                FRPHDX.Show();
                TTTT.Ma = 0;
                this.Close();
            }    
        }
    }
}
