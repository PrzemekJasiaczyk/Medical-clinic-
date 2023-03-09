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

            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

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

            this.textBoxFirstName.Location = new System.Drawing.Point(305, 73);
            this.textBoxFirstName.MaxLength = 100;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(199, 23);
            this.textBoxFirstName.TabIndex = 10;
            this.textBoxFirstName.Text = "a";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);

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

            this.textBoxLastName.Location = new System.Drawing.Point(305, 102);
            this.textBoxLastName.MaxLength = 100;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(199, 23);
            this.textBoxLastName.TabIndex = 13;
            this.textBoxLastName.Text = "a";
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(305, 131);
            this.textBoxPESEL.MaxLength = 11;
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(199, 23);
            this.textBoxPESEL.TabIndex = 14;
            this.textBoxPESEL.Text = "01010011111";
            this.textBoxPESEL.TextChanged += new System.EventHandler(this.textBoxPESEL_TextChanged);

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

            this.textBoxPhone.Location = new System.Drawing.Point(305, 304);
            this.textBoxPhone.MaxLength = 9;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(199, 23);
            this.textBoxPhone.TabIndex = 26;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(305, 275);
            this.textBoxEmail.MaxLength = 200;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(199, 23);
            this.textBoxEmail.TabIndex = 25;

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

            this.textBoxAddress.Location = new System.Drawing.Point(305, 246);
            this.textBoxAddress.MaxLength = 500;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(199, 23);
            this.textBoxAddress.TabIndex = 22;

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
            // comboBoxSex
            // 

            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Not Specified",
            "Male",
            "Female"});
            this.comboBoxSex.Location = new System.Drawing.Point(305, 333);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(199, 23);
            this.comboBoxSex.TabIndex = 28;
            // 
            // EmplyeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "EmplyeeAdd";
            this.Text = "EmplyeeAdd";
            this.Load += new System.EventHandler(this.EmplyeeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBoxSex;
    }
}