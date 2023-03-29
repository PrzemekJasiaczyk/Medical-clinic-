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
    public partial class FormAddEditPatient : Form
    {
        public FormAddEditPatient()
        {
            InitializeComponent();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            //buttonAddPatient
            ChangeVisibleDataGridView(false);
            ChangeTitle("Add new patient");
        }


        private void ChangeVisibleDataGridView(bool tr)
        {
            // if tr = true - DGV will be visible
            // if tr = false - DGV will be hidden

            //bool DGV_visible = false;
            bool Other_visible = true;

            if (tr == true)
            {
                //DGV_visible = true;
                Other_visible = false;
            }

            //dataGridViewEmployees.Visible = DGV_visible;

            //Label 8x
            labelAddEditNewPatient.Visible = Other_visible;
            labelDateLastVisit.Visible = Other_visible;
            labelDateOfBirth.Visible = Other_visible;
            labelLastName.Visible = Other_visible;
            labelName.Visible = Other_visible;
            labelPESEL.Visible = Other_visible;
            labelSex.Visible = Other_visible;
            labelStatus.Visible = Other_visible;

            //TEXTBOX 2x
            textBoxLastName.Visible = Other_visible;
            textBoxName.Visible = Other_visible;

            //COMBOBOX 2x

            comboBoxSex.Visible = Other_visible;
            comboBoxStatus.Visible = Other_visible;

            // MASKEDTEXTBOX 3x
            maskedTextBoxDateLastVisit.Visible = Other_visible;
            maskedTextBoxDateOfBirth.Visible = Other_visible;
            maskedTextBoxPESEL.Visible = Other_visible;

            // BUTTON 2x
            buttonAddEditPatient.Visible = Other_visible;
            buttonCancel.Visible = Other_visible;
        }


        private void ChangeTitle(string title)
        {
            labelAddEditNewPatient.Text = title;
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            //EDIT PATIENT

            ChangeVisibleDataGridView(false);
            ChangeTitle("Edit patient");
        }

        private void FormAddEditPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
