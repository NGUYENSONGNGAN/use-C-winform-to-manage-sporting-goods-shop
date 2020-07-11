namespace Client
{
    partial class FormChatClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatClient));
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btn_Gui = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(438, -2);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 44;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(487, -2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 43;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(69, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(365, 41);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "0";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(12, 372);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(392, 70);
            this.txtMessage.TabIndex = 41;
            this.txtMessage.Text = "";
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // lsvMessage
            // 
            this.lsvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(12, 54);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(509, 312);
            this.lsvMessage.TabIndex = 40;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.Tile;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.lbTitle;
            // 
            // btn_Gui
            // 
            this.btn_Gui.AnimationHoverSpeed = 0.07F;
            this.btn_Gui.AnimationSpeed = 0.03F;
            this.btn_Gui.BaseColor1 = System.Drawing.Color.Transparent;
            this.btn_Gui.BaseColor2 = System.Drawing.Color.Transparent;
            this.btn_Gui.BorderColor = System.Drawing.Color.Black;
            this.btn_Gui.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Gui.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gui.ForeColor = System.Drawing.Color.Blue;
            this.btn_Gui.Image = null;
            this.btn_Gui.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Gui.Location = new System.Drawing.Point(422, 372);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_Gui.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Gui.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Gui.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Gui.OnHoverImage = null;
            this.btn_Gui.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Gui.Size = new System.Drawing.Size(99, 70);
            this.btn_Gui.TabIndex = 45;
            this.btn_Gui.Text = "Gửi";
            this.btn_Gui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // FormChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 448);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btn_Gui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChatClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChatClient";
            this.Load += new System.EventHandler(this.FormChatClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.ListView lsvMessage;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaGradientButton btn_Gui;
    }
}