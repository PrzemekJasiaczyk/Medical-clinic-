namespace GUI_Management_of_medical_clinic
{
    partial class FormUserDetailsView
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonClose = new Button();
            buttonEditUser = new Button();
            textBoxActive = new TextBox();
            textBoxRole = new TextBox();
            textBoxUsername = new TextBox();
            labelTitle = new Label();
            label4 = new Label();
            textBoxUserId = new TextBox();
            label5 = new Label();
            textBoxEmployeeId = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 48;
            label3.Text = "Is it Active";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 47;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 46;
            label1.Text = "Username";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 224);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(140, 38);
            buttonClose.TabIndex = 45;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(160, 224);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(147, 38);
            buttonEditUser.TabIndex = 44;
            buttonEditUser.Text = "Edit";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // textBoxActive
            // 
            textBoxActive.Location = new Point(92, 181);
            textBoxActive.Name = "textBoxActive";
            textBoxActive.ReadOnly = true;
            textBoxActive.Size = new Size(187, 23);
            textBoxActive.TabIndex = 36;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(92, 152);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.ReadOnly = true;
            textBoxRole.Size = new Size(187, 23);
            textBoxRole.TabIndex = 35;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(92, 123);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Size = new Size(187, 23);
            textBoxUsername.TabIndex = 34;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(107, 30);
            labelTitle.TabIndex = 49;
            labelTitle.Text = "User view";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 51;
            label4.Text = "Id of User";
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(75, 60);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.ReadOnly = true;
            textBoxUserId.Size = new Size(59, 23);
            textBoxUserId.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 63);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 53;
            label5.Text = "Id of Employee";
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(248, 60);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.ReadOnly = true;
            textBoxEmployeeId.Size = new Size(59, 23);
            textBoxEmployeeId.TabIndex = 54;
            // 
            // FormUserDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 283);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxUserId);
            Controls.Add(labelTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Controls.Add(buttonEditUser);
            Controls.Add(textBoxActive);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxUsername);
            Name = "FormUserDetailsView";
            Text = "FormUserDetailsView";
            Load += FormUserDetailsView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonClose;
        private Button buttonEditUser;
        private TextBox textBoxActive;
        private TextBox textBoxRole;
        private TextBox textBoxUsername;
        private Label labelTitle;
        private Label label4;
        private TextBox textBoxUserId;
        private Label label5;
        private TextBox textBoxEmployeeId;
    }
}