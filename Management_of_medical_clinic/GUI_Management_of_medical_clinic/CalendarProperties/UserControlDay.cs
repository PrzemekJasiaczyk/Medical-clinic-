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
        public DateTime selectedDate;

        public delegate void ControlClickedEventHandler(object sender, DateTime selectedDate);
        public event ControlClickedEventHandler ControlClicked;


        public UserControlDay(DateTime selecteddate)
        {
            selectedDate = selecteddate;
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            labelNumberOfDay.Text = selectedDate.Day.ToString();
        }

        private void UserControlDay_MouseClick(object sender, MouseEventArgs e)
        {
            ControlClicked?.Invoke(this, selectedDate);
        }
    }
}
