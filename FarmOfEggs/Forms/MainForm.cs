using Forms;

namespace FarmOfEggs.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowFormInPanel(Form childForm)
        {
            // 1. Clear the panel of any previous forms
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            // 2. Setup the child form
            childForm.TopLevel = false;             // Required to embed
            childForm.FormBorderStyle = FormBorderStyle.None; // Remove window borders
            childForm.Dock = DockStyle.Fill;        // Make it fill the panel area

            // 3. Add to panel and display
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.Show();
        }

        private void FarmFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FarmForm.FarmForm());
        }

        private void BirdBreedFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FarmForm.BirdBreedForm());
        }

        private void BirdGroupFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FarmForm.BirdGroupForm());
        }

        private void BatchEggFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new BatchEggForm());
        }

        private void SaleFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new EggSalesForm());
        }

        private void RetailFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new RetailForm());
        }

        private void ReportsFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ReportsForm());
        }
    }
}
