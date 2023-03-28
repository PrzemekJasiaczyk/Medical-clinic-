namespace GUI_Management_of_medical_clinic
{
    partial class FormMenuPatient
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
            panel2 = new Panel();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonAddEdit = new Button();
            button3 = new Button();
            labelTitle = new Label();
            buttonListPatient = new Button();
            buttonListEmployee = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonExit);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 1041);
            panel2.TabIndex = 8;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gainsboro;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(29, 982);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(252, 66);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.MenuBar;
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonListEmployee);
            panel1.Controls.Add(buttonListPatient);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(buttonAddEdit);
            panel1.Controls.Add(button3);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(635, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 415);
            panel1.TabIndex = 27;
            panel1.Paint += panel1_Paint;
            // 
            // buttonAddEdit
            // 
            buttonAddEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddEdit.BackColor = Color.SteelBlue;
            buttonAddEdit.FlatAppearance.BorderColor = SystemColors.Control;
            buttonAddEdit.FlatAppearance.BorderSize = 5;
            buttonAddEdit.FlatStyle = FlatStyle.Flat;
            buttonAddEdit.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddEdit.ForeColor = SystemColors.Control;
            buttonAddEdit.Location = new Point(112, 182);
            buttonAddEdit.Name = "buttonAddEdit";
            buttonAddEdit.Size = new Size(244, 131);
            buttonAddEdit.TabIndex = 19;
            buttonAddEdit.Text = "Add and Edit";
            buttonAddEdit.UseVisualStyleBackColor = false;
            buttonAddEdit.Click += buttonConfirm_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(29, 982);
            button3.Name = "button3";
            button3.Size = new Size(252, 66);
            button3.TabIndex = 3;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Tw Cen MT Condensed", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(369, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(334, 74);
            labelTitle.TabIndex = 20;
            labelTitle.Text = "Patient Menu";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            labelTitle.Click += label1_Click;
            // 
            // buttonListPatient
            // 
            buttonListPatient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonListPatient.BackColor = Color.SteelBlue;
            buttonListPatient.FlatAppearance.BorderColor = SystemColors.Control;
            buttonListPatient.FlatAppearance.BorderSize = 5;
            buttonListPatient.FlatStyle = FlatStyle.Flat;
            buttonListPatient.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonListPatient.ForeColor = SystemColors.Control;
            buttonListPatient.Location = new Point(404, 182);
            buttonListPatient.Name = "buttonListPatient";
            buttonListPatient.Size = new Size(244, 131);
            buttonListPatient.TabIndex = 21;
            buttonListPatient.Text = "List of Patients";
            buttonListPatient.UseVisualStyleBackColor = false;
            buttonListPatient.Click += buttonListPatient_Click;
            // 
            // buttonListEmployee
            // 
            buttonListEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonListEmployee.BackColor = Color.SteelBlue;
            buttonListEmployee.FlatAppearance.BorderColor = SystemColors.Control;
            buttonListEmployee.FlatAppearance.BorderSize = 5;
            buttonListEmployee.FlatStyle = FlatStyle.Flat;
            buttonListEmployee.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonListEmployee.ForeColor = SystemColors.Control;
            buttonListEmployee.Location = new Point(703, 182);
            buttonListEmployee.Name = "buttonListEmployee";
            buttonListEmployee.Size = new Size(244, 131);
            buttonListEmployee.TabIndex = 22;
            buttonListEmployee.Text = "List of Employee";
            buttonListEmployee.UseVisualStyleBackColor = false;
            // 
            // FormMenuPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Website_Headers_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuPatient";
            WindowState = FormWindowState.Maximized;
            Load += FormMenuPatient_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button buttonAddEdit;
        private Button button3;
        private Label labelTitle;
        private Button buttonListPatient;
        private Button buttonListEmployee;
    }
}