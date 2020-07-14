using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class FormThongKeTonKho : Form
    {
        public FormThongKeTonKho()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void bt_XuatExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 4] = "Bảng Thống Kê Số Lượng Tồn "+cbbLoai.Text;
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Sản phẩm";
            worksheet.Cells[3, 3] = "Loại";
            worksheet.Cells[3, 4] = "Size";
            worksheet.Cells[3, 5] = "Màu";
            worksheet.Cells[3, 6] = "Số lượng tồn";


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            int dem = dataGridView1.RowCount;


            // Định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Đinh dạng cột
            worksheet.Range["A1"].ColumnWidth = 7;
            worksheet.Range["B1"].ColumnWidth = 35;
            worksheet.Range["C1"].ColumnWidth = 29;
            worksheet.Range["D1"].ColumnWidth = 33;
            worksheet.Range["E1"].ColumnWidth = 31;
            worksheet.Range["F1"].ColumnWidth = 22;



            // Định dạng font chữ
            //     worksheet.Range["A1", "J100"].Font.Name = "";
            worksheet.Range["A1", "A1000"].Font.Size = 24;
            worksheet.Range["A3", "J1000"].Font.Size = 16;
            worksheet.Range["A1", "F1"].MergeCells = true;
            worksheet.Range["A1", "F1"].Font.Bold = true;

            //worksheet.Range["A3", "J3"].MergeCells = true;
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
            worksheet.Range["G4", "F" + (dem + 4)].HorizontalAlignment = 3;

        }

        private void FormThongKeTonKho_Load(object sender, EventArgs e)
        {
            cbbLoai.DisplayMember = "Ten";
            cbbLoai.ValueMember = "Ma";
            cbbLoai.DataSource = dt.LoaiSPs;
            cbbLoai.SelectedValue = 1;
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            FormTrangChu FTC = new FormTrangChu();
            FTC.Show();
            this.Close();
        }

        private void cbbLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt.ThongKeSLTLoaiSP(Convert.ToInt32(cbbLoai.SelectedValue));
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells[4].Value) < 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                    

            }
            catch
            {

            }
        }
    }
}
