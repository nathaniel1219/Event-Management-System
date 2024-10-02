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
    public partial class EditEvents : Form
    {
        private Event editedEvent;
        public EditEvents()
        {
            InitializeComponent();
        }

        private void EditEvents_Load(object sender, EventArgs e)
        {
            EventManager eventManager = new EventManager();
            DataTable eventDT = eventManager.getMyEvents();
            viewEventsDGV.DataSource = eventDT;
            viewEventsDGV.Columns["id"].ReadOnly = true;
            viewEventsDGV.Columns["event_code"].ReadOnly = true;
            viewEventsDGV.Columns["organizer_id"].ReadOnly = true;

            string user = PeopleManager.organizer.getName();
            loggedTXT.Text = user;
        }

        private void goBackBTN_Click(object sender, EventArgs e)
        {
            Form viewEvents = new ViewEvents();
            this.Hide();
            viewEvents.ShowDialog();
        }

        private void deleteEventBTN_Click(object sender, EventArgs e)
        {
            string title = "Delete Event";
            string message = "Please enter the event id to delete";
            string deleteEventId = EventManager.ButtonPrompt(title, message);
            if (deleteEventId != null)
            {
                EventManager eventManager = new EventManager();
                eventManager.deleteEvent(deleteEventId);
            }
        }

        private void refreshBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Refresh();
            EventManager eventManager = new EventManager();
            DataTable eventDT = eventManager.getMyEvents();
            viewEventsDGV.DataSource = eventDT;
        }

        private void editEventBTN_Click(object sender, EventArgs e)
        {
            EventManager eventManager = new EventManager();
            eventManager.editEvent(editedEvent);
        }

        public void InitializeGrid(DataGridView yourDataGridView)
        {
            yourDataGridView.CellValueChanged += viewEventsDGV_CellValueChanged;
        }

        private void viewEventsDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            DataGridViewRow row = grid.Rows[e.RowIndex];

            if (grid.CurrentRow != null)
            {
                int eventId = Convert.ToInt32(grid.CurrentRow.Cells["id"].Value);
                string eventName = grid.CurrentRow.Cells["event_name"].Value.ToString(); 
                string venue = grid.CurrentRow.Cells["venue"].Value.ToString();
                string dateTime = grid.CurrentRow.Cells["date_time"].Value.ToString();
                string description = grid.CurrentRow.Cells["description"].Value.ToString();
                string eventCode = grid.CurrentRow.Cells["event_code"].Value.ToString();
                int? organizerId = Convert.ToInt32(grid.CurrentRow.Cells["organizer_id"].Value);
                int maxParticipants = Convert.ToInt32(grid.CurrentRow.Cells["max_participants"].Value);
                string scope = grid.CurrentRow.Cells["scope"].Value.ToString();

                // Create or update the edited event
                editedEvent = new Event(eventName, eventId, venue, dateTime, eventCode, description, maxParticipants, scope, organizerId);
                MessageBox.Show("You have made changes to the event. Please press 'Edit Events' to save them to the database.");
            }
        }
    }
}
