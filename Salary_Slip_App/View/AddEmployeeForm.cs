using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary_Slip_App.Controller;
using Salary_Slip_App.Model;

namespace Salary_Slip_App.View
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeController employeeController;
        private DepartmentController departmentController;
        private JobController jobController;

        public AddEmployeeForm()
        {
            InitializeComponent();

            this.employeeController = new EmployeeController(this);
            departmentController = new DepartmentController();
            jobController = new JobController();

            RegisterEventHandlers();

            setID();
            populateDepartmentComboBox();
            populateJobComboBox();
        }

        private void RegisterEventHandlers()
        {
            this.submitButton.Click += new System.EventHandler(
                this.employeeController.submitButton_Click);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.employeeController.alphabetTextBox_KeyPress);
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.employeeController.numericTextBox_KeyPress);
            this.addressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.employeeController.alphaNumericTextBox_KeyPress);

        }

        public void setID()
        {
            int nextId = employeeController.getID() + 1;
            idTextBox.Text = nextId.ToString();
        }

        private void populateDepartmentComboBox()
        {
            departmentComboBox.Items.Clear();
            departmentComboBox.Items.AddRange(departmentController.getNameFromDatabase());
            departmentComboBox.SelectedItem = departmentComboBox.Items[0];
        }
        private void populateJobComboBox()
        {
            jobComboBox.Items.Clear();
            jobComboBox.Items.AddRange(jobController.getNameFromDatabase());
            jobComboBox.SelectedItem = jobComboBox.Items[0];
        }
    }
}
