using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip_App.Model
{
    public class Payslip
    {
        #region Salary Attribute
        private int id;
        private int employeeId;
        private int operatorId;
        private int year;
        private int month;
        private int basic;
        private decimal totalAllowances;
        private decimal totalDeductions;
        private decimal netSalary;
        private bool status;
        #endregion Salary Attribute

        #region Constructor

        public Payslip(int id, int employeeId, int operatorId, int year, int month, int basic, decimal totalAllowances, decimal totalDeductions, decimal netSalary, bool status)
        {
            this.id = id;
            this.employeeId = employeeId;
            this.operatorId = operatorId;
            this.year = year;
            this.month = month;
            this.basic = basic;
            this.totalAllowances = totalAllowances;
            this.totalDeductions = totalDeductions;
            this.netSalary = netSalary;
            this.status = status;
        }

        public Payslip()
        {

        }

        #endregion Constructor

        #region Getter & Setter
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }
        public int OperatorId
        {
            get { return this.operatorId; }
            set { this.operatorId = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        public int Basic
        {
            get { return this.basic; }
            set { this.basic = value; }
        }
        public decimal TotalAllowances
        {
            get { return this.totalAllowances; }
            set { this.totalAllowances = value; }
        }
        public decimal TotalDeductions
        {
            get { return this.totalDeductions; }
            set { this.totalDeductions = value; }
        }
        public decimal NetSalary
        {
            get { return this.netSalary; }
            set { this.netSalary = value; }
        }
        public bool Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        #endregion Getter & Setter

        public Payslip_Table ConvertToPayslipTable()
        {
            Payslip_Table data = new Payslip_Table
            {
                id = this.Id,
                employeeID = this.employeeId,
                operatorID = this.operatorId,
                year = DateTime.Parse(this.year.ToString() + "-" + this.month.ToString()+"-01 00:00:00"),
                month = DateTime.Parse(this.year.ToString() + "-" + this.month.ToString() + "-01 00:00:00"),
                jobIdBasic = this.basic,
                totalAllowance = this.totalAllowances,
                totalDeduction = this.totalDeductions,
                netSalary = this.netSalary,
                status = this.Status,
            };

            return data;
        }
    }
}
