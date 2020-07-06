using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormCauHinhEmail : Form
    {
        public FormCauHinhEmail()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void FormCauHinhEmail_Load(object sender, EventArgs e)
        {
            var Email = dt.Emails.Where(s => s.Ma == 1).FirstOrDefault();
            txtEmail.Text = Email.TaiKhoan;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var Email = dt.Emails.Where(s => s.Ma == 1).FirstOrDefault();
            if (txtMatKhau.Text.Trim() != txtXacNhanMatKhau.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không trùng\nVui lòng kiểm tra lại", "Lỗi");
            }    
            else if (txtEmail.Text.Trim() ==""||txtEmail.Text == null || txtMatKhau.Text.Trim() == "" || txtMatKhau.Text == null )
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thiếu thông tin");
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
                        txtEmail.Focus();
                    }
                    else
                    {
                        if (txtEmail.Text.Trim()!= Email.TaiKhoan)
                        {
                            DialogResult a = MessageBox.Show("Bạn có chắc thay đổi Email ???", "Thay đổi Email", MessageBoxButtons.YesNo);
                            if (a==DialogResult.Yes)
                            {
                                dt.updateEmail(txtEmail.Text, txtMatKhau.Text.Trim());
                                MessageBox.Show("Cập nhật Email thành công", "Thành công");
                                this.Close();
                            }    
                        }
                        else
                        {
                            dt.updateEmail(txtEmail.Text, txtMatKhau.Text.Trim());
                            MessageBox.Show("Cập nhật Email thành công", "Thành công");
                            this.Close();
                        }

                    }
                }
            }
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

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
