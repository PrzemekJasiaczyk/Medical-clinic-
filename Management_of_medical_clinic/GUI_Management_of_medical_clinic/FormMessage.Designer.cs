namespace GUI_Management_of_medical_clinic
{
    partial class FormMessage
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
            buttonOK = new Button();
            panel1 = new Panel();
            button2 = new Button();
            labelMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOK.BackColor = Color.SteelBlue;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.FlatAppearance.BorderColor = SystemColors.Control;
            buttonOK.FlatAppearance.BorderSize = 5;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.ForeColor = SystemColors.Control;
            buttonOK.Location = new Point(75, 170);
            buttonOK.MaximumSize = new Size(550, 55);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(450, 55);
            buttonOK.TabIndex = 20;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 105);
            panel1.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(29, 982);
            button2.Name = "button2";
            button2.Size = new Size(252, 66);
            button2.TabIndex = 3;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.Location = new Point(75, 38);
            labelMessage.MaximumSize = new Size(550, 160);
            labelMessage.MinimumSize = new Size(450, 80);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(450, 80);
            labelMessage.TabIndex = 25;
            labelMessage.Text = "Message";
            // 
            // FormMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 250);
            Controls.Add(labelMessage);
            Controls.Add(buttonOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMessage";
            Load += FormMessage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOK;
        private Panel panel1;
        private Button button2;
        private Label labelMessage;
    }
}