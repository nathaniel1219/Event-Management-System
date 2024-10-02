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
    public partial class EditOrganizers : Form
    {
        private PeopleManager pplmgr = new PeopleManager();
        private Person editedOrganizer;
        private string organizerPass;
        public EditOrganizers()
        {
            InitializeComponent();
        }

        private void EditOrganizers_Load(object sender, EventArgs e)
        {
            
            DataTable organizers = pplmgr.getAllOrganizers();
            organizersDGV.DataSource = organizers;

            string user = PeopleManager.admin.getName();
            loggedTXT.Text = user;
        }

        private void goBackBTN_Click(object sender, EventArgs e)
        {
            Form viewUsers = new ViewUsers();
            this.Hide();
            viewUsers.ShowDialog();
        }

        private void deleteOrganizerBTN_Click(object sender, EventArgs e)
        {
            string title = "Delete Organizer";
            string message = "Please enter the organizer id to delete";
            string deleteOrganizerId = PeopleManager.ButtonPrompt(title, message);
            if (deleteOrganizerId != null)
            {
                pplmgr.deleteUser(deleteOrganizerId, "organizer");
            }
        }

        private void refreshBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Refresh();
            DataTable organizers = pplmgr.getAllOrganizers();
            organizersDGV.DataSource = organizers;
        }

        private void editOrganizerBTN_Click(object sender, EventArgs e)
        {
            pplmgr.editPerson(editedOrganizer, organizerPass);
        }

        public void InitializeGrid(DataGridView yourDataGridView)
        {
            yourDataGridView.CellValueChanged += organizersDGV_CellValueChanged;
        }

        private void organizersDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                organizerPass = grid.CurrentRow.Cells["password"].Value.ToString();

                // Create or update the edited event
                editedOrganizer = new Organizer(username, age, phone, email, "organizer", id);
                MessageBox.Show("You have made changes to the organizer table. Please press 'Edit Organizer' to save them to the database.");
            }
        }
    }
}
