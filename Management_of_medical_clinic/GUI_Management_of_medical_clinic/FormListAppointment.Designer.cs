namespace GUI_Management_of_medical_clinic
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonClearFilter = new Button();
            panel1 = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            TextBox_PESEL = new MaskedTextBox();
            textBox1_Name = new TextBox();
            dataGridViewAppointmentList = new DataGridView();
            ColumnPatient = new DataGridViewTextBoxColumn();
            ColumnPESEL = new DataGridViewTextBoxColumn();
            ColumnDoctor = new DataGridViewTextBoxColumn();
            ColumnSpecialization = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnOffice = new DataGridViewTextBoxColumn();
            ColumnCost = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            buttonClearFilters = new Button();
            buttonShowFilters = new Button();
            pictureBoxSortDESC = new PictureBox();
            pictureBoxSortASC = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointmentList).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSortDESC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSortASC).BeginInit();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Bernard MT Condensed", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(929, 16);
            label4.Name = "label4";
            label4.Size = new Size(17, 18);
            label4.TabIndex = 42;
            label4.Text = "_";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(951, 19);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(98, 25);
            dateTimePicker2.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLight;
            dateTimePicker1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(820, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 25);
            dateTimePicker1.TabIndex = 39;
            // 
            // TextBox_PESEL
            // 
            TextBox_PESEL.BackColor = SystemColors.ButtonFace;
            TextBox_PESEL.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_PESEL.Location = new Point(474, 21);
            TextBox_PESEL.Name = "TextBox_PESEL";
            TextBox_PESEL.Size = new Size(129, 23);
            TextBox_PESEL.TabIndex = 38;
            // 
            // textBox1_Name
            // 
            textBox1_Name.BackColor = SystemColors.ButtonFace;
            textBox1_Name.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_Name.Location = new Point(169, 24);
            textBox1_Name.Name = "textBox1_Name";
            textBox1_Name.Size = new Size(129, 23);
            textBox1_Name.TabIndex = 37;
            // 
            // dataGridViewAppointmentList
            // 
            dataGridViewAppointmentList.AllowUserToAddRows = false;
            dataGridViewAppointmentList.AllowUserToDeleteRows = false;
            dataGridViewAppointmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointmentList.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            panel2.Controls.Add(buttonClearFilters);
            panel2.Controls.Add(buttonShowFilters);
            panel2.Controls.Add(pictureBoxSortDESC);
            panel2.Controls.Add(pictureBoxSortASC);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox1_Name);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TextBox_PESEL);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Location = new Point(357, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1567, 77);
            panel2.TabIndex = 31;
            // 
            // buttonClearFilters
            // 
            buttonClearFilters.BackColor = Color.Gainsboro;
            buttonClearFilters.FlatAppearance.BorderColor = Color.White;
            buttonClearFilters.FlatAppearance.BorderSize = 2;
            buttonClearFilters.FlatStyle = FlatStyle.Flat;
            buttonClearFilters.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearFilters.Location = new Point(1215, 20);
            buttonClearFilters.Name = "buttonClearFilters";
            buttonClearFilters.Size = new Size(86, 26);
            buttonClearFilters.TabIndex = 49;
            buttonClearFilters.Text = "Clear";
            buttonClearFilters.UseVisualStyleBackColor = false;
            // 
            // buttonShowFilters
            // 
            buttonShowFilters.BackColor = Color.Gainsboro;
            buttonShowFilters.FlatAppearance.BorderColor = Color.White;
            buttonShowFilters.FlatAppearance.BorderSize = 2;
            buttonShowFilters.FlatStyle = FlatStyle.Flat;
            buttonShowFilters.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowFilters.Location = new Point(1101, 20);
            buttonShowFilters.Margin = new Padding(3, 2, 3, 2);
            buttonShowFilters.Name = "buttonShowFilters";
            buttonShowFilters.Size = new Size(86, 26);
            buttonShowFilters.TabIndex = 48;
            buttonShowFilters.Text = "Show";
            buttonShowFilters.UseVisualStyleBackColor = false;
            // 
            // pictureBoxSortDESC
            // 
            pictureBoxSortDESC.Image = Properties.Resources.sort;
            pictureBoxSortDESC.Location = new Point(1486, 21);
            pictureBoxSortDESC.Name = "pictureBoxSortDESC";
            pictureBoxSortDESC.Size = new Size(38, 36);
            pictureBoxSortDESC.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSortDESC.TabIndex = 46;
            pictureBoxSortDESC.TabStop = false;
            pictureBoxSortDESC.Click += pictureBoxSortDESC_Click;
            // 
            // pictureBoxSortASC
            // 
            pictureBoxSortASC.Image = Properties.Resources.sort__1_;
            pictureBoxSortASC.Location = new Point(1438, 21);
            pictureBoxSortASC.Name = "pictureBoxSortASC";
            pictureBoxSortASC.Size = new Size(41, 36);
            pictureBoxSortASC.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSortASC.TabIndex = 45;
            pictureBoxSortASC.TabStop = false;
            pictureBoxSortASC.Click += pictureBoxSortASC_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(646, 23);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 2;
            label7.Text = "Date of the latest visit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(345, 22);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 1;
            label6.Text = "PESEL number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 0;
            label5.Text = "Name and Surname";
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxSortDESC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSortASC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClearFilter;
        private Button buttonAddPatient;
        private Button buttonEditPatient;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewAppointmentList;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox TextBox_PESEL;
        private TextBox textBox1_Name;
        private Button buttonDeactivatePatinet;
        private Button buttonActivatePatient;
        private Button buttonRemovePatient;
        private Panel panel2;
        private PictureBox pictureBoxSortDESC;
        private PictureBox pictureBoxSortASC;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buttonExit;
        private Button button_ShowDetails;
        private Button buttonClearFilters;
        private Button buttonShowFilters;
        private Button buttonViewAppointments;
        private DataGridViewTextBoxColumn ColumnPatient;
        private DataGridViewTextBoxColumn ColumnPESEL;
        private DataGridViewTextBoxColumn ColumnDoctor;
        private DataGridViewTextBoxColumn ColumnSpecialization;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnOffice;
        private DataGridViewTextBoxColumn ColumnCost;
    }
}