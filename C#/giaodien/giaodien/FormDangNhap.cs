//sing DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormDangNhap : Form
    {

        public class ThongTinNVDangNhap
        {
            public static int MaNVDangNhap;
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();


        public FormDangNhap()
        {
            InitializeComponent();
        }

        string TKdoimk = "";

        public string MaHoa(string txt)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            txt = sb.ToString();
            return txt;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            pnDangNhap.Focus();
            txtTaiKhoan.Focus();
        }
        int manv = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NhanVien nv =  dt.NhanViens.Where(s=>s.taikhoan == txtTaiKhoan.Text.Trim()).Where(s=>s.matkhau == MaHoa(txtMatKhau.Text.Trim())).FirstOrDefault();
            if (nv== null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng\nVui lòng kiểm tra lại");
            }
            else
            {
                if (nv.HoatDong == Convert.ToBoolean("False"))
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa\nLiên hệ quản lý để được hỗ trợ", "Lỗi");
                } 
                else if (nv.HoatDong == Convert.ToBoolean("True"))
                {
                    ThongTinNVDangNhap.MaNVDangNhap = nv.Ma;
                    MessageBox.Show("Chào mừng bạn đến DHV Sport");
                    this.Hide();
                    FormTrangChu f1 = new FormTrangChu();
                    f1.Show();
                }    
            }               
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            txtEmail.ResetText();
      //      txtQuenTaiKhoan.Focus();
            if (pnQuenMatKhau.Left == 376)
            {
                pnDangNhap.Visible = false;
                pnDangNhap.Left = 376;            
                pnQuenMatKhau.Left = 2;
                pnQuenMatKhau.Visible = true;
                pnQuenMatKhau.Refresh();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            if (pnQuenMatKhau.Left == 2)
            {                
                pnDangNhap.Visible = true;
                pnQuenMatKhau.Visible = false;
                pnDangNhap.Left = 2;
                pnQuenMatKhau.Left = 376;
                pnDangNhap.Refresh();
            }
        }

        private void btnQuayLaiDangNhap_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.ResetText();
            txtMatKhau.ResetText();
            txtTaiKhoan.Focus();
            if (pnQuayLaiDangNhap.Left == 2)
            {
                pnDangNhap.Visible = true;
                pnQuenMatKhau.Visible = false;
                pnQuayLaiDangNhap.Visible = false;
                pnDangNhap.Left = 2;
                pnQuenMatKhau.Left = 376;
                pnDangNhap.Refresh();
            }
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtMaXacMinh.ResetText();
            txtMatKhauMoi.ResetText();
            txtEmail.Focus();
            var Email = dt.Emails.Where(s=>s.Ma ==1).FirstOrDefault();
           
            NhanVien nv = dt.NhanViens.Where(s => s.Email == txtEmail.Text.Trim()).FirstOrDefault();
            
            if (nv==null)
            {
                MessageBox.Show("Tài khoản hoặc email chưa đúng !!!\nVui lòng kiểm tra lại", "Lỗi");
            }
            else
            {
                manv = nv.Ma;
                TKdoimk = nv.Ten;
                string bodyemail = "Xin Chào " + nv.Ten + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hỗ Trợ Của Bạn: \n\n"
                                    + "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
                                    + "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
                                    + "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
                                    + "\t\t Tài khoản đăng nhập của bạn là: "+ nv.taikhoan+"\n"
                                    + "\t\t=> Mã Xác Minh Của Bạn Là: " + nv.matkhau.Remove(6, 26)
                                    + "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu\n"
                                    + "Chúc bạn thành công";
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(Email.TaiKhoan);
                    mail.To.Add(nv.Email);
                    mail.Subject = "DHV Sport - Số 1 về thể thao";
                    mail.Body = bodyemail;
                    SmtpClient smptClient = new SmtpClient();
                    smptClient.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential credential = new NetworkCredential();
                    credential.UserName = Email.TaiKhoan;
                    credential.Password = Email.MatKhau;
                    smptClient.Credentials = credential;
                    smptClient.Port = 587;
                    smptClient.EnableSsl = true;
                    smptClient.Send(mail);
                    MessageBox.Show("Đã gửi mã xác minh về Email\nMời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
                    if (pnQuenMatKhau.Left == 2)
                    {
                        pnDangNhap.Visible = false;
                        pnQuenMatKhau.Visible = false;
                        pnQuayLaiDangNhap.Visible = true;
                        pnQuayLaiDangNhap.Left = 2;
                        pnDangNhap.Left = 2;
                        pnQuenMatKhau.Left = 376;
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Kiểm tra lại mạng hoặc thông tin Email\nHoặc liên hệ với người quản trị", "Lỗi");
                }
            }                  
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            NhanVien nv = dt.NhanViens.Where(s => s.matkhau.Remove(6, 26) == txtMaXacMinh.Text.Trim()).Where(s=>s.Ma == manv).FirstOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Bạn Đã Nhập Sai Mã Xác Minh Vui Lòng Check Mail Hoặc Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                dt.updatemkmahoa(nv.Ma, MaHoa(txtMatKhauMoi.Text.Trim()));
                MessageBox.Show("Bạn đã đổi mật khẩu thành công");
                pnQuayLaiDangNhap.Visible = false;
                pnDangNhap.Visible = true;
                txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
            }
        }

        private void pnDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]

                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|

                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Lỗi định dạng email", "Lỗi");
                    txtEmail.Focus();
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}