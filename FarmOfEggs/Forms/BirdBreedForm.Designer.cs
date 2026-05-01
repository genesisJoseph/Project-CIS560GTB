namespace FarmForm
{
    partial class BirdBreedForm
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
            dgvBirdBreed = new DataGridView();
            btLoad = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            btAdd = new Button();
            txtSpecies = new TextBox();
            txtCName = new TextBox();
            txtCBreedID = new TextBox();
            uxSpecies = new Label();
            uxBirdBreedID = new Label();
            uxBName = new Label();
            uxBreedMg = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBirdBreed).BeginInit();
            SuspendLayout();
            // 
            // dgvBirdBreed
            // 
            dgvBirdBreed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBirdBreed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBirdBreed.Location = new Point(99, 409);
            dgvBirdBreed.Margin = new Padding(5, 6, 5, 6);
            dgvBirdBreed.Name = "dgvBirdBreed";
            dgvBirdBreed.RowHeadersVisible = false;
            dgvBirdBreed.RowHeadersWidth = 62;
            dgvBirdBreed.Size = new Size(524, 384);
            dgvBirdBreed.TabIndex = 33;
            // 
            // btLoad
            // 
            btLoad.Font = new Font("Segoe UI", 9F);
            btLoad.Location = new Point(524, 141);
            btLoad.Margin = new Padding(5, 6, 5, 6);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(112, 34);
            btLoad.TabIndex = 32;
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
            btDelete.TabIndex = 30;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 9F);
            btUpdate.Location = new Point(354, 199);
            btUpdate.Margin = new Padding(5, 6, 5, 6);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(112, 34);
            btUpdate.TabIndex = 29;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btAdd
            // 
            btAdd.Font = new Font("Segoe UI", 9F);
            btAdd.Location = new Point(354, 141);
            btAdd.Margin = new Padding(5, 6, 5, 6);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(112, 34);
            btAdd.TabIndex = 28;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(98, 227);
            txtSpecies.Margin = new Padding(5, 6, 5, 6);
            txtSpecies.Multiline = true;
            txtSpecies.Name = "txtSpecies";
            txtSpecies.ScrollBars = ScrollBars.Vertical;
            txtSpecies.Size = new Size(150, 31);
            txtSpecies.TabIndex = 25;
            // 
            // txtCName
            // 
            txtCName.Location = new Point(99, 165);
            txtCName.Margin = new Padding(5, 6, 5, 6);
            txtCName.Multiline = true;
            txtCName.Name = "txtCName";
            txtCName.ScrollBars = ScrollBars.Both;
            txtCName.Size = new Size(150, 31);
            txtCName.TabIndex = 24;
            // 
            // txtCBreedID
            // 
            txtCBreedID.Location = new Point(99, 93);
            txtCBreedID.Margin = new Padding(5, 6, 5, 6);
            txtCBreedID.Multiline = true;
            txtCBreedID.Name = "txtCBreedID";
            txtCBreedID.ScrollBars = ScrollBars.Both;
            txtCBreedID.Size = new Size(150, 31);
            txtCBreedID.TabIndex = 23;
            // 
            // uxSpecies
            // 
            uxSpecies.AutoSize = true;
            uxSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxSpecies.Location = new Point(99, 199);
            uxSpecies.Margin = new Padding(5, 0, 5, 0);
            uxSpecies.Name = "uxSpecies";
            uxSpecies.Size = new Size(75, 25);
            uxSpecies.TabIndex = 20;
            uxSpecies.Text = "Species";
            uxSpecies.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxBirdBreedID
            // 
            uxBirdBreedID.AutoSize = true;
            uxBirdBreedID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxBirdBreedID.Location = new Point(99, 65);
            uxBirdBreedID.Margin = new Padding(5, 0, 5, 0);
            uxBirdBreedID.Name = "uxBirdBreedID";
            uxBirdBreedID.Size = new Size(116, 25);
            uxBirdBreedID.TabIndex = 19;
            uxBirdBreedID.Text = "BirdBreedID";
            uxBirdBreedID.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxBName
            // 
            uxBName.AutoSize = true;
            uxBName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxBName.Location = new Point(99, 137);
            uxBName.Margin = new Padding(5, 0, 5, 0);
            uxBName.Name = "uxBName";
            uxBName.Size = new Size(62, 25);
            uxBName.TabIndex = 18;
            uxBName.Text = "Name";
            uxBName.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxBreedMg
            // 
            uxBreedMg.AutoSize = true;
            uxBreedMg.BorderStyle = BorderStyle.FixedSingle;
            uxBreedMg.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uxBreedMg.Location = new Point(14, 9);
            uxBreedMg.Margin = new Padding(5, 0, 5, 0);
            uxBreedMg.Name = "uxBreedMg";
            uxBreedMg.Size = new Size(120, 30);
            uxBreedMg.TabIndex = 17;
            uxBreedMg.Text = "Bird Breed ";
            uxBreedMg.TextAlign = ContentAlignment.TopCenter;
            // 
            // BirdBreedForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(704, 805);
            Controls.Add(dgvBirdBreed);
            Controls.Add(btLoad);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(txtSpecies);
            Controls.Add(txtCName);
            Controls.Add(txtCBreedID);
            Controls.Add(uxSpecies);
            Controls.Add(uxBirdBreedID);
            Controls.Add(uxBName);
            Controls.Add(uxBreedMg);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BirdBreedForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBirdBreed).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBirdBreed;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCBreedID;
        private System.Windows.Forms.Label uxSpecies;
        private System.Windows.Forms.Label uxBirdBreedID;
        private System.Windows.Forms.Label uxBName;
        private System.Windows.Forms.Label uxBreedMg;
    }
}