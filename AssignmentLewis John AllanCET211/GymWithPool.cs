using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// child class of Gym for booking a month at a gym with a pool
    /// </summary>
    [Serializable]
    class GymWithPool : Gym
    {
        /// <summary>
        /// Constructor to pass in data values for an object
        /// </summary>
        /// <param name="location">Location of the gym, which town/city</param>
        /// <param name="price">The monthly cost of the gym</param>
        /// <param name="count">How many members are attending the gym</param>
        /// <param name="totalNum">Amount of available memberships remainding</param>
        public GymWithPool(String location) : base(location)
        {
            
            Price = 25.00;
            TotalNum = 300;
        }
        
        /// <summary>
        /// string to output to screen showing this gym comes with a pool
        /// </summary>
        /// <returns>A message containing location price and that it has a pool</returns>
        public override String ToString()
        {
            return base.ToString() + " this gym has a pool ";
        }
    }
}
