namespace GUI_Management_of_medical_clinic
{
    partial class FormSpecializationAdd
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
            labelTitle = new Label();
            buttonCancel = new Button();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            dataGridViewSpecializations = new DataGridView();
            buttonRemove = new Button();
            buttonReplace = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxNewName = new TextBox();
            labelNewName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecializations).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(991, 215);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(195, 30);
            labelTitle.TabIndex = 73;
            labelTitle.Text = "Edit Specializations";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(26, 973);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(252, 66);
            buttonCancel.TabIndex = 72;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Enabled = false;
            buttonAdd.Location = new Point(1287, 302);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(142, 45);
            buttonAdd.TabIndex = 76;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(1225, 273);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(204, 23);
            textBoxName.TabIndex = 77;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1225, 255);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 78;
            label1.Text = "Name of Specialization to Edit:";
            // 
            // dataGridViewSpecializations
            // 
            dataGridViewSpecializations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSpecializations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpecializations.Location = new Point(675, 255);
            dataGridViewSpecializations.Name = "dataGridViewSpecializations";
            dataGridViewSpecializations.RowTemplate.Height = 25;
            dataGridViewSpecializations.Size = new Size(506, 387);
            dataGridViewSpecializations.TabIndex = 79;
            dataGridViewSpecializations.CellClick += dataGridViewSpecializations_CellClick;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(1287, 353);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(142, 45);
            buttonRemove.TabIndex = 80;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonReplace_Click;
            // 
            // buttonReplace
            // 
            buttonReplace.Enabled = false;
            buttonReplace.Location = new Point(1462, 302);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.RightToLeft = RightToLeft.No;
            buttonReplace.Size = new Size(142, 45);
            buttonReplace.TabIndex = 83;
            buttonReplace.Text = "Replace";
            buttonReplace.UseVisualStyleBackColor = true;
            buttonReplace.Click += buttonReplace_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonCancel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 1081);
            panel2.TabIndex = 84;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 168);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(1462, 273);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(204, 23);
            textBoxNewName.TabIndex = 85;
            // 
            // labelNewName
            // 
            labelNewName.AutoSize = true;
            labelNewName.Location = new Point(1462, 255);
            labelNewName.Name = "labelNewName";
            labelNewName.Size = new Size(90, 15);
            labelNewName.TabIndex = 86;
            labelNewName.Text = "Updated Name:";
            // 
            // FormSpecializationAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1920, 1080);
            Controls.Add(labelNewName);
            Controls.Add(textBoxNewName);
            Controls.Add(panel2);
            Controls.Add(buttonReplace);
            Controls.Add(buttonRemove);
            Controls.Add(dataGridViewSpecializations);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSpecializationAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSpecializationAdd";
            WindowState = FormWindowState.Maximized;
            Load += FormSpecializationAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecializations).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Button buttonCancel;
        private Button buttonAdd;
        private TextBox textBoxName;
        private Label label1;
        private DataGridView dataGridViewSpecializations;
        private Button buttonRemove;
        private Button buttonReplace;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBoxNewName;
        private Label labelNewName;
    }
}