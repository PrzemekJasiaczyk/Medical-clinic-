namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCurrentCalendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanelMonth = new FlowLayoutPanel();
            panel1 = new Panel();
            label8 = new Label();
            labelTitleCalendar_Month = new Label();
            labelTitleCalendar_Year = new Label();
            panel9 = new Panel();
            buttonToday = new Button();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            labelMonday = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            labelDate = new Label();
            labelTitleCalendarMonth = new Label();
            labelTitleCalendarYear = new Label();
            dataGridViewAppointments = new DataGridView();
            label7 = new Label();
            label9 = new Label();
            Room = new DataGridViewTextBoxColumn();
            Term = new DataGridViewTextBoxColumn();
            Patient = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(-3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1081);
            panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(26, 983);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 48;
            buttonExit.Text = "Back";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelMonth
            // 
            flowLayoutPanelMonth.BackColor = SystemColors.Control;
            flowLayoutPanelMonth.Location = new Point(309, 248);
            flowLayoutPanelMonth.Name = "flowLayoutPanelMonth";
            flowLayoutPanelMonth.Size = new Size(1200, 820);
            flowLayoutPanelMonth.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(307, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1888, 77);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1522, 148);
            label8.Name = "label8";
            label8.Size = new Size(69, 30);
            label8.TabIndex = 18;
            label8.Text = "Office";
            // 
            // labelTitleCalendar_Month
            // 
            labelTitleCalendar_Month.AutoSize = true;
            labelTitleCalendar_Month.BackColor = Color.White;
            labelTitleCalendar_Month.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendar_Month.Location = new Point(337, 29);
            labelTitleCalendar_Month.Name = "labelTitleCalendar_Month";
            labelTitleCalendar_Month.Size = new Size(149, 54);
            labelTitleCalendar_Month.TabIndex = 10;
            labelTitleCalendar_Month.Text = "Month";
            labelTitleCalendar_Month.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleCalendar_Year
            // 
            labelTitleCalendar_Year.AutoSize = true;
            labelTitleCalendar_Year.BackColor = Color.White;
            labelTitleCalendar_Year.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendar_Year.Location = new Point(1074, 15);
            labelTitleCalendar_Year.Name = "labelTitleCalendar_Year";
            labelTitleCalendar_Year.Size = new Size(154, 72);
            labelTitleCalendar_Year.TabIndex = 17;
            labelTitleCalendar_Year.Text = "2023";
            labelTitleCalendar_Year.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 100);
            panel9.TabIndex = 29;
            // 
            // buttonToday
            // 
            buttonToday.BackColor = Color.White;
            buttonToday.FlatAppearance.BorderSize = 0;
            buttonToday.FlatStyle = FlatStyle.Flat;
            buttonToday.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToday.Location = new Point(20, 25);
            buttonToday.Name = "buttonToday";
            buttonToday.Size = new Size(165, 62);
            buttonToday.TabIndex = 14;
            buttonToday.Text = "Today";
            buttonToday.UseVisualStyleBackColor = false;
            buttonToday.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(312, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 62);
            panel2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(30, 11);
            label6.Name = "label6";
            label6.Size = new Size(104, 37);
            label6.TabIndex = 9;
            label6.Text = "Sunday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelMonday);
            panel3.Location = new Point(484, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(165, 62);
            panel3.TabIndex = 22;
            // 
            // labelMonday
            // 
            labelMonday.AutoSize = true;
            labelMonday.BackColor = Color.White;
            labelMonday.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelMonday.ImageAlign = ContentAlignment.MiddleRight;
            labelMonday.Location = new Point(19, 13);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new Size(115, 37);
            labelMonday.TabIndex = 3;
            labelMonday.Text = "Monday";
            labelMonday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(655, 181);
            panel4.Name = "panel4";
            panel4.Size = new Size(165, 62);
            panel4.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 4;
            label1.Text = "Tuesday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(826, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(165, 62);
            panel5.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(5, 12);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(154, 37);
            label3.TabIndex = 5;
            label3.Text = "Wednesday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(23, 12);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 6;
            label2.Text = "Thursday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(997, 181);
            panel6.Name = "panel6";
            panel6.Size = new Size(165, 62);
            panel6.TabIndex = 25;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(1168, 181);
            panel7.Name = "panel7";
            panel7.Size = new Size(165, 62);
            panel7.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(38, 12);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 8;
            label4.Text = "Friday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label5);
            panel8.Location = new Point(1339, 181);
            panel8.Name = "panel8";
            panel8.Size = new Size(165, 62);
            panel8.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(23, 12);
            label5.Name = "label5";
            label5.Size = new Size(121, 37);
            label5.TabIndex = 7;
            label5.Text = "Saturday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.Location = new Point(1638, 80);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(122, 30);
            labelDate.TabIndex = 28;
            labelDate.Text = "Select Date";
            // 
            // labelTitleCalendarMonth
            // 
            labelTitleCalendarMonth.AutoSize = true;
            labelTitleCalendarMonth.BackColor = SystemColors.Control;
            labelTitleCalendarMonth.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendarMonth.Location = new Point(630, 110);
            labelTitleCalendarMonth.Name = "labelTitleCalendarMonth";
            labelTitleCalendarMonth.Size = new Size(149, 54);
            labelTitleCalendarMonth.TabIndex = 30;
            labelTitleCalendarMonth.Text = "Month";
            labelTitleCalendarMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleCalendarYear
            // 
            labelTitleCalendarYear.AutoSize = true;
            labelTitleCalendarYear.BackColor = SystemColors.Control;
            labelTitleCalendarYear.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCalendarYear.Location = new Point(1362, 92);
            labelTitleCalendarYear.Name = "labelTitleCalendarYear";
            labelTitleCalendarYear.Size = new Size(154, 72);
            labelTitleCalendarYear.TabIndex = 32;
            labelTitleCalendarYear.Text = "2023";
            labelTitleCalendarYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AllowUserToAddRows = false;
            dataGridViewAppointments.AllowUserToDeleteRows = false;
            dataGridViewAppointments.AllowUserToResizeColumns = false;
            dataGridViewAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointments.BackgroundColor = Color.Gainsboro;
            dataGridViewAppointments.BorderStyle = BorderStyle.None;
            dataGridViewAppointments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAppointments.ColumnHeadersHeight = 60;
            dataGridViewAppointments.ColumnHeadersVisible = false;
            dataGridViewAppointments.Columns.AddRange(new DataGridViewColumn[] { Room, Term, Patient });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAppointments.Location = new Point(1515, 181);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAppointments.RowHeadersVisible = false;
            dataGridViewAppointments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewAppointments.RowTemplate.Height = 40;
            dataGridViewAppointments.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewAppointments.ScrollBars = ScrollBars.Vertical;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(398, 888);
            dataGridViewAppointments.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1638, 148);
            label7.Name = "label7";
            label7.Size = new Size(58, 30);
            label7.TabIndex = 34;
            label7.Text = "Term";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1764, 148);
            label9.Name = "label9";
            label9.Size = new Size(77, 30);
            label9.TabIndex = 35;
            label9.Text = "Patient";
            // 
            // Room
            // 
            Room.HeaderText = "Room";
            Room.Name = "Room";
            Room.ReadOnly = true;
            Room.Width = 30;
            // 
            // Term
            // 
            Term.HeaderText = "Term";
            Term.Name = "Term";
            Term.ReadOnly = true;
            Term.Width = 40;
            // 
            // Patient
            // 
            Patient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Patient.HeaderText = "Patient";
            Patient.Name = "Patient";
            Patient.ReadOnly = true;
            // 
            // FormDoctorCurrentCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(labelTitleCalendarYear);
            Controls.Add(labelTitleCalendarMonth);
            Controls.Add(labelDate);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Controls.Add(panel9);
            Controls.Add(flowLayoutPanelMonth);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCurrentCalendar";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorCalendar_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private FlowLayoutPanel flowLayoutPanelMonth;
        private Panel panel1;
        private Label label8;
        private Label labelTitleCalendar_Month;
        private Label labelTitleCalendar_Year;
        private Panel panel9;
        private Panel panel2;
        private Label label6;
        private Panel panel3;
        private Label labelMonday;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Label label3;
        private Label label2;
        private Panel panel6;
        private Panel panel7;
        private Label label4;
        private Panel panel8;
        private Label label5;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private Button buttonToday;
        private Label labelDate;
        private Label labelTitleCalendarMonth;
        private Label labelTitleCalendarYear;
        private DataGridView dataGridViewAppointments;
        private Label label7;
        private Label label9;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Term;
        private DataGridViewTextBoxColumn Patient;
    }
}