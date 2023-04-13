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
            buttonSaveUser = new Button();
            textBoxUsername = new TextBox();
            buttonChangePassword = new Button();
            comboBoxRole = new ComboBox();
            comboBoxActive = new ComboBox();
            label6 = new Label();
            listBoxEmployees = new ListBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            buttonClose = new Button();
            buttonChangeStatus = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(873, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "Id of User";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(936, 376);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.ReadOnly = true;
            this.textBoxUserId.Size = new System.Drawing.Size(59, 23);
            this.textBoxUserId.TabIndex = 64;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(1136, 302);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 30);
            this.labelTitle.TabIndex = 63;
            this.labelTitle.Text = "User edition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(943, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "Is it Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(943, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(943, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Username";
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Location = new System.Drawing.Point(1216, 605);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(147, 38);
            this.buttonSaveUser.TabIndex = 58;
            this.buttonSaveUser.Text = "Save";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(1023, 423);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(187, 23);
            this.textBoxUsername.TabIndex = 55;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(1040, 605);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(170, 38);
            this.buttonChangePassword.TabIndex = 68;
            this.buttonChangePassword.Text = "Change password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.comboBoxRole.Location = new System.Drawing.Point(1023, 452);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(187, 23);
            this.comboBoxRole.TabIndex = 69;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // comboBoxActive
            // 
            this.comboBoxActive.FormattingEnabled = true;
            this.comboBoxActive.Items.AddRange(new object[] {
            "Active",
            "Disactive"});
            this.comboBoxActive.Location = new System.Drawing.Point(1023, 481);
            this.comboBoxActive.Name = "comboBoxActive";
            this.comboBoxActive.Size = new System.Drawing.Size(187, 23);
            this.comboBoxActive.TabIndex = 70;
            this.comboBoxActive.SelectedIndexChanged += new System.EventHandler(this.comboBoxActive_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1261, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "Choose an employee to create an user:";
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 15;
            this.listBoxEmployees.Location = new System.Drawing.Point(1261, 395);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(211, 109);
            this.listBoxEmployees.TabIndex = 71;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployees_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 1081);
            this.panel2.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(24, 985);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(252, 66);
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonChangeStatus
            // 
            buttonChangeStatus.Location = new Point(864, 605);
            buttonChangeStatus.Name = "buttonChangeStatus";
            buttonChangeStatus.Size = new Size(170, 38);
            buttonChangeStatus.TabIndex = 69;
            buttonChangeStatus.Text = "Change status of user";
            buttonChangeStatus.UseVisualStyleBackColor = true;
            buttonChangeStatus.Click += buttonChangeStatus_Click;
            // 
            // FormUserEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonChangeStatus);
            Controls.Add(panel2);
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
            Controls.Add(buttonSaveUser);
            Controls.Add(textBoxUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUserEdit";
            Text = "FormUserEdit";
            Load += FormUserEdit_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button buttonSaveUser;
        private TextBox textBoxUsername;
        private Button buttonChangePassword;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxActive;
        private Label label6;
        private ListBox listBoxEmployees;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonClose;
        private Button buttonChangeStatus;
    }
}