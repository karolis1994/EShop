using System;
using System.Collections.Generic;
using System.Text;

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
        /// Image name
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// Contents of the image
        /// </summary>
        public byte[] Content { get; set; }
    }
}
