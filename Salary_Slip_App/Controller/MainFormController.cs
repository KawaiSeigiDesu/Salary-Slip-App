using Salary_Slip_App.ENUM;
using Salary_Slip_App.Model;
using Salary_Slip_App.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App.Controller
{
    public class MainFormController
    {
        private MainForm mainForm;
        private Operator myOperator;
        
        public MainFormController(MainForm mainFormParam,Operator operatorParam)
        {
            mainForm = mainFormParam;
            myOperator = operatorParam;
        }

        private void showForm(FormEnum enumParam)
        {
            mainForm.SuspendLayout();
            mainForm.clearForm();

            Form formParam;

            switch (enumParam)
            {
                case FormEnum.AddDepartmentForm:
                    formParam = new AddDepartmentForm();
                    break;
                case FormEnum.AddEmployeeForm:
                    formParam = new AddEmployeeForm();
                    break;
                case FormEnum.AddPayslipForm:
                    formParam = new AddPayslipForm(myOperator);
                    break;
                case FormEnum.AddJobForm:
                    formParam = new AddJobForm();
                    break;
                case FormEnum.ManageJobForm:
                    formParam = new ManageJobForm();
                    break;
                case FormEnum.ManageDepartmentForm:
                    formParam = new ManageDepartmentForm();
                    break;
                case FormEnum.ManageEmployeeForm:
                    formParam = new ManageEmployeeForm();
                    break;
                case FormEnum.ViewPayslipForm:
                    formParam = new ManagePayslipForm();
                    break;
                default:
                    formParam = new Form();
                    break;
            }

            formParam.TopLevel = false;
            mainForm.mainPanel.Controls.Add(formParam);
            formParam.Show();
            mainForm.ResumeLayout(false);
        }


        public void viewPayslipButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.ViewPayslipForm);
        }

        public void addPayslipButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.AddPayslipForm);
        }

        public void manageDepartmentButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.ManageDepartmentForm);
        }

        public void addDepartmentButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.AddDepartmentForm);
        }

        public void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.ManageEmployeeForm);
        }

        public void addEmployeeButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.AddEmployeeForm);
        }

        public void manageJobButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.ManageJobForm);
        }

        public void addJobButton_Click(object sender, EventArgs e)
        {
            showForm(FormEnum.AddJobForm);
        }
    }
}
