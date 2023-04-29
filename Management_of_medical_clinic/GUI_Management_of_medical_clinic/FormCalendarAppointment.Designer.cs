namespace GUI_Management_of_medical_clinic
{
    partial class FormCalendarAppointment
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
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            buttonExit = new Button();
            panel1 = new Panel();
            labelTitleCalendar_Month = new Label();
            labelMonday = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            buttonNextMonth = new Button();
            buttonPreviousMonth = new Button();
            buttonToday = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            labelTitleCalendar_Year = new Label();
            flowLayoutPanelMonth = new FlowLayoutPanel();
            dataGridViewAppointment = new DataGridView();
            ColumnDoctor = new DataGridViewTextBoxColumn();
            ColumnTime = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Location = new Point(-3, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1081);
            panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            buttonExit.TabIndex = 46;
            buttonExit.Text = "Back";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(307, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1888, 77);
            panel1.TabIndex = 2;
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
            // labelMonday
            // 
            labelMonday.AutoSize = true;
            labelMonday.BackColor = Color.White;
            labelMonday.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelMonday.ImageAlign = ContentAlignment.MiddleRight;
            labelMonday.Location = new Point(23, 12);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new Size(115, 37);
            labelMonday.TabIndex = 3;
            labelMonday.Text = "Monday";
            labelMonday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(27, 11);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 4;
            label1.Text = "Tuesday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // buttonNextMonth
            // 
            buttonNextMonth.BackColor = Color.White;
            buttonNextMonth.BackgroundImageLayout = ImageLayout.None;
            buttonNextMonth.FlatAppearance.BorderSize = 0;
            buttonNextMonth.FlatStyle = FlatStyle.Flat;
            buttonNextMonth.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNextMonth.Location = new Point(260, 25);
            buttonNextMonth.Name = "buttonNextMonth";
            buttonNextMonth.Size = new Size(62, 62);
            buttonNextMonth.TabIndex = 11;
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
            buttonPreviousMonth.Location = new Point(193, 25);
            buttonPreviousMonth.Name = "buttonPreviousMonth";
            buttonPreviousMonth.Size = new Size(62, 62);
            buttonPreviousMonth.TabIndex = 12;
            buttonPreviousMonth.Text = "<";
            buttonPreviousMonth.TextAlign = ContentAlignment.TopCenter;
            buttonPreviousMonth.UseVisualStyleBackColor = false;
            buttonPreviousMonth.Click += buttonPreviousMonth_Click;
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
            buttonToday.Click += buttonToday_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(311, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 62);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelMonday);
            panel3.Location = new Point(483, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(165, 62);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(654, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(165, 62);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(825, 180);
            panel5.Name = "panel5";
            panel5.Size = new Size(165, 62);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(996, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(165, 62);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(1167, 180);
            panel7.Name = "panel7";
            panel7.Size = new Size(165, 62);
            panel7.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label5);
            panel8.Location = new Point(1338, 180);
            panel8.Name = "panel8";
            panel8.Size = new Size(165, 62);
            panel8.TabIndex = 15;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(buttonToday);
            panel9.Controls.Add(labelTitleCalendar_Year);
            panel9.Controls.Add(labelTitleCalendar_Month);
            panel9.Controls.Add(buttonNextMonth);
            panel9.Controls.Add(buttonPreviousMonth);
            panel9.Location = new Point(296, 75);
            panel9.Name = "panel9";
            panel9.Size = new Size(1888, 99);
            panel9.TabIndex = 3;
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
            // flowLayoutPanelMonth
            // 
            flowLayoutPanelMonth.BackColor = SystemColors.Control;
            flowLayoutPanelMonth.Location = new Point(309, 248);
            flowLayoutPanelMonth.Name = "flowLayoutPanelMonth";
            flowLayoutPanelMonth.Size = new Size(1200, 820);
            flowLayoutPanelMonth.TabIndex = 1;
            // 
            // dataGridViewAppointment
            // 
            dataGridViewAppointment.AllowUserToAddRows = false;
            dataGridViewAppointment.AllowUserToDeleteRows = false;
            dataGridViewAppointment.BackgroundColor = SystemColors.Control;
            dataGridViewAppointment.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointment.ColumnHeadersHeight = 60;
            dataGridViewAppointment.Columns.AddRange(new DataGridViewColumn[] { ColumnDoctor, ColumnTime });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAppointment.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAppointment.Location = new Point(1514, 180);
            dataGridViewAppointment.Name = "dataGridViewAppointment";
            dataGridViewAppointment.ReadOnly = true;
            dataGridViewAppointment.RowHeadersVisible = false;
            dataGridViewAppointment.RowHeadersWidth = 90;
            dataGridViewAppointment.RowTemplate.Height = 25;
            dataGridViewAppointment.ScrollBars = ScrollBars.None;
            dataGridViewAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointment.Size = new Size(402, 700);
            dataGridViewAppointment.TabIndex = 16;
            // 
            // ColumnDoctor
            // 
            ColumnDoctor.HeaderText = "Doctor";
            ColumnDoctor.Name = "ColumnDoctor";
            ColumnDoctor.ReadOnly = true;
            ColumnDoctor.Width = 201;
            // 
            // ColumnTime
            // 
            ColumnTime.HeaderText = "Time";
            ColumnTime.Name = "ColumnTime";
            ColumnTime.ReadOnly = true;
            ColumnTime.Resizable = DataGridViewTriState.False;
            ColumnTime.Width = 201;
            // 
            // FormCalendarAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(dataGridViewAppointment);
            Controls.Add(flowLayoutPanelMonth);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalendarAppointment";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormCalendarAppointment_Load;
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
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Label labelMonday;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label labelTitleCalendar_Month;
        private Button buttonNextMonth;
        private Button buttonPreviousMonth;
        private Button buttonToday;
        private Button buttonExit;
        private Label labelDate;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private FlowLayoutPanel flowLayoutPanelMonth;
        private Label labelTitleCalendar_Year;
        private DataGridView dataGridViewAppointment;
        private DataGridViewTextBoxColumn ColumnDoctor;
        private DataGridViewTextBoxColumn ColumnTime;
    }
}