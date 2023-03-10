namespace GUI_Management_of_medical_clinic
{
    partial class FormChangeStatusOfEmployee
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
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(23, 15);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 15);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Wprowadź hasło:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(126, 12);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(23, 53);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(126, 33);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(190, 53);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(126, 33);
            buttonConfirm.TabIndex = 3;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // ChangeStatusOfEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 110);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Name = "ChangeStatusOfEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeactivateEmployee";
            Load += ChangeStatusOfEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}