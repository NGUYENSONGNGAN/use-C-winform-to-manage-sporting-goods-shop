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
    public partial class FormGhiChuHuyHDX : Form
    {
        public FormGhiChuHuyHDX()
        {
            InitializeComponent();
        }
        public class TTDongForm
        {
            public static int HuyHDX;
            public static int ThayDoiTrangThaiHDX;
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int MaHD = 0; ;
            if (txtGhiChu.Text.Trim()==""|| txtGhiChu.Text.Trim()==null)
            {
                MessageBox.Show("Bạn phải nhập lý do hủy đơn", "Lỗi");
            }    
            else if(txtGhiChu.Text.Trim()!= "")
            {
                if (FormLapHoaDon.TTMHDX.MoFormGhiChuHuyHDX ==1)
                {
                    MaHD = FormLapHoaDon.TTMHDX.Ma;
                    TTDongForm.HuyHDX = 1;
                }
                else if (FormHDX.TTHDX.MoFormGhiChuHuy == 1)
                {
                    MaHD = FormHDX.TTHDX.MaHDX;
                    TTDongForm.ThayDoiTrangThaiHDX = 1;
                }    
                dt.updateTrangThaiHuy(MaHD, txtGhiChu.Text);
                foreach (var CTHDX in dt.CTHDXuats.Where(s=>s.Ma_HDX== MaHD))
                {
                    var CTSP = dt.CTSanPhams.Where(s => s.Ma_SP == CTHDX.Ma_SP)
                                            .Where(s => s.Ma_Size == CTHDX.Ma_Size)
                                            .Where(s => s.Ma_MauSac == CTHDX.Ma_MauSac)
                                            .FirstOrDefault();
                    dt.updateSLT(CTHDX.Ma_SP, CTHDX.Ma_Size, CTHDX.Ma_MauSac, CTSP.Soluong + CTHDX.SoLuong);
                    
                }
                FormLapHoaDon.TTMHDX.MoFormGhiChuHuyHDX = 0;
                FormHDX.TTHDX.MoFormGhiChuHuy = 0;
                MessageBox.Show("Hủy đơn thành công");                
                this.Hide();
            }           
        }

        private void FormGhiChuHuyHDX_Load(object sender, EventArgs e)
        {
            txtGhiChu.ResetText();
        }
    }
}
