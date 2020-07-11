using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormKhachHangMoi : Form
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public class TTKHM
        {
            public static int Ma=0;
        }
        public FormKhachHangMoi()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormKhachHangMoi_Load(object sender, EventArgs e)
        {
            KhachHang KH = dt.KhachHangs.FirstOrDefault();         
            if (KH == null)
            {
                lbSoMa.Text = "1";
            }
            else 
            {
                var r = from s in dt.KhachHangs select s.Ma;
                lbSoMa.Text = Convert.ToString(Convert.ToInt32(r.Max().ToString()) + 1);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtTen.Text.Trim() =="" || txtTen.Text.Trim() == null|| txtEmail.Text.Trim() == null)
            {
                MessageBox.Show("Bạn chưa nhập tên hoặc gmail");
            }
            else
            {
                if ( txtDiaChi.Text == "" || txtSoDienThoai.Text == "")
                {
                    DialogResult a = MessageBox.Show("Bạn chưa nhập đủ thông tin\nBạn có muốn tiếp tục không?", "Thiếu thông tin", MessageBoxButtons.YesNo);
                    if (a == DialogResult.Yes)
                    {
                        if (txtEmail.Text.Trim() != "")
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
                                else
                                {
                                    dt.insertKH(Convert.ToInt32(lbSoMa.Text), txtTen.Text, txtEmail.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                                    MessageBox.Show("Thêm khách hàng thành công", "Thành công");
                                    TTKHM.Ma = Convert.ToInt32(lbSoMa.Text);
                                    FormLapHoaDon FLHD = new FormLapHoaDon();
                                    FLHD.Show();
                                    this.Close();
                                }
                            }
                        }
                        else if (txtEmail.Text.Trim() == "")
                        {
                            dt.insertKH(Convert.ToInt32(lbSoMa.Text), txtTen.Text, txtEmail.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                            MessageBox.Show("Thêm khách hàng thành công", "Thành công");
                            TTKHM.Ma = Convert.ToInt32(lbSoMa.Text);
                            FormLapHoaDon FLHD = new FormLapHoaDon();
                            FLHD.Show();
                            this.Close();
                        }
                    }
                }
                else
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
                        else
                        {
                            dt.insertKH(Convert.ToInt32(lbSoMa.Text), txtTen.Text, txtEmail.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                            MessageBox.Show("Thêm khách hàng thành công", "Thành công");
                            TTKHM.Ma = Convert.ToInt32(lbSoMa.Text);
                            FormLapHoaDon FLHD = new FormLapHoaDon();
                            FLHD.Show();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            FormKiemTraKhachHang FKTKH = new FormKiemTraKhachHang();
            FKTKH.Show();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }
    }
}
