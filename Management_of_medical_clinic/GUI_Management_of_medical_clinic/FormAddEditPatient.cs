using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System.ComponentModel;
using System.Windows.Forms;


namespace GUI_Management_of_medical_clinic
{
    public partial class FormAddEditPatient : Form
    {
        EmployeeModel currentUser;
        Patient patient;
        bool isNewPatient = false;

        // Color type cannot be declared as const
        Color _errorColor = Color.LightPink;
        Color _normalColor = SystemColors.Window;


        public FormAddEditPatient(EmployeeModel currentUser, Patient? patient)
        {
            InitializeComponent();
            CompleteComboBox();
            this.currentUser = currentUser;
            this.patient = patient;
        }

        private void FormAddEditPatient_Load(object sender, EventArgs e)
        {
            SetPropertiesDateTimePicker();

            if (patient == null)
            {
                isNewPatient = true;
                return;
            }
            CompleteControls();

        }

        private void buttonAddEditPatient_Click(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (isCompletedForm())
                {
                    if (isNewPatient == true)
                    {
                        patient = new Patient();

                        ChangeOrAddPatientData();

                        Patient.AddPatient(patient, context);
                    }
                    else
                    {
                        FindEditPatientInDataBase();
                    }

                    ComeToPatientList();
                }
            }

            string msg= "Incorrect data. The following errors occurred:\n\n";

            if (ErrorProviderFirstName.GetError(textBoxName) != string.Empty)
            {
                msg += "• " + ErrorProviderFirstName.GetError(textBoxName) + ".\n";

            }

            if (ErrorProviderLastName.GetError(textBoxLastName) != string.Empty)
            {
                msg += "• Last " + ErrorProviderLastName.GetError(textBoxLastName) + ".\n";
                
            }

            if(ErrorProviderPESEL.GetError(maskedTextBoxPESEL) != "")
            {
                msg += "• " + ErrorProviderPESEL.GetError(maskedTextBoxPESEL) + "\n";
            }

            if (ErrorProviderBirthDate.GetError(dateTimePickerBirthDate) != string.Empty)
            {
                msg += "• " + ErrorProviderBirthDate.GetError(dateTimePickerBirthDate);
            }

            FormMessage formMessage = new FormMessage(msg);

            //formMessage.Size=formMessage.MaximumSize;
            //formMessage.Controls["buttonOK"].Size = formMessage.Controls["buttonOK"].MaximumSize;
            //formMessage.Controls["panel1"].Size = formMessage.Controls["panel1"].MaximumSize;

            //formMessage.Controls["buttonOK"].Location = new Point(75, 250);
            //formMessage.Controls["panel1"].Location = new Point(0, 225);

            formMessage.ShowDialog();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // temps
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

                if (isNewPatient == false)
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

        // ----------------------------------------------------------- FUNCTIONS ----------------------------------------------------------------- //


        private void maxLengthInTextBox(TextBox textBox, int MaxNumberOfCharacters)
        {
            if (textBox.TextLength > MaxNumberOfCharacters)
            {
                textBox.Text = textBox.Text.Substring(0, MaxNumberOfCharacters);
                textBox.SelectionStart = MaxNumberOfCharacters;
            }
        }


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
            AppDbContext _context = new AppDbContext();
            patient = _context.Patients.Find(patient.PatientId);
            ChangeOrAddPatientData();
            _context.SaveChanges();
        }


        private void ChangeOrAddPatientData()
        {
            patient.PESEL = maskedTextBoxPESEL.Text;
            patient.Sex = (EnumSex)comboBoxSex.SelectedItem;

            patient.BirthDate = dateTimePickerBirthDate.Value;

            patient.FirstName = textBoxName.Text;
            patient.LastName = textBoxLastName.Text;
            patient.IsActive = true;
        }

        #endregion

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            maxLengthInTextBox(textBoxName,60);
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            maxLengthInTextBox(textBoxLastName, 60);
        }
    }
}
