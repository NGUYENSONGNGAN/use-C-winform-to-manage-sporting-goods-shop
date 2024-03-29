﻿using System;
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
    public partial class FormRPHDX : Form
    {
        public FormRPHDX()
        {
            InitializeComponent();
        }
        
        private void FormRPHDX_Load(object sender, EventArgs e)
        {
            int MaHD=0;
            if (FormThanhToan.TTTT.MoFormRP == 1)
            {
                MaHD = FormThanhToan.TTTT.Ma;
            }
            else if (FormHDX.TTHDX.MoFormRP == 1)
            {
                MaHD = FormHDX.TTHDX.MaHDX;
            }
            else if (FormQuetQRTimKiemHDX.TTTK.MoFormRP ==1)
            {
                MaHD = FormQuetQRTimKiemHDX.TTTK.MaHDX;
            }
            // TODO: This line of code loads data into the 'ttcmDataSet.selectRePortHDX' table. You can move, or remove it, as needed.
            this.selectRePortHDXTableAdapter.Fill(this.ttcmDataSet.selectRePortHDX, MaHD);
            this.TTHDXReportTableAdapter.Fill(this.ttcmDataSet.TTHDXReport, MaHD);
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
            else if (FormQuetQRTimKiemHDX.TTTK.MoFormRP ==1)
            {
                FormQuetQRTimKiemHDX.TTTK.MoFormRP = 0;
                FormQuetQRTimKiemHDX.TTTK.Load = 1;
                this.Close();
                //FormHDX FHDX = new FormHDX();
                //FHDX.Show();
            }
        }
    }
}
