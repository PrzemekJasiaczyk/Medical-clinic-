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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.textBoxActive = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Is it Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Username";
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(957, 560);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(147, 38);
            this.buttonEditUser.TabIndex = 44;
            this.buttonEditUser.Text = "Edit";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // textBoxActive
            // 
            this.textBoxActive.Location = new System.Drawing.Point(962, 496);
            this.textBoxActive.Name = "textBoxActive";
            this.textBoxActive.ReadOnly = true;
            this.textBoxActive.Size = new System.Drawing.Size(187, 23);
            this.textBoxActive.TabIndex = 36;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(962, 467);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(187, 23);
            this.textBoxRole.TabIndex = 35;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(962, 438);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(187, 23);
            this.textBoxUsername.TabIndex = 34;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(985, 307);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(107, 30);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "User view";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(882, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Id of User";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(945, 375);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.ReadOnly = true;
            this.textBoxUserId.Size = new System.Drawing.Size(59, 23);
            this.textBoxUserId.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1026, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Id of Employee";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(1118, 375);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.ReadOnly = true;
            this.textBoxEmployeeId.Size = new System.Drawing.Size(59, 23);
            this.textBoxEmployeeId.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 1081);
            this.panel2.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(24, 985);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(252, 66);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormUserDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.textBoxActive);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserDetailsView";
            this.Text = "FormUserDetailsView";
            this.Load += new System.EventHandler(this.FormUserDetailsView_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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