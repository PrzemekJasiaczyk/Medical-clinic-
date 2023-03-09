namespace GUI_Management_of_medical_clinic
{
    partial class EmployeeDetailsView
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxCorrespondenceAddress = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxIsActive = new System.Windows.Forms.TextBox();
            this.Edit_Employee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(78, 66);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(187, 23);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(78, 121);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(187, 23);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(78, 171);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(187, 23);
            this.textBoxPESEL.TabIndex = 2;
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(78, 223);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(187, 23);
            this.textBoxDateOfBirth.TabIndex = 3;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(78, 282);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(187, 23);
            this.textBoxRole.TabIndex = 4;
            // 
            // textBoxCorrespondenceAddress
            // 
            this.textBoxCorrespondenceAddress.Location = new System.Drawing.Point(549, 66);
            this.textBoxCorrespondenceAddress.Name = "textBoxCorrespondenceAddress";
            this.textBoxCorrespondenceAddress.Size = new System.Drawing.Size(187, 23);
            this.textBoxCorrespondenceAddress.TabIndex = 5;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(549, 223);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.Size = new System.Drawing.Size(187, 23);
            this.textBoxSex.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(549, 112);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(187, 23);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(549, 171);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(187, 23);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // textBoxIsActive
            // 
            this.textBoxIsActive.Location = new System.Drawing.Point(549, 282);
            this.textBoxIsActive.Name = "textBoxIsActive";
            this.textBoxIsActive.Size = new System.Drawing.Size(187, 23);
            this.textBoxIsActive.TabIndex = 9;
            // 
            // Edit_Employee
            // 
            this.Edit_Employee.Location = new System.Drawing.Point(245, 360);
            this.Edit_Employee.Name = "Edit_Employee";
            this.Edit_Employee.Size = new System.Drawing.Size(147, 38);
            this.Edit_Employee.TabIndex = 10;
            this.Edit_Employee.Text = "Edit employee";
            this.Edit_Employee.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
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
            this.Name = "EmployeeDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeDetailsView";


            this.Load += new System.EventHandler(this.EmployeeDetailsView_Load_1);

            this.ResumeLayout(false);
            this.PerformLayout();

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
