using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// Serializable class for handling data objects for different gyms
    /// </summary>
    [Serializable]
    class Gym : IBookable
    {
        /// <summary>
        /// Attribute containing object information of Gyms location
        /// </summary>
        private String location;
        /// <summary>
        /// attribute containing object information of the gyms price
        /// </summary>
        private double price;
        /// <summary>
        /// attribute to store the total amount of users at the gym
        /// </summary>
        private int totalNum;
        /// <summary>
        /// property for accessing the attribute totalNum
        /// </summary>
        public int TotalNum
        {
            get { return totalNum; }
            set { totalNum = value; }
        }
        /// <summary>
        /// Property for accessing the attribute, location
        /// </summary>
        public String Location
        {
            get { return location; }
            set { location = value; }
        }
        /// <summary>
        /// Property for accessing the attribute, price
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// attribute holding the number of spaces taken in the gym
        /// </summary>
        private int count;
        /// <summary>
        /// property access modifier for spaces
        /// </summary>
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        /// <summary>
        /// constructor that requires the location to be entered, price is set to fixed cost
        /// </summary>
        /// <param name="location">location of the gym</param>
        public Gym(String location)
        {
            this.location = location;
            this.count = 0;
            this.price = 10.00;
            this.totalNum = 200;

        }
        /// <summary>
        /// Method for the user booking a session
        /// </summary>
        public virtual Boolean BookSession()
        {
            if (TotalNum == 0)
            {
                return false;
            }
            else
            {
                TotalNum--;
                Count++;
                return true;
                //bool = gym1.BookSession();
                //if (bool = true)
                //{ say it was true etc }
                //for main form when calling
            }
        }
        /// <summary>
        /// Overriding function for writing a string to screen
        /// </summary>
        /// <returns>String value containing location and price</returns>
        public override string ToString()
        {
            String msg;
            msg = "The current gym is located at: " + location + " and it has a monthly cost of: " + price.ToString("C");
            return msg;
        }
    }
}
