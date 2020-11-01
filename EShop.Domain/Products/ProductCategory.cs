using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Domain.Products
{
    /// <summary>
    /// Category of product
    /// </summary>
    public class ProductCategory : Entity
    {
        /// <summary>
        /// Parent category identifier
        /// </summary>
        public long? ParentCategoryId { get; set; }
        /// <summary>
        /// Parent category reference
        /// </summary>
        public ProductCategory ParentCategory { get; set; }

        /// <summary>
        /// Sub categories of products
        /// </summary>
        public IEnumerable<ProductCategory> SubCategories { get; set; }
    }
}
