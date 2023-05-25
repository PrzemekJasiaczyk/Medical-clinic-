using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
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
    public partial class FormEmployeeEdit : Form
    {
        EmployeeModel employee;
        EmployeeModel currentUser;

        Color _errorColor = Color.LightPink;
        Color _normalColor = SystemColors.Window;
        public FormEmployeeEdit(EmployeeModel emp, EmployeeModel currentU)
        {
            InitializeComponent();
            this.employee = emp;
            currentUser = currentU;
        }

        private void FormEmployeeEdit_Load(object sender, EventArgs e)
        {
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();

            foreach (SpecializationModel specialization in specializations)
            {
                checkedListBoxSpecialization.Items.Add(specialization.Name);
            }

            comboBoxRole.DataSource = Enum.GetValues(typeof(EnumEmployeeRoles));
            comboBoxSex.DataSource = Enum.GetValues(typeof(EnumSex));

            comboBoxRole.SelectedItem = employee.Role;
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxPESEL.Text = employee.PESEL;
            dateTimePickerDate.Text = (employee.DateOfBirth);

            textBoxAddress.Text = employee.CorrespondenceAddress;
            textBoxEmail.Text = employee.Email;
            textBoxPhone.Text = employee.PhoneNumber;
            comboBoxSex.SelectedItem = employee.Sex;
            if (employee.IdSpecialization != null)
            {

                checkedListBoxSpecialization.SelectedItem = SpecializationService.GetSpecializationNameById((int)employee.IdSpecialization);
            }

            checkIfMedicalDoctor();

        }
        private void checkForms()
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxPESEL.Text.Length == 11 && comboBoxRole.Text.Length > 0 && comboBoxSex.SelectedItem != null)
                buttonConfirm.Enabled = true;
            else
                buttonConfirm.Enabled = false;
        }

        PatientService _patientValidator = new();
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string errorMessage;

            if (!_patientValidator.IsValidPESEL(textBoxPESEL.Text, dateTimePickerDate.Value, (EnumSex)comboBoxSex.SelectedItem, out errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            (string stringEmail, bool booleanEmail) = EmployeeService.validateEmail(textBoxEmail.Text, textBoxFirstName.Text);
            if (!booleanEmail)
            {
                MessageBox.Show(stringEmail);
                return;
            }

            (string stringPhone, bool booleanPhone) = EmployeeService.validatePhone(textBoxPhone.Text);
            if (!booleanPhone)
            {
                MessageBox.Show(stringPhone);
                return;
            }

            if (comboBoxRole.Text == "MedicalDoctor" && checkedListBoxSpecialization.CheckedItems.Count == 0)
            {
                MessageBox.Show("A specialization needs to be selected");
                return;
            }

            EnumSex enumSex = (EnumSex)Enum.Parse(typeof(EnumSex), comboBoxSex.SelectedItem.ToString());
            EnumEmployeeRoles enumRole = (EnumEmployeeRoles)Enum.Parse(typeof(EnumEmployeeRoles), comboBoxRole.SelectedItem.ToString());
            int idSpecialization;

            if (comboBoxRole.Text == "MedicalDoctor")
            {
                idSpecialization = SpecializationService.getSpecializationIdByName(checkedListBoxSpecialization.SelectedItem.ToString());
                EmployeeModel.EditEmployeeWithSpecialization(employee.IdEmployee, textBoxFirstName.Text, textBoxLastName.Text, textBoxPESEL.Text, dateTimePickerDate.Text,
                enumRole, textBoxAddress.Text, textBoxEmail.Text, textBoxPhone.Text, enumSex, idSpecialization, true);
            }
            else
            {
                EmployeeModel.EditEmployee(employee.IdEmployee, textBoxFirstName.Text, textBoxLastName.Text, textBoxPESEL.Text, dateTimePickerDate.Text,
                enumRole, textBoxAddress.Text, textBoxEmail.Text, textBoxPhone.Text, enumSex, true);
            }

            MessageBox.Show("Employee’s data changed.");

            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            Hide();
            employeeList.ShowDialog();
            Close();
        }

        public void checkIfMedicalDoctor()
        {
            if (comboBoxRole.Text == "MedicalDoctor")
            {
                checkedListBoxSpecialization.Visible = true;
                labelSpecialization.Visible = true;
            }
            else
            {
                checkedListBoxSpecialization.Visible = false;
                labelSpecialization.Visible = false;
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void textBoxPESEL_TextChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkForms();
            checkIfMedicalDoctor();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            Hide();
            employeeList.ShowDialog();
            Close();
        }

        private void correspAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void checkedListBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBoxSpecialization.SelectedIndex;
            foreach (int i in checkedListBoxSpecialization.CheckedIndices)
            {
                checkedListBoxSpecialization.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkedListBoxSpecialization.SetItemCheckState(selectedIndex, CheckState.Checked);
        }

        private void comboBoxRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            checkIfMedicalDoctor();
            checkForms();
        }

        private void textBoxPESEL_TextChanged_1(object sender, EventArgs e)
        {
            checkForms();
        }

        private void checkedListBoxSpecialization_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBoxSpecialization.SelectedIndex;
            foreach (int i in checkedListBoxSpecialization.CheckedIndices)
            {
                checkedListBoxSpecialization.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkedListBoxSpecialization.SetItemCheckState(selectedIndex, CheckState.Checked);
        }

        private void textBoxFirstName_TextChanged_1(object sender, EventArgs e)
        {
            checkForms();
        }

        private void textBoxLastName_TextChanged_1(object sender, EventArgs e)
        {
            checkForms();
        }

        private void textBoxPESEL_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxPESEL_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}