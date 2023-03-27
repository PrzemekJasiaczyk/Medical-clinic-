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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            buttonClearFilter = new Button();
            buttonAddPatient = new Button();
            buttonFilterEmployee = new Button();
            comboBoxRole = new ComboBox();
            checkBoxIsActive = new CheckBox();
            labelFilter = new Label();
            buttonEditPatient = new Button();
            panel1 = new Panel();
            button2 = new Button();
            buttonDeactivatePatinet = new Button();
            buttonActivatePatient = new Button();
            buttonRemovePatient = new Button();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            radioButton2Descending = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            buttonSort = new Button();
            label2 = new Label();
            buttonClear = new Button();
            buttonShow = new Button();
            checkBoxDate = new CheckBox();
            checkBoxPesel = new CheckBox();
            checkBoxName = new CheckBox();
            label1 = new Label();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            dataGridViewPatientList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatientList).BeginInit();
            SuspendLayout();
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(482, 1311);
            buttonClearFilter.Margin = new Padding(3, 4, 3, 4);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(138, 31);
            buttonClearFilter.TabIndex = 28;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.BackColor = Color.SteelBlue;
            buttonAddPatient.FlatAppearance.BorderColor = Color.Black;
            buttonAddPatient.FlatStyle = FlatStyle.Flat;
            buttonAddPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPatient.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddPatient.Location = new Point(-1, 245);
            buttonAddPatient.Margin = new Padding(3, 4, 3, 4);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(355, 65);
            buttonAddPatient.TabIndex = 15;
            buttonAddPatient.Text = "Add new patient";
            buttonAddPatient.UseVisualStyleBackColor = false;
            // 
            // buttonFilterEmployee
            // 
            buttonFilterEmployee.Location = new Point(482, 1277);
            buttonFilterEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonFilterEmployee.Name = "buttonFilterEmployee";
            buttonFilterEmployee.Size = new Size(138, 31);
            buttonFilterEmployee.TabIndex = 27;
            buttonFilterEmployee.Text = "Filtruj";
            buttonFilterEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Medical Doctor", "Nurse", "Paramedic", "Janitor", "Technitian" });
            comboBoxRole.Location = new Point(482, 1239);
            comboBoxRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(138, 23);
            comboBoxRole.TabIndex = 26;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.Location = new Point(482, 1205);
            checkBoxIsActive.Margin = new Padding(3, 4, 3, 4);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(123, 19);
            checkBoxIsActive.TabIndex = 25;
            checkBoxIsActive.Text = "Is Employee active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(482, 1181);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(51, 15);
            labelFilter.TabIndex = 24;
            labelFilter.Text = "Filter list";
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.BackColor = Color.SteelBlue;
            buttonEditPatient.FlatAppearance.BorderColor = Color.Black;
            buttonEditPatient.FlatStyle = FlatStyle.Flat;
            buttonEditPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditPatient.Location = new Point(-1, 315);
            buttonEditPatient.Margin = new Padding(3, 4, 3, 4);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(355, 65);
            buttonEditPatient.TabIndex = 21;
            buttonEditPatient.Text = "Edit patient";
            buttonEditPatient.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonDeactivatePatinet);
            panel1.Controls.Add(buttonActivatePatient);
            panel1.Controls.Add(buttonRemovePatient);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(radioButton2Descending);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonSort);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonShow);
            panel1.Controls.Add(checkBoxDate);
            panel1.Controls.Add(checkBoxPesel);
            panel1.Controls.Add(checkBoxName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonEditPatient);
            panel1.Controls.Add(buttonAddPatient);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 1441);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(50, 983);
            button2.Name = "button2";
            button2.Size = new Size(248, 60);
            button2.TabIndex = 31;
            button2.Text = "LOG OUT";
            button2.UseVisualStyleBackColor = false;
            // 
            // buttonDeactivatePatinet
            // 
            buttonDeactivatePatinet.BackColor = Color.SteelBlue;
            buttonDeactivatePatinet.FlatAppearance.BorderColor = Color.Black;
            buttonDeactivatePatinet.FlatStyle = FlatStyle.Flat;
            buttonDeactivatePatinet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeactivatePatinet.Location = new Point(-1, 525);
            buttonDeactivatePatinet.Margin = new Padding(3, 4, 3, 4);
            buttonDeactivatePatinet.Name = "buttonDeactivatePatinet";
            buttonDeactivatePatinet.Size = new Size(355, 65);
            buttonDeactivatePatinet.TabIndex = 45;
            buttonDeactivatePatinet.Text = "Deactivate patient";
            buttonDeactivatePatinet.UseVisualStyleBackColor = false;
            // 
            // buttonActivatePatient
            // 
            buttonActivatePatient.BackColor = Color.SteelBlue;
            buttonActivatePatient.FlatAppearance.BorderColor = Color.Black;
            buttonActivatePatient.FlatStyle = FlatStyle.Flat;
            buttonActivatePatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonActivatePatient.Location = new Point(-1, 455);
            buttonActivatePatient.Margin = new Padding(3, 4, 3, 4);
            buttonActivatePatient.Name = "buttonActivatePatient";
            buttonActivatePatient.Size = new Size(355, 65);
            buttonActivatePatient.TabIndex = 44;
            buttonActivatePatient.Text = "Activate patient";
            buttonActivatePatient.UseVisualStyleBackColor = false;
            // 
            // buttonRemovePatient
            // 
            buttonRemovePatient.BackColor = Color.SteelBlue;
            buttonRemovePatient.FlatAppearance.BorderColor = Color.Black;
            buttonRemovePatient.FlatStyle = FlatStyle.Flat;
            buttonRemovePatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemovePatient.Location = new Point(-1, 385);
            buttonRemovePatient.Margin = new Padding(3, 4, 3, 4);
            buttonRemovePatient.Name = "buttonRemovePatient";
            buttonRemovePatient.Size = new Size(355, 65);
            buttonRemovePatient.TabIndex = 43;
            buttonRemovePatient.Text = "Remove patient";
            buttonRemovePatient.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(198, 766);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 42;
            label4.Text = "To";
            label4.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(229, 764);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(98, 23);
            dateTimePicker2.TabIndex = 41;
            dateTimePicker2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 766);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 40;
            label3.Text = "From";
            label3.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(70, 764);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 39;
            dateTimePicker1.Visible = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(198, 690);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 23);
            maskedTextBox1.TabIndex = 38;
            maskedTextBox1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 649);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 37;
            textBox1.Visible = false;
            // 
            // radioButton2Descending
            // 
            radioButton2Descending.AutoSize = true;
            radioButton2Descending.FlatStyle = FlatStyle.Flat;
            radioButton2Descending.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2Descending.Location = new Point(152, 894);
            radioButton2Descending.Name = "radioButton2Descending";
            radioButton2Descending.Size = new Size(87, 19);
            radioButton2Descending.TabIndex = 36;
            radioButton2Descending.TabStop = true;
            radioButton2Descending.Text = "Descending";
            radioButton2Descending.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(25, 894);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 35;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ascending";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(200, 926);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 34;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonSort
            // 
            buttonSort.BackColor = Color.SteelBlue;
            buttonSort.FlatAppearance.BorderColor = Color.Black;
            buttonSort.FlatStyle = FlatStyle.Flat;
            buttonSort.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSort.Location = new Point(50, 926);
            buttonSort.Margin = new Padding(3, 4, 3, 4);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(98, 33);
            buttonSort.TabIndex = 33;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 854);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 30;
            label2.Text = "Sort data:";
            label2.Click += label2_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.SteelBlue;
            buttonClear.FlatAppearance.BorderColor = Color.Black;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.Location = new Point(200, 803);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(98, 33);
            buttonClear.TabIndex = 29;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.SteelBlue;
            buttonShow.FlatAppearance.BorderColor = Color.Black;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShow.Location = new Point(50, 803);
            buttonShow.Margin = new Padding(3, 4, 3, 4);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(98, 33);
            buttonShow.TabIndex = 28;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AutoSize = true;
            checkBoxDate.FlatStyle = FlatStyle.Flat;
            checkBoxDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxDate.Location = new Point(22, 730);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(137, 19);
            checkBoxDate.TabIndex = 27;
            checkBoxDate.Text = "Date of the latest visit";
            checkBoxDate.UseVisualStyleBackColor = true;
            checkBoxDate.CheckedChanged += checkBoxDate_CheckedChanged;
            // 
            // checkBoxPesel
            // 
            checkBoxPesel.AutoSize = true;
            checkBoxPesel.FlatStyle = FlatStyle.Flat;
            checkBoxPesel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxPesel.Location = new Point(22, 690);
            checkBoxPesel.Name = "checkBoxPesel";
            checkBoxPesel.Size = new Size(100, 19);
            checkBoxPesel.TabIndex = 26;
            checkBoxPesel.Text = "PESEL number";
            checkBoxPesel.UseVisualStyleBackColor = true;
            checkBoxPesel.CheckedChanged += checkBoxPesel_CheckedChanged;
            // 
            // checkBoxName
            // 
            checkBoxName.AutoSize = true;
            checkBoxName.FlatStyle = FlatStyle.Flat;
            checkBoxName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxName.Location = new Point(22, 649);
            checkBoxName.Name = "checkBoxName";
            checkBoxName.Size = new Size(127, 19);
            checkBoxName.TabIndex = 25;
            checkBoxName.Text = "Name and surname";
            checkBoxName.UseVisualStyleBackColor = true;
            checkBoxName.CheckedChanged += checkBoxName_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 606);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 23;
            label1.Text = "Filter patients on:";
            label1.Click += label1_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Gainsboro;
            buttonBack.FlatAppearance.BorderColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(33, 1293);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(288, 88);
            buttonBack.TabIndex = 22;
            buttonBack.Text = "LOG OUT";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MC_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(70, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 224);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewPatientList
            // 
            dataGridViewPatientList.AllowUserToAddRows = false;
            dataGridViewPatientList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatientList.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPatientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatientList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewPatientList.Location = new Point(353, 0);
            dataGridViewPatientList.Name = "dataGridViewPatientList";
            dataGridViewPatientList.RowHeadersVisible = false;
            dataGridViewPatientList.RowHeadersWidth = 51;
            dataGridViewPatientList.RowTemplate.Height = 29;
            dataGridViewPatientList.Size = new Size(1567, 1155);
            dataGridViewPatientList.TabIndex = 30;
            dataGridViewPatientList.CellContentClick += dataGridViewPatientList_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Surname";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "PESEL";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date of birth";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Active";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            Column6.HeaderText = "Date last visit";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // FormPatientList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1061);
            Controls.Add(dataGridViewPatientList);
            Controls.Add(buttonClearFilter);
            Controls.Add(buttonFilterEmployee);
            Controls.Add(comboBoxRole);
            Controls.Add(checkBoxIsActive);
            Controls.Add(labelFilter);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPatientList";
            Text = "FormPatientList";
            WindowState = FormWindowState.Maximized;
            Load += FormPatientList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatientList).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Button buttonDeactivatePatinet;
        private Button buttonActivatePatient;
        private Button buttonRemovePatient;
        private Button button2;
    }
}