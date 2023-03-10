namespace GUI_Management_of_medical_clinic
{
    partial class FormEmployeeDetailsView
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPESEL = new TextBox();
            textBoxDateOfBirth = new TextBox();
            textBoxRole = new TextBox();
            textBoxCorrespondenceAddress = new TextBox();
            textBoxSex = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxIsActive = new TextBox();
            Edit_Employee = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(78, 66);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.ReadOnly = true;
            textBoxFirstName.Size = new Size(187, 23);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(78, 121);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.ReadOnly = true;
            textBoxLastName.Size = new Size(187, 23);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(78, 171);
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.ReadOnly = true;
            textBoxPESEL.Size = new Size(187, 23);
            textBoxPESEL.TabIndex = 2;
            // 
            // textBoxDateOfBirth
            // 
            textBoxDateOfBirth.Location = new Point(78, 223);
            textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            textBoxDateOfBirth.ReadOnly = true;
            textBoxDateOfBirth.Size = new Size(187, 23);
            textBoxDateOfBirth.TabIndex = 3;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(78, 282);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.ReadOnly = true;
            textBoxRole.Size = new Size(187, 23);
            textBoxRole.TabIndex = 4;
            // 
            // textBoxCorrespondenceAddress
            // 
            textBoxCorrespondenceAddress.Location = new Point(549, 66);
            textBoxCorrespondenceAddress.Name = "textBoxCorrespondenceAddress";
            textBoxCorrespondenceAddress.ReadOnly = true;
            textBoxCorrespondenceAddress.Size = new Size(187, 23);
            textBoxCorrespondenceAddress.TabIndex = 5;
            // 
            // textBoxSex
            // 
            textBoxSex.Location = new Point(549, 223);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.ReadOnly = true;
            textBoxSex.Size = new Size(187, 23);
            textBoxSex.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(549, 112);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(187, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(549, 171);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.ReadOnly = true;
            textBoxPhoneNumber.Size = new Size(187, 23);
            textBoxPhoneNumber.TabIndex = 8;
            // 
            // textBoxIsActive
            // 
            textBoxIsActive.Location = new Point(549, 282);
            textBoxIsActive.Name = "textBoxIsActive";
            textBoxIsActive.ReadOnly = true;
            textBoxIsActive.Size = new Size(187, 23);
            textBoxIsActive.TabIndex = 9;
            // 
            // Edit_Employee
            // 
            Edit_Employee.Location = new Point(405, 361);
            Edit_Employee.Name = "Edit_Employee";
            Edit_Employee.Size = new Size(147, 38);
            Edit_Employee.TabIndex = 10;
            Edit_Employee.Text = "Edit employee";
            Edit_Employee.UseVisualStyleBackColor = true;
            Edit_Employee.Click += Edit_Employee_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 361);
            button2.Name = "button2";
            button2.Size = new Size(140, 38);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EmployeeDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Edit_Employee);
            Controls.Add(textBoxIsActive);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxSex);
            Controls.Add(textBoxCorrespondenceAddress);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxDateOfBirth);
            Controls.Add(textBoxPESEL);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Name = "EmployeeDetailsView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmployeeDetailsView";
            Load += EmployeeDetailsView_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPESEL;
        private TextBox textBoxDateOfBirth;
        private TextBox textBoxRole;
        private TextBox textBoxCorrespondenceAddress;
        private TextBox textBoxSex;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxIsActive;
        private Button Edit_Employee;
        private Button button2;
    }
}
