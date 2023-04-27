using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDay : UserControl
    {
        DateTime selectedDate;

        public UserControlDay(DateTime selectedDate)
        {
            this.selectedDate = selectedDate;
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            labelNumberOfDay.Text = selectedDate.Day.ToString();
        }

        private void UserControlDay_MouseClick(object sender, MouseEventArgs e)
        {

            string str = "Wybrana data to: " + selectedDate.Date.ToString();
            MessageBox.Show(str);
        }
    }
}
