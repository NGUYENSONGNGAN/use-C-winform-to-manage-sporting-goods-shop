using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormHDN : Form
    {
        public FormHDN()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        CultureInfo culture = new CultureInfo("vi-VN");
        private void FormHDN1_Load(object sender, EventArgs e)
        {
            //int a = 20000000;
            //label1.Text = a.ToString("c", culture);
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = dt.HDNhaps;
            // TODO: This line of code loads data into the 'nhanVien_FormHDN.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVien_FormHDN.NhanVien);
            // TODO: This line of code loads data into the 'nhaCungCap_FormHDN.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.nhaCungCap_FormHDN.NhaCungCap);
            //màu dòng chẵn
            //dgvHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            //dgvHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ////Mau o khi click
            //dgvHoaDon.DefaultCellStyle.SelectionBackColor = Color.Orange;
            ////color chữ khi click
            //dgvHoaDon.DefaultCellStyle.SelectionForeColor = Color.Red;
            ////back groud
            //// dgvHoaDon.BackgroundColor = Color.White;
            //dgvHoaDon.EnableHeadersVisualStyles = false;
            //dgvHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ////Mau title
            //dgvHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
            ////mau chu title
            //dgvHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int r = dgvHoaDon.CurrentRow.Index;
            //NhanVien nv = dt.NhanViens.Where(s => s.Ma == Convert.ToInt32(dgvHoaDon.Rows[r].Cells[1].Value.ToString())).FirstOrDefault();

            //lbMaPhieuNhap.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            //lbTenNhanVien.Text = nv.Ten;
            //cbbNhaCungCap.SelectedValue = Convert.ToInt32(dgvHoaDon.Rows[r].Cells[2].Value.ToString());
            //lbTongTien.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();

            //MaHDN = Convert.ToInt32(lbMaPhieuNhap.Text);
            //btnThem.Enabled = true;
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = true; 

            //if (dgvHoaDon.Columns[e.ColumnIndex].Name == "Xem")
            //{
            //    ThongTinHDN.ma_HDN = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
            //    FormNhapHang CTHDN = new FormNhapHang();
            //    CTHDN.Show();
            //    this.Hide();
            //}


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChu FTT = new FormTrangChu();
            FTT.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Trim()==""||txtTimKiem.Text.Trim()==null)
            {
                dgvHoaDon.DataSource = dt.HDNhaps;
            }    
            else if (txtTimKiem.Text.Trim()!= null)
            {
                dgvHoaDon.DataSource = dt.TKHDN(txtTimKiem.Text);
            }    
        }
    }
}
