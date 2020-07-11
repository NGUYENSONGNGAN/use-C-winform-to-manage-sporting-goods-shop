using DevExpress.XtraCharts;
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
    public partial class FormThongKeThuChi : Form
    {
        public FormThongKeThuChi()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void FormThongKeThuChi_Load(object sender, EventArgs e)
        {
            rbtThu.Checked = true;
            cbbNam.DisplayMember = "Nam";
            cbbNam.ValueMember = "Nam";
            cbbNam.DataSource = dt.NamBanHang();
            chartControl2.SeriesDataMember = "Thang";
            chartControl2.SeriesTemplate.ArgumentDataMember = "Thang";
            chartControl2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "TongTien" });
            chartControl2.SeriesTemplate.View = new StackedBarSeriesView();
            chartControl2.SeriesNameTemplate.BeginText = "";

            //   chartControl2.DataSource = dt.DOANHTHU_CUAQUY_THEONAM(Convert.ToInt32(comboBox1.SelectedValue.ToString())).ToList();
            //    chartControl2.SeriesDataMember = "Quater";
            //    chartControl2.SeriesTemplate.ArgumentDataMember = "Quater";
            //    chartControl2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Sum" });
            ////    chartControl2.SeriesTemplate.View = new StackedBarSeriesView();
            //    chartControl2.SeriesNameTemplate.BeginText = "Qúy ";

            //      dataGridView1.DataSource = dt.CTDOANHTHU_THEOQUY(Convert.ToInt32(comboBox1.SelectedValue.ToString()));

        }

        private void rbtThu_CheckedChanged(object sender, EventArgs e)
        {
            cbbNam.DisplayMember = "Nam";
            cbbNam.ValueMember = "Nam";
            cbbNam.DataSource = dt.NamBanHang();
        }

        private void rbtChi_CheckedChanged(object sender, EventArgs e)
        {
            cbbNam.DisplayMember = "Nam";
            cbbNam.ValueMember = "Nam";
            cbbNam.DataSource = dt.NamNhapHang();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
            this.Close();
        }

        private void cbbNam_SelectedValueChanged(object sender, EventArgs e)
        {

            if (rbtChi.Checked)
            {
                // chart1.DataSource = dt.TienNhapTheoThangCuaNam(Convert.ToInt32(cbbNam.SelectedValue)).ToList();
                chartControl2.DataSource = dt.TienNhapTheoThangCuaNam(Convert.ToInt32(cbbNam.SelectedValue)).ToList();
                chartControl2.SeriesDataMember = "Thang";
                chartControl2.SeriesTemplate.ArgumentDataMember = "Thang";
                chartControl2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "TongTien" });
                chartControl2.SeriesTemplate.View = new StackedBarSeriesView();
                chartControl2.SeriesNameTemplate.BeginText = "";
        //        dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt.DanhSachHDNTrongNam(Convert.ToInt32(cbbNam.SelectedValue));
            }
            else if (rbtThu.Checked)
            {
                chartControl2.DataSource = dt.TienBanTheoThangCuaNam(Convert.ToInt32(cbbNam.SelectedValue)).ToList();
                chartControl2.SeriesDataMember = "Thang";
                chartControl2.SeriesTemplate.ArgumentDataMember = "Thang";
                chartControl2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "TongTien" });
                chartControl2.SeriesTemplate.View = new StackedBarSeriesView();
                chartControl2.SeriesNameTemplate.BeginText = "";
        //        dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt.DanhSachHDXtTrongNam(Convert.ToInt32(cbbNam.SelectedValue));
            }    



            //  dataGridView1.DataSource = dt.CTDOANHTHU_THEOQUY(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
        }

        private void bt_XuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            try
            {
               
                if (rbtChi.Checked)
                {
                    // Dua du lieu vao excel
                    worksheet.Cells[1, 4] = "Bảng Thống Kê Tổng Tiền Nhập Của Năm " + cbbNam.SelectedValue.ToString();
                    worksheet.Cells[2, 3] = "";
                    worksheet.Cells[3, 1] = "STT";
                    worksheet.Cells[3, 2] = "Mã hóa đơn nhập";
                    worksheet.Cells[3, 3] = "Nhân viên";
                    worksheet.Cells[3, 4] = "Nhà cung cấp";
                    worksheet.Cells[3, 5] = "Ngày nhập";
                    worksheet.Cells[3, 6] = "Tổng tiền";

                    for (int i = 0; i < dataGridView1.RowCount ; i++)  //đếm stt
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            worksheet.Cells[i + 4, 1] = i + 1;
                            worksheet.Cells[i + 4, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    int dem = dataGridView1.RowCount;
                    int tongtienchi = 0;
                    foreach(var chi in dt.DanhSachHDNTrongNam(Convert.ToInt32(cbbNam.SelectedValue)))
                    {
                        tongtienchi = tongtienchi + Convert.ToInt32( chi.TongTien);
                    }

                    worksheet.Cells[dem + 4, 5] = "Tổng Tiền: ";
                    worksheet.Cells[dem + 4, 6] = tongtienchi;

                    // Định dạng trang
                    worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                    worksheet.PageSetup.LeftMargin = 0;
                    worksheet.PageSetup.RightMargin = 0;
                    worksheet.PageSetup.TopMargin = 0;
                    worksheet.PageSetup.BottomMargin = 0;

                    // Đinh dạng cột
                    worksheet.Range["A1"].ColumnWidth = 10;
                    worksheet.Range["B1"].ColumnWidth = 27;
                    worksheet.Range["C1"].ColumnWidth = 15;
                    worksheet.Range["D1"].ColumnWidth = 27;
                    worksheet.Range["E1"].ColumnWidth = 21;
                    worksheet.Range["F1"].ColumnWidth = 26;

                    // Định dạng font chữ
                    worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
                    worksheet.Range["A1", "A100"].Font.Size = 24;
                    worksheet.Range["A3", "J100"].Font.Size = 16;
                    worksheet.Range["A1", "F1"].MergeCells = true;
                    worksheet.Range["A1", "F1"].Font.Bold = true;


                    worksheet.Range["A3", "F3"].Font.Bold = true;

                    // kẻ bảng
                    worksheet.Range["A3", "F" + (dem + 3)].Borders.LineStyle = 1;


                    //Định dạng dòng text
                    worksheet.Range["A1", "F1"].HorizontalAlignment = 3;
                    worksheet.Range["A3", "F3"].HorizontalAlignment = 3;
                    worksheet.Range["A4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["B4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["C4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["D4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["E4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["F4", "F" + (dem + 4)].HorizontalAlignment = 3;


                }
                else if (rbtThu.Checked)
                {
                    // Dua du lieu vao excel
                    worksheet.Cells[1, 4] = "Bảng Thống Kê Tổng Tiền Bán Hàng Của Năm " + cbbNam.SelectedValue.ToString();
                    worksheet.Cells[2, 3] = "";
                    worksheet.Cells[3, 1] = "STT";
                    worksheet.Cells[3, 2] = "Mã hóa đơn Xuất";
                    worksheet.Cells[3, 3] = "Nhân viên";
                    worksheet.Cells[3, 4] = "Khách Hàng";
                    worksheet.Cells[3, 5] = "Ngày Xuất";
                    worksheet.Cells[3, 6] = "Ghi chú";
                    worksheet.Cells[3, 7] = "Tổng tiền";

                    for (int i = 0; i < dataGridView1.RowCount ; i++)  //đếm stt
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            worksheet.Cells[i + 4, 1] = i + 1;
                            worksheet.Cells[i + 4, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    int dem = dataGridView1.RowCount;
                    int tongtienthu = 0;
                    foreach (var thu in dt.DanhSachHDXtTrongNam(Convert.ToInt32(cbbNam.SelectedValue)))
                    {
                        tongtienthu = tongtienthu + Convert.ToInt32(thu.TongTien);
                    }

                    worksheet.Cells[dem + 4, 6] = "Tổng Tiền: ";
                    worksheet.Cells[dem + 4, 7] = tongtienthu;

                    // Định dạng trang
                    worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                    worksheet.PageSetup.LeftMargin = 0;
                    worksheet.PageSetup.RightMargin = 0;
                    worksheet.PageSetup.TopMargin = 0;
                    worksheet.PageSetup.BottomMargin = 0;

                    // Đinh dạng cột
                    worksheet.Range["A1"].ColumnWidth = 10;
                    worksheet.Range["B1"].ColumnWidth = 27;
                    worksheet.Range["C1"].ColumnWidth = 25;
                    worksheet.Range["D1"].ColumnWidth = 27;
                    worksheet.Range["E1"].ColumnWidth = 21;
                    worksheet.Range["F1"].ColumnWidth = 26;
                    worksheet.Range["G1"].ColumnWidth = 26;

                    // Định dạng font chữ
                    worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
                    worksheet.Range["A1", "A100"].Font.Size = 24;
                    worksheet.Range["A3", "J100"].Font.Size = 16;
                    worksheet.Range["A1", "G1"].MergeCells = true;
                    worksheet.Range["A1", "G1"].Font.Bold = true;


                    worksheet.Range["A3", "G3"].Font.Bold = true;

                    // kẻ bảng
                    worksheet.Range["A3", "G" + (dem + 3)].Borders.LineStyle = 1;


                    //Định dạng dòng text
                    worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
                    worksheet.Range["A3", "G3"].HorizontalAlignment = 3;
                    worksheet.Range["A4", "G" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["B4", "G" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["C4", "G" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["D4", "G" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["E4", "G" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["F4", "G" + (dem + 4)].HorizontalAlignment = 3;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui không tắt excel khi đang xuất hoặc kiểm tra lại kích hoạt office của bạn");
                Application.Exit();
            }
        }

}
}
