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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
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
            dateTimePickerDate = new DateTimePicker();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(951, 482);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(199, 43);
            comboBoxRole.TabIndex = 72;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged_1;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Gainsboro;
            buttonConfirm.FlatAppearance.BorderColor = Color.Black;
            buttonConfirm.FlatAppearance.BorderSize = 2;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(1064, 882);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(252, 66);
            buttonConfirm.TabIndex = 71;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(723, 730);
            label7.Name = "label7";
            label7.Size = new Size(58, 36);
            label7.TabIndex = 69;
            label7.Text = "Sex";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(723, 683);
            label8.Name = "label8";
            label8.Size = new Size(196, 36);
            label8.TabIndex = 66;
            label8.Text = "Phone number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(723, 636);
            label9.Name = "label9";
            label9.Size = new Size(92, 36);
            label9.TabIndex = 65;
            label9.Text = "E-mail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(723, 589);
            label10.Name = "label10";
            label10.Size = new Size(175, 36);
            label10.TabIndex = 63;
            label10.Text = "Corr. Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(723, 482);
            label5.Name = "label5";
            label5.Size = new Size(80, 36);
            label5.TabIndex = 62;
            label5.Text = "Role*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(723, 435);
            label4.Name = "label4";
            label4.Size = new Size(185, 36);
            label4.TabIndex = 60;
            label4.Text = "Date of Birth*";
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPESEL.Location = new Point(951, 388);
            textBoxPESEL.MaxLength = 11;
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(199, 41);
            textBoxPESEL.TabIndex = 59;
            textBoxPESEL.TextChanged += textBoxPESEL_TextChanged_1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(951, 341);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(199, 41);
            textBoxLastName.TabIndex = 58;
            textBoxLastName.Text = "Surname";
            textBoxLastName.TextChanged += textBoxLastName_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(723, 388);
            label3.Name = "label3";
            label3.Size = new Size(96, 36);
            label3.TabIndex = 57;
            label3.Text = "PESEL*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(723, 341);
            label1.Name = "label1";
            label1.Size = new Size(155, 36);
            label1.TabIndex = 56;
            label1.Text = "Last Name*";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(951, 293);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(199, 41);
            textBoxFirstName.TabIndex = 55;
            textBoxFirstName.Text = "Name";
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(723, 293);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 54;
            label2.Text = "First Name*";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(808, 98);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(246, 46);
            labelTitle.TabIndex = 53;
            labelTitle.Text = "Edit employee";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(28, 984);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(252, 66);
            buttonCancel.TabIndex = 52;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(951, 730);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(199, 43);
            comboBoxSex.TabIndex = 73;
            // 
            // labelSpecialization
            // 
            labelSpecialization.AutoSize = true;
            labelSpecialization.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpecialization.Location = new Point(1229, 214);
            labelSpecialization.Name = "labelSpecialization";
            labelSpecialization.Size = new Size(383, 46);
            labelSpecialization.TabIndex = 75;
            labelSpecialization.Text = "Doctor's Specialization";
            labelSpecialization.Visible = false;
            // 
            // checkedListBoxSpecialization
            // 
            checkedListBoxSpecialization.CheckOnClick = true;
            checkedListBoxSpecialization.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxSpecialization.FormattingEnabled = true;
            checkedListBoxSpecialization.Location = new Point(1229, 293);
            checkedListBoxSpecialization.Name = "checkedListBoxSpecialization";
            checkedListBoxSpecialization.Size = new Size(383, 256);
            checkedListBoxSpecialization.TabIndex = 74;
            checkedListBoxSpecialization.Visible = false;
            checkedListBoxSpecialization.SelectedIndexChanged += checkedListBoxSpecialization_SelectedIndexChanged_1;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(951, 435);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(199, 41);
            dateTimePickerDate.TabIndex = 76;
            dateTimePickerDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(951, 683);
            textBoxPhone.MaxLength = 9;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(199, 41);
            textBoxPhone.TabIndex = 79;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(951, 636);
            textBoxEmail.MaxLength = 200;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 41);
            textBoxEmail.TabIndex = 78;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(951, 589);
            textBoxAddress.MaxLength = 500;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(199, 41);
            textBoxAddress.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonCancel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 76;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormEmployeeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAddress);
            Controls.Add(dateTimePickerDate);
            Controls.Add(panel2);
            Controls.Add(labelSpecialization);
            Controls.Add(checkedListBoxSpecialization);
            Controls.Add(comboBoxSex);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonConfirm);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxPESEL);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployeeEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployeeEdit";
            WindowState = FormWindowState.Maximized;
            Load += FormEmployeeEdit_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRole;
        private Button buttonConfirm;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
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
        private DateTimePicker dateTimePickerDate;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}