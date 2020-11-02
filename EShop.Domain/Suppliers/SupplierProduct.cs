using EShop.Domain.Suppliers;

namespace EShop.Domain.Products
{
    /// <summary>
    /// Product supplier
    /// </summary>
    public class SupplierProduct
    {
        /// <summary>
        /// Supplier identifier
        /// </summary>
        public long SupplierId { get; set; }
        /// <summary>
        /// Supplier reference
        /// </summary>
        public Supplier Supplier { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// Product reference
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Quantity of available products
        /// </summary>
        public int Quantity { get; set; }
    }
}
