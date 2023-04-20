namespace GUI_Management_of_medical_clinic
{
    partial class FormOfficeList
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
            dataGridViewOffices = new DataGridView();
            buttonLogOut = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonAddOffice = new Button();
            buttonEditUser = new Button();
            buttonReviewUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOffices).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOffices
            // 
            dataGridViewOffices.AllowUserToAddRows = false;
            dataGridViewOffices.AllowUserToDeleteRows = false;
            dataGridViewOffices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOffices.BackgroundColor = SystemColors.Info;
            dataGridViewOffices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOffices.GridColor = SystemColors.Info;
            dataGridViewOffices.Location = new Point(647, 148);
            dataGridViewOffices.Name = "dataGridViewOffices";
            dataGridViewOffices.ReadOnly = true;
            dataGridViewOffices.RowHeadersVisible = false;
            dataGridViewOffices.RowTemplate.Height = 25;
            dataGridViewOffices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOffices.Size = new Size(1077, 680);
            dataGridViewOffices.TabIndex = 23;
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
            panel1.Controls.Add(buttonAddOffice);
            panel1.Controls.Add(buttonEditUser);
            panel1.Controls.Add(buttonReviewUser);
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
            // buttonAddOffice
            // 
            buttonAddOffice.BackColor = Color.SteelBlue;
            buttonAddOffice.FlatStyle = FlatStyle.Flat;
            buttonAddOffice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddOffice.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddOffice.Location = new Point(-7, 259);
            buttonAddOffice.Name = "buttonAddOffice";
            buttonAddOffice.Size = new Size(329, 87);
            buttonAddOffice.TabIndex = 27;
            buttonAddOffice.Text = "Add new office";
            buttonAddOffice.UseVisualStyleBackColor = false;
            buttonAddOffice.Click += buttonAddOffice_Click;
            // 
            // buttonEditUser
            // 
            buttonEditUser.BackColor = Color.SteelBlue;
            buttonEditUser.FlatStyle = FlatStyle.Flat;
            buttonEditUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditUser.ForeColor = SystemColors.ActiveCaptionText;
            buttonEditUser.Location = new Point(-7, 352);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(329, 87);
            buttonEditUser.TabIndex = 33;
            buttonEditUser.Text = "Edit user";
            buttonEditUser.UseVisualStyleBackColor = false;
            // 
            // buttonReviewUser
            // 
            buttonReviewUser.BackColor = Color.SteelBlue;
            buttonReviewUser.FlatStyle = FlatStyle.Flat;
            buttonReviewUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReviewUser.Location = new Point(-7, 445);
            buttonReviewUser.Name = "buttonReviewUser";
            buttonReviewUser.Size = new Size(329, 87);
            buttonReviewUser.TabIndex = 28;
            buttonReviewUser.Text = "Review user";
            buttonReviewUser.UseVisualStyleBackColor = false;
            // 
            // FormOfficeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel1);
            Controls.Add(dataGridViewOffices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOfficeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOfficeList";
            WindowState = FormWindowState.Maximized;
            Load += FormOfficeList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOffices).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOffices;
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonAddOffice;
        private Button buttonEditUser;
        private Button buttonReviewUser;
    }
}