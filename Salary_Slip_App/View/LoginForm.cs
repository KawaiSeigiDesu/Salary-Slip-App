using Salary_Slip_App.Controller;
using Salary_Slip_App.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Slip_App
{
    public partial class LoginForm : Form
    {
        private LoginController loginController;

        public LoginForm()
        {
            InitializeComponent();

            this.loginController = new LoginController(this);
            RegisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            this.loginButton.Click += new System.EventHandler(this.loginController.loginButton_Click);
            this.clearButton.Click += new System.EventHandler(this.loginController.clearButton_Click);
            this.exitLabel.Click += new System.EventHandler(this.loginController.exitLabel_Click);
        }

        public void clearButton_Click(object sender, EventArgs e)
        {
            userNameInput.Clear();
            passwordInput.Clear();
            userNameInput.Focus();
        }
    }
}
