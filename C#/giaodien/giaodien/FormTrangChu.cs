using DevExpress.Emf;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace giaodien
{
    public partial class FormTrangChu : Form
    {

        public class ThongTinCaNhan
        {
            public static int SuaTTCaNhan, MaNV;
        }

        public FormTrangChu()
        {
            InitializeComponent();
            customizeDesing();
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void customizeDesing()
        {
            pnQuanLyThongTin.Visible = false;
            pnNhapHang.Visible = false;
            pnBanHang.Visible = false;
        }

        private void hidemenu()
        {
            if (pnQuanLyThongTin.Visible == true)
                pnQuanLyThongTin.Visible = false;
            if (pnNhapHang.Visible == true)
                pnNhapHang.Visible = false;
            if (pnBanHang.Visible == true)
                pnBanHang.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
        }

        private void showmenu( Panel pnQuanLyThongTin)
        {
            if (pnQuanLyThongTin.Visible == false)
            {
                hidemenu();
                pnQuanLyThongTin.Visible = true;
            }
            else
                pnQuanLyThongTin.Visible = false;

        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap DN = new FormDangNhap();
            DN.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnQuanLyDuLieu_Click_1(object sender, EventArgs e)
        {
            showmenu(pnQuanLyThongTin);
        }

        private void btnBaoCaoThongKe_Click_1(object sender, EventArgs e)
        {
            showmenu(pnNhapHang);
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            FormChatServer FC = new FormChatServer();
            FC.TopLevel = false;
            panel4.Controls.Add(FC);
            FC.Dock = DockStyle.Fill;
            FC.Show();
            panel4.Visible = false;

            NhanVien nv = dt.NhanViens.Where(s => s.Ma == Convert.ToInt32(FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap)).FirstOrDefault();
            label2.Text = "Xin chào " + nv.Ten;
            if (nv.Ma_CV == 1)
            {
                btnQuanLyDuLieu.Visible = true;
                btnQuanLyNhapHang.Visible = true;
                btnQuanLyBanHang.Visible = true;
                btnThongKe.Visible = true;
                btnCauHinhEmail.Visible = true;
                btnBackUp.Visible = true;
            }    
            else if (nv.Ma_CV == 2)
            {
                btnQuanLyDuLieu.Visible = false;
                btnQuanLyNhapHang.Visible = false;
                btnQuanLyBanHang.Visible = true;
                btnThongKe.Visible = false;
                btnCauHinhEmail.Visible = false;
                btnBackUp.Visible = false;
            }
            else if (nv.Ma_CV ==3)
            {
                btnQuanLyDuLieu.Visible = false;
                btnQuanLyNhapHang.Visible = false;
                btnQuanLyBanHang.Visible = false;
                btnThongKe.Visible = true;
                btnCauHinhEmail.Visible = false;
                btnBackUp.Visible = false;
            }    
            int KH =0;
            foreach(var kh in dt.KhachHangs)
            {
                KH = KH + 1;
            }
            lbTongKhachHang.Text = KH.ToString();
            // int DoanhThu = 0;
            var DoanhThu = dt.DoanhThuNamHienTai().FirstOrDefault();
            lbDoanhThu.Text = Convert.ToInt32(DoanhThu.TongTien).ToString("N0");
            var HD = dt.SoLuongHDXDaBan().FirstOrDefault();
            lbSoLuongHoaDon.Text = Convert.ToInt32(HD.SoLuong).ToString("N0");
        }

        private void btnThongTinSanPham_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            hidemenu();
            FormThongTinSP TTSP = new FormThongTinSP();
            TTSP.Show();
        }

        private void btnThongTinNhaCungCap_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            hidemenu();
            FormThongTinNCC TTNCC = new FormThongTinNCC();
            TTNCC.Show();
        }

        private void btnDuLieuNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            hidemenu();
            FormDuLieuNV DLNV = new FormDuLieuNV();
            DLNV.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinNV TTNV = new FormThongTinNV();
            TTNV.Show();
            ThongTinCaNhan.SuaTTCaNhan = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormNhapHang FNH = new FormNhapHang();
            FNH.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            showmenu(pnBanHang);
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            FormKiemTraKhachHang FKTKH = new FormKiemTraKhachHang();
            FKTKH.Show();
            this.Hide();
        }

        private void btnThongTinPhieuNhap_Click(object sender, EventArgs e)
        {
            FormHDN HDN = new FormHDN();
            HDN.Show();
            this.Hide();
        }

        private void btnThongTinHoaDon_Click(object sender, EventArgs e)
        {
            FormHDX FHDX = new FormHDX();
            FHDX.Show();
            this.Hide();
        }

        private void btnThongTinKhachHang_Click(object sender, EventArgs e)
        {
            FormThongTinKhachHang FTTKH = new FormThongTinKhachHang();
            FTTKH.Show();
            this.Hide();
        }

        private void btnCauHinhEmail_Click(object sender, EventArgs e)
        {
            showmenu(panel2);
            FormCauHinhEmail FCHE = new FormCauHinhEmail();
            FCHE.ShowDialog();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            FormBackUpDuLieu FBKDL = new FormBackUpDuLieu();
            FBKDL.ShowDialog();

        }

        private void btnFaceBook_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com/");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            showmenu(panel3);
        }

        private void btnTongquan_Click(object sender, EventArgs e)
        {
            FormThongKeKhachHang FTT = new FormThongKeKhachHang();
            FTT.Show();
            this.Hide();
        }

        private void btnThongKeThuChi_Click(object sender, EventArgs e)
        {
            FormThongKeThuChi FTTTC = new FormThongKeThuChi();
            FTTTC.Show();
            this.Hide();
        }
        int i = 0;
        private void btnChat_Click(object sender, EventArgs e)
        {
   
            i++;
            if (i%2 != 0)
            {
                panel4.Visible = true;
                
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void btnThongKeTonKho_Click(object sender, EventArgs e)
        {            
            FormThongKeTonKho FTKTK = new FormThongKeTonKho();
            FTKTK.Show();
            this.Hide();
        }

    }
}
