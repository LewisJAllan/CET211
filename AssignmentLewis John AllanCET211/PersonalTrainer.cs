using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// Personal Trainers at the gym which implement the IComparable interface
    /// </summary>
    [Serializable]
    class PersonalTrainer : IComparable<PersonalTrainer>, IBookable
    {
        /// <summary>
        /// attribute for storing new personal trainers name
        /// </summary>
        private String name;
        /// <summary>
        /// location of new personal trainer
        /// </summary>
        private String location;
        /// <summary>
        /// monthly cost of the personal trainer
        /// </summary>
        private double price;
        /// <summary>
        /// how many members they can take on in a month
        /// </summary>
        private int totalNum;
        /// <summary>
        /// amount of members they are currently training
        /// </summary>
        private int count;
        /// <summary>
        /// property for accessing trainers name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        /// <summary>
        /// property for accessing trainers location
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
        /// propert for accessing trainers price
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
        /// property for accessing totalNum
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
        /// property for accessing the count
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
        /// constructor for passing in data to an object of class Personal Trainer
        /// </summary>
        /// <param name="name">Name of the personal trainer</param>
        /// <param name="location">location of where the personal trainer trains clients</param>
        /// <param name="totalNum"> total number of clients the trainer will take on</param>
        public PersonalTrainer(String name, String location, int totalNum)
        {
            this.name = name;
            this.location = location;            
            this.totalNum = totalNum;
            price = 30;
            count = 0;
        }
        /// <summary>
        /// method of interface IComparable to organise trainers into alphabetical order
        /// </summary>
        /// <param name="p">object of class Personal Trainer to be passed in</param>
        /// <returns>integer to sort trainers into a list</returns>
        public int CompareTo(PersonalTrainer p)
        {
            if (String.Compare(Name, p.Name) == 0)
            {
                return 0;
            }
            else if (String.Compare(Name, p.Name) > 0)
                return 1;
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Check for spaces and book a personal trainer
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

        public override string ToString()
        {
            String msg;
            msg = name + ", " + price.ToString("C") + ", " + location + ".";
            return msg;
        }
    }
}
