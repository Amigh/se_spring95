using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gomrokP1
{
    class DB
    {
        private static DB instance = null;
        private List<Employee> users;
        private List<Ezhar> ezhars;
        
        private DB(){
            users = new List<Employee>();
            ezhars = new List<Ezhar>();
            users.Add(new Employee("a","a","admin"));
            users.Add(new Employee("b", "b", "user"));
        }

        public static DB getDB(){
            if (instance == null)
                return new DB();
            else
                return instance;
        }

        public Employee getUser(string username){
            foreach(Employee e in users){
                if(e.getUsername() == username){
                    return e;
                }
            }
            return null;
        }
        public void addNewEzhar(Ezhar ezhar)
        {
            this.ezhars.Add(ezhar);
        }

    }
}
