using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary_Slip_App.Controller;

namespace Salary_Slip_App.View
{
    public partial class Dashboard : Form
    {
        private DepartmentController departmentController;
        private PayslipController payslipController;
        private EmployeeController employeeController;

        #region CONST
        private const string COLUMN_YEAR = "Year";
        private const string COLUMN_MONTH = "Month";
        private const string COLUMN_PAYSLIP = "Payslip Amount";
        private const string DATA_PAYSLIP = "PayslipAmount";
        private const string COLUMN_TOTAL = "Total Expense";
        private const string DATA_TOTAL = "TotalExpense";
        #endregion CONST

        public Dashboard()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            payslipController = new PayslipController();
            departmentController = new DepartmentController();

            setEmployeeSum();
            setDepartmentSum();
            setPayslipSum();
            SetUpDataGridView();
            PopulateDataGridViewLINQ();
        }

        private void PopulateDataGridViewLINQ()
        {
            this.dataGridView.DataSource = null;
            SetUpDataGridView();
            this.dataGridView.Rows.Clear();

            this.dataGridView.DataSource = payslipController.getDashboardView();
        }

        private void SetUpDataGridView()
        {
            this.dataGridView.ColumnCount = 4;
            this.dataGridView.Columns[0].Name = COLUMN_YEAR;
            this.dataGridView.Columns[0].DataPropertyName = this.dataGridView.Columns[0].Name;
            this.dataGridView.Columns[0].HeaderText = this.dataGridView.Columns[0].Name;

            this.dataGridView.Columns[1].Name = COLUMN_MONTH;
            this.dataGridView.Columns[1].DataPropertyName = this.dataGridView.Columns[1].Name;
            this.dataGridView.Columns[1].HeaderText = this.dataGridView.Columns[1].Name;

            this.dataGridView.Columns[2].Name = COLUMN_PAYSLIP;
            this.dataGridView.Columns[2].DataPropertyName = DATA_PAYSLIP;
            this.dataGridView.Columns[2].HeaderText = this.dataGridView.Columns[2].Name;

            this.dataGridView.Columns[3].Name = COLUMN_TOTAL;
            this.dataGridView.Columns[3].DataPropertyName = DATA_TOTAL;
            this.dataGridView.Columns[3].HeaderText = this.dataGridView.Columns[3].Name;

        }

        private void setPayslipSum()
        {
            sumPayslipPanel.Text = payslipController.getID().ToString();
        }

        private void setEmployeeSum()
        {
            sumEmployeeDashboard.Text = employeeController.getID().ToString();
        }

        private void setDepartmentSum()
        {
            sumDepartmentDashboard.Text = departmentController.getID().ToString();
        }
    }
}
