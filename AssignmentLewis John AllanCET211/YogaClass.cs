using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// YogaClass is the child class of Classes
    /// </summary>
    [Serializable]
    class YogaClass : Classes
    {
        /// <summary>
        /// Data to be passed in for an object of class Yoga
        /// </summary>
        /// <param name="location">Gyms location for yoga class</param>
        /// <param name="price">the cost of the yoga session</param>
        /// <param name="count">how many people are partaking in the class</param>
        /// <param name="totalNum">how many people can partake in the class</param>
        public YogaClass(String location) :base(location)
        {
            Price = 7.00;
            TotalNum = 30;
        }
        /// <summary>
        /// Informs user of the class location price and what the class is
        /// </summary>
        /// <returns>string message</returns>
        public override String ToString()
        {
            return base.ToString() + ".  The session booked is for Yoga.";
        }
    }
}
