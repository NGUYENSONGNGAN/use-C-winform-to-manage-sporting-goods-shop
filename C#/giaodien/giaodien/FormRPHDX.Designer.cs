namespace giaodien
{
    partial class FormRPHDX
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRPHDX));
            this.selectRePortHDXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttcmDataSet = new giaodien.ttcmDataSet();
            this.TTHDXReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.selectRePortHDXTableAdapter = new giaodien.ttcmDataSetTableAdapters.selectRePortHDXTableAdapter();
            this.TTHDXReportTableAdapter = new giaodien.ttcmDataSetTableAdapters.TTHDXReportTableAdapter();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectRePortHDXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTHDXReportBindingSource)).BeginInit();
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
            // TTHDXReportBindingSource
            // 
            this.TTHDXReportBindingSource.DataMember = "TTHDXReport";
            this.TTHDXReportBindingSource.DataSource = this.ttcmDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.selectRePortHDXBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TTHDXReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "giaodien.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1098, 755);
            this.reportViewer1.TabIndex = 0;
            // 
            // selectRePortHDXTableAdapter
            // 
            this.selectRePortHDXTableAdapter.ClearBeforeFill = true;
            // 
            // TTHDXReportTableAdapter
            // 
            this.TTHDXReportTableAdapter.ClearBeforeFill = true;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1053, -4);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 1;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // FormRPHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 781);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRPHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRPHDX";
            this.Load += new System.EventHandler(this.FormRPHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectRePortHDXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTHDXReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource selectRePortHDXBindingSource;
        private ttcmDataSet ttcmDataSet;
        private ttcmDataSetTableAdapters.selectRePortHDXTableAdapter selectRePortHDXTableAdapter;
        private System.Windows.Forms.BindingSource TTHDXReportBindingSource;
        private ttcmDataSetTableAdapters.TTHDXReportTableAdapter TTHDXReportTableAdapter;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}