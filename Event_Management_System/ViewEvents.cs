using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class ViewEvents : Form
    {
        public ViewEvents()
        {
            InitializeComponent();
        }

        private void ViewEvents_Load(object sender, EventArgs e)
        {
            EventManager eventManager = new EventManager();
            DataTable eventDT = eventManager.getMyEvents();
            viewEventsDGV.DataSource = eventDT;

            string user = PeopleManager.organizer.getName();
            loggedTXT.Text = user;
        }
        private void gobackBTN_Click(object sender, EventArgs e)
        {
            Form organizerDash = new OrganizerDash();
            this.Hide();
            organizerDash.ShowDialog();
        }
        private void editEventsBTN_Click(object sender, EventArgs e)
        {
            Form editEvents = new EditEvents();
            this.Hide();
            editEvents.ShowDialog();
        }
    }
}
