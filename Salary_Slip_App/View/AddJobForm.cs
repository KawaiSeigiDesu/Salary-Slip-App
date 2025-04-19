using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary_Slip_App.Controller;

namespace Salary_Slip_App.View
{
    public partial class AddJobForm : Form
    {
        private JobController jobController;

        public AddJobForm()
        {
            InitializeComponent();

            this.jobController = new JobController(this);

            RegisterEventHandlers();

            setID();
        }

        private void RegisterEventHandlers()
        {
            this.submitButton.Click += new System.EventHandler(
                this.jobController.submitButton_Click);
        }

        public void setID()
        {
            int nextId = jobController.getID() + 1;
            idTextBox.Text = nextId.ToString();
        }
    }
}
