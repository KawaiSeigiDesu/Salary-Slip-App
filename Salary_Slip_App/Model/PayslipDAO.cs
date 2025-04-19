using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip_App.Model
{
    public class PayslipDAO
    {
        public static void AddPayslipToLINQ(Payslip payslipData)
        {
            Payslip_Table newPayslip = payslipData.ConvertToPayslipTable();

            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                db.Payslip_Tables.InsertOnSubmit(newPayslip);
                db.SubmitChanges();
            }
        }

        public static object GetViewFromDatabase()
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myPayslip in db.PayslipViews
                              select new
                              {
                                  id = myPayslip.ID,
                                  employee = myPayslip.Employee,
                                  Operator = myPayslip.Operator,
                                  year = myPayslip.Year.Year,
                                  month = DateTime.Parse(myPayslip.Year.Year + "-" + myPayslip.Month.Month + "-01 00:00:00").ToString("MMM"),
                                  basic = decimal.Parse(""+myPayslip.Base_Salary).ToString("C"),
                                  totalAllowance = decimal.Parse("" + myPayslip.Total_Allowance).ToString("C"),
                                  totalDeduction = decimal.Parse("" + myPayslip.Total_Deduction).ToString("C"),
                                  netSalary = decimal.Parse("" + myPayslip.Net_Salary).ToString("C"),
                                  status = myPayslip.Status,
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
                var result = (from myPayslip in db.Payslip_Tables
                              select new
                              {
                                  id = myPayslip.id
                              }).Count();
                query = result;
            }

            return query;
        }

        internal static object getDashboardView()
        {
            object query = null;
            using (SalarySlipAppDBMLDataContext db = new SalarySlipAppDBMLDataContext())
            {
                var result = (from myPayslip in db.DashboardViews
                              select new
                              {
                                  year = myPayslip.Year,
                                  month = myPayslip.Month,
                                  payslipamount = myPayslip.Payslip_Amount,
                                  totalexpense = decimal.Parse(""+myPayslip.Total_Expense).ToString("C"),
                              }).ToList();
                query = result;
            }

            return query;
        }
    }
}
