namespace GUI_Management_of_medical_clinic
{
	partial class FormAddEditPatient
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
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			buttonBack = new Button();
			buttonAddEditPatient = new Button();
			pictureBox1 = new PictureBox();
			comboBoxSex = new ComboBox();
			labelAddEditNewPatient = new Label();
			labelSex = new Label();
			labelDateOfBirth = new Label();
			maskedTextBoxPESEL = new MaskedTextBox();
			labelPESEL = new Label();
			labelLastName = new Label();
			textBoxLastName = new TextBox();
			labelName = new Label();
			textBoxName = new TextBox();
			dateTimePickerBirthDate = new DateTimePicker();
			ErrorProviderFirstName = new ErrorProvider(components);
			ErrorProviderLastName = new ErrorProvider(components);
			ErrorProviderPESEL = new ErrorProvider(components);
			ErrorProviderBirthDate = new ErrorProvider(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderFirstName).BeginInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderLastName).BeginInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderPESEL).BeginInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderBirthDate).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.SteelBlue;
			panel1.Controls.Add(buttonBack);
			panel1.Controls.Add(buttonAddEditPatient);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(-3, 0);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(357, 1441);
			panel1.TabIndex = 23;
			// 
			// buttonBack
			// 
			buttonBack.BackColor = Color.Gainsboro;
			buttonBack.CausesValidation = false;
			buttonBack.FlatAppearance.BorderColor = Color.White;
			buttonBack.FlatAppearance.BorderSize = 2;
			buttonBack.FlatStyle = FlatStyle.Flat;
			buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
			buttonBack.Location = new Point(33, 1293);
			buttonBack.Margin = new Padding(3, 4, 3, 4);
			buttonBack.Name = "buttonBack";
			buttonBack.Size = new Size(288, 88);
			buttonBack.TabIndex = 22;
			buttonBack.Text = "Back";
			buttonBack.UseVisualStyleBackColor = false;
			buttonBack.Click += buttonBack_Click;
			// 
			// buttonAddEditPatient
			// 
			buttonAddEditPatient.BackColor = Color.SteelBlue;
			buttonAddEditPatient.FlatStyle = FlatStyle.Flat;
			buttonAddEditPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			buttonAddEditPatient.ForeColor = SystemColors.ActiveCaptionText;
			buttonAddEditPatient.Location = new Point(-33, 277);
			buttonAddEditPatient.Margin = new Padding(3, 4, 3, 4);
			buttonAddEditPatient.Name = "buttonAddEditPatient";
			buttonAddEditPatient.Size = new Size(411, 87);
			buttonAddEditPatient.TabIndex = 59;
			buttonAddEditPatient.Text = "Add patient";
			buttonAddEditPatient.UseVisualStyleBackColor = false;
			buttonAddEditPatient.Click += buttonAddEditPatient_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(70, 16);
			pictureBox1.Margin = new Padding(3, 4, 3, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(201, 224);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// comboBoxSex
			// 
			comboBoxSex.FormattingEnabled = true;
			comboBoxSex.Location = new Point(893, 156);
			comboBoxSex.Name = "comboBoxSex";
			comboBoxSex.Size = new Size(348, 28);
			comboBoxSex.TabIndex = 56;
			// 
			// labelAddEditNewPatient
			// 
			labelAddEditNewPatient.AutoSize = true;
			labelAddEditNewPatient.FlatStyle = FlatStyle.Flat;
			labelAddEditNewPatient.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
			labelAddEditNewPatient.Location = new Point(417, 25);
			labelAddEditNewPatient.Name = "labelAddEditNewPatient";
			labelAddEditNewPatient.Size = new Size(284, 46);
			labelAddEditNewPatient.TabIndex = 55;
			labelAddEditNewPatient.Text = "Add new patient";
			// 
			// labelSex
			// 
			labelSex.AutoSize = true;
			labelSex.Location = new Point(891, 123);
			labelSex.Name = "labelSex";
			labelSex.Size = new Size(35, 20);
			labelSex.TabIndex = 50;
			labelSex.Text = "Sex:";
			// 
			// labelDateOfBirth
			// 
			labelDateOfBirth.AutoSize = true;
			labelDateOfBirth.Location = new Point(891, 227);
			labelDateOfBirth.Name = "labelDateOfBirth";
			labelDateOfBirth.Size = new Size(97, 20);
			labelDateOfBirth.TabIndex = 48;
			labelDateOfBirth.Text = "Date of birth:";
			// 
			// maskedTextBoxPESEL
			// 
			maskedTextBoxPESEL.Location = new Point(418, 419);
			maskedTextBoxPESEL.Mask = "00000000000";
			maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
			maskedTextBoxPESEL.Size = new Size(348, 27);
			maskedTextBoxPESEL.TabIndex = 47;
			maskedTextBoxPESEL.Validating += maskedTextBoxPESEL_Validating;
			maskedTextBoxPESEL.Validated += maskedTextBoxPESEL_Validated;
			// 
			// labelPESEL
			// 
			labelPESEL.AutoSize = true;
			labelPESEL.Location = new Point(418, 367);
			labelPESEL.Name = "labelPESEL";
			labelPESEL.Size = new Size(51, 20);
			labelPESEL.TabIndex = 46;
			labelPESEL.Text = "PESEL:";
			// 
			// labelLastName
			// 
			labelLastName.AutoSize = true;
			labelLastName.Location = new Point(418, 244);
			labelLastName.Name = "labelLastName";
			labelLastName.Size = new Size(79, 20);
			labelLastName.TabIndex = 45;
			labelLastName.Text = "Last name:";
			// 
			// textBoxLastName
			// 
			textBoxLastName.Location = new Point(417, 277);
			textBoxLastName.Name = "textBoxLastName";
			textBoxLastName.Size = new Size(348, 27);
			textBoxLastName.TabIndex = 44;
			textBoxLastName.Validating += textBoxLastName_Validating;
			textBoxLastName.Validated += textBoxLastName_Validated;
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Location = new Point(418, 123);
			labelName.Name = "labelName";
			labelName.Size = new Size(52, 20);
			labelName.TabIndex = 43;
			labelName.Text = "Name:";
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(417, 156);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(348, 27);
			textBoxName.TabIndex = 42;
			textBoxName.Validating += textBoxName_Validating;
			textBoxName.Validated += textBoxName_Validated;
			// 
			// dateTimePickerBirthDate
			// 
			dateTimePickerBirthDate.Location = new Point(891, 277);
			dateTimePickerBirthDate.Margin = new Padding(3, 4, 3, 4);
			dateTimePickerBirthDate.MaxDate = new DateTime(2023, 4, 6, 0, 0, 0, 0);
			dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
			dateTimePickerBirthDate.Size = new Size(349, 27);
			dateTimePickerBirthDate.TabIndex = 57;
			dateTimePickerBirthDate.Value = new DateTime(2023, 4, 6, 0, 0, 0, 0);
			dateTimePickerBirthDate.Validating += dateTimePickerBirthDate_Validating;
			dateTimePickerBirthDate.Validated += dateTimePickerBirthDate_Validated;
			// 
			// ErrorProviderFirstName
			// 
			ErrorProviderFirstName.BlinkRate = 0;
			ErrorProviderFirstName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
			ErrorProviderFirstName.ContainerControl = this;
			// 
			// ErrorProviderLastName
			// 
			ErrorProviderLastName.BlinkRate = 0;
			ErrorProviderLastName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
			ErrorProviderLastName.ContainerControl = this;
			// 
			// ErrorProviderPESEL
			// 
			ErrorProviderPESEL.BlinkRate = 0;
			ErrorProviderPESEL.BlinkStyle = ErrorBlinkStyle.NeverBlink;
			ErrorProviderPESEL.ContainerControl = this;
			// 
			// ErrorProviderBirthDate
			// 
			ErrorProviderBirthDate.BlinkRate = 0;
			ErrorProviderBirthDate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
			ErrorProviderBirthDate.ContainerControl = this;
			// 
			// FormAddEditPatient
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1557, 884);
			Controls.Add(dateTimePickerBirthDate);
			Controls.Add(comboBoxSex);
			Controls.Add(labelAddEditNewPatient);
			Controls.Add(labelSex);
			Controls.Add(labelDateOfBirth);
			Controls.Add(maskedTextBoxPESEL);
			Controls.Add(labelPESEL);
			Controls.Add(labelLastName);
			Controls.Add(textBoxLastName);
			Controls.Add(labelName);
			Controls.Add(textBoxName);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormAddEditPatient";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormAddEditPatient";
			WindowState = FormWindowState.Maximized;
			FormClosing += FormAddEditPatient_FormClosing;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderFirstName).EndInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderLastName).EndInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderPESEL).EndInit();
			((System.ComponentModel.ISupportInitialize)ErrorProviderBirthDate).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button buttonBack;
		private PictureBox pictureBox1;
		private ComboBox comboBoxSex;
		private Label labelAddEditNewPatient;
		private Label labelSex;
		private Label labelDateOfBirth;
		private MaskedTextBox maskedTextBoxPESEL;
		private Label labelPESEL;
		private Label labelLastName;
		private TextBox textBoxLastName;
		private Label labelName;
		private TextBox textBoxName;
		private Button buttonAddEditPatient;
		private DateTimePicker dateTimePickerBirthDate;
		private ErrorProvider ErrorProviderFirstName;
		private ErrorProvider ErrorProviderLastName;
		private ErrorProvider ErrorProviderPESEL;
		private ErrorProvider ErrorProviderBirthDate;
	}
}