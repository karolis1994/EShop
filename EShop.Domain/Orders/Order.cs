using EShop.Domain.Shared;
using EShop.Domain.Users;
using System;
using System.Collections.Generic;

namespace EShop.Domain.Orders
{
    /// <summary>
    /// Order
    /// </summary>
    public class Order : BaseEntity
    {
        /// <summary>
        /// Order number
        /// </summary>
        public long OrderNumber { get; set; }

        /// <summary>
        /// Identifier of user that created the order
        /// </summary>
        public long OrderByUserId { get; set; }
        /// <summary>
        /// Reference of the user that created the order
        /// </summary>
        public RegularUser OrderByUser { get; set; }

        /// <summary>
        /// Order created at
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Marks whethers the order was paid for by the customer
        /// </summary>
        public bool IsPaidFor { get; set; }

        /// <summary>
        /// Billing information used for this order identifier
        /// </summary>
        public long BillingInformationId { get; set; }
        /// <summary>
        /// Billing information used for this order reference
        /// </summary>
        public OrderBillingInformation BillingInformation { get; set; }

        /// <summary>
        /// Products ordered
        /// </summary>
        public IEnumerable<OrderProduct> Products { get; set; }
    }
}
