using Salary_Slip_App.Model;
using Salary_Slip_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App.Controller
{
    public class EmployeeController
    {
        #region Constant Variable
        private const string numericPattern = @"^[\b0-9]+$";
        private const string alphabetPattern = @"^[\ba-zA-Z]+$";
        private const string alphaNumericPattern = @"^[\ba-zA-Z0-9 ]+$";
        #endregion Constant Variable

        private AddEmployeeForm addEmployeeForm;
        private ManageEmployeeForm manageEmployeeForm;

        private int selectedId;

        public EmployeeController(AddEmployeeForm addEmployeeForm)
        {
            this.addEmployeeForm = addEmployeeForm;
        }

        public EmployeeController(ManageEmployeeForm manageEmployeeForm)
        {
            this.manageEmployeeForm = manageEmployeeForm;
        }

        public EmployeeController() { }

        #region Regex Function
        private bool isNumeric(string input)
        {
            return Regex.IsMatch(input, numericPattern);
        }
        private bool isAlphabet(string input)
        {
            return Regex.IsMatch(input, alphabetPattern);
        }
        private bool isAlphaNumeric(string input)
        {
            return Regex.IsMatch(input, alphaNumericPattern);
        }
        #endregion Regex Function

        #region Events
        public void submitButton_Click(object sender, EventArgs e)
        {
            if (addEmployeeForm.nameTextBox.Text == "" || addEmployeeForm.phoneTextBox.Text == "" || addEmployeeForm.addressTextBox.Text == "")
            {
                MessageBox.Show("Please Input all required Field");
                return;
            }
            Employee newData = new Employee();

            newData.Id = int.Parse(addEmployeeForm.idTextBox.Text);
            newData.Name = addEmployeeForm.nameTextBox.Text;
            newData.PhoneNumber = addEmployeeForm.phoneTextBox.Text;
            newData.JobID = JobDAO.getIdFromName(addEmployeeForm.jobComboBox.SelectedItem.ToString());
            newData.DeptID = DepartmentDAO.getIdFromName(addEmployeeForm.departmentComboBox.Text);
            newData.Address = addEmployeeForm.addressTextBox.Text;
            newData.Status = true;

            EmployeeDAO.AddEmployeeToLINQ(newData);

            MessageBox.Show("New Employee Added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            addEmployeeForm.setID();
        }

        public void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isNumeric(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        public void alphabetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isAlphabet(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        public void alphaNumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isAlphaNumeric(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            string idParam = manageEmployeeForm.idTextBox.Text;
            string nameParam = manageEmployeeForm.nameTextBox.Text;
            string phoneNumberParam = manageEmployeeForm.phoneTextBox.Text;
            string jobParam = manageEmployeeForm.jobComboBox.SelectedItem.ToString();
            string deptParam = manageEmployeeForm.departmentComboBox.SelectedItem.ToString();
            string addressParam = manageEmployeeForm.addressTextBox.Text;

            manageEmployeeForm.PopulateDataGridViewLINQBySearch(EmployeeDAO.GetViewFromDatabaseBySearch(idParam, nameParam, phoneNumberParam, jobParam, deptParam, addressParam));
        }
        public void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(manageEmployeeForm.employeeDataGridView.Rows[e.RowIndex].Cells["id"].Value);
            }
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedId >= 0)
            {
                EmployeeDAO.DeleteDataFromDatabase(selectedId);
                manageEmployeeForm.PopulateDataGridViewLINQ();
                //LoadDataToDataGridView();
                selectedId = -1; // Reset selectedId
            }
        }
        public void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedId >= 0)
            {
                Employee newData = new Employee();

                newData.Name = manageEmployeeForm.nameTextBox.Text;
                newData.PhoneNumber = manageEmployeeForm.phoneTextBox.Text;
                newData.JobID = JobDAO.getIdFromName(manageEmployeeForm.jobComboBox.SelectedItem.ToString());
                newData.DeptID = DepartmentDAO.getIdFromName(manageEmployeeForm.departmentComboBox.Text);
                newData.Address = manageEmployeeForm.addressTextBox.Text;

                EmployeeDAO.updateData(selectedId, newData);
            }
        }

        #endregion Events

        public object GetViewFromDatabase()
        {
            return EmployeeDAO.GetViewFromDatabase();
        }

        public int getID()
        {
            return EmployeeDAO.getId();
        }

        public String[] getNameFromDatabase()
        {
            return EmployeeDAO.getNameFromDatabase();
        }

        
    }
}
