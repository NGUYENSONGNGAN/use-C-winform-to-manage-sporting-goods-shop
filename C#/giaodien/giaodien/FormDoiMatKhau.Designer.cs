namespace giaodien
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtXacNhan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDoiMatKhau = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhauMoi.HintForeColor = System.Drawing.Color.Empty;
            this.txtMatKhauMoi.HintText = "Nhập vào mật khẩu mới";
            this.txtMatKhauMoi.isPassword = false;
            this.txtMatKhauMoi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMatKhauMoi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMatKhauMoi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMatKhauMoi.LineThickness = 4;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(269, 68);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(323, 37);
            this.txtMatKhauMoi.TabIndex = 4;
            this.txtMatKhauMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhan.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtXacNhan.HintForeColor = System.Drawing.Color.Empty;
            this.txtXacNhan.HintText = "Xác nhận mật khẩu mới";
            this.txtXacNhan.isPassword = false;
            this.txtXacNhan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtXacNhan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtXacNhan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtXacNhan.LineThickness = 4;
            this.txtXacNhan.Location = new System.Drawing.Point(269, 148);
            this.txtXacNhan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(323, 37);
            this.txtXacNhan.TabIndex = 5;
            this.txtXacNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Activecolor = System.Drawing.Color.LightCyan;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.LightCyan;
            this.btnDoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiMatKhau.BorderRadius = 0;
            this.btnDoiMatKhau.ButtonText = "Đổi mật khẩu";
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoiMatKhau.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Iconimage")));
            this.btnDoiMatKhau.Iconimage_right = null;
            this.btnDoiMatKhau.Iconimage_right_Selected = null;
            this.btnDoiMatKhau.Iconimage_Selected = null;
            this.btnDoiMatKhau.IconMarginLeft = 0;
            this.btnDoiMatKhau.IconMarginRight = 0;
            this.btnDoiMatKhau.IconRightVisible = true;
            this.btnDoiMatKhau.IconRightZoom = 0D;
            this.btnDoiMatKhau.IconVisible = true;
            this.btnDoiMatKhau.IconZoom = 90D;
            this.btnDoiMatKhau.IsTab = false;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(181, 234);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Normalcolor = System.Drawing.Color.LightCyan;
            this.btnDoiMatKhau.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnDoiMatKhau.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoiMatKhau.selected = false;
            this.btnDoiMatKhau.Size = new System.Drawing.Size(230, 48);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoiMatKhau.Textcolor = System.Drawing.Color.DimGray;
            this.btnDoiMatKhau.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click_1);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(562, -1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 7;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(607, 307);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMatKhauMoi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtXacNhan;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoiMatKhau;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}