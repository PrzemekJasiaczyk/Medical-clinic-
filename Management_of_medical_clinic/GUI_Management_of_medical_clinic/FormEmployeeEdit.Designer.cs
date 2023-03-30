namespace GUI_Management_of_medical_clinic
{
    partial class FormEmployeeEdit
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
            comboBoxRole = new ComboBox();
            buttonConfirm = new Button();
            label7 = new Label();
            phoneNumberTextBox = new TextBox();
            textBoxEmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            correspAddressTextBox = new TextBox();
            label10 = new Label();
            label5 = new Label();
            textBoxDateOfBirth = new DateTimePicker();
            label4 = new Label();
            textBoxPESEL = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            labelTitle = new Label();
            buttonCancel = new Button();
            comboBoxSex = new ComboBox();
            labelSpecialization = new Label();
            checkedListBoxSpecialization = new CheckedListBox();
            SuspendLayout();
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Medical Doctor", "Nurse", "Paramedic", "Janitor", "Technitian" });
            comboBoxRole.Location = new Point(718, 386);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(199, 23);
            comboBoxRole.TabIndex = 72;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(1059, 593);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(142, 45);
            buttonConfirm.TabIndex = 71;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(622, 538);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 69;
            label7.Text = "Sex";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(718, 501);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(199, 23);
            phoneNumberTextBox.TabIndex = 68;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(718, 472);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 23);
            textBoxEmail.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(622, 509);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 66;
            label8.Text = "Phone number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(622, 480);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 65;
            label9.Text = "E-mail";
            // 
            // correspAddressTextBox
            // 
            correspAddressTextBox.Location = new Point(718, 443);
            correspAddressTextBox.Name = "correspAddressTextBox";
            correspAddressTextBox.Size = new Size(199, 23);
            correspAddressTextBox.TabIndex = 64;
            correspAddressTextBox.TextChanged += correspAddressTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(622, 446);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 63;
            label10.Text = "Corr. Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(622, 394);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 62;
            label5.Text = "Role*";
            // 
            // textBoxDateOfBirth
            // 
            textBoxDateOfBirth.Format = DateTimePickerFormat.Short;
            textBoxDateOfBirth.Location = new Point(718, 357);
            textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            textBoxDateOfBirth.Size = new Size(199, 23);
            textBoxDateOfBirth.TabIndex = 61;
            textBoxDateOfBirth.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(622, 365);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 60;
            label4.Text = "Date of Birth*";
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(718, 328);
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(199, 23);
            textBoxPESEL.TabIndex = 59;
            textBoxPESEL.Text = "11111111111";
            textBoxPESEL.TextChanged += textBoxPESEL_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(718, 299);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(199, 23);
            textBoxLastName.TabIndex = 58;
            textBoxLastName.Text = "a";
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 336);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 57;
            label3.Text = "PESEL*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(622, 307);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 56;
            label1.Text = "Last Name*";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(718, 270);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(199, 23);
            textBoxFirstName.TabIndex = 55;
            textBoxFirstName.Text = "a";
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 278);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 54;
            label2.Text = "First Name*";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(741, 209);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(152, 30);
            labelTitle.TabIndex = 53;
            labelTitle.Text = "Edit employee";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(425, 590);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(142, 45);
            buttonCancel.TabIndex = 52;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(718, 538);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(199, 23);
            comboBoxSex.TabIndex = 73;
            comboBoxSex.SelectedIndexChanged += comboBoxSex_SelectedIndexChanged;
            // 
            // labelSpecialization
            // 
            labelSpecialization.AutoSize = true;
            labelSpecialization.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpecialization.Location = new Point(1035, 252);
            labelSpecialization.Name = "labelSpecialization";
            labelSpecialization.Size = new Size(133, 15);
            labelSpecialization.TabIndex = 75;
            labelSpecialization.Text = "Doctor's Specialization";
            labelSpecialization.Visible = false;
            // 
            // checkedListBoxSpecialization
            // 
            checkedListBoxSpecialization.CheckOnClick = true;
            checkedListBoxSpecialization.FormattingEnabled = true;
            checkedListBoxSpecialization.Location = new Point(992, 270);
            checkedListBoxSpecialization.Name = "checkedListBoxSpecialization";
            checkedListBoxSpecialization.Size = new Size(209, 274);
            checkedListBoxSpecialization.TabIndex = 74;
            checkedListBoxSpecialization.Visible = false;
            checkedListBoxSpecialization.SelectedIndexChanged += checkedListBoxSpecialization_SelectedIndexChanged;
            // 
            // FormEmployeeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelSpecialization);
            Controls.Add(checkedListBoxSpecialization);
            Controls.Add(comboBoxSex);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonConfirm);
            Controls.Add(label7);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(textBoxEmail);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(correspAddressTextBox);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(textBoxDateOfBirth);
            Controls.Add(label4);
            Controls.Add(textBoxPESEL);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployeeEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployeeEdit";
            WindowState = FormWindowState.Maximized;
            Load += FormEmployeeEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRole;
        private Button buttonConfirm;
        private Label label7;
        private TextBox phoneNumberTextBox;
        private TextBox textBoxEmail;
        private Label label8;
        private Label label9;
        private TextBox correspAddressTextBox;
        private Label label10;
        private Label label5;
        private DateTimePicker textBoxDateOfBirth;
        private Label label4;
        private TextBox textBoxPESEL;
        private TextBox textBoxLastName;
        private Label label3;
        private Label label1;
        private TextBox textBoxFirstName;
        private Label label2;
        private Label labelTitle;
        private Button buttonCancel;
        private ComboBox comboBoxSex;
        private Label labelSpecialization;
        private CheckedListBox checkedListBoxSpecialization;
    }
}