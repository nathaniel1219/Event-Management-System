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
    public partial class OrganizerDash : Form
    {
        public OrganizerDash()
        {
            InitializeComponent();
        }

        private void OrganizerDash_Load(object sender, EventArgs e)
        {
            string user = PeopleManager.organizer.getName();
            loggedTXT.Text = user;
        }

        private void createEventsBTN_Click(object sender, EventArgs e)
        {
            Form createEvents = new CreateEvents();
            this.Hide();
            createEvents.ShowDialog();
        }

        private void viewEventsBTN_Click(object sender, EventArgs e)
        {
            Form viewEvents = new ViewEvents();
            this.Hide();
            viewEvents.ShowDialog();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            Form logout = new Login();
            MessageBox.Show("Successfully Logged Out");
            this.Hide();
            logout.ShowDialog();
        }
    }
}
