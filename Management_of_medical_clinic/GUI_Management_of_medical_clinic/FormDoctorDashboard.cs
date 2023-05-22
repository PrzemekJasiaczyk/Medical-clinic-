using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.VisualBasic;
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
    public partial class FormDoctorDashboard : Form
    {
        EmployeeModel currentUser;

        public FormDoctorDashboard()
        {
            InitializeComponent();
        }

        public FormDoctorDashboard(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            label1.Text = "Welcome, " + currentUser.FirstName;
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            bool isNewCalendar = true;
            //bool isNewCalendar = false; roboczo dałem true
            List<CalendarModel> calendars = CalendarService.GetCalendarData();
            
            foreach (CalendarModel calendar in calendars)
            {                
                if (calendar.IdEmployee == currentUser.IdEmployee && calendar.Active == false)
                {
                    isNewCalendar = true;        
                }
            }
            if (isNewCalendar == true)
            {
                FormDoctorCalendar formDoctor = new FormDoctorCalendar(currentUser);
                formDoctor.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You don't have any new calendar to check", "Information", MessageBoxButtons.OK);
            }           
            
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void buttonCurrentCalendar_Click(object sender, EventArgs e)
        {
            IsCalendarActiveForCurrentMonth();
        }


        private void IsCalendarActiveForCurrentMonth()
        {
            bool isCurrentCalendar = false;
            string currentMonthYear = DateTime.Today.ToString("MM-yyyy");


            List<CalendarModel> calendars = CalendarService.GetCalendarData();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentUser.IdEmployee && 
                    calendar.Active == true && 
                    calendar.DateReference == currentMonthYear)
                {
                    isCurrentCalendar = true;
                    break;
                }
            }

            if (isCurrentCalendar)
            {
                ToFormCurrentCalendar();
            }
            else
            {
                MessageBox.Show("Brak takich");
            }
            
        }
        private void ToFormCurrentCalendar()
        {
            FormDoctorCurrentCalendar formCurrentCalendar = new FormDoctorCurrentCalendar(currentUser);
            this.Hide();
            formCurrentCalendar.ShowDialog();
            this.Close();
        }
    }
}
