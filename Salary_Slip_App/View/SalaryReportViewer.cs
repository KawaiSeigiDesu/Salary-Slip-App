using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App.View
{
    public partial class SalaryReportViewer : Form
    {
        public SalaryReportViewer()
        {
            InitializeComponent();
        }

        private void SalaryReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salarySlipAppDataSet.PayslipViewReport' table. You can move, or remove it, as needed.
            this.payslipViewReportTableAdapter.Fill(this.salarySlipAppDataSet.PayslipViewReport);
            

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
