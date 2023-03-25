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
            buttonReactivate = new Button();
            buttonClearFilter = new Button();
            buttonDeactivateEmployee = new Button();
            buttonReviewEmployee = new Button();
            buttonAddEmployee = new Button();
            buttonFilterEmployee = new Button();
            comboBoxRole = new ComboBox();
            checkBoxIsActive = new CheckBox();
            labelFilter = new Label();
            dataGridViewEmployees = new DataGridView();
            buttonSpecializations = new Button();
            buttonEditEmployee = new Button();
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonReactivate
            // 
            buttonReactivate.BackColor = Color.SteelBlue;
            buttonReactivate.Location = new Point(31, 840);
            buttonReactivate.Margin = new Padding(3, 4, 3, 4);
            buttonReactivate.Name = "buttonReactivate";
            buttonReactivate.Size = new Size(160, 60);
            buttonReactivate.TabIndex = 19;
            buttonReactivate.Text = "Reactivate employee";
            buttonReactivate.UseVisualStyleBackColor = false;
            buttonReactivate.Click += buttonReactivate_Click;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(482, 1311);
            buttonClearFilter.Margin = new Padding(3, 4, 3, 4);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(138, 31);
            buttonClearFilter.TabIndex = 18;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // buttonDeactivateEmployee
            // 
            buttonDeactivateEmployee.BackColor = Color.SteelBlue;
            buttonDeactivateEmployee.Location = new Point(31, 728);
            buttonDeactivateEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            buttonDeactivateEmployee.Size = new Size(290, 76);
            buttonDeactivateEmployee.TabIndex = 17;
            buttonDeactivateEmployee.Text = "Deactivate employee";
            buttonDeactivateEmployee.UseVisualStyleBackColor = false;
            buttonDeactivateEmployee.Click += buttonDeactivateEmployee_Click;
            // 
            // buttonReviewEmployee
            // 
            buttonReviewEmployee.BackColor = Color.SteelBlue;
            buttonReviewEmployee.Location = new Point(31, 623);
            buttonReviewEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonReviewEmployee.Name = "buttonReviewEmployee";
            buttonReviewEmployee.Size = new Size(290, 76);
            buttonReviewEmployee.TabIndex = 16;
            buttonReviewEmployee.Text = "Review employee";
            buttonReviewEmployee.UseVisualStyleBackColor = false;
            buttonReviewEmployee.Click += buttonReviewEmployee_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.BackColor = Color.SteelBlue;
            buttonAddEmployee.FlatAppearance.BorderColor = Color.Black;
            buttonAddEmployee.FlatStyle = FlatStyle.Flat;
            buttonAddEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddEmployee.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddEmployee.Location = new Point(-8, 339);
            buttonAddEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(365, 116);
            buttonAddEmployee.TabIndex = 15;
            buttonAddEmployee.Text = "Add new employee";
            buttonAddEmployee.UseVisualStyleBackColor = false;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonFilterEmployee
            // 
            buttonFilterEmployee.Location = new Point(482, 1277);
            buttonFilterEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonFilterEmployee.Name = "buttonFilterEmployee";
            buttonFilterEmployee.Size = new Size(138, 31);
            buttonFilterEmployee.TabIndex = 14;
            buttonFilterEmployee.Text = "Filtruj";
            buttonFilterEmployee.UseVisualStyleBackColor = true;
            buttonFilterEmployee.Click += buttonFilterEmployee_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Medical Doctor", "Nurse", "Paramedic", "Janitor", "Technitian" });
            comboBoxRole.Location = new Point(482, 1239);
            comboBoxRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(138, 28);
            comboBoxRole.TabIndex = 13;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.Location = new Point(482, 1205);
            checkBoxIsActive.Margin = new Padding(3, 4, 3, 4);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(154, 24);
            checkBoxIsActive.TabIndex = 12;
            checkBoxIsActive.Text = "Is Employee active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(482, 1181);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(65, 20);
            labelFilter.TabIndex = 11;
            labelFilter.Text = "Filter list";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(642, 87);
            dataGridViewEmployees.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowTemplate.Height = 25;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(1231, 907);
            dataGridViewEmployees.TabIndex = 10;
            dataGridViewEmployees.RowHeaderMouseClick += dataGridViewEmployees_RowHeaderMouseClick;
            // 
            // buttonSpecializations
            // 
            buttonSpecializations.BackColor = Color.SteelBlue;
            buttonSpecializations.Location = new Point(31, 931);
            buttonSpecializations.Margin = new Padding(3, 4, 3, 4);
            buttonSpecializations.Name = "buttonSpecializations";
            buttonSpecializations.Size = new Size(162, 60);
            buttonSpecializations.TabIndex = 20;
            buttonSpecializations.Text = "Edit Specializations";
            buttonSpecializations.UseVisualStyleBackColor = false;
            buttonSpecializations.Click += buttonSpecializations_Click;
            // 
            // buttonEditEmployee
            // 
            buttonEditEmployee.BackColor = Color.SteelBlue;
            buttonEditEmployee.FlatAppearance.BorderColor = Color.Black;
            buttonEditEmployee.FlatStyle = FlatStyle.Flat;
            buttonEditEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditEmployee.Location = new Point(-8, 463);
            buttonEditEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonEditEmployee.Name = "buttonEditEmployee";
            buttonEditEmployee.Size = new Size(376, 116);
            buttonEditEmployee.TabIndex = 21;
            buttonEditEmployee.Text = "Edit Employee";
            buttonEditEmployee.UseVisualStyleBackColor = false;
            buttonEditEmployee.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonSpecializations);
            panel1.Controls.Add(buttonEditEmployee);
            panel1.Controls.Add(buttonReactivate);
            panel1.Controls.Add(buttonAddEmployee);
            panel1.Controls.Add(buttonReviewEmployee);
            panel1.Controls.Add(buttonDeactivateEmployee);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 1441);
            panel1.TabIndex = 22;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(33, 1293);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(288, 88);
            buttonBack.TabIndex = 22;
            buttonBack.Text = "LOG OUT";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(70, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 224);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(31, 1015);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 60);
            button1.TabIndex = 23;
            button1.Text = "Patient";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // FormEmployeeList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1942, 1102);
            Controls.Add(panel1);
            Controls.Add(buttonClearFilter);
            Controls.Add(buttonFilterEmployee);
            Controls.Add(comboBoxRole);
            Controls.Add(checkBoxIsActive);
            Controls.Add(labelFilter);
            Controls.Add(dataGridViewEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployeeList";
            WindowState = FormWindowState.Maximized;
            Load += FormEmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private Button button1;
    }
}