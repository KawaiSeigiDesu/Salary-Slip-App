namespace Salary_Slip_App.View
{
    partial class ManagePayslipForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewPayslipPanel = new System.Windows.Forms.Panel();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.payslipDataGridView = new System.Windows.Forms.DataGridView();
            this.menuViewPanel = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.employeeCB = new System.Windows.Forms.ComboBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearUpDownInput = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.viewPayslipUnderline = new System.Windows.Forms.Panel();
            this.managePayslipLabel = new System.Windows.Forms.Label();
            this.viewPayslipPanel.SuspendLayout();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payslipDataGridView)).BeginInit();
            this.menuViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDownInput)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPayslipPanel
            // 
            this.viewPayslipPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.viewPayslipPanel.Controls.Add(this.dataGridPanel);
            this.viewPayslipPanel.Controls.Add(this.menuViewPanel);
            this.viewPayslipPanel.Controls.Add(this.viewPayslipUnderline);
            this.viewPayslipPanel.Controls.Add(this.managePayslipLabel);
            this.viewPayslipPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPayslipPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPayslipPanel.Margin = new System.Windows.Forms.Padding(2);
            this.viewPayslipPanel.Name = "viewPayslipPanel";
            this.viewPayslipPanel.Size = new System.Drawing.Size(676, 481);
            this.viewPayslipPanel.TabIndex = 5;
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.dataGridPanel.Controls.Add(this.payslipDataGridView);
            this.dataGridPanel.Location = new System.Drawing.Point(44, 188);
            this.dataGridPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Size = new System.Drawing.Size(583, 257);
            this.dataGridPanel.TabIndex = 3;
            // 
            // payslipDataGridView
            // 
            this.payslipDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.payslipDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payslipDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.payslipDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payslipDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payslipDataGridView.Location = new System.Drawing.Point(0, 0);
            this.payslipDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.payslipDataGridView.Name = "payslipDataGridView";
            this.payslipDataGridView.RowHeadersVisible = false;
            this.payslipDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.payslipDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.payslipDataGridView.RowTemplate.Height = 27;
            this.payslipDataGridView.RowTemplate.ReadOnly = true;
            this.payslipDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payslipDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payslipDataGridView.Size = new System.Drawing.Size(583, 257);
            this.payslipDataGridView.TabIndex = 4;
            // 
            // menuViewPanel
            // 
            this.menuViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.menuViewPanel.Controls.Add(this.printButton);
            this.menuViewPanel.Controls.Add(this.searchButton);
            this.menuViewPanel.Controls.Add(this.employeeCB);
            this.menuViewPanel.Controls.Add(this.employeeLabel);
            this.menuViewPanel.Controls.Add(this.monthCB);
            this.menuViewPanel.Controls.Add(this.monthLabel);
            this.menuViewPanel.Controls.Add(this.yearUpDownInput);
            this.menuViewPanel.Controls.Add(this.yearLabel);
            this.menuViewPanel.Location = new System.Drawing.Point(44, 71);
            this.menuViewPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuViewPanel.Name = "menuViewPanel";
            this.menuViewPanel.Size = new System.Drawing.Size(583, 100);
            this.menuViewPanel.TabIndex = 2;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.printButton.ForeColor = System.Drawing.Color.Black;
            this.printButton.Location = new System.Drawing.Point(327, 63);
            this.printButton.Margin = new System.Windows.Forms.Padding(2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(113, 27);
            this.printButton.TabIndex = 19;
            this.printButton.Text = "Print to PDF\r\n";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Green;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchButton.Location = new System.Drawing.Point(164, 63);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(93, 27);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // employeeCB
            // 
            this.employeeCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.employeeCB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.employeeCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeCB.FormattingEnabled = true;
            this.employeeCB.Location = new System.Drawing.Point(410, 26);
            this.employeeCB.Margin = new System.Windows.Forms.Padding(2);
            this.employeeCB.Name = "employeeCB";
            this.employeeCB.Size = new System.Drawing.Size(158, 25);
            this.employeeCB.TabIndex = 3;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeLabel.Location = new System.Drawing.Point(406, 8);
            this.employeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(68, 17);
            this.employeeLabel.TabIndex = 18;
            this.employeeLabel.Text = "Employee";
            // 
            // monthCB
            // 
            this.monthCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.monthCB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.monthCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Items.AddRange(new object[] {
            "",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Des"});
            this.monthCB.Location = new System.Drawing.Point(212, 26);
            this.monthCB.Margin = new System.Windows.Forms.Padding(2);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(158, 25);
            this.monthCB.TabIndex = 2;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.monthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.monthLabel.Location = new System.Drawing.Point(208, 8);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(49, 17);
            this.monthLabel.TabIndex = 16;
            this.monthLabel.Text = "Month";
            // 
            // yearUpDownInput
            // 
            this.yearUpDownInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.yearUpDownInput.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.yearUpDownInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yearUpDownInput.Location = new System.Drawing.Point(14, 28);
            this.yearUpDownInput.Margin = new System.Windows.Forms.Padding(2);
            this.yearUpDownInput.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.yearUpDownInput.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.yearUpDownInput.Name = "yearUpDownInput";
            this.yearUpDownInput.ReadOnly = true;
            this.yearUpDownInput.Size = new System.Drawing.Size(158, 25);
            this.yearUpDownInput.TabIndex = 1;
            this.yearUpDownInput.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yearLabel.Location = new System.Drawing.Point(10, 8);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(34, 17);
            this.yearLabel.TabIndex = 14;
            this.yearLabel.Text = "Year";
            // 
            // viewPayslipUnderline
            // 
            this.viewPayslipUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.viewPayslipUnderline.Location = new System.Drawing.Point(44, 54);
            this.viewPayslipUnderline.Margin = new System.Windows.Forms.Padding(2);
            this.viewPayslipUnderline.Name = "viewPayslipUnderline";
            this.viewPayslipUnderline.Size = new System.Drawing.Size(583, 1);
            this.viewPayslipUnderline.TabIndex = 1;
            // 
            // managePayslipLabel
            // 
            this.managePayslipLabel.AutoSize = true;
            this.managePayslipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePayslipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.managePayslipLabel.Location = new System.Drawing.Point(39, 15);
            this.managePayslipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managePayslipLabel.Name = "managePayslipLabel";
            this.managePayslipLabel.Size = new System.Drawing.Size(220, 31);
            this.managePayslipLabel.TabIndex = 0;
            this.managePayslipLabel.Text = "Manage Payslip";
            // 
            // ManagePayslipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 481);
            this.Controls.Add(this.viewPayslipPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePayslipForm";
            this.Text = "ViewPayroll";
            this.viewPayslipPanel.ResumeLayout(false);
            this.viewPayslipPanel.PerformLayout();
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payslipDataGridView)).EndInit();
            this.menuViewPanel.ResumeLayout(false);
            this.menuViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDownInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewPayslipPanel;
        private System.Windows.Forms.Panel viewPayslipUnderline;
        private System.Windows.Forms.Label managePayslipLabel;
        private System.Windows.Forms.Panel menuViewPanel;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.NumericUpDown yearUpDownInput;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox employeeCB;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Panel dataGridPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button printButton;
        public System.Windows.Forms.DataGridView payslipDataGridView;
    }
}