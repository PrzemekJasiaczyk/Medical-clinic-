using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
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

			comboBoxSex.SelectedItem = patient.Sex;
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
			// można to zrobić w klasie Patient ale trzeba by było przekazać wszystkie pola do tego więc nie wiem czy by
			// to było dobre rozwiązanie

			AppDbContext _context = new AppDbContext();
			patient = _context.Patients.Find(patient.PatientId);
			ChangeOrAddPatientData();
			_context.SaveChanges();
		}


		private void ChangeOrAddPatientData()
		{
			// zmiana lub dodanie pacjenta +++ dodanie walidacji

			patient.PESEL = maskedTextBoxPESEL.Text;
			patient.Sex = (EnumSex)comboBoxSex.SelectedItem;

			patient.BirthDate = dateTimePickerBirthDate.Value;

			patient.FirstName = textBoxName.Text;
			patient.LastName = textBoxLastName.Text;
			patient.IsActive = true;
		}

		#region Validation

		PatientService _patientValidator = new();

		private void textBoxName_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidName(textBoxName.Text, out errorMessage))
			{
				e.Cancel = true;
				ErrorProviderFirstName.SetError(textBoxName, errorMessage);
				textBoxName.BackColor = Color.LightPink;
			}
		}

		private void textBoxName_Validated(object sender, EventArgs e)
		{
			ErrorProviderFirstName.SetError(textBoxName, "");
			textBoxName.BackColor = SystemColors.Window;
		}

		private void textBoxLastName_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidName(textBoxLastName.Text, out errorMessage))
			{
				e.Cancel = true;
				ErrorProviderLastName.SetError(textBoxLastName, errorMessage);
				textBoxLastName.BackColor = Color.LightPink;
			}
		}

		private void textBoxLastName_Validated(object sender, EventArgs e)
		{
			ErrorProviderLastName.SetError(textBoxLastName, "");
			textBoxLastName.BackColor = SystemColors.Window;
		}

		private void maskedTextBoxPESEL_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidPESEL(maskedTextBoxPESEL.Text, dateTimePickerBirthDate.Value, (EnumSex)comboBoxSex.SelectedItem, out errorMessage))
			{
				e.Cancel = true;
				ErrorProviderPESEL.SetError(maskedTextBoxPESEL, errorMessage);
				maskedTextBoxPESEL.BackColor = Color.LightPink;
			}
		}

		private void maskedTextBoxPESEL_Validated(object sender, EventArgs e)
		{
			ErrorProviderPESEL.SetError(maskedTextBoxPESEL, "");
			maskedTextBoxPESEL.BackColor = SystemColors.Window;
		}

		#endregion

		private void dateTimePickerBirthDate_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidDate(dateTimePickerBirthDate.Value, out errorMessage))
			{
				e.Cancel = true;
				ErrorProviderBirthDate.SetError(dateTimePickerBirthDate, errorMessage);
				dateTimePickerBirthDate.CalendarMonthBackground = Color.LightPink;
			}

		}

		private void dateTimePickerBirthDate_Validated(object sender, EventArgs e)
		{
			ErrorProviderBirthDate.SetError(dateTimePickerBirthDate, "");
			dateTimePickerBirthDate.CalendarMonthBackground = SystemColors.Window;
		}
	}
}
