using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary_Slip_App.Model;
using Salary_Slip_App.View;

namespace Salary_Slip_App.Controller
{
    public class JobController
    {
        private AddJobForm addJobForm;
        private ManageJobForm manageJobForm;
        private int selectedId;

        public JobController(AddJobForm addJobForm)
        {
            this.addJobForm = addJobForm;
        }

        public JobController(ManageJobForm manageJobForm)
        {
            this.manageJobForm = manageJobForm;
        }

        public JobController()
        {
        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            Job newData = new Job();

            newData.Id = int.Parse(addJobForm.idTextBox.Text);
            newData.JobTitle = addJobForm.jobTitleInput.Text;
            newData.BaseSalary = decimal.Parse(addJobForm.salaryInput.Text);
            newData.HealthInsurance = decimal.Parse(addJobForm.healthInsurInput.Text);
            newData.EmploymentInsurance = decimal.Parse(addJobForm.employeeInsurInput.Text);

            JobDAO.AddJobToLINQ(newData);

            MessageBox.Show("New Job Added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            addJobForm.setID();
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            string titleParam = manageJobForm.jobTitleCB.Text;
            string baseParam = manageJobForm.baseSalaryInput.Text;
            string healthParam = manageJobForm.HealthInsurInput.Text;
            string employmentParam = manageJobForm.employeeInsurInput.Text;

            manageJobForm.PopulateDataGridViewLINQBySearch(JobDAO.GetViewFromDatabaseBySearch(titleParam, baseParam, healthParam, employmentParam));
        }

        public object GetDataFromDatabase()
        {
            return JobDAO.GetDataFromDatabase();
        }

        public int getID()
        {
            return JobDAO.getId();
        }

        public string[] getNameFromDatabase()
        {
            return JobDAO.getNameFromDatabase();
        }

        public decimal getJobBaseSalaryFromTitle(string title)
        {
            return JobDAO.getjobBaseSalaryFromTitle(title);
        }
        public void jobDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(manageJobForm.jobDataGridView.Rows[e.RowIndex].Cells["id"].Value);
            }
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedId >= 0)
            {
                JobDAO.DeleteDataFromDatabase(selectedId);
                manageJobForm.PopulateDataGridViewLINQ();
                //LoadDataToDataGridView();
                selectedId = -1; // Reset selectedId
            }
        }
        public void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedId >= 0)
            {
                Job newData = new Job();

                try
                {
                    newData.BaseSalary = decimal.Parse(manageJobForm.baseSalaryInput.Text);
                }
                catch (Exception)
                {
                    newData.BaseSalary = 0;
                }
                try
                {
                    newData.HealthInsurance = decimal.Parse(manageJobForm.HealthInsurInput.Text);
                }
                catch (Exception)
                {
                    newData.HealthInsurance = 0;
                }
                try
                {
                    newData.EmploymentInsurance = decimal.Parse(manageJobForm.employeeInsurInput.Text);
                }
                catch (Exception)
                {
                    newData.EmploymentInsurance = 0;
                }

                JobDAO.updateData(selectedId, newData);
            }
        }
    }
}
