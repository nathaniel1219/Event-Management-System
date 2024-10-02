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
    public partial class ViewParticipantEvents : Form
    {
        EventManager eventmgr = new EventManager();
        public ViewParticipantEvents()
        {
            InitializeComponent();
        }

        private void ViewParticipantEvents_Load(object sender, EventArgs e)
        {
            DataTable eventDT = eventmgr.getParticipantEvents();
            eventsDGV.DataSource = eventDT;

            string user = PeopleManager.participant.getName();
            loggedTXT.Text = user;
        }

        private void goBackBTN_Click(object sender, EventArgs e)
        {
            Form participantDash = new ParticipantDash();
            this.Hide();
            participantDash.ShowDialog();
        }

        private void removeEventBTN_Click(object sender, EventArgs e)
        {
            string title = "Remove Event";
            string message = "Please enter the event id to Remove";
            string removeEventId = EventManager.ButtonPrompt(title, message);
            if (removeEventId != null)
            {
                eventmgr.removeParticipantEvent(removeEventId);
                MessageBox.Show("You have been removed from the event successfully");
            }
        }

        private void refreshBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Refresh();
            DataTable eventDT = eventmgr.getParticipantEvents();
            eventsDGV.DataSource = eventDT;
        }
    }
}
