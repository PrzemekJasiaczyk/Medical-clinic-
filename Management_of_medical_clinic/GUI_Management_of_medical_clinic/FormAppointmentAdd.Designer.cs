namespace GUI_Management_of_medical_clinic
{
    partial class FormAppointmentAdd
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
            labelTerm = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonAdd = new Button();
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBoxTerm = new ComboBox();
            numericUpDownCost = new NumericUpDown();
            comboBoxCalendar = new ComboBox();
            comboBoxPatient = new ComboBox();
            comboBoxDoctor = new ComboBox();
            comboBoxOffice = new ComboBox();
            labelDay = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            SuspendLayout();
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTerm.Location = new Point(1056, 272);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(82, 37);
            labelTerm.TabIndex = 1;
            labelTerm.Text = "Term";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1056, 336);
            label2.Name = "label2";
            label2.Size = new Size(74, 37);
            label2.TabIndex = 2;
            label2.Text = "Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(610, 272);
            label4.Name = "label4";
            label4.Size = new Size(164, 37);
            label4.TabIndex = 4;
            label4.Text = "Calendar Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(610, 336);
            label6.Name = "label6";
            label6.Size = new Size(142, 37);
            label6.TabIndex = 6;
            label6.Text = "Patient Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(610, 401);
            label7.Name = "label7";
            label7.Size = new Size(139, 37);
            label7.TabIndex = 7;
            label7.Text = "Doctor Id";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gainsboro;
            buttonAdd.FlatAppearance.BorderColor = Color.White;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(918, 553);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(252, 66);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 40;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(28, 953);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(252, 66);
            buttonBack.TabIndex = 40;
            buttonBack.Text = "CANCEL";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(610, 468);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 42;
            label1.Text = "Office Id";
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.DropDownHeight = 200;
            comboBoxTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerm.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.IntegralHeight = false;
            comboBoxTerm.ItemHeight = 37;
            comboBoxTerm.Items.AddRange(new object[] { "07:00 ", "07:20", "07:40", "08:00", "08:20", "08:40", "09:00", "09:20", "09:40", "10:00, ", "10:20", "10:40", "11:20", "11:40", "12:00", "12:20", "12:40", "13:00", "13:20 ", "13:40", "14:00 ", "14:20 ", "14:40", "15:00 ", "15:40", "16:00", "16:20", "16:40 ", "17:00", "17:20", "17:40 ", "18:00", "18:20", "18:40", "19:00", "19:20", "19:40" });
            comboBoxTerm.Location = new Point(1172, 272);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(218, 45);
            comboBoxTerm.TabIndex = 15;
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.DecimalPlaces = 2;
            numericUpDownCost.Location = new Point(1172, 346);
            numericUpDownCost.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownCost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(218, 23);
            numericUpDownCost.TabIndex = 43;
            numericUpDownCost.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // comboBoxCalendar
            // 
            comboBoxCalendar.FormattingEnabled = true;
            comboBoxCalendar.Location = new Point(780, 282);
            comboBoxCalendar.Name = "comboBoxCalendar";
            comboBoxCalendar.Size = new Size(218, 23);
            comboBoxCalendar.TabIndex = 44;
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.FormattingEnabled = true;
            comboBoxPatient.Location = new Point(780, 347);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(218, 23);
            comboBoxPatient.TabIndex = 45;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(780, 412);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(218, 23);
            comboBoxDoctor.TabIndex = 46;
            // 
            // comboBoxOffice
            // 
            comboBoxOffice.FormattingEnabled = true;
            comboBoxOffice.Location = new Point(780, 478);
            comboBoxOffice.Name = "comboBoxOffice";
            comboBoxOffice.Size = new Size(218, 23);
            comboBoxOffice.TabIndex = 47;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDay.Location = new Point(610, 143);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(190, 37);
            labelDay.TabIndex = 48;
            labelDay.Text = "Selected Day:";
            // 
            // FormAppointmentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(labelDay);
            Controls.Add(comboBoxOffice);
            Controls.Add(comboBoxDoctor);
            Controls.Add(comboBoxPatient);
            Controls.Add(comboBoxCalendar);
            Controls.Add(numericUpDownCost);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(comboBoxTerm);
            Controls.Add(buttonAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelTerm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAppointmentAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAppointmentAdd";
            WindowState = FormWindowState.Maximized;
            Load += FormAppointmentAdd_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTerm;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button buttonAdd;
        private Panel panel1;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBoxTerm;
        private NumericUpDown numericUpDownCost;
        private ComboBox comboBoxCalendar;
        private ComboBox comboBoxPatient;
        private ComboBox comboBoxDoctor;
        private ComboBox comboBoxOffice;
        private Label labelDay;
    }
}