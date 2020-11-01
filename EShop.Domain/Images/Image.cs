using EShop.Domain.Shared;

namespace EShop.Domain.Images
{
    /// <summary>
    /// Image
    /// </summary>
    public class Image : BaseEntity
    {
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
