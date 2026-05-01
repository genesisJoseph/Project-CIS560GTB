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
    public partial class BirdBreedForm : Form
    {
        private static string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=FarmOfEggs;Trusted_Connection=True;";

        private SqlConnection connect;

        public BirdBreedForm()
        {
            InitializeComponent();
            connect = new SqlConnection(connectionString);
            LoadBirdBreedData();
        }

        private void LoadBirdBreedData(int? id = null)
        {
            connect.Open();
            string query = "SELECT * FROM BirdBreed";

            if (id.HasValue)
            {
                query += " WHERE BirdBreedID = @id";
            }

            SqlDataAdapter dataA = new SqlDataAdapter(query, connect);

            if (id.HasValue)
            {
                dataA.SelectCommand.Parameters.AddWithValue("@id", id.Value);
            }

            DataTable dataT = new DataTable();
            dataA.Fill(dataT);
            dgvBirdBreed.DataSource = dataT;
            connect.Close();
        }


        private void ClearFields()
        {
            txtCName.Text = "";
            txtSpecies.Text = "";
            txtCBreedID.Text = "";

            txtCName.Focus();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (txtCName.Text == "" || txtSpecies.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connect.Open();

            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM BirdBreed WHERE BreedName = @BreedName", connect);

            checkCmd.Parameters.AddWithValue("@BreedName", txtCName.Text);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("This breed already exists.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO BirdBreed (BreedName, Species) VALUES (@BreedName, @Species)", connect);

            cmd.Parameters.AddWithValue("@BreedName", txtCName.Text);
            cmd.Parameters.AddWithValue("@Species", txtSpecies.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Bird breed added successfully.");

            LoadBirdBreedData();
            ClearFields();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtCBreedID.Text == "")
            {
                MessageBox.Show("Please select a breed to update.");
                return;
            }

            if (txtCName.Text == "" || txtSpecies.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connect.Open();

            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM BirdBreed WHERE BreedName = @BreedName AND BirdBreedID <> @BirdBreedID", connect);

            checkCmd.Parameters.AddWithValue("@BreedName", txtCName.Text);
            checkCmd.Parameters.AddWithValue("@BirdBreedID", txtCBreedID.Text);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("Another breed already has this name.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "UPDATE BirdBreed SET BreedName = @BreedName, Species = @Species WHERE BirdBreedID = @BirdBreedID", connect);

            cmd.Parameters.AddWithValue("@BirdBreedID", txtCBreedID.Text);
            cmd.Parameters.AddWithValue("@BreedName", txtCName.Text);
            cmd.Parameters.AddWithValue("@Species", txtSpecies.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Bird breed updated successfully.");

            LoadBirdBreedData();
            ClearFields();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (txtCBreedID.Text == "")
            {
                MessageBox.Show("Please select a breed to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this breed?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            connect.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM BirdBreed WHERE BirdBreedID = @BirdBreedID", connect);

            cmd.Parameters.AddWithValue("@BirdBreedID", txtCBreedID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Bird breed deleted successfully.");

            LoadBirdBreedData();
            ClearFields();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            // If the textbox has a valid number, filter by it. 
            // If it's empty or invalid, load all rows.
            if (int.TryParse(txtCBreedID.Text, out int id))
            {
                LoadBirdBreedData(id);
            }
            else
            {
                LoadBirdBreedData();
            }
        }

    }
}
