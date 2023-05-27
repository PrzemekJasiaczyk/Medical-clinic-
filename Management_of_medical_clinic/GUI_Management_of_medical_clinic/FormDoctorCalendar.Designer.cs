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
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridViewYourAppointments = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonEditAppointment = new System.Windows.Forms.Button();
            this.list_ofCalendars = new System.Windows.Forms.ListView();
            this.column0 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.button_acceptAppointments = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Location = new System.Drawing.Point(-3, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(312, 1081);
            this.panelMenu.TabIndex = 0;
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
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(296, 75);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1888, 99);
            this.panel9.TabIndex = 20;
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
            this.dataGridViewYourAppointments.Name = "dataGridViewYourAppointments";
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
            this.buttonEditAppointment.Location = new System.Drawing.Point(1752, 630);
            this.buttonEditAppointment.Name = "buttonEditAppointment";
            this.buttonEditAppointment.Size = new System.Drawing.Size(156, 37);
            this.buttonEditAppointment.TabIndex = 31;
            this.buttonEditAppointment.Text = "Modify";
            this.buttonEditAppointment.UseVisualStyleBackColor = true;
            this.buttonEditAppointment.Click += new System.EventHandler(this.buttonEditAppointment_Click);
            // 
            // list_ofCalendars
            // 
            this.list_ofCalendars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column0});
            this.list_ofCalendars.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.list_ofCalendars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.list_ofCalendars.Location = new System.Drawing.Point(419, 242);
            this.list_ofCalendars.Name = "list_ofCalendars";
            this.list_ofCalendars.Size = new System.Drawing.Size(312, 366);
            this.list_ofCalendars.TabIndex = 32;
            this.list_ofCalendars.UseCompatibleStateImageBehavior = false;
            this.list_ofCalendars.View = System.Windows.Forms.View.Details;
            this.list_ofCalendars.SelectedIndexChanged += new System.EventHandler(this.list_ofCalendars_SelectedIndexChanged);
            this.list_ofCalendars.DoubleClick += new System.EventHandler(this.listofCalendars_DoubleClick);
            // 
            // column0
            // 
            this.column0.Text = "Calendars to accept";
            this.column0.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(419, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "Calendars to accept";
            // 
            // button_acceptAppointments
            // 
            this.button_acceptAppointments.Location = new System.Drawing.Point(1563, 630);
            this.button_acceptAppointments.Name = "button_acceptAppointments";
            this.button_acceptAppointments.Size = new System.Drawing.Size(162, 37);
            this.button_acceptAppointments.TabIndex = 36;
            this.button_acceptAppointments.Text = "Accept";
            this.button_acceptAppointments.UseVisualStyleBackColor = true;
            // 
            // FormDoctorCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button_acceptAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_ofCalendars);
            this.Controls.Add(this.buttonEditAppointment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewYourAppointments);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctorCalendar";
            this.Text = "Calendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDoctorCalendar_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Label label8;
        private DataGridView dataGridViewAppointments;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private Label labelDate;
        private DataGridView dataGridViewYourAppointments;
        private Label label9;
        private Button buttonEditAppointment;
        private ListView list_ofCalendars;
        private ColumnHeader column0;
        private Label label1;
        private Button button_acceptAppointments;
    }
}