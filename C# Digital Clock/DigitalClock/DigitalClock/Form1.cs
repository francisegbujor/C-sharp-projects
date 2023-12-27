using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get the current Time
            lblTime.Text = DateTime.Now.ToString("HH:mm");

            // Get current seconds
            lblSeconds.Text = DateTime.Now.ToString("ss");

            // Get current Date
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");

            // Get current Day
            lblDay.Text = DateTime.Now.ToString("dddd");

            lblSeconds.Location = new Point(lblTime.Location.X + lblTime.Width, lblSeconds.Location.Y);
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            // Starts the timer to display current 
            timer1.Start();
        }
    }
}
