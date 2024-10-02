using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Management_System
{
    internal class Participant : Person
    {
        private int? id;
        private Event eventt;
        

        //Constructor
        public Participant(string name, int age, string phone, string email, string role, int? id, Event eventt) : base(name, age, phone, email, role)
        {
            this.id = id;
            this.eventt = eventt;
        }

        // Getters
        public int? getId() { return id; }
        public Event getEvent() { return eventt; }

        // Setters
        public void setId(int id) { this.id = id; }
        public void setEvent(Event value) { eventt = value; }

        //Other Methods
        public void Login()
        {
            //Complete
        }
        public bool RSVP(Event eventt)
        {
            //To be completed
            return true;
        }

        public void ViewInfo(Event eventt)
        {
            //To be completed
        }
    }
}
