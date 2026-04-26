using FarmOfEggs.Data;
using FarmOfEggs.Models;
using System.Windows.Forms;

namespace FarmOfEggs
{
    public partial class FarmOfEggs : Form
    {
        public FarmOfEggs()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var service = new BatchEggService();

            var egg = new BatchEgg
            {
                ChickenGroupID = int.Parse(ChickenGroupIDTB.Text),
                Size = SizeTB.Text,
                DateProduced = DateProducedDTP.Value,
                BestByDate = BestByDateDTP.Value,
                Grade = GradeTB.Text,
                EggColor = EggColorTB.Text
            };

            service.Insert(egg);
            MessageBox.Show("Inserted!");
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            var service = new BatchEggService();
            dataGridView1.DataSource = service.GetAll();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var service = new BatchEggService();

            var egg = new BatchEgg
            {
                BatchEggID = int.Parse(BatchEggIdTB.Text), // add this textbox
                ChickenGroupID = int.Parse(ChickenGroupIDTB.Text),
                Size = SizeTB.Text,
                DateProduced = DateProducedDTP.Value,
                BestByDate = BestByDateDTP.Value,
                Grade = GradeTB.Text,
                EggColor = EggColorTB.Text
            };

            service.Update(egg);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var service = new BatchEggService();
            service.Delete(int.Parse(BatchEggIdTB.Text));
        }
    }
}
