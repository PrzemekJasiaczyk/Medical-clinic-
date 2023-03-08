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
            this.buttonOpenEmployeeList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenEmployeeList
            // 
            this.buttonOpenEmployeeList.Location = new System.Drawing.Point(242, 96);
            this.buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
            this.buttonOpenEmployeeList.Size = new System.Drawing.Size(240, 102);
            this.buttonOpenEmployeeList.TabIndex = 0;
            this.buttonOpenEmployeeList.Text = "Zacznij";
            this.buttonOpenEmployeeList.UseVisualStyleBackColor = true;
            this.buttonOpenEmployeeList.Click += new System.EventHandler(this.buttonOpenEmployeeList_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 332);
            this.Controls.Add(this.buttonOpenEmployeeList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOpenEmployeeList;
    }
}