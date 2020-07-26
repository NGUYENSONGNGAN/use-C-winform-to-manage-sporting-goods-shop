using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class FormBackUpDuLieu : Form
    {
        public FormBackUpDuLieu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(giaodien.Properties.Settings.Default.Database1ConnectionString);

        private void btnThem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
                btnBackUp.Enabled = true;
            }
        }

        private void backup()
        {
            string database = con.Database.ToString();
            if (txtPath.Text == string.Empty)
            {
                MessageBox.Show("Chọn đường dẫn để lưu");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtPath.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("BackUp dữ liệu thành công", "Thành công");
                    btnBackUp.Enabled = false;
                }
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();

            try
            {
                if (txtPath.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa chọn đường dẫn để lưu");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtPath.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("BackUp dữ liệu thành công", "Thành công");
                        btnBackUp.Enabled = false;
                        this.Close();
                    }
                }

            }
            catch (Exception)
            {
                btnBackUp_Click(sender, e);
                //DialogResult b = MessageBox.Show("Bạn có chắc chắn backup dữ liệu không ?", "Back up", MessageBoxButtons.YesNo);
                //if (b == DialogResult.Yes)
                //{
                //    backup();
                //    this.Close();
                //}
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
