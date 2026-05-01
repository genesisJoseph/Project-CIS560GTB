using FarmOfEggs.Data;
using FarmOfEggs.Models;
using System.Windows.Forms;

namespace FarmOfEggs
{
    public partial class BatchEggForm : Form
    {
        public BatchEggForm()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BirdGroupIDTB.Text == "" || SizeTB.Text == "" || GradeTB.Text == "" || EggColorTB.Text == "" || QuantityTB.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            var service = new BatchEggService();

            var egg = new BatchEgg
            {
                BirdGroupID = int.Parse(BirdGroupIDTB.Text),
                Size = SizeTB.Text,
                DateProduced = DateProducedDTP.Value,
                BestByDate = BestByDateDTP.Value,
                Grade = GradeTB.Text,
                EggColor = EggColorTB.Text,
                Quantity = int.Parse(QuantityTB.Text)
            };

            service.Insert(egg);
            MessageBox.Show("Inserted!");
            dataGridView1.DataSource = service.GetAll();
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            var service = new BatchEggService();
            if (BirdGroupIDTB.Text != "")
            {
                
                dataGridView1.DataSource = service.GetRow(BirdGroupIDTB.Text);
                return;
            }            
            dataGridView1.DataSource = service.GetAll();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (BatchEggIdTB.Text == "")
            {
                MessageBox.Show("Please select a batch egg to update.");
                return;
            }

            if (BirdGroupIDTB.Text == "" || SizeTB.Text == "" || GradeTB.Text == "" || EggColorTB.Text == "" || QuantityTB.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            var service = new BatchEggService();

            var egg = new BatchEgg
            {
                BatchEggID = int.Parse(BatchEggIdTB.Text), // add this textbox
                BirdGroupID = int.Parse(BirdGroupIDTB.Text),
                Size = SizeTB.Text,
                DateProduced = DateProducedDTP.Value,
                BestByDate = BestByDateDTP.Value,
                Grade = GradeTB.Text,
                EggColor = EggColorTB.Text
            };

            service.Update(egg);
            MessageBox.Show("Batch egg updated successfully.");
            dataGridView1.DataSource = service.GetAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var service = new BatchEggService();
            service.Delete(int.Parse(BatchEggIdTB.Text));
            MessageBox.Show("Batch egg deleted successfully.");
            dataGridView1.DataSource = service.GetAll();
        }
    }
}
