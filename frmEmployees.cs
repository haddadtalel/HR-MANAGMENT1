using HR_MANAGMENT1._2.HRDataSet2TableAdapters;
using HR_MANAGMENT1._2.HRDataSet3TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HR_MANAGMENT1._2.frmEmployees;

namespace HR_MANAGMENT1._2
{
    public partial class frmEmployees : Form
    {
        private HRDataSet3 originalDataSet;
        public class Employee
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime DateHire { get; set; }
            public string Department { get; set; }
            public string JobID { get; set; }
            
        }
        public List<Employee> EmployeeList = new List<Employee>();
        public frmEmployees()
        {
            InitializeComponent();

        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet3.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hRDataSet3.Employees);
            originalDataSet = (HRDataSet3)this.hRDataSet3.Copy();
            
            // Assuming listBox1 is the name of your ListBox
            listBox1.Items.Clear();

            foreach (HRDataSet3.EmployeesRow row in this.hRDataSet3.Employees.Rows)
            {
                listBox1.Items.Add(row.First_name + "-" + row.Last_name); // or whatever columns you want to display
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (listBox1.SelectedIndex >= 0)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] data = selectedItem.Split('-');

                if (data.Length >= 2) // Ensure there are enough elements after splitting
                {
                    string Name = data[0].Trim();
                    string Lastname = data[1].Trim();

                    // Get the selected Employee object from the EmployeeList
                    DataRow[] selectEmp = hRDataSet3.Employees.Select($"First_name = '{Name}' AND Last_name='{Lastname}'");

                    if (selectEmp.Length > 0)
                    {
                        DataRow employeeRow = selectEmp[0];
                        textBox1.Text = employeeRow["Employee_id"].ToString();
                        textBox2.Text = employeeRow["First_name"].ToString();
                        textBox3.Text = employeeRow["Last_name"].ToString();
                        dateTimePicker1.Value = (DateTime)employeeRow["Hire_date"];
                        textBox4.Text = employeeRow["Job_id"].ToString();
                        textBox5.Text = employeeRow["Department_id"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Employee found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid data format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Clear TextBoxes if no item is selected
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                // Clear the date elements in the Employees form
                dateTimePicker1.Value = DateTime.Now;
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

            HRDataSet3.EmployeesRow  newRow = hRDataSet3.Employees.NewEmployeesRow();
            // Get values from TextBoxes
            string id = textBox1.Text.Trim();
            string Name = textBox2.Text.Trim();
            string LastName = textBox3.Text.Trim();
            string department =textBox5.Text.Trim();
            string JobID = textBox4.Text.Trim();
            DateTime dateHire = dateTimePicker1.Value;

            newRow.Employee_id = int.Parse(id);
            newRow.First_name = Name;
            newRow.Last_name = LastName;
            newRow.Job_id=JobID;
            newRow.Hire_date = dateHire;
            newRow.Department_id =(byte)int.Parse(department);
            hRDataSet3.Employees.AddEmployeesRow(newRow);
            // Add the employee's name to the ListBox
            listBox1.Items.Add($"{Name} - {LastName}");

            // Clear TextBoxes after adding the new record
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.Value = DateTime.Now;

            MessageBox.Show("Employee Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                // Get the selected item from the ListBox
                string selectedEmployeeInfo = listBox1.SelectedItem.ToString();
                string[] data = selectedEmployeeInfo.Split('-');

                if (data.Length >= 2)
                {
                    // Extract the employee name from the selected item
                    string firstName = data[0].Trim();
                    string lastName = data[1].Trim();

                    // Find the corresponding rows in the dataset based on first and last name
                    DataRow[] selectedRows = hRDataSet3.Employees.Select($"First_name = '{firstName}' AND Last_name='{lastName}'");

                    // Check if any rows are found
                    if (selectedRows.Length > 0)
                    {
                        // Get the first DataRow found (assuming each employee has a unique name combination)
                        DataRow selectedRow = selectedRows[0];

                        // Confirm deletion with the user
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Delete the DataRow
                            selectedRow.Delete();

                            // Update the ListBox
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                            // Clear TextBoxes and DateTimePicker
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            dateTimePicker1.Value = DateTime.Now;

                            MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Check if any item is selected in the ListBox
            if (listBox1.SelectedIndex >= 0)
            {
                // Get the selected item from the ListBox
                string selectedEmployeeInfo = listBox1.SelectedItem.ToString();
                string[] data = selectedEmployeeInfo.Split('-');

                if (data.Length >= 2)
                {
                    // Extract the employee name from the selected item
                    string firstName = data[0].Trim();
                    string lastName = data[1].Trim();

                    // Find the corresponding rows in the dataset based on first and last name
                    DataRow[] selectedRows = hRDataSet3.Employees.Select($"First_name = '{firstName}' AND Last_name='{lastName}'");

                    // Check if any rows are found
                    if (selectedRows.Length > 0)
                    {
                        // Prompt the user for confirmation before proceeding with the update
                        DialogResult result = MessageBox.Show("Are you sure you want to update this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Get the first DataRow found (assuming each employee has a unique name combination)
                            DataRow selectedRow = selectedRows[0];

                            // Get the Employee_id from the DataRow
                            int employeeId = (int)selectedRow["Employee_id"];

                            // Now you have the employeeId, and you can use it however you want
                            // For example, you can use it to update the corresponding row in your dataset
                            HRDataSet3.EmployeesRow rowToUpdate = hRDataSet3.Employees.FindByEmployee_id(employeeId);
                            if (rowToUpdate != null)
                            {
                                rowToUpdate.Employee_id = employeeId;
                                rowToUpdate.First_name = textBox2.Text.Trim();
                                rowToUpdate.Last_name = textBox3.Text.Trim();
                                rowToUpdate.Hire_date = DateTime.Parse(dateTimePicker1.Text.Trim());
                                rowToUpdate.Job_id = textBox4.Text.Trim();
                                rowToUpdate.Department_id = byte.Parse(textBox5.Text.Trim());
                                listBox1.Items[listBox1.SelectedIndex] = $"{textBox2.Text.Trim()} - {textBox3.Text.Trim()}";
                                MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            else
                            {
                                MessageBox.Show("Employee not found in the data set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please verify the First Name and the Last Name of the emp.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please select an employee to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to undo the changes?", "Undo Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.hRDataSet3.Clear();
                this.hRDataSet3.Merge(originalDataSet);
                foreach (HRDataSet3.EmployeesRow row in this.hRDataSet3.Employees.Rows)
                {
                    listBox1.Items.Add(row.First_name + "-" + row.Last_name); // or whatever columns you want to display
                    MessageBox.Show("Changes undone successfully.", "Undo Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                // Update changes to the database
                int rowsUpdated = employeesTableAdapter.Update(hRDataSet3.Employees);

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
    }
}
