using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace Event_Management_System
{
    internal class Admin:Person
    {
        private int id;

        //Constructor
        public Admin(string name, int age, string phone, string email,string role, int id) : base(name, age, phone, email, role)
        {
            this.id = id;
        }
        
        //Getter
        public int getID() { return id; }

        //Setter
        public void setID(int id) { this.id = id; }

        //Other Methods
        
    }
}
