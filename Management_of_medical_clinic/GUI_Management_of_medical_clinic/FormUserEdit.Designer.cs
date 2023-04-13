namespace GUI_Management_of_medical_clinic
{
    partial class FormUserEdit
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
            label4 = new Label();
            textBoxUserId = new TextBox();
            labelTitle = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonClose = new Button();
            buttonSaveUser = new Button();
            textBoxUsername = new TextBox();
            buttonChangePassword = new Button();
            comboBoxRole = new ComboBox();
            comboBoxActive = new ComboBox();
            label6 = new Label();
            listBoxEmployees = new ListBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 65;
            label4.Text = "Id of User";
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(75, 60);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.ReadOnly = true;
            textBoxUserId.Size = new Size(59, 23);
            textBoxUserId.TabIndex = 64;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(130, 30);
            labelTitle.TabIndex = 63;
            labelTitle.Text = "User edition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 168);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 62;
            label3.Text = "Is it Active";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 139);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 61;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 110);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 60;
            label1.Text = "Username";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 224);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(140, 38);
            buttonClose.TabIndex = 59;
            buttonClose.Text = "Cancel";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSaveUser
            // 
            buttonSaveUser.Location = new Point(464, 224);
            buttonSaveUser.Name = "buttonSaveUser";
            buttonSaveUser.Size = new Size(147, 38);
            buttonSaveUser.TabIndex = 58;
            buttonSaveUser.Text = "Save";
            buttonSaveUser.UseVisualStyleBackColor = true;
            buttonSaveUser.Click += buttonSaveUser_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(162, 107);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(187, 23);
            textBoxUsername.TabIndex = 55;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Location = new Point(288, 224);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(170, 38);
            buttonChangePassword.TabIndex = 68;
            buttonChangePassword.Text = "Change password";
            buttonChangePassword.UseVisualStyleBackColor = true;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Administrator", "Employee" });
            comboBoxRole.Location = new Point(162, 136);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(187, 23);
            comboBoxRole.TabIndex = 69;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // comboBoxActive
            // 
            comboBoxActive.FormattingEnabled = true;
            comboBoxActive.Items.AddRange(new object[] { "Active", "Disactive" });
            comboBoxActive.Location = new Point(162, 165);
            comboBoxActive.Name = "comboBoxActive";
            comboBoxActive.Size = new Size(187, 23);
            comboBoxActive.TabIndex = 70;
            comboBoxActive.SelectedIndexChanged += comboBoxActive_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 61);
            label6.Name = "label6";
            label6.Size = new Size(211, 15);
            label6.TabIndex = 72;
            label6.Text = "Choose an employee to create an user:";
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 15;
            listBoxEmployees.Location = new Point(400, 79);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(211, 109);
            listBoxEmployees.TabIndex = 71;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // FormUserEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 283);
            Controls.Add(label6);
            Controls.Add(listBoxEmployees);
            Controls.Add(comboBoxActive);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonChangePassword);
            Controls.Add(label4);
            Controls.Add(textBoxUserId);
            Controls.Add(labelTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveUser);
            Controls.Add(textBoxUsername);
            Name = "FormUserEdit";
            Text = "FormUserEdit";
            Load += FormUserEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox textBoxUserId;
        private Label labelTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonClose;
        private Button buttonSaveUser;
        private TextBox textBoxUsername;
        private Button buttonChangePassword;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxActive;
        private Label label6;
        private ListBox listBoxEmployees;
    }
}