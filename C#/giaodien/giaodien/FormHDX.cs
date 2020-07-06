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
    public partial class FormHDX : Form
    {
        public FormHDX()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public class TTHDX
        {
            public static int MaHDX;
            public static int MoFormRP;
        }
        private void FormHDX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVien_FormHDX.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVien_FormHDX.NhanVien);
            // TODO: This line of code loads data into the 'khachHang_FormHDX.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.khachHang_FormHDX.KhachHang);

            dgvHDX.AutoGenerateColumns = false;
            dgvHDX.DataSource = dt.HDXuats;
            dgvHDX.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim()==null||txtTimKiem.Text.Trim()=="")
            {
                dgvHDX.DataSource = dt.HDXuats;
            }    
            else if (txtTimKiem.Text.Trim()!=null)
            {
                dgvHDX.DataSource = dt.TKHDX(txtTimKiem.Text);
            }    
        }

        private void dgvHDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDX.Columns[e.ColumnIndex].Name == "Xem")
            {
                int Ma = Convert.ToInt32(dgvHDX.Rows[e.RowIndex].Cells[0].Value.ToString());
                TTHDX.MaHDX = Ma;
                TTHDX.MoFormRP = 1;
                FormRePortHDX FRPHDX = new FormRePortHDX();
                FRPHDX.ShowDialog();
            }
        }
    }
}
