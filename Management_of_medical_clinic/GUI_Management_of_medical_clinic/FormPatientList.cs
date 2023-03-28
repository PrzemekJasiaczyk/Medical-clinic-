using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormPatientList : Form
    {
        public FormPatientList()
        {
            InitializeComponent();
            dataGridViewPatientList.AllowUserToAddRows = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = checkBoxDate.Checked;
            label4.Visible = checkBoxDate.Checked;
            dateTimePicker1.Visible = checkBoxDate.Checked;
            dateTimePicker2.Visible = checkBoxDate.Checked;

        }

        private void checkBoxPesel_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = checkBoxPesel.Checked;
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = checkBoxName.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPatientList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
