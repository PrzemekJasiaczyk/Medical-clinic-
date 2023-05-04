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
            //checkedListBoxTerms.Items.AddRange(typeof(EnumTerms).GetEnumNames());

            foreach (EnumTerms term in Enum.GetValues(typeof(EnumTerms)))
            {
                checkedListBoxTerms.Items.Add(DoctorsPlanService.GetTermDescription(term));
            }


            try
            {
                comboBoxDoctor.DataSource = EmployeeService.GetDoctorIds();
                comboBoxOffice.DataSource = OfficeService.GetCalendarIds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            try
            {
                comboBoxDoctor.SelectedIndex = 0;
                comboBoxOffice.SelectedIndex = 0;
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
                if (comboBoxDoctor.SelectedIndex < 0) return;
                if (comboBoxOffice.SelectedIndex < 0) return;

                DoctorsDayPlanModel model = new DoctorsDayPlanModel();
                DoctorsPlanService.AddAppointment(model);
                MessageBox.Show("Success!");
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
    }
}
