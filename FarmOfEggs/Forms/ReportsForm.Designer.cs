namespace FarmOfEggs.Forms
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnEggsByRetail = new Button();
            btnPriceByGrade = new Button();
            btnRevenueByFarm = new Button();
            btnRevenueByBreed = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(524, 492);
            dataGridView1.TabIndex = 15;
            // 
            // btnEggsByRetail
            // 
            btnEggsByRetail.Location = new Point(127, 78);
            btnEggsByRetail.Name = "btnEggsByRetail";
            btnEggsByRetail.Size = new Size(170, 34);
            btnEggsByRetail.TabIndex = 16;
            btnEggsByRetail.Text = "Eggs By Retail";
            btnEggsByRetail.UseVisualStyleBackColor = true;
            btnEggsByRetail.Click += btnEggsByRetail_Click;
            // 
            // btnPriceByGrade
            // 
            btnPriceByGrade.Location = new Point(406, 78);
            btnPriceByGrade.Name = "btnPriceByGrade";
            btnPriceByGrade.Size = new Size(170, 34);
            btnPriceByGrade.TabIndex = 17;
            btnPriceByGrade.Text = "Price By Grade";
            btnPriceByGrade.UseVisualStyleBackColor = true;
            btnPriceByGrade.Click += btnPriceByGrade_Click;
            // 
            // btnRevenueByFarm
            // 
            btnRevenueByFarm.Location = new Point(127, 187);
            btnRevenueByFarm.Name = "btnRevenueByFarm";
            btnRevenueByFarm.Size = new Size(170, 34);
            btnRevenueByFarm.TabIndex = 18;
            btnRevenueByFarm.Text = "Revenue By Farm";
            btnRevenueByFarm.UseVisualStyleBackColor = true;
            btnRevenueByFarm.Click += btnRevenueByFarm_Click;
            // 
            // btnRevenueByBreed
            // 
            btnRevenueByBreed.Location = new Point(406, 187);
            btnRevenueByBreed.Name = "btnRevenueByBreed";
            btnRevenueByBreed.Size = new Size(170, 34);
            btnRevenueByBreed.TabIndex = 19;
            btnRevenueByBreed.Text = "Revenue By Breed";
            btnRevenueByBreed.UseVisualStyleBackColor = true;
            btnRevenueByBreed.Click += btnRevenueByBreed_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 805);
            Controls.Add(btnRevenueByBreed);
            Controls.Add(btnRevenueByFarm);
            Controls.Add(btnPriceByGrade);
            Controls.Add(btnEggsByRetail);
            Controls.Add(dataGridView1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEggsByRetail;
        private Button btnPriceByGrade;
        private Button btnRevenueByFarm;
        private Button btnRevenueByBreed;
    }
}