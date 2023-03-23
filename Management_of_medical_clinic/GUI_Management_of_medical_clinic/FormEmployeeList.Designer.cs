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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonSpecializations = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReactivate
            // 
            this.buttonReactivate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReactivate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReactivate.Location = new System.Drawing.Point(-7, 630);
            this.buttonReactivate.Name = "buttonReactivate";
            this.buttonReactivate.Size = new System.Drawing.Size(329, 87);
            this.buttonReactivate.TabIndex = 19;
            this.buttonReactivate.Text = "Reactivate employee";
            this.buttonReactivate.UseVisualStyleBackColor = false;
            this.buttonReactivate.Click += new System.EventHandler(this.buttonReactivate_Click);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearFilter.Location = new System.Drawing.Point(610, 200);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(329, 87);
            this.buttonClearFilter.TabIndex = 18;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonDeactivateEmployee
            // 
            this.buttonDeactivateEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDeactivateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeactivateEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeactivateEmployee.Location = new System.Drawing.Point(-7, 537);
            this.buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            this.buttonDeactivateEmployee.Size = new System.Drawing.Size(329, 87);
            this.buttonDeactivateEmployee.TabIndex = 17;
            this.buttonDeactivateEmployee.Text = "Deactivate employee";
            this.buttonDeactivateEmployee.UseVisualStyleBackColor = false;
            this.buttonDeactivateEmployee.Click += new System.EventHandler(this.buttonDeactivateEmployee_Click);
            // 
            // buttonReviewEmployee
            // 
            this.buttonReviewEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReviewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReviewEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReviewEmployee.Location = new System.Drawing.Point(-7, 440);
            this.buttonReviewEmployee.Name = "buttonReviewEmployee";
            this.buttonReviewEmployee.Size = new System.Drawing.Size(329, 87);
            this.buttonReviewEmployee.TabIndex = 16;
            this.buttonReviewEmployee.Text = "Review employee";
            this.buttonReviewEmployee.UseVisualStyleBackColor = false;
            this.buttonReviewEmployee.Click += new System.EventHandler(this.buttonReviewEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddEmployee.Location = new System.Drawing.Point(-7, 254);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(319, 87);
            this.buttonAddEmployee.TabIndex = 15;
            this.buttonAddEmployee.Text = "Add new employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonFilterEmployee
            // 
            this.buttonFilterEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFilterEmployee.Location = new System.Drawing.Point(124, 200);
            this.buttonFilterEmployee.Name = "buttonFilterEmployee";
            this.buttonFilterEmployee.Size = new System.Drawing.Size(329, 87);
            this.buttonFilterEmployee.TabIndex = 14;
            this.buttonFilterEmployee.Text = "Filtruj";
            this.buttonFilterEmployee.UseVisualStyleBackColor = true;
            this.buttonFilterEmployee.Click += new System.EventHandler(this.buttonFilterEmployee_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRole.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Medical Doctor",
            "Nurse",
            "Paramedic",
            "Janitor",
            "Technitian"});
            this.comboBoxRole.Location = new System.Drawing.Point(636, 17);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(271, 36);
            this.comboBoxRole.TabIndex = 13;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBoxIsActive.FlatAppearance.BorderSize = 4;
            this.checkBoxIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIsActive.Location = new System.Drawing.Point(146, 17);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(271, 41);
            this.checkBoxIsActive.TabIndex = 12;
            this.checkBoxIsActive.Text = "Is Employee active";
            this.checkBoxIsActive.UseVisualStyleBackColor = false;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(562, 65);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            this.dataGridViewEmployees.RowTemplate.Height = 25;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1077, 680);
            this.dataGridViewEmployees.TabIndex = 10;
            this.dataGridViewEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployees_RowHeaderMouseClick);
            // 
            // buttonSpecializations
            // 
            this.buttonSpecializations.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSpecializations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpecializations.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSpecializations.Location = new System.Drawing.Point(-7, 734);
            this.buttonSpecializations.Name = "buttonSpecializations";
            this.buttonSpecializations.Size = new System.Drawing.Size(329, 87);
            this.buttonSpecializations.TabIndex = 20;
            this.buttonSpecializations.Text = "Edit Specializations";
            this.buttonSpecializations.UseVisualStyleBackColor = false;
            this.buttonSpecializations.Click += new System.EventHandler(this.buttonSpecializations_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditEmployee.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditEmployee.Location = new System.Drawing.Point(-7, 347);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(329, 87);
            this.buttonEditEmployee.TabIndex = 21;
            this.buttonEditEmployee.Text = "Edit Employee";
            this.buttonEditEmployee.UseVisualStyleBackColor = false;
            this.buttonEditEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonSpecializations);
            this.panel1.Controls.Add(this.buttonEditEmployee);
            this.panel1.Controls.Add(this.buttonReactivate);
            this.panel1.Controls.Add(this.buttonAddEmployee);
            this.panel1.Controls.Add(this.buttonReviewEmployee);
            this.panel1.Controls.Add(this.buttonDeactivateEmployee);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 1081);
            this.panel1.TabIndex = 22;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(29, 970);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(252, 66);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "LOG OUT";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.checkBoxIsActive);
            this.panel2.Controls.Add(this.buttonClearFilter);
            this.panel2.Controls.Add(this.comboBoxRole);
            this.panel2.Controls.Add(this.buttonFilterEmployee);
            this.panel2.Location = new System.Drawing.Point(562, 762);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 306);
            this.panel2.TabIndex = 23;
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEmployees);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private DataGridView dataGridViewEmployees;
        private Button buttonSpecializations;
        private Button buttonEditEmployee;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private Panel panel2;
    }
}