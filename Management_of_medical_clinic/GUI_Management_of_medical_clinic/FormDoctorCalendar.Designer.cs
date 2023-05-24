namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCalendar
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
            panelMenu = new Panel();
            buttonReject = new Button();
            buttonModify = new Button();
            buttonAccept = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanelMonth = new FlowLayoutPanel();
            panel1 = new Panel();
            label8 = new Label();
            dataGridViewAppointments = new DataGridView();
            labelTitleCalendar_Month = new Label();
            labelTitleCalendar_Year = new Label();
            panel9 = new Panel();
            buttonNextMonth = new Button();
            buttonPreviousMonth = new Button();
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
            dataGridViewYourAppointments = new DataGridView();
            label9 = new Label();
            buttonEditAppointment = new Button();
            labelCalendarStatus = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYourAppointments).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(buttonReject);
            panelMenu.Controls.Add(buttonModify);
            panelMenu.Controls.Add(buttonAccept);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(-3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1081);
            panelMenu.TabIndex = 0;
            // 
            // buttonReject
            // 
            buttonReject.BackColor = Color.SteelBlue;
            buttonReject.FlatStyle = FlatStyle.Flat;
            buttonReject.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReject.ForeColor = SystemColors.ActiveCaptionText;
            buttonReject.Location = new Point(-9, 384);
            buttonReject.Name = "buttonReject";
            buttonReject.Size = new Size(329, 87);
            buttonReject.TabIndex = 50;
            buttonReject.Text = "Reject";
            buttonReject.UseVisualStyleBackColor = false;
            buttonReject.Click += buttonReject_Click;
            // 
            // buttonModify
            // 
            buttonModify.BackColor = Color.SteelBlue;
            buttonModify.FlatStyle = FlatStyle.Flat;
            buttonModify.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModify.ForeColor = SystemColors.ActiveCaptionText;
            buttonModify.Location = new Point(-9, 477);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(329, 87);
            buttonModify.TabIndex = 49;
            buttonModify.Text = "Modify";
            buttonModify.UseVisualStyleBackColor = false;
            buttonModify.Visible = false;
            // 
            // buttonAccept
            // 
            buttonAccept.BackColor = Color.SteelBlue;
            buttonAccept.FlatStyle = FlatStyle.Flat;
            buttonAccept.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAccept.ForeColor = SystemColors.ActiveCaptionText;
            buttonAccept.Location = new Point(-9, 291);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(329, 87);
            buttonAccept.TabIndex = 29;
            buttonAccept.Text = "Accept";
            buttonAccept.UseVisualStyleBackColor = false;
            buttonAccept.Click += buttonAccept_Click;
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
            buttonExit.Click += buttonExit_Click_1;
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
            label8.Location = new Point(1598, 664);
            label8.Name = "label8";
            label8.Size = new Size(281, 30);
            label8.TabIndex = 18;
            label8.Text = "All appointments for this day";
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.BackgroundColor = SystemColors.Info;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewAppointments.Location = new Point(1563, 697);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.RowHeadersVisible = false;
            dataGridViewAppointments.RowTemplate.Height = 25;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(345, 371);
            dataGridViewAppointments.TabIndex = 19;
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
            panel9.BackColor = Color.White;
            panel9.Controls.Add(labelCalendarStatus);
            panel9.Controls.Add(buttonNextMonth);
            panel9.Controls.Add(buttonPreviousMonth);
            panel9.Controls.Add(labelTitleCalendar_Year);
            panel9.Controls.Add(labelTitleCalendar_Month);
            panel9.Location = new Point(296, 75);
            panel9.Name = "panel9";
            panel9.Size = new Size(1888, 99);
            panel9.TabIndex = 20;
            // 
            // buttonNextMonth
            // 
            buttonNextMonth.BackColor = Color.White;
            buttonNextMonth.BackgroundImageLayout = ImageLayout.None;
            buttonNextMonth.FlatAppearance.BorderSize = 0;
            buttonNextMonth.FlatStyle = FlatStyle.Flat;
            buttonNextMonth.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNextMonth.Location = new Point(219, 29);
            buttonNextMonth.Name = "buttonNextMonth";
            buttonNextMonth.Size = new Size(62, 62);
            buttonNextMonth.TabIndex = 18;
            buttonNextMonth.Text = ">";
            buttonNextMonth.TextAlign = ContentAlignment.TopCenter;
            buttonNextMonth.UseVisualStyleBackColor = false;
            buttonNextMonth.Click += buttonNextMonth_Click;
            // 
            // buttonPreviousMonth
            // 
            buttonPreviousMonth.BackColor = Color.White;
            buttonPreviousMonth.BackgroundImageLayout = ImageLayout.None;
            buttonPreviousMonth.FlatAppearance.BorderSize = 0;
            buttonPreviousMonth.FlatStyle = FlatStyle.Flat;
            buttonPreviousMonth.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPreviousMonth.Location = new Point(152, 29);
            buttonPreviousMonth.Name = "buttonPreviousMonth";
            buttonPreviousMonth.Size = new Size(62, 62);
            buttonPreviousMonth.TabIndex = 19;
            buttonPreviousMonth.Text = "<";
            buttonPreviousMonth.TextAlign = ContentAlignment.TopCenter;
            buttonPreviousMonth.UseVisualStyleBackColor = false;
            buttonPreviousMonth.Click += buttonPreviousMonth_Click;
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
            labelDate.Location = new Point(1671, 213);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(122, 30);
            labelDate.TabIndex = 28;
            labelDate.Text = "Select Date";
            // 
            // dataGridViewYourAppointments
            // 
            dataGridViewYourAppointments.BackgroundColor = SystemColors.Info;
            dataGridViewYourAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYourAppointments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewYourAppointments.Location = new Point(1563, 291);
            dataGridViewYourAppointments.MultiSelect = false;
            dataGridViewYourAppointments.Name = "dataGridViewYourAppointments";
            dataGridViewYourAppointments.ReadOnly = true;
            dataGridViewYourAppointments.RowHeadersVisible = false;
            dataGridViewYourAppointments.RowTemplate.Height = 25;
            dataGridViewYourAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewYourAppointments.Size = new Size(345, 333);
            dataGridViewYourAppointments.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1598, 258);
            label9.Name = "label9";
            label9.Size = new Size(298, 30);
            label9.TabIndex = 30;
            label9.Text = "Your appointments for this day";
            // 
            // buttonEditAppointment
            // 
            buttonEditAppointment.Location = new Point(1657, 630);
            buttonEditAppointment.Name = "buttonEditAppointment";
            buttonEditAppointment.Size = new Size(156, 37);
            buttonEditAppointment.TabIndex = 31;
            buttonEditAppointment.Text = "Modify";
            buttonEditAppointment.UseVisualStyleBackColor = true;
            buttonEditAppointment.Click += buttonEditAppointment_Click;
            // 
            // labelCalendarStatus
            // 
            labelCalendarStatus.AutoSize = true;
            labelCalendarStatus.BackColor = Color.White;
            labelCalendarStatus.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelCalendarStatus.Location = new Point(655, 29);
            labelCalendarStatus.Name = "labelCalendarStatus";
            labelCalendarStatus.Size = new Size(140, 54);
            labelCalendarStatus.TabIndex = 20;
            labelCalendarStatus.Text = "Status";
            labelCalendarStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDoctorCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonEditAppointment);
            Controls.Add(label9);
            Controls.Add(dataGridViewYourAppointments);
            Controls.Add(labelDate);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(label8);
            Controls.Add(flowLayoutPanelMonth);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Controls.Add(panel9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorCalendar";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormDoctorCalendar_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewYourAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private FlowLayoutPanel flowLayoutPanelMonth;
        private Panel panel1;
        private Label label8;
        private DataGridView dataGridViewAppointments;
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
        private Label labelDate;
        private Button buttonReject;
        private Button buttonModify;
        private Button buttonAccept;
        private DataGridView dataGridViewYourAppointments;
        private Label label9;
        private Button buttonEditAppointment;
        private Button buttonNextMonth;
        private Button buttonPreviousMonth;
        private Label labelCalendarStatus;
    }
}