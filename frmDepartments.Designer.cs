namespace HR_MANAGMENT1._2
{
    partial class frmDepartments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet2 = new HR_MANAGMENT1._2.HRDataSet2();
            this.departmentsTableAdapter = new HR_MANAGMENT1._2.HRDataSet2TableAdapters.DepartmentsTableAdapter();
            this.DepartmentsGB = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LocationID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NameDep = new System.Windows.Forms.Label();
            this.KeyID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet2)).BeginInit();
            this.DepartmentsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Department_id,
            this.Department_name,
            this.Location_id});
            this.dataGridView1.DataSource = this.departmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(356, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Department_id
            // 
            this.Department_id.DataPropertyName = "Department_id";
            this.Department_id.HeaderText = "Department_id";
            this.Department_id.MinimumWidth = 6;
            this.Department_id.Name = "Department_id";
            this.Department_id.Width = 125;
            // 
            // Department_name
            // 
            this.Department_name.DataPropertyName = "Department_name";
            this.Department_name.HeaderText = "Department_name";
            this.Department_name.MinimumWidth = 6;
            this.Department_name.Name = "Department_name";
            this.Department_name.Width = 125;
            // 
            // Location_id
            // 
            this.Location_id.DataPropertyName = "Location_id";
            this.Location_id.HeaderText = "Location_id";
            this.Location_id.MinimumWidth = 6;
            this.Location_id.Name = "Location_id";
            this.Location_id.Width = 125;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.hRDataSet2;
            // 
            // hRDataSet2
            // 
            this.hRDataSet2.DataSetName = "HRDataSet2";
            this.hRDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentsGB
            // 
            this.DepartmentsGB.Controls.Add(this.textBox3);
            this.DepartmentsGB.Controls.Add(this.LocationID);
            this.DepartmentsGB.Controls.Add(this.textBox2);
            this.DepartmentsGB.Controls.Add(this.NameDep);
            this.DepartmentsGB.Controls.Add(this.KeyID);
            this.DepartmentsGB.Controls.Add(this.textBox1);
            this.DepartmentsGB.Location = new System.Drawing.Point(391, 12);
            this.DepartmentsGB.Name = "DepartmentsGB";
            this.DepartmentsGB.Size = new System.Drawing.Size(397, 179);
            this.DepartmentsGB.TabIndex = 1;
            this.DepartmentsGB.TabStop = false;
            this.DepartmentsGB.Text = "Department";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 22);
            this.textBox3.TabIndex = 5;
            // 
            // LocationID
            // 
            this.LocationID.AutoSize = true;
            this.LocationID.Location = new System.Drawing.Point(40, 137);
            this.LocationID.Name = "LocationID";
            this.LocationID.Size = new System.Drawing.Size(58, 16);
            this.LocationID.TabIndex = 4;
            this.LocationID.Text = "Location";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 22);
            this.textBox2.TabIndex = 3;
            // 
            // NameDep
            // 
            this.NameDep.AutoSize = true;
            this.NameDep.Location = new System.Drawing.Point(40, 89);
            this.NameDep.Name = "NameDep";
            this.NameDep.Size = new System.Drawing.Size(44, 16);
            this.NameDep.TabIndex = 2;
            this.NameDep.Text = "Name";
            // 
            // KeyID
            // 
            this.KeyID.AutoSize = true;
            this.KeyID.Location = new System.Drawing.Point(40, 46);
            this.KeyID.Name = "KeyID";
            this.KeyID.Size = new System.Drawing.Size(30, 16);
            this.KeyID.TabIndex = 1;
            this.KeyID.Text = "Key";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(495, 219);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(576, 219);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(657, 219);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(495, 248);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(75, 23);
            this.BtnValidate.TabIndex = 5;
            this.BtnValidate.Text = "Validate";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Location = new System.Drawing.Point(576, 248);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(75, 23);
            this.BtnUndo.TabIndex = 6;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(657, 248);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 23);
            this.BtnHome.TabIndex = 7;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(29, 381);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnFirst.TabIndex = 8;
            this.BtnFirst.Text = "First";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(110, 381);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 9;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(191, 381);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 10;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(272, 381);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(75, 23);
            this.BtnLast.TabIndex = 11;
            this.BtnLast.Text = "Last";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // frmDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnValidate);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.DepartmentsGB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDepartments";
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.frmDepartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet2)).EndInit();
            this.DepartmentsGB.ResumeLayout(false);
            this.DepartmentsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HRDataSet2 hRDataSet2;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private HRDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.GroupBox DepartmentsGB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LocationID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NameDep;
        private System.Windows.Forms.Label KeyID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_id;
    }
}