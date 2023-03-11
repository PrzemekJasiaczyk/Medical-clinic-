namespace GUI_Management_of_medical_clinic
{
    partial class FormMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenEmployeeList
            // 
            this.buttonOpenEmployeeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpenEmployeeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenEmployeeList.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpenEmployeeList.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOpenEmployeeList.FlatAppearance.BorderSize = 5;
            this.buttonOpenEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenEmployeeList.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenEmployeeList.Location = new System.Drawing.Point(272, 326);
            this.buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
            this.buttonOpenEmployeeList.Size = new System.Drawing.Size(235, 91);
            this.buttonOpenEmployeeList.TabIndex = 2;
            this.buttonOpenEmployeeList.Text = "START";
            this.buttonOpenEmployeeList.UseVisualStyleBackColor = false;
            this.buttonOpenEmployeeList.Click += new System.EventHandler(this.buttonOpenEmployeeList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.Website_Headers_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenEmployeeList);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOpenEmployeeList;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}