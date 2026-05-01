using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Forms
{
    public partial class EggSalesForm : Form
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FarmOfEggs;Trusted_Connection=True;";
        private SqlConnection connect;

        public EggSalesForm()
        {
            InitializeComponent();
            connect = new SqlConnection(connectionString);
        }

        private void EggSalesForm_Load(object sender, EventArgs e)
        {
            
            LoadSalesData();
            
        }

        // Standard Load method with ID filtering
        private void LoadSalesData(int? id = null)
        {
            try
            {
                connect.Open();
                string query = "SELECT EggSalesID, UnitPrice, AvgUnit, BatchEggID, RetailID FROM EggSales WHERE CanceledOn IS NULL";

                if (id.HasValue)
                    query += " AND EggSalesID = @id";

                SqlDataAdapter dataA = new SqlDataAdapter(query, connect);
                if (id.HasValue)
                    dataA.SelectCommand.Parameters.AddWithValue("@id", id.Value);

                DataTable dataT = new DataTable();
                dataA.Fill(dataT);
                dataGridView1.DataSource = dataT;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { connect.Close(); }
        }

        

        private void ClearFields()
        {
            txtEggSaleID.Clear();
            txtUnitPrice.Clear();
            txtAvgUnit.Clear();
            txtUnitPrice.Focus();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEggSaleID.Text, out int id))
                LoadSalesData(id);
            else
                LoadSalesData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtAvgUnit.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO EggSales (UnitPrice, AvgUnit, BatchEggID, RetailID) 
                                                VALUES (@UnitPrice, @AvgUnit, @BatchID, @RetailID)", connect);
                cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(txtUnitPrice.Text));
                cmd.Parameters.AddWithValue("@AvgUnit", decimal.Parse(txtAvgUnit.Text));
                cmd.Parameters.AddWithValue("@BatchID", txtBatchID.Text);
                cmd.Parameters.AddWithValue("@RetailID", txtRetailID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sale recorded successfully.");
            }
            catch (Exception ex) { MessageBox.Show("Add Error: " + ex.Message); }
            finally { connect.Close(); LoadSalesData(); ClearFields(); }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEggSaleID.Text)) { MessageBox.Show("Select a sale to update."); return; }

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE EggSales SET UnitPrice = @UnitPrice, AvgUnit = @AvgUnit, 
                                                BatchEggID = @BatchID, RetailID = @RetailID WHERE EggSalesID = @ID", connect);
                cmd.Parameters.AddWithValue("@ID", txtEggSaleID.Text);
                cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(txtUnitPrice.Text));
                cmd.Parameters.AddWithValue("@AvgUnit", decimal.Parse(txtAvgUnit.Text));
                cmd.Parameters.AddWithValue("@BatchID", txtBatchID.Text);
                cmd.Parameters.AddWithValue("@RetailID", txtRetailID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sale updated.");
            }
            catch (Exception ex) { MessageBox.Show("Update Error: " + ex.Message); }
            finally { connect.Close(); LoadSalesData(); ClearFields(); }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEggSaleID.Text)) { MessageBox.Show("Select a sale to cancel."); return; }

            DialogResult res = MessageBox.Show("Cancel this sale?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("UPDATE EggSales SET CanceledOn = GETDATE() WHERE EggSalesID = @ID", connect);
                cmd.Parameters.AddWithValue("@ID", txtEggSaleID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sale canceled.");
            }
            finally { connect.Close(); LoadSalesData(); ClearFields(); }
        }

        private void btClear_Click(object sender, EventArgs e) { ClearFields(); }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtEggSaleID.Text = row.Cells["EggSalesID"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtAvgUnit.Text = row.Cells["AvgUnit"].Value.ToString();
                txtBatchID.Text = row.Cells["BatchEggID"].Value.ToString();
                txtRetailID.Text = row.Cells["RetailID"].Value.ToString();
            }
        }

       
    }
}
