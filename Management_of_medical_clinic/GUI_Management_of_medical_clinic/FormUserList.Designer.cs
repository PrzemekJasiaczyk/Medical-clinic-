namespace GUI_Management_of_medical_clinic
{
    partial class FormUserList
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
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonSpecializations = new System.Windows.Forms.Button();
            this.buttonReactivateUser = new System.Windows.Forms.Button();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonDeactivateUser = new System.Windows.Forms.Button();
            this.buttonReviewUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonFilterUser = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(402, 380);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(142, 45);
            this.buttonEditUser.TabIndex = 33;
            this.buttonEditUser.Text = "Edit user";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // buttonSpecializations
            // 
            this.buttonSpecializations.Location = new System.Drawing.Point(251, 380);
            this.buttonSpecializations.Name = "buttonSpecializations";
            this.buttonSpecializations.Size = new System.Drawing.Size(142, 45);
            this.buttonSpecializations.TabIndex = 32;
            this.buttonSpecializations.Text = "Edit Specializations";
            this.buttonSpecializations.UseVisualStyleBackColor = true;
            // 
            // buttonReactivateUser
            // 
            this.buttonReactivateUser.Location = new System.Drawing.Point(648, 380);
            this.buttonReactivateUser.Name = "buttonReactivateUser";
            this.buttonReactivateUser.Size = new System.Drawing.Size(140, 45);
            this.buttonReactivateUser.TabIndex = 31;
            this.buttonReactivateUser.Text = "Reactivate user";
            this.buttonReactivateUser.UseVisualStyleBackColor = true;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(8, 390);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(100, 24);
            this.buttonClearFilter.TabIndex = 30;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonDeactivateUser
            // 
            this.buttonDeactivateUser.Location = new System.Drawing.Point(648, 329);
            this.buttonDeactivateUser.Name = "buttonDeactivateUser";
            this.buttonDeactivateUser.Size = new System.Drawing.Size(140, 45);
            this.buttonDeactivateUser.TabIndex = 29;
            this.buttonDeactivateUser.Text = "Deactivate user";
            this.buttonDeactivateUser.UseVisualStyleBackColor = true;
            // 
            // buttonReviewUser
            // 
            this.buttonReviewUser.Location = new System.Drawing.Point(399, 329);
            this.buttonReviewUser.Name = "buttonReviewUser";
            this.buttonReviewUser.Size = new System.Drawing.Size(145, 45);
            this.buttonReviewUser.TabIndex = 28;
            this.buttonReviewUser.Text = "Review user";
            this.buttonReviewUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(251, 329);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(142, 45);
            this.buttonAddUser.TabIndex = 27;
            this.buttonAddUser.Text = "Add new user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonFilterUser
            // 
            this.buttonFilterUser.Location = new System.Drawing.Point(118, 390);
            this.buttonFilterUser.Name = "buttonFilterUser";
            this.buttonFilterUser.Size = new System.Drawing.Size(100, 24);
            this.buttonFilterUser.TabIndex = 26;
            this.buttonFilterUser.Text = "Filtr";
            this.buttonFilterUser.UseVisualStyleBackColor = true;
            this.buttonFilterUser.Click += new System.EventHandler(this.buttonFilterUser_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.comboBoxRole.Location = new System.Drawing.Point(8, 361);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 23);
            this.comboBoxRole.TabIndex = 25;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 308);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(51, 15);
            this.labelFilter.TabIndex = 23;
            this.labelFilter.Text = "Filter list";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowTemplate.Height = 25;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(776, 273);
            this.dataGridViewUsers.TabIndex = 22;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(118, 361);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "Username";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 23);
            this.textBoxUsername.TabIndex = 34;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(118, 332);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.PlaceholderText = "Last name";
            this.textBoxLastname.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastname.TabIndex = 35;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(8, 332);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.PlaceholderText = "First name";
            this.textBoxFirstname.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstname.TabIndex = 36;
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonSpecializations);
            this.Controls.Add(this.buttonReactivateUser);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonDeactivateUser);
            this.Controls.Add(this.buttonReviewUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonFilterUser);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "FormUserList";
            this.Text = "FormUserList";
            this.Load += new System.EventHandler(this.FormUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEditUser;
        private Button buttonSpecializations;
        private Button buttonReactivateUser;
        private Button buttonClearFilter;
        private Button buttonDeactivateUser;
        private Button buttonReviewUser;
        private Button buttonAddUser;
        private Button buttonFilterUser;
        private ComboBox comboBoxRole;
        private Label labelFilter;
        private DataGridView dataGridViewUsers;
        private TextBox textBoxUsername;
        private TextBox textBoxLastname;
        private TextBox textBoxFirstname;
    }
}