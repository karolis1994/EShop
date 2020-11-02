using EShop.CoreUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Domain.Pricing
{
    /// <summary>
    /// Discount coupon
    /// </summary>
    public class DiscountCoupon : Discount
    {
        /// <summary>
        /// Name of coupon
        /// </summary>
        public IReadOnlyDictionary<Locale, string> Name { get; set; } = new Dictionary<Locale, string>();

        /// <summary>
        /// Code of coupon
        /// </summary>
        public string Code { get; set; }
    }
}
