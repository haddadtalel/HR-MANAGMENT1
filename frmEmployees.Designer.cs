namespace HR_MANAGMENT1._2
{
    partial class frmEmployees
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
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet3 = new HR_MANAGMENT1._2.HRDataSet3();
            this.employeesTableAdapter = new HR_MANAGMENT1._2.HRDataSet3TableAdapters.EmployeesTableAdapter();
            this.EmployeeGB = new System.Windows.Forms.GroupBox();
            this.DepartmentID = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.JobID = new System.Windows.Forms.Label();
            this.Hire_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.Employee_id = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet3)).BeginInit();
            this.EmployeeGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hRDataSet3;
            // 
            // hRDataSet3
            // 
            this.hRDataSet3.DataSetName = "HRDataSet3";
            this.hRDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeGB
            // 
            this.EmployeeGB.Controls.Add(this.DepartmentID);
            this.EmployeeGB.Controls.Add(this.textBox5);
            this.EmployeeGB.Controls.Add(this.textBox4);
            this.EmployeeGB.Controls.Add(this.JobID);
            this.EmployeeGB.Controls.Add(this.Hire_Date);
            this.EmployeeGB.Controls.Add(this.dateTimePicker1);
            this.EmployeeGB.Controls.Add(this.Last_Name);
            this.EmployeeGB.Controls.Add(this.First_Name);
            this.EmployeeGB.Controls.Add(this.Employee_id);
            this.EmployeeGB.Controls.Add(this.textBox3);
            this.EmployeeGB.Controls.Add(this.textBox2);
            this.EmployeeGB.Controls.Add(this.textBox1);
            this.EmployeeGB.Location = new System.Drawing.Point(372, 28);
            this.EmployeeGB.Name = "EmployeeGB";
            this.EmployeeGB.Size = new System.Drawing.Size(406, 313);
            this.EmployeeGB.TabIndex = 1;
            this.EmployeeGB.TabStop = false;
            this.EmployeeGB.Text = "Employee";
            // 
            // DepartmentID
            // 
            this.DepartmentID.AutoSize = true;
            this.DepartmentID.Location = new System.Drawing.Point(3, 275);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(101, 16);
            this.DepartmentID.TabIndex = 11;
            this.DepartmentID.Text = "Departement ID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 272);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 22);
            this.textBox4.TabIndex = 9;
            // 
            // JobID
            // 
            this.JobID.AutoSize = true;
            this.JobID.Location = new System.Drawing.Point(6, 228);
            this.JobID.Name = "JobID";
            this.JobID.Size = new System.Drawing.Size(46, 16);
            this.JobID.TabIndex = 8;
            this.JobID.Text = "Job ID";
            // 
            // Hire_Date
            // 
            this.Hire_Date.AutoSize = true;
            this.Hire_Date.Location = new System.Drawing.Point(6, 183);
            this.Hire_Date.Name = "Hire_Date";
            this.Hire_Date.Size = new System.Drawing.Size(64, 16);
            this.Hire_Date.TabIndex = 7;
            this.Hire_Date.Text = "Hire Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(6, 121);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(72, 16);
            this.Last_Name.TabIndex = 5;
            this.Last_Name.Text = "Last Name";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(6, 80);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(72, 16);
            this.First_Name.TabIndex = 4;
            this.First_Name.Text = "First Name";
            // 
            // Employee_id
            // 
            this.Employee_id.AutoSize = true;
            this.Employee_id.Location = new System.Drawing.Point(6, 33);
            this.Employee_id.Name = "Employee_id";
            this.Employee_id.Size = new System.Drawing.Size(85, 16);
            this.Employee_id.TabIndex = 3;
            this.Employee_id.Text = "Employee ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(490, 348);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(571, 347);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(652, 347);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(490, 377);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(75, 23);
            this.BtnValidate.TabIndex = 5;
            this.BtnValidate.Text = "Validate";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Location = new System.Drawing.Point(571, 377);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(75, 23);
            this.BtnUndo.TabIndex = 6;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(652, 377);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 23);
            this.BtnHome.TabIndex = 7;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(14, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 308);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnValidate);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.EmployeeGB);
            this.Name = "frmEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet3)).EndInit();
            this.EmployeeGB.ResumeLayout(false);
            this.EmployeeGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private HRDataSet3 hRDataSet3;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRDataSet3TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.GroupBox EmployeeGB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Hire_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label Employee_id;
        private System.Windows.Forms.Label DepartmentID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label JobID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.ListBox listBox1;
    }
}