using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormDoiMatKhau : Form
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

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


        private void btnDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            if(txtXacNhan.Text == ""  || txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
            }
            else
            {
                NhanVien nv = dt.NhanViens.Where(s => s.Ma == FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap).FirstOrDefault();
                if (txtMatKhauMoi.Text.Trim() == txtXacNhan.Text.Trim())
                {
                    dt.updatemkmahoa(nv.Ma, MaHoa(txtMatKhauMoi.Text ));
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công", "");
                    txtMatKhauMoi.ResetText();
                    txtXacNhan.ResetText();
                    this.Close();   
                }
                else
                {
                    MessageBox.Show("Bạn nhập thông tin chưa đúng.\n Kiểm tra lại", "Lỗi");
                }
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
