namespace Forms
{
    partial class RetailForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            RetailTx = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTB = new TextBox();
            PhoneTB = new TextBox();
            FeeTB = new TextBox();
            BatchEggIdTB = new TextBox();
            RetailIdLabel = new Label();
            btLoad = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(99, 409);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(524, 384);
            dataGridView1.TabIndex = 0;
            // 
            // RetailTx
            // 
            RetailTx.AutoSize = true;
            RetailTx.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RetailTx.Location = new Point(14, 9);
            RetailTx.Margin = new Padding(2, 0, 2, 0);
            RetailTx.Name = "RetailTx";
            RetailTx.Size = new Size(67, 28);
            RetailTx.TabIndex = 1;
            RetailTx.Text = "Retail";
            // 
            // button1
            // 
            button1.Location = new Point(354, 141);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btAdd_Click;
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
            label1.Size = new Size(116, 25);
            label1.TabIndex = 10;
            label1.Text = "Retail Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(99, 199);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 11;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(98, 266);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 12;
            label3.Text = "Retail Fee";
            // 
            // NameTB
            // 
            NameTB.Location = new Point(99, 165);
            NameTB.Margin = new Padding(2);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(150, 31);
            NameTB.TabIndex = 13;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(98, 227);
            PhoneTB.Margin = new Padding(2);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(150, 31);
            PhoneTB.TabIndex = 14;
            // 
            // FeeTB
            // 
            FeeTB.Location = new Point(98, 294);
            FeeTB.Margin = new Padding(2);
            FeeTB.Name = "FeeTB";
            FeeTB.Size = new Size(150, 31);
            FeeTB.TabIndex = 15;
            // 
            // BatchEggIdTB
            // 
            BatchEggIdTB.Location = new Point(99, 93);
            BatchEggIdTB.Name = "BatchEggIdTB";
            BatchEggIdTB.Size = new Size(150, 31);
            BatchEggIdTB.TabIndex = 20;
            // 
            // RetailIdLabel
            // 
            RetailIdLabel.AutoSize = true;
            RetailIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RetailIdLabel.Location = new Point(99, 65);
            RetailIdLabel.Name = "RetailIdLabel";
            RetailIdLabel.Size = new Size(85, 25);
            RetailIdLabel.TabIndex = 19;
            RetailIdLabel.Text = "Retail ID";
            // 
            // btLoad
            // 
            btLoad.Font = new Font("Segoe UI", 9F);
            btLoad.Location = new Point(524, 141);
            btLoad.Margin = new Padding(5, 6, 5, 6);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(112, 34);
            btLoad.TabIndex = 33;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Segoe UI", 9F);
            btDelete.Location = new Point(524, 199);
            btDelete.Margin = new Padding(5, 6, 5, 6);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 34);
            btDelete.TabIndex = 34;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // RetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 805);
            Controls.Add(btDelete);
            Controls.Add(btLoad);
            Controls.Add(BatchEggIdTB);
            Controls.Add(RetailIdLabel);
            Controls.Add(FeeTB);
            Controls.Add(PhoneTB);
            Controls.Add(NameTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RetailTx);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "RetailForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label RetailTx;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTB;
        private TextBox PhoneTB;
        private TextBox FeeTB;
        private TextBox BatchEggIdTB;
        private Label RetailIdLabel;
        private Button btLoad;
        private Button btDelete;
    }
}