using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App.Model
{
    public class DepartmentDAO
    {
        public static void AddDepartmentToLINQ(Department departmentData)
        {
            Department_Table newDepartment = departmentData.ConvertToDepartmentTable();

            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                db.Department_Tables.InsertOnSubmit(newDepartment);
                db.SubmitChanges();
            }
        }
        public static void DeleteDataFromDatabase(int idParam)
        {
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                var entity = db.Department_Tables.SingleOrDefault(e => e.id == idParam);
                if (entity != null)
                {
                    db.Department_Tables.DeleteOnSubmit(entity);
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fatal Error Occurred, Data is still connected","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
        public static int getId()
        {
            int query;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myDepartment in db.Department_Tables
                              select new
                              {
                                  id = myDepartment.id
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
                var result = (from myDepartment in db.Department_Tables
                              select myDepartment.name).ToArray();
                query = result;
            }

            return query;
        }

        public static object GetViewFromDatabase()
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myDepartment in db.DepartmentViews
                              select new
                              {
                                  id = myDepartment.ID,
                                  name = myDepartment.Name,
                                  manager = myDepartment.Manager,
                              }).ToList();
                query = result;
            }

            return query;
        }

        public static int getIdFromName(string name)
        {
            int id;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                IEnumerable<int> result = (from myDepartment in db.Department_Tables
                                           where myDepartment.name == name
                                           select myDepartment.id);

                id = result.FirstOrDefault();
            }
            return id;
        }

        public static object GetViewFromDatabaseBySearch(string idParam, string nameParam, string managerParam)
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myDepartment in db.DepartmentViews 
                              where SqlMethods.Like("" + myDepartment.ID, "%" + idParam)
                              && SqlMethods.Like("" + myDepartment.Name, "%" + nameParam)
                              && SqlMethods.Like("" + myDepartment.Manager, "%" + managerParam)
                              select new
                              {
                                  id = myDepartment.ID,
                                  name = myDepartment.Name,
                                  manager = myDepartment.Manager,
                              }).ToList();
                query = result;
            }

            return query;
        }

        public static void updateData(int selectedId,Department newDepartmentData)
        {
            Department_Table newDepartment = newDepartmentData.ConvertToDepartmentTable();
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                var entity = db.Department_Tables.SingleOrDefault(e => e.id == selectedId);
                if (entity != null)
                {
                    if(newDepartment.name!= "")
                    {
                        entity.name = newDepartment.name;
                        MessageBox.Show("Update Name Success");
                    }
                    if(newDepartment.managerId != 0)
                    {
                        entity.managerId = newDepartment.managerId;
                        MessageBox.Show("Update Manager Success");
                    }
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
    }
}
