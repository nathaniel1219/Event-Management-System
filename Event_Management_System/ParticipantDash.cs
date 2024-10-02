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
    public partial class ParticipantDash : Form
    {
        public ParticipantDash()
        {
            InitializeComponent();
        }

        private void ParticipantDash_Load(object sender, EventArgs e)
        {
            string user = PeopleManager.participant.getName();
            loggedTXT.Text = user;
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            Form logout = new Login();
            MessageBox.Show("Successfully Logged Out");
            this.Hide();
            logout.ShowDialog();
        }

        private void viewEventsBTN_Click(object sender, EventArgs e)
        {
            Form viewPartEvnts = new ViewParticipantEvents();
            this.Hide();
            viewPartEvnts.ShowDialog();
        }

        private void rsvpBTN_Click(object sender, EventArgs e)
        {
            Form rsvp = new RSVP();
            this.Hide();
            rsvp.ShowDialog();
        }
    }
}
