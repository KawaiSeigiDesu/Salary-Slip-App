using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Salary_Slip_App.Controller;
using Salary_Slip_App.Model;

namespace Salary_Slip_App.View
{
    public partial class MainForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        #region Global Variable
        private bool expand = false;
        private FlowLayoutPanel comboBoxParam;
        private MainFormController controller;
        private Dashboard dashboardForm;
        private Button[] buttons;
        private Operator myOperator;
        #endregion Global Variable

        #region Constant Variable
        public const string DASHBOARD_BUTTON_NAME = "dashboardButton";
        public const string EMPLOYEE_BUTTON_NAME = "employeeButton";
        public const string MANAGE_EMPLOYEE_BUTTON_NAME = "manageEmployeeButton";
        public const string ADD_EMPLOYEE_BUTTON_NAME = "addEmployeeButton";
        public const string DEPARTMENT_BUTTON_NAME = "departmentButton";
        public const string MANAGE_DEPARTMENTS_BUTTON_NAME = "manageDepartmentButton";
        public const string ADD_DEPARTMENTS_BUTTON_NAME = "addDepartmentButton";
        public const string JOB_BUTTON_NAME = "jobButton";
        public const string MANAGE_JOB_BUTTON_NAME = "manageJobButton";
        public const string ADD_JOB_BUTTON_NAME = "addJobButton";
        public const string PAYSLIP_BUTTON_NAME = "payslipButton";
        public const string VIEW_PAYSLIP_BUTTON_NAME = "viewPayslipButton";
        public const string ADD_PAYSLIP_BUTTON_NAME = "addPayslipButton";
        public const string LOGOUT_BUTTON_NAME = "logOutButton";

        public const int BUTTON_SUM = 14;
        #endregion Constant Variable

        public MainForm(Operator opParam)
        {
            InitializeComponent();
            populateButtonArrays();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            navPanel.Visible = false;
            controller = new MainFormController(this,opParam);
            myOperator = opParam;

            setProfile();
            RegisterEventHandlers();
            
        }

        private void setProfile()
        {
            usernameLabel.Text = myOperator.Name;
        }

        private void showDashboard()
        {
            this.SuspendLayout();
            clearForm();
            dashboardForm = new Dashboard();
            dashboardForm.TopLevel = false;
            this.mainPanel.Controls.Add(dashboardForm);
            dashboardForm.Show();
            this.ResumeLayout(false);
            

        }

        public void clearForm()
        {
            foreach (Control ctr in this.mainPanel.Controls)
            {
                if (ctr is Form)
                {
                    this.mainPanel.Controls.Remove(ctr);
                }
            }
        }

        #region Populate Button
        private void populateButtonArrays()
        {
            int i = 0;
            buttons = new Button[BUTTON_SUM];

            foreach(Control ctr in sidePanel.Controls)
            {
                if(ctr is Button)
                {
                    buttons[i] = (Button)ctr;
                    i++;
                }
                if(ctr is FlowLayoutPanel)
                {
                    foreach(Control control in ctr.Controls)
                    {
                        if(control is Button)
                        {
                        buttons[i] = (Button)control;
                        i++;

                        }
                    }
                }
            }
        }

        #endregion Populate Button

