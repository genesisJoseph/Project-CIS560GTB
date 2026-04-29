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
            uxFarmMg = new Label();
            uxLocation = new Label();
            uxFarmID = new Label();
            uxName = new Label();
            uxPNumber = new Label();
            uxOwner = new Label();
            txtFarmID = new TextBox();
            txtLocation = new TextBox();
            txtName = new TextBox();
            txtPNumber = new TextBox();
            txtOwner = new TextBox();
            btAdd = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            btLoad = new Button();
            dgvFarm = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFarm).BeginInit();
            SuspendLayout();
            // 
            // uxFarmMg
            // 
            uxFarmMg.AutoSize = true;
            uxFarmMg.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            uxFarmMg.Location = new Point(14, 9);
            uxFarmMg.Margin = new Padding(6, 0, 6, 0);
            uxFarmMg.Name = "uxFarmMg";
            uxFarmMg.Size = new Size(64, 28);
            uxFarmMg.TabIndex = 0;
            uxFarmMg.Text = " Farm";
            uxFarmMg.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxLocation
            // 
            uxLocation.AutoSize = true;
            uxLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxLocation.Location = new Point(99, 137);
            uxLocation.Margin = new Padding(6, 0, 6, 0);
            uxLocation.Name = "uxLocation";
            uxLocation.Size = new Size(85, 25);
            uxLocation.TabIndex = 1;
            uxLocation.Text = "Location";
            uxLocation.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxFarmID
            // 
            uxFarmID.AutoSize = true;
            uxFarmID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxFarmID.Location = new Point(99, 65);
            uxFarmID.Margin = new Padding(6, 0, 6, 0);
            uxFarmID.Name = "uxFarmID";
            uxFarmID.Size = new Size(72, 25);
            uxFarmID.TabIndex = 2;
            uxFarmID.Text = "FarmID";
            uxFarmID.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxName
            // 
            uxName.AutoSize = true;
            uxName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxName.Location = new Point(99, 199);
            uxName.Margin = new Padding(6, 0, 6, 0);
            uxName.Name = "uxName";
            uxName.Size = new Size(62, 25);
            uxName.TabIndex = 3;
            uxName.Text = "Name";
            uxName.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxPNumber
            // 
            uxPNumber.AutoSize = true;
            uxPNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxPNumber.Location = new Point(98, 266);
            uxPNumber.Margin = new Padding(6, 0, 6, 0);
            uxPNumber.Name = "uxPNumber";
            uxPNumber.Size = new Size(140, 25);
            uxPNumber.TabIndex = 4;
            uxPNumber.Text = "Phone Number";
            uxPNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxOwner
            // 
            uxOwner.AutoSize = true;
            uxOwner.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxOwner.Location = new Point(98, 328);
            uxOwner.Margin = new Padding(6, 0, 6, 0);
            uxOwner.Name = "uxOwner";
            uxOwner.Size = new Size(68, 25);
            uxOwner.TabIndex = 5;
            uxOwner.Text = "Owner";
            uxOwner.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFarmID
            // 
            txtFarmID.Location = new Point(99, 93);
            txtFarmID.Margin = new Padding(6);
            txtFarmID.Multiline = true;
            txtFarmID.Name = "txtFarmID";
            txtFarmID.ScrollBars = ScrollBars.Both;
            txtFarmID.Size = new Size(150, 31);
            txtFarmID.TabIndex = 6;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(99, 165);
            txtLocation.Margin = new Padding(6);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.ScrollBars = ScrollBars.Both;
            txtLocation.Size = new Size(150, 31);
            txtLocation.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 227);
            txtName.Margin = new Padding(6);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ScrollBars = ScrollBars.Vertical;
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 8;
            // 
            // txtPNumber
            // 
            txtPNumber.Location = new Point(98, 294);
            txtPNumber.Margin = new Padding(6);
            txtPNumber.Multiline = true;
            txtPNumber.Name = "txtPNumber";
            txtPNumber.ScrollBars = ScrollBars.Both;
            txtPNumber.Size = new Size(150, 31);
            txtPNumber.TabIndex = 9;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(99, 372);
            txtOwner.Margin = new Padding(6);
            txtOwner.Multiline = true;
            txtOwner.Name = "txtOwner";
            txtOwner.ScrollBars = ScrollBars.Both;
            txtOwner.Size = new Size(150, 31);
            txtOwner.TabIndex = 16;
            // 
            // btAdd
            // 
            btAdd.Font = new Font("Segoe UI", 9F);
            btAdd.Location = new Point(354, 141);
            btAdd.Margin = new Padding(6);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(112, 34);
            btAdd.TabIndex = 11;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 9F);
            btUpdate.Location = new Point(354, 199);
            btUpdate.Margin = new Padding(6);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(112, 34);
            btUpdate.TabIndex = 12;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Segoe UI", 9F);
            btDelete.Location = new Point(524, 199);
            btDelete.Margin = new Padding(6);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 34);
            btDelete.TabIndex = 13;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btLoad
            // 
            btLoad.Font = new Font("Segoe UI", 9F);
            btLoad.Location = new Point(524, 141);
            btLoad.Margin = new Padding(6);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(112, 34);
            btLoad.TabIndex = 15;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // dgvFarm
            // 
            dgvFarm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFarm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFarm.Location = new Point(99, 409);
            dgvFarm.Name = "dgvFarm";
            dgvFarm.RowHeadersVisible = false;
            dgvFarm.RowHeadersWidth = 62;
            dgvFarm.Size = new Size(524, 384);
            dgvFarm.TabIndex = 17;
            // 
            // FarmForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(704, 805);
            Controls.Add(dgvFarm);
            Controls.Add(btLoad);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(txtOwner);
            Controls.Add(txtPNumber);
            Controls.Add(txtName);
            Controls.Add(txtLocation);
            Controls.Add(txtFarmID);
            Controls.Add(uxOwner);
            Controls.Add(uxPNumber);
            Controls.Add(uxName);
            Controls.Add(uxFarmID);
            Controls.Add(uxLocation);
            Controls.Add(uxFarmMg);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(6);
            Name = "FarmForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvFarm).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button btLoad;
        private DataGridView dgvFarm;
    }
}

