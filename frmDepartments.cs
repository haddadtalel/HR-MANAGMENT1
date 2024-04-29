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
    public partial class frmDepartments : Form
    {
        private HRDataSet2 originalDataSet;
        public frmDepartments()
        {
            InitializeComponent();
        }

        private void frmDepartments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet2.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.hRDataSet2.Departments);
            originalDataSet = (HRDataSet2)this.hRDataSet2.Copy();



        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract data from the selected row
                string DepartId = selectedRow.Cells["Department_id"].Value.ToString();
                string DepartName = selectedRow.Cells["Department_name"].Value.ToString();
                string Locationid = selectedRow.Cells["Location_id"].Value.ToString();
                // Display data in TextBoxes
                textBox1.Text = DepartId;
                textBox2.Text = DepartName;
                textBox3.Text = Locationid;
            }
            else
            {
                // Clear TextBoxes if no row is selected
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            // Create a new row for the DataTable
            HRDataSet2.DepartmentsRow newRow = hRDataSet2.Departments.NewDepartmentsRow();

            // Assign values to the new row
            newRow.Department_id = (byte)int.Parse(textBox1.Text.Trim());
            newRow.Department_name = textBox2.Text.Trim();
            newRow.Location_id = int.Parse(textBox3.Text.Trim()) ;
            // Add the new row to the DataTable
            hRDataSet2.Departments.AddDepartmentsRow(newRow);

            // Clear TextBoxes after adding the new record
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Get the corresponding DataRowView
                DataRowView selectedRowView = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

                // Get the DataRow associated with the DataRowView
                HRDataSet2.DepartmentsRow rowToDelete = (HRDataSet2.DepartmentsRow)selectedRowView.Row;

                // Delete the row from the DataTable
                rowToDelete.Delete();

                // Refresh the DataGridView
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a Department to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the corresponding DataRowView
                DataRowView selectedRowView = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

                // Get the DataRow associated with the DataRowView
                HRDataSet2.DepartmentsRow rowToUpdate = (HRDataSet2.DepartmentsRow)selectedRowView.Row;

                // Update the values of the DataRow
                rowToUpdate.Department_id = (Byte)int.Parse(textBox1.Text.Trim());
                rowToUpdate.Department_name = textBox2.Text.Trim();
                rowToUpdate.Location_id = int.Parse(textBox3.Text.Trim()) ;

                // Refresh the DataGridView
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a Department to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                // Update changes to the database
                int rowsUpdated = departmentsTableAdapter.Update(hRDataSet2.Departments);

                // Check if any rows were updated
                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Changes successfully validated and applied to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No changes were made to validate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while validating changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {

            // Restore the original state of the dataset
            this.hRDataSet2.Clear();
            this.hRDataSet2.Merge(originalDataSet);
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {

            int currentIndex = dataGridView1.CurrentCell.RowIndex;
            if (currentIndex > 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex - 1].Cells[0];
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            int currentIndex = dataGridView1.CurrentCell.RowIndex;
            if (currentIndex < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex + 1].Cells[0];
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            }
        }
    }
}
