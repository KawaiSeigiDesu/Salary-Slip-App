using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salary_Slip_App.Model;

namespace Salary_Slip_App.Controller
{
    public class OperatorController
    {
        public object GetDataFromDatabase()
        {
            return OperatorDAO.GetDataFromDatabase();
        }

        public Operator GetDataByIdFromDatabase(int idParam)
        {
            return OperatorDAO.GetDataByIDFromDatabase(idParam);
        }

        public int GetCheckLoginFromDatabaseProcedure(string username, string password)
        {
            return OperatorDAO.CheckLogin(username, password);
        }
    }
}
