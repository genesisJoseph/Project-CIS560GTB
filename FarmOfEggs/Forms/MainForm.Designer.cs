namespace FarmOfEggs.Forms
{
    partial class MainForm
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
            FarmFormButton = new Button();
            BirdGroupFormButton = new Button();
            RetailFormButton = new Button();
            BatchEggFormButton = new Button();
            BirdBreedFormButton = new Button();
            mainPanel = new Panel();
            SaleFormButton = new Button();
            SuspendLayout();
            // 
            // FarmFormButton
            // 
            FarmFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            FarmFormButton.Location = new Point(221, 33);
            FarmFormButton.Name = "FarmFormButton";
            FarmFormButton.Size = new Size(153, 58);
            FarmFormButton.TabIndex = 0;
            FarmFormButton.Text = "Farm";
            FarmFormButton.UseVisualStyleBackColor = true;
            FarmFormButton.Click += FarmFormButton_Click;
            // 
            // BirdGroupFormButton
            // 
            BirdGroupFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BirdGroupFormButton.Location = new Point(221, 117);
            BirdGroupFormButton.Name = "BirdGroupFormButton";
            BirdGroupFormButton.Size = new Size(153, 58);
            BirdGroupFormButton.TabIndex = 1;
            BirdGroupFormButton.Text = "Bird Group";
            BirdGroupFormButton.UseVisualStyleBackColor = true;
            BirdGroupFormButton.Click += BirdGroupFormButton_Click;
            // 
            // RetailFormButton
            // 
            RetailFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            RetailFormButton.Location = new Point(221, 197);
            RetailFormButton.Name = "RetailFormButton";
            RetailFormButton.Size = new Size(153, 58);
            RetailFormButton.TabIndex = 2;
            RetailFormButton.Text = "Retail";
            RetailFormButton.UseVisualStyleBackColor = true;
            RetailFormButton.Click += RetailFormButton_Click;
            // 
            // BatchEggFormButton
            // 
            BatchEggFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BatchEggFormButton.Location = new Point(655, 117);
            BatchEggFormButton.Name = "BatchEggFormButton";
            BatchEggFormButton.Size = new Size(153, 58);
            BatchEggFormButton.TabIndex = 3;
            BatchEggFormButton.Text = "Egg Batch";
            BatchEggFormButton.UseVisualStyleBackColor = true;
            BatchEggFormButton.Click += BatchEggFormButton_Click;
            // 
            // BirdBreedFormButton
            // 
            BirdBreedFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BirdBreedFormButton.Location = new Point(655, 33);
            BirdBreedFormButton.Name = "BirdBreedFormButton";
            BirdBreedFormButton.Size = new Size(153, 58);
            BirdBreedFormButton.TabIndex = 4;
            BirdBreedFormButton.Text = "Bird Breed";
            BirdBreedFormButton.UseVisualStyleBackColor = true;
            BirdBreedFormButton.Click += BirdBreedFormButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(148, 264);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 894);
            mainPanel.TabIndex = 5;
            // 
            // SaleFormButton
            // 
            SaleFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SaleFormButton.Location = new Point(655, 197);
            SaleFormButton.Name = "SaleFormButton";
            SaleFormButton.Size = new Size(153, 58);
            SaleFormButton.TabIndex = 6;
            SaleFormButton.Text = "Sales";
            SaleFormButton.UseVisualStyleBackColor = true;
            SaleFormButton.Click += SaleFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 1195);
            Controls.Add(SaleFormButton);
            Controls.Add(mainPanel);
            Controls.Add(BirdBreedFormButton);
            Controls.Add(BatchEggFormButton);
            Controls.Add(RetailFormButton);
            Controls.Add(BirdGroupFormButton);
            Controls.Add(FarmFormButton);
            Name = "MainForm";
            Text = "Application";
            ResumeLayout(false);
        }

        #endregion

        private Button FarmFormButton;
        private Button BirdGroupFormButton;
        private Button RetailFormButton;
        private Button BatchEggFormButton;
        private Button BirdBreedFormButton;
        private Panel mainPanel;
        private Button SaleFormButton;
    }
}