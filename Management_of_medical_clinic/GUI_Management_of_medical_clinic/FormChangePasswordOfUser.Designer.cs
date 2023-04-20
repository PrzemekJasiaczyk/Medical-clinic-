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
            buttonSaveUser = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            buttonCancel = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(970, 306);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(293, 45);
            labelTitle.TabIndex = 64;
            labelTitle.Text = "Change password";
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordConfirm.Location = new Point(1149, 432);
            textBoxPasswordConfirm.MaxLength = 11;
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.PasswordChar = '*';
            textBoxPasswordConfirm.Size = new Size(199, 41);
            textBoxPasswordConfirm.TabIndex = 68;
            textBoxPasswordConfirm.TextChanged += textBoxPasswordConfirm_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(1149, 385);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 41);
            textBoxPassword.TabIndex = 67;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(916, 435);
            label3.Name = "label3";
            label3.Size = new Size(227, 35);
            label3.TabIndex = 66;
            label3.Text = "Confirm Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(916, 388);
            label1.Name = "label1";
            label1.Size = new Size(187, 35);
            label1.TabIndex = 65;
            label1.Text = "New password";
            // 
            // buttonSaveUser
            // 
            buttonSaveUser.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveUser.Location = new Point(1015, 508);
            buttonSaveUser.Name = "buttonSaveUser";
            buttonSaveUser.Size = new Size(220, 60);
            buttonSaveUser.TabIndex = 69;
            buttonSaveUser.Text = "Save";
            buttonSaveUser.UseVisualStyleBackColor = true;
            buttonSaveUser.Click += buttonSaveUser_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonCancel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 71;
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
            // FormChangePasswordOfUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(buttonSaveUser);
            Controls.Add(textBoxPasswordConfirm);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChangePasswordOfUser";
            Text = "FormChangePasswordOfUser";
            Load += FormChangePasswordOfUser_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxPasswordConfirm;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label1;
        private Button buttonSaveUser;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonCancel;
    }
}