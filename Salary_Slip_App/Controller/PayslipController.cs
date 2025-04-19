using Salary_Slip_App.Model;
using Salary_Slip_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App.Controller
{
    public class PayslipController
    {
        private ManagePayslipForm managePayslipForm;
        private AddPayslipForm addPayslipForm;
        private int selectedId;

        public PayslipController() { }
        public PayslipController(ManagePayslipForm managePayslipForm)
        {
            this.managePayslipForm = managePayslipForm;
        }
        public PayslipController(AddPayslipForm addPayslipForm)
        {
            this.addPayslipForm = addPayslipForm;
        }

        #region Event Handlers
        public void submitButton_Click(object sender, EventArgs e)
        {
            Payslip newData = new Payslip();

            newData.Id = int.Parse(addPayslipForm.idOutput.Text);
            newData.EmployeeId = EmployeeDAO.getIdFromName(addPayslipForm.employeeCB.SelectedItem.ToString());
            newData.OperatorId = OperatorDAO.getIdFromName(addPayslipForm.operatorOutput.Text);
            newData.Basic = JobDAO.getIdFromName(addPayslipForm.jobOutput.Text);
            newData.Year = int.Parse(addPayslipForm.yearUpDownInput.Text);
            newData.Month = int.Parse((addPayslipForm.monthCB.SelectedIndex+1).ToString());
            newData.TotalAllowances = decimal.Parse(addPayslipForm.allowInput.Text);
            newData.TotalDeductions = decimal.Parse(addPayslipForm.deducInput.Text);
            newData.NetSalary = calculateNetSalary();
            MessageBox.Show(calculateNetSalary().ToString());
            newData.Status = true;


            PayslipDAO.AddPayslipToLINQ(newData);

            MessageBox.Show("Payslip Created", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            addPayslipForm.setLastID();
        }

        public void ValidateMoneyInput(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow control keys like backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits and one decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Ensure only one decimal point is allowed
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            // Validate the number of digits after the decimal point
            if (textBox.Text.Contains("."))
            {
                int decimalIndex = textBox.Text.IndexOf('.');
                string afterDecimal = textBox.Text.Substring(decimalIndex + 1);

                if (afterDecimal.Length >= 2 && textBox.SelectionStart > decimalIndex)
                {
                    e.Handled = true;
                }
            }
            
        }
        public void employeeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            setJobTitle();
            setBaseSalary();
        }
        #endregion Event Handlers

        public object GetViewFromDatabase()
        {
            return PayslipDAO.GetViewFromDatabase();
        }

        public void setJobTitle()
        {
            string employeeJob = addPayslipForm.employeeCB.SelectedItem.ToString();
            addPayslipForm.jobOutput.Text = EmployeeDAO.getJobFromName(employeeJob);
        }

        public void setBaseSalary()
        {
            string jobTitle = addPayslipForm.jobOutput.Text;
            addPayslipForm.baseSalaryOutput.Text = JobDAO.getjobBaseSalaryFromTitle(jobTitle).ToString();
        }
        public int getID()
        {
            return PayslipDAO.getId();
        }
        public decimal calculateNetSalary()
        {
            decimal baseSalary = JobDAO.getjobBaseSalaryFromTitle(addPayslipForm.jobOutput.Text);
            decimal allowance = decimal.Parse(addPayslipForm.allowInput.Text);
            decimal deduction = decimal.Parse(addPayslipForm.deducInput.Text);

            decimal total = baseSalary + allowance - deduction;
            return total;
        }

        internal object getDashboardView()
        {
            return PayslipDAO.getDashboardView();
        }

        public void payslipDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(managePayslipForm.payslipDataGridView.Rows[e.RowIndex].Cells["id"].Value);
            }
        }
        public void printButton_Click(object sender, EventArgs e)
        {
            if (selectedId >= 0)
            {
                SalaryReportViewer salaryReportViewer = new SalaryReportViewer();
                salaryReportViewer.Show();
            }
        }
    }
}
