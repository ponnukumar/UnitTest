using System;
using System.Collections.Generic;
using System.Text;

namespace TECHIES.Core.Domain
{
    public class Customers
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public int CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        public string CustomerName { get; set; }
        /// <summary>
        /// Gets or sets the customer phone.
        /// </summary>
        /// <value>
        /// The customer phone.
        /// </value>
        public string CustomerPhone { get; set; }
       
    }
}
