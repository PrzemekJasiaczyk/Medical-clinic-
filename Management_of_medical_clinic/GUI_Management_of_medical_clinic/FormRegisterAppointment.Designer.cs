namespace GUI_Management_of_medical_clinic
{
    partial class FormRegisterAppointment
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
            labelAvailableDates = new Label();
            labelDoctor = new Label();
            labelPatient = new Label();
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            comboBoxDate = new ComboBox();
            buttonAddAppointment = new Button();
            dataGridView_app_Patient = new DataGridView();
            dataGridView_app_doctor = new DataGridView();
            label6 = new Label();
            label3 = new Label();
            textBox1_Name = new TextBox();
            TextBox_PESEL = new MaskedTextBox();
            buttonShowFilters = new Button();
            button1 = new Button();
            label7 = new Label();
            textBox1_doctor = new TextBox();
            button2 = new Button();
            button3 = new Button();
            comboBoxDoctorSpecialization = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_app_Patient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_app_doctor).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.FlatStyle = FlatStyle.Flat;
            labelTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(368, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(351, 46);
            labelTitle.TabIndex = 67;
            labelTitle.Text = "Add an appointment";
            // 
            // labelAvailableDates
            // 
            labelAvailableDates.AutoSize = true;
            labelAvailableDates.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAvailableDates.Location = new Point(373, 495);
            labelAvailableDates.Name = "labelAvailableDates";
            labelAvailableDates.Size = new Size(148, 28);
            labelAvailableDates.TabIndex = 63;
            labelAvailableDates.Text = "Available dates:";
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDoctor.Location = new Point(372, 282);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(77, 28);
            labelDoctor.TabIndex = 62;
            labelDoctor.Text = "Doctor:";
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatient.Location = new Point(373, 82);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(76, 28);
            labelPatient.TabIndex = 60;
            labelPatient.Text = "Patient:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1102);
            panel1.TabIndex = 58;
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
            buttonBack.Text = "Cancel";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
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
            // comboBoxDate
            // 
            comboBoxDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(373, 543);
            comboBoxDate.Margin = new Padding(3, 2, 3, 2);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(453, 36);
            comboBoxDate.TabIndex = 72;
            comboBoxDate.SelectedIndexChanged += comboBoxDate_SelectedIndexChanged;
            comboBoxDate.SelectionChangeCommitted += comboBox3_SelectionChangeCommitted;
            // 
            // buttonAddAppointment
            // 
            buttonAddAppointment.BackColor = Color.Gainsboro;
            buttonAddAppointment.Enabled = false;
            buttonAddAppointment.FlatStyle = FlatStyle.Flat;
            buttonAddAppointment.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddAppointment.ForeColor = SystemColors.ControlText;
            buttonAddAppointment.Location = new Point(373, 970);
            buttonAddAppointment.Name = "buttonAddAppointment";
            buttonAddAppointment.Size = new Size(453, 65);
            buttonAddAppointment.TabIndex = 74;
            buttonAddAppointment.Text = "Add an appointment";
            buttonAddAppointment.UseVisualStyleBackColor = false;
            buttonAddAppointment.Click += buttonAddAppointment_Click;
            // 
            // dataGridView_app_Patient
            // 
            dataGridView_app_Patient.AllowUserToAddRows = false;
            dataGridView_app_Patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_app_Patient.Location = new Point(373, 154);
            dataGridView_app_Patient.Margin = new Padding(3, 2, 3, 2);
            dataGridView_app_Patient.Name = "dataGridView_app_Patient";
            dataGridView_app_Patient.RowHeadersWidth = 51;
            dataGridView_app_Patient.RowTemplate.Height = 29;
            dataGridView_app_Patient.Size = new Size(773, 87);
            dataGridView_app_Patient.TabIndex = 75;
            dataGridView_app_Patient.CellContentClick += dataGridView1_CellContentClick;
            dataGridView_app_Patient.CellValuePushed += dataGridView_app_Patient_CellValuePushed;
            dataGridView_app_Patient.SelectionChanged += dataGridView_app_Patient_SelectionChanged;
            // 
            // dataGridView_app_doctor
            // 
            dataGridView_app_doctor.AllowUserToAddRows = false;
            dataGridView_app_doctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_app_doctor.Location = new Point(373, 359);
            dataGridView_app_doctor.Name = "dataGridView_app_doctor";
            dataGridView_app_doctor.RowHeadersWidth = 51;
            dataGridView_app_doctor.RowTemplate.Height = 25;
            dataGridView_app_doctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_app_doctor.Size = new Size(773, 92);
            dataGridView_app_doctor.TabIndex = 76;
            dataGridView_app_doctor.SelectionChanged += dataGridView_app_doctor_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(677, 130);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 86;
            label6.Text = "PESEL number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(379, 130);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 85;
            label3.Text = "Name and Surname";
            // 
            // textBox1_Name
            // 
            textBox1_Name.BackColor = SystemColors.ButtonFace;
            textBox1_Name.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_Name.Location = new Point(530, 128);
            textBox1_Name.Name = "textBox1_Name";
            textBox1_Name.Size = new Size(129, 23);
            textBox1_Name.TabIndex = 87;
            // 
            // TextBox_PESEL
            // 
            TextBox_PESEL.BackColor = SystemColors.ButtonFace;
            TextBox_PESEL.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_PESEL.Location = new Point(806, 127);
            TextBox_PESEL.Name = "TextBox_PESEL";
            TextBox_PESEL.Size = new Size(129, 23);
            TextBox_PESEL.TabIndex = 88;
            // 
            // buttonShowFilters
            // 
            buttonShowFilters.BackColor = Color.Gainsboro;
            buttonShowFilters.FlatAppearance.BorderColor = Color.White;
            buttonShowFilters.FlatAppearance.BorderSize = 2;
            buttonShowFilters.FlatStyle = FlatStyle.Flat;
            buttonShowFilters.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowFilters.Location = new Point(961, 126);
            buttonShowFilters.Margin = new Padding(3, 2, 3, 2);
            buttonShowFilters.Name = "buttonShowFilters";
            buttonShowFilters.Size = new Size(86, 26);
            buttonShowFilters.TabIndex = 89;
            buttonShowFilters.Text = "Show";
            buttonShowFilters.UseVisualStyleBackColor = false;
            buttonShowFilters.Click += buttonShowFilters_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(962, 332);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 94;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(373, 332);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 90;
            label7.Text = "Name and Surname";
            // 
            // textBox1_doctor
            // 
            textBox1_doctor.BackColor = SystemColors.ButtonFace;
            textBox1_doctor.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_doctor.Location = new Point(524, 332);
            textBox1_doctor.Name = "textBox1_doctor";
            textBox1_doctor.Size = new Size(129, 23);
            textBox1_doctor.TabIndex = 92;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1053, 126);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 95;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1054, 332);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(86, 26);
            button3.TabIndex = 96;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBoxDoctorSpecialization
            // 
            comboBoxDoctorSpecialization.FormattingEnabled = true;
            comboBoxDoctorSpecialization.Location = new Point(822, 331);
            comboBoxDoctorSpecialization.Name = "comboBoxDoctorSpecialization";
            comboBoxDoctorSpecialization.Size = new Size(121, 23);
            comboBoxDoctorSpecialization.TabIndex = 97;
            comboBoxDoctorSpecialization.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(661, 332);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 98;
            label1.Text = "Doctor specialization";
            // 
            // FormRegisterAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1698, 825);
            Controls.Add(label1);
            Controls.Add(comboBoxDoctorSpecialization);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox1_doctor);
            Controls.Add(buttonShowFilters);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBox1_Name);
            Controls.Add(TextBox_PESEL);
            Controls.Add(dataGridView_app_doctor);
            Controls.Add(dataGridView_app_Patient);
            Controls.Add(buttonAddAppointment);
            Controls.Add(comboBoxDate);
            Controls.Add(labelTitle);
            Controls.Add(labelAvailableDates);
            Controls.Add(labelDoctor);
            Controls.Add(labelPatient);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegisterAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegisterAppointment";
            WindowState = FormWindowState.Maximized;
            Load += FormRegisterAppointment_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_app_Patient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_app_doctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelAvailableDates;
        private Label labelDoctor;
        private Label labelPatient;
        private Panel panel1;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private ComboBox comboBoxDate;
        internal Button buttonAddAppointment;
        private DataGridView dataGridView_app_Patient;
        private DataGridView dataGridView_app_doctor;
        private Label label6;
        private Label label3;
        private TextBox textBox1_Name;
        private MaskedTextBox TextBox_PESEL;
        private Button buttonShowFilters;
        private Button button1;
        private Label label7;
        private TextBox textBox1_doctor;
        private Button button2;
        private Button button3;
        private ComboBox comboBoxDoctorSpecialization;
        private Label label1;
    }
}