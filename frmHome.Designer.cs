namespace HR_MANAGMENT1._2
{
    partial class frmHome
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
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnEmp = new System.Windows.Forms.Button();
            this.BtnDep = new System.Windows.Forms.Button();
            this.BtnJob = new System.Windows.Forms.Button();
            this.BtnLoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(73, 247);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(493, 74);
            this.BtnQuit.TabIndex = 0;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnEmp
            // 
            this.BtnEmp.Location = new System.Drawing.Point(73, 43);
            this.BtnEmp.Name = "BtnEmp";
            this.BtnEmp.Size = new System.Drawing.Size(205, 65);
            this.BtnEmp.TabIndex = 1;
            this.BtnEmp.Text = "Employees";
            this.BtnEmp.UseVisualStyleBackColor = true;
            this.BtnEmp.Click += new System.EventHandler(this.BtnEmp_Click);
            // 
            // BtnDep
            // 
            this.BtnDep.Location = new System.Drawing.Point(73, 142);
            this.BtnDep.Name = "BtnDep";
            this.BtnDep.Size = new System.Drawing.Size(205, 67);
            this.BtnDep.TabIndex = 2;
            this.BtnDep.Text = "Derpartments";
            this.BtnDep.UseVisualStyleBackColor = true;
            this.BtnDep.Click += new System.EventHandler(this.BtnDep_Click);
            // 
            // BtnJob
            // 
            this.BtnJob.Location = new System.Drawing.Point(361, 43);
            this.BtnJob.Name = "BtnJob";
            this.BtnJob.Size = new System.Drawing.Size(205, 65);
            this.BtnJob.TabIndex = 3;
            this.BtnJob.Text = "Jobs";
            this.BtnJob.UseVisualStyleBackColor = true;
            this.BtnJob.Click += new System.EventHandler(this.BtnJob_Click);
            // 
            // BtnLoc
            // 
            this.BtnLoc.Location = new System.Drawing.Point(361, 142);
            this.BtnLoc.Name = "BtnLoc";
            this.BtnLoc.Size = new System.Drawing.Size(205, 67);
            this.BtnLoc.TabIndex = 4;
            this.BtnLoc.Text = "Locations";
            this.BtnLoc.UseVisualStyleBackColor = true;
            this.BtnLoc.Click += new System.EventHandler(this.BtnLoc_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 383);
            this.Controls.Add(this.BtnLoc);
            this.Controls.Add(this.BtnJob);
            this.Controls.Add(this.BtnDep);
            this.Controls.Add(this.BtnEmp);
            this.Controls.Add(this.BtnQuit);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnEmp;
        private System.Windows.Forms.Button BtnDep;
        private System.Windows.Forms.Button BtnJob;
        private System.Windows.Forms.Button BtnLoc;
    }
}

