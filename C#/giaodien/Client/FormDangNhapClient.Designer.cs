namespace Client
{
    partial class FormDangNhapClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhapClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.txtTen = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangNhap = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaControlBox2);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 30);
            this.panel1.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(410, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(365, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.White;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.FocusedLineColor = System.Drawing.Color.Aqua;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTen.Location = new System.Drawing.Point(30, 188);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.Size = new System.Drawing.Size(390, 46);
            this.txtTen.TabIndex = 1;
            this.txtTen.Text = "dhv";
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedLineColor = System.Drawing.Color.Aqua;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.Location = new System.Drawing.Point(30, 342);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Size = new System.Drawing.Size(390, 46);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "dhv0612@gmail.com";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập vào tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập vào Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(132, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AnimationHoverSpeed = 0.07F;
            this.btnDangNhap.AnimationSpeed = 0.03F;
            this.btnDangNhap.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnDangNhap.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnDangNhap.BorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDangNhap.Location = new System.Drawing.Point(124, 414);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnDangNhap.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnDangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangNhap.OnHoverImage = null;
            this.btnDangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangNhap.Size = new System.Drawing.Size(213, 57);
            this.btnDangNhap.TabIndex = 83;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // FormDangNhapClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 502);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDangNhapClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaLineTextBox txtTen;
        private Guna.UI.WinForms.GunaLineTextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaGradientButton btnDangNhap;
    }
}

