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
    public partial class FormChangeStatusOfPatient : Form
    {
        Patient patient;
        EmployeeModel currentUser;
        private string source;

        public FormChangeStatusOfPatient(string source, Patient patient, EmployeeModel currentUser)
        {
            InitializeComponent();
            this.patient = patient;
            this.currentUser = currentUser;
            this.source = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != currentUser.Password)
            {
                string msg = "Invalid password!";
                FormMessage FormMessage = new FormMessage(msg);
                FormMessage.ShowDialog();
                return;
            }

            if (source == "activate" || source == "deactivate")
            {
                Patient.ChangePatientStatus(patient);

            }
            else if (source == "remove")
            {
                Patient.RemovePatient(patient);
            }
                
            FormPatientList formPatientList = new FormPatientList(currentUser);
            Close();
            formPatientList.ShowDialog();
            
            
        }

        private void FormChangeStatusOfPatient_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormPatientList formPatientList = new FormPatientList(currentUser);
            Close();
            formPatientList.ShowDialog();
            
        }
    }
}
