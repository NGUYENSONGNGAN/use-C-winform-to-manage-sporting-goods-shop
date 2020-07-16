using DevExpress.Emf;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{

    public partial class FormDuLieuNV : Form
    {

        public class MoFormThongTinNV
        {
            static public int ma, chucvu,phanbietthemsua;
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        public FormDuLieuNV()
        {
            InitializeComponent();
        }

        private void FormDuLieuNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chucVu_FormDuLieuNV.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.chucVu_FormDuLieuNV.ChucVu);
            // TODO: This line of code loads data into the 'chucVu_FormDuLieuNV.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.chucVu_FormDuLieuNV.ChucVu);

           
            // thêm column
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dt.selectnv();

      //      //màu dòng chẵn
      //      dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
      //      dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      //      //Mau o khi click
      //      dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
      //      //color chữ khi click
      //      dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.Red;
      //      //back groud
      //      dgvNhanVien.BackgroundColor = Color.FromArgb(51, 51, 76);

      //      dgvNhanVien.EnableHeadersVisualStyles = false;
      ////      dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      //      //Mau title
      //      dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
      //      //mau chu title
      //      dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
      //      //font size data gridview
      //      dgvNhanVien.DefaultCellStyle.Font= new Font("Tahoma", 12);
      //      //// font title datagridview
      //      dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15);
      //      //borderstyle header
      //      dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      //      dgvNhanVien.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      //      //dataGridView1.BorderStyle = BorderStyle.Fixed3D;
      //      //text header center
      //      dgvNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      //      //color border
      //      dgvNhanVien.GridColor = Color.Aqua;
      //      //forecoloe datagridview
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvNhanVien.Columns[e.ColumnIndex].Name == "TDHD")
            {
                int Ma = Convert.ToInt32(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                NhanVien nv = dt.NhanViens.Where(s => s.Ma == Ma).FirstOrDefault();
                
                if (nv.Ma_CV ==1 )
                {
                    if (FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap != 1)
                    {
                        MessageBox.Show("Bạn không có quyền để hủy hoạt động của quản lý");
                    }    
                    else if (FormDangNhap.ThongTinNVDangNhap.MaNVDangNhap == 1)
                    {
                        if (Convert.ToBoolean(dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString()) == Convert.ToBoolean("True"))
                        {
                            dt.updateHoatDongnv(Ma, Convert.ToBoolean("False"));
                            dgvNhanVien.DataSource = dt.selectnv();
                            MessageBox.Show("Cập nhật trạng thái không hoạt động thành công", "Thành công");
                        }   
                        else if (Convert.ToBoolean(dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString()) == Convert.ToBoolean("False"))
                        {
                            dt.updateHoatDongnv(Ma, Convert.ToBoolean("True"));
                            dgvNhanVien.DataSource = dt.selectnv();
                            MessageBox.Show("Cập nhật trạng thái hoạt động thành công", "Thành công");
                        }    
                    }    
                }    
                else  if (nv.Ma_CV!=1)
                {
                    if (Convert.ToBoolean(dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString()) == Convert.ToBoolean("True"))
                    {
                        dt.updateHoatDongnv(Ma, Convert.ToBoolean("False"));
                        dgvNhanVien.DataSource = dt.selectnv();
                        MessageBox.Show("Cập nhật trạng thái không hoạt động thành công", "Thành công");
                    }
                    else if (Convert.ToBoolean(dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString()) == Convert.ToBoolean("False"))
                    {
                        dt.updateHoatDongnv(Ma, Convert.ToBoolean("True"));
                        dgvNhanVien.DataSource = dt.selectnv();
                        MessageBox.Show("Cập nhật trạng thái hoạt động thành công", "Thành công");
                    }
                }               
            }
            else if (dgvNhanVien.Columns[e.ColumnIndex].Name == "Xem")
            {
                MoFormThongTinNV.phanbietthemsua = 2;                
                MoFormThongTinNV.ma = Convert.ToInt32(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormThongTinNV FTTNV = new FormThongTinNV();
                FTTNV.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChu ftc = new FormTrangChu();
            ftc.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            MoFormThongTinNV.phanbietthemsua = 1;
            FormThongTinNV formTTNV = new FormThongTinNV();
            formTTNV.Show();
            this.Hide();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text ==null || txtTimKiem.Text == "")
            {
                dgvNhanVien.DataSource = dt.NhanViens;
            }    
            else if (txtTimKiem.Text !=null)
            {
                dgvNhanVien.DataSource = dt.TKNV(txtTimKiem.Text);
            }    
        }
    }
}