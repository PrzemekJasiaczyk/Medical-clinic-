namespace GUI_Management_of_medical_clinic
{
    partial class FormPatientList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonFilterEmployee = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2Descending = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxPesel = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewPatientList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(482, 1311);
            this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(138, 31);
            this.buttonClearFilter.TabIndex = 28;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddPatient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPatient.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddPatient.Location = new System.Drawing.Point(-8, 339);
            this.buttonAddPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(365, 116);
            this.buttonAddPatient.TabIndex = 15;
            this.buttonAddPatient.Text = "Add new patient";
            this.buttonAddPatient.UseVisualStyleBackColor = false;
            // 
            // buttonFilterEmployee
            // 
            this.buttonFilterEmployee.Location = new System.Drawing.Point(482, 1277);
            this.buttonFilterEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFilterEmployee.Name = "buttonFilterEmployee";
            this.buttonFilterEmployee.Size = new System.Drawing.Size(138, 31);
            this.buttonFilterEmployee.TabIndex = 27;
            this.buttonFilterEmployee.Text = "Filtruj";
            this.buttonFilterEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Medical Doctor",
            "Nurse",
            "Paramedic",
            "Janitor",
            "Technitian"});
            this.comboBoxRole.Location = new System.Drawing.Point(482, 1239);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(138, 28);
            this.comboBoxRole.TabIndex = 26;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Location = new System.Drawing.Point(482, 1205);
            this.checkBoxIsActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(154, 24);
            this.checkBoxIsActive.TabIndex = 25;
            this.checkBoxIsActive.Text = "Is Employee active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(482, 1181);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(65, 20);
            this.labelFilter.TabIndex = 24;
            this.labelFilter.Text = "Filter list";
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditPatient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPatient.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditPatient.Location = new System.Drawing.Point(-8, 463);
            this.buttonEditPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(376, 116);
            this.buttonEditPatient.TabIndex = 21;
            this.buttonEditPatient.Text = "Edit patient";
            this.buttonEditPatient.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.radioButton2Descending);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.checkBoxDate);
            this.panel1.Controls.Add(this.checkBoxPesel);
            this.panel1.Controls.Add(this.checkBoxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonEditPatient);
            this.panel1.Controls.Add(this.buttonAddPatient);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 1441);
            this.panel1.TabIndex = 29;
            // 
            // radioButton2Descending
            // 
            this.radioButton2Descending.AutoSize = true;
            this.radioButton2Descending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2Descending.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2Descending.Location = new System.Drawing.Point(195, 943);
            this.radioButton2Descending.Name = "radioButton2Descending";
            this.radioButton2Descending.Size = new System.Drawing.Size(109, 24);
            this.radioButton2Descending.TabIndex = 36;
            this.radioButton2Descending.TabStop = true;
            this.radioButton2Descending.Text = "Descending";
            this.radioButton2Descending.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(68, 943);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 24);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ascending";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(195, 987);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSort.Location = new System.Drawing.Point(70, 987);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(98, 33);
            this.buttonSort.TabIndex = 33;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 893);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 35);
            this.label2.TabIndex = 30;
            this.label2.Text = "Sort data:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(195, 809);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 33);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShow.Location = new System.Drawing.Point(70, 809);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(98, 33);
            this.buttonShow.TabIndex = 28;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDate.Location = new System.Drawing.Point(81, 753);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(174, 24);
            this.checkBoxDate.TabIndex = 27;
            this.checkBoxDate.Text = "Date of the latest visit";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxPesel
            // 
            this.checkBoxPesel.AutoSize = true;
            this.checkBoxPesel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPesel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPesel.Location = new System.Drawing.Point(81, 710);
            this.checkBoxPesel.Name = "checkBoxPesel";
            this.checkBoxPesel.Size = new System.Drawing.Size(125, 24);
            this.checkBoxPesel.TabIndex = 26;
            this.checkBoxPesel.Text = "PESEL number";
            this.checkBoxPesel.UseVisualStyleBackColor = true;
            this.checkBoxPesel.CheckedChanged += new System.EventHandler(this.checkBoxPesel_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxName.Location = new System.Drawing.Point(81, 664);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(161, 24);
            this.checkBoxName.TabIndex = 25;
            this.checkBoxName.Text = "Name and surname";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filter patients on:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(33, 1293);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(288, 88);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "LOG OUT";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(70, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 224);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewPatientList
            // 
            this.dataGridViewPatientList.AllowUserToAddRows = false;
            this.dataGridViewPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewPatientList.Location = new System.Drawing.Point(353, 0);
            this.dataGridViewPatientList.Name = "dataGridViewPatientList";
            this.dataGridViewPatientList.RowHeadersVisible = false;
            this.dataGridViewPatientList.RowHeadersWidth = 51;
            this.dataGridViewPatientList.RowTemplate.Height = 29;
            this.dataGridViewPatientList.Size = new System.Drawing.Size(1570, 1155);
            this.dataGridViewPatientList.TabIndex = 30;
            this.dataGridViewPatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surname";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PESEL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date of birth";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Active";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date last visit";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FormPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 1055);
            this.Controls.Add(this.dataGridViewPatientList);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonFilterEmployee);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatientList";
            this.Text = "FormPatientList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPatientList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClearFilter;
        private Button buttonAddPatient;
        private Button buttonFilterEmployee;
        private ComboBox comboBoxRole;
        private CheckBox checkBoxIsActive;
        private Label labelFilter;
        private Button buttonEditPatient;
        private Panel panel1;
        private Button button1;
        private Button buttonSort;
        private Label label2;
        private Button buttonClear;
        private Button buttonShow;
        private CheckBox checkBoxDate;
        private CheckBox checkBoxPesel;
        private CheckBox checkBoxName;
        private Label label1;
        private Button buttonBack;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewPatientList;
        private RadioButton radioButton2Descending;
        private RadioButton radioButton1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}