using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary_Slip_App.Controller;
using Salary_Slip_App.Model;
using Salary_Slip_App.View;

namespace Salary_Slip_App
{
    public class LoginController
    {
        private LoginForm loginForm;
        private OperatorController operatorController;

        public LoginController(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.operatorController = new OperatorController();
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            string myUsername = loginForm.userNameInput.Text;
            string myPassword = loginForm.passwordInput.Text;
            int myLogin = operatorController.GetCheckLoginFromDatabaseProcedure(myUsername, myPassword);

            if (myLogin != 0)
            {
                Operator result = operatorController.GetDataByIdFromDatabase(myLogin);
                new MainForm(result).Show();
                this.loginForm.Hide();
            }
            else
                MessageBox.Show("Your Credentials is not correct");
        }

        public void clearButton_Click(object sender, EventArgs e)
        {
            loginForm.clearButton_Click(sender,e);
        }

        public void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
