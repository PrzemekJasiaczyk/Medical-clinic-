namespace GUI_Management_of_medical_clinic
{
    partial class FormDeletingConfirmation
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
            buttonCancel = new Button();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(413, 35);
            label1.TabIndex = 0;
            label1.Text = "Are you sure to delete this office?";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(12, 70);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(175, 45);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(245, 70);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(175, 45);
            buttonConfirm.TabIndex = 12;
            buttonConfirm.Text = "Delete";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // FormDeletingConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 127);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Name = "FormDeletingConfirmation";
            Text = "FormDeletingConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}