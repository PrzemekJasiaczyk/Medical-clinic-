namespace GUI_Management_of_medical_clinic
{
    partial class FormDoctorCalendarEdit
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
            label1 = new Label();
            panel1 = new Panel();
            dateTimePicker = new DateTimePicker();
            comboBoxOffice = new ComboBox();
            comboBoxTerm = new ComboBox();
            buttonCancel = new Button();
            buttonEdit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(820, 48);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 0;
            label1.Text = "Appointment edition";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-704, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 126);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(190, 154);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(218, 23);
            dateTimePicker.TabIndex = 4;
            // 
            // comboBoxOffice
            // 
            comboBoxOffice.FormattingEnabled = true;
            comboBoxOffice.Location = new Point(190, 207);
            comboBoxOffice.Name = "comboBoxOffice";
            comboBoxOffice.Size = new Size(218, 23);
            comboBoxOffice.TabIndex = 6;
            // 
            // comboBoxTerm
            // 
            comboBoxTerm.DropDownHeight = 200;
            comboBoxTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerm.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTerm.FormattingEnabled = true;
            comboBoxTerm.IntegralHeight = false;
            comboBoxTerm.ItemHeight = 37;
            comboBoxTerm.Items.AddRange(new object[] { "07:00 ", "07:20", "07:40", "08:00", "08:20", "08:40", "09:00", "09:20", "09:40", "10:00, ", "10:20", "10:40", "11:20", "11:40", "12:00", "12:20", "12:40", "13:00", "13:20 ", "13:40", "14:00 ", "14:20 ", "14:40", "15:00 ", "15:40", "16:00", "16:20", "16:40 ", "17:00", "17:20", "17:40 ", "18:00", "18:20", "18:40", "19:00", "19:20", "19:40" });
            comboBoxTerm.Location = new Point(190, 249);
            comboBoxTerm.Name = "comboBoxTerm";
            comboBoxTerm.Size = new Size(218, 45);
            comboBoxTerm.TabIndex = 16;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Gainsboro;
            buttonCancel.FlatAppearance.BorderColor = Color.White;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(23, 392);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(167, 59);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Gainsboro;
            buttonEdit.FlatAppearance.BorderColor = Color.White;
            buttonEdit.FlatAppearance.BorderSize = 2;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(241, 392);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(167, 59);
            buttonEdit.TabIndex = 18;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 193);
            label2.Name = "label2";
            label2.Size = new Size(100, 37);
            label2.TabIndex = 43;
            label2.Text = "Office:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 257);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 44;
            label3.Text = "Term:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(74, 142);
            label4.Name = "label4";
            label4.Size = new Size(85, 37);
            label4.TabIndex = 45;
            label4.Text = "Date:";
            // 
            // FormDoctorCalendarEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(451, 463);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonEdit);
            Controls.Add(buttonCancel);
            Controls.Add(comboBoxTerm);
            Controls.Add(comboBoxOffice);
            Controls.Add(dateTimePicker);
            Controls.Add(panel1);
            Name = "FormDoctorCalendarEdit";
            Text = "Appointment edition";
            Load += FormDoctorCalendarEdit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxOffice;
        private ComboBox comboBoxTerm;
        private Button buttonCancel;
        private Button buttonEdit;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}