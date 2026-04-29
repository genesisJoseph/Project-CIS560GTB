namespace FarmForm
{
    partial class ChickenGroupForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvCGroup = new DataGridView();
            btLoad = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            btAdd = new Button();
            txtCGBreedID = new TextBox();
            txtConfinement = new TextBox();
            txtCGroupID = new TextBox();
            txtCFarmID = new TextBox();
            uxChickenBreedID = new Label();
            uxConfinement = new Label();
            uxCFarmID = new Label();
            uxCGroupID = new Label();
            uxCGroupMg = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCGroup).BeginInit();
            SuspendLayout();
            // 
            // dgvCGroup
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCGroup.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCGroup.Location = new Point(99, 409);
            dgvCGroup.Margin = new Padding(5, 6, 5, 6);
            dgvCGroup.Name = "dgvCGroup";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCGroup.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCGroup.RowHeadersWidth = 62;
            dgvCGroup.Size = new Size(524, 384);
            dgvCGroup.TabIndex = 17;
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
            // txtCGBreedID
            // 
            txtCGBreedID.Location = new Point(98, 294);
            txtCGBreedID.Margin = new Padding(5, 6, 5, 6);
            txtCGBreedID.Multiline = true;
            txtCGBreedID.Name = "txtCGBreedID";
            txtCGBreedID.ScrollBars = ScrollBars.Both;
            txtCGBreedID.Size = new Size(150, 31);
            txtCGBreedID.TabIndex = 27;
            // 
            // txtConfinement
            // 
            txtConfinement.Location = new Point(99, 165);
            txtConfinement.Margin = new Padding(5, 6, 5, 6);
            txtConfinement.Multiline = true;
            txtConfinement.Name = "txtConfinement";
            txtConfinement.ScrollBars = ScrollBars.Vertical;
            txtConfinement.Size = new Size(150, 31);
            txtConfinement.TabIndex = 26;
            // 
            // txtCGroupID
            // 
            txtCGroupID.Location = new Point(99, 93);
            txtCGroupID.Margin = new Padding(5, 6, 5, 6);
            txtCGroupID.Multiline = true;
            txtCGroupID.Name = "txtCGroupID";
            txtCGroupID.ScrollBars = ScrollBars.Both;
            txtCGroupID.Size = new Size(150, 31);
            txtCGroupID.TabIndex = 25;
            // 
            // txtCFarmID
            // 
            txtCFarmID.Location = new Point(98, 227);
            txtCFarmID.Margin = new Padding(5, 6, 5, 6);
            txtCFarmID.Multiline = true;
            txtCFarmID.Name = "txtCFarmID";
            txtCFarmID.ScrollBars = ScrollBars.Both;
            txtCFarmID.Size = new Size(150, 31);
            txtCFarmID.TabIndex = 24;
            // 
            // uxChickenBreedID
            // 
            uxChickenBreedID.AutoSize = true;
            uxChickenBreedID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxChickenBreedID.Location = new Point(98, 266);
            uxChickenBreedID.Margin = new Padding(5, 0, 5, 0);
            uxChickenBreedID.Name = "uxChickenBreedID";
            uxChickenBreedID.Size = new Size(148, 25);
            uxChickenBreedID.TabIndex = 22;
            uxChickenBreedID.Text = "ChickenBreedID";
            uxChickenBreedID.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxConfinement
            // 
            uxConfinement.AutoSize = true;
            uxConfinement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxConfinement.Location = new Point(99, 137);
            uxConfinement.Margin = new Padding(5, 0, 5, 0);
            uxConfinement.Name = "uxConfinement";
            uxConfinement.Size = new Size(122, 25);
            uxConfinement.TabIndex = 21;
            uxConfinement.Text = "Confinement";
            uxConfinement.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxCFarmID
            // 
            uxCFarmID.AutoSize = true;
            uxCFarmID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxCFarmID.Location = new Point(99, 199);
            uxCFarmID.Margin = new Padding(5, 0, 5, 0);
            uxCFarmID.Name = "uxCFarmID";
            uxCFarmID.Size = new Size(72, 25);
            uxCFarmID.TabIndex = 20;
            uxCFarmID.Text = "FarmID";
            uxCFarmID.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxCGroupID
            // 
            uxCGroupID.AutoSize = true;
            uxCGroupID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            uxCGroupID.Location = new Point(99, 65);
            uxCGroupID.Margin = new Padding(5, 0, 5, 0);
            uxCGroupID.Name = "uxCGroupID";
            uxCGroupID.Size = new Size(151, 25);
            uxCGroupID.TabIndex = 19;
            uxCGroupID.Text = "ChickenGroupID";
            uxCGroupID.TextAlign = ContentAlignment.TopCenter;
            // 
            // uxCGroupMg
            // 
            uxCGroupMg.AutoSize = true;
            uxCGroupMg.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            uxCGroupMg.Location = new Point(14, 9);
            uxCGroupMg.Margin = new Padding(5, 0, 5, 0);
            uxCGroupMg.Name = "uxCGroupMg";
            uxCGroupMg.Size = new Size(150, 28);
            uxCGroupMg.TabIndex = 18;
            uxCGroupMg.Text = "Chicken Group";
            uxCGroupMg.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChickenGroupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 805);
            Controls.Add(dgvCGroup);
            Controls.Add(btLoad);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(txtCGBreedID);
            Controls.Add(txtConfinement);
            Controls.Add(txtCGroupID);
            Controls.Add(txtCFarmID);
            Controls.Add(uxChickenBreedID);
            Controls.Add(uxConfinement);
            Controls.Add(uxCFarmID);
            Controls.Add(uxCGroupID);
            Controls.Add(uxCGroupMg);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ChickenGroupForm";
            Text = "ChickenGroupForm";
            ((System.ComponentModel.ISupportInitialize)dgvCGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCGroup;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtCGBreedID;
        private System.Windows.Forms.TextBox txtConfinement;
        private System.Windows.Forms.TextBox txtCGroupID;
        private System.Windows.Forms.TextBox txtCFarmID;
        private System.Windows.Forms.Label uxChickenBreedID;
        private System.Windows.Forms.Label uxConfinement;
        private System.Windows.Forms.Label uxCFarmID;
        private System.Windows.Forms.Label uxCGroupID;
        private System.Windows.Forms.Label uxCGroupMg;
    }
}