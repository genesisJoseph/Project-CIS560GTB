using System.Data.SqlClient;
namespace Forms
{
    partial class EggSalesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            EggSaleTx = new Label();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUnitPrice = new TextBox();
            txtAvgUnit = new TextBox();
            label4 = new Label();
            button4 = new Button();
            txtEggSaleID = new TextBox();
            EggSaleIdLabel = new Label();
            LoadButton = new Button();
            DeleteButton = new Button();
            txtRetailID = new TextBox();
            txtBatchID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 409);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(524, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dgvSales_CellClick;
            // 
            // EggSaleTx
            // 
            EggSaleTx.AutoSize = true;
            EggSaleTx.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EggSaleTx.Location = new Point(14, 9);
            EggSaleTx.Margin = new Padding(2, 0, 2, 0);
            EggSaleTx.Name = "EggSaleTx";
            EggSaleTx.Size = new Size(95, 28);
            EggSaleTx.TabIndex = 1;
            EggSaleTx.Text = "EggSales";
            // 
            // button2
            // 
            button2.Location = new Point(354, 199);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(115, 36);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(99, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(98, 266);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 6;
            label2.Text = "Retail ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(99, 344);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 7;
            label3.Text = "Batch ID";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(99, 165);
            txtUnitPrice.Margin = new Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(155, 31);
            txtUnitPrice.TabIndex = 11;
            // 
            // txtAvgUnit
            // 
            txtAvgUnit.Location = new Point(98, 227);
            txtAvgUnit.Margin = new Padding(2);
            txtAvgUnit.Name = "txtAvgUnit";
            txtAvgUnit.Size = new Size(155, 31);
            txtAvgUnit.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(99, 199);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 12;
            label4.Text = "Avg Price";
            // 
            // button4
            // 
            button4.Location = new Point(354, 141);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(115, 36);
            button4.TabIndex = 14;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btAdd_Click;
            // 
            // txtEggSaleID
            // 
            txtEggSaleID.Location = new Point(99, 93);
            txtEggSaleID.Name = "txtEggSaleID";
            txtEggSaleID.Size = new Size(150, 31);
            txtEggSaleID.TabIndex = 20;
            // 
            // EggSaleIdLabel
            // 
            EggSaleIdLabel.AutoSize = true;
            EggSaleIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EggSaleIdLabel.Location = new Point(99, 65);
            EggSaleIdLabel.Name = "EggSaleIdLabel";
            EggSaleIdLabel.Size = new Size(96, 25);
            EggSaleIdLabel.TabIndex = 19;
            EggSaleIdLabel.Text = "EggSaleId";
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(524, 141);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(112, 34);
            LoadButton.TabIndex = 23;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(524, 199);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(112, 34);
            DeleteButton.TabIndex = 24;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += btDelete_Click;
            // 
            // txtRetailID
            // 
            txtRetailID.Location = new Point(98, 294);
            txtRetailID.Margin = new Padding(2);
            txtRetailID.Name = "txtRetailID";
            txtRetailID.Size = new Size(155, 31);
            txtRetailID.TabIndex = 25;
            // 
            // txtBatchID
            // 
            txtBatchID.Location = new Point(99, 372);
            txtBatchID.Margin = new Padding(2);
            txtBatchID.Name = "txtBatchID";
            txtBatchID.Size = new Size(155, 31);
            txtBatchID.TabIndex = 26;
            // 
            // EggSalesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 805);
            Controls.Add(txtBatchID);
            Controls.Add(txtRetailID);
            Controls.Add(DeleteButton);
            Controls.Add(LoadButton);
            Controls.Add(txtEggSaleID);
            Controls.Add(EggSaleIdLabel);
            Controls.Add(button4);
            Controls.Add(txtAvgUnit);
            Controls.Add(label4);
            Controls.Add(txtUnitPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(EggSaleTx);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "EggSalesForm";
            Text = "Form1";
            Load += EggSalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label EggSaleTx;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUnitPrice;
        private TextBox txtAvgUnit;
        private Label label4;
        private Button button4;
        private TextBox txtEggSaleID;
        private Label EggSaleIdLabel;
        private Button LoadButton;
        private Button DeleteButton;
        private TextBox txtRetailID;
        private TextBox txtBatchID;
    }
}