        #region Register Event
        private void RegisterEventHandlers()
        {
            foreach (Button button in buttons)
            {
                button.Click += new System.EventHandler(this.Button_Click);
            }

            foreach (Button button in buttons)
            {
                button.Leave += new System.EventHandler(this.Button_Leave);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            navPanel.Visible = true;
            switch (((Button)sender).Name)
            {
                case DASHBOARD_BUTTON_NAME:
                    dashboardButton_Click(sender,e);
                    break;
                case EMPLOYEE_BUTTON_NAME:
                    employeeButton_Click(sender, e);
                    break;
                case ADD_EMPLOYEE_BUTTON_NAME:
                    addEmployeeButton_Click(sender, e);
                    controller.addEmployeeButton_Click(sender, e);
                    break;
                case MANAGE_EMPLOYEE_BUTTON_NAME:
                    manageEmployeeButton_Click(sender, e);
                    controller.manageEmployeeButton_Click(sender, e);
                    break;
                case DEPARTMENT_BUTTON_NAME:
                    departmentButton_Click(sender, e);
                    break;
                case ADD_DEPARTMENTS_BUTTON_NAME:
                    addDepartmentButton_Click(sender, e);
                    controller.addDepartmentButton_Click(sender, e);
                    break;
                case MANAGE_DEPARTMENTS_BUTTON_NAME:
                    manageDepartmentButton_Click(sender, e);
                    controller.manageDepartmentButton_Click(sender, e);
                    break;
                case JOB_BUTTON_NAME:
                    jobButton_Click(sender, e);
                    break;
                case ADD_JOB_BUTTON_NAME:
                    addJobButton_Click(sender, e);
                    controller.addJobButton_Click(sender, e);
                    break;
                case MANAGE_JOB_BUTTON_NAME:
                    manageJobButton_Click(sender, e);
                    controller.manageJobButton_Click(sender, e);
                    break;
                case PAYSLIP_BUTTON_NAME:
                    payslipButton_Click(sender, e);
                    break;
                case ADD_PAYSLIP_BUTTON_NAME:
                    addPayslipButton_Click(sender, e);
                    controller.addPayslipButton_Click(sender, e);
                    break;
                case VIEW_PAYSLIP_BUTTON_NAME:
                    viewPayslipButton_Click(sender, e);
                    controller.viewPayslipButton_Click(sender, e);
                    break;
                case LOGOUT_BUTTON_NAME:
                    logOutButton_Click(sender, e);
                    break;
                default:
                    break;

            }
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case DASHBOARD_BUTTON_NAME:
                    dashboardButton_Leave(sender,e);
                    break;
                case EMPLOYEE_BUTTON_NAME:
                    employeeButton_Leave(sender,e);
                    break;
                case ADD_EMPLOYEE_BUTTON_NAME:
                    addEmployeeButton_Leave(sender,e);
                    break;
                case MANAGE_EMPLOYEE_BUTTON_NAME:
                    manageEmployeeButton_Leave(sender,e);
                    break;
                case DEPARTMENT_BUTTON_NAME:
                    departmentButton_Leave(sender,e);
                    break;
                case ADD_DEPARTMENTS_BUTTON_NAME:
                    addDepartmentButton_Leave(sender,e);
                    break;
                case MANAGE_DEPARTMENTS_BUTTON_NAME:
                    manageDepartmentButton_Leave(sender,e);
                    break;
                case JOB_BUTTON_NAME:
                    jobButton_Leave(sender, e);
                    break;
                case ADD_JOB_BUTTON_NAME:
                    addJobButton_Leave(sender, e);
                    break;
                case MANAGE_JOB_BUTTON_NAME:
                    manageJobButton_Leave(sender, e);
                    break;
                case PAYSLIP_BUTTON_NAME:
                    payslipButton_Leave(sender,e);
                    break;
                case ADD_PAYSLIP_BUTTON_NAME:
                    addPayslipButton_Leave(sender,e);
                    break;
                case VIEW_PAYSLIP_BUTTON_NAME:
                    viewPayslipButton_Leave (sender,e);
                    break;
                case LOGOUT_BUTTON_NAME:
                    logOutButton_Leave(sender,e);
                    break;
                default:
                    break;

            }
        }

        #endregion Register Event

        #region Init Timer
        private void InitializeTimer(FlowLayoutPanel comboBoxParam)
        {            
            this.comboBoxParam = comboBoxParam;

            this.timerComboBox.Tick -= new System.EventHandler(this.timerComboBox_Tick);
            this.timerComboBox.Tick += new System.EventHandler(this.timerComboBox_Tick);

            timerComboBox.Start();
        }

        #endregion Init Timer

