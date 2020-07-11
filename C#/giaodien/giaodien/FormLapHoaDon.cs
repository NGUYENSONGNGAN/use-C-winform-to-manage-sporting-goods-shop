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
    public partial class FormLapHoaDon : Form
    {

        DataClasses1DataContext dt = new DataClasses1DataContext();
        public FormLapHoaDon()
        {
            InitializeComponent();
        }
        public class TTMHDX
        {
            public static int Ma;
            public static int MoFormGhiChuHuyHDX;
        }
        int MaKH;
        int i = 0;
        int dongia;
        CultureInfo culture = new CultureInfo("vi-VN");
        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanPham_FormLapHoaDon.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sanPham_FormLapHoaDon.SanPham);
            // TODO: This line of code loads data into the 'mauSac_FormLapHoaDon.MauSac' table. You can move, or remove it, as needed.
            this.mauSacTableAdapter.Fill(this.mauSac_FormLapHoaDon.MauSac);
            // TODO: This line of code loads data into the 'size_FormLapHoaDon.Size' table. You can move, or remove it, as needed.
            this.sizeTableAdapter.Fill(this.size_FormLapHoaDon.Size);
            // TODO: This line of code loads data into the 'sanPham_FormLapHoaDon.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sanPham_FormLapHoaDon.SanPham);
            if (FormKiemTraKhachHang.TTKHC.Ma == 0)
            {
                MaKH = FormKhachHangMoi.TTKHM.Ma;
            }    
            else if (FormKhachHangMoi.TTKHM.Ma == 0)
            {
                MaKH = FormKiemTraKhachHang.TTKHC.Ma ;
            }
            var r = from s in dt.HDXuats select s.Ma;
            if (r.Count()== 0)
            {
                lbMaHD.Text = "1";
            }    
            else if (r.Count()!=0)
            {
                lbMaHD.Text = Convert.ToString(Convert.ToInt32(r.Max().ToString()) + 1);
            }    

            KhachHang KH = dt.KhachHangs.Where(s => s.Ma == MaKH).FirstOrDefault();
            lbTenKH.Text = KH.Ten;
            lbSoDienThoai.Text = KH.SoDienThoai;
            LoaiKH Loai = dt.LoaiKHs.Where(s => s.Ma == KH.Ma_LoaiKH).FirstOrDefault();
            lbThanhVien.Text = Loai.Ten;

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

            cbbSP.Enabled = false;
            cbbSize.Enabled = false;
            cbbMau.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            txtSoLuong.ResetText();
            lbThanhTien.Text = "0";
            txtSoLuong.Enabled = false;
            lbTren.Visible = false;
            lbSoLuongTon.Visible = false;
            lbDonGia.Visible = false;
            lbThanhTien.Visible = false;
            lbThanhTien.Visible = false;
            TTMHDX.Ma = Convert.ToInt32(lbMaHD.Text);
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = dt.SanPhams;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            var kiemtrahdx = dt.selectTTHDX(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();
            if (kiemtrahdx == null)
            {
                FormKhachHangMoi.TTKHM.Ma = 0;
                FormKiemTraKhachHang.TTKHC.Ma = 0;
                FormTrangChu FTC = new FormTrangChu();
                FTC.Show();
                this.Close();
            }
            else if (kiemtrahdx != null)
            {
                DialogResult a = MessageBox.Show("Bạn có muốn hủy hóa đơn này không ???", "Hủy", MessageBoxButtons.YesNo);
                if (a== DialogResult.Yes)
                {
                    TTMHDX.MoFormGhiChuHuyHDX = 1;
                    FormGhiChuHuyHDX FGCHHDX = new FormGhiChuHuyHDX();
                    FGCHHDX.ShowDialog();
                    if (FormGhiChuHuyHDX.TTDongForm.HuyHDX ==1)
                    {
                        FormKhachHangMoi.TTKHM.Ma = 0;
                        FormKiemTraKhachHang.TTKHC.Ma = 0;
                        FormTrangChu FTC = new FormTrangChu();
                        FTC.Show();
                        FormGhiChuHuyHDX.TTDongForm.HuyHDX = 0;
                        this.Close();
                    }    
                }    
            }    
        }

        private void cbbSP_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                i++;
                cbbSP.DisplayMember = "Ten";
                cbbSP.ValueMember = "Ma";
                cbbSP.DataSource = dt.SanPhams;
                if (i ==1)
                {
                   
                    var cbsp = from cb in dt.SanPhams select cb.Ma;
                    cbbSP.SelectedValue = Convert.ToInt32(cbsp.Min().ToString());
                    SanPham sp1 = dt.SanPhams.Where(s => s.Ma == Convert.ToInt32(cbbSP.SelectedValue)).FirstOrDefault();
                    cbbSize.DisplayMember = "TenSize";
                    cbbSize.ValueMember = "Ma";
                    cbbSize.DataSource = dt.cbbSize(sp1.Ma_LoaiSP);
                }
                else
                {
                    SanPham sp = dt.SanPhams.Where(s => s.Ma == Convert.ToInt32(cbbSP.SelectedValue)).FirstOrDefault();
                    if (i != 1)
                    {
                        cbbSize.DisplayMember = "TenSize";
                        cbbSize.ValueMember = "Ma";
                        cbbSize.DataSource = dt.cbbSize(sp.Ma_LoaiSP);
                        dongia = sp.DonGia;
                        lbDonGia.Text = sp.DonGia.ToString("N0",culture);
                    }
                    var CTSP = dt.selectTTCTSP(Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                                     Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
                                                  
                    txtSoLuong.ResetText();
                    lbThanhTien.Text = "0";
                    if (CTSP == null)
                    {
                        lbSoLuongTon.Text = "0";
                    }
                    else
                    {
                        int slt = Convert.ToInt32 (CTSP.Soluong);
                        lbSoLuongTon.Text =slt.ToString("N0",culture);
                    }    
                        
                }
            }
            catch(Exception)
            {

            }
        }

        private void cbbSize_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.ResetText();
                lbThanhTien.Text = "0";
                var CTSP = dt.selectTTCTSP(Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                                 Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
                if (CTSP == null)
                {
                    lbSoLuongTon.Text = "0";
                }    
                else
                {
                    int slt = Convert.ToInt32(CTSP.Soluong);
                    lbSoLuongTon.Text = slt.ToString("N0", culture);
                }    

            }
            catch(Exception)
            {

            }
        }

        private void cbbMau_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.ResetText();
                lbThanhTien.Text = "0";
                var CTSP = dt.selectTTCTSP(Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                                 Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
                if (CTSP == null)
                {
                    lbSoLuongTon.Text = "0";
                }
                else
                {
                    lbSoLuongTon.Text = CTSP.Soluong.ToString();
                }
                    
            }
            catch (Exception)
            {

            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text == "" || txtSoLuong.Text.Trim() == null || Convert.ToInt32(txtSoLuong.Text.Trim()) == 0)
                {
                    lbThanhTien.Text = "0";
                }
                else if (txtSoLuong.Text.Trim() != null)
                {

                    lbThanhTien.Text = (dongia * Convert.ToInt32(txtSoLuong.Text)).ToString("N0",culture);
                }
            }
            catch(Exception)
            {

            }
        }

        private void lbDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text.Trim() == null || Convert.ToInt32(txtSoLuong.Text.Trim()) == 0)
                {
                    lbThanhTien.Text = "0";
                }
                else if (txtSoLuong.Text.Trim() != null)
                {
                    lbThanhTien.Text = (Convert.ToInt32(lbDonGia.Text) * Convert.ToInt32(txtSoLuong.Text)).ToString("N0", culture);                   
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim()==null|| txtSoLuong.Text.Trim() == "")
            {

            }
            else if (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(lbSoLuongTon.Text))
            {
                MessageBox.Show("Số lượng không đủ\nVui lòng xem lại");
                txtSoLuong.Focus();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbbSP.Enabled = false;
            cbbSize.Enabled = false;
            cbbMau.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            txtSoLuong.Enabled = false;
            lbTren.Visible = false;
            lbSoLuongTon.Visible = false;
            lbDonGia.Visible = false;
            lbThanhTien.Visible = false;
            txtSoLuong.ResetText();
            lbThanhTien.Visible = false;
            gunaGradientCircleButton1.Visible = true;
            txtTimKiem.Visible = true;
            dgvSanPham.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim() == "" || txtSoLuong.Text == null || Convert.ToInt32(txtSoLuong.Text)==0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng", "Lỗi");
            }
            else if (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(lbSoLuongTon.Text))
            {
                //đã xử lý sự kiện trong textleave
                txtSoLuong.Focus();
            }    
            else
            {
                var HDX = dt.selectTTHDX(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();
                if (HDX == null)
                {
                    Image QR;
                    Zen.Barcode.CodeQrBarcodeDraw qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                    QR = qr.Draw(lbMaHD.Text, 50);
                    MemoryStream stream = new MemoryStream();
                    QR.Save(stream, ImageFormat.Jpeg);
                    dt.insertHDX(Convert.ToInt32(lbMaHD.Text), MaKH, FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap, Convert.ToDateTime(DateTime.Now), null, stream.ToArray());
                    dt.insertCTHDX(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                   Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(txtSoLuong.Text),
                                   dongia * Convert.ToInt32(txtSoLuong.Text));
                    dt.updateTongTienHDX(Convert.ToInt32(lbMaHD.Text), dongia * Convert.ToInt32(txtSoLuong.Text));
                    dt.updateSLT(Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                   Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(lbSoLuongTon.Text) - Convert.ToInt32(txtSoLuong.Text));
                    dgvCTHDX.AutoGenerateColumns = false;
                    dgvCTHDX.DataSource = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text));


                    MessageBox.Show("Thêm thành công");
                    cbbSP.Enabled = false;
                    cbbSize.Enabled = false;
                    cbbMau.Enabled = false;

                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = true;

                    txtSoLuong.ResetText();
                    lbThanhTien.Text = "0";
                    txtSoLuong.Enabled = false;
                    lbTren.Visible = false;
                    lbSoLuongTon.Visible = false;
                    lbDonGia.Visible = false;
                    lbThanhTien.Visible = false;
                }   
                else if (HDX!= null)
                {
                    var CTHDX = dt.selectTTCTHDX(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue),
                                                 Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
                    if (CTHDX == null)
                    {
                        dt.insertCTHDX(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                   Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(txtSoLuong.Text),
                                   dongia * Convert.ToInt32(txtSoLuong.Text));
                        int tongtien=0;
                        foreach(var a in dt.selectCTHDX(Convert.ToInt32( lbMaHD.Text)))
                        {
                            tongtien = tongtien + Convert.ToInt32( a.ThanhTien);
                        }
                        dt.updateTongTienHDX(Convert.ToInt32(lbMaHD.Text), tongtien);
                        dt.updateSLT(Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                  Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(lbSoLuongTon.Text) - Convert.ToInt32(txtSoLuong.Text));
                        dgvCTHDX.AutoGenerateColumns = false;
                        dgvCTHDX.DataSource = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text));
                        MessageBox.Show("Thêm sản phẩm thành công");

                    }    
                    else if (CTHDX != null)
                    {
                        var TTCTHDX = dt.selectTTCTHDX(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue),
                                                       Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
                        dt.updateSoLuongTTCTHDX(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbSP.SelectedValue),
                                                Convert.ToInt32(cbbSize.SelectedValue), Convert.ToInt32(cbbMau.SelectedValue),
                                                (TTCTHDX.SoLuong + Convert.ToInt32(txtSoLuong.Text)), 
                                                (TTCTHDX.ThanhTien + (Convert.ToInt32(txtSoLuong.Text) * dongia)));
                        int tongtien = 0;
                        foreach (var a in dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text)))
                        {
                            tongtien = tongtien + Convert.ToInt32(a.ThanhTien);
                        }
                        dt.updateTongTienHDX(Convert.ToInt32(lbMaHD.Text), tongtien);
                        dt.updateSLT(Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue),
                                  Convert.ToInt32(cbbMau.SelectedValue), Convert.ToInt32(lbSoLuongTon.Text) - Convert.ToInt32(txtSoLuong.Text));
                        dgvCTHDX.AutoGenerateColumns = false;
                        dgvCTHDX.DataSource = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text));
                        MessageBox.Show("Thêm số lượng thành công");
                    }
                    cbbSP.Enabled = false;
                    cbbSize.Enabled = false;
                    cbbMau.Enabled = false;

                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = true;

                    txtSoLuong.ResetText();
                    lbThanhTien.Text = "0";
                    txtSoLuong.Enabled = false;
                    lbTren.Visible = false;
                    lbSoLuongTon.Visible = false;
                    lbDonGia.Visible = false;
                    lbThanhTien.Visible = false;
                    gunaGradientCircleButton1.Visible = false;
                    txtTimKiem.Visible = false;
                    dgvSanPham.Visible = false;
                }    
            }
        }

        private void FormLapHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var CTSP = dt.selectTTCTSP(Convert.ToInt32(cbbSP.SelectedValue), Convert.ToInt32(cbbSize.SelectedValue), 
                                       Convert.ToInt32(cbbMau.SelectedValue)).FirstOrDefault();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cbbSP.Enabled = true;
            cbbSize.Enabled = true;
            cbbMau.Enabled = true;
            lbTren.Visible = true;
            lbSoLuongTon.Text = CTSP.Soluong.ToString();
            lbSoLuongTon.Visible = true;
            lbDonGia.Visible = true;
            lbThanhTien.Visible = true;
            txtSoLuong.Enabled = true;
            gunaGradientCircleButton1.Visible = true;
            txtTimKiem.Visible = true;
            dgvSanPham.Visible = true;
        }

        private void dgvCTHDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCTHDX.CurrentRow.Index;
            cbbSP.Enabled = false;
            cbbSize.Enabled = false;
            cbbMau.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            txtSoLuong.ResetText();
            txtSoLuong.Enabled = false;
            lbThanhTien.Text = "0";
            lbTren.Visible = false;
            lbSoLuongTon.Visible = false;
            lbDonGia.Visible = false;
            lbThanhTien.Visible = false;
            lbThanhTien.Visible = false;

            var CTHDX = dt.selectTTCTHDX(Convert.ToInt32(lbMaHD.Text),
                                              Convert.ToInt32(dgvCTHDX.Rows[r].Cells[0].Value.ToString()),
                                              Convert.ToInt32(dgvCTHDX.Rows[r].Cells[1].Value.ToString()),
                                              Convert.ToInt32(dgvCTHDX.Rows[r].Cells[2].Value.ToString()))
                                              .FirstOrDefault();
            if (dgvCTHDX.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult xoaCTHDX = MessageBox.Show("Bạn có muốn xóa không ???", "Xóa", MessageBoxButtons.YesNo);
                if (xoaCTHDX == DialogResult.Yes)
                {
                    var slcthdn = CTHDX.SoLuong;
                    dt.deleteCTHDX(Convert.ToInt32(lbMaHD.Text), CTHDX.Ma_SP, CTHDX.Ma_Size, CTHDX.Ma_MauSac);
                    //var tongtien = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text))
                    //                   .Select(s => s.ThanhTien).Sum();
                    int tongtien = 0;
                    foreach(var tt in dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text)))
                    {
                        tongtien = Convert.ToInt32( tt.ThanhTien )+ tongtien;
                    }             
                    dt.updateTongTienHDX(Convert.ToInt32(lbMaHD.Text), tongtien);
                    int ma, size, mau;
                    ma = Convert.ToInt32(dgvCTHDX.Rows[r].Cells[0].Value.ToString());
                    size = Convert.ToInt32(dgvCTHDX.Rows[r].Cells[1].Value.ToString());
                    mau = Convert.ToInt32(dgvCTHDX.Rows[r].Cells[2].Value.ToString());
                    var CTSP = dt.selectTTCTSP(ma, size, mau).FirstOrDefault();

                    dt.updateSLT(CTSP.Ma_SP, CTSP.Ma_Size, CTSP.Ma_MauSac, (CTSP.Soluong + slcthdn));
                    dgvCTHDX.DataSource = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text));
                    MessageBox.Show("Xóa thành công");
                    lbDonGia.Visible = false;
                    txtSoLuong.ResetText();
                    lbThanhTien.Text = "0";
                    cbbSP.Text = "";
                    cbbSize.Text = "";
                    cbbMau.Text = "";
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    txtSoLuong.ResetText();
                    txtSoLuong.Enabled = false;
                    lbThanhTien.Text = "0";
                    cbbSP.Enabled = false;
                    cbbSize.Enabled = false;
                    cbbMau.Enabled = false;
                    dgvCTHDX.DataSource = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text));
                }
                else if(xoaCTHDX == DialogResult.No)
                {
                    dgvCTHDX.DataSource = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text));
                }
            }
           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {            
            FormKhachHangMoi.TTKHM.Ma = 0;
            FormKiemTraKhachHang.TTKHC.Ma = 0;
            var CTHDX = dt.selectCTHDX(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();
            if (CTHDX== null)
            {
                MessageBox.Show("Hóa đơn bạn chưa có sản phẩm\nKhông thể thanh toán", "Lỗi");
            }   
            else if (CTHDX != null)
            {
                var KH = dt.selectTTKH(MaKH).FirstOrDefault();
                var HD = dt.selectTTHDX(Convert.ToInt32( lbMaHD.Text)).FirstOrDefault();
                var LKH = dt.LoaiKHs.Where(s => s.Ma == KH.Ma_LoaiKH).FirstOrDefault();
                int tongtien = Convert.ToInt32 ( HD.TongTien - HD.TongTien/100 * Convert.ToInt32(LKH.TiLeGiamGia));
                dt.updateTongTienHDX(Convert.ToInt32(lbMaHD.Text),tongtien);

                if (HD.TongTien >=200000)
                {
                    dt.updatediemtichluy(KH.Ma, KH.DiemTichLuy + 10);
                    var KH1 = dt.selectTTKH(MaKH).FirstOrDefault();
                    
                    if (KH1.DiemTichLuy >=200 && KH1.DiemTichLuy < 400)
                    {
                        dt.updateLKH(MaKH, 2);
                    }    
                    else if (KH1.DiemTichLuy >=400 && KH1.DiemTichLuy < 1000)
                    {
                        dt.updateLKH(MaKH, 3);
                    }                        
                }    
                FormThanhToan FTT = new FormThanhToan();
                FTT.Show();
                this.Close();
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSanPham.CurrentRow.Index;
            int ma = Convert.ToInt32(dgvSanPham.Rows[r].Cells[0].Value.ToString());
            cbbSP.SelectedValue = ma;
            txtTimKiem.ResetText();
            dgvSanPham.Visible = false;
            txtSoLuong.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.Visible = true;
            if (txtTimKiem.Text.Trim() == "" || txtTimKiem.Text.Trim() == null)
            {
                dgvSanPham.AutoGenerateColumns = false;
                dgvSanPham.DataSource = dt.SanPhams;
            }
            else if (txtTimKiem.Text.Trim() != "")
            {
                dgvSanPham.AutoGenerateColumns = false;
                dgvSanPham.DataSource = dt.TKSPTrongHD(txtTimKiem.Text);
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
