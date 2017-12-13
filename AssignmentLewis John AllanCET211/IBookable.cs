using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLewis_John_AllanCET211
{
    /// <summary>
    /// Interface to implement all bookable sessions for a user
    /// </summary>
    public interface IBookable
    {
        /// <summary>
        /// Property for getting the price
        /// </summary>
        double Price
        {
            get;
        }
        /// <summary>
        /// method for booking a session
        /// </summary>
        /// <returns>boolean to notify if a session has been booked</returns>
        Boolean BookSession();
    }
}
