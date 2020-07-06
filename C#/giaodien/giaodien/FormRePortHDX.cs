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
    public partial class FormRePortHDX : Form
    {
        public FormRePortHDX()
        {
            InitializeComponent();
        }
        int MaHD;
        private void FormRePortHDX_Load(object sender, EventArgs e)
        {
            if (FormThanhToan.TTTT.MoFormRP ==1)
            {
                MaHD = FormThanhToan.TTTT.Ma;
            }    
            else if (FormHDX.TTHDX.MoFormRP == 1)
            {
                MaHD = FormHDX.TTHDX.MaHDX;
            }    
            
            // TODO: This line of code loads data into the 'ttcmDataSet.selectRePortHDX' table. You can move, or remove it, as needed.
            this.selectRePortHDXTableAdapter.Fill(this.ttcmDataSet.selectRePortHDX,  MaHD);            
            this.reportViewer1.RefreshReport();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            if (FormThanhToan.TTTT.MoFormRP == 1)
            {
                FormThanhToan.TTTT.MoFormRP = 0;
                FormTrangChu FTC = new FormTrangChu();
                FTC.Show();
                this.Close();
            }
            else if (FormHDX.TTHDX.MoFormRP == 1)
            {
                FormHDX.TTHDX.MoFormRP = 0;
                this.Close();
            }    
            
        }
    }
}
