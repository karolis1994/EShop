using EShop.Domain.Products;
using EShop.Domain.Suppliers;

namespace EShop.Domain.Orders
{
    /// <summary>
    /// Product that is part of an order
    /// </summary>
    public class OrderProduct
    {
        /// <summary>
        /// Order identifier
        /// </summary>
        public long OrderId { get; set; }
        /// <summary>
        /// Order reference
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Product identifier
        /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// Product reference
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Product price, that was used during order time, identifier
        /// </summary>
        public long ProductPriceId { get; set; }
        /// <summary>
        /// Product price, that was used during order time, reference
        /// </summary>
        public ProductPrice ProductPrice { get;set; }

        /// <summary>
        /// Supplier of the product identifier
        /// </summary>
        public long SupplierId { get; set; }
        /// <summary>
        /// Supplier of the product reference
        /// </summary>
        public Supplier Supplier { get; set; }
    }
}
