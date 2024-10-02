using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Event_Management_System
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordTXT.PasswordChar = '*';
        }

        public bool NotEmptyInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"Field cannot be blank.");
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


        private void signupBTN_Click(object sender, EventArgs e)
        {
            Form signUp = new SignUp(); 
            this.Hide();  
            signUp.ShowDialog(); 
        }

        private void adminBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form adminLogin = new AdminLogin();
            this.Hide();
            adminLogin.ShowDialog();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            PeopleManager peopleManager = new PeopleManager();
            string username;
            string password;
            string role = GetSelectedRole();

            if (NotEmptyInput(usernameTXT.Text) && NotEmptyInput(passwordTXT.Text) && role != null)
            {
                username = usernameTXT.Text;
                password = passwordTXT.Text;

                bool authenticated = peopleManager.Login(username, password, role);
                if (authenticated)
                {
                    MessageBox.Show("You have successfully logged in");

                    if(role == "participant")
                    {
                        Form participantDash = new ParticipantDash();
                        this.Hide();
                        participantDash.ShowDialog();
                    }
                    else
                    {
                        Form organizerDash = new OrganizerDash();
                        this.Hide();
                        organizerDash.ShowDialog();
                    }

                }
            }
            
        }

        
    }
}
