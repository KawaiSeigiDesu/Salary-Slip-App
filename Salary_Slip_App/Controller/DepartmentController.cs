using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary_Slip_App.Model;
using Salary_Slip_App.View;

namespace Salary_Slip_App.Controller
{
    public class DepartmentController
    {
        #region Constant Variable
        private const string numericPattern = @"^[\b0-9]+$";
        private const string alphabetPattern = @"^[\ba-zA-Z]+$";
        private const string alphaNumericPattern = @"^[\ba-zA-Z0-9 ]+$";
        #endregion Constant Variable

        private AddDepartmentForm addDepartmentForm;
        private ManageDepartmentForm manageDepartmentForm;
        private int selectedId;

        public DepartmentController()
        {
        }
        public DepartmentController(AddDepartmentForm addDepartmentForm)
        {
            this.addDepartmentForm = addDepartmentForm;
        }
        public DepartmentController(ManageDepartmentForm manageDepartmentForm)
        {
            this.manageDepartmentForm = manageDepartmentForm;

        }


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
            Department newData = new Department();

            newData.Id = int.Parse(addDepartmentForm.idTextBox.Text);
            newData.Name = addDepartmentForm.nameTextBox.Text;
            newData.ManagerId = EmployeeDAO.getIdFromName(addDepartmentForm.managerCB.SelectedItem.ToString());

            DepartmentDAO.AddDepartmentToLINQ(newData);
            MessageBox.Show("New Department Added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            addDepartmentForm.setID();
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

        public void searchButton_Click(object sender, EventArgs e)
        {
            string idParam = manageDepartmentForm.idTextBox.Text;
            string nameParam = manageDepartmentForm.nameTextBox.Text;
            string managerParam = manageDepartmentForm.managerComboBox.SelectedItem.ToString();

            manageDepartmentForm.PopulateDataGridViewLINQBySearch(DepartmentDAO.GetViewFromDatabaseBySearch(idParam, nameParam, managerParam));
        }

        public void departmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(manageDepartmentForm.departmentDataGridView.Rows[e.RowIndex].Cells["id"].Value);
            }
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedId >= 0)
            {
                DepartmentDAO.DeleteDataFromDatabase(selectedId);
                manageDepartmentForm.PopulateDataGridViewLINQ();
                //LoadDataToDataGridView();
                selectedId = -1; // Reset selectedId
            }
        }
        public void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedId >= 0)
            {
                Department newData = new Department();

                newData.Name = manageDepartmentForm.nameTextBox.Text;
                newData.ManagerId = EmployeeDAO.getIdFromName(manageDepartmentForm.managerComboBox.SelectedItem.ToString());


                DepartmentDAO.updateData(selectedId,newData);
            }
        }
        #endregion Events

        public object GetViewFromDatabase()
        {
            return DepartmentDAO.GetViewFromDatabase();
        }

        public int getID()
        {
            return DepartmentDAO.getId();
        }

        public string[] getNameFromDatabase()
        {
            return DepartmentDAO.getNameFromDatabase();
        }

        
    }
}
