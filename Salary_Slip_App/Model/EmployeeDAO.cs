using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App.Model
{
    public class EmployeeDAO
    {
        public static void AddEmployeeToLINQ(Employee employeeData)
        {
            Employee_Table newEmployee = employeeData.ConvertToEmployeeTable();

            using(SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                db.Employee_Tables.InsertOnSubmit(newEmployee);
                db.SubmitChanges();
            }
        }

        public static void DeleteDataFromDatabase(int idParam)
        {
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                
                var entity = db.Employee_Tables.SingleOrDefault(e => e.id == idParam);
                if (entity != null)
                {
                    entity.status = false;
                    db.SubmitChanges();
                }
            }
        }

        public static object GetViewFromDatabase()
        {
            object query = null;
            using(SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myEmployee in db.EmployeeViews
                              select new
                              {
                                  id = myEmployee.ID,
                                  name = myEmployee.Name,
                                  phoneNumber = myEmployee.Phone,
                                  job = myEmployee.Job,
                                  department = myEmployee.Department,
                                  address = myEmployee.Address,
                                  status = myEmployee.Status,
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
                var result = (from myEmployee in db.Employee_Tables
                              select new
                              {
                                  id = myEmployee.id
                              }).Count();
                query = result;
            }

            return query;
        }

        public static String[] getNameFromDatabase()
        {
            String[] query;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myEmployee in db.Employee_Tables
                              select myEmployee.name).ToArray();
                query = result;
            }

            return query;
        }
        public static int getIdFromName(string name)
        {
            int id;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                IEnumerable<int> result = (from myEmployee in db.Employee_Tables
                                           where myEmployee.name == name
                                           select myEmployee.id);

                id = result.FirstOrDefault();
            }
            return id;
        }

        public static string getJobFromName(string name)
        {
            string jobName;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                IEnumerable<string> result = (from myEmployee in db.Employee_Tables join myJob in db.Job_Tables on myEmployee.jobID equals myJob.id
                                           where myEmployee.name == name
                                           select myJob.title);

                jobName = result.FirstOrDefault();
            }
            return jobName;
        }

        public static object GetViewFromDatabaseBySearch(string idParam, string nameParam,
            string phoneNumberParam, string jobParam, string deptParam, string addressParam)
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myEmployee in db.EmployeeViews
                              where SqlMethods.Like("" + myEmployee.ID, "%" + idParam) && SqlMethods.Like("" + myEmployee.Name, "%" + nameParam)
                              && SqlMethods.Like("" + myEmployee.Phone, "%" + phoneNumberParam) && SqlMethods.Like("" + myEmployee.Job, "%" + jobParam)
                              && SqlMethods.Like("" + myEmployee.Department, "%" + deptParam) && SqlMethods.Like("" + myEmployee.Address, "%" + addressParam)
                              select new
                              {
                                  id = myEmployee.ID,
                                  name = myEmployee.Name,
                                  phoneNumber = myEmployee.Phone,
                                  job = myEmployee.Job,
                                  department = myEmployee.Department,
                                  address = myEmployee.Address,
                                  status = myEmployee.Status,
                              }).ToList();
                query = result;
            }

            return query;
        }

        public static void updateData(int selectedId, Employee newEmployeeData)
        {
            Employee_Table newEmployee = newEmployeeData.ConvertToEmployeeTable();
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                var entity = db.Employee_Tables.SingleOrDefault(e => e.id == selectedId);
                if (entity != null)
                {
                    if (newEmployee.name != "")
                    {
                        entity.name = newEmployee.name;
                        MessageBox.Show("Update Name Success");
                    }
                    if (newEmployee.phoneNumber != "")
                    {
                        entity.phoneNumber = newEmployee.phoneNumber;
                        MessageBox.Show("Update Phone Number Success");
                    }
                    if (newEmployee.jobID != 0 || newEmployee.jobID != entity.jobID)
                    {
                        entity.jobID = newEmployee.jobID;
                        MessageBox.Show("Update Title Success");
                    }
                    if(newEmployee.deptID != 0 || newEmployee.deptID != entity.deptID)
                    {
                        entity.deptID = newEmployee.deptID;
                        MessageBox.Show("Update Department Success");

                    }
                    if(newEmployee.address != "" || newEmployee.address != entity.address)
                    {
                        entity.address = newEmployee.address;
                        MessageBox.Show("Update Address Success");
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
