namespace GUI_Management_of_medical_clinic
{
	partial class FormCalendarsList
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
			dataGridViewCalendars = new DataGridView();
			buttonLogOut = new Button();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			buttonAddCalendar = new Button();
			buttonEditCalendar = new Button();
			buttonRemoveCalendar = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewCalendars
			// 
			dataGridViewCalendars.AllowUserToAddRows = false;
			dataGridViewCalendars.AllowUserToDeleteRows = false;
			dataGridViewCalendars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCalendars.BackgroundColor = SystemColors.Info;
			dataGridViewCalendars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCalendars.GridColor = SystemColors.Info;
			dataGridViewCalendars.Location = new Point(647, 148);
			dataGridViewCalendars.Name = "dataGridViewCalendars";
			dataGridViewCalendars.ReadOnly = true;
			dataGridViewCalendars.RowHeadersVisible = false;
			dataGridViewCalendars.RowTemplate.Height = 25;
			dataGridViewCalendars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewCalendars.Size = new Size(1077, 680);
			dataGridViewCalendars.TabIndex = 23;
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
			panel1.Controls.Add(buttonAddCalendar);
			panel1.Controls.Add(buttonEditCalendar);
			panel1.Controls.Add(buttonRemoveCalendar);
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
			// buttonAddCalendar
			// 
			buttonAddCalendar.BackColor = Color.SteelBlue;
			buttonAddCalendar.FlatStyle = FlatStyle.Flat;
			buttonAddCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			buttonAddCalendar.ForeColor = SystemColors.ActiveCaptionText;
			buttonAddCalendar.Location = new Point(-7, 259);
			buttonAddCalendar.Name = "buttonAddCalendar";
			buttonAddCalendar.Size = new Size(329, 87);
			buttonAddCalendar.TabIndex = 27;
			buttonAddCalendar.Text = "Add new Calendar";
			buttonAddCalendar.UseVisualStyleBackColor = false;
			buttonAddCalendar.Click += buttonAddCalendar_Click;
			// 
			// buttonEditCalendar
			// 
			buttonEditCalendar.BackColor = Color.SteelBlue;
			buttonEditCalendar.FlatStyle = FlatStyle.Flat;
			buttonEditCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEditCalendar.ForeColor = SystemColors.ActiveCaptionText;
			buttonEditCalendar.Location = new Point(-7, 352);
			buttonEditCalendar.Name = "buttonEditCalendar";
			buttonEditCalendar.Size = new Size(329, 87);
			buttonEditCalendar.TabIndex = 33;
			buttonEditCalendar.Text = "Edit Calendar";
			buttonEditCalendar.UseVisualStyleBackColor = false;
			buttonEditCalendar.Click += buttonEditCalendar_Click;
			// 
			// buttonRemoveCalendar
			// 
			buttonRemoveCalendar.BackColor = Color.SteelBlue;
			buttonRemoveCalendar.FlatStyle = FlatStyle.Flat;
			buttonRemoveCalendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			buttonRemoveCalendar.Location = new Point(-7, 445);
			buttonRemoveCalendar.Name = "buttonRemoveCalendar";
			buttonRemoveCalendar.Size = new Size(329, 87);
			buttonRemoveCalendar.TabIndex = 28;
			buttonRemoveCalendar.Text = "Delete Calendar";
			buttonRemoveCalendar.UseVisualStyleBackColor = false;
			buttonRemoveCalendar.Click += buttonRemoveCalendar_Click;
			// 
			// FormCalendarsList
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1920, 1080);
			Controls.Add(panel1);
			Controls.Add(dataGridViewCalendars);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormCalendarsList";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormCalendarsList";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridViewCalendars;
		private Button buttonLogOut;
		private Panel panel1;
		private PictureBox pictureBox1;
		private Button buttonAddCalendar;
		private Button buttonEditCalendar;
		private Button buttonRemoveCalendar;
	}
}