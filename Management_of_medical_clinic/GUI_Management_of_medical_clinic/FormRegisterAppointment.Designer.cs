﻿namespace GUI_Management_of_medical_clinic
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
            comboBoxPatient = new ComboBox();
            comboBoxDate = new ComboBox();
            comboBoxDoctor = new ComboBox();
            buttonAddAppointment = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            labelAvailableDates.Location = new Point(373, 400);
            labelAvailableDates.Name = "labelAvailableDates";
            labelAvailableDates.Size = new Size(148, 28);
            labelAvailableDates.TabIndex = 63;
            labelAvailableDates.Text = "Available dates:";
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDoctor.Location = new Point(373, 250);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(77, 28);
            labelDoctor.TabIndex = 62;
            labelDoctor.Text = "Doctor:";
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatient.Location = new Point(373, 100);
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
            // comboBoxPatient
            // 
            comboBoxPatient.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatient.FormattingEnabled = true;
            comboBoxPatient.Location = new Point(373, 148);
            comboBoxPatient.Margin = new Padding(3, 2, 3, 2);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(453, 36);
            comboBoxPatient.TabIndex = 71;
            comboBoxPatient.SelectedIndexChanged += comboBoxPatient_SelectedIndexChanged;
            comboBoxPatient.SelectionChangeCommitted += comboBoxPatient_SelectionChangeCommitted;
            // 
            // comboBoxDate
            // 
            comboBoxDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(373, 448);
            comboBoxDate.Margin = new Padding(3, 2, 3, 2);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(453, 36);
            comboBoxDate.TabIndex = 72;
            comboBoxDate.SelectedIndexChanged += comboBoxDate_SelectedIndexChanged;
            comboBoxDate.SelectionChangeCommitted += comboBox3_SelectionChangeCommitted;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(373, 298);
            comboBoxDoctor.Margin = new Padding(3, 2, 3, 2);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(453, 36);
            comboBoxDoctor.TabIndex = 73;
            comboBoxDoctor.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            comboBoxDoctor.SelectionChangeCommitted += comboBoxDoctor_SelectionChangeCommitted;
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
            // FormRegisterAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(buttonAddAppointment);
            Controls.Add(comboBoxDoctor);
            Controls.Add(comboBoxDate);
            Controls.Add(comboBoxPatient);
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
        private ComboBox comboBoxPatient;
        private ComboBox comboBoxDate;
        private ComboBox comboBoxDoctor;
        internal Button buttonAddAppointment;
    }
}