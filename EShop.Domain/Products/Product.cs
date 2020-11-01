using EShop.CoreUtils;
using EShop.Domain.Shared;
using System.Collections.Generic;

namespace EShop.Domain.Products
{
    /// <summary>
    /// Product
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// The name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique code of the product
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Category identifier
        /// </summary>
        public long CategoryId { get; set; }
        /// <summary>
        /// Category reference
        /// </summary>
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Product price
        /// </summary>
        public ProductPrice Price { get; set; }

        /// <summary>
        /// Product description in different locales
        /// </summary>
        public IReadOnlyDictionary<Locale, string> Description { get; set; } = new Dictionary<Locale, string>();

        /// <summary>
        /// Images of products
        /// </summary>
        public IEnumerable<ProductImage> Images { get; set; }

        /// <summary>
        /// Product prices for various time spans
        /// </summary>
        public IEnumerable<ProductPrice> Prices { get; set; }

        /// <summary>
        /// Discounts that apply to the product
        /// </summary>
        public IEnumerable<ProductDiscount> Discounts { get; set; }
    }
}
