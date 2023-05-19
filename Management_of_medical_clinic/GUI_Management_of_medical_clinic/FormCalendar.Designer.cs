namespace GUI_Management_of_medical_clinic
{
    partial class FormCalendar
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
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            createCalendarButton = new Button();
            flowLayoutPanelMonth = new FlowLayoutPanel();
            labelDate = new Label();
            buttonAddAppointment = new Button();
            label8 = new Label();
            dataGridViewAppointments = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            labelTitleCalendar_Month = new Label();
            labelTitleCalendar_Year = new Label();
            buttonToday = new Button();
            panel9 = new Panel();
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
            // createCalendarButton
            // 
            createCalendarButton.BackColor = SystemColors.GradientActiveCaption;
            createCalendarButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            createCalendarButton.ForeColor = SystemColors.ControlText;
            createCalendarButton.Location = new Point(1321, 2);
            createCalendarButton.Name = "createCalendarButton";
            createCalendarButton.Size = new Size(252, 94);
            createCalendarButton.TabIndex = 17;
            createCalendarButton.Text = "Create Calendar for Selected Month";
            createCalendarButton.UseVisualStyleBackColor = false;
            createCalendarButton.Click += createCalendarButton_Click;
            // 
            // flowLayoutPanelMonth
            // 
            flowLayoutPanelMonth.BackColor = SystemColors.Control;
            flowLayoutPanelMonth.Location = new Point(312, 173);
            flowLayoutPanelMonth.Name = "flowLayoutPanelMonth";
            flowLayoutPanelMonth.Size = new Size(786, 895);
            flowLayoutPanelMonth.TabIndex = 1;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.Location = new Point(1628, 248);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(188, 45);
            labelDate.TabIndex = 1;
            labelDate.Text = "Select term";
            // 
            // buttonAddAppointment
            // 
            buttonAddAppointment.Location = new Point(1628, 946);
            buttonAddAppointment.Name = "buttonAddAppointment";
            buttonAddAppointment.Size = new Size(225, 78);
            buttonAddAppointment.TabIndex = 15;
            buttonAddAppointment.Text = "Add new Plan";
            buttonAddAppointment.UseVisualStyleBackColor = true;
            buttonAddAppointment.Click += buttonAddAppointment_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1617, 307);
            label8.Name = "label8";
            label8.Size = new Size(228, 30);
            label8.TabIndex = 18;
            label8.Text = "Doctor's Working Plans";
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.BackgroundColor = SystemColors.Info;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Location = new Point(1563, 349);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.RowTemplate.Height = 25;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewAppointments.Size = new Size(345, 538);
            dataGridViewAppointments.TabIndex = 19;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(193, 25);
            button3.Name = "button3";
            button3.Size = new Size(62, 62);
            button3.TabIndex = 12;
            button3.Text = "<";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonPreviousMonth_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(260, 25);
            button2.Name = "button2";
            button2.Size = new Size(62, 62);
            button2.TabIndex = 11;
            button2.Text = ">";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonNextMonth_Click;
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
            labelTitleCalendar_Year.Location = new Point(657, 14);
            labelTitleCalendar_Year.Name = "labelTitleCalendar_Year";
            labelTitleCalendar_Year.Size = new Size(154, 72);
            labelTitleCalendar_Year.TabIndex = 17;
            labelTitleCalendar_Year.Text = "2023";
            labelTitleCalendar_Year.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(buttonToday);
            panel9.Controls.Add(labelTitleCalendar_Year);
            panel9.Controls.Add(labelTitleCalendar_Month);
            panel9.Controls.Add(button2);
            panel9.Controls.Add(button3);
            panel9.Controls.Add(createCalendarButton);
            panel9.Location = new Point(296, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1888, 99);
            panel9.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(315, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 62);
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
            label6.Size = new Size(61, 37);
            label6.TabIndex = 9;
            label6.Text = "Sun";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelMonday);
            panel3.Location = new Point(426, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(105, 62);
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
            labelMonday.Size = new Size(72, 37);
            labelMonday.TabIndex = 3;
            labelMonday.Text = "Mon";
            labelMonday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(537, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 62);
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
            label1.Size = new Size(60, 37);
            label1.TabIndex = 4;
            label1.Text = "Tue";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(648, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(105, 62);
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
            label3.Size = new Size(71, 37);
            label3.TabIndex = 5;
            label3.Text = "Wed";
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
            label2.Size = new Size(61, 37);
            label2.TabIndex = 6;
            label2.Text = "Thu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(759, 105);
            panel6.Name = "panel6";
            panel6.Size = new Size(105, 62);
            panel6.TabIndex = 25;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(870, 105);
            panel7.Name = "panel7";
            panel7.Size = new Size(105, 62);
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
            label4.Size = new Size(46, 37);
            label4.TabIndex = 8;
            label4.Text = "Fri";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label5);
            panel8.Location = new Point(981, 105);
            panel8.Name = "panel8";
            panel8.Size = new Size(105, 62);
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
            label5.Size = new Size(54, 37);
            label5.TabIndex = 7;
            label5.Text = "Sat";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(label8);
            Controls.Add(buttonAddAppointment);
            Controls.Add(labelDate);
            Controls.Add(flowLayoutPanelMonth);
            Controls.Add(panelMenu);
            Controls.Add(panel9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalendar";
            Text = "Calendar";
            WindowState = FormWindowState.Maximized;
            Load += FormCalendar_Load;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private FlowLayoutPanel flowLayoutPanelMonth;
        private Label labelDate;
        private Button buttonAddAppointment;
        private Button createCalendarButton;
        private Label label8;
        private DataGridView dataGridViewAppointments;
        private Button button3;
        private Button button2;
        private Label labelTitleCalendar_Month;
        private Label labelTitleCalendar_Year;
        private Button buttonToday;
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
    }
}