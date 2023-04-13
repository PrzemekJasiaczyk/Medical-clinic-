namespace GUI_Management_of_medical_clinic
{
    partial class FormChangePasswordOfUser
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
            labelTitle = new Label();
            textBoxPasswordConfirm = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            label1 = new Label();
            buttonClose = new Button();
            buttonSaveUser = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(185, 30);
            labelTitle.TabIndex = 64;
            labelTitle.Text = "Change password";
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.Location = new Point(125, 113);
            textBoxPasswordConfirm.MaxLength = 11;
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.PasswordChar = '*';
            textBoxPasswordConfirm.Size = new Size(199, 23);
            textBoxPasswordConfirm.TabIndex = 68;
            textBoxPasswordConfirm.TextChanged += textBoxPasswordConfirm_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(125, 84);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 23);
            textBoxPassword.TabIndex = 67;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 66;
            label3.Text = "Confirm Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 65;
            label1.Text = "New password";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 193);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(140, 38);
            buttonClose.TabIndex = 70;
            buttonClose.Text = "Cancel";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSaveUser
            // 
            buttonSaveUser.Location = new Point(177, 193);
            buttonSaveUser.Name = "buttonSaveUser";
            buttonSaveUser.Size = new Size(147, 38);
            buttonSaveUser.TabIndex = 69;
            buttonSaveUser.Text = "Save";
            buttonSaveUser.UseVisualStyleBackColor = true;
            buttonSaveUser.Click += buttonSaveUser_Click;
            // 
            // FormChangePasswordOfUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 243);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveUser);
            Controls.Add(textBoxPasswordConfirm);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Name = "FormChangePasswordOfUser";
            Text = "FormChangePasswordOfUser";
            Load += FormChangePasswordOfUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxPasswordConfirm;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label1;
        private Button buttonClose;
        private Button buttonSaveUser;
    }
}