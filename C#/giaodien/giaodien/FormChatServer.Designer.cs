namespace giaodien
{
    partial class FormChatServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatServer));
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnGui = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // lsvMessage
            // 
            this.lsvMessage.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(3, 3);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(298, 266);
            this.lsvMessage.TabIndex = 23;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(3, 275);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(223, 50);
            this.txtMessage.TabIndex = 22;
            this.txtMessage.Text = "";
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnGui
            // 
            this.btnGui.AnimationHoverSpeed = 0.07F;
            this.btnGui.AnimationSpeed = 0.03F;
            this.btnGui.BaseColor1 = System.Drawing.SystemColors.Control;
            this.btnGui.BaseColor2 = System.Drawing.SystemColors.Control;
            this.btnGui.BorderColor = System.Drawing.Color.Black;
            this.btnGui.FocusedColor = System.Drawing.Color.Empty;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.Black;
            this.btnGui.Image = null;
            this.btnGui.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGui.Location = new System.Drawing.Point(232, 275);
            this.btnGui.Name = "btnGui";
            this.btnGui.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnGui.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnGui.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGui.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGui.OnHoverImage = null;
            this.btnGui.OnPressedColor = System.Drawing.Color.Black;
            this.btnGui.Size = new System.Drawing.Size(60, 42);
            this.btnGui.TabIndex = 24;
            this.btnGui.Text = "Gửi";
            this.btnGui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // FormChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(304, 328);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChatServer";
            this.Text = "FormChatServer";
            this.Load += new System.EventHandler(this.FormChatServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.RichTextBox txtMessage;
        private Guna.UI.WinForms.GunaGradientButton btnGui;
        // private Guna.UI.WinForms.GunaGradientButton btn_Gui;
    }
}