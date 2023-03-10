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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBoxSex = new TextBox();
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
            buttonConfirm = new Button();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // textBoxSex
            // 
            textBoxSex.Location = new Point(305, 330);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.Size = new Size(199, 23);
            textBoxSex.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 338);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 48;
            label7.Text = "Sex";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(305, 301);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(199, 23);
            phoneNumberTextBox.TabIndex = 47;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(305, 272);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 23);
            textBoxEmail.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 309);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 45;
            label8.Text = "Phone number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(209, 280);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 44;
            label9.Text = "E-mail";
            // 
            // correspAddressTextBox
            // 
            correspAddressTextBox.Location = new Point(305, 243);
            correspAddressTextBox.Name = "correspAddressTextBox";
            correspAddressTextBox.Size = new Size(199, 23);
            correspAddressTextBox.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(209, 246);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 42;
            label10.Text = "Corr. Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 194);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 40;
            label5.Text = "Role*";
            // 
            // textBoxDateOfBirth
            // 
            textBoxDateOfBirth.Format = DateTimePickerFormat.Short;
            textBoxDateOfBirth.Location = new Point(305, 157);
            textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            textBoxDateOfBirth.Size = new Size(199, 23);
            textBoxDateOfBirth.TabIndex = 39;
            textBoxDateOfBirth.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 165);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 38;
            label4.Text = "Date of Birth*";
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(305, 128);
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(199, 23);
            textBoxPESEL.TabIndex = 37;
            textBoxPESEL.Text = "11111111111";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(305, 99);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(199, 23);
            textBoxLastName.TabIndex = 36;
            textBoxLastName.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 136);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 35;
            label3.Text = "PESEL*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 107);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 34;
            label1.Text = "Last Name*";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(305, 70);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(199, 23);
            textBoxFirstName.TabIndex = 33;
            textBoxFirstName.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 32;
            label2.Text = "First Name*";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(328, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(152, 30);
            labelTitle.TabIndex = 31;
            labelTitle.Text = "Edit employee";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 390);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(142, 45);
            buttonCancel.TabIndex = 30;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(646, 393);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(142, 45);
            buttonConfirm.TabIndex = 50;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Employee", "Doctor", "none" });
            comboBoxRole.Location = new Point(305, 186);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(199, 23);
            comboBoxRole.TabIndex = 51;
            // 
            // EmployeeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxSex);
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
            Name = "EmployeeEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Edit";
            Load += EmployeeEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxSex;
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
        private Button buttonConfirm;
        private ComboBox comboBoxRole;
    }
}