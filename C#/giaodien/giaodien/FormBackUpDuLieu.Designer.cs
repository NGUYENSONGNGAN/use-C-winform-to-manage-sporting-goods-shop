namespace giaodien
{
    partial class FormBackUpDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackUpDuLieu));
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtPath = new Guna.UI.WinForms.GunaTextBox();
            this.btnThem = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBackUp = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.SuspendLayout();
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(134, 34);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(167, 37);
            this.gunaLabel4.TabIndex = 35;
            this.gunaLabel4.Text = "Backup Data";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Transparent;
            this.txtPath.BaseColor = System.Drawing.Color.White;
            this.txtPath.BorderColor = System.Drawing.Color.Silver;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.Enabled = false;
            this.txtPath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPath.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(12, 92);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.Size = new System.Drawing.Size(413, 42);
            this.txtPath.TabIndex = 34;
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnThem.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DimGray;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThem.Location = new System.Drawing.Point(12, 162);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnThem.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(182, 49);
            this.btnThem.TabIndex = 86;
            this.btnThem.Text = "Browser";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.AnimationHoverSpeed = 0.07F;
            this.btnBackUp.AnimationSpeed = 0.03F;
            this.btnBackUp.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnBackUp.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnBackUp.BorderColor = System.Drawing.Color.Black;
            this.btnBackUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackUp.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.Color.DimGray;
            this.btnBackUp.Image = ((System.Drawing.Image)(resources.GetObject("btnBackUp.Image")));
            this.btnBackUp.ImageSize = new System.Drawing.Size(45, 45);
            this.btnBackUp.Location = new System.Drawing.Point(244, 162);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.btnBackUp.OnHoverBaseColor2 = System.Drawing.Color.SkyBlue;
            this.btnBackUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackUp.OnHoverImage = null;
            this.btnBackUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackUp.Size = new System.Drawing.Size(181, 49);
            this.btnBackUp.TabIndex = 87;
            this.btnBackUp.Text = "Back up";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(393, -1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 88;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // FormBackUpDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 250);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBackUpDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBackUpDuLieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtPath;
        private Guna.UI.WinForms.GunaGradientButton btnThem;
        private Guna.UI.WinForms.GunaGradientButton btnBackUp;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}