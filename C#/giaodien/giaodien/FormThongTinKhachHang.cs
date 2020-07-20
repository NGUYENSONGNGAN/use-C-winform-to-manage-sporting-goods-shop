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
    public partial class FormThongTinKhachHang : Form
    {
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
            this.Close();
        }
        int i ;
        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loaiKH_FormThongTinKhachHang.LoaiKH' table. You can move, or remove it, as needed.
            this.loaiKHTableAdapter.Fill(this.loaiKH_FormThongTinKhachHang.LoaiKH);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            txtTen.Enabled = false;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            lbMaKH.Visible = false;
            lbDiemTichLuy.Visible = false;
            lbThanhVien.Visible = false;

            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = dt.KhachHangs;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            i = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            var r = from s in dt.KhachHangs select s.Ma;
            if (r.Count() == 0)
            {
                lbMaKH.Text = "1";
            }
            else if (r.Count() != 0)
            {
                lbMaKH.Text = Convert.ToString(Convert.ToInt32(r.Max().ToString()) + 1);
               // int a = Convert.ToInt32()
            }
            lbDiemTichLuy.Text = "0";
            lbThanhVien.Text = "Bạc";
            lbMaKH.Visible = true;
            lbDiemTichLuy.Visible = true;
            lbThanhVien.Visible = true;
            txtTen.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtTen.ResetText();
            txtEmail.ResetText();
            txtSoDienThoai.ResetText();
            txtDiaChi.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            i = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtTen.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lbMaKH.Visible = false;
            lbDiemTichLuy.Visible = false;
            lbThanhVien.Visible = false;
            txtTen.ResetText();
            txtEmail.ResetText();
            txtSoDienThoai.ResetText();
            txtDiaChi.ResetText();
            txtTen.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = dgvKhachHang.CurrentRow.Index;
            lbMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            txtSoDienThoai.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            lbDiemTichLuy.Text = dgvKhachHang.Rows[r].Cells[5].Value.ToString();
            KhachHang KH = dt.KhachHangs.Where(s => s.Ma == Convert.ToInt32(lbMaKH.Text)).FirstOrDefault();
            LoaiKH Loai = dt.LoaiKHs.Where(s => s.Ma == KH.Ma_LoaiKH).FirstOrDefault();
            lbThanhVien.Text = Loai.Ten;
            lbMaKH.Visible = true;
            lbDiemTichLuy.Visible = true;
            lbThanhVien.Visible = true;
            txtTen.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text ==""|| txtTen.Text == null|| txtEmail.Text == ""|| txtEmail.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập đủ\nVui lòng kiểm tra lại", "Thiếu thông tin");
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
                        if ( txtDiaChi.Text.Trim() == "" || txtSoDienThoai.Text.Trim() == "")
                        {
                            DialogResult kiemtra = MessageBox.Show("Bạn chưa nhập đủ thông tin\nBạn có muốn tiếp tục không ?", "Thiếu thông tin", MessageBoxButtons.YesNo);
                            if (kiemtra == DialogResult.Yes)
                            {
                                if (i == 1)
                                {
                                    dt.insertKH(Convert.ToInt32(lbMaKH.Text), txtTen.Text, txtEmail.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                                    MessageBox.Show("Bạn đã thêm thành công");
                                }
                                else if (i == 2)
                                {
                                    dt.updateKH(Convert.ToInt32(lbMaKH.Text), txtTen.Text, txtEmail.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                                    MessageBox.Show("Bạn đã sửa thành công");
                                }
                                dgvKhachHang.DataSource = dt.selectKH();
                                btnThem.Enabled = true;
                                btnSua.Enabled = false;
                                btnLuu.Enabled = false;
                                btnHuy.Enabled = true;
                                txtTen.ResetText();
                                txtEmail.ResetText();
                                txtSoDienThoai.ResetText();
                                txtDiaChi.ResetText();
                                lbMaKH.Visible = false;
                                lbDiemTichLuy.Visible = false;
                                lbThanhVien.Visible = false;
                                txtTen.Enabled = false;
                                txtSoDienThoai.Enabled = false;
                                txtDiaChi.Enabled = false;
                                txtEmail.Enabled = false;
                            }
                        }
                        else 
                        {
                            if (i == 1)
                            {
                                dt.insertKH(Convert.ToInt32(lbMaKH.Text), txtTen.Text, txtEmail.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                                MessageBox.Show("Bạn đã thêm thành công");
                            }
                            else if (i == 2)
                            {
                                dt.updateKH(Convert.ToInt32(lbMaKH.Text), txtTen.Text, txtEmail.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                                MessageBox.Show("Bạn đã sửa thành công");
                            }
                            dgvKhachHang.DataSource = dt.selectKH();
                            btnThem.Enabled = true;
                            btnSua.Enabled = false;
                            btnLuu.Enabled = false;
                            btnHuy.Enabled = true;
                            txtTen.ResetText();
                            txtEmail.ResetText();
                            txtSoDienThoai.ResetText();
                            txtDiaChi.ResetText();
                            lbMaKH.Visible = false;
                            lbDiemTichLuy.Visible = false;
                            lbThanhVien.Visible = false;
                            txtTen.Enabled = false;
                            txtSoDienThoai.Enabled = false;
                            txtDiaChi.Enabled = false;
                            txtEmail.Enabled = false;
                        }
                    }
                }            
            }
        }
    }
}
