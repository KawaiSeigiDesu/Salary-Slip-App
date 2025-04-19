using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip_App.Model
{
    public class Job
    {
        #region Job Attribute
        private int id;
        private string jobTitle;
        private decimal baseSalary;
        private decimal healthInsurance;
        private decimal employmentInsurance;
        #endregion Job Attribute

        #region Constructor
        public Job()
        {

        }
        public Job(int id, string jobTitle, decimal baseSalary, decimal healthInsurance, decimal employmentInsurance)
        {
            this.id = id;
            this.jobTitle = jobTitle;
            this.baseSalary = baseSalary;
            this.healthInsurance = healthInsurance;
            this.employmentInsurance = employmentInsurance;
        }
        #endregion Constructor

        #region Getter & Setter
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public decimal BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        public decimal HealthInsurance
        {
            get { return healthInsurance; }
            set { healthInsurance = value; }
        }
        public decimal EmploymentInsurance
        {
            get { return employmentInsurance; }
            set { employmentInsurance = value; }
        }
        #endregion Getter & Setter

        public Job_Table ConvertToJobTable()
        {
            Job_Table data = new Job_Table
            {
                id = this.Id,
                title = this.JobTitle,
                baseSalary = this.baseSalary,
                healthInsurance = this.healthInsurance,
                employmentInsurance = this.employmentInsurance,
            };

            return data;
        }
    }
}
