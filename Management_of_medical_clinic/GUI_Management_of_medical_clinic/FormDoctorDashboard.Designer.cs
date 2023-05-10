namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorDashboard
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
            buttonLogOut = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonCalendar = new Button();
            buttonCurrentCalendar = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridViewAppointments = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Gainsboro;
            buttonLogOut.FlatAppearance.BorderColor = Color.White;
            buttonLogOut.FlatAppearance.BorderSize = 2;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.Location = new Point(29, 970);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(252, 66);
            buttonLogOut.TabIndex = 40;
            buttonLogOut.Text = "LOG OUT";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonCalendar);
            panel1.Controls.Add(buttonCurrentCalendar);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 39;
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
            // buttonCalendar
            // 
            buttonCalendar.BackColor = Color.SteelBlue;
            buttonCalendar.FlatStyle = FlatStyle.Flat;
            buttonCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalendar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCalendar.Location = new Point(-7, 259);
            buttonCalendar.Name = "buttonCalendar";
            buttonCalendar.Size = new Size(329, 87);
            buttonCalendar.TabIndex = 27;
            buttonCalendar.Text = "Calendar";
            buttonCalendar.UseVisualStyleBackColor = false;
            buttonCalendar.Click += buttonCalendar_Click;
            // 
            // buttonCurrentCalendar
            // 
            buttonCurrentCalendar.BackColor = Color.SteelBlue;
            buttonCurrentCalendar.FlatStyle = FlatStyle.Flat;
            buttonCurrentCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCurrentCalendar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCurrentCalendar.Location = new Point(-7, 352);
            buttonCurrentCalendar.Name = "buttonCurrentCalendar";
            buttonCurrentCalendar.Size = new Size(329, 87);
            buttonCurrentCalendar.TabIndex = 33;
            buttonCurrentCalendar.Text = "Current calendar";
            buttonCurrentCalendar.UseVisualStyleBackColor = false;
            buttonCurrentCalendar.Click += buttonCurrentCalendar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(-7, 445);
            button2.Name = "button2";
            button2.Size = new Size(329, 87);
            button2.TabIndex = 28;
            button2.Text = "[..]";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(375, 115);
            label1.Name = "label1";
            label1.Size = new Size(420, 65);
            label1.TabIndex = 40;
            label1.Text = "Welcome message";
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.BackgroundColor = SystemColors.Info;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewAppointments.Location = new Point(1465, 259);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.RowHeadersVisible = false;
            dataGridViewAppointments.RowTemplate.Height = 25;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(345, 538);
            dataGridViewAppointments.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1537, 226);
            label8.Name = "label8";
            label8.Size = new Size(215, 30);
            label8.TabIndex = 42;
            label8.Text = "Today's appointments";
            // 
            // FormDoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label8);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeList";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonCalendar;
        private Button buttonCurrentCalendar;
        private Button button2;
        private Label label1;
        private DataGridView dataGridViewAppointments;
        private Label label8;
    }
}