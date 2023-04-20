using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System.ComponentModel;

namespace GUI_Management_of_medical_clinic
{
	public partial class FormAddEditPatient : Form
	{
		EmployeeModel _currentUser;
		Patient _patient;
		bool _isNewPatient = false;

		// Const cannot have 'Color' type
		readonly Color _errorColor = Color.LightPink;
		readonly Color _normalColor = SystemColors.Window;


		public FormAddEditPatient(EmployeeModel currentUser, Patient? patient)
		{
			InitializeComponent();
			CompleteComboBox();
			_currentUser = currentUser;
			_patient = patient!;
		}

		private void FormAddEditPatient_Load(object sender, EventArgs e)
		{
			SetPropertiesDateTimePicker();

			if (_patient == null)
			{
				_isNewPatient = true;
				return;
			}
			CompleteControls();
		}

		private void buttonAddEditPatient_Click(object sender, EventArgs e)
		{
			using (AppDbContext context = new())
			{
				if (isCompletedForm())
				{
					if (_isNewPatient == true)
					{
						_patient = new Patient();

						ChangeOrAddPatientData();

						Patient.AddPatient(_patient, context);
					}
					else
					{
						FindEditPatientInDataBase();
					}

					ComeToPatientList();
				}
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			ComeToPatientList();
		}

		#region Validation

		PatientService _patientValidator = new();

		private void textBoxName_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidName(textBoxName.Text, out errorMessage))
			{
				e.Cancel = false;
				ErrorProviderFirstName.SetError(textBoxName, errorMessage);
				textBoxName.BackColor = _errorColor;
			}
		}

		private void textBoxName_Validated(object sender, EventArgs e)
		{
			string errorMessage;

			if (_patientValidator.IsValidName(textBoxName.Text, out errorMessage))
			{
				ErrorProviderFirstName.SetError(textBoxName, "");
				textBoxName.BackColor = _normalColor;
			}
		}

		private void textBoxLastName_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidName(textBoxLastName.Text, out errorMessage))
			{
				e.Cancel = false;
				ErrorProviderLastName.SetError(textBoxLastName, errorMessage);
				textBoxLastName.BackColor = _errorColor;
			}
		}

		private void textBoxLastName_Validated(object sender, EventArgs e)
		{
			string errorMessage;

			if (_patientValidator.IsValidName(textBoxLastName.Text, out errorMessage))
			{
				ErrorProviderLastName.SetError(textBoxLastName, "");
				textBoxLastName.BackColor = _normalColor;
			}
		}

		private void maskedTextBoxPESEL_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidPESEL(maskedTextBoxPESEL.Text, dateTimePickerBirthDate.Value, (EnumSex)comboBoxSex.SelectedItem, out errorMessage))
			{
				e.Cancel = false;
				ErrorProviderPESEL.SetError(maskedTextBoxPESEL, errorMessage);

				if (_isNewPatient == false)
				{
					ErrorProviderPESEL.SetError(maskedTextBoxPESEL, "");
					return;
				}

				maskedTextBoxPESEL.BackColor = _errorColor;
			}
		}

		private void maskedTextBoxPESEL_Validated(object sender, EventArgs e)
		{
			string errorMessage;

			if (_patientValidator.IsValidPESEL(maskedTextBoxPESEL.Text, dateTimePickerBirthDate.Value, (EnumSex)comboBoxSex.SelectedItem, out errorMessage))
			{
				ErrorProviderPESEL.SetError(maskedTextBoxPESEL, "");
				maskedTextBoxPESEL.BackColor = _normalColor;
			}
		}

		private void dateTimePickerBirthDate_Validating(object sender, CancelEventArgs e)
		{
			string errorMessage;

			if (!_patientValidator.IsValidDate(dateTimePickerBirthDate.Value, out errorMessage))
			{
				e.Cancel = false;
				ErrorProviderBirthDate.SetError(dateTimePickerBirthDate, errorMessage);
				dateTimePickerBirthDate.CalendarMonthBackground = _errorColor;
			}

		}

		private void dateTimePickerBirthDate_Validated(object sender, EventArgs e)
		{
			string errorMessage;

			if (_patientValidator.IsValidDate(dateTimePickerBirthDate.Value, out errorMessage))
			{
				ErrorProviderBirthDate.SetError(dateTimePickerBirthDate, "");
				dateTimePickerBirthDate.CalendarMonthBackground = _normalColor;
			}
		}

		private void comboBoxSex_SelectedValueChanged(object sender, EventArgs e)
		{
			maskedTextBoxPESEL.Focus();
			comboBoxSex.Focus();
		}

		private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
		{
			maskedTextBoxPESEL.Focus();
			dateTimePickerBirthDate.Focus();
		}

		private bool isCompletedForm()
		{
			List<bool> conditions = new()
			{
				string.IsNullOrEmpty(textBoxName.Text),
				string.IsNullOrEmpty(textBoxLastName.Text),
				string.IsNullOrEmpty(maskedTextBoxPESEL.Text),
				!string.IsNullOrEmpty(ErrorProviderFirstName.GetError(textBoxName)),
				!string.IsNullOrEmpty(ErrorProviderLastName.GetError(textBoxLastName)),
				!string.IsNullOrEmpty(ErrorProviderPESEL.GetError(maskedTextBoxPESEL)),
				!string.IsNullOrEmpty(ErrorProviderBirthDate.GetError(dateTimePickerBirthDate)),
			};

			if (conditions.Contains(true))
			{
				return false;
			}

			return true;
		}

		private void FormAddEditPatient_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}

		#endregion

		#region Custom Methods

		private void ComeToPatientList()
		{
			ActiveForm.Close();
			FormPatientList formPatientList = new(_currentUser);
			formPatientList.ShowDialog();
		}

		private void CompleteComboBox()
		{
			comboBoxSex.DataSource = Enum.GetValues(typeof(EnumSex));
		}

		private void CompleteControls()
		{
			textBoxLastName.Text = _patient.LastName;
			textBoxName.Text = _patient.FirstName;
			dateTimePickerBirthDate.Value = _patient.BirthDate;
			maskedTextBoxPESEL.Text = _patient.PESEL;
			comboBoxSex.SelectedItem = _patient.Sex;
		}

		internal void ReadOnlyControls()
		{
			textBoxLastName.ReadOnly = true;
			textBoxName.ReadOnly = true;
			dateTimePickerBirthDate.Enabled = false;
			maskedTextBoxPESEL.ReadOnly = true;
			comboBoxSex.Enabled = false;
		}

		internal void ChangeTitle(string title)
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
			using (AppDbContext context = new())
			{
				_patient = context.Patients.Find(_patient.PatientId);
				ChangeOrAddPatientData();
				context.SaveChanges();
			}
		}

		private void ChangeOrAddPatientData()
		{
			_patient.PESEL = maskedTextBoxPESEL.Text;
			_patient.Sex = (EnumSex)comboBoxSex.SelectedItem;
			_patient.BirthDate = dateTimePickerBirthDate.Value;
			_patient.FirstName = textBoxName.Text;
			_patient.LastName = textBoxLastName.Text;
			_patient.IsActive = true;
		}

		#endregion

	}
}
