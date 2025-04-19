using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip_App.Model
{
    public class Operator
    {
        #region Operator Attribute
        private int id;
        private string name;
        private string password;
        private bool status;
        #endregion Operator Attribute

        #region Constructor
        public Operator(int id, string name, string password, bool status)
        {
            this.id = id;
            this.name = name;
            this.password = password;
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
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion Getter & Setter

    }
}
