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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonCalendar);
            this.panel1.Controls.Add(this.buttonCurrentCalendar);
            this.panel1.Controls.Add(this.button2);
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
            this.buttonCalendar.Text = "New Calendar";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(-7, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 87);
            this.button2.TabIndex = 28;
            this.button2.Text = "[..]";
            this.button2.UseVisualStyleBackColor = false;
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
            // FormDoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoctorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOfficeList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonCalendar;
        private Button buttonCurrentCalendar;
        private Button button2;
        private Label label1;
    }
}