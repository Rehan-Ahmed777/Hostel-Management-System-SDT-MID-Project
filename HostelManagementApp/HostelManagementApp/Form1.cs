using System;
using System.Data;
#pragma warning disable 0618
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HostelManagementApp
{
    public partial class Form1 : Form
    {
        // Connection String
        string connectionString = "Server=DESKTOP-49J26E7\\SQLEXPRESS;Database=HostelManagementDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            this.ActiveControl = txtFullName; // Setting the default focus to the Full Name field
            txtStudentID.Enabled = false; // Make StudentID field unclickable
            txtStudentID.TabStop = false;
        }

        // Load Data into DataGridView
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStudents.DataSource = dt;
            }
        }

        // Reset Fields After Action
        private void ResetFields()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAge.Clear();
            txtRoomNo.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtMonthlyFee.Clear();

            txtFullName.Focus(); // Move focus to Full Name
        }

        // Add New Student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Empty Fields and show error message if any of them is empty
                if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtRoomNo.Text) ||
                    string.IsNullOrWhiteSpace(txtContact.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtMonthlyFee.Text))
                {
                    MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Full Name. Only Letters and Spaces are allowed
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtFullName.Text, @"^[A-Za-z\s]+$"))
                {
                    MessageBox.Show("Full Name must contain only letters and spaces!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Age Must be a number and at least 16
                if (!int.TryParse(txtAge.Text, out int age) || age < 16)
                {
                    MessageBox.Show("Age must be a number and at least 16!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Room Number. ItMust be a valid integer
                if (!int.TryParse(txtRoomNo.Text, out int roomNo) || roomNo <= 0)
                {
                    MessageBox.Show("Room Number must be a valid positive number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Monthly Fee (Must be a positive decimal)
                if (!decimal.TryParse(txtMonthlyFee.Text, out decimal monthlyFee) || monthlyFee <= 0)
                {
                    MessageBox.Show("Monthly Fee must be a valid number greater than 0!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Students (FullName, Age, RoomNo, Contact, Address, MonthlyFee) VALUES (@FullName, @Age, @RoomNo, @Contact, @Address, @MonthlyFee)", conn);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MonthlyFee", monthlyFee);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(); // Refresh DataGridView after Data Insertion
                    ResetFields(); // Clear Input Fields
                }
            }
            catch (SqlException sqlEx) 
            {
                MessageBox.Show("Database Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Student Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a student is selected
                if (string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    MessageBox.Show("Please select a student to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Empty Fields
                if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtRoomNo.Text) ||
                    string.IsNullOrWhiteSpace(txtContact.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtMonthlyFee.Text))
                {
                    MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Student ID. It Must be a number
                if (!int.TryParse(txtStudentID.Text, out int studentID) || studentID <= 0)
                {
                    MessageBox.Show("Invalid Student ID!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Full Name only Letters and Spaces are allowed
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtFullName.Text, @"^[A-Za-z\s]+$"))
                {
                    MessageBox.Show("Full Name must contain only letters and spaces!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Age. It must be a number and at least 16
                if (!int.TryParse(txtAge.Text, out int age) || age < 16)
                {
                    MessageBox.Show("Age must be a number and at least 16!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Room Number (Must be a valid integer)
                if (!int.TryParse(txtRoomNo.Text, out int roomNo) || roomNo <= 0)
                {
                    MessageBox.Show("Room Number must be a valid positive number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Monthly Fee. It must be a positive decimal
                if (!decimal.TryParse(txtMonthlyFee.Text, out decimal monthlyFee) || monthlyFee <= 0)
                {
                    MessageBox.Show("Monthly Fee must be a valid number greater than 0!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Students SET FullName=@FullName, Age=@Age, RoomNo=@RoomNo, Contact=@Contact, Address=@Address, MonthlyFee=@MonthlyFee WHERE StudentID=@StudentID", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MonthlyFee", monthlyFee);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh DataGridView after updating the Student Info
                        ResetFields(); // Clear Input Fields
                    }
                    else
                    {
                        MessageBox.Show("No student found with the provided ID!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException sqlEx) 
            {
                MessageBox.Show("Database Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Delete Student
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    MessageBox.Show("Please select a student to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentID=@StudentID", conn);
                        cmd.Parameters.AddWithValue("@StudentID", int.Parse(txtStudentID.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        ResetFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Select Data When Clicking on DataGridView Row
        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridViewStudents.Rows[e.RowIndex];

                // Ensure values exist before assigning them to avoid null reference issues
                txtStudentID.Text = row.Cells["StudentID"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtAge.Text = row.Cells["Age"].Value?.ToString() ?? "";
                txtRoomNo.Text = row.Cells["RoomNo"].Value?.ToString() ?? "";
                txtContact.Text = row.Cells["Contact"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtMonthlyFee.Text = row.Cells["MonthlyFee"].Value?.ToString() ?? "";
            }
        }


        // Refresh Data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ResetFields();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtMonthlyFee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}