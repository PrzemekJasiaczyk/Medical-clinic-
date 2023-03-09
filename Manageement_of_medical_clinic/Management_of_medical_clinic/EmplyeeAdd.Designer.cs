namespace GUI_Management_of_medical_clinic
{
    partial class EmplyeeAdd
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
            buttonNext = new Button();
            buttonCancel = new Button();
            labelTitle = new Label();
            label2 = new Label();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBoxLastName = new TextBox();
            textBoxPESEL = new TextBox();
            label4 = new Label();
            dateTimePickerDate = new DateTimePicker();
            label5 = new Label();
            comboBoxRole = new ComboBox();
            label7 = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxAddress = new TextBox();
            label10 = new Label();
            textBoxSex = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.Location = new Point(646, 393);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(142, 45);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 393);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(142, 45);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(299, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(212, 30);
            labelTitle.TabIndex = 8;
            labelTitle.Text = "Add Employee Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 81);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "First Name*";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(305, 73);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(199, 23);
            textBoxFirstName.TabIndex = 10;
            textBoxFirstName.Text = "a";
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 110);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 11;
            label1.Text = "Last Name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 139);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 12;
            label3.Text = "PESEL*";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(305, 102);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(199, 23);
            textBoxLastName.TabIndex = 13;
            textBoxLastName.Text = "a";
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(305, 131);
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(199, 23);
            textBoxPESEL.TabIndex = 14;
            textBoxPESEL.Text = "11111111111";
            textBoxPESEL.TextChanged += textBoxPESEL_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 168);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 16;
            label4.Text = "Date of Birth*";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(305, 160);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(199, 23);
            dateTimePickerDate.TabIndex = 17;
            dateTimePickerDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 197);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 19;
            label5.Text = "Role*";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Medical Doctor", "Nurse", "Paramedic", "Janitor", "Technitian" });
            comboBoxRole.Location = new Point(305, 189);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(199, 23);
            comboBoxRole.TabIndex = 20;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 341);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 27;
            label7.Text = "Sex";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(305, 304);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(199, 23);
            textBoxPhone.TabIndex = 26;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(305, 275);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 23);
            textBoxEmail.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 312);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 24;
            label8.Text = "Phone number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(209, 283);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 23;
            label9.Text = "E-mail";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(305, 246);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(199, 23);
            textBoxAddress.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(209, 249);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 21;
            label10.Text = "Corr. Address";
            // 
            // textBoxSex
            // 
            textBoxSex.Location = new Point(305, 333);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.Size = new Size(199, 23);
            textBoxSex.TabIndex = 28;
            // 
            // EmplyeeAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSex);
            Controls.Add(label7);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBoxAddress);
            Controls.Add(label10);
            Controls.Add(comboBoxRole);
            Controls.Add(label5);
            Controls.Add(dateTimePickerDate);
            Controls.Add(label4);
            Controls.Add(textBoxPESEL);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Controls.Add(buttonCancel);
            Controls.Add(buttonNext);
            Name = "EmplyeeAdd";
            Text = "Employee Add";
            Load += EmplyeeAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private Button buttonCancel;
        private Label labelTitle;
        private Label label2;
        private TextBox textBoxFirstName;
        private Label label1;
        private Label label3;
        private TextBox textBoxLastName;
        private TextBox textBoxPESEL;
        private Label label4;
        private DateTimePicker dateTimePickerDate;
        private Label label5;
        private ComboBox comboBoxRole;
        private Label label7;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Label label8;
        private Label label9;
        private TextBox textBoxAddress;
        private Label label10;
        private TextBox textBoxSex;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}