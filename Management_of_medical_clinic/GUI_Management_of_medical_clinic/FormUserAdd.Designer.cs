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
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(135, 176);
            this.textBoxPasswordConfirm.MaxLength = 11;
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.PasswordChar = '*';
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(199, 23);
            this.textBoxPasswordConfirm.TabIndex = 53;
            this.textBoxPasswordConfirm.TextChanged += new System.EventHandler(this.textBoxPasswordConfirm_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(135, 142);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(199, 23);
            this.textBoxPassword.TabIndex = 52;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Repeat Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(135, 91);
            this.textBoxUsername.MaxLength = 100;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(199, 23);
            this.textBoxUsername.TabIndex = 49;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Username";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(162, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(422, 30);
            this.labelTitle.TabIndex = 47;
            this.labelTitle.Text = "Set Username and Password for Employee";
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 15;
            this.listBoxEmployees.Location = new System.Drawing.Point(420, 91);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(296, 229);
            this.listBoxEmployees.TabIndex = 54;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployeesWithout_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Choose an employee to create an user:";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(648, 351);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(140, 45);
            this.buttonAddNewUser.TabIndex = 56;
            this.buttonAddNewUser.Text = "Add";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 350);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 45);
            this.buttonCancel.TabIndex = 57;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Role";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.comboBoxRole.Location = new System.Drawing.Point(135, 237);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(199, 23);
            this.comboBoxRole.TabIndex = 59;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // FormUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormUserAdd";
            this.Text = "FormUserAdd";
            this.Load += new System.EventHandler(this.FormUserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPasswordConfirm;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private Label labelTitle;
        private ListBox listBoxEmployees;
        private Label label4;
        private Button buttonAddNewUser;
        private Button buttonCancel;
        private Label label5;
        private ComboBox comboBoxRole;
    }
}