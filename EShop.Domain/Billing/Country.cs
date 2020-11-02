using EShop.CoreUtils;
using EShop.Domain.Shared;
using System.Collections.Generic;

namespace EShop.Domain.Billing
{
    /// <summary>
    /// Country
    /// </summary>
    public class Country : BaseEntity
    {
        /// <summary>
        /// ISO 3166-1 code
        /// </summary>
        public string ISOCode { get; set; }

        /// <summary>
        /// Country name in different locales
        /// </summary>
        public IReadOnlyDictionary<Locale, string> Name { get; set; } = new Dictionary<Locale, string>();
    }
}
