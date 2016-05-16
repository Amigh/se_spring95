using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gomrokP1
{
    class Employee
    {
        private string username;
        private string password;
        private string role;
        public Employee(string username,string password,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public string getRole()
        {
            return this.role;
        }
        public bool authenticate(string username,string password)
        {
            if (this.password == password && this.username == username)
                return true;
            return false;
        }
        public string getUsername()
        {
            return this.username;
        }
    }   
}
