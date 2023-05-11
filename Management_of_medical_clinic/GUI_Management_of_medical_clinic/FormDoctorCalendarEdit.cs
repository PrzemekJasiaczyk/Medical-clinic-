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
    public partial class FormDoctorCalendarEdit : Form
    {
        AppointmentModel appointment;
        public FormDoctorCalendarEdit(AppointmentModel appointment)
        {
            this.appointment = appointment;
            InitializeComponent();
        }

        private void FormDoctorCalendarEdit_Load(object sender, EventArgs e)
        {

            //Insert data to combobox
            try
            {
                comboBoxOffice.DataSource = OfficeService.GetCalendarIds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            //Change selecteditem in combobox
            try
            {
                comboBoxOffice.SelectedItem = appointment.IdOffice.ToString();
                comboBoxTerm.SelectedIndex = appointment.IdTerm - 2;
                //comboBoxTerm.SelectedIndex = appointment.IdTerm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTerm.SelectedIndex < 0)
                    return;
                if (comboBoxOffice.SelectedIndex < 0)
                    return;

                string term = comboBoxTerm.SelectedItem.ToString();
                int idTerm = AppointmentService.GetIdTerm(term);
                //appointment.IdTerm = idTerm;
                //appointment.IdOffice = (int)comboBoxOffice.SelectedItem;
                //dateTimePicker
                //Check if the date is from the same month?
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
