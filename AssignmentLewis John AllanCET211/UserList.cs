using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// Creating a class specifically to make adding and finding a new user easier
    /// </summary>
    [Serializable]
    class UserList
    {
        /// <summary>
        /// Generic List of Student objects
        /// </summary>
        public List<User> Users;

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public UserList()
        {
            Users = new List<User>();
        }

        // Add new User to List, first checking that Account number
        // has not already been used and the username                
        public bool AddUser(User user)
        {
            bool success = true;
            foreach (User u in Users)
            {
                if (u.AccountNumber == user.AccountNumber  && u.UserName == user.UserName)
                {
                    success = false;
                }
            }
            if (success)
            {
                Users.Add(user);
            }
            return success;
        }

        // Find and return User whose Account number matches search Account number
        // or return null if User object not found 
        public User FindItem(String UserName)
        {
            User user = null;
            foreach (User u in Users)
            {

                if (u.UserName == UserName)
                {
                    user = u;
                }
            }
            return user;
        }
    }
}
