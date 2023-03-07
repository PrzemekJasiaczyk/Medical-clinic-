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
            dataGridViewEmployees = new DataGridView();
            labelFilter = new Label();
            checkBoxIsActive = new CheckBox();
            comboBoxRole = new ComboBox();
            buttonFilterEmployee = new Button();
            buttonAddEmployee = new Button();
            buttonReviewEmployee = new Button();
            buttonDeactivateEmployee = new Button();
            buttonClearFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 12);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowTemplate.Height = 25;
            dataGridViewEmployees.Size = new Size(776, 283);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(12, 298);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(51, 15);
            labelFilter.TabIndex = 1;
            labelFilter.Text = "Filter list";
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Location = new Point(12, 316);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(123, 19);
            checkBoxIsActive.TabIndex = 2;
            checkBoxIsActive.Text = "Is Employee active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(12, 341);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 23);
            comboBoxRole.TabIndex = 3;
            // 
            // buttonFilterEmployee
            // 
            buttonFilterEmployee.Location = new Point(12, 370);
            buttonFilterEmployee.Name = "buttonFilterEmployee";
            buttonFilterEmployee.Size = new Size(121, 23);
            buttonFilterEmployee.TabIndex = 4;
            buttonFilterEmployee.Text = "Filtruj";
            buttonFilterEmployee.UseVisualStyleBackColor = true;
            buttonFilterEmployee.Click += buttonFilterEmployee_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(380, 302);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(142, 45);
            buttonAddEmployee.TabIndex = 5;
            buttonAddEmployee.Text = "Add new employee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonReviewEmployee
            // 
            buttonReviewEmployee.Location = new Point(528, 302);
            buttonReviewEmployee.Name = "buttonReviewEmployee";
            buttonReviewEmployee.Size = new Size(114, 45);
            buttonReviewEmployee.TabIndex = 6;
            buttonReviewEmployee.Text = "Review employee";
            buttonReviewEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonDeactivateEmployee
            // 
            buttonDeactivateEmployee.Location = new Point(648, 302);
            buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            buttonDeactivateEmployee.Size = new Size(140, 45);
            buttonDeactivateEmployee.TabIndex = 7;
            buttonDeactivateEmployee.Text = "Deactivate employee";
            buttonDeactivateEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(12, 395);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(121, 23);
            buttonClearFilter.TabIndex = 8;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClearFilter);
            Controls.Add(buttonDeactivateEmployee);
            Controls.Add(buttonReviewEmployee);
            Controls.Add(buttonAddEmployee);
            Controls.Add(buttonFilterEmployee);
            Controls.Add(comboBoxRole);
            Controls.Add(checkBoxIsActive);
            Controls.Add(labelFilter);
            Controls.Add(dataGridViewEmployees);
            Name = "EmployeeList";
            Text = "EmployeeList";
            Load += EmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}