using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Forms
{
    public partial class RetailForm : Form
    {
        // Using the same connection string format as BirdBreedForm
        private static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FarmOfEggs;Trusted_Connection=True;";
        private SqlConnection connect;

        public RetailForm()
        {
            InitializeComponent();
            connect = new SqlConnection(connectionString);
            LoadRetailData();
        }

        // Same pattern as BirdBreedForm
        private void LoadRetailData(int? id = null)
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Retail";
                if (id.HasValue)
                {
                    query += " WHERE RetailID = @id";
                }

                SqlDataAdapter dataA = new SqlDataAdapter(query, connect);
                if (id.HasValue)
                {
                    dataA.SelectCommand.Parameters.AddWithValue("@id", id.Value);
                }

                DataTable dataT = new DataTable();
                dataA.Fill(dataT);
                dataGridView1.DataSource = dataT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void ClearFields()
        {
            BatchEggIdTB.Text = ""; // Changed from BatchEggIdTB to match BirdBreed style
            NameTB.Text = "";
            PhoneTB.Text = "";
            FeeTB.Text = "";
            NameTB.Focus();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || PhoneTB.Text == "" || FeeTB.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(FeeTB.Text, out decimal fee))
            {
                MessageBox.Show("Invalid Retail Fee. Please enter a number.");
                return;
            }

            connect.Open();
            // Check for uniqueness like BirdBreedForm
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Retail WHERE Name = @Name", connect);
            checkCmd.Parameters.AddWithValue("@Name", NameTB.Text);
            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("This retailer already exists.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Retail (PhoneNumber, Name, RetailFee) VALUES (@Phone, @Name, @Fee)", connect);
            cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text);
            cmd.Parameters.AddWithValue("@Name", NameTB.Text);
            cmd.Parameters.AddWithValue("@Fee", fee);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Retailer added successfully.");
            LoadRetailData();
            ClearFields();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (BatchEggIdTB.Text == "")
            {
                MessageBox.Show("Please select a retailer to update.");
                return;
            }

            if (!decimal.TryParse(FeeTB.Text, out decimal fee))
            {
                MessageBox.Show("Invalid Retail Fee.");
                return;
            }

            connect.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Retail SET PhoneNumber = @Phone, Name = @Name, RetailFee = @Fee WHERE RetailID = @ID", connect);
            cmd.Parameters.AddWithValue("@ID", BatchEggIdTB.Text);
            cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text);
            cmd.Parameters.AddWithValue("@Name", NameTB.Text);
            cmd.Parameters.AddWithValue("@Fee", fee);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Retailer updated successfully.");
            LoadRetailData();
            ClearFields();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (BatchEggIdTB.Text == "")
            {
                MessageBox.Show("Please select a retailer to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this retailer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            connect.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Retail WHERE RetailID = @ID", connect);
            cmd.Parameters.AddWithValue("@ID", BatchEggIdTB.Text);
            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Retailer deleted successfully.");
            LoadRetailData();
            ClearFields();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(BatchEggIdTB.Text, out int id))
            {
                LoadRetailData(id);
            }
            else
            {
                LoadRetailData();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                BatchEggIdTB.Text = row.Cells["RetailID"].Value.ToString();
                NameTB.Text = row.Cells["Name"].Value.ToString();
                PhoneTB.Text = row.Cells["PhoneNumber"].Value.ToString();
                FeeTB.Text = row.Cells["RetailFee"].Value.ToString();
            }
        }
    }
}
