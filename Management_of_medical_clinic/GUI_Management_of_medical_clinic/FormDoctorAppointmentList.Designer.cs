namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorAppointmentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonShowDetails = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewAppointmentList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.checkBoxDateOfVisit = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxPESEL = new System.Windows.Forms.MaskedTextBox();
            this.buttonClearFiltr = new System.Windows.Forms.Button();
            this.buttonAddFiltr = new System.Windows.Forms.Button();
            this.dateTimePickerDateOfVisit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(482, 1311);
            this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(138, 31);
            this.buttonClearFilter.TabIndex = 28;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonShowDetails);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 1080);
            this.panel1.TabIndex = 29;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.Location = new System.Drawing.Point(-1, 346);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(360, 65);
            this.buttonRemove.TabIndex = 48;
            this.buttonRemove.Text = "Cancel appointment";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonShowDetails
            // 
            this.buttonShowDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonShowDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowDetails.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShowDetails.Location = new System.Drawing.Point(-1, 273);
            this.buttonShowDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowDetails.Name = "buttonShowDetails";
            this.buttonShowDetails.Size = new System.Drawing.Size(360, 65);
            this.buttonShowDetails.TabIndex = 47;
            this.buttonShowDetails.Text = "[Show details]";
            this.buttonShowDetails.UseVisualStyleBackColor = false;
            this.buttonShowDetails.Click += new System.EventHandler(this.buttonShowDetails_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(50, 983);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(252, 66);
            this.buttonExit.TabIndex = 46;
            this.buttonExit.Text = "Cancel";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(90, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewAppointmentList
            // 
            this.dataGridViewAppointmentList.AllowUserToAddRows = false;
            this.dataGridViewAppointmentList.AllowUserToDeleteRows = false;
            this.dataGridViewAppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointmentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColumnPatient,
            this.Columnfirstname,
            this.ColumnPESEL,
            this.ColumnDate,
            this.ColumnHour,
            this.ColumnOffice,
            this.ColumnCost});
            this.dataGridViewAppointmentList.Location = new System.Drawing.Point(357, 84);
            this.dataGridViewAppointmentList.MultiSelect = false;
            this.dataGridViewAppointmentList.Name = "dataGridViewAppointmentList";
            this.dataGridViewAppointmentList.ReadOnly = true;
            this.dataGridViewAppointmentList.RowHeadersVisible = false;
            this.dataGridViewAppointmentList.RowHeadersWidth = 51;
            this.dataGridViewAppointmentList.RowTemplate.Height = 29;
            this.dataGridViewAppointmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointmentList.Size = new System.Drawing.Size(1564, 1053);
            this.dataGridViewAppointmentList.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdVisit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // ColumnPatient
            // 
            this.ColumnPatient.HeaderText = "Last name";
            this.ColumnPatient.Name = "ColumnPatient";
            this.ColumnPatient.ReadOnly = true;
            // 
            // Columnfirstname
            // 
            this.Columnfirstname.HeaderText = "First Name";
            this.Columnfirstname.Name = "Columnfirstname";
            this.Columnfirstname.ReadOnly = true;
            // 
            // ColumnPESEL
            // 
            this.ColumnPESEL.HeaderText = "PESEL";
            this.ColumnPESEL.Name = "ColumnPESEL";
            this.ColumnPESEL.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnHour
            // 
            this.ColumnHour.HeaderText = "Hour";
            this.ColumnHour.Name = "ColumnHour";
            this.ColumnHour.ReadOnly = true;
            // 
            // ColumnOffice
            // 
            this.ColumnOffice.HeaderText = "Office";
            this.ColumnOffice.Name = "ColumnOffice";
            this.ColumnOffice.ReadOnly = true;
            // 
            // ColumnCost
            // 
            this.ColumnCost.HeaderText = "Cost";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.checkBoxDateOfVisit);
            this.panel2.Controls.Add(this.maskedTextBoxPESEL);
            this.panel2.Controls.Add(this.buttonClearFiltr);
            this.panel2.Controls.Add(this.buttonAddFiltr);
            this.panel2.Controls.Add(this.dateTimePickerDateOfVisit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Location = new System.Drawing.Point(357, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1567, 212);
            this.panel2.TabIndex = 31;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GUI_Management_of_medical_clinic.Properties.Resources.sort;
            this.pictureBox5.Location = new System.Drawing.Point(249, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI_Management_of_medical_clinic.Properties.Resources.sort__1_;
            this.pictureBox4.Location = new System.Drawing.Point(202, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // checkBoxDateOfVisit
            // 
            this.checkBoxDateOfVisit.AutoSize = true;
            this.checkBoxDateOfVisit.Location = new System.Drawing.Point(710, 8);
            this.checkBoxDateOfVisit.Name = "checkBoxDateOfVisit";
            this.checkBoxDateOfVisit.Size = new System.Drawing.Size(88, 19);
            this.checkBoxDateOfVisit.TabIndex = 15;
            this.checkBoxDateOfVisit.Text = "Date of visit";
            this.checkBoxDateOfVisit.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPESEL
            // 
            this.maskedTextBoxPESEL.Location = new System.Drawing.Point(508, 31);
            this.maskedTextBoxPESEL.Mask = "00000000000";
            this.maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
            this.maskedTextBoxPESEL.Size = new System.Drawing.Size(178, 23);
            this.maskedTextBoxPESEL.TabIndex = 14;
            this.maskedTextBoxPESEL.ValidatingType = typeof(System.DateTime);
            // 
            // buttonClearFiltr
            // 
            this.buttonClearFiltr.Location = new System.Drawing.Point(1153, 30);
            this.buttonClearFiltr.Name = "buttonClearFiltr";
            this.buttonClearFiltr.Size = new System.Drawing.Size(117, 23);
            this.buttonClearFiltr.TabIndex = 13;
            this.buttonClearFiltr.Text = "Clear";
            this.buttonClearFiltr.UseVisualStyleBackColor = true;
            this.buttonClearFiltr.Click += new System.EventHandler(this.buttonClearFiltr_Click);
            // 
            // buttonAddFiltr
            // 
            this.buttonAddFiltr.Location = new System.Drawing.Point(1044, 30);
            this.buttonAddFiltr.Name = "buttonAddFiltr";
            this.buttonAddFiltr.Size = new System.Drawing.Size(103, 23);
            this.buttonAddFiltr.TabIndex = 12;
            this.buttonAddFiltr.Text = "Set filters";
            this.buttonAddFiltr.UseVisualStyleBackColor = true;
            this.buttonAddFiltr.Click += new System.EventHandler(this.buttonAddFiltr_Click);
            // 
            // dateTimePickerDateOfVisit
            // 
            this.dateTimePickerDateOfVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfVisit.Location = new System.Drawing.Point(710, 30);
            this.dateTimePickerDateOfVisit.Name = "dateTimePickerDateOfVisit";
            this.dateTimePickerDateOfVisit.Size = new System.Drawing.Size(178, 23);
            this.dateTimePickerDateOfVisit.TabIndex = 6;
            this.dateTimePickerDateOfVisit.Value = new System.DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "PESEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(15, 33);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(178, 23);
            this.textBoxLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(304, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // FormDoctorAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.dataGridViewAppointmentList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctorAppointmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatientList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDoctorAppointmentList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

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
        private Button buttonShowDetails;
        private Button buttonRemove;
        private Button buttonViewAppointments;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerDateOfVisit;
        private Button buttonClearFiltr;
        private Button buttonAddFiltr;
        private MaskedTextBox maskedTextBoxPESEL;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxDateOfVisit;
        private CheckBox checkBoxName;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnPatient;
        private DataGridViewTextBoxColumn Columnfirstname;
        private DataGridViewTextBoxColumn ColumnPESEL;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnHour;
        private DataGridViewTextBoxColumn ColumnOffice;
        private DataGridViewTextBoxColumn ColumnCost;
    }
}