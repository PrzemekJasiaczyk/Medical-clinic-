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
            this.buttonOpenEmployeeList = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenUserList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.buttonOpenDoctorDashboard = new System.Windows.Forms.Button();
            this.buttonOpenCalendarsList = new System.Windows.Forms.Button();
            this.buttonOpenPatientsList = new System.Windows.Forms.Button();
            this.buttonOfficeList = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenEmployeeList
            // 
            buttonOpenEmployeeList.Anchor = AnchorStyles.None;
            buttonOpenEmployeeList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenEmployeeList.BackColor = Color.Gray;
            buttonOpenEmployeeList.Enabled = false;
            buttonOpenEmployeeList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenEmployeeList.FlatAppearance.BorderSize = 5;
            buttonOpenEmployeeList.FlatStyle = FlatStyle.Flat;
            buttonOpenEmployeeList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenEmployeeList.Location = new Point(147, 202);
            buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
            buttonOpenEmployeeList.Size = new Size(325, 125);
            buttonOpenEmployeeList.TabIndex = 2;
            buttonOpenEmployeeList.Text = "EMPLOYEE LIST";
            buttonOpenEmployeeList.UseVisualStyleBackColor = false;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.BackColor = Color.MintCream;
            textBoxLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.ForeColor = SystemColors.MenuText;
            textBoxLogin.Location = new Point(49, 45);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Login";
            textBoxLogin.Size = new Size(509, 42);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.MintCream;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.MenuText;
            textBoxPassword.Location = new Point(49, 111);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(509, 43);
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
            buttonExit.Click += buttonExit_Click_1;
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
            buttonOpenUserList.BackColor = Color.Gray;
            buttonOpenUserList.Enabled = false;
            buttonOpenUserList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenUserList.FlatAppearance.BorderSize = 5;
            buttonOpenUserList.FlatStyle = FlatStyle.Flat;
            buttonOpenUserList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenUserList.Location = new Point(147, 329);
            buttonOpenUserList.Name = "buttonOpenUserList";
            buttonOpenUserList.Size = new Size(325, 125);
            buttonOpenUserList.TabIndex = 8;
            buttonOpenUserList.Text = "USER LIST";
            buttonOpenUserList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(208, 171);
            label1.Name = "label1";
            label1.Size = new Size(194, 24);
            label1.TabIndex = 9;
            label1.Text = "Choose Log In Option";
            // 
            // panelLogIn
            // 
            panelLogIn.BackColor = SystemColors.ControlLight;
            panelLogIn.BorderStyle = BorderStyle.FixedSingle;
            panelLogIn.Controls.Add(buttonOpenDoctorDashboard);
            panelLogIn.Controls.Add(buttonOpenCalendarsList);
            panelLogIn.Controls.Add(buttonOpenPatientsList);
            panelLogIn.Controls.Add(buttonOfficeList);
            panelLogIn.Controls.Add(buttonOpenEmployeeList);
            panelLogIn.Controls.Add(label1);
            panelLogIn.Controls.Add(textBoxPassword);
            panelLogIn.Controls.Add(buttonOpenUserList);
            panelLogIn.Controls.Add(textBoxLogin);
            panelLogIn.Location = new Point(748, 223);
            panelLogIn.Name = "panelLogIn";
            panelLogIn.Size = new Size(598, 725);
            panelLogIn.TabIndex = 10;
            // 
            // buttonOpenDoctorDashboard
            // 
            buttonOpenDoctorDashboard.Anchor = AnchorStyles.None;
            buttonOpenDoctorDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenDoctorDashboard.BackColor = Color.Gray;
            buttonOpenDoctorDashboard.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenDoctorDashboard.FlatAppearance.BorderSize = 5;
            buttonOpenDoctorDashboard.FlatStyle = FlatStyle.Flat;
            buttonOpenDoctorDashboard.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenDoctorDashboard.Location = new Point(147, 654);
            buttonOpenDoctorDashboard.Name = "buttonOpenDoctorDashboard";
            buttonOpenDoctorDashboard.Size = new Size(325, 61);
            buttonOpenDoctorDashboard.TabIndex = 13;
            buttonOpenDoctorDashboard.Text = "DOCTOR DASHBOARD";
            buttonOpenDoctorDashboard.UseVisualStyleBackColor = false;
            buttonOpenDoctorDashboard.Click += buttonOpenDoctorDashboard_Click;
            // 
            // buttonOpenDoctorDashboard
            // 
            this.buttonOpenDoctorDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpenDoctorDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenDoctorDashboard.BackColor = System.Drawing.Color.Gray;
            this.buttonOpenDoctorDashboard.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOpenDoctorDashboard.FlatAppearance.BorderSize = 5;
            this.buttonOpenDoctorDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDoctorDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenDoctorDashboard.Location = new System.Drawing.Point(147, 654);
            this.buttonOpenDoctorDashboard.Name = "buttonOpenDoctorDashboard";
            this.buttonOpenDoctorDashboard.Size = new System.Drawing.Size(325, 61);
            this.buttonOpenDoctorDashboard.TabIndex = 13;
            this.buttonOpenDoctorDashboard.Text = "DOCTOR DASHBOARD";
            this.buttonOpenDoctorDashboard.UseVisualStyleBackColor = false;
            this.buttonOpenDoctorDashboard.Click += new System.EventHandler(this.buttonOpenDoctorDashboard_Click);
            // 
            // buttonOpenCalendarsList
            // 
            this.buttonOpenCalendarsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpenCalendarsList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenCalendarsList.BackColor = System.Drawing.Color.Gray;
            this.buttonOpenCalendarsList.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOpenCalendarsList.FlatAppearance.BorderSize = 5;
            this.buttonOpenCalendarsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCalendarsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenCalendarsList.Location = new System.Drawing.Point(147, 590);
            this.buttonOpenCalendarsList.Name = "buttonOpenCalendarsList";
            this.buttonOpenCalendarsList.Size = new System.Drawing.Size(325, 61);
            this.buttonOpenCalendarsList.TabIndex = 12;
            this.buttonOpenCalendarsList.Text = "CALENDARS LIST";
            this.buttonOpenCalendarsList.UseVisualStyleBackColor = false;
            this.buttonOpenCalendarsList.Click += new System.EventHandler(this.buttonOpenCalendarsList_Click_1);
            // 
            // buttonOpenPatientsList
            // 
            buttonOpenPatientsList.Anchor = AnchorStyles.None;
            buttonOpenPatientsList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOpenPatientsList.BackColor = Color.Gray;
            buttonOpenPatientsList.Enabled = false;
            buttonOpenPatientsList.FlatAppearance.BorderColor = Color.AntiqueWhite;
            buttonOpenPatientsList.FlatAppearance.BorderSize = 5;
            buttonOpenPatientsList.FlatStyle = FlatStyle.Flat;
            buttonOpenPatientsList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenPatientsList.Location = new Point(147, 524);
            buttonOpenPatientsList.Name = "buttonOpenPatientsList";
            buttonOpenPatientsList.Size = new Size(325, 61);
            buttonOpenPatientsList.TabIndex = 11;
            buttonOpenPatientsList.Text = "PATIENTS LIST";
            buttonOpenPatientsList.UseVisualStyleBackColor = false;
            // 
            // buttonOfficeList
            // 
            this.buttonOfficeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOfficeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOfficeList.BackColor = System.Drawing.Color.Gray;
            this.buttonOfficeList.Enabled = false;
            this.buttonOfficeList.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOfficeList.FlatAppearance.BorderSize = 5;
            this.buttonOfficeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOfficeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOfficeList.Location = new System.Drawing.Point(147, 459);
            this.buttonOfficeList.Name = "buttonOfficeList";
            this.buttonOfficeList.Size = new System.Drawing.Size(325, 61);
            this.buttonOfficeList.TabIndex = 10;
            this.buttonOfficeList.Text = "OFFICE LIST";
            this.buttonOfficeList.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Website_Headers_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelLogIn);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load_1;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogIn.ResumeLayout(false);
            panelLogIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenEmployeeList;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private Button buttonOpenUserList;
        private Label label1;
        private Panel panelLogIn;
        private Button buttonOfficeList;
        private Button buttonOpenPatientsList;
        private Button buttonOpenCalendarsList;
        private Button buttonOpenDoctorDashboard;
    }
}