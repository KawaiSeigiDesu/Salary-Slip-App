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
    public partial class ManageJobForm : Form
    {
        private JobController jobController;
        private EmployeeController employeeController;

        #region CONST
        private const string COLUMN_ID = "ID";
        private const string COLUMN_TITLE = "Title";
        private const string COLUMN_BASESALARY = "Base Salary";
        private const string DATA_BASESALARY = "BaseSalary";
        private const string COLUMN_HEALTHINSURANCE = "Health Insurance";
        private const string DATA_HEALTHINSURANCE = "HealthInsurance";
        private const string COLUMN_EMPLOYMENTINSURANCE = "Employment Insurance";
        private const string DATA_EMPLOYMENTINSURANCE = "EmploymentInsurance";
        #endregion CONST

        public ManageJobForm()
        {
            InitializeComponent();
            jobController = new JobController(this);
            employeeController = new EmployeeController();
            SetUpDataGridView();
            PopulateDataGridViewLINQ();
            populateJobComboBox();
            RegisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            this.searchButton.Click += new System.EventHandler(
                this.jobController.searchButton_Click);
            this.jobDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(
                this.jobController.jobDataGridView_CellClick);
            this.deleteButton.Click += new System.EventHandler(
                this.jobController.deleteButton_Click);
            this.updateButton.Click += new System.EventHandler(
                this.jobController.updateButton_Click);
        }

        private void SetUpDataGridView()
        {
            this.jobDataGridView.ColumnCount = 5;
            this.jobDataGridView.Columns[0].Name = COLUMN_ID;
            this.jobDataGridView.Columns[0].DataPropertyName = this.jobDataGridView.Columns[0].Name;
            this.jobDataGridView.Columns[0].HeaderText = this.jobDataGridView.Columns[0].Name;

            this.jobDataGridView.Columns[1].Name = COLUMN_TITLE;
            this.jobDataGridView.Columns[1].DataPropertyName = this.jobDataGridView.Columns[1].Name;
            this.jobDataGridView.Columns[1].HeaderText = this.jobDataGridView.Columns[1].Name;

            this.jobDataGridView.Columns[2].Name = COLUMN_BASESALARY;
            this.jobDataGridView.Columns[2].DataPropertyName = DATA_BASESALARY;
            this.jobDataGridView.Columns[2].HeaderText = this.jobDataGridView.Columns[2].Name;

            this.jobDataGridView.Columns[3].Name = COLUMN_HEALTHINSURANCE;
            this.jobDataGridView.Columns[3].DataPropertyName = DATA_HEALTHINSURANCE;
            this.jobDataGridView.Columns[3].HeaderText = this.jobDataGridView.Columns[3].Name;

            this.jobDataGridView.Columns[4].Name = COLUMN_EMPLOYMENTINSURANCE;
            this.jobDataGridView.Columns[4].DataPropertyName = DATA_EMPLOYMENTINSURANCE;
            this.jobDataGridView.Columns[4].HeaderText = this.jobDataGridView.Columns[4].Name;
        }

        public void PopulateDataGridViewLINQ()
        {
            this.jobDataGridView.DataSource = null;
            SetUpDataGridView();
            this.jobDataGridView.Rows.Clear();

            this.jobDataGridView.DataSource = jobController.GetDataFromDatabase();
        }

        public void PopulateDataGridViewLINQBySearch(object dataParam)
        {
            this.jobDataGridView.DataSource = null;
            SetUpDataGridView();

            this.jobDataGridView.Rows.Clear();

            this.jobDataGridView.DataSource = dataParam;
        }

        private void populateJobComboBox()
        {
            jobTitleCB.Items.Clear();
            jobTitleCB.Items.Add("");
            jobTitleCB.Items.AddRange(jobController.getNameFromDatabase());
            jobTitleCB.SelectedItem = jobTitleCB.Items[0];
        }

    }
}
