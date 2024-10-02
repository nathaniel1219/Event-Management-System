using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Management_System
{
    internal abstract class Person
    {
        private string name;
        private int age;
        private string phone;
        private string email;
        private string role;
     
        //Constructor
        public Person(string name, int age, string phone, string email, string role)
        {
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.email = email;
            this.role = role;
        }

        // Getters
        public string getName() { return name; }
        public int getAge() { return age; }
        public string getPhone() { return phone; }
        public string getEmail() { return email; }
        public string getRole() { return role; }

        // Setters
        public void setName(string value) { name = value; }
        public void setAge(int value) { age = value; }
        public void setPhone(string value) { phone = value; }
        public void setEmail(string value) { email = value; }
        public void setRole(string value) { role = value; }
    }
}
