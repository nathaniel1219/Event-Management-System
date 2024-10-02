using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Management_System
{
    internal class Event
    {
        private string name;
        private int? id;
        private List<Participant> participantList;
        private string dateTime;
        private string venue;
        private string eventCode;
        private string description;
        private int maxParticipants;
        private string scope;
        private int? organizerId;
        private List<Event> eventList;

        //Constructor
        public Event(string name, int? id, string venue, string dateTime, string eventCode,string description, int maxParticipants, string scope, int? organizerId)
        {
            this.name = name;
            this.id = id;
            this.dateTime = dateTime;
            this.venue = venue;
            this.eventCode = eventCode;
            this.description = description;
            this.maxParticipants = maxParticipants;
            this.scope = scope;
            this.organizerId = organizerId;
        }

        // Getters
        public string getName() { return name; }
        public int? getId() { return id; }
        public int? getOrganizerId() { return organizerId; }
        public List<Participant> getParticipantList() { return participantList; }
        public string getDateTime() { return dateTime; }
        public string getVenue() { return venue; }
        public string getEventCode() { return eventCode; }
        public string getDescription() { return description; }
        public int getMaxParticipants() { return maxParticipants; }
        public string getScope() { return scope; }
        public List<Event> getEventList() { return eventList; }

        // Setters
        public void setName(string value) { name = value; }
        public void setId(int value) { id = value; }
        public void setOrganizerId(int value) { organizerId = value; }
        public void setParticipantList(List<Participant> value) { participantList = value; }
        public void setDateTime(string value) { dateTime = value; }
        public void setVenue(string value) { venue = value; }
        public void setEventCode(string value) { eventCode = value; }
        public void setDescription(string value) { description = value; }
        public void setMaxParticipants(int value) { maxParticipants = value; }
        public void setScope(string value) { scope = value; }
        public void setEventList(List<Event> value) { eventList = value; }

        //Other methods
        public void DisplayDetails()
        {
            //
        }
    }
}

