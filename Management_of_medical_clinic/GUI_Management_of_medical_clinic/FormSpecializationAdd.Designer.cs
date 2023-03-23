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
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSpecializations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializations)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(328, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(190, 30);
            this.labelTitle.TabIndex = 73;
            this.labelTitle.Text = "Edit Specializatons";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 30);
            this.buttonCancel.TabIndex = 72;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(562, 342);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 45);
            this.buttonAdd.TabIndex = 76;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(562, 113);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(204, 23);
            this.textBoxAdd.TabIndex = 77;
            this.textBoxAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Name of new Specialization";
            // 
            // dataGridViewSpecializations
            // 
            this.dataGridViewSpecializations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecializations.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewSpecializations.Name = "dataGridViewSpecializations";
            this.dataGridViewSpecializations.RowTemplate.Height = 25;
            this.dataGridViewSpecializations.Size = new System.Drawing.Size(506, 387);
            this.dataGridViewSpecializations.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 82;
            this.label2.Text = "Name of Specialization to Remove";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(562, 291);
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
            this.buttonReplace.Location = new System.Drawing.Point(562, 393);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReplace.Size = new System.Drawing.Size(142, 45);
            this.buttonReplace.TabIndex = 83;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 84;
            this.label3.Text = "Name of new Specialization";
            // 
            // FormSpecializationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewSpecializations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSpecializationAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSpecializationAdd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSpecializationAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelTitle;
        private Button buttonCancel;
        private Button buttonAdd;
        private TextBox textBoxAdd;
        private Label label1;
        private DataGridView dataGridViewSpecializations;
        private Label label2;
        private Button buttonRemove;
        private Button buttonReplace;
        private Label label3;
    }
}