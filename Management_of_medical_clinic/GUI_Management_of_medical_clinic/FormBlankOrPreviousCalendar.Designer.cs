namespace GUI_Management_of_medical_clinic
{
    partial class FormBlankOrPreviousCalendar
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
            buttonBlankForm = new Button();
            buttonPreviousForm = new Button();
            buttonCancel = new Button();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // buttonBlankForm
            // 
            buttonBlankForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonBlankForm.BackColor = Color.SteelBlue;
            buttonBlankForm.DialogResult = DialogResult.OK;
            buttonBlankForm.FlatAppearance.BorderColor = SystemColors.Control;
            buttonBlankForm.FlatAppearance.BorderSize = 5;
            buttonBlankForm.FlatStyle = FlatStyle.Flat;
            buttonBlankForm.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBlankForm.ForeColor = SystemColors.Control;
            buttonBlankForm.Location = new Point(175, 205);
            buttonBlankForm.MaximumSize = new Size(550, 55);
            buttonBlankForm.Name = "buttonBlankForm";
            buttonBlankForm.Size = new Size(450, 55);
            buttonBlankForm.TabIndex = 26;
            buttonBlankForm.Text = "Blank form";
            buttonBlankForm.UseVisualStyleBackColor = false;
            buttonBlankForm.Click += buttonBlankForm_Click;
            // 
            // buttonPreviousForm
            // 
            buttonPreviousForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPreviousForm.BackColor = Color.SteelBlue;
            buttonPreviousForm.DialogResult = DialogResult.OK;
            buttonPreviousForm.FlatAppearance.BorderColor = SystemColors.Control;
            buttonPreviousForm.FlatAppearance.BorderSize = 5;
            buttonPreviousForm.FlatStyle = FlatStyle.Flat;
            buttonPreviousForm.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPreviousForm.ForeColor = SystemColors.Control;
            buttonPreviousForm.Location = new Point(175, 266);
            buttonPreviousForm.MaximumSize = new Size(550, 55);
            buttonPreviousForm.Name = "buttonPreviousForm";
            buttonPreviousForm.Size = new Size(450, 55);
            buttonPreviousForm.TabIndex = 28;
            buttonPreviousForm.Text = "Based on the previous month";
            buttonPreviousForm.UseVisualStyleBackColor = false;
            buttonPreviousForm.Click += buttonPreviousForm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancel.BackColor = Color.Gray;
            buttonCancel.DialogResult = DialogResult.OK;
            buttonCancel.FlatAppearance.BorderColor = SystemColors.Control;
            buttonCancel.FlatAppearance.BorderSize = 5;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(288, 345);
            buttonCancel.MaximumSize = new Size(550, 55);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(216, 55);
            buttonCancel.TabIndex = 29;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.Location = new Point(175, 110);
            labelMessage.MaximumSize = new Size(550, 160);
            labelMessage.MinimumSize = new Size(450, 80);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(450, 80);
            labelMessage.TabIndex = 30;
            labelMessage.Text = "Calendar form";
            labelMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormBlankOrPreviousCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMessage);
            Controls.Add(buttonCancel);
            Controls.Add(buttonPreviousForm);
            Controls.Add(buttonBlankForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBlankOrPreviousCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBlankOrPreviousCalendar";
            Load += FormBlankOrPreviousCalendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBlankForm;
        private Button buttonPreviousForm;
        private Button buttonCancel;
        private Label labelMessage;
    }
}