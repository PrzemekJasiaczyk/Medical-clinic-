namespace GUI_Management_of_medical_clinic
{
    partial class FormAppointmentAdd
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
            buttonCancel = new Button();
            labelTerm = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            buttonAdd = new Button();
            comboBoxTerm = new ComboBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(277, 449);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(242, 80);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Location = new Point(836, 117);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(33, 15);
            labelTerm.TabIndex = 1;
            labelTerm.Text = "Term";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 122);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 167);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 3;
            label3.Text = "isActive";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 211);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 4;
            label4.Text = "idCalendar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 119);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 6;
            label6.Text = "patientId";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 159);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 7;
            label7.Text = "officeId";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(228, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(227, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(593, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(593, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 23);
            textBox6.TabIndex = 13;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(564, 451);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(218, 78);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.ItemHeight = 15;
            comboBoxTerm.Items.AddRange(new object[] { "07:00 ", "07:20", "07:40", "08:00", "08:20", "08:40", "09:00", "09:20", "09:40", "10:00, ", "10:20", "10:40", "11:20", "11:40", "12:00", "12:20", "12:40", "13:00", "13:20 ", "13:40", "14:00 ", "14:20 ", "14:40", "15:00 ", "15:40", "16:00", "16:20", "16:40 ", "17:00", "17:20", "17:40 ", "18:00", "18:20", "18:40", "19:00", "19:20", "19:40" });
            comboBoxTerm.Location = new Point(912, 117);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(192, 23);
            comboBoxTerm.TabIndex = 15;
            // 
            // FormAppointmentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 588);
            Controls.Add(comboBoxTerm);
            Controls.Add(buttonAdd);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelTerm);
            Controls.Add(buttonCancel);
            Name = "FormAppointmentAdd";
            Text = "FormAppointmentAdd";
            Load += FormAppointmentAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Label labelTerm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button buttonAdd;
        private ComboBox comboBoxTerm;
    }
}