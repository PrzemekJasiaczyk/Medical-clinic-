namespace GUI_Management_of_medical_clinic
{
    partial class FormUserAdd
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
            textBoxPasswordConfirm = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            labelTitle = new Label();
            listBoxEmployeesWithout = new ListBox();
            label4 = new Label();
            buttonAddNewUser = new Button();
            buttonCancel = new Button();
            label5 = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.Location = new Point(135, 176);
            textBoxPasswordConfirm.MaxLength = 11;
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.PasswordChar = '*';
            textBoxPasswordConfirm.Size = new Size(199, 23);
            textBoxPasswordConfirm.TabIndex = 53;
            textBoxPasswordConfirm.TextChanged += textBoxPasswordConfirm_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(135, 142);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 23);
            textBoxPassword.TabIndex = 52;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 179);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 51;
            label3.Text = "Repeat Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 150);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 50;
            label1.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(135, 91);
            textBoxUsername.MaxLength = 100;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(199, 23);
            textBoxUsername.TabIndex = 49;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 99);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 48;
            label2.Text = "Username";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(162, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(422, 30);
            labelTitle.TabIndex = 47;
            labelTitle.Text = "Set Username and Password for Employee";
            // 
            // listBoxEmployeesWithout
            // 
            listBoxEmployeesWithout.FormattingEnabled = true;
            listBoxEmployeesWithout.ItemHeight = 15;
            listBoxEmployeesWithout.Location = new Point(420, 91);
            listBoxEmployeesWithout.Name = "listBoxEmployeesWithout";
            listBoxEmployeesWithout.Size = new Size(296, 229);
            listBoxEmployeesWithout.TabIndex = 54;
            listBoxEmployeesWithout.SelectedIndexChanged += listBoxEmployeesWithout_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 73);
            label4.Name = "label4";
            label4.Size = new Size(211, 15);
            label4.TabIndex = 55;
            label4.Text = "Choose an employee to create an user:";
            // 
            // buttonAddNewUser
            // 
            buttonAddNewUser.Location = new Point(648, 350);
            buttonAddNewUser.Name = "buttonAddNewUser";
            buttonAddNewUser.Size = new Size(140, 45);
            buttonAddNewUser.TabIndex = 56;
            buttonAddNewUser.Text = "Add";
            buttonAddNewUser.UseVisualStyleBackColor = true;
            buttonAddNewUser.Click += buttonAddNewUser_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 350);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(140, 45);
            buttonCancel.TabIndex = 57;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 240);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 58;
            label5.Text = "Role";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Administrator", "Employee" });
            comboBoxRole.Location = new Point(135, 237);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(199, 23);
            comboBoxRole.TabIndex = 59;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // FormUserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 407);
            Controls.Add(comboBoxRole);
            Controls.Add(label5);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddNewUser);
            Controls.Add(label4);
            Controls.Add(listBoxEmployeesWithout);
            Controls.Add(textBoxPasswordConfirm);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Name = "FormUserAdd";
            Text = "FormUserAdd";
            Load += FormUserAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPasswordConfirm;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private Label labelTitle;
        private ListBox listBoxEmployeesWithout;
        private Label label4;
        private Button buttonAddNewUser;
        private Button buttonCancel;
        private Label label5;
        private ComboBox comboBoxRole;
    }
}