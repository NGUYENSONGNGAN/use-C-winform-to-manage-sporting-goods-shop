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
    public partial class FormCTHDN : Form
    {
        public FormCTHDN()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void FormCTHDN_Load(object sender, EventArgs e)
        {
            int ma = FormHDN.ThongTinHDN.Ma;
            // TODO: This line of code loads data into the 'mauSac_FormCTHDN.MauSac' table. You can move, or remove it, as needed.
            this.mauSacTableAdapter.Fill(this.mauSac_FormCTHDN.MauSac);
            // TODO: This line of code loads data into the 'size_FormCTHDN.Size' table. You can move, or remove it, as needed.
            this.sizeTableAdapter.Fill(this.size_FormCTHDN.Size);
            // TODO: This line of code loads data into the 'sanPham_FormCTHDN.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sanPham_FormCTHDN.SanPham);
            dgvCTHDN.AutoGenerateColumns = false;
            dgvCTHDN.DataSource = dt.CTHDNhaps.Where(s => s.Ma_HDN == ma);
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
