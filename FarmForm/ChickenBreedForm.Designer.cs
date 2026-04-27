namespace FarmForm
{
    partial class ChickenBreedForm
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
            this.dgvChickenBreed = new System.Windows.Forms.DataGridView();
            this.btLoad = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCBreedID = new System.Windows.Forms.TextBox();
            this.uxSpecies = new System.Windows.Forms.Label();
            this.uxChickenBreedID = new System.Windows.Forms.Label();
            this.uxBName = new System.Windows.Forms.Label();
            this.uxBreedMg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChickenBreed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChickenBreed
            // 
            this.dgvChickenBreed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChickenBreed.Location = new System.Drawing.Point(208, 527);
            this.dgvChickenBreed.Name = "dgvChickenBreed";
            this.dgvChickenBreed.Size = new System.Drawing.Size(340, 135);
            this.dgvChickenBreed.TabIndex = 33;
            // 
            // btLoad
            // 
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btLoad.Location = new System.Drawing.Point(651, 429);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 32;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btClear.Location = new System.Drawing.Point(519, 429);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 31;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btDelete.Location = new System.Drawing.Point(372, 429);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 30;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btUpdate.Location = new System.Drawing.Point(220, 429);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 29;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(58, 429);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 28;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(258, 246);
            this.txtSpecies.Multiline = true;
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecies.Size = new System.Drawing.Size(100, 20);
            this.txtSpecies.TabIndex = 25;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(258, 191);
            this.txtCName.Multiline = true;
            this.txtCName.Name = "txtCName";
            this.txtCName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 24;
            // 
            // txtCBreedID
            // 
            this.txtCBreedID.Location = new System.Drawing.Point(258, 128);
            this.txtCBreedID.Multiline = true;
            this.txtCBreedID.Name = "txtCBreedID";
            this.txtCBreedID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCBreedID.Size = new System.Drawing.Size(100, 20);
            this.txtCBreedID.TabIndex = 23;
            // 
            // uxSpecies
            // 
            this.uxSpecies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxSpecies.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxSpecies.Location = new System.Drawing.Point(44, 242);
            this.uxSpecies.Name = "uxSpecies";
            this.uxSpecies.Size = new System.Drawing.Size(186, 24);
            this.uxSpecies.TabIndex = 20;
            this.uxSpecies.Text = "Species";
            this.uxSpecies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxChickenBreedID
            // 
            this.uxChickenBreedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxChickenBreedID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxChickenBreedID.Location = new System.Drawing.Point(44, 124);
            this.uxChickenBreedID.Name = "uxChickenBreedID";
            this.uxChickenBreedID.Size = new System.Drawing.Size(186, 24);
            this.uxChickenBreedID.TabIndex = 19;
            this.uxChickenBreedID.Text = "ChickenBreedID";
            this.uxChickenBreedID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxBName
            // 
            this.uxBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxBName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxBName.Location = new System.Drawing.Point(44, 187);
            this.uxBName.Name = "uxBName";
            this.uxBName.Size = new System.Drawing.Size(186, 24);
            this.uxBName.TabIndex = 18;
            this.uxBName.Text = "Name";
            this.uxBName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxBreedMg
            // 
            this.uxBreedMg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxBreedMg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxBreedMg.Location = new System.Drawing.Point(294, 30);
            this.uxBreedMg.Name = "uxBreedMg";
            this.uxBreedMg.Size = new System.Drawing.Size(186, 24);
            this.uxBreedMg.TabIndex = 17;
            this.uxBreedMg.Text = "Chicken Breed Management";
            this.uxBreedMg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChickenBreedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 813);
            this.Controls.Add(this.dgvChickenBreed);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCBreedID);
            this.Controls.Add(this.uxSpecies);
            this.Controls.Add(this.uxChickenBreedID);
            this.Controls.Add(this.uxBName);
            this.Controls.Add(this.uxBreedMg);
            this.Name = "ChickenBreedForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChickenBreed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChickenBreed;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCBreedID;
        private System.Windows.Forms.Label uxSpecies;
        private System.Windows.Forms.Label uxChickenBreedID;
        private System.Windows.Forms.Label uxBName;
        private System.Windows.Forms.Label uxBreedMg;
    }
}