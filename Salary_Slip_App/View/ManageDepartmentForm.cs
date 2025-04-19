using Salary_Slip_App.Controller;
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
    public partial class ManageDepartmentForm : Form
    {

        private DepartmentController departmentController;
        private EmployeeController employeeController;

        #region CONST
        private const string COLUMN_ID = "ID";
        private const string COLUMN_NAME = "Name";
        private const string COLUMN_MANAGER = "Manager";
        #endregion CONST

        public ManageDepartmentForm()
        {
            InitializeComponent();
            departmentController = new DepartmentController(this);
            employeeController = new EmployeeController();
            SetUpDataGridView();
            PopulateDataGridViewLINQ();
            RegisterEventHandlers();
            populateManagerComboBox();
        }

        private void RegisterEventHandlers()
        {
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.departmentController.numericTextBox_KeyPress);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.departmentController.alphabetTextBox_KeyPress);
            this.searchButton.Click += new System.EventHandler(
                this.departmentController.searchButton_Click);
            this.departmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(
                this.departmentController.departmentDataGridView_CellClick);
            this.deleteButton.Click += new System.EventHandler(
                this.departmentController.deleteButton_Click);
            this.updateButton.Click += new System.EventHandler(
                this.departmentController.updateButton_Click);
        }

        private void SetUpDataGridView()
        {
            this.departmentDataGridView.ColumnCount = 3;
            this.departmentDataGridView.Columns[0].Name = COLUMN_ID;
            this.departmentDataGridView.Columns[0].DataPropertyName = this.departmentDataGridView.Columns[0].Name;
            this.departmentDataGridView.Columns[0].HeaderText = this.departmentDataGridView.Columns[0].Name;


            this.departmentDataGridView.Columns[1].Name = COLUMN_NAME;
            this.departmentDataGridView.Columns[1].DataPropertyName = this.departmentDataGridView.Columns[1].Name;
            this.departmentDataGridView.Columns[1].HeaderText = this.departmentDataGridView.Columns[1].Name;

            this.departmentDataGridView.Columns[2].Name = COLUMN_MANAGER;
            this.departmentDataGridView.Columns[2].DataPropertyName = this.departmentDataGridView.Columns[2].Name; ;
            this.departmentDataGridView.Columns[2].HeaderText = this.departmentDataGridView.Columns[2].Name;
            
        }

        public void PopulateDataGridViewLINQ()
        {
            this.departmentDataGridView.DataSource = null;

            SetUpDataGridView();
            this.departmentDataGridView.Rows.Clear();

            this.departmentDataGridView.DataSource = departmentController.GetViewFromDatabase();
        }
        public void PopulateDataGridViewLINQBySearch(object dataParam)
        {
            this.departmentDataGridView.DataSource = null;
            SetUpDataGridView();
            this.departmentDataGridView.Rows.Clear();

            this.departmentDataGridView.DataSource = dataParam;
        }
        private void populateManagerComboBox()
        {
            managerComboBox.Items.Clear();
            managerComboBox.Items.Add("");
            managerComboBox.Items.AddRange(employeeController.getNameFromDatabase());
            managerComboBox.SelectedItem = managerComboBox.Items[0];
        }

        
    }
}
