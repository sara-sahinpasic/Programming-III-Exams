
namespace cSharpIntroWinForms.IB140261.Report
{
    partial class frmIzvjestajIB140261
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDLWMS = new cSharpIntroWinForms.IB140261.Report.dsDLWMS();
            this.OcjeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDLWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OcjeneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsOcjene";
            reportDataSource1.Value = this.OcjeneBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cSharpIntroWinForms.IB140261.Report.rptOcjene.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsDLWMS
            // 
            this.dsDLWMS.DataSetName = "dsDLWMS";
            this.dsDLWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OcjeneBindingSource
            // 
            this.OcjeneBindingSource.DataMember = "Ocjene";
            this.OcjeneBindingSource.DataSource = this.dsDLWMS;
            // 
            // frmIzvjestajIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestajIB140261";
            this.Text = "frmIzvjestajIB140261";
            this.Load += new System.EventHandler(this.frmIzvjestajIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDLWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OcjeneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OcjeneBindingSource;
        private dsDLWMS dsDLWMS;
    }
}