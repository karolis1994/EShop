using EShop.Domain.Shared;
using System;

namespace EShop.Domain.Pricing
{
    public abstract class BasePrice<T> : BaseEntity
    {
        /// <summary>
        /// Entity to which the price is assigned identifier
        /// </summary>
        public long EntityId { get; set; }
        /// <summary>
        /// Entity to which the price is assigned reference
        /// </summary>
        public T Entity { get; set; }

        /// <summary>
        /// Price of product
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Date from which the sale starts
        /// </summary>
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Date until which the sale lasts
        /// </summary>
        public DateTime ValidTo { get; set; }
    }
}
