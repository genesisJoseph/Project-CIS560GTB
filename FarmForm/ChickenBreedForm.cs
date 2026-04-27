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
    public partial class ChickenBreedForm : Form
    {

        SqlConnection connect = new SqlConnection(
           ConfigurationManager.ConnectionStrings["FarmDB"].ConnectionString);
        public ChickenBreedForm()
        {
            InitializeComponent();
        }

        private void LoadChickenBreedData()
        {
            connect.Open();

            SqlDataAdapter dataA = new SqlDataAdapter(
                "SELECT * FROM ChickenBreed", connect);

            DataTable dataT = new DataTable();
            dataA.Fill(dataT);

            dgvChickenBreed.DataSource = dataT;

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
                "SELECT COUNT(*) FROM ChickenBreed WHERE BreedName = @BreedName", connect);

            checkCmd.Parameters.AddWithValue("@BreedName", txtCName.Text);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("This breed already exists.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO ChickenBreed (BreedName, Species) VALUES (@BreedName, @Species)", connect);

            cmd.Parameters.AddWithValue("@BreedName", txtCName.Text);
            cmd.Parameters.AddWithValue("@Species", txtSpecies.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Chicken breed added successfully.");

            LoadChickenBreedData();
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
                "SELECT COUNT(*) FROM ChickenBreed WHERE BreedName = @BreedName AND ChickenBreedID <> @ChickenBreedID", connect);

            checkCmd.Parameters.AddWithValue("@BreedName", txtCName.Text);
            checkCmd.Parameters.AddWithValue("@ChickenBreedID", txtCBreedID.Text);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("Another breed already has this name.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "UPDATE ChickenBreed SET BreedName = @BreedName, Species = @Species WHERE ChickenBreedID = @ChickenBreedID", connect);

            cmd.Parameters.AddWithValue("@ChickenBreedID", txtCBreedID.Text);
            cmd.Parameters.AddWithValue("@BreedName", txtCName.Text);
            cmd.Parameters.AddWithValue("@Species", txtSpecies.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Chicken breed updated successfully.");

            LoadChickenBreedData();
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
                "DELETE FROM ChickenBreed WHERE ChickenBreedID = @ChickenBreedID", connect);

            cmd.Parameters.AddWithValue("@ChickenBreedID", txtCBreedID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Chicken breed deleted successfully.");

            LoadChickenBreedData();
            ClearFields();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadChickenBreedData();
        }
    }
}
