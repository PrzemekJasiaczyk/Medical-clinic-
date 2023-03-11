namespace GUI_Management_of_medical_clinic
{
    partial class FormEmployeeAdd
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
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.checkedListBoxSpecialization = new System.Windows.Forms.CheckedListBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSpecialization.Location = new System.Drawing.Point(591, 61);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(133, 15);
            this.labelSpecialization.TabIndex = 54;
            this.labelSpecialization.Text = "Doctor\'s Specialization";
            this.labelSpecialization.Visible = false;
            // 
            // checkedListBoxSpecialization
            // 
            this.checkedListBoxSpecialization.CheckOnClick = true;
            this.checkedListBoxSpecialization.FormattingEnabled = true;
            this.checkedListBoxSpecialization.Items.AddRange(new object[] {
            "Anesthesiology",
            "Dermatology",
            "Family Medicine",
            "Neurology",
            "Radiation Oncology",
            "Surgery",
            "Urology"});
            this.checkedListBoxSpecialization.Location = new System.Drawing.Point(548, 79);
            this.checkedListBoxSpecialization.Name = "checkedListBoxSpecialization";
            this.checkedListBoxSpecialization.Size = new System.Drawing.Size(209, 130);
            this.checkedListBoxSpecialization.TabIndex = 53;
            this.checkedListBoxSpecialization.Visible = false;
            this.checkedListBoxSpecialization.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSpecialization_SelectedIndexChanged);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Not Specified",
            "Male",
            "Female"});
            this.comboBoxSex.Location = new System.Drawing.Point(305, 330);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(199, 23);
            this.comboBoxSex.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Sex";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(305, 301);
            this.textBoxPhone.MaxLength = 9;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(199, 23);
            this.textBoxPhone.TabIndex = 50;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(305, 272);
            this.textBoxEmail.MaxLength = 200;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(199, 23);
            this.textBoxEmail.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Phone number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "E-mail";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(305, 243);
            this.textBoxAddress.MaxLength = 500;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(199, 23);
            this.textBoxAddress.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Corr. Address";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Medical Doctor",
            "Nurse",
            "Paramedic",
            "Janitor",
            "Technitian"});
            this.comboBoxRole.Location = new System.Drawing.Point(305, 186);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(199, 23);
            this.comboBoxRole.TabIndex = 44;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Role*";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(305, 157);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(199, 23);
            this.dateTimePickerDate.TabIndex = 42;
            this.dateTimePickerDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date of Birth*";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(305, 128);
            this.textBoxPESEL.MaxLength = 11;
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(199, 23);
            this.textBoxPESEL.TabIndex = 40;
            this.textBoxPESEL.Text = "01010011111";
            this.textBoxPESEL.TextChanged += new System.EventHandler(this.textBoxPESEL_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(305, 99);
            this.textBoxLastName.MaxLength = 100;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(199, 23);
            this.textBoxLastName.TabIndex = 39;
            this.textBoxLastName.Text = "a";
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "PESEL*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Last Name*";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(305, 70);
            this.textBoxFirstName.MaxLength = 100;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(199, 23);
            this.textBoxFirstName.TabIndex = 36;
            this.textBoxFirstName.Text = "a";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "First Name*";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(299, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(212, 30);
            this.labelTitle.TabIndex = 34;
            this.labelTitle.Text = "Add Employee Form";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 390);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 45);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(646, 390);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(142, 45);
            this.buttonNext.TabIndex = 32;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSpecialization);
            this.Controls.Add(this.checkedListBoxSpecialization);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPESEL);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNext);
            this.Name = "FormEmployeeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeAdd";
            this.Load += new System.EventHandler(this.FormEmployeeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSpecialization;
        private CheckedListBox checkedListBoxSpecialization;
        private ComboBox comboBoxSex;
        private Label label7;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Label label8;
        private Label label9;
        private TextBox textBoxAddress;
        private Label label10;
        private ComboBox comboBoxRole;
        private Label label5;
        private DateTimePicker dateTimePickerDate;
        private Label label4;
        private TextBox textBoxPESEL;
        private TextBox textBoxLastName;
        private Label label3;
        private Label label1;
        private TextBox textBoxFirstName;
        private Label label2;
        private Label labelTitle;
        private Button buttonCancel;
        private Button buttonNext;
    }
}