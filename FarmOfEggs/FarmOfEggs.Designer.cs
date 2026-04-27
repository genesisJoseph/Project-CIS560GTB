namespace FarmOfEggs
{
    partial class FarmOfEggs
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
            BirdGroupIDTB = new TextBox();
            GradeTB = new TextBox();
            SizeTB = new TextBox();
            EggColorTB = new TextBox();
            DateProducedDTP = new DateTimePicker();
            BestByDateDTP = new DateTimePicker();
            AddButton = new Button();
            LoadButton = new Button();
            BirdGroupIdLabel = new Label();
            GradeLabel = new Label();
            EggColorLabel = new Label();
            SizeLabel = new Label();
            DateProducedLabel = new Label();
            BestByDateLabel = new Label();
            dataGridView1 = new DataGridView();
            UpdateButton = new Button();
            DeleteButton = new Button();
            BatchEggIdLabel = new Label();
            BatchEggIdTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ChickenGroupIDTB
            // 
            BirdGroupIDTB.Location = new Point(101, 55);
            BirdGroupIDTB.Name = "BirdGroupIDTB";
            BirdGroupIDTB.Size = new Size(150, 31);
            BirdGroupIDTB.TabIndex = 0;
            // 
            // GradeTB
            // 
            GradeTB.Location = new Point(101, 127);
            GradeTB.Name = "GradeTB";
            GradeTB.Size = new Size(150, 31);
            GradeTB.TabIndex = 1;
            // 
            // SizeTB
            // 
            SizeTB.Location = new Point(100, 256);
            SizeTB.Name = "SizeTB";
            SizeTB.Size = new Size(150, 31);
            SizeTB.TabIndex = 2;
            // 
            // EggColorTB
            // 
            EggColorTB.Location = new Point(100, 189);
            EggColorTB.Name = "EggColorTB";
            EggColorTB.Size = new Size(150, 31);
            EggColorTB.TabIndex = 3;
            // 
            // DateProducedDTP
            // 
            DateProducedDTP.Location = new Point(324, 64);
            DateProducedDTP.Name = "DateProducedDTP";
            DateProducedDTP.Size = new Size(300, 31);
            DateProducedDTP.TabIndex = 4;
            // 
            // BestByDateDTP
            // 
            BestByDateDTP.Location = new Point(323, 140);
            BestByDateDTP.Name = "BestByDateDTP";
            BestByDateDTP.Size = new Size(300, 31);
            BestByDateDTP.TabIndex = 5;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(323, 198);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += btnAdd_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(493, 198);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(112, 34);
            LoadButton.TabIndex = 7;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // ChickenGroupIdLabel
            // 
            BirdGroupIdLabel.AutoSize = true;
            BirdGroupIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BirdGroupIdLabel.Location = new Point(101, 27);
            BirdGroupIdLabel.Name = "BirdGroupIdLabel";
            BirdGroupIdLabel.Size = new Size(149, 25);
            BirdGroupIdLabel.TabIndex = 8;
            BirdGroupIdLabel.Text = "BirdGroupId";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradeLabel.Location = new Point(101, 99);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(63, 25);
            GradeLabel.TabIndex = 9;
            GradeLabel.Text = "Grade";
            // 
            // EggColorLabel
            // 
            EggColorLabel.AutoSize = true;
            EggColorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EggColorLabel.Location = new Point(101, 161);
            EggColorLabel.Name = "EggColorLabel";
            EggColorLabel.Size = new Size(89, 25);
            EggColorLabel.TabIndex = 10;
            EggColorLabel.Text = "EggColor";
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SizeLabel.Location = new Point(100, 228);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(46, 25);
            SizeLabel.TabIndex = 11;
            SizeLabel.Text = "Size";
            // 
            // DateProducedLabel
            // 
            DateProducedLabel.AutoSize = true;
            DateProducedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateProducedLabel.Location = new Point(323, 27);
            DateProducedLabel.Name = "DateProducedLabel";
            DateProducedLabel.Size = new Size(138, 25);
            DateProducedLabel.TabIndex = 12;
            DateProducedLabel.Text = "Data Produced";
            // 
            // BestByDateLabel
            // 
            BestByDateLabel.AutoSize = true;
            BestByDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BestByDateLabel.Location = new Point(323, 112);
            BestByDateLabel.Name = "BestByDateLabel";
            BestByDateLabel.Size = new Size(121, 25);
            BestByDateLabel.TabIndex = 13;
            BestByDateLabel.Text = "Best By Date";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 409);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(524, 314);
            dataGridView1.TabIndex = 14;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(323, 256);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(112, 34);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(493, 256);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(112, 34);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // BatchEggIdLabel
            // 
            BatchEggIdLabel.AutoSize = true;
            BatchEggIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BatchEggIdLabel.Location = new Point(100, 290);
            BatchEggIdLabel.Name = "BatchEggIdLabel";
            BatchEggIdLabel.Size = new Size(110, 25);
            BatchEggIdLabel.TabIndex = 17;
            BatchEggIdLabel.Text = "EggBatchId";
            // 
            // BatchEggIdTB
            // 
            BatchEggIdTB.Location = new Point(101, 334);
            BatchEggIdTB.Name = "BatchEggIdTB";
            BatchEggIdTB.Size = new Size(150, 31);
            BatchEggIdTB.TabIndex = 18;
            // 
            // FarmOfEggs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 805);
            Controls.Add(BatchEggIdTB);
            Controls.Add(BatchEggIdLabel);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView1);
            Controls.Add(BestByDateLabel);
            Controls.Add(DateProducedLabel);
            Controls.Add(SizeLabel);
            Controls.Add(EggColorLabel);
            Controls.Add(GradeLabel);
            Controls.Add(BirdGroupIdLabel);
            Controls.Add(LoadButton);
            Controls.Add(AddButton);
            Controls.Add(BestByDateDTP);
            Controls.Add(DateProducedDTP);
            Controls.Add(EggColorTB);
            Controls.Add(SizeTB);
            Controls.Add(GradeTB);
            Controls.Add(BirdGroupIDTB);
            Name = "FarmOfEggs";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BirdGroupIDTB;
        private TextBox GradeTB;
        private TextBox SizeTB;
        private TextBox EggColorTB;
        private DateTimePicker DateProducedDTP;
        private DateTimePicker BestByDateDTP;
        private Button AddButton;
        private Button LoadButton;
        private Label BirdGroupIdLabel;
        private Label GradeLabel;
        private Label EggColorLabel;
        private Label SizeLabel;
        private Label DateProducedLabel;
        private Label BestByDateLabel;
        private DataGridView dataGridView1;
        private Button UpdateButton;
        private Button DeleteButton;
        private Label BatchEggIdLabel;
        private TextBox BatchEggIdTB;
    }
}
