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
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
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
            buttonBack.Location = new Point(29, 970);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(252, 66);
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
            buttonAddEditPatient.Location = new Point(-29, 208);
            buttonAddEditPatient.Name = "buttonAddEditPatient";
            buttonAddEditPatient.Size = new Size(360, 65);
            buttonAddEditPatient.TabIndex = 59;
            buttonAddEditPatient.Text = "Add patient";
            buttonAddEditPatient.UseVisualStyleBackColor = false;
            buttonAddEditPatient.Click += buttonAddEditPatient_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBoxSex
            // 
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(781, 117);
            comboBoxSex.Margin = new Padding(3, 2, 3, 2);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(305, 23);
            comboBoxSex.TabIndex = 56;
            comboBoxSex.SelectedValueChanged += comboBoxSex_SelectedValueChanged;
            // 
            // labelAddEditNewPatient
            // 
            labelAddEditNewPatient.AutoSize = true;
            labelAddEditNewPatient.FlatStyle = FlatStyle.Flat;
            labelAddEditNewPatient.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddEditNewPatient.Location = new Point(365, 19);
            labelAddEditNewPatient.Name = "labelAddEditNewPatient";
            labelAddEditNewPatient.Size = new Size(284, 46);
            labelAddEditNewPatient.TabIndex = 55;
            labelAddEditNewPatient.Text = "Add new patient";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(780, 92);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(28, 15);
            labelSex.TabIndex = 50;
            labelSex.Text = "Sex:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(780, 170);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(76, 15);
            labelDateOfBirth.TabIndex = 48;
            labelDateOfBirth.Text = "Date of birth:";
            // 
            // maskedTextBoxPESEL
            // 
            maskedTextBoxPESEL.Location = new Point(366, 314);
            maskedTextBoxPESEL.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxPESEL.Mask = "00000000000";
            maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
            maskedTextBoxPESEL.Size = new Size(305, 23);
            maskedTextBoxPESEL.TabIndex = 47;
            maskedTextBoxPESEL.Validating += maskedTextBoxPESEL_Validating;
            maskedTextBoxPESEL.Validated += maskedTextBoxPESEL_Validated;
            // 
            // labelPESEL
            // 
            labelPESEL.AutoSize = true;
            labelPESEL.Location = new Point(366, 275);
            labelPESEL.Name = "labelPESEL";
            labelPESEL.Size = new Size(41, 15);
            labelPESEL.TabIndex = 46;
            labelPESEL.Text = "PESEL:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(366, 183);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(64, 15);
            labelLastName.TabIndex = 45;
            labelLastName.Text = "Last name:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(365, 208);
            textBoxLastName.Margin = new Padding(3, 2, 3, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(305, 23);
            textBoxLastName.TabIndex = 44;
            textBoxLastName.Validating += textBoxLastName_Validating;
            textBoxLastName.Validated += textBoxLastName_Validated;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(366, 92);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 43;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(365, 117);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(305, 23);
            textBoxName.TabIndex = 42;
            textBoxName.Validating += textBoxName_Validating;
            textBoxName.Validated += textBoxName_Validated;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(780, 208);
            dateTimePickerBirthDate.MaxDate = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(306, 23);
            dateTimePickerBirthDate.TabIndex = 57;
            dateTimePickerBirthDate.Value = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            dateTimePickerBirthDate.ValueChanged += dateTimePickerBirthDate_ValueChanged;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 663);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddEditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddEditPatient";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormAddEditPatient_FormClosing;
            Load += FormAddEditPatient_Load;
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
        private DateTimePicker dateTimePickerBirthDate;
        private ErrorProvider ErrorProviderFirstName;
        private ErrorProvider ErrorProviderLastName;
        private ErrorProvider ErrorProviderPESEL;
        private ErrorProvider ErrorProviderBirthDate;
        internal Button buttonAddEditPatient;
    }
}