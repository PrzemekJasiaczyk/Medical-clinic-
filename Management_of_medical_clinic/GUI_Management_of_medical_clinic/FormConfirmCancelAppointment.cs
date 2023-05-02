using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormConfirmCancelAppointment : Form
    {
        EmployeeModel currentUser;
        AppointmentModel appointment;

        public FormConfirmCancelAppointment(EmployeeModel currentUser, AppointmentModel appointment)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.appointment = appointment;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            UserModel user = UserService.GetUserByEmployeeId(currentUser);

            if (textBoxPassword.Text != user.Password)
            {
                string msg = "Invalid password!";
                FormMessage formMessage = new FormMessage(msg);
                formMessage.ShowDialog();
                return;
            }

            using (AppDbContext _context = new AppDbContext())
            {
                appointment.PatientId = null;
                appointment.IsActive = true;

                _context.Entry(appointment).State = EntityState.Modified;
                _context.SaveChanges();
            }

            string msg2 = "Appointment cancelled.";
            FormMessage formMessage2 = new FormMessage(msg2);
            formMessage2.ShowDialog();

            List<Form> otwarteOkna = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form otwarteOkno in otwarteOkna)
            {
                otwarteOkno.Hide();
            }

            FormListAppointment formListAppointment = new FormListAppointment(currentUser);
            formListAppointment.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            List<Form> otwarteOkna = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form otwarteOkno in otwarteOkna)
            {
                otwarteOkno.Hide();
            }

            FormListAppointment formListAppointment = new FormListAppointment(currentUser);
            formListAppointment.ShowDialog();
        }
    }
}
