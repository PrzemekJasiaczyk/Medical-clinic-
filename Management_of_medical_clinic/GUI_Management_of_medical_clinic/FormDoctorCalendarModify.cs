﻿using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Migrations;
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
        bool appointmentEx = false;

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
                    int currentUserSpecialization = currentUser.IdSpecialization.Value;
                    List<OfficeModel> offices = OfficeService.GetOfficesData();
                    List<OfficeModel> filteredOffices = offices.Where(o => o.IdSpecialization == currentUserSpecialization).ToList();

                    comboBoxOfficeNumber.DisplayMember = "Name";
                    comboBoxOfficeNumber.DataSource = filteredOffices;

                    //comboBoxOfficeNumber.DataSource = OfficeService.GetCalendarIds();
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
                {
                    MessageBox.Show("You have to select a term");
                    return;
                }

                if (comboBoxOfficeNumber.SelectedIndex < 0)
                {
                    MessageBox.Show("You have to select an office");
                    return;
                }

                DateTime DateInDTP = dateTimePicker.Value;
                dateReference = DateInDTP.ToString("d");
                calendarId = CalendarService.GetCalendarIdByDate(dateReference);
                OfficeModel selectedOffice = (OfficeModel)comboBoxOfficeNumber.SelectedItem;

                if (DoctorsPlanService.CheckIfAppointmentExists(GetIdOfTermFromCombo(), 
                    dateTimePicker.Value.Day, 
                    calendarId, selectedOffice.IdOffice))
                {
                    MessageBox.Show("The office is already booked for this term");
                    return;
                }


                if (creatingNew)
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

            DoctorsDayPlanModel model = new DoctorsDayPlanModel(GetIdOfTermFromCombo(), 
                dateTimePicker.Value.Day,
                calendarId,
                currentUser.IdEmployee,
                (int)comboBoxOfficeNumber.SelectedItem, 
                true);
            DoctorsPlanService.AddPlan(model);
            MessageBox.Show("New plan added successfully");
        }


        private void FindEditAppointemntInDataBase()
        {
            AppDbContext _context = new AppDbContext();
            appointment = _context.DbDoctorsDayPlan.Find(appointment.IdDoctorsDayPlan);
            ChangeOrAddAppointemntData();
            _context.SaveChanges();
        }

        private void ChangeOrAddAppointemntData()
        {
            OfficeModel selectedOffice = (OfficeModel)comboBoxOfficeNumber.SelectedItem;

            appointment.IdOffice = selectedOffice.IdOffice;
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
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser);
            this.Hide();
            formDoctorCalendar.ShowDialog();
            this.Close();
        }
    }
}