        #region Dashboard Button Event
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            showDashboard();
            setPanelPos(dashboardButton);
            dashboardButton.BackColor = Color.FromArgb(46, 51, 73);
        }
        
        private void dashboardButton_Leave(object sender, EventArgs e)
        {
            dashboardButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion Dashboard Button Event

        #region Employee Button Event
        private void employeeButton_Click(object sender, EventArgs e)
        {
            employeeButton.BackColor = Color.FromArgb(46, 51, 73);
            InitializeTimer(employeeCB);
        }

        private void employeeButton_Leave(object sender, EventArgs e)
        {
            employeeButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            addEmployeeButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void addEmployeeButton_Leave(object sender, EventArgs e)
        {
            addEmployeeButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            manageEmployeeButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void manageEmployeeButton_Leave(object sender, EventArgs e)
        {
            manageEmployeeButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion Employee Button Event

        #region Department Button Event
        private void departmentButton_Click(object sender, EventArgs e)
        {
            departmentButton.BackColor = Color.FromArgb(46, 51, 73);
            InitializeTimer(departmentCB);
        }

        private void departmentButton_Leave(object sender, EventArgs e)
        {
            departmentButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            addDepartmentButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void addDepartmentButton_Leave(object sender, EventArgs e)
        {
            addDepartmentButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void manageDepartmentButton_Click(object sender, EventArgs e)
        {
            manageDepartmentButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void manageDepartmentButton_Leave(object sender, EventArgs e)
        {
            manageDepartmentButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion Department Button Event

        #region Job Button Event
        private void jobButton_Click(object sender, EventArgs e)
        {
            jobButton.BackColor = Color.FromArgb(46, 51, 73);
            InitializeTimer(jobCB);
        }

        private void jobButton_Leave(object sender, EventArgs e)
        {
            jobButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            addJobButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void addJobButton_Leave(object sender, EventArgs e)
        {
            addJobButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void manageJobButton_Click(object sender, EventArgs e)
        {
            manageJobButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void manageJobButton_Leave(object sender, EventArgs e)
        {
            manageJobButton.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion Job Button Event

        #region Payslip Button Event
        private void payslipButton_Click(object sender, EventArgs e)
        {
            payslipButton.BackColor = Color.FromArgb(46, 51, 73);
            InitializeTimer(payslipCB);
        }

        private void payslipButton_Leave(object sender, EventArgs e)
        {
            payslipButton.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void addPayslipButton_Click(object sender, EventArgs e)
        {
            addPayslipButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void addPayslipButton_Leave(object sender, EventArgs e)
        {
            addPayslipButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void viewPayslipButton_Click(object sender, EventArgs e)
        {
            viewPayslipButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void viewPayslipButton_Leave(object sender, EventArgs e)
        {
            viewPayslipButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion Payslip Button Event

        #region Logout Button Event
        private void logOutButton_Click(object sender, EventArgs e)
        {
            setPanelPos(logOutButton);
            logOutButton.BackColor = Color.FromArgb(46, 51, 73);

            new LoginForm().Show();
            this.Dispose();
        }

        private void logOutButton_Leave(object sender, EventArgs e)
        {
            logOutButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion Logout Button Event

        #region Timer Event
        private void timerComboBox_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                this.comboBoxParam.Height += 15;
                if (this.comboBoxParam.Height >= this.comboBoxParam.MaximumSize.Height)
                {
                    timerComboBox.Stop();
                    expand = true;
                }
            }
            else
            {
                this.comboBoxParam.Height -= 15;
                if (this.comboBoxParam.Height <= this.comboBoxParam.MinimumSize.Height)
                {
                    timerComboBox.Stop();
                    expand = false;
                }
            }

            navPanel.Height = this.comboBoxParam.Height;
            navPanel.Top = this.comboBoxParam.Top;
            navPanel.Left = this.comboBoxParam.Left;

        }

        #endregion Timer Event

        #region Set Panel
        private void setPanelPos(Button buttonParam)
        {
            navPanel.Height = buttonParam.Height;
            navPanel.Top = buttonParam.Top;
            navPanel.Left = buttonParam.Left;
        }

        #endregion Set Panel

    }
}
