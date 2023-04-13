namespace GUI_Management_of_medical_clinic
{
    partial class FormSpecializationAdd
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSpecializations = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializations)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(991, 215);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(195, 30);
            this.labelTitle.TabIndex = 73;
            this.labelTitle.Text = "Edit Specializations";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(26, 973);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(252, 66);
            this.buttonCancel.TabIndex = 72;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(1287, 302);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 45);
            this.buttonAdd.TabIndex = 76;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1225, 273);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 23);
            this.textBoxName.TabIndex = 77;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1225, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Name of Specialization to Edit:";
            // 
            // dataGridViewSpecializations
            // 
            this.dataGridViewSpecializations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecializations.Location = new System.Drawing.Point(675, 255);
            this.dataGridViewSpecializations.Name = "dataGridViewSpecializations";
            this.dataGridViewSpecializations.RowTemplate.Height = 25;
            this.dataGridViewSpecializations.Size = new System.Drawing.Size(506, 387);
            this.dataGridViewSpecializations.TabIndex = 79;
            this.dataGridViewSpecializations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpecializations_CellClick);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(1287, 353);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(142, 45);
            this.buttonRemove.TabIndex = 80;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Location = new System.Drawing.Point(1462, 302);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReplace.Size = new System.Drawing.Size(142, 45);
            this.buttonReplace.TabIndex = 83;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 1081);
            this.panel2.TabIndex = 84;
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
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(1462, 273);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(204, 23);
            this.textBoxNewName.TabIndex = 85;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(1462, 255);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(90, 15);
            this.labelNewName.TabIndex = 86;
            this.labelNewName.Text = "Updated Name:";
            // 
            // FormSpecializationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewSpecializations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSpecializationAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSpecializationAdd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSpecializationAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializations)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelTitle;
        private Button buttonCancel;
        private Button buttonAdd;
        private TextBox textBoxName;
        private Label label1;
        private DataGridView dataGridViewSpecializations;
        private Button buttonRemove;
        private Button buttonReplace;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBoxNewName;
        private Label labelNewName;
    }
}