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
    public partial class FormThongKeKhachHang : Form
    {
        public FormThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
            this.Close();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void FormThongKeKhachHang_Load(object sender, EventArgs e)
        {
            dgvThongTin.DataSource = dt.TKKHmuagi();  
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_XuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 4] = "Bảng Thống Kê Khách Hàng Đã Mượn Gì " ;
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã Hóa Đơn";
            worksheet.Cells[3, 3] = "Khách Hàng";
            worksheet.Cells[3, 4] = "Sản Phẩm";
            worksheet.Cells[3, 5] = "Màu";
            worksheet.Cells[3, 6] = "Size";
            worksheet.Cells[3, 7] = "Số Lượng";

            for (int i = 0; i < dgvThongTin.RowCount; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = dgvThongTin.Rows[i].Cells[j].Value;
                }
            }
            int dem = dgvThongTin.RowCount;
        

            // Định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Đinh dạng cột
            worksheet.Range["A1"].ColumnWidth = 7;
            worksheet.Range["B1"].ColumnWidth = 25;
            worksheet.Range["C1"].ColumnWidth = 29;
            worksheet.Range["D1"].ColumnWidth = 33;
            worksheet.Range["E1"].ColumnWidth = 31;
            worksheet.Range["F1"].ColumnWidth = 22;
            worksheet.Range["G1"].ColumnWidth = 23;


            // Định dạng font chữ
            //     worksheet.Range["A1", "J100"].Font.Name = "";
            worksheet.Range["A1", "A100"].Font.Size = 24;
            worksheet.Range["A3", "J100"].Font.Size = 16;
            worksheet.Range["A1", "G1"].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;

            //worksheet.Range["A3", "J3"].MergeCells = true;
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
            worksheet.Range["G4", "G" + (dem + 4)].HorizontalAlignment = 3;


        }
    }
}
