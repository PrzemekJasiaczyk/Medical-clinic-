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
            buttonEditUser = new Button();
            textBoxActive = new TextBox();
            textBoxRole = new TextBox();
            textBoxUsername = new TextBox();
            labelTitle = new Label();
            label4 = new Label();
            textBoxUserId = new TextBox();
            label5 = new Label();
            textBoxEmployeeId = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            buttonCancel = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(882, 499);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 48;
            label3.Text = "Is it Active";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(882, 470);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 47;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(882, 441);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 46;
            label1.Text = "Username";
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(957, 560);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(147, 38);
            buttonEditUser.TabIndex = 44;
            buttonEditUser.Text = "Edit";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // textBoxActive
            // 
            textBoxActive.Location = new Point(962, 496);
            textBoxActive.Name = "textBoxActive";
            textBoxActive.ReadOnly = true;
            textBoxActive.Size = new Size(187, 23);
            textBoxActive.TabIndex = 36;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(962, 467);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.ReadOnly = true;
            textBoxRole.Size = new Size(187, 23);
            textBoxRole.TabIndex = 35;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(962, 438);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Size = new Size(187, 23);
            textBoxUsername.TabIndex = 34;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(985, 307);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(107, 30);
            labelTitle.TabIndex = 49;
            labelTitle.Text = "User view";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(882, 378);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 51;
            label4.Text = "Id of User";
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(945, 375);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.ReadOnly = true;
            textBoxUserId.Size = new Size(59, 23);
            textBoxUserId.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1026, 378);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 53;
            label5.Text = "Id of Employee";
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(1118, 375);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.ReadOnly = true;
            textBoxEmployeeId.Size = new Size(59, 23);
            textBoxEmployeeId.TabIndex = 54;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonCancel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 61;
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
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(24, 985);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(252, 66);
            buttonCancel.TabIndex = 33;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonClose_Click;
            // 
            // FormUserDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxUserId);
            Controls.Add(labelTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEditUser);
            Controls.Add(textBoxActive);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUserDetailsView";
            Text = "FormUserDetailsView";
            Load += FormUserDetailsView_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonEditUser;
        private TextBox textBoxActive;
        private TextBox textBoxRole;
        private TextBox textBoxUsername;
        private Label labelTitle;
        private Label label4;
        private TextBox textBoxUserId;
        private Label label5;
        private TextBox textBoxEmployeeId;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonCancel;
    }
}