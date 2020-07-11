using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormDangNhapClient : Form
    {
        public FormDangNhapClient()
        {
            InitializeComponent();
        }
        public class TTKH
        {
            public static int MaKH;
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var KH = dt.KhachHangs.Where(s => s.Ten == txtTen.Text.Trim()).Where(s=>s.Email == txtEmail.Text.Trim()).FirstOrDefault();
            if (KH == null)
            {
                MessageBox.Show("Thông tin không đúng\nVui lòng kiểm tra lại", "Lỗi");
            }    
            else if (KH!= null)
            {
                TTKH.MaKH = Convert.ToInt32(KH.Ma);
                FormChatClient FCCL = new FormChatClient();
                FCCL.Show();
                this.Hide();
            }    
        }
    }
}
