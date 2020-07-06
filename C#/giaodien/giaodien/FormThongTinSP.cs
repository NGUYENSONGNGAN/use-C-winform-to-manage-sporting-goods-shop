//using DevExpress.DataAccess.Native.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormThongTinSP : Form
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public FormThongTinSP()
        {
            InitializeComponent();
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        int themsua;
        private void FormThongTinSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loaiSP_FormThongTinSP.LoaiSP' table. You can move, or remove it, as needed.
            this.loaiSPTableAdapter.Fill(this.loaiSP_FormThongTinSP.LoaiSP);
            treeView1.Nodes.Clear();
            foreach (var a in dt.selectLoaiSP())
            {
                TreeNode b = new TreeNode();
                b.Name = a.Ma.ToString();
                b.Text = a.Ten;
                treeView1.Nodes.Add(b);
            }
            // TODO: This line of code loads data into the 'loai_SP.LoaiSP' table. You can move, or remove it, as needed.
            btnChonAnh.Visible = false;
            cbbLoai.ValueMember = "Ma";
            cbbLoai.DisplayMember = "Ten";
            cbbLoai.DataSource = dt.selectLoaiSP();

            pic_SanPham.Image = null;
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = dt.selectSP();

            lbMa.Visible = false;
            lbSoMa.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            cbbLoai.Enabled = false;
            txtTen.Enabled = false;
            txtDonGia.Enabled = false;
            txtDonGia.ResetText();
            txtTen.ResetText();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach(var a in dt.LoaiSPs.Where(s=>s.Ma == Convert.ToInt32( e.Node.Name)))
            {
                dgvSanPham.DataSource = dt.SanPhams.Where(s => s.Ma_LoaiSP == a.Ma);
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themsua = 1;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnChonAnh.Visible = true;
            txtTen.ResetText();
            txtDonGia.ResetText();
            pic_SanPham.Image = null;
          
            lbMa.Visible = true;
            lbSoMa.Visible = true;
            cbbLoai.Enabled = true;
            txtTen.Enabled = true;
            txtDonGia.Enabled = true;
            txtTen.Focus();
            var r = from s in dt.SanPhams select s.Ma;
            lbSoMa.Text = Convert.ToString(Convert.ToInt32(r.Max().ToString()) + 1);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChu ftc = new FormTrangChu();
            ftc.Show();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbLoai.Enabled = false;
            txtDonGia.Enabled = false;
            txtTen.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnChonAnh.Visible = false;
            int r = dgvSanPham.CurrentRow.Index;
            lbSoMa.Text = dgvSanPham.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dgvSanPham.Rows[r].Cells[1].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[r].Cells[2].Value.ToString();
            cbbLoai.SelectedValue = Convert.ToInt32( dgvSanPham.Rows[r].Cells[3].Value.ToString());
            SanPham sp = dt.SanPhams.Where(s => s.Ma == Convert.ToInt32(lbSoMa.Text)).FirstOrDefault();
            if (sp == null || sp.HinhAnh == null)
            {
                pic_SanPham.Image = null;
            }
            else
            {
                MemoryStream img = new MemoryStream(sp.HinhAnh.ToArray());
                Image i = Image.FromStream(img);
                if (i == null)
                {
                    pic_SanPham.Image = null;
                }
                else
                {
                    pic_SanPham.Image = i;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themsua = 2;
            cbbLoai.Enabled = true;
            txtTen.Enabled = true;
            txtDonGia.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnChonAnh.Visible = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text ==""||txtTen.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin\n Vui lòng kiển tra lại", "Lỗi");
            }    
            else
            {
                if (themsua ==1)
                {
                    if (pic_SanPham.Image == null)
                    {
                        DialogResult a = MessageBox.Show("Bạn chưa có hình sản phẩm này\nBạn có muốn tiếp tục không","Thiếu thông tin", MessageBoxButtons.YesNo);
                        if (a== DialogResult.Yes)
                        {
                            SanPham sp = dt.SanPhams.Where(s => s.Ten == txtTen.Text).FirstOrDefault();
                            if (sp!= null)
                            {
                                DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn thêm không", "Trùng tên", MessageBoxButtons.YesNo);
                                if (b== DialogResult.Yes)
                                {
                                    dt.insertSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), null);
                                    MessageBox.Show("Bạn đã thêm thành công");
                                    FormThongTinSP_Load(sender, e);
                                    themsua = 0;
                                }    
                            }    
                            else if (sp == null)
                            {
                                dt.insertSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), null);
                                MessageBox.Show("Bạn đã thêm thành công");
                                FormThongTinSP_Load(sender, e);
                                themsua = 0;
                            }                            
                        }    
                    }
                    else if (pic_SanPham.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        pic_SanPham.Image.Save(stream, ImageFormat.Jpeg);

 
                        SanPham sp = dt.SanPhams.Where(s => s.Ten == txtTen.Text)
                                                .FirstOrDefault();
                        
                        if (sp!= null)
                        {
                            DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn thêm không", "Trùng tên", MessageBoxButtons.YesNo);
                            if (b == DialogResult.Yes)
                            {
                                dt.insertSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), stream.ToArray());
                                MessageBox.Show("Bạn đã thêm thành công");
                                FormThongTinSP_Load(sender, e);
                                themsua = 0;
                            }
                        }
                        else if (sp == null)
                        {
                            dt.insertSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), stream.ToArray());
                            MessageBox.Show("Bạn đã thêm thành công");
                            FormThongTinSP_Load(sender, e);
                            themsua = 0;
                        }
                    }    
                    //dt.insertSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text));
                }
                else if (themsua ==2)
                {
                    if (pic_SanPham.Image == null)
                    {
                        DialogResult a = MessageBox.Show("Bạn chưa có hình sản phẩm này\nBạn có muốn tiếp tục không", "Thiếu thông tin", MessageBoxButtons.YesNo);
                        if (a == DialogResult.Yes)
                        {
                            SanPham sp = dt.SanPhams.Where(s => s.Ten == txtTen.Text)
                                                .Where(s => s.Ma != Convert.ToInt32(lbSoMa.Text))
                                                .FirstOrDefault();
                            if (sp != null)
                            {
                                DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn tiếp tục không", "Trùng tên", MessageBoxButtons.YesNo);
                                if (b == DialogResult.Yes)
                                {
                                    dt.updateSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), null);
                                    MessageBox.Show("Bạn đã sửa thành công");
                                    FormThongTinSP_Load(sender, e);
                                    themsua = 0;
                                }
                            }
                            else if (sp == null)
                            {
                                dt.updateSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), null);
                                MessageBox.Show("Bạn đã sửa thành công");
                                FormThongTinSP_Load(sender, e);
                                themsua = 0;
                            }
                        }
                    }
                    else if (pic_SanPham.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        pic_SanPham.Image.Save(stream, ImageFormat.Jpeg);
                        SanPham sp = dt.SanPhams.Where(s => s.Ten == txtTen.Text)
                                                .Where(s => s.Ma != Convert.ToInt32(lbSoMa.Text))
                                                .FirstOrDefault();
                        if (sp != null)
                        {
                            DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn thêm không", "Trùng tên", MessageBoxButtons.YesNo);
                            if (b == DialogResult.Yes)
                            {
                                dt.updateSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), stream.ToArray());
                                MessageBox.Show("Bạn đã sửa thành công");
                                FormThongTinSP_Load(sender, e);
                                themsua = 0;
                            }
                        }
                        else if (sp == null)
                        {
                            dt.updateSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text), stream.ToArray());
                            MessageBox.Show("Bạn đã sửa thành công");
                            FormThongTinSP_Load(sender, e);
                            themsua = 0;
                        }
                    }
                }    
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormThongTinSP_Load(sender, e);
            txtTimKiem.ResetText();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
            if (a.ShowDialog() == DialogResult.OK)
            {
                pic_SanPham.Image = new Bitmap(a.FileName);
                pic_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "" || txtTimKiem.Text == null)
            {
                dgvSanPham.DataSource = dt.SanPhams;
            }    
            else
            {
                dgvSanPham.DataSource = dt.TKSP(txtTimKiem.Text);
            }    
        }

        private void cbbLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {

        }

        private void txtDonGia_OnValueChanged(object sender, EventArgs e)
        {
        //    txtDonGia.Text.ToString("N0", culture);
        }
    }
}
