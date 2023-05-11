using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendarModify : Form
    {
        EmployeeModel currentUser;
        AppointmentModel appointment;

        public FormDoctorCalendarModify(AppointmentModel? appointment, EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            this.appointment = appointment;
            InitializeComponent();

            //List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(DateTime.Today.Date);


        }

        private void FormDoctorCalendarModify_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxOfficeNumber.DataSource = OfficeService.GetCalendarIds();
                // ????dateTimePicker.MaxDate = appointment.
            }
            catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex);
                }

            //Change selecteditem in combobox
            try
            {
                //appointment.IdCalendar
                comboBoxOfficeNumber.SelectedItem = appointment.IdOffice.ToString();
                comboBoxTerm.SelectedItem = AppointmentService.GetTermByTermId(appointment.IdTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormDoctorCalendarDetails formDoctorCalendarDetails = new FormDoctorCalendarDetails(appointment, currentUser);
            this.Hide();
            formDoctorCalendarDetails.ShowDialog();
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.ShowDialog();
            Close();
        }

            try
        {
                if (comboBoxTerm.SelectedIndex < 0)
                    return;
                if (comboBoxOfficeNumber.SelectedIndex < 0)
                    return;

                //appointment.IdTerm = idTerm;
                //appointment.IdOffice = (int)comboBoxOffice.SelectedItem;
                //dateTimePicker
                //Check if the date is from the same month?

                string term = comboBoxTerm.SelectedItem.ToString();
                int idTerm  = AppointmentService.GetIdTerm(term);
                AppointmentService.DoctorModifiesAppointment(appointment.IdAppointment, (int)comboBoxOfficeNumber.SelectedItem,
                    idTerm, dateTimePicker.Value.Day - 1);

            FormDoctorCurrentCalendar formDoctor = new FormDoctorCurrentCalendar(currentUser);
            this.currentUser = currentUser;

                MessageBox.Show("Success!");
            this.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
