using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore.Storage;
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
        bool newPatinet = false;

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
                //dateTimePickerBirthDate.Value = DateTime.Now;
                newPatinet = true;
                return;
            }

            ChangeTitle("Edit patient");
            CompleteControls();

        }

        private void buttonAddEditPatient_Click(object sender, EventArgs e)
        {
            if (newPatinet == true) 
            {
                patient = new Patient();
                //AddNewPatientToDataBase();
                // dodawanie działa

                //v2
                ChangeOrAddPatientData();
                Patient.AddPatient(patient);

            }
            else
            {
                FindEditPatientInDataBase();
            }
            ComeToPatientList();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // temp
            ComeToPatientList();
        }


        // ----------------------------------------------------------- FUNCTIONS ----------------------------------------------------------------- //


        private void ComeToPatientList()
        {
            FormAddEditPatient.ActiveForm.Close();
            FormPatientList formPatientList = new FormPatientList(currentUser);
            formPatientList.ShowDialog();
        }


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

        private void FindEditPatientInDataBase()
        {
            // szukanie w bazie pacjenta edytowanego, zmienienie mu pól i zapisanie zmian

            using (AppDbContext db = new AppDbContext())
            {
                Patient editPatient = Patient.FindPatient((int)patient.PatientId);

               if (editPatient != null)
               {
                    ChangeOrAddPatientData();
                    db.SaveChanges();
               }
            }
        }

        private void AddNewPatientToDataBase()
        {
            using (AppDbContext db = new AppDbContext())
            {
                ChangeOrAddPatientData();
                db.Patients.Add(patient);
                db.SaveChanges();
            }
        }


        private void ChangeOrAddPatientData()
        {
            // zmiana lub dodanie pacjenta +++ dodanie walidacji
            // jesli newPatient = true -- dodaje nowy obiekt, inaczej zamieniam stary

            patient.PESEL = maskedTextBoxPESEL.Text;
            patient.Sex = (EnumSex)comboBoxSex.SelectedItem;  // pewnie źle

            patient.BirthDate = dateTimePickerBirthDate.Value;

            patient.FirstName = textBoxName.Text;
            patient.LastName = textBoxLastName.Text;
            patient.IsActive = true;
        }
    }
}
