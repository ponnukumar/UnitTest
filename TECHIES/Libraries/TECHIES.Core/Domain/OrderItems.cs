using System;
using System.Collections.Generic;
using System.Text;

namespace TECHIES.Core.Domain
{
    public class OrderItems
    {
        /// <summary>
        /// Gets or sets the order item identifier.
        /// </summary>
        /// <value>
        /// The order item identifier.
        /// </value>
        public int OrderItemId { get; set; }
        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>
        /// The order identifier.
        /// </value>
        public int OrderId { get; set; }
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductId { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public Products Products { get; set; }

    }
}
