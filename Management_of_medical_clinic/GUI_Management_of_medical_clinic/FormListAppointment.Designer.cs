﻿namespace GUI_Management_of_medical_clinic
{
    partial class FormListAppointment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            buttonClearFilter = new Button();
            panel1 = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            dataGridViewAppointmentList = new DataGridView();
            ColumnPatient = new DataGridViewTextBoxColumn();
            ColumnPESEL = new DataGridViewTextBoxColumn();
            ColumnDoctor = new DataGridViewTextBoxColumn();
            ColumnSpecialization = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnOffice = new DataGridViewTextBoxColumn();
            ColumnCost = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxPESEL = new TextBox();
            dateTimePickerDateOfVisit = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboBoxDoctorSpecialization = new ComboBox();
            comboBoxSelectDoctorOrPatient = new ComboBox();
            label6 = new Label();
            buttonAddFiltr = new Button();
            buttonClearFiltr = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointmentList).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(482, 1311);
            buttonClearFilter.Margin = new Padding(3, 4, 3, 4);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(138, 31);
            buttonClearFilter.TabIndex = 28;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 1080);
            panel1.TabIndex = 29;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(50, 983);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 46;
            buttonExit.Text = "Back";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(90, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewAppointmentList
            // 
            dataGridViewAppointmentList.AllowUserToAddRows = false;
            dataGridViewAppointmentList.AllowUserToDeleteRows = false;
            dataGridViewAppointmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointmentList.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointmentList.Columns.AddRange(new DataGridViewColumn[] { ColumnPatient, ColumnPESEL, ColumnDoctor, ColumnSpecialization, ColumnDate, ColumnOffice, ColumnCost });
            dataGridViewAppointmentList.Location = new Point(357, 77);
            dataGridViewAppointmentList.Name = "dataGridViewAppointmentList";
            dataGridViewAppointmentList.ReadOnly = true;
            dataGridViewAppointmentList.RowHeadersVisible = false;
            dataGridViewAppointmentList.RowHeadersWidth = 51;
            dataGridViewAppointmentList.RowTemplate.Height = 29;
            dataGridViewAppointmentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointmentList.Size = new Size(1564, 1060);
            dataGridViewAppointmentList.TabIndex = 30;
            // 
            // ColumnPatient
            // 
            ColumnPatient.HeaderText = "Patient";
            ColumnPatient.Name = "ColumnPatient";
            ColumnPatient.ReadOnly = true;
            // 
            // ColumnPESEL
            // 
            ColumnPESEL.HeaderText = "PESEL";
            ColumnPESEL.Name = "ColumnPESEL";
            ColumnPESEL.ReadOnly = true;
            // 
            // ColumnDoctor
            // 
            ColumnDoctor.HeaderText = "Doctor";
            ColumnDoctor.Name = "ColumnDoctor";
            ColumnDoctor.ReadOnly = true;
            // 
            // ColumnSpecialization
            // 
            ColumnSpecialization.HeaderText = "Specialization";
            ColumnSpecialization.Name = "ColumnSpecialization";
            ColumnSpecialization.ReadOnly = true;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnOffice
            // 
            ColumnOffice.HeaderText = "Office";
            ColumnOffice.Name = "ColumnOffice";
            ColumnOffice.ReadOnly = true;
            // 
            // ColumnCost
            // 
            ColumnCost.HeaderText = "Cost";
            ColumnCost.Name = "ColumnCost";
            ColumnCost.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonClearFiltr);
            panel2.Controls.Add(buttonAddFiltr);
            panel2.Controls.Add(comboBoxSelectDoctorOrPatient);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBoxDoctorSpecialization);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePickerDateOfVisit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxPESEL);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxLastName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(357, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1567, 77);
            panel2.TabIndex = 31;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(246, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(178, 23);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 12);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Last name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(453, 33);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(178, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 12);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "PESEL";
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(660, 33);
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(178, 23);
            textBoxPESEL.TabIndex = 4;
            // 
            // dateTimePickerDateOfVisit
            // 
            dateTimePickerDateOfVisit.Format = DateTimePickerFormat.Short;
            dateTimePickerDateOfVisit.Location = new Point(867, 33);
            dateTimePickerDateOfVisit.Name = "dateTimePickerDateOfVisit";
            dateTimePickerDateOfVisit.Size = new Size(178, 23);
            dateTimePickerDateOfVisit.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(867, 12);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 7;
            label4.Text = "Date of the visit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1074, 12);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 8;
            label5.Text = "Doctor specialization";
            // 
            // comboBoxDoctorSpecialization
            // 
            comboBoxDoctorSpecialization.FormattingEnabled = true;
            comboBoxDoctorSpecialization.Location = new Point(1074, 33);
            comboBoxDoctorSpecialization.Name = "comboBoxDoctorSpecialization";
            comboBoxDoctorSpecialization.Size = new Size(178, 23);
            comboBoxDoctorSpecialization.TabIndex = 9;
            // 
            // comboBoxSelectDoctorOrPatient
            // 
            comboBoxSelectDoctorOrPatient.FormattingEnabled = true;
            comboBoxSelectDoctorOrPatient.Location = new Point(39, 33);
            comboBoxSelectDoctorOrPatient.Name = "comboBoxSelectDoctorOrPatient";
            comboBoxSelectDoctorOrPatient.Size = new Size(178, 23);
            comboBoxSelectDoctorOrPatient.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 12);
            label6.Name = "label6";
            label6.Size = new Size(147, 15);
            label6.TabIndex = 10;
            label6.Text = "Filtr name or last name by:";
            // 
            // buttonAddFiltr
            // 
            buttonAddFiltr.Location = new Point(1275, 33);
            buttonAddFiltr.Name = "buttonAddFiltr";
            buttonAddFiltr.Size = new Size(103, 23);
            buttonAddFiltr.TabIndex = 12;
            buttonAddFiltr.Text = "Add filtr";
            buttonAddFiltr.UseVisualStyleBackColor = true;
            // 
            // buttonClearFiltr
            // 
            buttonClearFiltr.Location = new Point(1384, 33);
            buttonClearFiltr.Name = "buttonClearFiltr";
            buttonClearFiltr.Size = new Size(117, 23);
            buttonClearFiltr.TabIndex = 13;
            buttonClearFiltr.Text = "Clear";
            buttonClearFiltr.UseVisualStyleBackColor = true;
            // 
            // FormListAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1055);
            Controls.Add(panel2);
            Controls.Add(dataGridViewAppointmentList);
            Controls.Add(buttonClearFilter);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPatientList";
            WindowState = FormWindowState.Maximized;
            Load += FormListAppointment_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointmentList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClearFilter;
        private Button buttonAddPatient;
        private Button buttonEditPatient;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewAppointmentList;
        private Button buttonDeactivatePatinet;
        private Button buttonActivatePatient;
        private Button buttonRemovePatient;
        private Panel panel2;
        private Button buttonExit;
        private Button button_ShowDetails;
        private Button buttonViewAppointments;
        private DataGridViewTextBoxColumn ColumnPatient;
        private DataGridViewTextBoxColumn ColumnPESEL;
        private DataGridViewTextBoxColumn ColumnDoctor;
        private DataGridViewTextBoxColumn ColumnSpecialization;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnOffice;
        private DataGridViewTextBoxColumn ColumnCost;
        private Label label3;
        private TextBox textBoxPESEL;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label1;
        private TextBox textBoxName;
        private Label label4;
        private DateTimePicker dateTimePickerDateOfVisit;
        private ComboBox comboBoxDoctorSpecialization;
        private Label label5;
        private Button buttonClearFiltr;
        private Button buttonAddFiltr;
        private ComboBox comboBoxSelectDoctorOrPatient;
        private Label label6;
    }
}