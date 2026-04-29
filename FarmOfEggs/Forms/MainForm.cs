using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmForm;

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

        private void ChickenBreedFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FarmForm.ChickenBreedForm());
        }

        private void ChickenGroupFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FarmForm.ChickenGroupForm());
        }

        private void BatchEggFormButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new BatchEggForm());
        }
    }
}
