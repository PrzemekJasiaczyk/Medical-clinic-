namespace GUI_Management_of_medical_clinic
{
    partial class FormChangeStatusOfUser
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
            buttonConfirm = new Button();
            buttonCancel = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(192, 47);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(126, 33);
            buttonConfirm.TabIndex = 15;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(25, 47);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(126, 33);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(128, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 13;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(25, 9);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 15);
            labelPassword.TabIndex = 12;
            labelPassword.Text = "Input password:";
            // 
            // FormChangeStatusOfUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 87);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Name = "FormChangeStatusOfUser";
            Text = "FormChangeStatusOfUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private Button buttonCancel;
        private TextBox textBoxPassword;
        private Label labelPassword;
    }
}