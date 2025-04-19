namespace Salary_Slip_App.View
{
    partial class AddDepartmentForm
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
            this.departmentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.managerCB = new System.Windows.Forms.ComboBox();
            this.managerNameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.departmentUnderline = new System.Windows.Forms.Panel();
            this.createDepartmentLabel = new System.Windows.Forms.Label();
            this.departmentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentPanel
            // 
            this.departmentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.departmentPanel.Controls.Add(this.panel1);
            this.departmentPanel.Controls.Add(this.departmentUnderline);
            this.departmentPanel.Controls.Add(this.createDepartmentLabel);
            this.departmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentPanel.Location = new System.Drawing.Point(0, 0);
            this.departmentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentPanel.Name = "departmentPanel";
            this.departmentPanel.Size = new System.Drawing.Size(676, 481);
            this.departmentPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.managerCB);
            this.panel1.Controls.Add(this.managerNameLabel);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Location = new System.Drawing.Point(190, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 234);
            this.panel1.TabIndex = 11;
            // 
            // managerCB
            // 
            this.managerCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.managerCB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.managerCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.managerCB.FormattingEnabled = true;
            this.managerCB.Location = new System.Drawing.Point(120, 122);
            this.managerCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managerCB.Name = "managerCB";
            this.managerCB.Size = new System.Drawing.Size(158, 25);
            this.managerCB.TabIndex = 2;
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.AutoSize = true;
            this.managerNameLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.managerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.managerNameLabel.Location = new System.Drawing.Point(29, 122);
            this.managerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(62, 17);
            this.managerNameLabel.TabIndex = 10;
            this.managerNameLabel.Text = "Manager";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.submitButton.Location = new System.Drawing.Point(22, 171);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(255, 27);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameLabel.Location = new System.Drawing.Point(50, 73);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.idLabel.Location = new System.Drawing.Point(71, 24);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 17);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.nameTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameTextBox.Location = new System.Drawing.Point(120, 73);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.idTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.idTextBox.Location = new System.Drawing.Point(120, 24);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(158, 18);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.Text = "01";
            // 
            // departmentUnderline
            // 
            this.departmentUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.departmentUnderline.Location = new System.Drawing.Point(44, 54);
            this.departmentUnderline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentUnderline.Name = "departmentUnderline";
            this.departmentUnderline.Size = new System.Drawing.Size(583, 1);
            this.departmentUnderline.TabIndex = 1;
            // 
            // createDepartmentLabel
            // 
            this.createDepartmentLabel.AutoSize = true;
            this.createDepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDepartmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.createDepartmentLabel.Location = new System.Drawing.Point(39, 15);
            this.createDepartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createDepartmentLabel.Name = "createDepartmentLabel";
            this.createDepartmentLabel.Size = new System.Drawing.Size(262, 31);
            this.createDepartmentLabel.TabIndex = 0;
            this.createDepartmentLabel.Text = "Create Department";
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 481);
            this.Controls.Add(this.departmentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDepartmentForm";
            this.Text = "AddDepartment";
            this.departmentPanel.ResumeLayout(false);
            this.departmentPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel departmentPanel;
        private System.Windows.Forms.Panel departmentUnderline;
        private System.Windows.Forms.Label createDepartmentLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label managerNameLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox idTextBox;
        public System.Windows.Forms.ComboBox managerCB;
    }
}