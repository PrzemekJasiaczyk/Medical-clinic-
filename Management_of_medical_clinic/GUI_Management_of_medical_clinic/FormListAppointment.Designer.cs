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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            buttonClearFilter = new Button();
            panel1 = new Panel();
            buttonShowDetails = new Button();
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
            pictureBoxSortDESC = new PictureBox();
            pictureBoxSortASC = new PictureBox();
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
            panel1.Controls.Add(buttonShowDetails);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 1080);
            panel1.TabIndex = 29;
            // 
            // buttonShowDetails
            // 
            buttonShowDetails.BackColor = Color.SteelBlue;
            buttonShowDetails.FlatAppearance.BorderColor = Color.Black;
            buttonShowDetails.FlatStyle = FlatStyle.Flat;
            buttonShowDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowDetails.Location = new Point(-1, 273);
            buttonShowDetails.Margin = new Padding(3, 4, 3, 4);
            buttonShowDetails.Name = "buttonShowDetails";
            buttonShowDetails.Size = new Size(360, 65);
            buttonShowDetails.TabIndex = 47;
            buttonShowDetails.Text = "Show details";
            buttonShowDetails.UseVisualStyleBackColor = false;
            buttonShowDetails.Click += buttonShowDetails_Click;
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
            panel2.Controls.Add(pictureBoxSortDESC);
            panel2.Controls.Add(pictureBoxSortASC);
            panel2.Location = new Point(357, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1567, 77);
            panel2.TabIndex = 31;
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
        private Button buttonDeactivatePatinet;
        private Button buttonActivatePatient;
        private Button buttonRemovePatient;
        private Panel panel2;
        private PictureBox pictureBoxSortDESC;
        private PictureBox pictureBoxSortASC;
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
        private Button buttonShowDetails;
    }
}