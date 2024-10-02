using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Management_System
{
    internal interface IManageEvent
    {
        void createEvents(Event eventt);
        void editEvent(Event editedEvent);
        void deleteEvent(string eventId);
    }
}
