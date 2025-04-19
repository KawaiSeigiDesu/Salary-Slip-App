using Salary_Slip_App.View;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Salary_Slip_App.Model
{
    public class JobDAO
    {

        public static void AddJobToLINQ(Job jobData)
        {
            Job_Table newJob = jobData.ConvertToJobTable();

            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                db.Job_Tables.InsertOnSubmit(newJob);
                db.SubmitChanges();
            }
        }
        public static void DeleteDataFromDatabase(int idParam)
        {
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                var entity = db.Job_Tables.SingleOrDefault(e => e.id == idParam);
                if (entity != null)
                {
                    db.Job_Tables.DeleteOnSubmit(entity);
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fatal Error Occurred, Data is still connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public static object GetDataFromDatabase()
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myJob in db.Job_Tables
                              select new
                              {
                                  id = myJob.id,
                                  title = myJob.title,
                                  baseSalary = myJob.baseSalary,
                                  healthInsurance = myJob.healthInsurance,
                                  employmentInsurance = myJob.employmentInsurance,
                              }).ToList();
                query = result;
            }

            return query;
        }

        public static int getId()
        {
            int query;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myJob in db.Job_Tables
                              select new
                              {
                                  id = myJob.id
                              }).Count();
                query = result;
            }

            return query;
        }

        public static string[] getNameFromDatabase()
        {
            string[] query;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myJob in db.Job_Tables
                              select myJob.title).ToArray();
                query = result;
            }

            return query;
        }

        public static int getIdFromName(string name)
        {
            int id;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                IEnumerable<int> result = (from myJob in db.Job_Tables where myJob.title == name
                              select myJob.id);

                id = result.FirstOrDefault();
            }
            return id;
        }

        public static decimal getjobBaseSalaryFromTitle(string title)
        {
            decimal baseSalary;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                IEnumerable<decimal> result = (from myJob in db.Job_Tables
                                           where myJob.title == title
                                           select myJob.baseSalary);

                baseSalary = result.FirstOrDefault();
            }
            return baseSalary;
        }

        public static object GetViewFromDatabaseBySearch(string titleParam, string baseParam, string healthParam, string employmentParam)
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myJob in db.Job_Tables
                              where SqlMethods.Like("" + myJob.title, "%" + titleParam)
                              && SqlMethods.Like("" + myJob.baseSalary, "%" + baseParam)
                              && SqlMethods.Like("" + myJob.healthInsurance, "%" + healthParam)
                              && SqlMethods.Like("" + myJob.employmentInsurance, "%" + employmentParam)
                              select new
                              {
                                  id = myJob.id,
                                  title = myJob.title,
                                  baseSalary = myJob.baseSalary,
                                  healthInsurance = myJob.healthInsurance,
                                  employmentInsurance = myJob.employmentInsurance,
                              }).ToList();
                query = result;
            }

            return query;
        }
        public static void updateData(int selectedId, Job newJobData)
        {
            Job_Table newDepartment = newJobData.ConvertToJobTable();
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                var entity = db.Job_Tables.SingleOrDefault(e => e.id == selectedId);
                if (entity != null)
                {
                    if (newDepartment.baseSalary != 0)
                    {
                        entity.baseSalary = newDepartment.baseSalary;
                        MessageBox.Show("Update Base Salary Success");
                    }
                    if (newDepartment.healthInsurance != 0)
                    {
                        entity.healthInsurance = newDepartment.healthInsurance;
                        MessageBox.Show("Update Health Insurance Success");
                    }
                    if (newDepartment.employmentInsurance != 0)
                    {
                        entity.employmentInsurance = newDepartment.employmentInsurance;
                        MessageBox.Show("Update Employment Insurance Success");
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fatal Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
