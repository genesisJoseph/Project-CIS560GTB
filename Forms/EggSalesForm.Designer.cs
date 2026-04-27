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
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 367);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(670, 160);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EggSaleTx
            // 
            EggSaleTx.AutoSize = true;
            EggSaleTx.Location = new Point(342, 310);
            EggSaleTx.Name = "EggSaleTx";
            EggSaleTx.Size = new Size(108, 32);
            EggSaleTx.TabIndex = 1;
            EggSaleTx.Text = "EggSales";
            // 
            // button2
            // 
            button2.Location = new Point(340, 240);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(529, 240);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 4;
            button3.Text = "Cancle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 12);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 5;
            label1.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 105);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 6;
            label2.Text = "Retail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 169);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 7;
            label3.Text = "Batch";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(290, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(290, 161);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 58);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 12;
            label4.Text = "Avg Price";
            // 
            // button4
            // 
            button4.Location = new Point(152, 240);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 14;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // EggSalesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(EggSaleTx);
            Controls.Add(dataGridView1);
            Name = "EggSalesForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label EggSaleTx;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button4;
    }
}
