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
using Salary_Slip_App.Model;

namespace Salary_Slip_App.View
{
    public partial class ManageEmployeeForm : Form
    {
        private EmployeeController employeeController;
        private DepartmentController departmentController;
        private JobController jobController;

        #region CONST
        private const string COLUMN_ID = "ID";
        private const string COLUMN_NAME= "Name";
        private const string COLUMN_PHONENUMBER= "Phone Number";
        private const string DATA_PHONENUMBER = "PhoneNumber";
        private const string COLUMN_JOB = "Job";
        private const string COLUMN_DEPARTMENT = "Department";
        private const string COLUMN_ADDRESS = "Address";
        private const string COLUMN_STATUS = "Status";
        #endregion CONST

        public ManageEmployeeForm()
        {
            InitializeComponent();

            employeeController = new EmployeeController(this);
            departmentController = new DepartmentController();
            jobController = new JobController();

            SetUpDataGridView();
            PopulateDataGridViewLINQ();
            RegisterEventHandlers();

            populateJobComboBox();
            populateDepartmentComboBox();

        }

        

        

        private void RegisterEventHandlers()
        {
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.employeeController.numericTextBox_KeyPress);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.employeeController.alphabetTextBox_KeyPress);
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.employeeController.numericTextBox_KeyPress);
            this.addressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.employeeController.alphaNumericTextBox_KeyPress);
            this.searchButton.Click += new System.EventHandler(
                this.employeeController.searchButton_Click);
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(
                this.employeeController.employeeDataGridView_CellClick);
            this.deleteButton.Click += new System.EventHandler(
                this.employeeController.deleteButton_Click);
            this.updateButton.Click += new System.EventHandler(
                this.employeeController.updateButton_Click);
        }

        private void SetUpDataGridView()
        {
            this.employeeDataGridView.ColumnCount = 7;
            this.employeeDataGridView.Columns[0].Name = COLUMN_ID;
            this.employeeDataGridView.Columns[0].DataPropertyName = this.employeeDataGridView.Columns[0].Name;
            this.employeeDataGridView.Columns[0].HeaderText = this.employeeDataGridView.Columns[0].Name;
                 
            this.employeeDataGridView.Columns[1].Name = COLUMN_NAME;
            this.employeeDataGridView.Columns[1].DataPropertyName = this.employeeDataGridView.Columns[1].Name;
            this.employeeDataGridView.Columns[1].HeaderText = this.employeeDataGridView.Columns[1].Name;
                 
            this.employeeDataGridView.Columns[2].Name = COLUMN_PHONENUMBER;
            this.employeeDataGridView.Columns[2].DataPropertyName = DATA_PHONENUMBER;
            this.employeeDataGridView.Columns[2].HeaderText = this.employeeDataGridView.Columns[2].Name;
                 
            this.employeeDataGridView.Columns[3].Name = COLUMN_JOB;
            this.employeeDataGridView.Columns[3].DataPropertyName = this.employeeDataGridView.Columns[3].Name;
            this.employeeDataGridView.Columns[3].HeaderText = this.employeeDataGridView.Columns[3].Name;
                 
            this.employeeDataGridView.Columns[4].Name = COLUMN_DEPARTMENT;
            this.employeeDataGridView.Columns[4].DataPropertyName = this.employeeDataGridView.Columns[4].Name;
            this.employeeDataGridView.Columns[4].HeaderText = this.employeeDataGridView.Columns[4].Name;
                 
            this.employeeDataGridView.Columns[5].Name = COLUMN_ADDRESS;
            this.employeeDataGridView.Columns[5].DataPropertyName = this.employeeDataGridView.Columns[5].Name;
            this.employeeDataGridView.Columns[5].HeaderText = this.employeeDataGridView.Columns[5].Name;

            this.employeeDataGridView.Columns[6].Name = COLUMN_STATUS;
            this.employeeDataGridView.Columns[6].DataPropertyName = this.employeeDataGridView.Columns[6].Name;
            this.employeeDataGridView.Columns[6].HeaderText = this.employeeDataGridView.Columns[6].Name;
        }

        public void PopulateDataGridViewLINQ()
        {
            employeeDataGridView.DataSource = null;
            SetUpDataGridView();
            this.employeeDataGridView.Rows.Clear();

            this.employeeDataGridView.DataSource = employeeController.GetViewFromDatabase();
        }

        public void PopulateDataGridViewLINQBySearch(object dataParam)
        {
            this.employeeDataGridView.DataSource = null;
            SetUpDataGridView();
            this.employeeDataGridView.Rows.Clear();

            this.employeeDataGridView.DataSource = dataParam;
        }

        private void populateDepartmentComboBox()
        {
            departmentComboBox.Items.Clear();
            departmentComboBox.Items.Add("");
            departmentComboBox.Items.AddRange(departmentController.getNameFromDatabase());
            departmentComboBox.SelectedItem = departmentComboBox.Items[0];
        }

        private void populateJobComboBox()
        {
            jobComboBox.Items.Clear();
            jobComboBox.Items.Add("");
            jobComboBox.Items.AddRange(jobController.getNameFromDatabase());
            jobComboBox.SelectedItem = jobComboBox.Items[0];
        }

        
    }
}
