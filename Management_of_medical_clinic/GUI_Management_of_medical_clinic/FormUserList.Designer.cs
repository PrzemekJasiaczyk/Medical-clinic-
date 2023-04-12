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
            buttonEditUser = new Button();
            buttonSpecializations = new Button();
            buttonReactivateUser = new Button();
            buttonClearFilter = new Button();
            buttonDeactivateUser = new Button();
            buttonReviewUser = new Button();
            buttonAddUser = new Button();
            buttonFilterUser = new Button();
            comboBoxRole = new ComboBox();
            labelFilter = new Label();
            dataGridViewUsers = new DataGridView();
            textBoxUsername = new TextBox();
            textBoxLastname = new TextBox();
            textBoxFirstname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(402, 380);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(142, 45);
            buttonEditUser.TabIndex = 33;
            buttonEditUser.Text = "Edit user";
            buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // buttonSpecializations
            // 
            buttonSpecializations.Location = new Point(251, 380);
            buttonSpecializations.Name = "buttonSpecializations";
            buttonSpecializations.Size = new Size(142, 45);
            buttonSpecializations.TabIndex = 32;
            buttonSpecializations.Text = "Edit Specializations";
            buttonSpecializations.UseVisualStyleBackColor = true;
            // 
            // buttonReactivateUser
            // 
            buttonReactivateUser.Location = new Point(648, 380);
            buttonReactivateUser.Name = "buttonReactivateUser";
            buttonReactivateUser.Size = new Size(140, 45);
            buttonReactivateUser.TabIndex = 31;
            buttonReactivateUser.Text = "Reactivate user";
            buttonReactivateUser.UseVisualStyleBackColor = true;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(8, 390);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(100, 24);
            buttonClearFilter.TabIndex = 30;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // buttonDeactivateUser
            // 
            buttonDeactivateUser.Location = new Point(648, 329);
            buttonDeactivateUser.Name = "buttonDeactivateUser";
            buttonDeactivateUser.Size = new Size(140, 45);
            buttonDeactivateUser.TabIndex = 29;
            buttonDeactivateUser.Text = "Deactivate user";
            buttonDeactivateUser.UseVisualStyleBackColor = true;
            // 
            // buttonReviewUser
            // 
            buttonReviewUser.Location = new Point(399, 329);
            buttonReviewUser.Name = "buttonReviewUser";
            buttonReviewUser.Size = new Size(145, 45);
            buttonReviewUser.TabIndex = 28;
            buttonReviewUser.Text = "Review user";
            buttonReviewUser.UseVisualStyleBackColor = true;
            buttonReviewUser.Click += buttonReviewUser_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(251, 329);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(142, 45);
            buttonAddUser.TabIndex = 27;
            buttonAddUser.Text = "Add new user";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonFilterUser
            // 
            buttonFilterUser.Location = new Point(118, 390);
            buttonFilterUser.Name = "buttonFilterUser";
            buttonFilterUser.Size = new Size(100, 24);
            buttonFilterUser.TabIndex = 26;
            buttonFilterUser.Text = "Filtr";
            buttonFilterUser.UseVisualStyleBackColor = true;
            buttonFilterUser.Click += buttonFilterUser_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Administrator", "Employee" });
            comboBoxRole.Location = new Point(8, 361);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(100, 23);
            comboBoxRole.TabIndex = 25;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(12, 308);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(51, 15);
            labelFilter.TabIndex = 23;
            labelFilter.Text = "Filter list";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 22);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(776, 273);
            dataGridViewUsers.TabIndex = 22;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(118, 361);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(100, 23);
            textBoxUsername.TabIndex = 34;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(118, 332);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.PlaceholderText = "Last name";
            textBoxLastname.Size = new Size(100, 23);
            textBoxLastname.TabIndex = 35;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(8, 332);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.PlaceholderText = "First name";
            textBoxFirstname.Size = new Size(100, 23);
            textBoxFirstname.TabIndex = 36;
            // 
            // FormUserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxFirstname);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonEditUser);
            Controls.Add(buttonSpecializations);
            Controls.Add(buttonReactivateUser);
            Controls.Add(buttonClearFilter);
            Controls.Add(buttonDeactivateUser);
            Controls.Add(buttonReviewUser);
            Controls.Add(buttonAddUser);
            Controls.Add(buttonFilterUser);
            Controls.Add(comboBoxRole);
            Controls.Add(labelFilter);
            Controls.Add(dataGridViewUsers);
            Name = "FormUserList";
            Text = "FormUserList";
            Load += FormUserList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
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