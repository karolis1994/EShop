using EShop.CoreUtils;
using EShop.Domain.Shared;
using System;
using System.Collections.Generic;

namespace EShop.Domain.Pricing
{
    /// <summary>
    /// Discount coupon
    /// </summary>
    public class DiscountCoupon : BaseEntity, IDiscount
    {
        /// <summary>
        /// Name of coupon
        /// </summary>
        public IReadOnlyDictionary<Locale, string> Name { get; set; } = new Dictionary<Locale, string>();

        /// <summary>
        /// Code of coupon
        /// </summary>
        public string Code { get; set; }

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
