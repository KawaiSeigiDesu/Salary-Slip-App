using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip_App.Model
{
    public class Department
    {
        #region Employee Attribute
        private int id;
        private string name;
        private int managerId;
        #endregion Employee Attribute

        #region Constructor
        public Department()
        {

        }

        public Department(int id, string name, int managerId)
        {
            this.id = id;
            this.name = name;
            this.managerId = managerId;
        }
        #endregion Constructor

        #region Getter & Setter
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ManagerId
        {
            get { return managerId; }
            set { managerId = value; }
        }
        #endregion Getter & Setter

        public Department_Table ConvertToDepartmentTable()
        {
            Department_Table data = new Department_Table
            {
                id = this.Id,
                name = this.Name,
                managerId = this.ManagerId,
            };

            return data;
        }
    }
}
