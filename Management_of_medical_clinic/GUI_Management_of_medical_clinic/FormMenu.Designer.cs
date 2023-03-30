namespace GUI_Management_of_medical_clinic
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOpenEmployeeList = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            buttonOpenUserList = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenEmployeeList
            // 
            buttonOpenEmployeeList.Anchor = AnchorStyles.None;
            buttonOpenEmployeeList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenEmployeeList.BackColor = Color.SteelBlue;
            buttonOpenEmployeeList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenEmployeeList.FlatAppearance.BorderSize = 5;
            buttonOpenEmployeeList.FlatStyle = FlatStyle.Flat;
            buttonOpenEmployeeList.Font = new Font("Tw Cen MT Condensed Extra Bold", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenEmployeeList.Location = new Point(912, 640);
            buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
            buttonOpenEmployeeList.Size = new Size(325, 125);
            buttonOpenEmployeeList.TabIndex = 2;
            buttonOpenEmployeeList.Text = "START";
            buttonOpenEmployeeList.UseVisualStyleBackColor = false;
            buttonOpenEmployeeList.Click += buttonOpenEmployeeList_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.BackColor = Color.MintCream;
            textBoxLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.ForeColor = SystemColors.MenuText;
            textBoxLogin.Location = new Point(799, 424);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Login";
            textBoxLogin.Size = new Size(531, 42);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.MintCream;
            textBoxPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.MenuText;
            textBoxPassword.Location = new Point(799, 517);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(531, 43);
            textBoxPassword.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonExit);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 7;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(29, 982);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
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
            // buttonOpenUserList
            // 
            buttonOpenUserList.Anchor = AnchorStyles.None;
            buttonOpenUserList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenUserList.BackColor = Color.SteelBlue;
            buttonOpenUserList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenUserList.FlatAppearance.BorderSize = 5;
            buttonOpenUserList.FlatStyle = FlatStyle.Flat;
            buttonOpenUserList.Font = new Font("Tw Cen MT Condensed Extra Bold", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenUserList.Location = new Point(912, 780);
            buttonOpenUserList.Name = "buttonOpenUserList";
            buttonOpenUserList.Size = new Size(325, 125);
            buttonOpenUserList.TabIndex = 8;
            buttonOpenUserList.Text = "USER LIST";
            buttonOpenUserList.UseVisualStyleBackColor = false;
            buttonOpenUserList.Click += buttonOpenUserList_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Website_Headers_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonOpenUserList);
            Controls.Add(panel2);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonOpenEmployeeList);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenEmployeeList;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private Button buttonOpenUserList;
    }
}