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
            buttonReviewUser = new Button();
            buttonAddUser = new Button();
            comboBoxRole = new ComboBox();
            labelFilter = new Label();
            dataGridViewUsers = new DataGridView();
            textBoxUsername = new TextBox();
            textBoxLastname = new TextBox();
            textBoxFirstname = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonReactivateUser = new Button();
            buttonDeactivateUser = new Button();
            buttonLogOut = new Button();
            panel2 = new Panel();
            buttonFilterClear = new Button();
            buttonFilterUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            buttonReactivateUser.BackColor = Color.SteelBlue;
            buttonReactivateUser.FlatStyle = FlatStyle.Flat;
            buttonReactivateUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReactivateUser.Location = new Point(-7, 631);
            buttonReactivateUser.Name = "buttonReactivateUser";
            buttonReactivateUser.Size = new Size(329, 87);
            buttonReactivateUser.TabIndex = 35;
            buttonReactivateUser.Text = "Reactivate user";
            buttonReactivateUser.UseVisualStyleBackColor = false;
            buttonReactivateUser.Click += buttonReactivateUser_Click;
            // 
            // buttonDeactivateUser
            // 
            buttonDeactivateUser.BackColor = Color.SteelBlue;
            buttonDeactivateUser.FlatStyle = FlatStyle.Flat;
            buttonDeactivateUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeactivateUser.Location = new Point(-7, 538);
            buttonDeactivateUser.Name = "buttonDeactivateUser";
            buttonDeactivateUser.Size = new Size(329, 87);
            buttonDeactivateUser.TabIndex = 34;
            buttonDeactivateUser.Text = "Deactivate user";
            buttonDeactivateUser.UseVisualStyleBackColor = false;
            buttonDeactivateUser.Click += buttonDeactivateUser_Click;
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
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonFilterClear);
            panel2.Controls.Add(buttonFilterUser);
            panel2.Controls.Add(textBoxFirstname);
            panel2.Controls.Add(textBoxLastname);
            panel2.Controls.Add(textBoxUsername);
            panel2.Controls.Add(labelFilter);
            panel2.Controls.Add(comboBoxRole);
            panel2.Location = new Point(562, 762);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 306);
            panel2.TabIndex = 39;
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
            // buttonFilterUser
            // 
            buttonFilterUser.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFilterUser.Location = new Point(124, 200);
            buttonFilterUser.Name = "buttonFilterUser";
            buttonFilterUser.Size = new Size(329, 87);
            buttonFilterUser.TabIndex = 14;
            buttonFilterUser.Text = "Filter";
            buttonFilterUser.UseVisualStyleBackColor = true;
            buttonFilterUser.Click += buttonFilterUser_Click;
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