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
    public partial class ChickenGroupForm : Form
    {

        private static string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=FarmOfEggs;Trusted_Connection=True;";

        private SqlConnection connect;
        public ChickenGroupForm()
        {
            InitializeComponent();
            connect = new SqlConnection(connectionString);
        }


        private void LoadChickenGroupData()
        {
            connect.Open();

            SqlDataAdapter dataA = new SqlDataAdapter(
                "SELECT * FROM ChickenGroup", connect);

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
            LoadChickenGroupData();
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
                "SELECT COUNT(*) FROM ChickenBreed WHERE ChickenBreedID = @ChickenBreedID", connect);
            checkBreed.Parameters.AddWithValue("@ChickenBreedID", txtCGBreedID.Text);

            int breedExists = (int)checkBreed.ExecuteScalar();

            if (breedExists == 0)
            {
                MessageBox.Show("ChickenBreedID does not exist.");
                connect.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO ChickenGroup (Confinement, FarmID, ChickenBreedID) VALUES (@Confinement, @FarmID, @ChickenBreedID)", connect);

            cmd.Parameters.AddWithValue("@Confinement", txtConfinement.Text);
            cmd.Parameters.AddWithValue("@FarmID", txtCFarmID.Text);
            cmd.Parameters.AddWithValue("@ChickenBreedID", txtCGBreedID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Chicken group added successfully.");

            LoadChickenGroupData();
            ClearFields();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtCGroupID.Text == "")
            {
                MessageBox.Show("Please select a chicken group to update.");
                return;
            }

            if (txtConfinement.Text == "" || txtCFarmID.Text == "" || txtCGBreedID.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connect.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE ChickenGroup SET Confinement = @Confinement, FarmID = @FarmID, ChickenBreedID = @ChickenBreedID WHERE ChickenGroupID = @ChickenGroupID", connect);

            cmd.Parameters.AddWithValue("@ChickenGroupID", txtCGroupID.Text);
            cmd.Parameters.AddWithValue("@Confinement", txtConfinement.Text);
            cmd.Parameters.AddWithValue("@FarmID", txtCFarmID.Text);
            cmd.Parameters.AddWithValue("@ChickenBreedID", txtCGBreedID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Chicken group updated successfully.");

            LoadChickenGroupData();
            ClearFields();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtCGroupID.Text == "")
            {
                MessageBox.Show("Please select a chicken group to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this chicken group?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            connect.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM ChickenGroup WHERE ChickenGroupID = @ChickenGroupID", connect);

            cmd.Parameters.AddWithValue("@ChickenGroupID", txtCGroupID.Text);

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Chicken group deleted successfully.");

            LoadChickenGroupData();
            ClearFields();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
