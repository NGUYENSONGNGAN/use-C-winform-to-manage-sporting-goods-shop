using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormThongTinNV : Form
    {
       // int hienbtchonanh = 0;
        int kiemtrasua;
     //   int Loaddata =0;

        // mã hóa mật khẩu
        public string MaHoa(string txt)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            txt = sb.ToString();
            return txt;
        }

        public class loadulieuNV
        {
            public static int load = 1 ;
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public FormThongTinNV()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

                    
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormThongTinNV_Load(object sender, EventArgs e)
        {
            int ma = FormTrangChu.ThongTinCaNhan.MaNV;
            //if (ma ==1)
            //{
                NhanVien nv = dt.NhanViens.Where(s => s.Ma == Convert.ToInt32(FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap)).FirstOrDefault();
                lbSoMaNV.Text = nv.Ma.ToString();                
                txtTen.Text = nv.Ten ;
                cbbChucVu.DisplayMember = "Ten";
                cbbChucVu.ValueMember = "Ma";
                cbbChucVu.DataSource = dt.ChucVus;
                cbbChucVu.SelectedValue = nv.Ma_CV;
                if (nv.GioiTinh == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                txtDiaChi.Text = nv.DiaChi;
                txtEmail.Text = nv.Email;
                dtpNgaySinh.Value = Convert.ToDateTime( nv.NgaySinh);
                dtpNgayVaoLam.Value = Convert.ToDateTime( nv.NgayVaoLam);
                txtTen.Enabled = false;
                cbbChucVu.Enabled = false;
                rbtNam.Enabled = false;
                rbtNu.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                dtpNgaySinh.Enabled = false;
                dtpNgayVaoLam.Enabled = false;
                btnChonAnh.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = true;
                btnChonAnh.Visible = false;
                groupBox2.Visible = false;
              //int ma = Convert.ToInt32(lbSoMaNV.Text);
                if (nv == null || nv.Hinhanh == null)
                {
                   pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream img = new MemoryStream(nv.Hinhanh.ToArray());
                    Image i = Image.FromStream(img);
                    if (i == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        pictureBox1.Image = i;
                    }
                }


            //}
            //them
            if (FormDuLieuNV.MoFormThongTinNV.phanbietthemsua == 1)
            {
                cbbChucVu.DisplayMember = "Ten";
                cbbChucVu.ValueMember = "Ma";
                cbbChucVu.DataSource = dt.ChucVus;
                var r = from s in dt.NhanViens select s.Ma;
                lbSoMaNV.Text = Convert.ToString(Convert.ToInt32(r.Max().ToString()) + 1);
                txtTen.ResetText();
                rbtNam.Checked = true;
                txtDiaChi.ResetText();
                txtEmail.ResetText();
                dtpNgaySinh.ResetText();
                dtpNgayVaoLam.ResetText();
                btnSua.Visible = false;
                btnLuu.Enabled = true;
                txtTen.Enabled = true;
                cbbChucVu.Enabled = true;
                rbtNam.Enabled = true;
                rbtNu.Enabled = true;
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                dtpNgaySinh.Enabled = true;
                dtpNgayVaoLam.Enabled = true;
                btnChonAnh.Enabled = true;
                lbTaiKhoan.Visible = true;
                lbMatKhau.Visible = true;
                txtTaiKhoan.Visible = true;
                txtTaiKhoan.Visible = true;
                groupBox2.Visible = true;
                btnChonAnh.Visible = true;
                btnDoiMatKhau.Visible = false;
                pictureBox1.Image = null;

            }
            //sua
            else if (FormDuLieuNV.MoFormThongTinNV.phanbietthemsua ==2)
            {   
                cbbChucVu.DisplayMember = "Ten";
                cbbChucVu.ValueMember = "Ma";
                cbbChucVu.DataSource = dt.ChucVus;
                lbSoMaNV.Text = FormDuLieuNV.MoFormThongTinNV.ma.ToString();
                NhanVien NVCT = dt.NhanViens.Where(s => s.Ma == Convert.ToInt32(lbSoMaNV.Text)).FirstOrDefault();
                txtTen.Text = NVCT.Ten;
                if (NVCT.GioiTinh == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                dtpNgaySinh.Value = Convert.ToDateTime(nv.NgaySinh);
                dtpNgayVaoLam.Value = Convert.ToDateTime(nv.NgayVaoLam);
                txtDiaChi.Text = nv.DiaChi;
                txtEmail.Text = nv.Email;
                cbbChucVu.SelectedValue = nv.ChucVu;
                groupBox2.Visible = false;
                txtTen.Enabled = false;
                cbbChucVu.Enabled = false;
                panel2.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                dtpNgaySinh.Enabled = false;
                dtpNgayVaoLam.Enabled = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
                btnDoiMatKhau.Visible = false;
                if (NVCT == null || NVCT.Hinhanh == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream img = new MemoryStream(NVCT.Hinhanh.ToArray());
                    Image i = Image.FromStream(img);
                    if (i == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        pictureBox1.Image = i;
                    }
                }
                if (FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap == 1)
                {
                    btnSua.Visible = true;
                    btnLuu.Visible = true;
                }
            }    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kiemtrasua = 2;
            
            txtTen.Enabled = true;
            cbbChucVu.Enabled = true;
            rbtNam.Enabled = true;
            rbtNu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            dtpNgaySinh.Enabled = true;
            dtpNgayVaoLam.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnChonAnh.Enabled = true;
            lbTaiKhoan.Enabled = false;
            lbMatKhau.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            btnChonAnh.Visible = true;
            if (lbSoMaNV.Text == FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap.ToString())
            {
                cbbChucVu.Enabled = false;
                dtpNgayVaoLam.Enabled = false;
                groupBox2.Visible = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //lưu khi xem thông tin nhan viên cũ
            if (FormTrangChu.ThongTinCaNhan.SuaTTCaNhan == 1)
            {
                if (txtDiaChi.Text == "" || txtEmail.Text == "" || txtTen.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    string gt = "";
                    if (rbtNam.Checked == true)
                    {
                        gt = "Nam";
                    }
                    else if (rbtNu.Checked == true)
                    {
                        gt = "Nữ";
                    }  
                    if (pictureBox1.Image == null)
                    {
                        DialogResult img = MessageBox.Show("Bạn chưa chọn hình.\nBạn có muốn lưu không ?", "Thiếu thông tin", MessageBoxButtons.YesNo);
                        if (img == DialogResult.Yes)
                        {
                            dt.updatenv(Convert.ToInt32(lbSoMaNV.Text), txtTen.Text, Convert.ToInt32(cbbChucVu.SelectedValue), gt, txtDiaChi.Text,
                                txtEmail.Text, Convert.ToDateTime(dtpNgaySinh.Value), Convert.ToDateTime(dtpNgayVaoLam.Value), null);
                        }
                    }
                    else if (pictureBox1.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                        dt.updatenv(Convert.ToInt32(lbSoMaNV.Text), txtTen.Text, Convert.ToInt32(cbbChucVu.SelectedValue), gt, txtDiaChi.Text,
                            txtEmail.Text, Convert.ToDateTime(dtpNgaySinh.Value), Convert.ToDateTime(dtpNgayVaoLam.Value), stream.ToArray());

                    }
                    NhanVien nv = dt.NhanViens.Where(s => s.Ma == Convert.ToInt32(lbSoMaNV.Text)).FirstOrDefault();
                    txtDiaChi.Text = nv.DiaChi;
                    txtEmail.Text = nv.Email;
                    dtpNgaySinh.Value = Convert.ToDateTime(nv.NgaySinh);
                    dtpNgayVaoLam.Value = Convert.ToDateTime(nv.NgayVaoLam);
                    txtTen.Enabled = false;
                    cbbChucVu.Enabled = false;
                    rbtNam.Enabled = false;
                    rbtNu.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtEmail.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    dtpNgayVaoLam.Enabled = false;
                    btnChonAnh.Enabled = false;
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    groupBox2.Visible = false;

                    //bunifuMaterialTextbox1.Visible = false;
                    //bunifuMaterialTextbox1.Visible = false;
                    btnHuy.Visible = true;
                    btnChonAnh.Visible = false;
                    MessageBox.Show("Bạn đã sửa thành công");
                }
            }

            //Lưu khi thêm nhân viên
            else if (FormDuLieuNV.MoFormThongTinNV.phanbietthemsua == 1 && kiemtrasua != 2)
            {
                if (txtDiaChi.Text == "" || txtEmail.Text == "" || txtTen.Text == ""||txtTaiKhoan.Text == ""||txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    string gt = "";
                    if (rbtNam.Checked == true)
                    {
                        gt = "Nam";
                    }
                    else if (rbtNu.Checked == true)
                    {
                        gt = "Nữ";
                    }                      
                    NhanVien nv = dt.NhanViens.Where(s => s.taikhoan == txtTaiKhoan.Text.Trim().ToString()).FirstOrDefault();
                    if (nv != null)
                    {
                        MessageBox.Show("Đã có tài khoản này\nHãy thử tài khoản khác", "Lỗi");
                    }
                    else
                    {
                        
                        if (pictureBox1.Image == null)
                        {
                            DialogResult img = MessageBox.Show("Bạn chưa chọn hình.\nBạn có muốn lưu không ?", "Thiếu thông tin", MessageBoxButtons.YesNo);
                            if (img == DialogResult.Yes)
                            {
                                dt.insertnv(Convert.ToInt32(lbSoMaNV.Text), txtTen.Text, Convert.ToInt32(cbbChucVu.SelectedValue), gt, txtDiaChi.Text,
                                    txtEmail.Text, Convert.ToDateTime(dtpNgaySinh.Value), Convert.ToDateTime(dtpNgayVaoLam.Value), txtTaiKhoan.Text.Trim(),
                                    MaHoa(txtMatKhau.Text.Trim()), null);
                                MessageBox.Show("Bạn đã thêm thành công");
                                txtTen.Enabled = false;
                                cbbChucVu.Enabled = false;
                                rbtNam.Enabled = false;
                                rbtNu.Enabled = false;
                                txtDiaChi.Enabled = false;
                                txtEmail.Enabled = false;
                                dtpNgaySinh.Enabled = false;
                                dtpNgayVaoLam.Enabled = false;
                                btnChonAnh.Enabled = false;
                                btnLuu.Enabled = false;
                                btnSua.Visible = true;
                                btnSua.Enabled = true;
                                groupBox2.Visible = true;
                                btnChonAnh.Visible = false;
                                groupBox2.Visible = false;
                                btnHuy.Visible = true;
                            }
                        }
                        else if (pictureBox1.Image != null)
                        {
                            MemoryStream stream = new MemoryStream();
                            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                            dt.insertnv(Convert.ToInt32(lbSoMaNV.Text), txtTen.Text, Convert.ToInt32(cbbChucVu.SelectedValue), gt, txtDiaChi.Text,
                            txtEmail.Text, Convert.ToDateTime(dtpNgaySinh.Value), Convert.ToDateTime(dtpNgayVaoLam.Value), txtTaiKhoan.Text,
                            MaHoa(txtMatKhau.Text.Trim()), stream.ToArray());
                            MessageBox.Show("Bạn đã thêm thành công");
                            txtTen.Enabled = false;
                            cbbChucVu.Enabled = false;
                            rbtNam.Enabled = false;
                            rbtNu.Enabled = false;
                            txtDiaChi.Enabled = false;
                            txtEmail.Enabled = false;
                            dtpNgaySinh.Enabled = false;
                            dtpNgayVaoLam.Enabled = false;
                            btnChonAnh.Enabled = false;
                            btnLuu.Enabled = false;
                            btnSua.Visible = true;
                            btnSua.Enabled = true;
                            groupBox2.Visible = true;
                            btnChonAnh.Visible = false;
                            groupBox2.Visible = false;
                            btnHuy.Visible = true;
                        }                      
                    }
                }
            }
            // lưu khi thêm thông tin nhân viên bị lỗi
            // sưa ttnv
            else if ( kiemtrasua == 2)
            {
                if (txtDiaChi.Text == "" || txtEmail.Text == "" || txtTen.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    string gt = "";
                    if (rbtNam.Checked == true)
                    {
                        gt = "Nam";
                    }
                    else if (rbtNu.Checked == true)
                    {
                        gt = "Nữ";
                    }                  
                    if (pictureBox1.Image == null)
                    {
                        DialogResult img = MessageBox.Show("Bạn chưa chọn hình.\nBạn có muốn lưu không ?", "Thiếu thông tin", MessageBoxButtons.YesNo);
                        if (img == DialogResult.Yes)
                        {                            
                            dt.updatenv(Convert.ToInt32(lbSoMaNV.Text), txtTen.Text, Convert.ToInt32(cbbChucVu.SelectedValue), gt, txtDiaChi.Text,
                                txtEmail.Text, Convert.ToDateTime(dtpNgaySinh.Value), Convert.ToDateTime(dtpNgayVaoLam.Value), null);
                            cbbChucVu.Enabled = false;
                            rbtNam.Enabled = false;
                            rbtNu.Enabled = false;
                            txtDiaChi.Enabled = false;
                            txtEmail.Enabled = false;
                            dtpNgaySinh.Enabled = false;
                            dtpNgayVaoLam.Enabled = false;
                            btnChonAnh.Enabled = false;
                            btnLuu.Enabled = false;
                            btnSua.Enabled = true;
                            lbTaiKhoan.Visible = false;
                            lbMatKhau.Visible = false;
                            txtTaiKhoan.Visible = false;
                            txtMatKhau.Visible = false;
                            groupBox2.Visible = false;
                            btnChonAnh.Visible = false;
                            MessageBox.Show("Bạn đã sửa thành công");
                        }
                    }
                    else if (pictureBox1.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                        dt.updatenv(Convert.ToInt32(lbSoMaNV.Text), txtTen.Text, Convert.ToInt32(cbbChucVu.SelectedValue), gt, txtDiaChi.Text,
                            txtEmail.Text, Convert.ToDateTime(dtpNgaySinh.Value), Convert.ToDateTime(dtpNgayVaoLam.Value), stream.ToArray());
                        cbbChucVu.Enabled = false;
                        rbtNam.Enabled = false;
                        rbtNu.Enabled = false;
                        txtDiaChi.Enabled = false;
                        txtEmail.Enabled = false;
                        dtpNgaySinh.Enabled = false;
                        dtpNgayVaoLam.Enabled = false;
                        btnChonAnh.Enabled = false;
                        btnLuu.Enabled = false;
                        btnSua.Enabled = true;
                        lbTaiKhoan.Visible = false;
                        lbMatKhau.Visible = false;
                        txtTaiKhoan.Visible = false;
                        txtMatKhau.Visible = false;
                        groupBox2.Visible = false;
                        btnChonAnh.Visible = false;
                        MessageBox.Show("Bạn đã sửa thành công");
                    }             
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //       btnChonAnh.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
        //    btnChonAnh.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        //    btnChonAnh.Visible = true;
        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {            
            FormDoiMatKhau FDMK = new FormDoiMatKhau();
            FDMK.ShowDialog();
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {           
            if (FormDuLieuNV.MoFormThongTinNV.phanbietthemsua == 1 || FormDuLieuNV.MoFormThongTinNV.phanbietthemsua == 2)
            {
                FormDuLieuNV.MoFormThongTinNV.phanbietthemsua = 0;
                FormDuLieuNV f1 = new FormDuLieuNV();
                f1.Show();
                this.Close();
            }
            else
            {
                FormTrangChu.ThongTinCaNhan.SuaTTCaNhan = 0;
                FormTrangChu ftt = new FormTrangChu();
                ftt.Show();
                this.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbChucVu_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbNgayVaoLam_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lbTen_Click(object sender, EventArgs e)
        {

        }

        private void lbTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void lbMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lbSoMaNV_Click(object sender, EventArgs e)
        {

        }

        private void lbMaNV_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
            if (a.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(a.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnChonAnh.Visible = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            dtpNgaySinh.Enabled = false;
            txtTen.Enabled = false;
            panel2.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;

        }

        private void rbtNu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
