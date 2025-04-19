namespace Salary_Slip_App.View
{
    partial class SalaryReportViewer
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
            this.salarySlipAppDataSet = new Salary_Slip_App.SalarySlipAppDataSet();
            this.payslipViewReportTableAdapter = new Salary_Slip_App.SalarySlipAppDataSetTableAdapters.PayslipViewReportTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.payslipViewReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.salarySlipAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipViewReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salarySlipAppDataSet
            // 
            this.salarySlipAppDataSet.DataSetName = "SalarySlipAppDataSet";
            this.salarySlipAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payslipViewReportTableAdapter
            // 
            this.payslipViewReportTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "viewReport";
            reportDataSource1.Value = this.payslipViewReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Salary_Slip_App.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1025, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // payslipViewReportBindingSource
            // 
            this.payslipViewReportBindingSource.DataMember = "PayslipViewReport";
            this.payslipViewReportBindingSource.DataSource = this.salarySlipAppDataSet;
            // 
            // SalaryReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalaryReportViewer";
            this.Text = "Salary Report Viewer";
            this.Load += new System.EventHandler(this.SalaryReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salarySlipAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payslipViewReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SalarySlipAppDataSet salarySlipAppDataSet;
        private SalarySlipAppDataSetTableAdapters.PayslipViewReportTableAdapter payslipViewReportTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource payslipViewReportBindingSource;
    }
}