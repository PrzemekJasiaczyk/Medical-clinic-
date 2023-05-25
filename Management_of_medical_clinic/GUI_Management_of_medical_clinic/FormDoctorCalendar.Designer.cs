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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelMonth = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.labelTitleCalendar_Month = new System.Windows.Forms.Label();
            this.labelTitleCalendar_Year = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMonday = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridViewYourAppointments = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonEditAppointment = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.buttonReject);
            this.panelMenu.Controls.Add(this.buttonModify);
            this.panelMenu.Controls.Add(this.buttonAccept);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Location = new System.Drawing.Point(-3, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(312, 1081);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReject.Location = new System.Drawing.Point(-9, 384);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(329, 87);
            this.buttonReject.TabIndex = 50;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonModify.Location = new System.Drawing.Point(-9, 477);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(329, 87);
            this.buttonModify.TabIndex = 49;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Visible = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAccept.Location = new System.Drawing.Point(-9, 291);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(329, 87);
            this.buttonAccept.TabIndex = 29;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(26, 983);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(252, 66);
            this.buttonExit.TabIndex = 48;
            this.buttonExit.Text = "Back";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelMonth
            // 
            this.flowLayoutPanelMonth.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelMonth.Location = new System.Drawing.Point(309, 248);
            this.flowLayoutPanelMonth.Name = "flowLayoutPanelMonth";
            this.flowLayoutPanelMonth.Size = new System.Drawing.Size(1200, 820);
            this.flowLayoutPanelMonth.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(307, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1888, 77);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1598, 664);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "All appointments for this day";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(1563, 697);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.RowHeadersVisible = false;
            this.dataGridViewAppointments.RowTemplate.Height = 25;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(345, 371);
            this.dataGridViewAppointments.TabIndex = 19;
            // 
            // labelTitleCalendar_Month
            // 
            this.labelTitleCalendar_Month.AutoSize = true;
            this.labelTitleCalendar_Month.BackColor = System.Drawing.Color.White;
            this.labelTitleCalendar_Month.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleCalendar_Month.Location = new System.Drawing.Point(337, 29);
            this.labelTitleCalendar_Month.Name = "labelTitleCalendar_Month";
            this.labelTitleCalendar_Month.Size = new System.Drawing.Size(149, 54);
            this.labelTitleCalendar_Month.TabIndex = 10;
            this.labelTitleCalendar_Month.Text = "Month";
            this.labelTitleCalendar_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleCalendar_Year
            // 
            this.labelTitleCalendar_Year.AutoSize = true;
            this.labelTitleCalendar_Year.BackColor = System.Drawing.Color.White;
            this.labelTitleCalendar_Year.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleCalendar_Year.Location = new System.Drawing.Point(1074, 15);
            this.labelTitleCalendar_Year.Name = "labelTitleCalendar_Year";
            this.labelTitleCalendar_Year.Size = new System.Drawing.Size(154, 72);
            this.labelTitleCalendar_Year.TabIndex = 17;
            this.labelTitleCalendar_Year.Text = "2023";
            this.labelTitleCalendar_Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.buttonNextMonth);
            this.panel9.Controls.Add(this.buttonPreviousMonth);
            this.panel9.Controls.Add(this.labelTitleCalendar_Year);
            this.panel9.Controls.Add(this.labelTitleCalendar_Month);
            this.panel9.Location = new System.Drawing.Point(296, 75);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1888, 99);
            this.panel9.TabIndex = 20;
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.BackColor = System.Drawing.Color.White;
            this.buttonNextMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNextMonth.FlatAppearance.BorderSize = 0;
            this.buttonNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextMonth.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNextMonth.Location = new System.Drawing.Point(219, 29);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(62, 62);
            this.buttonNextMonth.TabIndex = 18;
            this.buttonNextMonth.Text = ">";
            this.buttonNextMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNextMonth.UseVisualStyleBackColor = false;
            // 
            // buttonPreviousMonth
            // 
            this.buttonPreviousMonth.BackColor = System.Drawing.Color.White;
            this.buttonPreviousMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPreviousMonth.FlatAppearance.BorderSize = 0;
            this.buttonPreviousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousMonth.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPreviousMonth.Location = new System.Drawing.Point(152, 29);
            this.buttonPreviousMonth.Name = "buttonPreviousMonth";
            this.buttonPreviousMonth.Size = new System.Drawing.Size(62, 62);
            this.buttonPreviousMonth.TabIndex = 19;
            this.buttonPreviousMonth.Text = "<";
            this.buttonPreviousMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPreviousMonth.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(312, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 62);
            this.panel2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(30, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sunday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelMonday);
            this.panel3.Location = new System.Drawing.Point(484, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 62);
            this.panel3.TabIndex = 22;
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.BackColor = System.Drawing.Color.White;
            this.labelMonday.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMonday.Location = new System.Drawing.Point(19, 13);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(115, 37);
            this.labelMonday.TabIndex = 3;
            this.labelMonday.Text = "Monday";
            this.labelMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(655, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 62);
            this.panel4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tuesday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(826, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 62);
            this.panel5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wednesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thursday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(997, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 62);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(1168, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(165, 62);
            this.panel7.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(38, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Friday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(1339, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(165, 62);
            this.panel8.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(23, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saturday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(1671, 213);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(122, 30);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Select Date";
            // 
            // dataGridViewYourAppointments
            // 
            this.dataGridViewYourAppointments.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewYourAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYourAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewYourAppointments.Location = new System.Drawing.Point(1563, 291);
            this.dataGridViewYourAppointments.MultiSelect = false;
            this.dataGridViewYourAppointments.Name = "dataGridViewYourAppointments";
            this.dataGridViewYourAppointments.ReadOnly = true;
            this.dataGridViewYourAppointments.RowHeadersVisible = false;
            this.dataGridViewYourAppointments.RowTemplate.Height = 25;
            this.dataGridViewYourAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYourAppointments.Size = new System.Drawing.Size(345, 333);
            this.dataGridViewYourAppointments.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1598, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 30);
            this.label9.TabIndex = 30;
            this.label9.Text = "Your appointments for this day";
            // 
            // buttonEditAppointment
            // 
            this.buttonEditAppointment.Location = new System.Drawing.Point(1657, 630);
            this.buttonEditAppointment.Name = "buttonEditAppointment";
            this.buttonEditAppointment.Size = new System.Drawing.Size(156, 37);
            this.buttonEditAppointment.TabIndex = 31;
            this.buttonEditAppointment.Text = "Modify";
            this.buttonEditAppointment.UseVisualStyleBackColor = true;
            // 
            // FormDoctorCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.buttonEditAppointment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewYourAppointments);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flowLayoutPanelMonth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctorCalendar";
            this.Text = "Calendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDoctorCalendar_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}