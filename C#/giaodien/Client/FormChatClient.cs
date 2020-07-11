using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormChatClient : Form
    {
        public FormChatClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        IPEndPoint IP;
        Socket client;
        void Connect()
        {

            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1997);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {

                client.Connect(IP);

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

  


        void Send()
        {
            if (txtMessage.Text != string.Empty)
            {
                KhachHang KH = dt.KhachHangs.Where(s => s.Ma == Convert.ToInt32(FormDangNhapClient.TTKH.MaKH)).FirstOrDefault();
                client.Send(Serialize(KH.Ten + ": " + txtMessage.Text));
            }
        }


        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deseriliaze(data);
                    AddMessage(message);
                }
            }
            catch
            {
                client.Close();
            }
        }

        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deseriliaze(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void FormChatClient_Load(object sender, EventArgs e)
        {
            KhachHang KH = dt.KhachHangs.Where(s => s.Ma == Convert.ToInt32(FormDangNhapClient.TTKH.MaKH)).FirstOrDefault();
            lbTitle.Text = KH.Ten;
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gui.PerformClick();
                txtMessage.Focus();
                txtMessage.ResetText();
            }
        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            Send();
            KhachHang KH = dt.KhachHangs.Where(s => s.Ma == Convert.ToInt32(FormDangNhapClient.TTKH.MaKH)).FirstOrDefault();
            AddMessage(KH.Ten + ": " + txtMessage.Text);
        }
    }
}
