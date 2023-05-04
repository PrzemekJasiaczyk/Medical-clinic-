namespace GUI_Management_of_medical_clinic
{
    partial class FormCalendarDelete
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
            buttonConfirm = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 18);
            label1.Name = "label1";
            label1.Size = new Size(555, 37);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to delete this Calendar";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(115, 97);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(144, 40);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(400, 97);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(133, 40);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormCalendarDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 163);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(label1);
            Name = "FormCalendarDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalendarDelete";
            Load += FormCalendarDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}