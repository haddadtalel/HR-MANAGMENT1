using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_MANAGMENT1._2
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            frmLocations frmLocations = new frmLocations();
            frmLocations.ShowDialog();
            this.Hide();
        }

        private void BtnJob_Click(object sender, EventArgs e)
        {
            frmJobs frmJobs = new frmJobs();
            frmJobs.ShowDialog();
            this.Hide();
        }

        private void BtnDep_Click(object sender, EventArgs e)
        {
            frmDepartments frmDepartments = new frmDepartments();
            frmDepartments.ShowDialog();
            this.Hide();
        }

        private void BtnEmp_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
            this.Hide();
        }
    }
}
