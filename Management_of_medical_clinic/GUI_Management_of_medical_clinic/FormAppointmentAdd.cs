using GUI_Management_of_medical_clinic;
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
        string dateReference;
        int selectedDay;
        int calendarId;
        EmployeeModel currentEmployee;

        public FormAppointmentAdd(DateTime date, EmployeeModel currentEmployee)
        {
            selectedDate = date;
            selectedDay = date.Day;


            dateReference = selectedDate.ToString("d");
            calendarId = CalendarService.GetCalendarIdByDate(dateReference);

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
                    comboBoxDoctor.Items.Add(employeeModel.IdEmployee + "-" + employeeModel.FirstName + " " + employeeModel.LastName);
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

            //DoctorsPlanService.CheckIfDoctorHasPlanForCurrentDay((int)comboBoxDoctor.SelectedItem, selectedDay, calendarId);
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
            string checkedTerms = "";
            for (int i = 0; i < checkedListBoxTerms.Items.Count; i++)
            {

                if (checkedListBoxTerms.GetItemChecked(i))
                {
                    checkedTerms = checkedTerms + "," + i.ToString();
                }

            }
            if (checkedTerms.Length == 0)
            {
                MessageBox.Show("No terms have been selected");
                return;
            }
            else
            {
                checkedTerms = checkedTerms.Remove(0, 1);
            }


            if (calendarId != -1)
            {
                try
                {
                    DoctorsDayPlanModel model = new DoctorsDayPlanModel(checkedTerms, selectedDay, calendarId, (int)comboBoxDoctor.SelectedItem, (int)comboBoxOffice.SelectedItem, true);
                    DoctorsPlanService.AddAppointment(model);
                    MessageBox.Show("New plan added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Calendar for current month hasn't been created");
                return;
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

            string[] employeeParts = selectedEmployee.Split('-');

            int selectedEmployeeId = int.Parse(employeeParts[0]);

            List<EmployeeModel> employees = EmployeeService.GetEmployeesData();
            EmployeeModel doctor = employees.FirstOrDefault(e => e.IdEmployee == selectedEmployeeId);
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();


            if (doctor == null) return;

            foreach (OfficeModel office in offices)
            {
                if (office.IdSpecialization == doctor.IdSpecialization)
                {

                    SpecializationModel specalization = specializations.FirstOrDefault(e => e.IdSpecialization == office.IdSpecialization);
                    comboBoxOffice.Items.Add(office.IdOffice + "-" + specalization.Name + " " + office.Number);

                }
            }

            //string checkedTerms = DoctorsPlanService.CheckIfDoctorHasPlanForCurrentDay((int)comboBoxDoctor.SelectedItem, selectedDay, calendarId);
            //MessageBox.Show((int)comboBoxDoctor.SelectedItem + selectedDay.ToString() + calendarId.ToString());
            //MessageBox.Show(checkedTerms);
        }
    }
}
