using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// Creating a serializable class that shares a relationship with the interface IBookable
    /// </summary>
    [Serializable]
    public class User
    {
        /// <summary>
        /// declaring attributes for class User, name
        /// </summary>
        private String name;
        /// <summary>
        /// declaring attribute for class User, username
        /// </summary>
        private String username;
        /// <summary>
        /// declaring attribute for class User, password
        /// </summary>
        private String password;
        /// <summary>
        /// declaring attribute for class User, account number
        /// </summary>
        private int accountNumber;
        /// <summary>
        /// declaring attribute for class User, running cost
        /// </summary>
        private double runningCost;

        /// <summary>
        /// create random method for declaring an account number
        /// </summary>
        Random rand = new Random();
        

        /// <summary>
        /// creating an access modifier, property for attribute, name
        /// </summary>
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// creating an access modifier, property for attribute username
        /// </summary>
        public String UserName
        {
            get { return username; }
            set { username = value; }
        }
        /// <summary>
        /// creating an access modifier, property for attribute password
        /// </summary>
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        /// <summary>
        /// creating an access modifier, property for attribute accountNumber by getting a random integer between 10000 and 19999
        /// </summary>
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = rand.Next(10000, 19999); }
        }
        /// <summary>
        /// creating an access modifier, property for attribute runningCost
        /// </summary>
        public double RunningCost
        {
            get { return runningCost; }
            set { runningCost = value; }
        }
        /// <summary>
        /// Constructor with parameters for storing an object of class User
        /// </summary>
        /// <param name="Name">End Users Full Name</param>
        /// <param name="Username">End users created username</param>
        /// <param name="Password">End users created password</param>
        /// <param name="AccountNumber">end users account number, this is randomised</param>
        /// <param name="RunningCost">Running cost is part of a method that increases by the users interactions</param>
        public User(String Name, String Username, String Password)
        {
            this.Name = Name;
            this.UserName = Username;
            this.Password = Password;
            accountNumber = AccountNumber;
            this.RunningCost = 0;
        }

        /// <summary>
        /// method for displaying the users current running cost
        /// </summary>
        /// <param name="RunningCost">The running cost of all the users gym interactions</param>
        /// <returns>A string message containing the user name and running cost</returns>
        public String ShowTotal()
        {
            string msg;
            msg = "The current running total for " + UserName + " is: " + RunningCost;
            return msg;
        }
        /// <summary>
        /// If it is an existing user, check they have entered the correct login details
        /// </summary>
        /// <param name="USERNAME">The passed in parameter representing the username value</param>
        /// <param name="PASSWORD">The passed in parameter represent the password value</param>
        /// <returns></returns>
        public Boolean CheckLogin(String USERNAME, String PASSWORD)
        {
            if(USERNAME == username && PASSWORD == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Overriding message for display object information for class User
        /// </summary>
        /// <returns>returns a string message of user details</returns>
        public override string ToString()
        {
            String msg;
            msg = username;
            return msg;
        }
        /// <summary>
        /// implementing the IBookable interface, tally up the cost
        /// </summary>
        /// <param name="bookable">object of the IBookable interface</param>
        public string BookItem(IBookable bookable)
        {
            //declare variable to store output message
            String msg;

            //calculate running total and run function "bookable" will be for example Gym or PersonalTrainer etc depending on what is being passed in
            runningCost = runningCost + bookable.Price;
            bookable.BookSession();

            //create message and write to the screen
            msg = "Booked  @ " + bookable.Price +
                  "\nSubtotal = " + runningCost;
            return msg;
        }
        /// <summary>
        /// Book a session for the user and tally cost
        /// </summary>
        /// <param name="bookable">Bookable session</param>
        /// <returns>string confirming the amount to now be paid and what has just been booked</returns>
        public string SessionType(IBookable bookable)
        {
            //create a string variable to return
            string msg; 
            //test to see what class the bookable session is within
            if (bookable is Gym)
            {
                //check if this is a subclass
                if (bookable is GymWithPool)
                {
                    msg = bookable.ToString() + " is a gym with a pool.";
                    return msg;
                }
                else
                {
                    msg = bookable.ToString() + " is a Gym.";
                    return msg;
                }
            }
            //repeat procedure for each class and sub class
            else if (bookable is Classes)
            {
                if (bookable is YogaClass)
                {
                    msg = bookable.ToString() + " is a Yoga class.";
                    return msg;
                }
                else
                {
                    msg = bookable.ToString() + " is a Boxing class.";
                    return msg;
                }
            }
            else if (bookable is PersonalTrainer)
            {
                msg = bookable.ToString() + " is a Personal Trainer session.";
                return msg;
            }
            else
            {
                msg = bookable.ToString() + " is an unknown sale type.";
                return msg;
            }
        }
        /// <summary>
        /// Method for paying bill that resets bill total to zero
        /// </summary>
        /// <returns>String message confirming payment</returns>
        public string Pay()
        {
            //create variable to return
            string msg;
            msg = ShowTotal() + ".  Thank you for paying for your bill.";
            runningCost = 0;
            return msg;  
        }

    }
}
