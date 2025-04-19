namespace Salary_Slip_App.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.payslipCB = new System.Windows.Forms.FlowLayoutPanel();
            this.payslipButton = new System.Windows.Forms.Button();
            this.addPayslipButton = new System.Windows.Forms.Button();
            this.viewPayslipButton = new System.Windows.Forms.Button();
            this.jobCB = new System.Windows.Forms.FlowLayoutPanel();
            this.jobButton = new System.Windows.Forms.Button();
            this.addJobButton = new System.Windows.Forms.Button();
            this.manageJobButton = new System.Windows.Forms.Button();
            this.departmentCB = new System.Windows.Forms.FlowLayoutPanel();
            this.departmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.manageDepartmentButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.employeeCB = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.manageEmployeeButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.profilPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profilPict = new System.Windows.Forms.PictureBox();
            this.timerComboBox = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.payslipCB.SuspendLayout();
            this.jobCB.SuspendLayout();
            this.departmentCB.SuspendLayout();
            this.employeeCB.SuspendLayout();
            this.profilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilPict)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sidePanel.Controls.Add(this.navPanel);
            this.sidePanel.Controls.Add(this.payslipCB);
            this.sidePanel.Controls.Add(this.jobCB);
            this.sidePanel.Controls.Add(this.departmentCB);
            this.sidePanel.Controls.Add(this.logOutButton);
            this.sidePanel.Controls.Add(this.employeeCB);
            this.sidePanel.Controls.Add(this.dashboardButton);
            this.sidePanel.Controls.Add(this.profilPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(256, 592);
            this.sidePanel.TabIndex = 0;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.navPanel.Location = new System.Drawing.Point(3, 177);
            this.navPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(3, 80);
            this.navPanel.TabIndex = 2;
            // 
            // payslipCB
            // 
            this.payslipCB.Controls.Add(this.payslipButton);
            this.payslipCB.Controls.Add(this.addPayslipButton);
            this.payslipCB.Controls.Add(this.viewPayslipButton);
            this.payslipCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.payslipCB.Location = new System.Drawing.Point(0, 400);
            this.payslipCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payslipCB.MaximumSize = new System.Drawing.Size(256, 177);
            this.payslipCB.MinimumSize = new System.Drawing.Size(256, 57);
            this.payslipCB.Name = "payslipCB";
            this.payslipCB.Size = new System.Drawing.Size(256, 57);
            this.payslipCB.TabIndex = 3;
            // 
            // payslipButton
            // 
            this.payslipButton.FlatAppearance.BorderSize = 0;
            this.payslipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payslipButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payslipButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.payslipButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_money_25_1_;
            this.payslipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payslipButton.Location = new System.Drawing.Point(3, 2);
            this.payslipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payslipButton.Name = "payslipButton";
            this.payslipButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.payslipButton.Size = new System.Drawing.Size(248, 52);
            this.payslipButton.TabIndex = 1;
            this.payslipButton.Text = "Payslip";
            this.payslipButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payslipButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payslipButton.UseVisualStyleBackColor = true;
            // 
            // addPayslipButton
            // 
            this.addPayslipButton.FlatAppearance.BorderSize = 0;
            this.addPayslipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPayslipButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPayslipButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addPayslipButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.addPayslipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPayslipButton.Location = new System.Drawing.Point(3, 58);
            this.addPayslipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPayslipButton.Name = "addPayslipButton";
            this.addPayslipButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.addPayslipButton.Size = new System.Drawing.Size(256, 52);
            this.addPayslipButton.TabIndex = 1;
            this.addPayslipButton.Text = "Add Payslip";
            this.addPayslipButton.UseVisualStyleBackColor = true;
            // 
            // viewPayslipButton
            // 
            this.viewPayslipButton.FlatAppearance.BorderSize = 0;
            this.viewPayslipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPayslipButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPayslipButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.viewPayslipButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.viewPayslipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewPayslipButton.Location = new System.Drawing.Point(3, 114);
            this.viewPayslipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewPayslipButton.Name = "viewPayslipButton";
            this.viewPayslipButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.viewPayslipButton.Size = new System.Drawing.Size(256, 52);
            this.viewPayslipButton.TabIndex = 1;
            this.viewPayslipButton.Text = "Manage Payslip";
            this.viewPayslipButton.UseVisualStyleBackColor = true;
            // 
            // jobCB
            // 
            this.jobCB.Controls.Add(this.jobButton);
            this.jobCB.Controls.Add(this.addJobButton);
            this.jobCB.Controls.Add(this.manageJobButton);
            this.jobCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobCB.Location = new System.Drawing.Point(0, 343);
            this.jobCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobCB.MaximumSize = new System.Drawing.Size(256, 177);
            this.jobCB.MinimumSize = new System.Drawing.Size(256, 57);
            this.jobCB.Name = "jobCB";
            this.jobCB.Size = new System.Drawing.Size(256, 57);
            this.jobCB.TabIndex = 4;
            // 
            // jobButton
            // 
            this.jobButton.FlatAppearance.BorderSize = 0;
            this.jobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.jobButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_suitcase_25;
            this.jobButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobButton.Location = new System.Drawing.Point(3, 2);
            this.jobButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobButton.Name = "jobButton";
            this.jobButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.jobButton.Size = new System.Drawing.Size(248, 52);
            this.jobButton.TabIndex = 1;
            this.jobButton.Text = "Job";
            this.jobButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jobButton.UseVisualStyleBackColor = true;
            // 
            // addJobButton
            // 
            this.addJobButton.FlatAppearance.BorderSize = 0;
            this.addJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addJobButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addJobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addJobButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.addJobButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addJobButton.Location = new System.Drawing.Point(3, 58);
            this.addJobButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.addJobButton.Size = new System.Drawing.Size(248, 52);
            this.addJobButton.TabIndex = 1;
            this.addJobButton.Text = "Add Job";
            this.addJobButton.UseVisualStyleBackColor = true;
            // 
            // manageJobButton
            // 
            this.manageJobButton.FlatAppearance.BorderSize = 0;
            this.manageJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageJobButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageJobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.manageJobButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.manageJobButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageJobButton.Location = new System.Drawing.Point(3, 114);
            this.manageJobButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageJobButton.Name = "manageJobButton";
            this.manageJobButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.manageJobButton.Size = new System.Drawing.Size(248, 52);
            this.manageJobButton.TabIndex = 1;
            this.manageJobButton.Text = "Manage Job";
            this.manageJobButton.UseVisualStyleBackColor = true;
            // 
            // departmentCB
            // 
            this.departmentCB.Controls.Add(this.departmentButton);
            this.departmentCB.Controls.Add(this.addDepartmentButton);
            this.departmentCB.Controls.Add(this.manageDepartmentButton);
            this.departmentCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentCB.Location = new System.Drawing.Point(0, 286);
            this.departmentCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentCB.MaximumSize = new System.Drawing.Size(256, 177);
            this.departmentCB.MinimumSize = new System.Drawing.Size(256, 57);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(256, 57);
            this.departmentCB.TabIndex = 3;
            // 
            // departmentButton
            // 
            this.departmentButton.FlatAppearance.BorderSize = 0;
            this.departmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.departmentButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_department_25;
            this.departmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departmentButton.Location = new System.Drawing.Point(3, 2);
            this.departmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentButton.Name = "departmentButton";
            this.departmentButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.departmentButton.Size = new System.Drawing.Size(248, 52);
            this.departmentButton.TabIndex = 1;
            this.departmentButton.Text = "Department";
            this.departmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.departmentButton.UseVisualStyleBackColor = true;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.FlatAppearance.BorderSize = 0;
            this.addDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDepartmentButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addDepartmentButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.addDepartmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDepartmentButton.Location = new System.Drawing.Point(3, 58);
            this.addDepartmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.addDepartmentButton.Size = new System.Drawing.Size(256, 52);
            this.addDepartmentButton.TabIndex = 1;
            this.addDepartmentButton.Text = "Add Department";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // manageDepartmentButton
            // 
            this.manageDepartmentButton.FlatAppearance.BorderSize = 0;
            this.manageDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageDepartmentButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepartmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.manageDepartmentButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.manageDepartmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageDepartmentButton.Location = new System.Drawing.Point(3, 114);
            this.manageDepartmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageDepartmentButton.Name = "manageDepartmentButton";
            this.manageDepartmentButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.manageDepartmentButton.Size = new System.Drawing.Size(256, 52);
            this.manageDepartmentButton.TabIndex = 1;
            this.manageDepartmentButton.Text = "Manage Department";
            this.manageDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.logOutButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_log_out_25;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 540);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.logOutButton.Size = new System.Drawing.Size(256, 52);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // employeeCB
            // 
            this.employeeCB.Controls.Add(this.employeeButton);
            this.employeeCB.Controls.Add(this.addEmployeeButton);
            this.employeeCB.Controls.Add(this.manageEmployeeButton);
            this.employeeCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeCB.Location = new System.Drawing.Point(0, 229);
            this.employeeCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeCB.MaximumSize = new System.Drawing.Size(256, 177);
            this.employeeCB.MinimumSize = new System.Drawing.Size(256, 57);
            this.employeeCB.Name = "employeeCB";
            this.employeeCB.Size = new System.Drawing.Size(256, 57);
            this.employeeCB.TabIndex = 3;
            // 
            // employeeButton
            // 
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.employeeButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_employees_25;
            this.employeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeButton.Location = new System.Drawing.Point(3, 2);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.employeeButton.Size = new System.Drawing.Size(248, 52);
            this.employeeButton.TabIndex = 1;
            this.employeeButton.Text = "Employee";
            this.employeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeeButton.UseVisualStyleBackColor = true;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addEmployeeButton.FlatAppearance.BorderSize = 0;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addEmployeeButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.addEmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployeeButton.Location = new System.Drawing.Point(3, 58);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.addEmployeeButton.Size = new System.Drawing.Size(248, 52);
            this.addEmployeeButton.TabIndex = 1;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // manageEmployeeButton
            // 
            this.manageEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.manageEmployeeButton.FlatAppearance.BorderSize = 0;
            this.manageEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageEmployeeButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.manageEmployeeButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_dash_10;
            this.manageEmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageEmployeeButton.Location = new System.Drawing.Point(3, 114);
            this.manageEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageEmployeeButton.Name = "manageEmployeeButton";
            this.manageEmployeeButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.manageEmployeeButton.Size = new System.Drawing.Size(253, 52);
            this.manageEmployeeButton.TabIndex = 1;
            this.manageEmployeeButton.Text = "Manage Employee";
            this.manageEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dashboardButton.Image = global::Salary_Slip_App.Properties.Resources.icons8_home_25;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 177);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.dashboardButton.Size = new System.Drawing.Size(256, 52);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = true;
            // 
            // profilPanel
            // 
            this.profilPanel.Controls.Add(this.welcomeLabel);
            this.profilPanel.Controls.Add(this.usernameLabel);
            this.profilPanel.Controls.Add(this.profilPict);
            this.profilPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilPanel.Location = new System.Drawing.Point(0, 0);
            this.profilPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilPanel.Name = "profilPanel";
            this.profilPanel.Size = new System.Drawing.Size(256, 177);
            this.profilPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.welcomeLabel.Location = new System.Drawing.Point(85, 110);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(70, 15);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome,";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usernameLabel.Location = new System.Drawing.Point(68, 130);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(97, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "UserName";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // profilPict
            // 
            this.profilPict.Image = global::Salary_Slip_App.Properties.Resources.icons8_account_63;
            this.profilPict.Location = new System.Drawing.Point(80, 27);
            this.profilPict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilPict.Name = "profilPict";
            this.profilPict.Size = new System.Drawing.Size(84, 78);
            this.profilPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilPict.TabIndex = 0;
            this.profilPict.TabStop = false;
            // 
            // timerComboBox
            // 
            this.timerComboBox.Interval = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(255, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(901, 592);
            this.mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1156, 592);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.sidePanel.ResumeLayout(false);
            this.payslipCB.ResumeLayout(false);
            this.jobCB.ResumeLayout(false);
            this.departmentCB.ResumeLayout(false);
            this.employeeCB.ResumeLayout(false);
            this.profilPanel.ResumeLayout(false);
            this.profilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilPict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel profilPanel;
        private System.Windows.Forms.PictureBox profilPict;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button payslipButton;
        private System.Windows.Forms.Button departmentButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.FlowLayoutPanel employeeCB;
        private System.Windows.Forms.Button manageEmployeeButton;
        private System.Windows.Forms.Timer timerComboBox;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.FlowLayoutPanel departmentCB;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Button manageDepartmentButton;
        private System.Windows.Forms.FlowLayoutPanel payslipCB;
        private System.Windows.Forms.Button addPayslipButton;
        private System.Windows.Forms.Button viewPayslipButton;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel jobCB;
        private System.Windows.Forms.Button jobButton;
        private System.Windows.Forms.Button addJobButton;
        private System.Windows.Forms.Button manageJobButton;
    }
}