using Event_Management_System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Event_Management_System
{
    internal class PeopleManager : IAuth
    {
        DBConnection dbConnection = new DBConnection(); // Database Object 
        public static Organizer organizer; // Organizer Object
        public static Participant participant; // Participant Object
        public static Admin admin; // Admin Object

        // User login method for participants/organizers to login to the system
        public bool Login(string username, string password, string role)
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                // Query for either the participant or organizer table
                string query = $"SELECT * FROM {role} WHERE username = @username AND password = @password;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("username");
                        int age = reader.GetInt32("age");
                        string phone = reader.GetString("phone");
                        string email = reader.GetString("email");
                        int id = reader.GetInt32("id");

                        // Based on the role, create either a Participant or Organizer object
                        if (role == "participant")
                        {
                            participant = new Participant(name, age, phone, email, role, id, null);
                        }
                        else
                        {
                            organizer = new Organizer(name, age, phone, email, role, id);
                        }
                    }
                    reader.Close();
                    return true; // User found and object created
                }
                else
                {
                    MessageBox.Show("User not found");
                    reader.Close();
                    return false; // No matching user
                }
            }
            catch
            {
                MessageBox.Show("An unknown error occured");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        //Admin login method to allow the admin to login to the system
        public bool AdminLogin(string username, string password)
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                // Query for the admin table
                string query = "SELECT * FROM admin WHERE username = @username AND password = @password;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("username");
                        int age = reader.GetInt32("age");
                        string phone = reader.GetString("phone");
                        string email = reader.GetString("email");
                        int id = reader.GetInt32("id");

                        admin = new Admin(name, age, phone, email, "admin", id);
                    }
                    reader.Close();
                    return true; // User found
                }
                else
                {
                    reader.Close();
                    return false; // No matching user
                }
            }
            catch
            {
                MessageBox.Show("An unknown error has occured");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        //Method to verify that the admin enters the right code
        public bool AdminVerify(string code)
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                // Query for admin table
                string query = "SELECT * FROM admin WHERE security_code = @code";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@code", code);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    return true; 
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("An unknown error has occurred");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }


        public void Register(Person person, string password)
        {
            string username = person.getName();
            int age = person.getAge();
            string phone = person.getPhone();
            string email = person.getEmail();
            string role = person.getRole();

            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                bool usernameCheck = false;
                bool emailCheck = false;
                bool phoneCheck = false;

                // Query to check if the username, email, or phone already exists
                string checkQuery = $"SELECT username, email, phone FROM {role} WHERE username = @username OR email = @email OR phone = @phone";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@email", email);
                    checkCmd.Parameters.AddWithValue("@phone", phone);

                    using (MySqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        // Conditional chain to verify if values already exist in the table
                        while (reader.Read())
                        {
                            if (reader["username"].ToString() == username)
                            {
                                usernameCheck = true;
                                MessageBox.Show("Username already exists. Please choose another.");
                                break;
                            }
                            if (reader["email"].ToString() == email)
                            {
                                emailCheck = true;
                                MessageBox.Show("Email already exists. Please choose another.");
                                break;
                            }
                            if (reader["phone"].ToString() == phone.ToString())
                            {
                                phoneCheck = true;
                                MessageBox.Show("Phone number already exists. Please choose another.");
                                break;
                            }
                        }
                    }
                }

                if (!usernameCheck && !emailCheck && !phoneCheck)
                {
                    // Query to insert the details of the new user into the database
                    string insertQuery = $"INSERT INTO {role} (username, password, email, phone, age) VALUES (@username, @password, @email, @phone, @age)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); 
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@age", age);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{username} has been registered successfully as a {role}");
                    }
                }
            }
            catch
            {
                MessageBox.Show("An unkown error has occured");
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        public DataTable getAllOrganizers()
        {
            DataTable dt = new DataTable();
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                string query = $"SELECT * FROM organizer";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                using (adapter)
                {
                    adapter.Fill(dt);
                }
            }
            catch
            {
                MessageBox.Show("An unknown error has occured");
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return dt;
        }

        public DataTable getAllParticipants()
        {
            DataTable dt = new DataTable();
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                string query = $"SELECT * FROM participant";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                using (adapter)
                {
                    adapter.Fill(dt);
                }
            }
            catch
            {
                MessageBox.Show("An unkown error has occured");
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return dt;
        }

        //Method to display a messagebox to take in an input string (for people related functions)
        public static string ButtonPrompt(string title, string message)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label()
            {
                Left = 10,
                Top = 20,
                Text = $"{message}:",
                AutoSize = true 
            };

            System.Windows.Forms.TextBox inputBox = new System.Windows.Forms.TextBox()
            {
                Left = 10,
                Top = 50,
                Width = 260 
            };

            System.Windows.Forms.Button confirmation = new System.Windows.Forms.Button()
            {
                Text = "OK",
                Left = 10,
                Width = 80,
                Top = 80,
                DialogResult = System.Windows.Forms.DialogResult.OK
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == System.Windows.Forms.DialogResult.OK ? inputBox.Text : string.Empty;
        }


        public void deleteUser(string userId, string userType) 
        {
            if (!string.IsNullOrEmpty(userId))
            {
                try
                {
                    dbConnection.OpenConnection();
                    MySqlConnection connection = dbConnection.GetConnection();


                    // Query to delete the event by ID
                    string query = $"DELETE FROM {userType} WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Event ID not found.");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("An unknown error has occured");
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("No Event ID entered.");
            }
        }

        public void editPerson(Person editedPerson, string password)
        {
            if (editedPerson != null)
            {
                string username = editedPerson.getName();
                int age = editedPerson.getAge();
                string phone = editedPerson.getPhone();
                string email = editedPerson.getEmail();
                string passwrd = password;
                string userType = string.Empty;
                int? id = null;

                try
                {

                    if (editedPerson is Organizer editedOrganizer)
                    {
                        id = editedOrganizer.getId();
                        userType = "organizer";
                    }
                    else if (editedPerson is Participant editedParticipant)
                    {
                        id = editedParticipant.getId();
                        userType = "participant";
                    }

                    dbConnection.OpenConnection();
                    MySqlConnection connection = dbConnection.GetConnection();

                    // Update query
                    string query = $"UPDATE {userType} SET username = @username, age = @age, phone = @phone, email = @email, password = @password WHERE id = @id";


                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", passwrd);

                        // Execute the update command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{editedPerson.getRole()} has been successfully updated.");
                    }
                }
                catch
                {
                    MessageBox.Show("An unkown error has occured");
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("No changes detected.");
            }
        }
    }
}




        
    

