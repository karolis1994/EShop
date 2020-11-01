using EShop.Domain.Shared;
using System.Collections.Generic;

namespace EShop.Domain.Products
{
    /// <summary>
    /// Category of product
    /// </summary>
    public class ProductCategory : BaseEntity
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

        /// <summary>
        /// Products of this category
        /// </summary>
        public IEnumerable<Product> Products { get; set; }

        /// <summary>
        /// Discounts that apply to all products inside of this category
        /// </summary>
        public IEnumerable<ProductCategoryDiscount> Discounts { get; set; }
    }
}
