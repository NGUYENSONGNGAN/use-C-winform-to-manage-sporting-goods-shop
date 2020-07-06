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
            public static int i;
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGhiChu.Text.Trim()==""|| txtGhiChu.Text.Trim()==null)
            {
                MessageBox.Show("Bạn phải nhập lý do hủy đơn", "Lỗi");
            }    
            else if(txtGhiChu.Text.Trim()!= "")
            {
                dt.updateTrangThaiHuy(FormLapHoaDon.TTMHDX.Ma, txtGhiChu.Text);
                foreach (var CTHDX in dt.CTHDXuats.Where(s=>s.Ma_HDX== FormLapHoaDon.TTMHDX.Ma))
                {
                    var CTSP = dt.CTSanPhams.Where(s => s.Ma_SP == CTHDX.Ma_SP)
                                            .Where(s => s.Ma_Size == CTHDX.Ma_Size)
                                            .Where(s => s.Ma_MauSac == CTHDX.Ma_MauSac)
                                            .FirstOrDefault();
                    dt.updateSLT(CTHDX.Ma_SP, CTHDX.Ma_Size, CTHDX.Ma_MauSac, CTSP.Soluong + CTHDX.SoLuong);
                }    
                MessageBox.Show("Hủy đơn thành công");
                TTDongForm.i = 1;
                this.Close();
            }           
        }
    }
}
