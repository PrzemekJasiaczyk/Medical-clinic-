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
        EmployeeModel currentUser;
        Patient patient;

        public FormAddEditPatient(EmployeeModel currentUser, Patient? patient)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.patient = patient;
        }

        private void FormAddEditPatient_Load(object sender, EventArgs e)
        {
            CompleteComboBox();
            SetPropertiesDateTimePicker();

            if (patient == null)
            {
                dateTimePickerBirthDate.Value = DateTime.Now;
                return;
            }

            ChangeTitle("Edit patient");
            CompleteControls();

        }

        //private void buttonCancel_Click(object sender, EventArgs e)
        //{
        //    FormAddEditPatient.ActiveForm.Close();

        //    FormPatientList formPatientList = new FormPatientList(currentUser);
        //    Close();
        //    formPatientList.ShowDialog();
        //}

        private void buttonAddEditPatient_Click(object sender, EventArgs e)
        {
            // zmiana lub dodanie pacjenta +++ dodanie walidacji

            //patient.PESEL = maskedTextBoxPESEL.Text;
            //patient.Sex = (EnumSex)comboBoxSex.SelectedItem;  // pewnie źle

            patient.BirthDate = dateTimePickerBirthDate.Value;

            //patient.FirstName = textBoxName.Text;
            //patient.LastName = textBoxLastName.Text;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // temp
            FormAddEditPatient.ActiveForm.Close();
            FormPatientList formPatientList = new FormPatientList(currentUser);
            formPatientList.ShowDialog();
        }


        // FUNCTIONS

        private void CompleteComboBox()
        {
            comboBoxSex.DataSource = Enum.GetValues(typeof(EnumSex));
        }
        private void CompleteControls()
        {
            textBoxLastName.Text = patient.LastName;
            textBoxName.Text = patient.FirstName;

            dateTimePickerBirthDate.Value = patient.BirthDate;
            maskedTextBoxPESEL.Text = patient.PESEL;

            //wybieranie w combo płci
        }

        private void ChangeTitle(string title)
        {
            labelAddEditNewPatient.Text = title;
            buttonAddEditPatient.Text = title;
        }

        private void SetPropertiesDateTimePicker()
        {
            dateTimePickerBirthDate.MaxDate = DateTime.Today.AddHours(+1);
            dateTimePickerBirthDate.MinDate = DateTime.Today.AddYears(-100);

        }
    }
}
