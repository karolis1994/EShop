using EShop.Domain.Products;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EShop.Domain
{
    /// <summary>
    /// Product
    /// </summary>
    public class Product : Entity
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
        /// Product description
        /// </summary>
        public LocalizableResourceValueObject<Product> ProductDescription { get; set; }

        /// <summary>
        /// Images of products
        /// </summary>
        public IEnumerable<ProductImage> Images { get; set; }
    }
}
