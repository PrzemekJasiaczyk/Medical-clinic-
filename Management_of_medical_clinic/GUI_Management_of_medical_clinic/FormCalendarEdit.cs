using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormCalendarEdit : Form
    {
        EmployeeModel currentEmployee;
        CalendarModel calendar;
        Form form;

        public FormCalendarEdit()
        {
            InitializeComponent();
        }

        public FormCalendarEdit(EmployeeModel currentEmployee, CalendarModel calendar, Form form)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            this.calendar = calendar;
            this.form = form;
        }

        private void FormCalendarEdit_Load(object sender, EventArgs e)
        {
            comboBoxActive.SelectedItem = calendar.Active ? "Active" : "Disactive";
            checkIfRequiredFilled();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
            Close();
        }

        public void checkIfRequiredFilled()
        {
            buttonSaveCalendar.Enabled = false;
            if (comboBoxActive.SelectedItem != null && !comboBoxActive.SelectedItem.Equals(calendar.Active ? "Active" : "Disactive")) buttonSaveCalendar.Enabled = true;
        }

        private void comboBoxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void buttonSaveCalendar_Click(object sender, EventArgs e)
        {
            CalendarService.EditCalendar(calendar.IdCalendar, comboBoxActive.SelectedItem == "Active" ? true : false);
            MessageBox.Show("Success, data is saved.");

            FormCalendarsList formCalendars = new FormCalendarsList(currentEmployee);
            formCalendars.ShowDialog();
            Close();
        }
    }
}
