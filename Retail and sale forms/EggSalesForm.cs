using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Forms
{
    public partial class EggSalesForm : Form
    {
        private int selectedSaleID;
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Farm;Trusted_Connection=True;";
        public EggSalesForm()
        {
            InitializeComponent();
            LoadSales();
            LoadCombos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRetail();
            LoadBatchEgg();
        }
        private void LoadRetail()
        {
            string query = "SELECT RetailID FROM Retail";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "RetailID";
                comboBox1.ValueMember = "RetailID";
            }
        }
        private void LoadBatchEgg()
        {
            string query = "SELECT BatchEggID FROM BatchEgg";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "BatchEggID";
                comboBox2.ValueMember = "BatchEggID";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
            INSERT INTO EggSales (UnitPrice, AvgUnit, BatchEggID, RetailID)
            VALUES (@UnitPrice, @AvgUnit, @BatchEggID, @RetailID)";

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UnitPrice", decimal.Parse(textBox1.Text)),
                    new SqlParameter("@AvgUnit", decimal.Parse(textBox2.Text)),
                    new SqlParameter("@BatchEggID", comboBox2.SelectedValue),
                    new SqlParameter("@RetailID", comboBox1.SelectedValue)
                };

                DataAccess db = new DataAccess(connectionString);
                db.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Sale recorded.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedSaleID == -1)
            {
                MessageBox.Show("Please select a sale first.");
                return;
            }

            const string query = @"
            UPDATE EggSales
            SET UnitPrice = @UnitPrice,
                AvgUnit = @AvgUnit,
                BatchEggID = @BatchEggID,
                RetailID = @RetailID
            WHERE EggSalesID = @EggSalesID";

            if (!decimal.TryParse(textBox1.Text, out decimal unitPrice) ||
                !decimal.TryParse(textBox2.Text, out decimal avgUnit))
            {
                MessageBox.Show("Please enter valid numeric values for Unit Price and Avg Price.");
                return;
            }

            if (comboBox2.SelectedValue == null || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a Batch and a Retail.");
                return;
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UnitPrice", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = unitPrice },
            new SqlParameter("@AvgUnit", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = avgUnit },
            new SqlParameter("@BatchEggID", SqlDbType.Int) { Value = comboBox2.SelectedValue ?? DBNull.Value },
            new SqlParameter("@RetailID", SqlDbType.Int) { Value = comboBox1.SelectedValue ?? DBNull.Value },
            new SqlParameter("@EggSalesID", SqlDbType.Int) { Value = selectedSaleID }
            };

            DataAccess db = new DataAccess(connectionString);
            db.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Sale updated.");
            LoadSales();
        }

        private void LoadSales()
        {
            string query = @"
            SELECT 
                EggSalesID,
                UnitPrice,
                AvgUnit,
                BatchEggID,
                RetailID
            FROM EggSales
            WHERE CanceledOn IS NULL";

            DataAccess db = new DataAccess(connectionString);
            dataGridView1.DataSource = db.ExecuteQuery(query);
        }

        private void LoadCombos()
        {
            DataAccess db = new DataAccess(connectionString);

            comboBox1.DataSource = db.ExecuteQuery("SELECT RetailID, Name FROM Retail");
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "RetailID";

            comboBox2.DataSource = db.ExecuteQuery("SELECT BatchEggID FROM BatchEgg");
            comboBox2.DisplayMember = "BatchEggID";
            comboBox2.ValueMember = "BatchEggID";
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedSaleID = Convert.ToInt32(row.Cells["EggSalesID"].Value);

                textBox1.Text = row.Cells["UnitPrice"].Value.ToString();
                textBox2.Text = row.Cells["AvgUnit"].Value.ToString();

                comboBox2.SelectedValue = row.Cells["BatchEggID"].Value;
                comboBox1.SelectedValue = row.Cells["RetailID"].Value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedSaleID == -1)
            {
                MessageBox.Show("Please select a sale first.");
                return;
            }

                string query = @"
                UPDATE EggSales
                SET CanceledOn = GETDATE()
                WHERE EggSalesID = @EggSalesID";
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) || comboBox2.SelectedValue == null || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                SqlParameter[] parameters = new SqlParameter[]
                    {
            new SqlParameter("@EggSalesID", selectedSaleID)
                    };

                DataAccess db = new DataAccess(connectionString);
                db.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Sale canceled successfully.");

                LoadSales();
            }
        }
    }
}
