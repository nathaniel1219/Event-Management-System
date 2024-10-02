using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Management_System
{
    internal class Organizer : Person
    {
        private int? id;
        private List<Event> eventList;
        private int noOfEvents;

        //Constructor
        public Organizer(string name, int age, string phone, string email,string role, int? id) : base(name, age, phone, email, role)
        {
            this.id = id;
        }

        // Getters
        public int? getId() { return id; }   
        public List<Event> getEventList() { return eventList; }
        public int getNoOfEvents() { return noOfEvents; }

        // Setters
        public void setId(int id) { this.id = id; }
        public void setEventList(List<Event> value) { eventList = value; }
        public void setNoOfEvents(int value) { noOfEvents = value; }

        //Other Methods
        

    }
}
