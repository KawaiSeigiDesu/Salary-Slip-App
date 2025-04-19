using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salary_Slip_App.View;

namespace Salary_Slip_App.Model
{
    public class Employee
    {
        #region Employee Attribute
        private int id;
        private string name;
        private string phoneNumber;
        private int jobID;
        private int deptID;
        private string address;
        private bool status;
        #endregion Employee Attribute

        #region Constructor
        public Employee()
        {

        }

        public Employee(int id, string name, string phoneNumber, int jobID, int deptID, string address, bool status)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.jobID = jobID;
            this.deptID = deptID;
            this.address = address;
            this.status = status;
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
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int JobID
        {
            get { return jobID; }
            set { jobID = value; }
        }
        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value;  }
        }
        #endregion Getter & Setter

        public Employee_Table ConvertToEmployeeTable()
        {
            Employee_Table data = new Employee_Table
            {
                id = this.Id,
                name = this.Name,
                phoneNumber = this.PhoneNumber,
                jobID = this.JobID,
                deptID = this.DeptID,
                address = this.Address,
                status = this.Status,
            };

            return data;
        }
    }
}
