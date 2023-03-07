namespace Management_of_medical_clinic
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOpenEmployeeList = new Button();
            SuspendLayout();
            // 
            // buttonOpenEmployeeList
            // 
            buttonOpenEmployeeList.Location = new Point(242, 96);
            buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
            buttonOpenEmployeeList.Size = new Size(240, 102);
            buttonOpenEmployeeList.TabIndex = 0;
            buttonOpenEmployeeList.Text = "Zacznij";
            buttonOpenEmployeeList.UseVisualStyleBackColor = true;
            buttonOpenEmployeeList.Click += buttonOpenEmployeeList_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 332);
            Controls.Add(buttonOpenEmployeeList);
            Margin = new Padding(2);
            Name = "Menu";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenEmployeeList;
    }
}