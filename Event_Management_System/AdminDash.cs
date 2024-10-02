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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            EventManager eventManager = new EventManager();
            DataTable eventDT = eventManager.getAllEvents();
            eventsDGV.DataSource = eventDT;

            string user = PeopleManager.admin.getName();
            loggedTXT.Text = user;
        }

        private void editEventsBTN_Click(object sender, EventArgs e)
        {
            Form adminEditEvents = new AdminEditEvents();
            this.Hide();
            adminEditEvents.ShowDialog();
        }

        private void viewUsersBTN_Click(object sender, EventArgs e)
        {
            Form viewUsers = new ViewUsers();
            this.Hide();
            viewUsers.ShowDialog();
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
