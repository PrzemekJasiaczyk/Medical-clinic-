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
			label1 = new Label();
			panelLogIn = new Panel();
			buttonOpenPatientList = new Button();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panelLogIn.SuspendLayout();
			SuspendLayout();
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
			buttonOpenEmployeeList.Location = new Point(155, 323);
			buttonOpenEmployeeList.Margin = new Padding(3, 4, 3, 4);
			buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
			buttonOpenEmployeeList.Size = new Size(371, 167);
			buttonOpenEmployeeList.TabIndex = 2;
			buttonOpenEmployeeList.Text = "EMPLOYEE LIST";
			buttonOpenEmployeeList.UseVisualStyleBackColor = false;
			buttonOpenEmployeeList.Click += buttonOpenEmployeeList_Click;
			// 
			// textBoxLogin
			// 
			textBoxLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBoxLogin.BackColor = Color.MintCream;
			textBoxLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxLogin.ForeColor = SystemColors.MenuText;
			textBoxLogin.Location = new Point(56, 134);
			textBoxLogin.Margin = new Padding(3, 4, 3, 4);
			textBoxLogin.Multiline = true;
			textBoxLogin.Name = "textBoxLogin";
			textBoxLogin.PlaceholderText = "Login";
			textBoxLogin.Size = new Size(581, 55);
			textBoxLogin.TabIndex = 4;
			textBoxLogin.TextChanged += textBoxLogin_TextChanged;
			// 
			// textBoxPassword
			// 
			textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBoxPassword.BackColor = Color.MintCream;
			textBoxPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxPassword.ForeColor = SystemColors.MenuText;
			textBoxPassword.Location = new Point(56, 198);
			textBoxPassword.Margin = new Padding(3, 4, 3, 4);
			textBoxPassword.Multiline = true;
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.PasswordChar = '*';
			textBoxPassword.PlaceholderText = "Password";
			textBoxPassword.Size = new Size(581, 56);
			textBoxPassword.TabIndex = 5;
			textBoxPassword.TextChanged += textBoxPassword_TextChanged;
			// 
			// panel2
			// 
			panel2.BackColor = Color.SteelBlue;
			panel2.Controls.Add(buttonExit);
			panel2.Controls.Add(pictureBox1);
			panel2.Location = new Point(0, -3);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(357, 1441);
			panel2.TabIndex = 7;
			// 
			// buttonExit
			// 
			buttonExit.BackColor = Color.Gainsboro;
			buttonExit.FlatAppearance.BorderColor = Color.White;
			buttonExit.FlatAppearance.BorderSize = 2;
			buttonExit.FlatStyle = FlatStyle.Flat;
			buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(33, 1309);
			buttonExit.Margin = new Padding(3, 4, 3, 4);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(288, 88);
			buttonExit.TabIndex = 3;
			buttonExit.Text = "EXIT";
			buttonExit.UseVisualStyleBackColor = false;
			buttonExit.Click += buttonExit_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(70, 16);
			pictureBox1.Margin = new Padding(3, 4, 3, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(201, 224);
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
			buttonOpenUserList.Location = new Point(155, 498);
			buttonOpenUserList.Margin = new Padding(3, 4, 3, 4);
			buttonOpenUserList.Name = "buttonOpenUserList";
			buttonOpenUserList.Size = new Size(371, 167);
			buttonOpenUserList.TabIndex = 8;
			buttonOpenUserList.Text = "USER LIST";
			buttonOpenUserList.UseVisualStyleBackColor = false;
			buttonOpenUserList.Click += buttonOpenUserList_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(217, 279);
			label1.Name = "label1";
			label1.Size = new Size(247, 29);
			label1.TabIndex = 9;
			label1.Text = "Choose Log In Option";
			// 
			// panelLogIn
			// 
			panelLogIn.BackColor = SystemColors.ControlLight;
			panelLogIn.BorderStyle = BorderStyle.FixedSingle;
			panelLogIn.Controls.Add(buttonOpenPatientList);
			panelLogIn.Controls.Add(buttonOpenEmployeeList);
			panelLogIn.Controls.Add(label1);
			panelLogIn.Controls.Add(textBoxPassword);
			panelLogIn.Controls.Add(buttonOpenUserList);
			panelLogIn.Controls.Add(textBoxLogin);
			panelLogIn.Location = new Point(861, 225);
			panelLogIn.Margin = new Padding(3, 4, 3, 4);
			panelLogIn.Name = "panelLogIn";
			panelLogIn.Size = new Size(683, 864);
			panelLogIn.TabIndex = 10;
			// 
			// buttonOpenPatientList
			// 
			buttonOpenPatientList.Anchor = AnchorStyles.None;
			buttonOpenPatientList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			buttonOpenPatientList.BackColor = Color.Gray;
			buttonOpenPatientList.Enabled = false;
			buttonOpenPatientList.FlatAppearance.BorderColor = Color.AntiqueWhite;
			buttonOpenPatientList.FlatAppearance.BorderSize = 5;
			buttonOpenPatientList.FlatStyle = FlatStyle.Flat;
			buttonOpenPatientList.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOpenPatientList.Location = new Point(155, 673);
			buttonOpenPatientList.Margin = new Padding(3, 4, 3, 4);
			buttonOpenPatientList.Name = "buttonOpenPatientList";
			buttonOpenPatientList.Size = new Size(371, 167);
			buttonOpenPatientList.TabIndex = 10;
			buttonOpenPatientList.Text = "PATIENT LIST";
			buttonOpenPatientList.UseVisualStyleBackColor = false;
			buttonOpenPatientList.Click += buttonOpenPatientList_Click;
			// 
			// FormMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Website_Headers_5;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1942, 1102);
			Controls.Add(panelLogIn);
			Controls.Add(panel2);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			WindowState = FormWindowState.Maximized;
			Load += FormMenu_Load;
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
		private Button buttonOpenPatientList;
	}
}