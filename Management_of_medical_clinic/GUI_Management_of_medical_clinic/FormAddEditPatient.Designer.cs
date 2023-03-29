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
            panel1 = new Panel();
            buttonEditPatient = new Button();
            buttonAddPatient = new Button();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            buttonEditEmployee = new Button();
            buttonAddEmployee = new Button();
            comboBoxSex = new ComboBox();
            labelAddEditNewPatient = new Label();
            maskedTextBoxDateLastVisit = new MaskedTextBox();
            labelDateLastVisit = new Label();
            comboBoxStatus = new ComboBox();
            labelStatus = new Label();
            labelSex = new Label();
            maskedTextBoxDateOfBirth = new MaskedTextBox();
            labelDateOfBirth = new Label();
            maskedTextBoxPESEL = new MaskedTextBox();
            labelPESEL = new Label();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            buttonCancel = new Button();
            buttonAddEditPatient = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonEditPatient);
            panel1.Controls.Add(buttonAddPatient);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonEditEmployee);
            panel1.Controls.Add(buttonAddEmployee);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 23;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.BackColor = Color.SteelBlue;
            buttonEditPatient.Location = new Point(61, 523);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(142, 45);
            buttonEditPatient.TabIndex = 24;
            buttonEditPatient.Text = "Edit patient";
            buttonEditPatient.UseVisualStyleBackColor = false;
            buttonEditPatient.Click += buttonEditPatient_Click;
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.BackColor = Color.SteelBlue;
            buttonAddPatient.Location = new Point(61, 466);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(142, 45);
            buttonAddPatient.TabIndex = 23;
            buttonAddPatient.Text = "Add patient";
            buttonAddPatient.UseVisualStyleBackColor = false;
            buttonAddPatient.Click += buttonAddPatient_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(29, 970);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(252, 66);
            buttonBack.TabIndex = 22;
            buttonBack.Text = "LOG OUT";
            buttonBack.UseVisualStyleBackColor = false;
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
            // buttonEditEmployee
            // 
            buttonEditEmployee.BackColor = Color.SteelBlue;
            buttonEditEmployee.FlatAppearance.BorderColor = Color.Black;
            buttonEditEmployee.FlatStyle = FlatStyle.Flat;
            buttonEditEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditEmployee.Location = new Point(-7, 347);
            buttonEditEmployee.Name = "buttonEditEmployee";
            buttonEditEmployee.Size = new Size(329, 87);
            buttonEditEmployee.TabIndex = 21;
            buttonEditEmployee.Text = "Edit Employee";
            buttonEditEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.BackColor = Color.SteelBlue;
            buttonAddEmployee.FlatAppearance.BorderColor = Color.Black;
            buttonAddEmployee.FlatStyle = FlatStyle.Flat;
            buttonAddEmployee.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddEmployee.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddEmployee.Location = new Point(-7, 254);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(319, 87);
            buttonAddEmployee.TabIndex = 15;
            buttonAddEmployee.Text = "Add new employee";
            buttonAddEmployee.UseVisualStyleBackColor = false;
            // 
            // comboBoxSex
            // 
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(781, 117);
            comboBoxSex.Margin = new Padding(3, 2, 3, 2);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(305, 23);
            comboBoxSex.TabIndex = 56;
            comboBoxSex.Visible = false;
            // 
            // labelAddEditNewPatient
            // 
            labelAddEditNewPatient.AutoSize = true;
            labelAddEditNewPatient.FlatStyle = FlatStyle.Flat;
            labelAddEditNewPatient.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddEditNewPatient.Location = new Point(365, 19);
            labelAddEditNewPatient.Name = "labelAddEditNewPatient";
            labelAddEditNewPatient.Size = new Size(230, 37);
            labelAddEditNewPatient.TabIndex = 55;
            labelAddEditNewPatient.Text = "Add new patient";
            labelAddEditNewPatient.Visible = false;
            // 
            // maskedTextBoxDateLastVisit
            // 
            maskedTextBoxDateLastVisit.Location = new Point(780, 314);
            maskedTextBoxDateLastVisit.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxDateLastVisit.Mask = "00/00/0000";
            maskedTextBoxDateLastVisit.Name = "maskedTextBoxDateLastVisit";
            maskedTextBoxDateLastVisit.Size = new Size(305, 23);
            maskedTextBoxDateLastVisit.TabIndex = 54;
            maskedTextBoxDateLastVisit.ValidatingType = typeof(DateTime);
            maskedTextBoxDateLastVisit.Visible = false;
            // 
            // labelDateLastVisit
            // 
            labelDateLastVisit.AutoSize = true;
            labelDateLastVisit.Location = new Point(780, 275);
            labelDateLastVisit.Name = "labelDateLastVisit";
            labelDateLastVisit.Size = new Size(79, 15);
            labelDateLastVisit.TabIndex = 53;
            labelDateLastVisit.Text = "Date last visit:";
            labelDateLastVisit.Visible = false;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(780, 208);
            comboBoxStatus.Margin = new Padding(3, 2, 3, 2);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(305, 23);
            comboBoxStatus.TabIndex = 52;
            comboBoxStatus.Visible = false;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(780, 183);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 51;
            labelStatus.Text = "Status:";
            labelStatus.Visible = false;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(780, 92);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(28, 15);
            labelSex.TabIndex = 50;
            labelSex.Text = "Sex:";
            labelSex.Visible = false;
            // 
            // maskedTextBoxDateOfBirth
            // 
            maskedTextBoxDateOfBirth.Location = new Point(365, 421);
            maskedTextBoxDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxDateOfBirth.Mask = "00/00/0000";
            maskedTextBoxDateOfBirth.Name = "maskedTextBoxDateOfBirth";
            maskedTextBoxDateOfBirth.Size = new Size(305, 23);
            maskedTextBoxDateOfBirth.TabIndex = 49;
            maskedTextBoxDateOfBirth.ValidatingType = typeof(DateTime);
            maskedTextBoxDateOfBirth.Visible = false;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(365, 382);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(76, 15);
            labelDateOfBirth.TabIndex = 48;
            labelDateOfBirth.Text = "Date of birth:";
            labelDateOfBirth.Visible = false;
            // 
            // maskedTextBoxPESEL
            // 
            maskedTextBoxPESEL.Location = new Point(366, 314);
            maskedTextBoxPESEL.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxPESEL.Mask = "00000000000";
            maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
            maskedTextBoxPESEL.Size = new Size(305, 23);
            maskedTextBoxPESEL.TabIndex = 47;
            maskedTextBoxPESEL.Visible = false;
            // 
            // labelPESEL
            // 
            labelPESEL.AutoSize = true;
            labelPESEL.Location = new Point(366, 275);
            labelPESEL.Name = "labelPESEL";
            labelPESEL.Size = new Size(41, 15);
            labelPESEL.TabIndex = 46;
            labelPESEL.Text = "PESEL:";
            labelPESEL.Visible = false;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(366, 183);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(64, 15);
            labelLastName.TabIndex = 45;
            labelLastName.Text = "Last name:";
            labelLastName.Visible = false;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(365, 208);
            textBoxLastName.Margin = new Padding(3, 2, 3, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(305, 23);
            textBoxLastName.TabIndex = 44;
            textBoxLastName.Visible = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(366, 92);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 43;
            labelName.Text = "Name:";
            labelName.Visible = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(365, 117);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(305, 23);
            textBoxName.TabIndex = 42;
            textBoxName.Visible = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.SteelBlue;
            buttonCancel.Location = new Point(634, 670);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(254, 57);
            buttonCancel.TabIndex = 60;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Visible = false;
            // 
            // buttonAddEditPatient
            // 
            buttonAddEditPatient.BackColor = Color.SteelBlue;
            buttonAddEditPatient.Location = new Point(366, 670);
            buttonAddEditPatient.Name = "buttonAddEditPatient";
            buttonAddEditPatient.Size = new Size(254, 57);
            buttonAddEditPatient.TabIndex = 59;
            buttonAddEditPatient.Text = "Add patient";
            buttonAddEditPatient.UseVisualStyleBackColor = false;
            buttonAddEditPatient.Visible = false;
            // 
            // FormAddEditPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1698, 825);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddEditPatient);
            Controls.Add(comboBoxSex);
            Controls.Add(labelAddEditNewPatient);
            Controls.Add(maskedTextBoxDateLastVisit);
            Controls.Add(labelDateLastVisit);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelStatus);
            Controls.Add(labelSex);
            Controls.Add(maskedTextBoxDateOfBirth);
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
            Load += FormAddEditPatient_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonAddPatient;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private Button buttonEditEmployee;
        private Button buttonAddEmployee;
        private ComboBox comboBoxSex;
        private Label labelAddEditNewPatient;
        private MaskedTextBox maskedTextBoxDateLastVisit;
        private Label labelDateLastVisit;
        private ComboBox comboBoxStatus;
        private Label labelStatus;
        private Label labelSex;
        private MaskedTextBox maskedTextBoxDateOfBirth;
        private Label labelDateOfBirth;
        private MaskedTextBox maskedTextBoxPESEL;
        private Label labelPESEL;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonEditPatient;
        private Button buttonCancel;
        private Button buttonAddEditPatient;
    }
}