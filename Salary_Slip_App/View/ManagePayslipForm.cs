using Salary_Slip_App.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App.View
{
    public partial class ManagePayslipForm : Form
    {
        PayslipController payslipController;
        EmployeeController employeeController;

        #region CONST
        private const string COLUMN_ID = "ID";
        private const string COLUMN_EMPLOYEE = "Employee";
        private const string COLUMN_OPERATOR = "Operator";
        private const string COLUMN_YEAR = "Year";
        private const string COLUMN_MONTH = "Month";
        private const string COLUMN_BASIC = "Basic";
        private const string COLUMN_TOTALALLOWANCE = "Total Allowance";
        private const string DATA_TOTALALLOWANCE = "TotalAllowance";
        private const string COLUMN_TOTALDEDUCTION = "Total Deduction";
        private const string DATA_TOTALDEDUCTION = "TotalDeduction";
        private const string COLUMN_NETSALARY = "Net Salary";
        private const string DATA_NETSALARY = "NetSalary";
        private const string COLUMN_STATUS = "Status";
        #endregion CONST

        public ManagePayslipForm()
        {
            InitializeComponent();
            payslipController = new PayslipController(this);
            employeeController = new EmployeeController();
            SetUpDataGridView();
            PopulateDataGridViewLINQ();
            RegisterEventHandlers();
            populateEmployeeComboBox();

        }


        private void populateEmployeeComboBox()
        {
            employeeCB.Items.Clear();
            employeeCB.Items.Add("");
            employeeCB.Items.AddRange(employeeController.getNameFromDatabase());
            employeeCB.SelectedItem = employeeCB.Items[0];
        }
        public void RegisterEventHandlers()
        {
            this.printButton.Click += new System.EventHandler(
                this.payslipController.printButton_Click);
            this.payslipDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(
                this.payslipController.payslipDataGridView_CellClick);
            //TODO REGISTER
        }

        private void SetUpDataGridView()
        {
            this.payslipDataGridView.ColumnCount = 10;
            this.payslipDataGridView.Columns[0].Name = COLUMN_ID;
            this.payslipDataGridView.Columns[0].DataPropertyName = this.payslipDataGridView.Columns[0].Name;
            this.payslipDataGridView.Columns[0].HeaderText = this.payslipDataGridView.Columns[0].Name;

            this.payslipDataGridView.Columns[1].Name = COLUMN_EMPLOYEE;
            this.payslipDataGridView.Columns[1].DataPropertyName = this.payslipDataGridView.Columns[1].Name;
            this.payslipDataGridView.Columns[1].HeaderText = this.payslipDataGridView.Columns[1].Name;


            this.payslipDataGridView.Columns[2].Name = COLUMN_OPERATOR;
            this.payslipDataGridView.Columns[2].DataPropertyName = this.payslipDataGridView.Columns[2].Name;
            this.payslipDataGridView.Columns[2].HeaderText = this.payslipDataGridView.Columns[2].Name;

            this.payslipDataGridView.Columns[3].Name = COLUMN_YEAR;
            this.payslipDataGridView.Columns[3].DataPropertyName = this.payslipDataGridView.Columns[3].Name;
            this.payslipDataGridView.Columns[3].HeaderText = this.payslipDataGridView.Columns[3].Name;

            this.payslipDataGridView.Columns[4].Name = COLUMN_MONTH;
            this.payslipDataGridView.Columns[4].DataPropertyName = this.payslipDataGridView.Columns[4].Name;
            this.payslipDataGridView.Columns[4].HeaderText = this.payslipDataGridView.Columns[4].Name;

            this.payslipDataGridView.Columns[5].Name = COLUMN_BASIC;
            this.payslipDataGridView.Columns[5].DataPropertyName = this.payslipDataGridView.Columns[5].Name;
            this.payslipDataGridView.Columns[5].HeaderText = this.payslipDataGridView.Columns[5].Name;

            this.payslipDataGridView.Columns[6].Name = COLUMN_TOTALALLOWANCE;
            this.payslipDataGridView.Columns[6].DataPropertyName = DATA_TOTALALLOWANCE;
            this.payslipDataGridView.Columns[6].HeaderText = this.payslipDataGridView.Columns[6].Name;

            this.payslipDataGridView.Columns[7].Name = COLUMN_TOTALDEDUCTION;
            this.payslipDataGridView.Columns[7].DataPropertyName = DATA_TOTALDEDUCTION;
            this.payslipDataGridView.Columns[7].HeaderText = this.payslipDataGridView.Columns[7].Name;

            this.payslipDataGridView.Columns[8].Name = COLUMN_NETSALARY;
            this.payslipDataGridView.Columns[8].DataPropertyName = DATA_NETSALARY;
            this.payslipDataGridView.Columns[8].HeaderText = this.payslipDataGridView.Columns[8].Name;


            this.payslipDataGridView.Columns[9].Name = COLUMN_STATUS;
            this.payslipDataGridView.Columns[9].DataPropertyName = this.payslipDataGridView.Columns[9].Name;
            this.payslipDataGridView.Columns[9].HeaderText = this.payslipDataGridView.Columns[9].Name;
        }

        private void PopulateDataGridViewLINQ()
        {
            this.payslipDataGridView.Rows.Clear();

            this.payslipDataGridView.DataSource = payslipController.GetViewFromDatabase();
        }
    }
}
