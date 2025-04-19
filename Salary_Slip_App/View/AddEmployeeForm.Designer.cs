namespace Salary_Slip_App.View
{
    partial class AddEmployeeForm
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
            this.employeePanel = new System.Windows.Forms.Panel();
            this.inputDataPanel = new System.Windows.Forms.Panel();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.employeeUnderline = new System.Windows.Forms.Panel();
            this.addEmployeeLabel = new System.Windows.Forms.Label();
            this.employeePanel.SuspendLayout();
            this.inputDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeePanel
            // 
            this.employeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.employeePanel.Controls.Add(this.inputDataPanel);
            this.employeePanel.Controls.Add(this.employeeUnderline);
            this.employeePanel.Controls.Add(this.addEmployeeLabel);
            this.employeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePanel.Location = new System.Drawing.Point(0, 0);
            this.employeePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(901, 592);
            this.employeePanel.TabIndex = 4;
            // 
            // inputDataPanel
            // 
            this.inputDataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.inputDataPanel.Controls.Add(this.departmentLabel);
            this.inputDataPanel.Controls.Add(this.departmentComboBox);
            this.inputDataPanel.Controls.Add(this.phoneTextBox);
            this.inputDataPanel.Controls.Add(this.phoneLabel);
            this.inputDataPanel.Controls.Add(this.submitButton);
            this.inputDataPanel.Controls.Add(this.addressTextBox);
            this.inputDataPanel.Controls.Add(this.addressLabel);
            this.inputDataPanel.Controls.Add(this.jobLabel);
            this.inputDataPanel.Controls.Add(this.nameLabel);
            this.inputDataPanel.Controls.Add(this.idLabel);
            this.inputDataPanel.Controls.Add(this.nameTextBox);
            this.inputDataPanel.Controls.Add(this.idTextBox);
            this.inputDataPanel.Controls.Add(this.jobComboBox);
            this.inputDataPanel.Location = new System.Drawing.Point(254, 80);
            this.inputDataPanel.Name = "inputDataPanel";
            this.inputDataPanel.Size = new System.Drawing.Size(393, 455);
            this.inputDataPanel.TabIndex = 7;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.departmentLabel.Location = new System.Drawing.Point(15, 273);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(108, 23);
            this.departmentLabel.TabIndex = 16;
            this.departmentLabel.Text = "Department";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.departmentComboBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(160, 270);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(210, 29);
            this.departmentComboBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.phoneTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phoneTextBox.Location = new System.Drawing.Point(160, 150);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(210, 29);
            this.phoneTextBox.TabIndex = 2;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phoneLabel.Location = new System.Drawing.Point(64, 150);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(59, 23);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Phone";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.submitButton.Location = new System.Drawing.Point(30, 390);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(340, 33);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.addressTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addressTextBox.Location = new System.Drawing.Point(160, 330);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(210, 29);
            this.addressTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addressLabel.Location = new System.Drawing.Point(49, 330);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 23);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "Address";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.jobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jobLabel.Location = new System.Drawing.Point(84, 213);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(39, 23);
            this.jobLabel.TabIndex = 10;
            this.jobLabel.Text = "Job";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameLabel.Location = new System.Drawing.Point(66, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 23);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.idLabel.Location = new System.Drawing.Point(95, 29);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 23);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.nameTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameTextBox.Location = new System.Drawing.Point(160, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(210, 29);
            this.nameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.idTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.idTextBox.Location = new System.Drawing.Point(160, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(210, 22);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.Text = "01";
            // 
            // jobComboBox
            // 
            this.jobComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.jobComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobComboBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.jobComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Location = new System.Drawing.Point(160, 210);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(210, 29);
            this.jobComboBox.TabIndex = 3;
            // 
            // employeeUnderline
            // 
            this.employeeUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.employeeUnderline.Location = new System.Drawing.Point(59, 66);
            this.employeeUnderline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeUnderline.Name = "employeeUnderline";
            this.employeeUnderline.Size = new System.Drawing.Size(777, 1);
            this.employeeUnderline.TabIndex = 1;
            // 
            // addEmployeeLabel
            // 
            this.addEmployeeLabel.AutoSize = true;
            this.addEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.addEmployeeLabel.Location = new System.Drawing.Point(52, 18);
            this.addEmployeeLabel.Name = "addEmployeeLabel";
            this.addEmployeeLabel.Size = new System.Drawing.Size(251, 39);
            this.addEmployeeLabel.TabIndex = 0;
            this.addEmployeeLabel.Text = "Add Employee";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 592);
            this.Controls.Add(this.employeePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmployeeForm";
            this.Text = "addEmployee";
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.inputDataPanel.ResumeLayout(false);
            this.inputDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.Panel employeeUnderline;
        private System.Windows.Forms.Label addEmployeeLabel;
        private System.Windows.Forms.Panel inputDataPanel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        public System.Windows.Forms.ComboBox departmentComboBox;
        public System.Windows.Forms.TextBox phoneTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox idTextBox;
        public System.Windows.Forms.ComboBox jobComboBox;
    }
}