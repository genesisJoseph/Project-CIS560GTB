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
            ChickenGroupFormButton = new Button();
            RetailFormButton = new Button();
            BatchEggFormButton = new Button();
            ChickenBreedFormButton = new Button();
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
            // ChickenGroupFormButton
            // 
            ChickenGroupFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ChickenGroupFormButton.Location = new Point(221, 117);
            ChickenGroupFormButton.Name = "ChickenGroupFormButton";
            ChickenGroupFormButton.Size = new Size(153, 58);
            ChickenGroupFormButton.TabIndex = 1;
            ChickenGroupFormButton.Text = "ChickenGroup";
            ChickenGroupFormButton.UseVisualStyleBackColor = true;
            ChickenGroupFormButton.Click += ChickenGroupFormButton_Click;
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
            // 
            // BatchEggFormButton
            // 
            BatchEggFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BatchEggFormButton.Location = new Point(655, 117);
            BatchEggFormButton.Name = "BatchEggFormButton";
            BatchEggFormButton.Size = new Size(153, 58);
            BatchEggFormButton.TabIndex = 3;
            BatchEggFormButton.Text = "EggBatch";
            BatchEggFormButton.UseVisualStyleBackColor = true;
            BatchEggFormButton.Click += BatchEggFormButton_Click;
            // 
            // ChickenBreedFormButton
            // 
            ChickenBreedFormButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ChickenBreedFormButton.Location = new Point(655, 33);
            ChickenBreedFormButton.Name = "ChickenBreedFormButton";
            ChickenBreedFormButton.Size = new Size(153, 58);
            ChickenBreedFormButton.TabIndex = 4;
            ChickenBreedFormButton.Text = "ChickenBreed";
            ChickenBreedFormButton.UseVisualStyleBackColor = true;
            ChickenBreedFormButton.Click += ChickenBreedFormButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(148, 264);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 739);
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
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 1015);
            Controls.Add(SaleFormButton);
            Controls.Add(mainPanel);
            Controls.Add(ChickenBreedFormButton);
            Controls.Add(BatchEggFormButton);
            Controls.Add(RetailFormButton);
            Controls.Add(ChickenGroupFormButton);
            Controls.Add(FarmFormButton);
            Name = "MainForm";
            Text = "Application";
            ResumeLayout(false);
        }

        #endregion

        private Button FarmFormButton;
        private Button ChickenGroupFormButton;
        private Button RetailFormButton;
        private Button BatchEggFormButton;
        private Button ChickenBreedFormButton;
        private Panel mainPanel;
        private Button SaleFormButton;
    }
}