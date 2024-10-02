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
    public partial class EditParticipants : Form
    {
        private PeopleManager pplmgr = new PeopleManager();
        private Person editedParticipant;
        private string participantPass;
        public EditParticipants()
        {
            InitializeComponent();
        }

        private void EditParticipants_Load(object sender, EventArgs e)
        {
            DataTable participants = pplmgr.getAllParticipants();
            participantsDGV.DataSource = participants;

            string user = PeopleManager.admin.getName();
            loggedTXT.Text = user;
        }

        private void goBackBTN_Click(object sender, EventArgs e)
        {
            Form viewUsers = new ViewUsers();
            this.Hide();
            viewUsers.ShowDialog();
        }

        private void deleteParticipantBTN_Click(object sender, EventArgs e)
        {
            string title = "Delete Organizer";
            string message = "Please enter the participant id to delete";
            string deleteParticipantId = PeopleManager.ButtonPrompt(title, message);
            if (deleteParticipantId != null)
            {
                pplmgr.deleteUser(deleteParticipantId, "organizer");
            }
        }

        private void refreshBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Refresh();
            DataTable participants = pplmgr.getAllParticipants();
            participantsDGV.DataSource = participants;
        }

        private void editParticipantBTN_Click(object sender, EventArgs e)
        {
            pplmgr.editPerson(editedParticipant, participantPass);
        }

        public void InitializeGrid(DataGridView yourDataGridView)
        {
            yourDataGridView.CellValueChanged += participantsDGV_CellValueChanged;
        }

        private void participantsDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            DataGridViewRow row = grid.Rows[e.RowIndex];

            if (grid.CurrentRow != null)
            {
                int? id = Convert.ToInt32(grid.CurrentRow.Cells["id"].Value);
                string username = grid.CurrentRow.Cells["username"].Value.ToString();
                int age = Convert.ToInt32(grid.CurrentRow.Cells["age"].Value);
                string phone = grid.CurrentRow.Cells["phone"].Value.ToString();
                string email = grid.CurrentRow.Cells["email"].Value.ToString();
                participantPass = grid.CurrentRow.Cells["password"].Value.ToString();

                // Create or update the edited event
                editedParticipant = new Participant(username, age, phone, email, "organizer", id, null);
                MessageBox.Show("You have made changes to the participant table. Please press 'Edit Participant' to save them to the database.");
            }
        }
    }
}
