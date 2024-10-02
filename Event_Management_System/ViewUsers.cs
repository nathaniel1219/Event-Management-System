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
    public partial class ViewUsers : Form
    {
        PeopleManager pplmgr = new PeopleManager();
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            DataTable organizers = pplmgr.getAllOrganizers();
            eventsDGV.DataSource = organizers;

            string user = PeopleManager.admin.getName();
            loggedTXT.Text = user;
        }

        private void goBackBTN_Click_2(object sender, EventArgs e)
        {
            Form adminDash = new AdminDash();
            this.Hide();
            adminDash.ShowDialog();
        }

        private void viewParticipantsBTN_Click(object sender, EventArgs e)
        {
            viewParticipantsBTN.BackColor = System.Drawing.Color.Red;
            viewParticipantsBTN.ForeColor = System.Drawing.Color.White;

            viewOrganizersBTN.BackColor = System.Drawing.Color.White;
            viewOrganizersBTN.ForeColor = System.Drawing.Color.Black;

            label1.Text = "Participant List";

            DataTable participants = pplmgr.getAllParticipants();
            eventsDGV.DataSource = participants;
        }

        private void viewOrganizersBTN_Click(object sender, EventArgs e)
        {
            viewOrganizersBTN.BackColor = System.Drawing.Color.Red;
            viewOrganizersBTN.ForeColor = System.Drawing.Color.White;

            viewParticipantsBTN.BackColor = System.Drawing.Color.White;
            viewParticipantsBTN.ForeColor = System.Drawing.Color.Black;

            label1.Text = "Organizer List";

            DataTable organizers = pplmgr.getAllOrganizers();
            eventsDGV.DataSource = organizers;
        }

        private void editParticipantsBTN_Click(object sender, EventArgs e)
        {
            Form editParts = new EditParticipants();
            this.Hide();
            editParts.ShowDialog();
        }

        private void editOrganizersBTN_Click(object sender, EventArgs e)
        {
            Form editOrgs = new EditOrganizers();
            this.Hide();
            editOrgs.ShowDialog();
        }
    }
}
