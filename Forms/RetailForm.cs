using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;


namespace Forms
{
    public partial class RetailForm : Form
    {
        private int selectedRetailID;
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Farm;Trusted_Connection=True;";
        public RetailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"
            INSERT INTO Retail (PhoneNumber, Name, RetailFee)
            VALUES (@PhoneNumber, @Name, @RetailFee)";
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@PhoneNumber", textBox2.Text),
                new SqlParameter("@Name", textBox1.Text),
                new SqlParameter("@RetailFee", decimal.Parse(textBox3.Text))
                };

                DataAccess db = new DataAccess(connectionString);
                db.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Retail added successfully.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                string query = @"
            UPDATE Retail
            SET PhoneNumber = @PhoneNumber,
                Name = @Name,
                RetailFee = @RetailFee
            WHERE RetailID = @RetailID";
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                SqlParameter[] parameters = new SqlParameter[]
                    {
            new SqlParameter("@PhoneNumber", textBox2.Text),
            new SqlParameter("@Name", textBox1.Text),
            new SqlParameter("@RetailFee", decimal.Parse(textBox3.Text)),
            new SqlParameter("@RetailID", selectedRetailID)
                    };

                DataAccess db = new DataAccess(connectionString);
                db.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Retail updated.");
            }
        }
        private void dgvRetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedRetailID = Convert.ToInt32(row.Cells["RetailID"].Value);

                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["PhoneNumber"].Value.ToString();
                textBox3.Text = row.Cells["RetailFee"].Value.ToString();
            }
        }
    }
}
