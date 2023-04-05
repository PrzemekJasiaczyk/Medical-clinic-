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
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
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
            panel1.Controls.Add(buttonBack);
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
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(33, 1293);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(288, 88);
            buttonBack.TabIndex = 22;
            buttonBack.Text = "LOG OUT";
            buttonBack.UseVisualStyleBackColor = false;
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
            // maskedTextBoxDateLastVisit
            // 
            maskedTextBoxDateLastVisit.Location = new Point(892, 418);
            maskedTextBoxDateLastVisit.Mask = "00/00/0000";
            maskedTextBoxDateLastVisit.Name = "maskedTextBoxDateLastVisit";
            maskedTextBoxDateLastVisit.Size = new Size(348, 27);
            maskedTextBoxDateLastVisit.TabIndex = 54;
            maskedTextBoxDateLastVisit.ValidatingType = typeof(DateTime);
            maskedTextBoxDateLastVisit.Visible = false;
            // 
            // labelDateLastVisit
            // 
            labelDateLastVisit.AutoSize = true;
            labelDateLastVisit.Location = new Point(892, 367);
            labelDateLastVisit.Name = "labelDateLastVisit";
            labelDateLastVisit.Size = new Size(101, 20);
            labelDateLastVisit.TabIndex = 53;
            labelDateLastVisit.Text = "Date last visit:";
            labelDateLastVisit.Visible = false;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(892, 278);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(348, 28);
            comboBoxStatus.TabIndex = 52;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(892, 244);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 51;
            labelStatus.Text = "Status:";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(892, 122);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(35, 20);
            labelSex.TabIndex = 50;
            labelSex.Text = "Sex:";
            // 
            // maskedTextBoxDateOfBirth
            // 
            maskedTextBoxDateOfBirth.Location = new Point(417, 561);
            maskedTextBoxDateOfBirth.Mask = "00/00/0000";
            maskedTextBoxDateOfBirth.Name = "maskedTextBoxDateOfBirth";
            maskedTextBoxDateOfBirth.Size = new Size(348, 27);
            maskedTextBoxDateOfBirth.TabIndex = 49;
            maskedTextBoxDateOfBirth.ValidatingType = typeof(DateTime);
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(417, 510);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(97, 20);
            labelDateOfBirth.TabIndex = 48;
            labelDateOfBirth.Text = "Date of birth:";
            // 
            // maskedTextBoxPESEL
            // 
            maskedTextBoxPESEL.Location = new Point(418, 418);
            maskedTextBoxPESEL.Mask = "00000000000";
            maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
            maskedTextBoxPESEL.Size = new Size(348, 27);
            maskedTextBoxPESEL.TabIndex = 47;
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
            textBoxLastName.Location = new Point(417, 278);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(348, 27);
            textBoxLastName.TabIndex = 44;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(418, 122);
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
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.SteelBlue;
            buttonCancel.Location = new Point(725, 893);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(290, 76);
            buttonCancel.TabIndex = 60;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddEditPatient
            // 
            buttonAddEditPatient.BackColor = Color.SteelBlue;
            buttonAddEditPatient.Location = new Point(418, 893);
            buttonAddEditPatient.Margin = new Padding(3, 4, 3, 4);
            buttonAddEditPatient.Name = "buttonAddEditPatient";
            buttonAddEditPatient.Size = new Size(290, 76);
            buttonAddEditPatient.TabIndex = 59;
            buttonAddEditPatient.Text = "Add patient";
            buttonAddEditPatient.UseVisualStyleBackColor = false;
            // 
            // FormAddEditPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1942, 1102);
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
            Name = "FormAddEditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddEditPatient";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormAddEditPatient_FormClosing;
            Load += FormAddEditPatient_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonBack;
        private PictureBox pictureBox1;
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
        private Button buttonCancel;
        private Button buttonAddEditPatient;
    }
}