using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmForm
{
    public partial class FarmForm : Form
    {
        private static string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=FarmOfEggs;Trusted_Connection=True;";

        private SqlConnection connect;
        public FarmForm()
        {
            InitializeComponent();
            connect = new SqlConnection(connectionString);
                LoadFarmData();
        }

        private void LoadFarmData(int? id = null)
        {
            connect.Open();
            string query = "SELECT * FROM Farm";

            if (id.HasValue)
            {
                query += " WHERE FarmID = @id";
            }

            SqlDataAdapter dataA = new SqlDataAdapter(query, connect);

            if (id.HasValue)
            {
                dataA.SelectCommand.Parameters.AddWithValue("@id", id.Value);
            }

            DataTable dataT = new DataTable();
            dataA.Fill(dataT);
            dgvFarm.DataSource = dataT;
            connect.Close();
        }


        private void ClearFields()
        {
            txtLocation.Text = "";
            txtName.Text = "";
            txtPNumber.Text = "";
            txtOwner.Text = "";
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            // If a valid ID is entered, filter; otherwise, load all farms.
            if (int.TryParse(txtFarmID.Text, out int id))
            {
                LoadFarmData(id);
            }
            else
            {
                LoadFarmData();
            }
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text == "" || txtName.Text == "" || txtPNumber.Text == "" || txtOwner.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connect.Open();

            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM Farm WHERE Name = @Name OR PhoneNumber = @PhoneNumber", connect);

            checkCmd.Parameters.AddWithValue("@Name", txtName.Text);
            checkCmd.Parameters.AddWithValue("@PhoneNumber", txtPNumber.Text);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("This farm already exists. Farm name or phone number must be unique.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Farm (Location, Name, PhoneNumber, Owner) VALUES (@Location, @Name, @PhoneNumber, @Owner)", connect);

            cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPNumber.Text);
            cmd.Parameters.AddWithValue("@Owner", txtOwner.Text);

            cmd.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Farm added successfully.");

            LoadFarmData();
            ClearFields();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtFarmID.Text == "")
            {
                MessageBox.Show("Please select a farm to update.");
                return;
            }

            if (txtLocation.Text == "" || txtName.Text == "" || txtPNumber.Text == "" || txtOwner.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connect.Open();

            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM Farm WHERE (Name = @Name OR PhoneNumber = @PhoneNumber) AND FarmID <> @FarmID", connect);

            checkCmd.Parameters.AddWithValue("@Name", txtName.Text);
            checkCmd.Parameters.AddWithValue("@PhoneNumber", txtPNumber.Text);
            checkCmd.Parameters.AddWithValue("@FarmID", txtFarmID.Text);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("Another farm already has this name or phone number.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "UPDATE Farm SET Location = @Location, Name = @Name, PhoneNumber = @PhoneNumber, Owner = @Owner WHERE FarmID = @FarmID", connect);

            cmd.Parameters.AddWithValue("@FarmID", txtFarmID.Text);
            cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPNumber.Text);
            cmd.Parameters.AddWithValue("@Owner", txtOwner.Text);

            cmd.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Farm updated successfully.");

            LoadFarmData();
            ClearFields();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtFarmID.Text == "")
            {
                MessageBox.Show("Please select a farm to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this farm?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            connect.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Farm WHERE FarmID = @FarmID", connect);

            cmd.Parameters.AddWithValue("@FarmID", txtFarmID.Text);

            cmd.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Farm deleted successfully.");

            LoadFarmData();
            ClearFields();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtFarmID.Clear();
            txtLocation.Clear();
            txtName.Clear();
            txtPNumber.Clear();
            txtOwner.Clear();

            txtLocation.Focus();
        }

        
    }
}
