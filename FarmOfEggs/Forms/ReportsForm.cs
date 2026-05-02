// Forms/ReportsForm.cs
using System;
using System.Windows.Forms;
using FarmOfEggs.Data;

namespace FarmOfEggs.Forms
{
    public partial class ReportsForm : Form
    {
        private DataAccessReports _reports = new DataAccessReports();

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Load the first report by default
            LoadEggsByRetail();
        }

        private void LoadEggsByRetail()
        {
            try { dataGridView1.DataSource = _reports.GetEggsSoldByRetail(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEggsByRetail_Click(object sender, EventArgs e) => LoadEggsByRetail();

        private void btnPriceByGrade_Click(object sender, EventArgs e)
        {
            try { dataGridView1.DataSource = _reports.GetAvgPriceByGrade(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRevenueByFarm_Click(object sender, EventArgs e)
        {
            try { dataGridView1.DataSource = _reports.GetRevenueByFarm(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRevenueByBreed_Click(object sender, EventArgs e)
        {
            try { dataGridView1.DataSource = _reports.GetRevenueByBreed(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}