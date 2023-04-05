using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormAddEditPatient : Form
    {
        public FormAddEditPatient()
        {
            InitializeComponent();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            //buttonAddPatient
            ChangeTitle("Add new patient");
        }

        private void ChangeTitle(string title)
        {
            labelAddEditNewPatient.Text = title;
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            //EDIT PATIENT
            ChangeTitle("Edit patient");
        }

        private void FormAddEditPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
