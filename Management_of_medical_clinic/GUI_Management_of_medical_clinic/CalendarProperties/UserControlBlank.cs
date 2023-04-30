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
    public partial class UserControlBlank : UserControl
    {
        DateTime? date = new DateTime();

        public UserControlBlank(DateTime? date)
        {
            InitializeComponent();
            this.date = date;


        }

        private void UserControlBlank_Load(object sender, EventArgs e)
        {
            if (date == null) return;

            labelNumberOfDay.Text = ((DateTime)date).Day.ToString();
        }
    }
}
