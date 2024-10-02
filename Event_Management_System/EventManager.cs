using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Frame.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Event_Management_System 
{
    internal class EventManager : IManageEvent
    {
        DBConnection dbConnection = new DBConnection(); // Database Object 

        public string GenerateUniqueEventCode()
        {
            Random random = new Random();
            string randomCode = string.Empty;
            bool codeExists = true;

            try
            {
                dbConnection.OpenConnection();
                while (codeExists)
                {
                    randomCode = random.Next(1000, 9999).ToString();  

                    string query = "SELECT event_code FROM events WHERE event_code = @code";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@code", randomCode);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            codeExists = reader.HasRows; 
                        }
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
            return randomCode;
        }






        public void editEvent(Event editedEvent)
        {
            if (editedEvent != null)
            {
                int? eventId = editedEvent.getId();
                string eventName = editedEvent.getName();
                string venue = editedEvent.getVenue();
                string dateTime = editedEvent.getDateTime();
                string description = editedEvent.getDescription();
                int maxParticipants = editedEvent.getMaxParticipants();
                string scope = editedEvent.getScope();

                try
                {
                    dbConnection.OpenConnection();
                    MySqlConnection connection = dbConnection.GetConnection();

                    // Update query
                    string query = "UPDATE events SET event_name = @event_name, venue = @venue, date_time = @date_time, " +
                                   "description = @description, max_participants = @max_participants, scope = @scope " +
                                   "WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", eventId);
                        cmd.Parameters.AddWithValue("@event_name", eventName);
                        cmd.Parameters.AddWithValue("@venue", venue);
                        cmd.Parameters.AddWithValue("@date_time", dateTime);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@max_participants", maxParticipants);
                        cmd.Parameters.AddWithValue("@scope", scope);
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Event has been successfully updated.");
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

        public void deleteEvent(string eventId)
        {
            if (!string.IsNullOrEmpty(eventId))
            {
                try
                {
                    dbConnection.OpenConnection();
                    MySqlConnection connection = dbConnection.GetConnection();

                    string query = "DELETE FROM events WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", eventId);
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
                    MessageBox.Show("An unkown error has occured");
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

        //Method to get all the events for the admin
        public DataTable getAllEvents()
        {
            DataTable dt = new DataTable();
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                string query = $"SELECT * FROM events";
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

        //Method to get events for the organizer
        public DataTable getMyEvents()
        {
            DataTable dt = new DataTable();
            int? organizerId = PeopleManager.organizer.getId();
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                string query = $"SELECT * FROM events WHERE organizer_id = @organizerId";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@organizerId", organizerId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
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
            return dt;
        }

        //Method to get some details of all events
        public DataTable getEvents()
        {
            DataTable dt = new DataTable();
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                string query = $"SELECT id, event_name, venue, date_time, description, max_participants, scope FROM events";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                using (adapter)
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return dt;
        }

        //Method to get the events which a participant is registered for
        public DataTable getParticipantEvents()
        {
            DataTable dt = new DataTable();
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();
                int? participantId = PeopleManager.participant.getId();

                string query = $"SELECT id, event_name, venue, date_time, description, scope FROM events " +
                                "WHERE id IN (SELECT eventId FROM event_participants WHERE participantId = @participantId);";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@participantId", participantId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
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
            return dt;
        }

        public void createEvents(Event eventt) 
        {
            string event_name = eventt.getName();
            string venue = eventt.getVenue();
            string date_time = eventt.getDateTime();
            string description = eventt.getDescription();
            int max_participants = eventt.getMaxParticipants();
            string scope = eventt.getScope();
            string event_code = eventt.getEventCode();
            int? organizer_id = eventt.getOrganizerId();

            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                // Query to check if the date_time for the specific venue already exists
                string checkQuery = "SELECT venue, date_time FROM events WHERE venue = @venue AND date_time = @date_time"; // Replace 'events' with your actual table name
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                using (checkCmd)
                {
                    checkCmd.Parameters.AddWithValue("@venue", venue);
                    checkCmd.Parameters.AddWithValue("@date_time", date_time);

                    using (MySqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("This timeslot for the venue is already booked.");
                            return;
                        }
                    }
                }

                // Query to insert the details of the new event into the database
                string query = "INSERT INTO events (event_name, venue, date_time, description, max_participants, scope, event_code, organizer_id) " +
                                     "VALUES (@event_name, @venue, @date_time, @description, @max_participants, @scope, @event_code, @organizer_id)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@event_name", event_name);
                    cmd.Parameters.AddWithValue("@venue", venue);
                    cmd.Parameters.AddWithValue("@date_time", date_time);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@max_participants", max_participants);
                    cmd.Parameters.AddWithValue("@scope", scope);
                    cmd.Parameters.AddWithValue("@event_code", event_code);
                    cmd.Parameters.AddWithValue("@organizer_id", organizer_id); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{event_name} has been added successfully.");
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

        //Method to display a messagebox to take in an input string (for event related functions)
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

            Label textLabel = new Label()
            {
                Left = 10,
                Top = 20,
                Text = $"{message}:",
                AutoSize = true
            };

            TextBox inputBox = new TextBox()
            {
                Left = 10,
                Top = 50,
                Width = 260
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 10,
                Width = 80,
                Top = 80,
                DialogResult = DialogResult.OK
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
        }


        public string ScopeConfirmation(string eventId)
        {
            string scope = string.Empty;
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                string scopeQuery = "SELECT scope FROM events WHERE id = @eventId";
                using (MySqlCommand cmd = new MySqlCommand(scopeQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@eventId", eventId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        scope = result.ToString();
                        MessageBox.Show($"The event scope is {scope}");
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
            return scope;
        }

        public void eventRSVP(string eventId, string scope)
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();

                string checkQuery = "SELECT max_participants, registered FROM events WHERE id = @eventId;";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@eventId", eventId);

                int maxParticipants = 0;
                int registeredCount = 0;

                MySqlDataReader reader = checkCmd.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        maxParticipants = reader.GetInt32("max_participants");
                        registeredCount = reader.GetInt32("registered");
                    }
                }

                if (registeredCount <= maxParticipants)
                {
                    if (scope == "private")
                    {
                        bool isValidCode = false;
                        string title = "Event Code";
                        string message = "Please enter the event code";
                        string eventCode = ButtonPrompt(title, message);

                        string eventCodeQuery = "SELECT COUNT(*) FROM events WHERE id = @eventId AND event_code = @eventCode;";
                        MySqlCommand cmd = new MySqlCommand(eventCodeQuery, connection);
                        using (cmd)
                        {
                            cmd.Parameters.AddWithValue("@eventId", eventId);
                            cmd.Parameters.AddWithValue("@eventCode", eventCode);

                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            isValidCode = (count > 0);
                        }

                        if (isValidCode)
                        {
                            int? participantId = PeopleManager.participant.getId();
                            string insertQuery = "INSERT INTO event_participants (eventId, participantId) VALUES (@eventId, @participantId);";

                            MySqlCommand newCmd = new MySqlCommand(insertQuery, connection);
                            using (newCmd)
                            {
                                newCmd.Parameters.AddWithValue("@eventId", eventId);
                                newCmd.Parameters.AddWithValue("@participantId", participantId);

                                newCmd.ExecuteNonQuery();
                                MessageBox.Show($"Participant has been successfully registered for the {scope} event.");
                            }

                            string updateRegisteredQuery = "UPDATE events SET registered = registered + 1 WHERE id = @eventId;";
                            MySqlCommand updateCmd = new MySqlCommand(updateRegisteredQuery, connection);
                            updateCmd.Parameters.AddWithValue("@eventId", eventId);
                            updateCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Invalid code entered... Failed to register");
                        }
                    }
                    else
                    {
                        int? participantId = PeopleManager.participant.getId();
                        string insertQuery = "INSERT INTO event_participants (eventId, participantId) VALUES (@eventId, @participantId);";

                        MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                        using (cmd)
                        {
                            cmd.Parameters.AddWithValue("@eventId", eventId);
                            cmd.Parameters.AddWithValue("@participantId", participantId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"Participant has been successfully registered for the {scope} event.");
                        }
                        string updateRegisteredQuery = "UPDATE events SET registered = registered + 1 WHERE id = @eventId;";
                        MySqlCommand updateCmd = new MySqlCommand(updateRegisteredQuery, connection);
                        updateCmd.Parameters.AddWithValue("@eventId", eventId);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("This event is already fully booked.");
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

        public void removeParticipantEvent(string eventId)
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlConnection connection = dbConnection.GetConnection();
                int? participantId = PeopleManager.participant.getId();

                string query = "DELETE FROM event_participants WHERE eventId = @eventId AND participantId = @participantId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@eventId", eventId);
                    cmd.Parameters.AddWithValue("@participantId", participantId);

                    cmd.ExecuteNonQuery();

                }
                string updateRegisteredQuery = "UPDATE events SET registered = registered - 1 WHERE id = @eventId;";
                MySqlCommand updateCmd = new MySqlCommand(updateRegisteredQuery, connection);
                updateCmd.Parameters.AddWithValue("@eventId", eventId);
                updateCmd.ExecuteNonQuery();
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

    }
}
