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
    public partial class RSVP : Form
    {
        private EventManager eventmgr = new EventManager();
        public RSVP()
        {
            InitializeComponent();
        }

        private void goBackBTN_Click(object sender, EventArgs e)
        {
            Form participantDash = new ParticipantDash();
            this.Hide();
            participantDash.ShowDialog();
        }

        private void RSVP_Load(object sender, EventArgs e)
        {
            EventManager eventManager = new EventManager();
            DataTable eventDT = eventManager.getEvents();
            eventsDGV.DataSource = eventDT;

            string user = PeopleManager.participant.getName();
            loggedTXT.Text = user;
        }

        private void rsvpBTN_Click(object sender, EventArgs e)
        {
            string title = "RSVP Event";
            string message = "Please enter the event id to RSVP";
            string rsvpEventId = EventManager.ButtonPrompt(title, message);
            if (rsvpEventId != null)
            {
                string scope = eventmgr.ScopeConfirmation(rsvpEventId);
                eventmgr.eventRSVP(rsvpEventId, scope);
            }

        }
    }
}
