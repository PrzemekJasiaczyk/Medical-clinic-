using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendarModify : Form
    {
        EmployeeModel currentUser;
        DoctorsDayPlanModel appointment;
        int IdcalendarModel;
        int calendarId;
        bool creatingNew;

        int selectedDay;
        string dateReference;
        DateTime selectedDate;

        public FormDoctorCalendarModify(DoctorsDayPlanModel? appointment, EmployeeModel currentUser, bool creatingNew, DateTime date)
        {
            this.currentUser = currentUser;
            this.appointment = appointment;
            this.creatingNew = creatingNew;
            if(date!=null)
            {
                selectedDate = date;
                selectedDay = date.Day;

                dateReference = selectedDate.ToString("d");
                calendarId = CalendarService.GetCalendarIdByDate(dateReference);
            }
            

            InitializeComponent();
        }

        private void FormDoctorCalendarModify_Load(object sender, EventArgs e)
        {
            labelModifyAppointment.Text = creatingNew ? "Creating new appointment" : "Modify Appointment";

            if(creatingNew)
            {
                comboBoxOfficeNumber.DataSource = OfficeService.GetCalendarIds();
            }
            else
            {
                try
                {
                    comboBoxOfficeNumber.DataSource = OfficeService.GetCalendarIds();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

                //Change selecteditem in combobox
                try
                {
                    dateTimePicker.Value = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);
                    comboBoxOfficeNumber.SelectedItem = appointment.IdOffice.ToString();
                    comboBoxTerm.SelectedItem = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ToFormDetails();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTerm.SelectedIndex < 0)
                    return;
                if (comboBoxOfficeNumber.SelectedIndex < 0)
                    return;
                //ToDo available date
                //ToDo correct office




                //AppointmentService.DoctorModifiesAppointment(appointment.IdDoctorsDayPlan, (int)comboBoxOfficeNumber.SelectedItem,
                //idTerm, dateTimePicker.Value.Day);
                if(creatingNew)
                {
                    CreateAppointemntInDataBase();
                }
                else
                {
                    FindEditAppointemntInDataBase();
                }
                

                MessageBox.Show("Successfully changed the data!");

                ToFormCalendar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private int GetIdOfTermFromCombo()
        {
            string term = comboBoxTerm.SelectedItem.ToString();
            int idTerm = AppointmentService.GetIdOfTerm(term);
            return idTerm;
        }
        private void CreateAppointemntInDataBase()
        {
            int selectedDay = dateTimePicker.Value.Day;

            selectedDate = dateTimePicker.Value;
            dateReference = selectedDate.ToString("d");
            calendarId = CalendarService.GetCalendarIdByDate(dateReference);

            /* DoctorsDayPlanModel model = new DoctorsDayPlanModel(GetIdOfTermFromCombo(),
                 dateTimePicker.Value.Day,
                 calendarId,
                 currentUser.IdEmployee,
                 (int)comboBoxOfficeNumber.SelectedItem, 
                 true);
            DoctorsPlanService.AddPlan(model);*/
            MessageBox.Show("New plan added successfully");
        }
        private void FindEditAppointemntInDataBase()
        {
            AppDbContext _context = new AppDbContext();
            appointment = _context.DbDoctorsDayPlan.Find(appointment.IdDoctorsDayPlan);
            ChangeOrAppointemntData();
            _context.SaveChanges();
        }

        private void ChangeOrAppointemntData()
        {
            appointment.IdOffice = (int)comboBoxOfficeNumber.SelectedItem;
            appointment.IdOfTerm = GetIdOfTermFromCombo();
            appointment.IdDay = dateTimePicker.Value.Day;
        }

        private void ToFormDetails()
        {
            FormDoctorCalendarDetails formDoctorCalendarDetails = new FormDoctorCalendarDetails(appointment, currentUser);
            this.Hide();
            formDoctorCalendarDetails.ShowDialog();
            this.Close();
        }

        private void ToFormCalendar()
        {
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser,appointment);
            this.Hide();
            formDoctorCalendar.ShowDialog();
            this.Close();
        }
    }
}
