using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormKiemTraKhachHang : Form
    {
        public FormKiemTraKhachHang()
        {
            InitializeComponent();
        }

        DataClasses1DataContext dt = new DataClasses1DataContext();
        public class TTKHC
        {
            public static int Ma=0;
        }

        private void btnKhachHangCu_Click(object sender, EventArgs e)
        {
            pnKiemTraKhachHang.Visible = false;
            pnTimKiemKhachHang.Visible = true;
  
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            pnKiemTraKhachHang.Visible = true;
            pnTimKiemKhachHang.Visible = false;
        }

        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChu FTC = new FormTrangChu();
            FTC.Hide();
            FormKhachHangMoi f1 = new FormKhachHangMoi();
            f1.Show();            
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            pnKiemTraKhachHang.Visible = true;
            pnTimKiemKhachHang.Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtEmailKhachHang.Text.Trim() =="" || txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ\nVui lòng nhập đủ thông tin", "Lỗi");
            }       
            else
            {
                KhachHang KH = dt.KhachHangs.Where(s => s.Email == txtEmailKhachHang.Text.Trim())
                .Where(s => s.Ten == txtTen.Text.Trim()).FirstOrDefault();
                if (KH == null)
                {
                    MessageBox.Show("Thông tin bạn nhập sai hoặc chưa có tài khoản.\nVui lòng kiểm tra lại", "Lỗi");
                }
                else if (KH != null)
                {
                    TTKHC.Ma = KH.Ma; 
                    MessageBox.Show("Mời bạn vào mua hàng");
                    FormLapHoaDon FLHD = new FormLapHoaDon();
                    FLHD.Show();
                    this.Hide();
                }
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
            this.Close();
        }

        private void txtMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
