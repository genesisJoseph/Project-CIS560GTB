using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmForm
{
    public partial class BirdGroupForm : Form
    {

        private static string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=FarmOfEggs;Trusted_Connection=True;";

        private SqlConnection connect;
        public BirdGroupForm()
        {
            InitializeComponent();
            connect = new SqlConnection(connectionString);
        }


        private void LoadBirdGroupData(int? id = null) // Nullable parameter
        {
            connect.Open();

            // Default query
            string query = "SELECT * FROM BirdGroup";

            // Add filter if an ID is provided
            if (id.HasValue)
            {
                query += " WHERE BirdGroupID = @id";
            }

            SqlDataAdapter dataA = new SqlDataAdapter(query, connect);

            if (id.HasValue)
            {
                dataA.SelectCommand.Parameters.AddWithValue("@id", id.Value);
            }

            DataTable dataT = new DataTable();
            dataA.Fill(dataT);
            dgvCGroup.DataSource = dataT;
            connect.Close();
        }


        private void ClearFields()
        {
            txtCGroupID.Clear();
            txtConfinement.Clear();
            txtCFarmID.Clear();
            txtCGBreedID.Clear();

            txtConfinement.Focus();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            // Try to turn the text into a number
            if (int.TryParse(txtCGroupID.Text, out int id))
            {
                LoadBirdGroupData(id);
            }
            else
            {
                // If the user typed something invalid, just load everything or show a message                
                LoadBirdGroupData();
            }
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtConfinement.Text == "" || txtCFarmID.Text == "" || txtCGBreedID.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connect.Open();

            SqlCommand checkFarm = new SqlCommand(
                "SELECT COUNT(*) FROM Farm WHERE FarmID = @FarmID", connect);
            checkFarm.Parameters.AddWithValue("@FarmID", txtCFarmID.Text);

            int farmExists = (int)checkFarm.ExecuteScalar();

            if (farmExists == 0)
            {
                MessageBox.Show("FarmID does not exist.");
                connect.Close();
                return;
            }

            SqlCommand checkBreed = new SqlCommand(
                "SELECT COUNT(*) FROM BirdBreed WHERE BirdBreedID = @BirdBreedID", connect);
            checkBreed.Parameters.AddWithValue("@BirdBreedID", txtCGBreedID.Text);

            int breedExists = (int)checkBreed.ExecuteScalar();

            if (breedExists == 0)
            {
                MessageBox.Show("BirdBreedID does not exist.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO BirdGroup (Confinement, FarmID, BirdBreedID) VALUES (@Confinement, @FarmID, @BirdBreedID)", connect);

            cmd.Parameters.AddWithValue("@Confinement", txtConfinement.Text);
            cmd.Parameters.AddWithValue("@FarmID", txtCFarmID.Text);
            cmd.Parameters.AddWithValue("@BirdBreedID", txtCGBreedID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Bird group added successfully.");

            LoadBirdGroupData();
            ClearFields();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtCGroupID.Text == "")
            {
                MessageBox.Show("Please select a bird group to update.");
                return;
            }

            if (txtConfinement.Text == "" || txtCFarmID.Text == "" || txtCGBreedID.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connect.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE BirdGroup SET Confinement = @Confinement, FarmID = @FarmID, BirdBreedID = @BirdBreedID WHERE BirdGroupID = @BirdGroupID", connect);

            cmd.Parameters.AddWithValue("@BirdGroupID", txtCGroupID.Text);
            cmd.Parameters.AddWithValue("@Confinement", txtConfinement.Text);
            cmd.Parameters.AddWithValue("@FarmID", txtCFarmID.Text);
            cmd.Parameters.AddWithValue("@BirdBreedID", txtCGBreedID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Bird group updated successfully.");

            LoadBirdGroupData();
            ClearFields();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtCGroupID.Text == "")
            {
                MessageBox.Show("Please select a bird group to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this bird group?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            connect.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM BirdGroup WHERE BirdGroupID = @BirdGroupID", connect);

            cmd.Parameters.AddWithValue("@BirdGroupID", txtCGroupID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Bird group deleted successfully.");

            LoadBirdGroupData();
            ClearFields();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
