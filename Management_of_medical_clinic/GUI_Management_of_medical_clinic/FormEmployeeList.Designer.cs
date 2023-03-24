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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReactivate
            // 
            this.buttonReactivate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReactivate.Location = new System.Drawing.Point(27, 630);
            this.buttonReactivate.Name = "buttonReactivate";
            this.buttonReactivate.Size = new System.Drawing.Size(140, 45);
            this.buttonReactivate.TabIndex = 19;
            this.buttonReactivate.Text = "Reactivate employee";
            this.buttonReactivate.UseVisualStyleBackColor = false;
            this.buttonReactivate.Click += new System.EventHandler(this.buttonReactivate_Click);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(422, 983);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(121, 23);
            this.buttonClearFilter.TabIndex = 18;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonDeactivateEmployee
            // 
            this.buttonDeactivateEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDeactivateEmployee.Location = new System.Drawing.Point(27, 546);
            this.buttonDeactivateEmployee.Name = "buttonDeactivateEmployee";
            this.buttonDeactivateEmployee.Size = new System.Drawing.Size(254, 57);
            this.buttonDeactivateEmployee.TabIndex = 17;
            this.buttonDeactivateEmployee.Text = "Deactivate employee";
            this.buttonDeactivateEmployee.UseVisualStyleBackColor = false;
            this.buttonDeactivateEmployee.Click += new System.EventHandler(this.buttonDeactivateEmployee_Click);
            // 
            // buttonReviewEmployee
            // 
            this.buttonReviewEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReviewEmployee.Location = new System.Drawing.Point(27, 467);
            this.buttonReviewEmployee.Name = "buttonReviewEmployee";
            this.buttonReviewEmployee.Size = new System.Drawing.Size(254, 57);
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
            this.buttonFilterEmployee.Location = new System.Drawing.Point(422, 958);
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
            this.comboBoxRole.Location = new System.Drawing.Point(422, 929);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRole.TabIndex = 13;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Location = new System.Drawing.Point(422, 904);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(123, 19);
            this.checkBoxIsActive.TabIndex = 12;
            this.checkBoxIsActive.Text = "Is Employee active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(422, 886);
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
            this.dataGridViewEmployees.Location = new System.Drawing.Point(562, 65);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowTemplate.Height = 25;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1077, 680);
            this.dataGridViewEmployees.TabIndex = 10;
            this.dataGridViewEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployees_RowHeaderMouseClick);
            // 
            // buttonSpecializations
            // 
            this.buttonSpecializations.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSpecializations.Location = new System.Drawing.Point(27, 698);
            this.buttonSpecializations.Name = "buttonSpecializations";
            this.buttonSpecializations.Size = new System.Drawing.Size(142, 45);
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
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonFilterEmployee);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dataGridViewEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonBack;
    }
}