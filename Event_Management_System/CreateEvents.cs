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
    public partial class CreateEvents : Form
    {
        public CreateEvents()
        {
            InitializeComponent();
        }

        private void CreateEvents_Load(object sender, EventArgs e)
        {
            string user = PeopleManager.organizer.getName();
            loggedTXT.Text = user;
        }

        public bool NotEmptyInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Field cannot be blank.");
                return false;
            }
            return true;
        }

        public string GetSelectedScope()
        {
            if (!privateRadio.Checked && !publicRadio.Checked)
            {
                MessageBox.Show("Please select a scope.");
                return null;
            }
            else
            {
                if (privateRadio.Checked)
                {
                    return "private";
                }
                else
                {
                    return "public";
                }
            }
        }

        public bool IsInteger(string input)
        {
            try
            {
                int result = int.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
                return false;
            }
        }

        private void gobackBTN_Click(object sender, EventArgs e)
        {
            Form organizerDash = new OrganizerDash();
            this.Hide();
            organizerDash.ShowDialog();
        }

        private void createEventBTN_Click(object sender, EventArgs e)
        {
            
            string name;
            string venue;
            string date;
            string time;
            string event_code;
            string description;
            int maxParticipants;
            string scope = GetSelectedScope();
            int? organizerId;
            

            if (IsInteger(maxParticipantsTXT.Text) && NotEmptyInput(nameTXT.Text) && NotEmptyInput(venueTXT.Text) && NotEmptyInput(dateTXT.Text) && NotEmptyInput(timeTXT.Text) && NotEmptyInput(descriptionTXT.Text) && NotEmptyInput(maxParticipantsTXT.Text) && scope != null)
            {
                EventManager eventManager = new EventManager();
                name = nameTXT.Text;
                venue = venueTXT.Text;
                date = dateTXT.Value.ToString("yyyy-MM-dd");
                time = timeTXT.Value.ToString("HH:mm:tt");
                string date_time = $"{date} - {time}";
                description = descriptionTXT.Text;
                maxParticipants = int.Parse(maxParticipantsTXT.Text);
                event_code = eventManager.GenerateUniqueEventCode();
                organizerId = PeopleManager.organizer.getId();

                Event newEvent = new Event(name, null, venue, date_time, event_code, description, maxParticipants, scope, organizerId);
                eventManager.createEvents(newEvent);
            }
        }

        
    }
}
