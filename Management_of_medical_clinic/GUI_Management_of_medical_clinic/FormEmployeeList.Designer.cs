namespace GUI_Management_of_medical_clinic
{
    partial class FormEmployeeList
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
            this.buttonReactivate = new System.Windows.Forms.Button();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonDeactivateEmployee = new System.Windows.Forms.Button();
            this.buttonReviewEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonFilterEmployee = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonSpecializations = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReactivate
            // 
            this.buttonReactivate.Location = new System.Drawing.Point(648, 380);
            this.buttonReactivate.Name = "buttonReactivate";
            this.buttonReactivate.Size = new System.Drawing.Size(140, 45);
            this.buttonReactivate.TabIndex = 19;
            this.buttonReactivate.Text = "Reactivate employee";
            this.buttonReactivate.UseVisualStyleBackColor = true;
            this.buttonReactivate.Click += new System.EventHandler(this.buttonReactivate_Click);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(12, 405);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(121, 23);
            this.buttonClearFilter.TabIndex = 18;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonDeactivateEmployee
            // 
            this.buttonDeactivateEmployee.Location = new System.Drawing.Point(648, 329);
            this.buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            this.buttonDeactivateEmployee.Size = new System.Drawing.Size(140, 45);
            this.buttonDeactivateEmployee.TabIndex = 17;
            this.buttonDeactivateEmployee.Text = "Deactivate employee";
            this.buttonDeactivateEmployee.UseVisualStyleBackColor = true;
            this.buttonDeactivateEmployee.Click += new System.EventHandler(this.buttonDeactivateEmployee_Click);
            // 
            // buttonReviewEmployee
            // 
            this.buttonReviewEmployee.Location = new System.Drawing.Point(399, 329);
            this.buttonReviewEmployee.Name = "buttonReviewEmployee";
            this.buttonReviewEmployee.Size = new System.Drawing.Size(145, 45);
            this.buttonReviewEmployee.TabIndex = 16;
            this.buttonReviewEmployee.Text = "Review employee";
            this.buttonReviewEmployee.UseVisualStyleBackColor = true;
            this.buttonReviewEmployee.Click += new System.EventHandler(this.buttonReviewEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(251, 329);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(142, 45);
            this.buttonAddEmployee.TabIndex = 15;
            this.buttonAddEmployee.Text = "Add new employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonFilterEmployee
            // 
            this.buttonFilterEmployee.Location = new System.Drawing.Point(12, 380);
            this.buttonFilterEmployee.Name = "buttonFilterEmployee";
            this.buttonFilterEmployee.Size = new System.Drawing.Size(121, 23);
            this.buttonFilterEmployee.TabIndex = 14;
            this.buttonFilterEmployee.Text = "Filtruj";
            this.buttonFilterEmployee.UseVisualStyleBackColor = true;
            this.buttonFilterEmployee.Click += new System.EventHandler(this.buttonFilterEmployee_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Medical Doctor",
            "Nurse",
            "Paramedic",
            "Janitor",
            "Technitian"});
            this.comboBoxRole.Location = new System.Drawing.Point(12, 351);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRole.TabIndex = 13;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Location = new System.Drawing.Point(12, 326);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(123, 19);
            this.checkBoxIsActive.TabIndex = 12;
            this.checkBoxIsActive.Text = "Is Employee active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 308);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(51, 15);
            this.labelFilter.TabIndex = 11;
            this.labelFilter.Text = "Filter list";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowTemplate.Height = 25;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(776, 273);
            this.dataGridViewEmployees.TabIndex = 10;
            this.dataGridViewEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployees_RowHeaderMouseClick);
            // 
            // buttonSpecializations
            // 
            this.buttonSpecializations.Location = new System.Drawing.Point(251, 380);
            this.buttonSpecializations.Name = "buttonSpecializations";
            this.buttonSpecializations.Size = new System.Drawing.Size(142, 45);
            this.buttonSpecializations.TabIndex = 20;
            this.buttonSpecializations.Text = "Edit Specializations";
            this.buttonSpecializations.UseVisualStyleBackColor = true;
            this.buttonSpecializations.Click += new System.EventHandler(this.buttonSpecializations_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Location = new System.Drawing.Point(402, 380);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(142, 45);
            this.buttonEditEmployee.TabIndex = 21;
            this.buttonEditEmployee.Text = "Edit Employee";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonSpecializations);
            this.Controls.Add(this.buttonReactivate);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonDeactivateEmployee);
            this.Controls.Add(this.buttonReviewEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonFilterEmployee);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "FormEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeList";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonReactivate;
        private Button buttonClearFilter;
        private Button buttonDeactivateEmployee;
        private Button buttonReviewEmployee;
        private Button buttonAddEmployee;
        private Button buttonFilterEmployee;
        private ComboBox comboBoxRole;
        private CheckBox checkBoxIsActive;
        private Label labelFilter;
        private DataGridView dataGridViewEmployees;
        private Button buttonSpecializations;
        private Button buttonEditEmployee;
    }
}