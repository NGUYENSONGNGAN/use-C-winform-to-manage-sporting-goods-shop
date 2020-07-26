namespace giaodien
{
    partial class FormQuetQRTimKiemHDX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuetQRTimKiemHDX));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI.WinForms.GunaGradientButton();
            this.panelQuetQR = new Guna.UI.WinForms.GunaPanel();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnKetNoi = new Guna.UI.WinForms.GunaButton();
            this.txtURL = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelQuetQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnBack.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(160, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelQuetQR
            // 
            this.panelQuetQR.Controls.Add(this.picQR);
            this.panelQuetQR.Controls.Add(this.btnKetNoi);
            this.panelQuetQR.Controls.Add(this.txtURL);
            this.panelQuetQR.Controls.Add(this.gunaLabel2);
            this.panelQuetQR.Location = new System.Drawing.Point(12, 62);
            this.panelQuetQR.Name = "panelQuetQR";
            this.panelQuetQR.Size = new System.Drawing.Size(400, 400);
            this.panelQuetQR.TabIndex = 56;
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(14, 153);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(372, 232);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 20;
            this.picQR.TabStop = false;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AnimationHoverSpeed = 0.07F;
            this.btnKetNoi.AnimationSpeed = 0.03F;
            this.btnKetNoi.BaseColor = System.Drawing.SystemColors.Control;
            this.btnKetNoi.BorderColor = System.Drawing.SystemColors.Control;
            this.btnKetNoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnKetNoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.ForeColor = System.Drawing.Color.Black;
            this.btnKetNoi.Image = global::giaodien.Properties.Resources.icons8_link_100;
            this.btnKetNoi.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKetNoi.Location = new System.Drawing.Point(141, 66);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.btnKetNoi.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnKetNoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKetNoi.OnHoverImage = null;
            this.btnKetNoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnKetNoi.Size = new System.Drawing.Size(245, 42);
            this.btnKetNoi.TabIndex = 17;
            this.btnKetNoi.Text = "Kết nối ứng dụng";
            this.btnKetNoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.Control;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtURL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.LineColor = System.Drawing.Color.Gray;
            this.txtURL.Location = new System.Drawing.Point(141, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.Size = new System.Drawing.Size(245, 33);
            this.txtURL.TabIndex = 17;
            this.txtURL.Text = "http://192.168.43.1:8080";
            this.txtURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(23, 25);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(56, 21);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "URL: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormQuetQRTimKiemHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 479);
            this.Controls.Add(this.panelQuetQR);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuetQRTimKiemHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuetQRTimKiemHDX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuetQRTimKiemHDX_FormClosing);
            this.Load += new System.EventHandler(this.FormQuetQRTimKiemHDX_Load);
            this.panel1.ResumeLayout(false);
            this.panelQuetQR.ResumeLayout(false);
            this.panelQuetQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton btnBack;
        private Guna.UI.WinForms.GunaPanel panelQuetQR;
        private System.Windows.Forms.PictureBox picQR;
        private Guna.UI.WinForms.GunaButton btnKetNoi;
        private Guna.UI.WinForms.GunaLineTextBox txtURL;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}