using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip_App.Model
{
    public class OperatorDAO
    {
        public static object GetDataFromDatabase()
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myOperator in db.Operator_Tables
                              select new
                              {
                                  id = myOperator.id,
                                  name = myOperator.name,
                                  password = myOperator.password,
                                  status = myOperator.status,
                              }).ToList();
                query = result;
            }

            return query;
        }

        //public static object GetDataByIDFromDatabase(int idParam)
        //{
        //    object query;
        //    using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
        //    {
        //        var result = (from myOperator in db.Operator_Tables where myOperator.id == idParam
        //                      select new
        //                      {
        //                          id = myOperator.id,
        //                          name = myOperator.name,
        //                          password = myOperator.password,
        //                          status = myOperator.status,
        //                      }).ToList();
        //        query = result;
        //    }

        //    return query;
        //}
        public static Operator GetDataByIDFromDatabase(int idParam)
        {
            Operator query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myOperator in db.Operator_Tables
                              where myOperator.id == idParam
                              select new
                              {
                                  id = myOperator.id,
                                  name = myOperator.name,
                                  password = myOperator.password,
                                  status = myOperator.status,
                              }).ToList();
                foreach(var item in result)
                {
                    query = new Operator(item.id,item.name,item.password,item.status);
                }
            }

            return query;
        }

        public static int CheckLogin(string user, string pass)
        {
            using(SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                //var result = (from myOperator in db.Operator_Tables
                //              where myOperator.id == 1);
                //var result = new SqlParameter
                //{
                //    ParameterName = "login",
                //    SqlDbType = System.Data.SqlDbType.Bit,
                //    Direction = System.Data.ParameterDirection.Output
                //};
                return db.tryLogin(user, pass);
            }
            
        }
        public static int getIdFromName(string name)
        {
            int id;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {

                IEnumerable<int> result = (from myOperator in db.Operator_Tables
                                           where myOperator.name == name
                                           select myOperator.id);

                id = result.FirstOrDefault();
            }
            return id;
        }

    }
}
