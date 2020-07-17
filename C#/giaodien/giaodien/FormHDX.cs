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
            public static int MoFormGhiChuHuy;
        }
        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormQuetQRTimKiemHDX FQQRTK = new FormQuetQRTimKiemHDX();
            FQQRTK.Show();
            this.Close();
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == null || txtTimKiem.Text.Trim() == "")
            {
                dgvHDX.DataSource = dt.HDXuats;
            }
            else if (txtTimKiem.Text.Trim() != null)
            {
                dgvHDX.DataSource = dt.TKHDX(txtTimKiem.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
            this.Close();
        }

        private void dgvHDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDX.Columns[e.ColumnIndex].Name == "Xem")
            {
                int Ma = Convert.ToInt32(dgvHDX.Rows[e.RowIndex].Cells[0].Value.ToString());
                TTHDX.MaHDX = Ma;
                TTHDX.MoFormRP = 1;
                FormRPHDX FRPHDX = new FormRPHDX();
                FRPHDX.ShowDialog();
            }
            else if (dgvHDX.Columns[e.ColumnIndex].Name == "ThayDoiTrangThai")
            {
                int Ma = Convert.ToInt32(dgvHDX.Rows[e.RowIndex].Cells[0].Value.ToString());
                var tthdx = dt.HDXuats.Where(s => s.Ma == Ma).FirstOrDefault();
                if (tthdx.TrangThai == Convert.ToBoolean("False"))
                {
                    MessageBox.Show("Hóa đơn đã hủy");
                }

                else if (tthdx.TrangThai == Convert.ToBoolean("True"))
                {
                    if (DateTime.Now.DayOfYear - Convert.ToDateTime(tthdx.NgayXuat).DayOfYear <= 2)
                    {
                        TTHDX.MaHDX = Ma;
                        TTHDX.MoFormGhiChuHuy = 1;
                        FormGhiChuHuyHDX FGCHHDX = new FormGhiChuHuyHDX();
                        FGCHHDX.ShowDialog();
                        if (FormGhiChuHuyHDX.TTDongForm.ThayDoiTrangThaiHDX == 1)
                        {
                            var HDX = dt.selectTTHDX(Ma).FirstOrDefault();
                            var KH = dt.selectTTKH(HDX.Ma_KH).FirstOrDefault();
                            var LKH = dt.LoaiKHs.Where(s => s.Ma == KH.Ma_LoaiKH).FirstOrDefault();
                            if (HDX.TongTien >= 200000)
                            {
                                int DiemTL = Convert.ToInt32(KH.DiemTichLuy) - 10;
                                dt.updatediemtichluy(KH.Ma, DiemTL);
                                if (DiemTL < 200)
                                {
                                    dt.updateKH_LoaiKH(KH.Ma, 1);
                                }
                                else if (DiemTL >= 200 && DiemTL < 400)
                                {
                                    dt.updateKH_LoaiKH(KH.Ma, 2);
                                }
                            }
                            dgvHDX.DataSource = dt.selectHDX();
                            FormGhiChuHuyHDX.TTDongForm.ThayDoiTrangThaiHDX = 0;
                            FGCHHDX.Close();
                        }
                    }
                    else if (DateTime.Now.DayOfYear - Convert.ToDateTime(tthdx.NgayXuat).DayOfYear > 2)
                    {
                        MessageBox.Show("Hóa đơn đã thanh toán trên 2 ngày\nKhông thể hủy", "Thất bại");
                    }
                }
            }
        }
    }
}
