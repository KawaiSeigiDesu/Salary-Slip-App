using Salary_Slip_App.Controller;
using Salary_Slip_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Salary_Slip_App.View
{
    public partial class AddPayslipForm : Form
    {
        private PayslipController payslipController;
        private EmployeeController employeeController;
        private JobController jobController;
        private Operator myOperator;
        public AddPayslipForm(Operator operatorParam)
        {
            InitializeComponent();
            payslipController = new PayslipController(this);
            employeeController = new EmployeeController();
            jobController = new JobController();
            myOperator = operatorParam;

            setLastID();
            PopulateEmployeeComboBox();
            setJobTitle();
            setBaseSalary();
            setOperatorName();
            monthCB.SelectedIndex = 1;
            setNetSalary();
          
            RegisterEventHandlers();
        }

        private void setNetSalary()
        {
            netSalaryOutput.Text = payslipController.calculateNetSalary().ToString();
        }

        private void RegisterEventHandlers()
        {
            this.submitButton.Click += new System.EventHandler(
                this.payslipController.submitButton_Click);
            this.allowInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.payslipController.ValidateMoneyInput);
            this.deducInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                this.payslipController.ValidateMoneyInput);
            this.employeeCB.SelectedIndexChanged += new System.EventHandler(
                this.payslipController.employeeCB_SelectedIndexChanged);
        }

        private void setOperatorName()
        {
            operatorOutput.Text = myOperator.Name;
            
        }

        private void setJobTitle()
        {
            payslipController.setJobTitle();
        }

        private void setBaseSalary()
        {
            payslipController.setBaseSalary();
        }

        private void PopulateEmployeeComboBox()
        {
            employeeCB.Items.Clear();
            employeeCB.Items.AddRange(employeeController.getNameFromDatabase());
            employeeCB.SelectedItem = employeeCB.Items[0];
        }

        public void setLastID()
        {
            int nextId = payslipController.getID() + 1;
            idOutput.Text = nextId.ToString();
        }


        //private void populateJobComboBox()
        //{
        //    jobComboBox.Items.Clear();
        //    jobComboBox.Items.AddRange(jobController.getNameFromDatabase());
        //    jobComboBox.SelectedItem = jobComboBox.Items[0]; 
        //}


    }
}