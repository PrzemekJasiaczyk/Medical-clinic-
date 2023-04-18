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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenUserList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenEmployeeList
            // 
            this.buttonOpenEmployeeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpenEmployeeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenEmployeeList.BackColor = System.Drawing.Color.Gray;
            this.buttonOpenEmployeeList.Enabled = false;
            this.buttonOpenEmployeeList.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOpenEmployeeList.FlatAppearance.BorderSize = 5;
            this.buttonOpenEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenEmployeeList.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenEmployeeList.Location = new System.Drawing.Point(136, 211);
            this.buttonOpenEmployeeList.Name = "buttonOpenEmployeeList";
            this.buttonOpenEmployeeList.Size = new System.Drawing.Size(325, 125);
            this.buttonOpenEmployeeList.TabIndex = 2;
            this.buttonOpenEmployeeList.Text = "EMPLOYEE LIST";
            this.buttonOpenEmployeeList.UseVisualStyleBackColor = false;
            this.buttonOpenEmployeeList.Click += new System.EventHandler(this.buttonOpenEmployeeList_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BackColor = System.Drawing.Color.MintCream;
            this.textBoxLogin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLogin.Location = new System.Drawing.Point(49, 52);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PlaceholderText = "Login";
            this.textBoxLogin.Size = new System.Drawing.Size(509, 42);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.MintCream;
            this.textBoxPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPassword.Location = new System.Drawing.Point(49, 100);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(509, 43);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 1081);
            this.panel2.TabIndex = 7;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(29, 982);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(252, 66);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.MC_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenUserList
            // 
            this.buttonOpenUserList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpenUserList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenUserList.BackColor = System.Drawing.Color.Gray;
            this.buttonOpenUserList.Enabled = false;
            this.buttonOpenUserList.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOpenUserList.FlatAppearance.BorderSize = 5;
            this.buttonOpenUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenUserList.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenUserList.Location = new System.Drawing.Point(136, 342);
            this.buttonOpenUserList.Name = "buttonOpenUserList";
            this.buttonOpenUserList.Size = new System.Drawing.Size(325, 125);
            this.buttonOpenUserList.TabIndex = 8;
            this.buttonOpenUserList.Text = "USER LIST";
            this.buttonOpenUserList.UseVisualStyleBackColor = false;
            this.buttonOpenUserList.Click += new System.EventHandler(this.buttonOpenUserList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose Log In Option";
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogIn.Controls.Add(this.buttonOpenEmployeeList);
            this.panelLogIn.Controls.Add(this.label1);
            this.panelLogIn.Controls.Add(this.textBoxPassword);
            this.panelLogIn.Controls.Add(this.buttonOpenUserList);
            this.panelLogIn.Controls.Add(this.textBoxLogin);
            this.panelLogIn.Location = new System.Drawing.Point(748, 223);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(598, 551);
            this.panelLogIn.TabIndex = 10;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_Management_of_medical_clinic.Properties.Resources.Website_Headers_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOpenEmployeeList;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonExit;
        private Button buttonOpenUserList;
        private Label label1;
        private Panel panelLogIn;
    }
}