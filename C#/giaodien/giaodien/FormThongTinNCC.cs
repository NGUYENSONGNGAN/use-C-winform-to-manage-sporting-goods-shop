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
    public partial class FormThongTinNCC : Form
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();
        int i = 0;
        public FormThongTinNCC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMa.Enabled = false;
            lbSoMa.Enabled = false;
            lbMa.Visible = false;
            lbSoMa.Visible = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenNhaCungCap.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            dgvNCC.DataSource = dt.selectncc();

        //    dgvNCC.BorderStyle = BorderStyle.None;
        //    //màu dòng chẵn
        //    dgvNCC.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
        ////    dgvNCC.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
        //    dgvNCC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        //    //Mau o khi click
        //    dgvNCC.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
        //    //color chữ khi click
        //    dgvNCC.DefaultCellStyle.SelectionForeColor = Color.Red;
        //    //back groud
        //    dgvNCC.BackgroundColor = Color.Red;

        //    dgvNCC.EnableHeadersVisualStyles = false;
        //    dgvNCC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //    //Mau title
        //    dgvNCC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
        //    //mau chu title
        //    dgvNCC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        //  //  dgvNCC.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        }

   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không ???", "Xóa", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                dt.deletencc(Convert.ToInt32(lbSoMa.Text));
                lbMa.Enabled = false;
                lbSoMa.Enabled = false;
                lbMa.Visible = false;
                lbSoMa.Visible = false;
                txtDiaChi.Enabled = false;
                txtSoDienThoai.Enabled = false;
                txtTenNhaCungCap.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = true;
                dgvNCC.DataSource = dt.selectncc();
            }
        }


        private void txtSoDienThoai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {      
            if (FormNhapHang.MoFormTTNCC.MoFormNCC ==1)
            {
                
                FormNhapHang.MoFormTTNCC.MoFormNCC = 0;
                FormNhapHang FNH = new FormNhapHang();
                FNH.Show();
                this.Close();
            }
            else if (FormNhapHang.MoFormTTNCC.MoFormNCC !=1)
            {
                FormTrangChu ftc = new FormTrangChu();
                ftc.Show();
                this.Close();
            }
        }

        private void dgvNCC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNCC.CurrentRow.Index;
            lbSoMa.Text = dgvNCC.Rows[r].Cells[0].Value.ToString();
            txtTenNhaCungCap.Text = dgvNCC.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[r].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvNCC.Rows[r].Cells[3].Value.ToString();
            btnSua.Enabled = true;

            lbMa.Visible = true;
            lbSoMa.Visible = true;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenNhaCungCap.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            i = 1;
            var r = from s in dt.NhaCungCaps select s.Ma;
            if (dt.NhaCungCaps == null)
            {
                lbSoMa.Text = "1";
            }
            else
            {
                lbSoMa.Text = Convert.ToString(Convert.ToInt32(r.Max().ToString()) + 1);
            }
            
            lbMa.Visible = true;
            lbSoMa.Visible = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtTenNhaCungCap.Enabled = true;
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();
            txtTenNhaCungCap.ResetText();
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            dgvNCC.DataSource = dt.selectncc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            i = 2;
            txtTenNhaCungCap.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTenNhaCungCap.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvNCC.DataSource = dt.selectncc();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || txtTenNhaCungCap.Text == "")
                {

                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    dt.insertncc(Convert.ToInt32(lbSoMa.Text), txtTenNhaCungCap.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                    MessageBox.Show("Thêm thành công", "Thành công");

                    i = 0;
                    lbMa.Enabled = false;
                    lbSoMa.Enabled = false;
                    lbMa.Visible = false;
                    lbSoMa.Visible = false;
                    txtDiaChi.Enabled = false;
                    txtSoDienThoai.Enabled = false;
                    txtTenNhaCungCap.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = true;
                    txtTenNhaCungCap.ResetText();
                    txtDiaChi.ResetText();
                    txtSoDienThoai.ResetText();
                    dgvNCC.DataSource = dt.selectncc();
                }
            }
            else if (i == 2)
            {
                if (txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || txtTenNhaCungCap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    dt.updatencc(Convert.ToInt32(lbSoMa.Text), txtTenNhaCungCap.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                    MessageBox.Show("Sửa thành công", "Thành công");

                    i = 0;
                    lbMa.Enabled = false;
                    lbSoMa.Enabled = false;
                    lbMa.Visible = false;
                    lbSoMa.Visible = false;
                    txtDiaChi.Enabled = false;
                    txtSoDienThoai.Enabled = false;
                    txtTenNhaCungCap.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = true;
                    txtTenNhaCungCap.ResetText();
                    txtDiaChi.ResetText();
                    txtSoDienThoai.ResetText();
                    dgvNCC.DataSource = dt.selectncc();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            i = 0;
            lbSoMa.Text = "";
            lbMa.Enabled = false;
            lbSoMa.Enabled = false;
            lbMa.Visible = false;
            lbSoMa.Visible = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenNhaCungCap.Enabled = false;
            txtTenNhaCungCap.ResetText();
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            dgvNCC.DataSource = dt.selectncc();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == null || txtTimKiem.Text == "")
            {
                dgvNCC.DataSource = dt.NhaCungCaps;
            }
            else
            {
                dgvNCC.DataSource = dt.TKNCC(txtTimKiem.Text);
            }
        }
    }
}