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
    public partial class FormNhapHang : Form
    {
        public class MoFormTTNCC
        {
            public static int MoFormNCC; 
        }

        public FormNhapHang()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        CultureInfo culture = new CultureInfo("vi-VN");
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
        }

        int i = 0;
        private void FormCTHDNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanPham_FormNhapHang.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sanPham_FormNhapHang.SanPham);
            // TODO: This line of code loads data into the 'sanPham_FormNhapHang.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sanPham_FormNhapHang.SanPham);

            // TODO: This line of code loads data into the 'mau_FormNhapHang.MauSac' table. You can move, or remove it, as needed.
            this.mauSacTableAdapter.Fill(this.mau_FormNhapHang.MauSac);
            // TODO: This line of code loads data into the 'size_FormNhapHang.Size' table. You can move, or remove it, as needed.
            this.sizeTableAdapter.Fill(this.size_FormNhapHang.Size);
            // TODO: This line of code loads data into the 'sanPham_FormNhapHang.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sanPham_FormNhapHang.SanPham);
            dgvCTHDN.AutoGenerateColumns = false;
            dgvCTHDN.DataSource = dt.HDNhaps;
            i = 1;
            dgvCTHDN.AutoGenerateColumns = false;
            //font size data gridview
          //  dgvCTHDN.DefaultCellStyle.Font= new Font("Tahoma", 14);
            //      //// font title datagridview
            dgvCTHDN.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 20);

            dgvCTHDN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var r = from s in dt.HDNhaps select s.Ma;
            lbMaHD.Text = Convert.ToString(Convert.ToInt32(r.Max().ToString()) + 1);
            
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            dgvCTHDN.DataSource = dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text));
            cbbSP.DisplayMember = "Ten";
            cbbSP.ValueMember = "Ma";
            cbbSP.DataSource = dt.SanPhams;

            SanPham sp = dt.SanPhams.Where(s => s.Ma == Convert.ToInt32(cbbSP.SelectedValue)).FirstOrDefault();

            cbbSize.DisplayMember = "TenSize";
            cbbSize.ValueMember = "Ma";
            cbbSize.DataSource = dt.cbbSize(sp.Ma_LoaiSP);

            cbbMau.DisplayMember = "TenMau";
            cbbMau.ValueMember = "Ma";
            cbbMau.DataSource = dt.MauSacs;

            cbbNhaCungCap.DisplayMember = "Ten";
            cbbNhaCungCap.ValueMember = "Ma";
            cbbNhaCungCap.DataSource = dt.selectncc();
            cbbNhaCungCap.Text = "";

            cbbSP.Enabled = false;
            cbbSize.Enabled = false;
            cbbMau.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            
            txtDonGia.ResetText();
            txtSoLuong.ResetText();
            lbThanhTien.Text = "0";
            cbbSP.Text = "";
            cbbSize.Text = "";
            cbbMau.Text = "";
            //   var a = dt.ngaytrongnam_HDN(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();
            //if (DateTime.Now.DayOfYear - a.ngay > 7 || DateTime.Now.Year < a.nam)
            //{
            //    btnThem.Enabled = false;
            //    btnLuu.Enabled = false;
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cbbSP.Enabled = true;
            cbbSize.Enabled = true;
            cbbMau.Enabled = true;

            txtSoLuong.Enabled = true;

            txtSoLuong.ResetText();
            cbbSP.Text = "";
            cbbSize.Text = "";
            cbbMau.Text = "";
            var CTHDN = dt.selectTTCTHDN(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue), 
                                       Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
            if (CTHDN!= null)
            {
                txtDonGia.Enabled = false;
                txtDonGia.Text = CTHDN.DonGia.ToString();
            }    
            else if (CTHDN == null)
            {
                txtDonGia.ResetText();
                txtDonGia.Enabled = true;
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var HDN = dt.selectTTHDN(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();
            var CTSP = dt.selectTTCTSP(Convert.ToInt32(cbbSP.SelectedValue),
                                            Convert.ToInt32(cbbSize.SelectedValue),
                                            Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
                                         
            if (txtDonGia.Text == "" || txtSoLuong.Text == ""|| cbbSP.Text ==""||cbbSize.Text ==""||cbbMau.Text == ""||
                cbbNhaCungCap.Text ==""||Convert.ToInt32( cbbSP.SelectedValue) ==0|| 
                Convert.ToInt32(cbbSize.SelectedValue) == 0|| Convert.ToInt32(cbbMau.SelectedValue) == 0)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin\nVui lòng kiểm tra lại", "Lỗi");
            }   
            else if (Convert.ToInt32(txtDonGia.Text) ==0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi");
            }
            else if (Convert.ToInt32(txtSoLuong.Text) ==0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi");
            }     
            else if (HDN == null)
            {
                dt.insertHDN(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbNhaCungCap.SelectedValue), FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap,
                             Convert.ToDateTime(DateTime.Now), 0);
                dt.insertCTHDN(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                               Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text),
                               Convert.ToInt32(txtSoLuong.Text)* Convert.ToInt32(txtDonGia.Text));
                dt.updatetongtienHDN(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                
                if (CTSP == null)
                {
                    dt.insertCTSP(Convert.ToInt32(cbbSP.SelectedValue),
                             Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue),0);
                }
                var CTSP1 = dt.selectTTCTSP(Convert.ToInt32(cbbSP.SelectedValue),
                                           Convert.ToInt32(cbbSize.SelectedValue),
                                           Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
                                            
                dt.updateSLT(Convert.ToInt32(cbbSP.SelectedValue),
                             Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue),
                            (Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(CTSP1.Soluong)));
                MessageBox.Show("Bạn đã thêm thành công");
                txtSoLuong.ResetText();
                txtDonGia.ResetText();
                lbThanhTien.Text = "0";
                dgvCTHDN.DataSource = dt.CTHDNhaps.Where(s => s.Ma_HDN == Convert.ToInt32(lbMaHD.Text));
                cbbNhaCungCap.Enabled = false;
                btnThemNCC.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                cbbSP.Text = "";
                cbbSP.Enabled = false;
                cbbSize.Text = "";
                cbbSize.Enabled = false; 
                cbbMau.Text = "";
                cbbMau.Enabled = false;
                txtSoLuong.Enabled = false;
                txtDonGia.Enabled = false;
            }
            else if (HDN != null)
            {               
                var CTHDN = dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();
                if (CTHDN == null)
                {
                    dt.insertCTHDN(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                   Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text),
                                   Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                    int tongtien = 0;
                    foreach (var a in dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text)))
                    {
                        tongtien = tongtien + Convert.ToInt32(a.ThanhTien) + 0;
                    }
                    dt.updatetongtienHDN(Convert.ToInt32(lbMaHD.Text), tongtien);
                    if (CTSP == null)
                    {
                        dt.insertCTSP(Convert.ToInt32(cbbSP.SelectedValue),
                                 Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue), 0);
                    }
                    var CTSP1 = dt.selectTTCTSP(Convert.ToInt32(cbbSP.SelectedValue),
                                                      Convert.ToInt32(cbbSize.SelectedValue),
                                                      Convert.ToInt32(cbbMau.SelectedValue))
                                                      .FirstOrDefault();
                    dt.updateSLT(Convert.ToInt32(cbbSP.SelectedValue),
                                 Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue),
                                (Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(CTSP1.Soluong)));
                    MessageBox.Show("Bạn đã thêm thành công");
                    txtSoLuong.ResetText();
                    txtDonGia.ResetText();
                    lbThanhTien.Text = "0";                        
                    cbbNhaCungCap.Enabled = false;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    cbbSP.Text = "";
                    cbbSP.Enabled = false;
                    cbbSize.Text = "";
                    cbbSize.Enabled = false;
                    cbbMau.Text = "";
                    cbbMau.Enabled = false;
                    txtSoLuong.Enabled = false;
                    txtDonGia.Enabled = false;
                }
                else if (CTHDN != null)
                {
                    var CTHDN1 = dt.selectTTCTHDN(Convert.ToInt32(lbMaHD.Text),
                                                       Convert.ToInt32(cbbSP.SelectedValue),
                                                       Convert.ToInt32(cbbSize.SelectedValue),
                                                       Convert.ToInt32(cbbMau.SelectedValue))
                                                  .FirstOrDefault();
                    if (CTHDN1  == null)
                    {
                        dt.insertCTHDN(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                       Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text),
                                       Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                        int tongtien = 0;
                        foreach (var a in dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text)))
                        {
                            tongtien = tongtien + Convert.ToInt32(a.ThanhTien) + 0;
                        }
                        dt.updatetongtienHDN(Convert.ToInt32(lbMaHD.Text), tongtien);
                        if (CTSP == null)
                        {
                            dt.insertCTSP(Convert.ToInt32(cbbSP.SelectedValue),
                                     Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue), 0);
                        }
                        CTSanPham CTSP1 = dt.CTSanPhams.Where(s => s.Ma_SP == Convert.ToInt32(cbbSP.SelectedValue))
                                 .Where(s => s.Ma_Size == Convert.ToInt32(cbbSize.SelectedValue))
                                 .Where(s => s.Ma_MauSac == Convert.ToInt32(cbbMau.SelectedValue))
                                 .FirstOrDefault();
                        dt.updateSLT(Convert.ToInt32(cbbSP.SelectedValue),
                                     Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue),
                                    (Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(CTSP1.Soluong)));
                        MessageBox.Show("Bạn đã thêm thành công");
                        txtSoLuong.ResetText();
                        txtDonGia.ResetText();
                        lbThanhTien.Text = "0";                            
                        cbbNhaCungCap.Enabled = false;
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        cbbSP.Text = "";
                        cbbSP.Enabled = false;
                        cbbSize.Text = "";
                        cbbSize.Enabled = false;
                        cbbMau.Text = "";
                        cbbMau.Enabled = false;
                        txtSoLuong.Enabled = false;
                        txtDonGia.Enabled = false;
                    }  
                    else if (CTHDN != null)
                    {
                        dt.updateCTHDN(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                       Convert.ToInt32(cbbMau.SelectedValue), (Convert.ToInt32(txtSoLuong.Text) + CTHDN.Soluong),
                                       Convert.ToInt32(txtDonGia.Text), ((Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)) + CTHDN.ThanhTien));
                        int tongtien = 0;
                        foreach (var a in dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text)))
                        {
                            tongtien = tongtien + Convert.ToInt32(a.ThanhTien) + 0;
                        }
                        dt.updatetongtienHDN(Convert.ToInt32(lbMaHD.Text), tongtien);
                            //CTSanPham CTSP = dt.CTSanPhams.Where(s => s.Ma_SP == Convert.ToInt32(cbbSP.SelectedValue))
                            //                              .Where(s => s.Ma_Size == Convert.ToInt32(cbbSize.SelectedValue))
                            //                              .Where(s => s.Ma_MauSac == Convert.ToInt32(cbbMau.SelectedValue))
                            //                              .FirstOrDefault();
                        dt.updateSLT(Convert.ToInt32(cbbSP.SelectedValue),
                                     Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue),
                                    (Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(CTSP.Soluong)));
                        MessageBox.Show("Bạn đã thêm số lượng thành công");
                        txtSoLuong.ResetText();
                        txtDonGia.ResetText();
                        lbThanhTien.Text = "0";                           
                        cbbNhaCungCap.Enabled = false;
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;
                        cbbSP.Text = "";
                        cbbSP.Enabled = false;
                        cbbSize.Text = "";
                        cbbSize.Enabled = false;
                        cbbMau.Text = "";
                        cbbMau.Enabled = false;
                        txtSoLuong.Enabled = false;
                        txtDonGia.Enabled = false;
                    }  
                }
            }
            dgvCTHDN.DataSource = dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text));       
        }
    

        private void cbbSP_SelectedValueChanged(object sender, EventArgs e)
        {            
            try
            {
                SanPham sp = dt.SanPhams.Where(s => s.Ma == Convert.ToInt32(cbbSP.SelectedValue)).FirstOrDefault();
                if (i == 1)
                {
                    cbbSize.DisplayMember = "TenSize";
                    cbbSize.ValueMember = "Ma";
                    cbbSize.DataSource = dt.cbbSize(1);
                    i++;
                }
                else
                {                    
                    cbbSize.DisplayMember = "TenSize";
                    cbbSize.ValueMember = "Ma";
                    cbbSize.DataSource = dt.cbbSize(sp.Ma_LoaiSP);
                }
                CTHDNhap CTHDN = dt.CTHDNhaps.Where(s => s.Ma_HDN == Convert.ToInt32(lbMaHD.Text))
                         .Where(s => s.Ma_SP == Convert.ToInt32(cbbSP.SelectedValue))
                         .FirstOrDefault();
                if (CTHDN == null)
                {
                    txtSoLuong.ResetText();
                    txtDonGia.ResetText();
                    lbThanhTien.Text = "0";
                    txtDonGia.Enabled = true;
                }
                else if (CTHDN != null)
                {                   
                    txtDonGia.Text = CTHDN.Soluong.ToString();
                    txtDonGia.Enabled = false;
                    txtDonGia.Text = CTHDN.DonGia.ToString();
                    lbThanhTien.Text = "0";
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbbSize_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    CTHDNhap CTHDN = dt.CTHDNhaps.Where(s => s.Ma_HDN == Convert.ToInt32(lbMaHD.Text))
            //                             .Where(s => s.Ma_SP == Convert.ToInt32(cbbSP.SelectedValue))
            //                             .Where(s => s.Ma_Size == Convert.ToInt32(cbbSize.SelectedValue))
            //                             .Where(s => s.Ma_MauSac == Convert.ToInt32(cbbMau.SelectedValue))
            //                             .FirstOrDefault();
            //    if (CTHDN == null)
            //    {
            //        txtSoLuong.ResetText();
            //        txtDonGia.ResetText();
            //        lbThanhTien.Text = "0";
            //    }
            //    else if (CTHDN != null)
            //    {
            //        txtSoLuong.Text = CTHDN.Soluong.ToString();
            //        txtDonGia.Text = CTHDN.Soluong.ToString();
            //        txtDonGia.Enabled = false;
            //        lbThanhTien.Text = CTHDN.ThanhTien.ToString();
            //    }
            //}
            //catch (Exception)
            //{

            //}
        }

        private void cbbMau_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnThem.Enabled = true;
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = true;
            //int r = dgvCTHDN.CurrentRow.Index;     

            //CTHDNhap CTHDN = dt.CTHDNhaps.Where(s => s.Ma_HDN == Convert.ToInt32(lbMaHD.Text))
            //                             .Where(s => s.Ma_SP == Convert.ToInt32(dgvCTHDN.Rows[r].Cells[0].Value.ToString()))
            //                             .Where(s => s.Ma_Size == Convert.ToInt32(dgvCTHDN.Rows[r].Cells[1].Value.ToString()))
            //                             .Where(s => s.Ma_MauSac == Convert.ToInt32(dgvCTHDN.Rows[r].Cells[2].Value.ToString()))
            //                             .FirstOrDefault();
            //cbbSP.SelectedValue = CTHDN.Ma_SP;
            //cbbSize.SelectedValue = CTHDN.Ma_Size;
            //cbbMau.SelectedValue = CTHDN.Ma_MauSac;
            //txtSoLuong.Text = CTHDN.Soluong.ToString();
            //txtDonGia.Text = CTHDN.DonGia.ToString();
            //lbThanhTien.Text = CTHDN.ThanhTien.ToString();

            int r = dgvCTHDN.CurrentRow.Index;

            CTHDNhap CTHDN = dt.CTHDNhaps.Where(s => s.Ma_HDN == Convert.ToInt32(lbMaHD.Text))
                                         .Where(s => s.Ma_SP == Convert.ToInt32(dgvCTHDN.Rows[r].Cells[0].Value.ToString()))
                                         .Where(s => s.Ma_Size == Convert.ToInt32(dgvCTHDN.Rows[r].Cells[1].Value.ToString()))
                                         .Where(s => s.Ma_MauSac == Convert.ToInt32(dgvCTHDN.Rows[r].Cells[2].Value.ToString()))
                                         .FirstOrDefault();
            if (dgvCTHDN.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult xoaCTHDN = MessageBox.Show("Bạn có muốn xóa không ???", "Xóa", MessageBoxButtons.YesNo);
                if (xoaCTHDN == DialogResult.Yes)
                {
                    var slcthdn = CTHDN.Soluong;
                    dt.deleteCTHDN(Convert.ToInt32(lbMaHD.Text), CTHDN.Ma_SP, CTHDN.Ma_Size, CTHDN.Ma_MauSac);
                    var tongtien = dt.CTHDNhaps.Where(s => s.Ma_HDN == Convert.ToInt32(lbMaHD.Text))
                                       .Select(s => s.ThanhTien).Sum();
                    if (tongtien == null)
                    {
                        tongtien = 0;
                    }

                    dt.updatetongtienHDN(Convert.ToInt32(lbMaHD.Text), tongtien);
                    int ma, size, mau;
                    ma = Convert.ToInt32(dgvCTHDN.Rows[r].Cells[0].Value.ToString());
                    size = Convert.ToInt32(dgvCTHDN.Rows[r].Cells[1].Value.ToString());
                    mau = Convert.ToInt32(dgvCTHDN.Rows[r].Cells[2].Value.ToString());
                    var CTSP = dt.selectTTCTSP(ma, size, mau).FirstOrDefault();

                    dt.updateSLT(CTSP.Ma_SP, CTSP.Ma_Size, CTSP.Ma_MauSac, (CTSP.Soluong - slcthdn));
                    dgvCTHDN.DataSource = dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text));
                    MessageBox.Show("Xóa thành công");
                    txtDonGia.ResetText();
                    txtSoLuong.ResetText();
                    lbThanhTien.Text = "0";
                    cbbSP.Text = "";
                    cbbSize.Text = "";
                    cbbMau.Text = "";
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    txtDonGia.ResetText();
                    txtSoLuong.ResetText();
                    txtDonGia.Enabled = false;
                    txtSoLuong.Enabled = false;
                    lbThanhTien.Text = "0";
                    cbbSP.Enabled = false;
                    cbbSize.Enabled = false;
                    cbbMau.Enabled = false;
                }
            }
            dgvCTHDN.DataSource = dt.selectCTHDN(Convert.ToInt32(lbMaHD.Text));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbbSP.Enabled = false;
            cbbSize.Enabled = false;
            cbbMau.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            txtDonGia.ResetText();
            txtSoLuong.ResetText();
            cbbSP.Text = "";
            cbbSize.Text = "";
            cbbMau.Text = "";
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void txtSoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            { 
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (txtDonGia.Text.Trim() == "" || txtDonGia.Text == null|| Convert.ToInt32(txtDonGia.Text) ==0)
                {
                    lbThanhTien.Text = "0";
                }
                else
                {
                    lbThanhTien.Text = (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text)).ToString("N0", culture);
                }
            }

            catch(Exception)
            {

            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (txtSoLuong.Text.Trim() == "" ||txtSoLuong.Text ==null|| Convert.ToInt32(txtSoLuong.Text) ==0)
                {
                    lbThanhTien.Text = "0";
                }
                else
                {
                    lbThanhTien.Text = (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text)).ToString("N0", culture);
                }
            }
            catch(Exception)
            {

            }
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cbbSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int loadttNCC = 0;
        private void cbbNhaCungCap_SelectedValueChanged(object sender, EventArgs e)
        {
            loadttNCC++;
            NhaCungCap NCC = dt.NhaCungCaps.Where(s => s.Ma == Convert.ToInt32(cbbNhaCungCap.SelectedValue)).FirstOrDefault();
            if (NCC!= null&&loadttNCC >1)
            {
                lbDiaChi.Text = NCC.DiaChi;
                lbSoDienThoai.Text = NCC.SoDienThoai.ToString();
                label8.Visible = true;
                label9.Visible = true;
                lbDiaChi.Visible = true;
                lbSoDienThoai.Visible = true;
            }    
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            MoFormTTNCC.MoFormNCC = 1;
            FormThongTinNCC FTTNCC = new FormThongTinNCC();
            FTTNCC.Show();
            this.Close();
        }

        private void dgvCTHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}