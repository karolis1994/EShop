using EShop.Domain.Images;

namespace EShop.Domain.Products
{
    /// <summary>
    /// Product image
    /// </summary>
    public class ProductImage
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// Product reference
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Image identifier
        /// </summary>
        public long ImageId { get; set; }
        /// <summary>
        /// Image reference
        /// </summary>
        public Image Image { get; set; }
    }
}
