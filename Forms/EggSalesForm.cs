using Microsoft.Data.SqlClient;
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
            INSERT INTO EggSales (UnitPrice, AvgUnit, BatchID, RetailID)
            VALUES (@UnitPrice, @AvgUnit, @BatchID, @RetailID)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UnitPrice", decimal.Parse(textBox1.Text)),
            new SqlParameter("@AvgUnit", int.Parse(textBox2.Text)),
            new SqlParameter("@BatchID", comboBox2.SelectedValue),
            new SqlParameter("@RetailID", comboBox1.SelectedValue)
            };

            DataAccess db = new DataAccess(connectionString);
            db.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Sale recorded.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedSaleID == -1)
            {
                MessageBox.Show("Please select a sale first.");
                return;
            }
            string query = @"
            UPDATE EggSales
            SET UnitPrice = @UnitPrice,
                AvgUnit = @AvgUnit,
                BatchID = @BatchID,
                RetailID = @RetailID
            WHERE EggSalesID = @EggSalesID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UnitPrice", decimal.Parse(textBox1.Text)),
            new SqlParameter("@AvgUnit", int.Parse(textBox2.Text)),
            new SqlParameter("@BatchID", comboBox2.SelectedValue),
            new SqlParameter("@RetailID", comboBox1.SelectedValue),
            new SqlParameter("@EggSalesID", selectedSaleID)
            };

            DataAccess db = new DataAccess(connectionString);
            db.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Sale updated.");
        }

        private void LoadSales()
        {
            string query = @"
            SELECT 
                EggSalesID,
                UnitPrice,
                AvgUnit,
                BatchID,
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

                comboBox2.SelectedValue = row.Cells["BatchID"].Value;
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
