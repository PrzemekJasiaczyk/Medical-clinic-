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
    public partial class FormDeletingConfirmation : Form
    {
        OfficeModel office;
        public FormDeletingConfirmation()
        {
            InitializeComponent();
        }

        public FormDeletingConfirmation(OfficeModel office)
        {
            this.office = office;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            OfficeService.RemoveOfficeById(office.IdOffice);

            MessageBox.Show("Data was successfully deleted.");
            Hide();
            Close();
        }
    }
}
