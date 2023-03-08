namespace GUI_Management_of_medical_clinic
{
    partial class EmployeeList
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonFilterEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonReviewEmployee = new System.Windows.Forms.Button();
            this.buttonDeactivateEmployee = new System.Windows.Forms.Button();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonReactivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowTemplate.Height = 25;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(776, 273);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            this.dataGridViewEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployees_RowHeaderMouseClick);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 298);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(51, 15);
            this.labelFilter.TabIndex = 1;
            this.labelFilter.Text = "Filter list";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(12, 316);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(123, 19);
            this.checkBoxIsActive.TabIndex = 2;
            this.checkBoxIsActive.Text = "Is Employee active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(12, 341);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRole.TabIndex = 3;
            // 
            // buttonFilterEmployee
            // 
            this.buttonFilterEmployee.Location = new System.Drawing.Point(12, 370);
            this.buttonFilterEmployee.Name = "buttonFilterEmployee";
            this.buttonFilterEmployee.Size = new System.Drawing.Size(121, 23);
            this.buttonFilterEmployee.TabIndex = 4;
            this.buttonFilterEmployee.Text = "Filtruj";
            this.buttonFilterEmployee.UseVisualStyleBackColor = true;
            this.buttonFilterEmployee.Click += new System.EventHandler(this.buttonFilterEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(380, 302);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(142, 45);
            this.buttonAddEmployee.TabIndex = 5;
            this.buttonAddEmployee.Text = "Add new employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonReviewEmployee
            // 
            this.buttonReviewEmployee.Location = new System.Drawing.Point(528, 302);
            this.buttonReviewEmployee.Name = "buttonReviewEmployee";
            this.buttonReviewEmployee.Size = new System.Drawing.Size(114, 45);
            this.buttonReviewEmployee.TabIndex = 6;
            this.buttonReviewEmployee.Text = "Review employee";
            this.buttonReviewEmployee.UseVisualStyleBackColor = true;
            this.buttonReviewEmployee.Click += new System.EventHandler(this.buttonReviewEmployee_Click);
            // 
            // buttonDeactivateEmployee
            // 
            this.buttonDeactivateEmployee.Location = new System.Drawing.Point(648, 302);
            this.buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            this.buttonDeactivateEmployee.Size = new System.Drawing.Size(140, 45);
            this.buttonDeactivateEmployee.TabIndex = 7;
            this.buttonDeactivateEmployee.Text = "Deactivate employee";
            this.buttonDeactivateEmployee.UseVisualStyleBackColor = true;
            this.buttonDeactivateEmployee.Click += new System.EventHandler(this.buttonDeactivateEmployee_Click);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(12, 395);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(121, 23);
            this.buttonClearFilter.TabIndex = 8;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonReactivate
            // 
            this.buttonReactivate.Location = new System.Drawing.Point(648, 353);
            this.buttonReactivate.Name = "buttonReactivate";
            this.buttonReactivate.Size = new System.Drawing.Size(140, 45);
            this.buttonReactivate.TabIndex = 9;
            this.buttonReactivate.Text = "Reactivate employee";
            this.buttonReactivate.UseVisualStyleBackColor = true;
            this.buttonReactivate.Click += new System.EventHandler(this.buttonReactivate_Click);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Label labelFilter;
        private CheckBox checkBoxIsActive;
        private ComboBox comboBoxRole;
        private Button buttonFilterEmployee;
        private Button buttonAddEmployee;
        private Button buttonReviewEmployee;
        private Button buttonDeactivateEmployee;
        private Button buttonClearFilter;
        private Button buttonReactivate;
    }
}