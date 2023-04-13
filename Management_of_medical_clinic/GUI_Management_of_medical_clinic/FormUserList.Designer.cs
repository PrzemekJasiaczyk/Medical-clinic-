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
            this.buttonReviewUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReactivateUser = new System.Windows.Forms.Button();
            this.buttonDeactivateUser = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFilterClear = new System.Windows.Forms.Button();
            this.buttonFilterUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditUser.Location = new System.Drawing.Point(-7, 352);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(329, 87);
            this.buttonEditUser.TabIndex = 33;
            this.buttonEditUser.Text = "Edit user";
            this.buttonEditUser.UseVisualStyleBackColor = false;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonReviewUser
            // 
            this.buttonReviewUser.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReviewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReviewUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReviewUser.Location = new System.Drawing.Point(-7, 445);
            this.buttonReviewUser.Name = "buttonReviewUser";
            this.buttonReviewUser.Size = new System.Drawing.Size(329, 87);
            this.buttonReviewUser.TabIndex = 28;
            this.buttonReviewUser.Text = "Review user";
            this.buttonReviewUser.UseVisualStyleBackColor = false;
            this.buttonReviewUser.Click += new System.EventHandler(this.buttonReviewUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddUser.Location = new System.Drawing.Point(-7, 259);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(329, 87);
            this.buttonAddUser.TabIndex = 27;
            this.buttonAddUser.Text = "Add new user";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.comboBoxRole.Location = new System.Drawing.Point(147, 142);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(271, 36);
            this.comboBoxRole.TabIndex = 25;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(124, 17);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(130, 37);
            this.labelFilter.TabIndex = 23;
            this.labelFilter.Text = "Filter list";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridViewUsers.Location = new System.Drawing.Point(562, 65);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowTemplate.Height = 25;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1077, 680);
            this.dataGridViewUsers.TabIndex = 22;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(634, 142);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "Username";
            this.textBoxUsername.Size = new System.Drawing.Size(271, 34);
            this.textBoxUsername.TabIndex = 34;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLastname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastname.Location = new System.Drawing.Point(634, 86);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.PlaceholderText = "Last name";
            this.textBoxLastname.Size = new System.Drawing.Size(271, 34);
            this.textBoxLastname.TabIndex = 35;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFirstname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstname.Location = new System.Drawing.Point(147, 86);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.PlaceholderText = "First name";
            this.textBoxFirstname.Size = new System.Drawing.Size(271, 34);
            this.textBoxFirstname.TabIndex = 36;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.buttonReactivateUser);
            this.panel1.Controls.Add(this.buttonDeactivateUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Controls.Add(this.buttonEditUser);
            this.panel1.Controls.Add(this.buttonReviewUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 1081);
            this.panel1.TabIndex = 37;
            // 
            // buttonReactivateUser
            // 
            this.buttonReactivateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReactivateUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReactivateUser.Location = new System.Drawing.Point(-7, 631);
            this.buttonReactivateUser.Name = "buttonReactivateUser";
            this.buttonReactivateUser.Size = new System.Drawing.Size(329, 87);
            this.buttonReactivateUser.TabIndex = 35;
            this.buttonReactivateUser.Text = "Reactivate user";
            this.buttonReactivateUser.UseVisualStyleBackColor = false;
            this.buttonReactivateUser.Click += new System.EventHandler(this.buttonReactivateUser_Click);
            // 
            // buttonDeactivateUser
            // 
            this.buttonDeactivateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDeactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeactivateUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeactivateUser.Location = new System.Drawing.Point(-7, 538);
            this.buttonDeactivateUser.Name = "buttonDeactivateUser";
            this.buttonDeactivateUser.Size = new System.Drawing.Size(329, 87);
            this.buttonDeactivateUser.TabIndex = 34;
            this.buttonDeactivateUser.Text = "Deactivate user";
            this.buttonDeactivateUser.UseVisualStyleBackColor = false;
            this.buttonDeactivateUser.Click += new System.EventHandler(this.buttonDeactivateUser_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogOut.FlatAppearance.BorderSize = 2;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.Location = new System.Drawing.Point(29, 970);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(252, 66);
            this.buttonLogOut.TabIndex = 38;
            this.buttonLogOut.Text = "LOG OUT";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.buttonFilterClear);
            this.panel2.Controls.Add(this.buttonFilterUser);
            this.panel2.Controls.Add(this.textBoxFirstname);
            this.panel2.Controls.Add(this.textBoxLastname);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Controls.Add(this.labelFilter);
            this.panel2.Controls.Add(this.comboBoxRole);
            this.panel2.Location = new System.Drawing.Point(562, 762);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 306);
            this.panel2.TabIndex = 39;
            // 
            // buttonFilterClear
            // 
            this.buttonFilterClear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFilterClear.Location = new System.Drawing.Point(602, 200);
            this.buttonFilterClear.Name = "buttonFilterClear";
            this.buttonFilterClear.Size = new System.Drawing.Size(329, 87);
            this.buttonFilterClear.TabIndex = 37;
            this.buttonFilterClear.Text = "Clear filter";
            this.buttonFilterClear.UseVisualStyleBackColor = true;
            this.buttonFilterClear.Click += new System.EventHandler(this.buttonFilterClear_Click);
            // 
            // buttonFilterUser
            // 
            this.buttonFilterUser.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFilterUser.Location = new System.Drawing.Point(124, 200);
            this.buttonFilterUser.Name = "buttonFilterUser";
            this.buttonFilterUser.Size = new System.Drawing.Size(329, 87);
            this.buttonFilterUser.TabIndex = 14;
            this.buttonFilterUser.Text = "Filter";
            this.buttonFilterUser.UseVisualStyleBackColor = true;
            this.buttonFilterUser.Click += new System.EventHandler(this.buttonFilterUser_Click);
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewUsers);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEditUser;
        private Button buttonClearFilter;
        private Button buttonReviewUser;
        private Button buttonAddUser;
        private ComboBox comboBoxRole;
        private Label labelFilter;
        private DataGridView dataGridViewUsers;
        private TextBox textBoxUsername;
        private TextBox textBoxLastname;
        private TextBox textBoxFirstname;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button buttonBack;
        private Button buttonDeactivateUser;
        private Button buttonReactivateUser;
        private Button buttonLogOut;
        private Panel panel2;
        //private Button buttonClearFilter;
        private Button buttonFilterUser;
        private Button buttonFilterClear;
    }
}