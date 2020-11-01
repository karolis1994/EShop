using EShop.Domain.Shared;
using System;

namespace EShop.Domain.Pricing
{
    /// <summary>
    /// Discount
    /// </summary>
    public class Discount : BaseEntity
    {
        /// <summary>
        /// Percentage off price
        /// </summary>
        public decimal PercentageOffPrice { get; set; }

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
