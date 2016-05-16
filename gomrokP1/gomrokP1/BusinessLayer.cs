using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gomrokP1
{
    class BusinessLayer
    {
        Employee currentUser;
        static BusinessLayer instance = null;
        public static BusinessLayer getInstance()
        {
            if (instance == null)
            {
                instance = new BusinessLayer();
                return instance;
            }
            else
                return instance;
        }
        public void setCurrentUser(Employee currentUser)
        {
            this.currentUser = currentUser;
        }
        public bool isCurrentUserAdmin()
        {
            if(this.currentUser!=null)
                if (this.currentUser.getRole() == "admin")
                {
                     return true;
                }
                return false;
        }
        public void logOut()
        {
            this.currentUser = null;
        }
        public void signUp(string username, string password, string role)
        {
            Employee newEmp = new Employee(username, password, role);
            
        }

    }
}
