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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.Edit_Employee = new System.Windows.Forms.Button();
            this.textBoxIsActive = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxCorrespondenceAddress = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(252, 354);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 38);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Edit_Employee
            // 
            this.Edit_Employee.Location = new System.Drawing.Point(398, 354);
            this.Edit_Employee.Name = "Edit_Employee";
            this.Edit_Employee.Size = new System.Drawing.Size(147, 38);
            this.Edit_Employee.TabIndex = 22;
            this.Edit_Employee.Text = "Edit employee";
            this.Edit_Employee.UseVisualStyleBackColor = true;
            this.Edit_Employee.Click += new System.EventHandler(this.Edit_Employee_Click);
            // 
            // textBoxIsActive
            // 
            this.textBoxIsActive.Location = new System.Drawing.Point(542, 275);
            this.textBoxIsActive.Name = "textBoxIsActive";
            this.textBoxIsActive.ReadOnly = true;
            this.textBoxIsActive.Size = new System.Drawing.Size(187, 23);
            this.textBoxIsActive.TabIndex = 21;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(542, 164);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(187, 23);
            this.textBoxPhoneNumber.TabIndex = 20;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(542, 105);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(187, 23);
            this.textBoxEmail.TabIndex = 19;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(542, 216);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.ReadOnly = true;
            this.textBoxSex.Size = new System.Drawing.Size(187, 23);
            this.textBoxSex.TabIndex = 18;
            // 
            // textBoxCorrespondenceAddress
            // 
            this.textBoxCorrespondenceAddress.Location = new System.Drawing.Point(542, 59);
            this.textBoxCorrespondenceAddress.Name = "textBoxCorrespondenceAddress";
            this.textBoxCorrespondenceAddress.ReadOnly = true;
            this.textBoxCorrespondenceAddress.Size = new System.Drawing.Size(187, 23);
            this.textBoxCorrespondenceAddress.TabIndex = 17;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(71, 275);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(187, 23);
            this.textBoxRole.TabIndex = 16;
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(71, 216);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.ReadOnly = true;
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(187, 23);
            this.textBoxDateOfBirth.TabIndex = 15;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(71, 164);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.ReadOnly = true;
            this.textBoxPESEL.Size = new System.Drawing.Size(187, 23);
            this.textBoxPESEL.TabIndex = 14;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(71, 114);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(187, 23);
            this.textBoxLastName.TabIndex = 13;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(71, 59);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(187, 23);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // FormEmployeeDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.Edit_Employee);
            this.Controls.Add(this.textBoxIsActive);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSex);
            this.Controls.Add(this.textBoxCorrespondenceAddress);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.textBoxPESEL);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormEmployeeDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeDetailsView";
            this.Load += new System.EventHandler(this.FormEmployeeDetailsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancel;
        private Button Edit_Employee;
        private TextBox textBoxIsActive;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxEmail;
        private TextBox textBoxSex;
        private TextBox textBoxCorrespondenceAddress;
        private TextBox textBoxRole;
        private TextBox textBoxDateOfBirth;
        private TextBox textBoxPESEL;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
    }
}