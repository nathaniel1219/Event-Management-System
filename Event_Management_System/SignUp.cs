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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
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
        public bool NotEmptyInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Field cannot be blank.");
                return false;
            }
            return true;
        }


        public string GetSelectedRole()
        {
            if (!participantRadio.Checked && !organizerRadio.Checked)
            {
                MessageBox.Show("Please select a role.");
                return null;
            }
            else
            {
                if (participantRadio.Checked)
                {
                    return "participant";
                }
                else
                {
                    return "organizer";
                }
            }
        }




        private void gobackBTN_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            PeopleManager peopleManager = new PeopleManager();
            string username;
            string password;
            string email = emailTXT.Text;
            string role = GetSelectedRole();
            
            string phone;
            int age;
            if (IsInteger(ageTXT.Text) && NotEmptyInput(usernameTXT.Text) && NotEmptyInput(passwordTXT.Text) && role != null)
            {
                username = usernameTXT.Text;
                password = passwordTXT.Text;
                age = int.Parse(ageTXT.Text);
                phone = phoneTXT.Text;
                Person newPerson = null;
                if (role == "participant")
                {
                    newPerson = new Participant(username, age, phone, email, role, null, null);
                }
                 else
                {
                    newPerson = new Organizer(username, age, phone, email, role, null);
                }
                

                //Run register function
                peopleManager.Register(newPerson, password);
                Form login = new Login();
                this.Hide();
                login.ShowDialog();
            }

            
        }
    }
}
