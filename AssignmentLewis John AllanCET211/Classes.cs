using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// An abstract class for booking specific gym classes at a gym
    /// </summary>
    [Serializable]
    abstract class Classes : IBookable
    {
        /// <summary>
        /// attribute for containing object location
        /// </summary>
        private String location;
        /// <summary>
        /// attribute for storing price value of object
        /// </summary>
        private double price;
        /// <summary>
        /// attribute for tallying total number of members in class
        /// </summary>
        private int count;
        /// <summary>
        /// attribute for the class total member size possible
        /// </summary>
        private int totalNum;

        public Classes(string location)
        {
            this.location = location;
            this.count = 0;
        }

        /// <summary>
        /// property for accessing the location attribute
        /// </summary>
        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
        /// <summary>
        /// property for accessing the price attribute
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        /// <summary>
        /// property for accessing the count attribute
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
        /// <summary>
        /// property for accessing the totalNum attribute
        /// </summary>
        public int TotalNum
        {
            get
            {
                return totalNum;
            }

            set
            {
                totalNum = value;
            }
        }
        /// <summary>
        /// Check for spaces and book a class
        /// </summary>
        /// <returns>true if spaces and adjusts size</returns>
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
                //bool = boxingclass1.BookSession();
                //if (bool = true)
                //{ say it was true etc }
                //for main form when calling
            }
        }
        /// <summary>
        /// Write a message for an object of this class
        /// </summary>
        /// <returns>a string message</returns>
        public override string ToString()
        {
            String msg;
            msg = "The gym for this class is located at: " + location + " and it has a monthly cost of: " + price.ToString("C");
            return msg;
        }
    }
}
