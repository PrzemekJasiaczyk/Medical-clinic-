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
    public partial class FormMessage : Form
    {
        private string msg;

        public FormMessage(string msg)
        {
            InitializeComponent();
            this.msg = msg;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            labelMessage.Text = msg;
        }
    }
}
