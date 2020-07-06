namespace giaodien
{
    partial class FormRePortHDX
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRePortHDX));
            this.selectRePortHDXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttcmDataSet = new giaodien.ttcmDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.selectRePortHDXTableAdapter = new giaodien.ttcmDataSet1TableAdapters.selectRePortHDXTableAdapter();
            this.ttcmDataSet1 = new giaodien.ttcmDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.selectRePortHDXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcmDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectRePortHDXBindingSource
            // 
            this.selectRePortHDXBindingSource.DataMember = "selectRePortHDX";
            this.selectRePortHDXBindingSource.DataSource = this.ttcmDataSet;
            // 
            // ttcmDataSet
            // 
            this.ttcmDataSet.DataSetName = "ttcmDataSet";
            this.ttcmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.selectRePortHDXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "giaodien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1135, 614);
            this.reportViewer1.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1090, -1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 1;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // selectRePortHDXTableAdapter
            // 
            this.selectRePortHDXTableAdapter.ClearBeforeFill = true;
            // 
            // ttcmDataSet1
            // 
            this.ttcmDataSet1.DataSetName = "ttcmDataSet1";
            this.ttcmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRePortHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 642);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRePortHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRePortHDX";
            this.Load += new System.EventHandler(this.FormRePortHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectRePortHDXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcmDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource selectRePortHDXBindingSource;
        private ttcmDataSet1 ttcmDataSet;
        private ttcmDataSet1TableAdapters.selectRePortHDXTableAdapter selectRePortHDXTableAdapter;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private ttcmDataSet1 ttcmDataSet1;
    }
}