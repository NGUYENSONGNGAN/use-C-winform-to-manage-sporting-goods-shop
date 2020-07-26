using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraRichEdit.Fields;
using DevExpress.CodeParser;

namespace giaodien
{
    public partial class FormQuetQRTimKiemHDX : Form
    {

        public FormQuetQRTimKiemHDX()
        {
            InitializeComponent();
        }
        public class TTTK
        {
            public static int MaHDX;
            public static int MoFormRP;
            public static int Load = 1;
        }
        MJPEGStream Stream;
        private void FormQuetQRTimKiemHDX_Load(object sender, EventArgs e)
        {
            //txtURL.ResetText();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void btnKetNoi_Click(object sender, EventArgs e)
        {            
            if (btnKetNoi.Text == "Kết nối ứng dụng")
            {
                if (txtURL.Text.Trim() =="" ||txtURL.Text.Trim()== null)
                {
                    MessageBox.Show("Bạn chưa kết nối ứng dụng");
                }
                else
                {
                    picQR.Visible = true;
                    Stream = new MJPEGStream(txtURL.Text);
                    Stream.NewFrame += stream_NewFrame;
                    Stream.Start();
                    timer1.Enabled = true;
                    timer1.Start();
                    btnKetNoi.Text = "Ngắt ứng dụng";
                    btnKetNoi.Image = Image.FromFile("..//..//..//..//image//icondis.png");
                }
            }
            else
            {
                picQR.Visible = false;
                btnKetNoi.Text = "Kết nối ứng dụng";
                btnKetNoi.Image = Image.FromFile("..//..//..//..//image//iconconnect.png");
                timer1.Stop();
                Stream.Stop();
                timer1.Enabled = false;
            }
        }
        
        private void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            picQR.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader Reader = new BarcodeReader();
                if (Reader.Decode((Bitmap)picQR.Image) != null)
                {
                    Result result = Reader.Decode((Bitmap)picQR.Image);
                    if (result != null)
                    {
                        int temp;
                        string MaHDX = "";
                        MaHDX = result.ToString();
                        var HDX = dt.HDXuats.Where(s => s.Ma == Convert.ToInt32(MaHDX)).FirstOrDefault();
                        if (HDX == null || Convert.ToInt32(MaHDX) % 1 != 0 || int.TryParse(MaHDX, out temp) == false)
                        {
                            MessageBox.Show("Không có hóa đơn này\nXin mời kiểm tra lại", "Lỗi");
                        }
                        else if (HDX != null)
                        {
                            TTTK.MaHDX = Convert.ToInt32(MaHDX);
                            TTTK.MoFormRP = 1;
                            if (TTTK.Load == 1)
                            {
                                TTTK.Load++;
                                btnKetNoi_Click(sender, e);
                                FormRPHDX FRPHDX = new FormRPHDX();
                                FRPHDX.ShowDialog();
                            }
                        }
                    }
                }

                //else if (Reader.Decode((Bitmap)picQR.Image) == null)
                //{
                //    btnKetNoi_Click(sender, e);
                //    MessageBox.Show("Không tìm thấy QR");
                //}


            }
            catch (Exception)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           if (timer1.Enabled == true)
           {
                timer1.Enabled = false;
                timer1.Stop();
                Stream.Stop();
           }    
            FormHDX FHDX = new FormHDX();
            FHDX.Show();
            TTTK.MaHDX = 0;
            TTTK.MoFormRP = 0;
            this.Close();
        }

        private void FormQuetQRTimKiemHDX_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Stream.Stop();
            }
        }
    }
}