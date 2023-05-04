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

namespace GUI_Management_of_medical_clinic
{
    public partial class FormAppointmentAdd : Form
    {
        DateTime selectedDate;
        int selectedDay;
        EmployeeModel currentEmployee;

        public FormAppointmentAdd(DateTime date, EmployeeModel currentEmployee)
        {
            selectedDate = date;
            selectedDay = date.Day;
            this.currentEmployee = currentEmployee;

            InitializeComponent();

            foreach (EnumTerms term in Enum.GetValues(typeof(EnumTerms)))
            {
                checkedListBoxTerms.Items.Add(DoctorsPlanService.GetTermDescription(term));
            }

            try
            {
                foreach (EmployeeModel employeeModel in EmployeeService.GetDoctors())
                {
                    comboBoxDoctor.Items.Add("ID: " + employeeModel.IdEmployee + "   " + employeeModel.FirstName + "   " + employeeModel.LastName);
                }
                //comboBoxOffice.DataSource = OfficeService.GetCalendarIds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            try
            {
                //comboBoxDoctor.SelectedIndex = 0;
                //comboBoxOffice.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Some data might be missing");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void FormAppointmentAdd_Load(object sender, EventArgs e)
        {
            labelDay.Text = "Selected Date: " + selectedDate.ToString("d");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorsDayPlanModel model = new DoctorsDayPlanModel("1,2,3", selectedDay, 1, (int)comboBoxDoctor.SelectedItem, (int)comboBoxOffice.SelectedItem, true);
                DoctorsPlanService.AddAppointment(model);
                MessageBox.Show("New plan added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new FormCalendar(currentEmployee);
            this.Hide();
            formCalendar.Show();
            this.Hide();
        }

        private void comboBoxOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOffice.Items.Clear();

            List<OfficeModel> offices = OfficeService.GetOfficesData();
            if (comboBoxDoctor.SelectedIndex < 0)
            {
                return;
            }

            string selectedEmployee = comboBoxDoctor.SelectedItem.ToString();
            string[] employeeParts = selectedEmployee.Split(' ');
            int selectedEmployeeId = int.Parse(employeeParts[1]);
            List<EmployeeModel> employees = EmployeeService.GetEmployeesData();
            EmployeeModel doctor = employees.FirstOrDefault(e => e.IdEmployee == selectedEmployeeId);
            if (doctor == null) return;

            foreach (OfficeModel office in offices)
            {
                if (office.IdSpecialization == doctor.IdSpecialization)
                {
                    comboBoxOffice.Items.Add("Number: " + office.Number + "   " + office.Info);
                }
            }
        }
    }
}
