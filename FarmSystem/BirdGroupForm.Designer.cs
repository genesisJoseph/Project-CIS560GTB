namespace FarmForm
{
    partial class BirdGroupForm
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
            this.dgvCGroup = new System.Windows.Forms.DataGridView();
            this.btLoad = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtBGBreedID = new System.Windows.Forms.TextBox();
            this.txtConfinement = new System.Windows.Forms.TextBox();
            this.txtBGroupID = new System.Windows.Forms.TextBox();
            this.txtCFarmID = new System.Windows.Forms.TextBox();
            this.uxChickenBreedID = new System.Windows.Forms.Label();
            this.uxConfinement = new System.Windows.Forms.Label();
            this.uxCFarmID = new System.Windows.Forms.Label();
            this.uxBGroupID = new System.Windows.Forms.Label();
            this.uxBGroupMg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCGroup
            // 
            this.dgvCGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCGroup.Location = new System.Drawing.Point(147, 492);
            this.dgvCGroup.Name = "dgvCGroup";
            this.dgvCGroup.Size = new System.Drawing.Size(463, 135);
            this.dgvCGroup.TabIndex = 17;
            // 
            // btLoad
            // 
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btLoad.Location = new System.Drawing.Point(630, 404);
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
            this.btClear.Location = new System.Drawing.Point(466, 404);
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
            this.btDelete.Location = new System.Drawing.Point(316, 404);
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
            this.btUpdate.Location = new System.Drawing.Point(181, 404);
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
            this.btAdd.Location = new System.Drawing.Point(58, 404);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 28;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtBGBreedID
            // 
            this.txtBGBreedID.Location = new System.Drawing.Point(258, 329);
            this.txtBGBreedID.Multiline = true;
            this.txtBGBreedID.Name = "txtBGBreedID";
            this.txtBGBreedID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBGBreedID.Size = new System.Drawing.Size(100, 20);
            this.txtBGBreedID.TabIndex = 27;
            // 
            // txtConfinement
            // 
            this.txtConfinement.Location = new System.Drawing.Point(258, 220);
            this.txtConfinement.Multiline = true;
            this.txtConfinement.Name = "txtConfinement";
            this.txtConfinement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConfinement.Size = new System.Drawing.Size(100, 20);
            this.txtConfinement.TabIndex = 26;
            // 
            // txtBGroupID
            // 
            this.txtBGroupID.Location = new System.Drawing.Point(258, 161);
            this.txtBGroupID.Multiline = true;
            this.txtBGroupID.Name = "txtBGroupID";
            this.txtBGroupID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBGroupID.Size = new System.Drawing.Size(100, 20);
            this.txtBGroupID.TabIndex = 25;
            // 
            // txtCFarmID
            // 
            this.txtCFarmID.Location = new System.Drawing.Point(258, 271);
            this.txtCFarmID.Multiline = true;
            this.txtCFarmID.Name = "txtCFarmID";
            this.txtCFarmID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCFarmID.Size = new System.Drawing.Size(100, 20);
            this.txtCFarmID.TabIndex = 24;
            // 
            // uxChickenBreedID
            // 
            this.uxChickenBreedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxChickenBreedID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxChickenBreedID.Location = new System.Drawing.Point(44, 325);
            this.uxChickenBreedID.Name = "uxChickenBreedID";
            this.uxChickenBreedID.Size = new System.Drawing.Size(186, 24);
            this.uxChickenBreedID.TabIndex = 22;
            this.uxChickenBreedID.Text = "BirdBreedID";
            this.uxChickenBreedID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxConfinement
            // 
            this.uxConfinement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxConfinement.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxConfinement.Location = new System.Drawing.Point(44, 216);
            this.uxConfinement.Name = "uxConfinement";
            this.uxConfinement.Size = new System.Drawing.Size(186, 24);
            this.uxConfinement.TabIndex = 21;
            this.uxConfinement.Text = "Confinement";
            this.uxConfinement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxCFarmID
            // 
            this.uxCFarmID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxCFarmID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxCFarmID.Location = new System.Drawing.Point(44, 271);
            this.uxCFarmID.Name = "uxCFarmID";
            this.uxCFarmID.Size = new System.Drawing.Size(186, 24);
            this.uxCFarmID.TabIndex = 20;
            this.uxCFarmID.Text = "FarmID";
            this.uxCFarmID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxBGroupID
            // 
            this.uxBGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxBGroupID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxBGroupID.Location = new System.Drawing.Point(44, 157);
            this.uxBGroupID.Name = "uxBGroupID";
            this.uxBGroupID.Size = new System.Drawing.Size(186, 24);
            this.uxBGroupID.TabIndex = 19;
            this.uxBGroupID.Text = "BirdGroupID";
            this.uxBGroupID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxBGroupMg
            // 
            this.uxBGroupMg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxBGroupMg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxBGroupMg.Location = new System.Drawing.Point(294, 59);
            this.uxBGroupMg.Name = "uxBGroupMg";
            this.uxBGroupMg.Size = new System.Drawing.Size(236, 24);
            this.uxBGroupMg.TabIndex = 18;
            this.uxBGroupMg.Text = "Bird Group Management";
            this.uxBGroupMg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BirdGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.dgvCGroup);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtBGBreedID);
            this.Controls.Add(this.txtConfinement);
            this.Controls.Add(this.txtBGroupID);
            this.Controls.Add(this.txtCFarmID);
            this.Controls.Add(this.uxChickenBreedID);
            this.Controls.Add(this.uxConfinement);
            this.Controls.Add(this.uxCFarmID);
            this.Controls.Add(this.uxBGroupID);
            this.Controls.Add(this.uxBGroupMg);
            this.Name = "BirdGroupForm";
            this.Text = "ChickenGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCGroup;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtBGBreedID;
        private System.Windows.Forms.TextBox txtConfinement;
        private System.Windows.Forms.TextBox txtBGroupID;
        private System.Windows.Forms.TextBox txtCFarmID;
        private System.Windows.Forms.Label uxChickenBreedID;
        private System.Windows.Forms.Label uxConfinement;
        private System.Windows.Forms.Label uxCFarmID;
        private System.Windows.Forms.Label uxBGroupID;
        private System.Windows.Forms.Label uxBGroupMg;
    }
}