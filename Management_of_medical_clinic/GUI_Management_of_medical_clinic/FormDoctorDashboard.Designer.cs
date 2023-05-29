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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonCurrentCalendar = new System.Windows.Forms.Button();
            this.button_patients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogOut.FlatAppearance.BorderSize = 2;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.Location = new System.Drawing.Point(29, 970);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(252, 66);
            this.buttonLogOut.TabIndex = 40;
            this.buttonLogOut.Text = "LOG OUT";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonCalendar);
            this.panel1.Controls.Add(this.buttonCurrentCalendar);
            this.panel1.Controls.Add(this.button_patients);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 1081);
            this.panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCalendar.Location = new System.Drawing.Point(-7, 259);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(329, 87);
            this.buttonCalendar.TabIndex = 27;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = false;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonCurrentCalendar
            // 
            this.buttonCurrentCalendar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCurrentCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurrentCalendar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCurrentCalendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCurrentCalendar.Location = new System.Drawing.Point(-7, 352);
            this.buttonCurrentCalendar.Name = "buttonCurrentCalendar";
            this.buttonCurrentCalendar.Size = new System.Drawing.Size(329, 87);
            this.buttonCurrentCalendar.TabIndex = 33;
            this.buttonCurrentCalendar.Text = "Current calendar";
            this.buttonCurrentCalendar.UseVisualStyleBackColor = false;
            this.buttonCurrentCalendar.Click += new System.EventHandler(this.buttonCurrentCalendar_Click);
            // 
            // button_patients
            // 
            this.button_patients.BackColor = System.Drawing.Color.SteelBlue;
            this.button_patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_patients.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_patients.Location = new System.Drawing.Point(-7, 445);
            this.button_patients.Name = "button_patients";
            this.button_patients.Size = new System.Drawing.Size(329, 87);
            this.button_patients.TabIndex = 28;
            this.button_patients.Text = "Patients";
            this.button_patients.UseVisualStyleBackColor = false;
            this.button_patients.Click += new System.EventHandler(this.button_patients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 65);
            this.label1.TabIndex = 40;
            this.label1.Text = "Welcome message";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(415, 179);
            this.dataGridView1.TabIndex = 41;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(884, 94);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(38, 15);
            this.labelFullName.TabIndex = 42;
            this.labelFullName.Text = "label2";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(884, 121);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(38, 15);
            this.labelPESEL.TabIndex = 43;
            this.labelPESEL.Text = "label3";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(884, 150);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(38, 15);
            this.labelSex.TabIndex = 44;
            this.labelSex.Text = "label4";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(884, 178);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(38, 15);
            this.labelBirthday.TabIndex = 45;
            this.labelBirthday.Text = "label5";
            // 
            // FormDoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1698, 825);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOfficeList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonCalendar;
        private Button buttonCurrentCalendar;
        private Button button_patients;
        private Label label1;
        private DataGridView dataGridView1;
        private Label labelFullName;
        private Label labelPESEL;
        private Label labelSex;
        private Label labelBirthday;
    }
}