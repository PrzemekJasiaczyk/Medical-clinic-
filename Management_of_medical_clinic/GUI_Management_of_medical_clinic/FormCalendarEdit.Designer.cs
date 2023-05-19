namespace GUI_Management_of_medical_clinic
{
    partial class FormCalendarEdit
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
            panel1 = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            comboBoxActive = new ComboBox();
            labelTitle = new Label();
            label3 = new Label();
            buttonSaveCalendar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1081);
            panel1.TabIndex = 41;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(28, 953);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(252, 66);
            buttonBack.TabIndex = 40;
            buttonBack.Text = "CANCEL";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
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
            // comboBoxActive
            // 
            comboBoxActive.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxActive.FormattingEnabled = true;
            comboBoxActive.Items.AddRange(new object[] { "Active", "Disactive" });
            comboBoxActive.Location = new Point(1098, 451);
            comboBoxActive.Name = "comboBoxActive";
            comboBoxActive.Size = new Size(187, 43);
            comboBoxActive.TabIndex = 74;
            comboBoxActive.SelectedIndexChanged += comboBoxActive_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(983, 346);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(275, 45);
            labelTitle.TabIndex = 73;
            labelTitle.Text = "Calendar edition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(926, 454);
            label3.Name = "label3";
            label3.Size = new Size(140, 35);
            label3.TabIndex = 72;
            label3.Text = "Is it Active";
            // 
            // buttonSaveCalendar
            // 
            buttonSaveCalendar.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveCalendar.Location = new Point(1013, 575);
            buttonSaveCalendar.Name = "buttonSaveCalendar";
            buttonSaveCalendar.Size = new Size(220, 60);
            buttonSaveCalendar.TabIndex = 71;
            buttonSaveCalendar.Text = "Save";
            buttonSaveCalendar.UseVisualStyleBackColor = true;
            buttonSaveCalendar.Click += buttonSaveCalendar_Click;
            // 
            // FormCalendarEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(comboBoxActive);
            Controls.Add(labelTitle);
            Controls.Add(label3);
            Controls.Add(buttonSaveCalendar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalendarEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalendarEdit";
            WindowState = FormWindowState.Maximized;
            Load += FormCalendarEdit_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private ComboBox comboBoxActive;
        private Label labelTitle;
        private Label label3;
        private Button buttonSaveCalendar;
    }
}