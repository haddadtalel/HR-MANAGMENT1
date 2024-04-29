using HR_MANAGMENT1._2.HRDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_MANAGMENT1._2
{
    public partial class frmLocations : Form
    {
        private HRDataSet originalDataSet;
        public string connectionString = "Data Source=DESKTOP-02EBENO\\SQLEXPRESS;Initial Catalog=HR;User ID=HRADMIN;Password=HRADMIN;TrustServerCertificate=true;";

        public frmLocations()
        {
            InitializeComponent();
        }
        private void frmLocations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.Locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.hRDataSet.Locations);
            originalDataSet = (HRDataSet)this.hRDataSet.Copy();

        }        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract data from the selected row
                string Locationid = selectedRow.Cells["Location_id"].Value.ToString();
                string Locationdetail = selectedRow.Cells["Location_detail"].Value.ToString();

                // Display data in TextBoxes
                textBox1.Text = Locationid;
                textBox2.Text = Locationdetail;
            }
            else
            {
                // Clear TextBoxes if no row is selected
                textBox1.Text = "";
                textBox2.Text = "";
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
            HRDataSet.LocationsRow newRow = hRDataSet.Locations.NewLocationsRow();

            // Assign values to the new row
            newRow.Location_id = int.Parse(textBox1.Text.Trim());
            newRow.Location_detail = textBox2.Text.Trim();

            // Add the new row to the DataTable
            hRDataSet.Locations.AddLocationsRow(newRow);

            // Clear TextBoxes after adding the new record
            textBox1.Clear();
            textBox2.Clear();

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
                HRDataSet.LocationsRow rowToDelete = (HRDataSet.LocationsRow)selectedRowView.Row;

                // Delete the row from the DataTable
                rowToDelete.Delete();

                // Refresh the DataGridView
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a Location to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                HRDataSet.LocationsRow rowToUpdate = (HRDataSet.LocationsRow)selectedRowView.Row;

                // Update the values of the DataRow
                rowToUpdate.Location_id = int.Parse(textBox1.Text.Trim());
                rowToUpdate.Location_detail = textBox2.Text.Trim();

                // Refresh the DataGridView
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a Job to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                // Update changes to the database
                int rowsUpdated = locationsTableAdapter.Update(hRDataSet.Locations);

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
            this.hRDataSet.Clear();
            this.hRDataSet.Merge(originalDataSet);
        }
    }
}
