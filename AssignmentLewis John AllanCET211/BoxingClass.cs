using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// BoxingClass is the child class of Classes
    /// </summary>
    [Serializable]
    class BoxingClass : Classes
    {
        /// <summary>
        /// Create data for an object of boxing class
        /// </summary>
        /// <param name="location">Which gym is the class held at</param>
        /// <param name="price">The cost of the class</param>
        /// <param name="count">How many people are taking the class</param>
        /// <param name="totalNum">How many people can partake in the class</param>
        public BoxingClass(String location) :base(location)
        {
            Price = 5.00;
            TotalNum = 25;
        }
        /// <summary>
        /// Informs user of the class location price and what the class is
        /// </summary>
        /// <returns>string message</returns>
        public override String ToString()
        {
            return base.ToString() + ".  The session booked is for Boxing.";
        }
    }
}
