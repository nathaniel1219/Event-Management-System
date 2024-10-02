using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            passwordTXT.PasswordChar = '*';
        }

        private void gobackBTN_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string username = usernameTXT.Text;
            string password = passwordTXT.Text;
            PeopleManager peopleManager = new PeopleManager();
            bool authenticated = peopleManager.AdminLogin(username, password);
            if (authenticated)
            {
                string title = "Admin Code";
                string message = "Please enter the designated admin code";
                string adminCode = PeopleManager.ButtonPrompt(title, message);
                if (adminCode != null)
                {
                    bool verified = peopleManager.AdminVerify(adminCode);

                    if (verified)
                    {
                        MessageBox.Show("You have successfully logged in as admin");
                        Form adminDash = new AdminDash();
                        this.Hide();
                        adminDash.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid code entered");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid username/password/role");
            }
        }

        
    }
}
