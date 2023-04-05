using Console_Management_of_medical_clinic.Data.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            CompleteComboBox();
            // sprawdzenie którą opcje wybrał user
            // czy dodać czy edytować
        }


        void CompleteComboBox()
        {
            comboBoxSex.DataSource = Enum.GetValues(typeof(EnumSex));
            //comboBoxStatus.DataSource = Patient.

        }

        private void FormAddEditPatient_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // temp
            FormAddEditPatient.ActiveForm.Close();
        }
    }
}
