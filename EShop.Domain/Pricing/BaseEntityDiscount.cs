namespace EShop.Domain.Pricing
{
    /// <summary>
    /// Base class of joined discount and entity class
    /// </summary>
    public abstract class BaseEntityDiscount<T>
    {
        /// <summary>
        /// Entity to which the sale applies identifier
        /// </summary>
        public long EntityId { get; set; }
        /// <summary>
        /// Entity to which the sale applies reference
        /// </summary>
        public T Entity { get; set; }

        /// <summary>
        /// Sale identifier
        /// </summary>
        public long DiscountId { get; set; }
        /// <summary>
        /// Sale reference
        /// </summary>
        public Discount Discount { get; set; }
    }
}
