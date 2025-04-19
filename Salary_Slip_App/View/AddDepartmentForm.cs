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
    public partial class AddDepartmentForm : Form
    {
        private DepartmentController departmentController;
        private EmployeeController employeeController;

        public AddDepartmentForm()
        {
            InitializeComponent();

            this.departmentController = new DepartmentController(this);
            employeeController = new EmployeeController();

            RegisterEventHandlers();

            setID();
            populateManagerComboBox();
        }

        private void RegisterEventHandlers()
        {
            this.submitButton.Click += new System.EventHandler(
                this.departmentController.submitButton_Click);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.departmentController.alphabetTextBox_KeyPress);
        }

        public void setID()
        {
            int nextId = departmentController.getID() + 1;
            idTextBox.Text = nextId.ToString();
        }

        private void populateManagerComboBox()
        {
            managerCB.Items.Clear();
            managerCB.Items.AddRange(employeeController.getNameFromDatabase());
            managerCB.SelectedItem = managerCB.Items[0];
        }
    }
}
