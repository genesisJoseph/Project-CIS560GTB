namespace FarmForm
{
    partial class FarmForm
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
            this.uxFarmMg = new System.Windows.Forms.Label();
            this.uxLocation = new System.Windows.Forms.Label();
            this.uxFarmID = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.Label();
            this.uxPNumber = new System.Windows.Forms.Label();
            this.uxOwner = new System.Windows.Forms.Label();
            this.txtFarmID = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.dgvFarm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFarmMg
            // 
            this.uxFarmMg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxFarmMg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxFarmMg.Location = new System.Drawing.Point(279, 20);
            this.uxFarmMg.Name = "uxFarmMg";
            this.uxFarmMg.Size = new System.Drawing.Size(186, 24);
            this.uxFarmMg.TabIndex = 0;
            this.uxFarmMg.Text = " Farm Management";
            this.uxFarmMg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxLocation
            // 
            this.uxLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxLocation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxLocation.Location = new System.Drawing.Point(29, 177);
            this.uxLocation.Name = "uxLocation";
            this.uxLocation.Size = new System.Drawing.Size(186, 24);
            this.uxLocation.TabIndex = 1;
            this.uxLocation.Text = "Location";
            this.uxLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxFarmID
            // 
            this.uxFarmID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxFarmID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxFarmID.Location = new System.Drawing.Point(29, 114);
            this.uxFarmID.Name = "uxFarmID";
            this.uxFarmID.Size = new System.Drawing.Size(186, 24);
            this.uxFarmID.TabIndex = 2;
            this.uxFarmID.Text = "FarmID";
            this.uxFarmID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxName
            // 
            this.uxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxName.Location = new System.Drawing.Point(29, 232);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(186, 24);
            this.uxName.TabIndex = 3;
            this.uxName.Text = "Name";
            this.uxName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxPNumber
            // 
            this.uxPNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxPNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxPNumber.Location = new System.Drawing.Point(29, 286);
            this.uxPNumber.Name = "uxPNumber";
            this.uxPNumber.Size = new System.Drawing.Size(186, 24);
            this.uxPNumber.TabIndex = 4;
            this.uxPNumber.Text = "Phone Number";
            this.uxPNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uxOwner
            // 
            this.uxOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxOwner.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOwner.Location = new System.Drawing.Point(29, 347);
            this.uxOwner.Name = "uxOwner";
            this.uxOwner.Size = new System.Drawing.Size(186, 24);
            this.uxOwner.TabIndex = 5;
            this.uxOwner.Text = "Owner";
            this.uxOwner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFarmID
            // 
            this.txtFarmID.Location = new System.Drawing.Point(243, 118);
            this.txtFarmID.Multiline = true;
            this.txtFarmID.Name = "txtFarmID";
            this.txtFarmID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFarmID.Size = new System.Drawing.Size(100, 20);
            this.txtFarmID.TabIndex = 6;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(243, 181);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 236);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(243, 290);
            this.txtPNumber.Multiline = true;
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPNumber.TabIndex = 9;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(243, 351);
            this.txtOwner.Multiline = true;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOwner.Size = new System.Drawing.Size(100, 20);
            this.txtOwner.TabIndex = 16;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(43, 419);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btUpdate.Location = new System.Drawing.Point(205, 419);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btDelete.Location = new System.Drawing.Point(357, 419);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btClear.Location = new System.Drawing.Point(504, 419);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btLoad
            // 
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btLoad.Location = new System.Drawing.Point(636, 419);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 15;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // dgvFarm
            // 
            this.dgvFarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarm.Location = new System.Drawing.Point(29, 519);
            this.dgvFarm.Name = "dgvFarm";
            this.dgvFarm.Size = new System.Drawing.Size(712, 135);
            this.dgvFarm.TabIndex = 0;
           
            // 
            // FarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 725);
            this.Controls.Add(this.dgvFarm);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtFarmID);
            this.Controls.Add(this.uxOwner);
            this.Controls.Add(this.uxPNumber);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxFarmID);
            this.Controls.Add(this.uxLocation);
            this.Controls.Add(this.uxFarmMg);
            this.Name = "FarmForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxFarmMg;
        private System.Windows.Forms.Label uxLocation;
        private System.Windows.Forms.Label uxFarmID;
        private System.Windows.Forms.Label uxName;
        private System.Windows.Forms.Label uxPNumber;
        private System.Windows.Forms.Label uxOwner;
        private System.Windows.Forms.TextBox txtFarmID;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.DataGridView dgvFarm;
    }
}

