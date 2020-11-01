using EShop.CoreUtils;

namespace EShop.Domain
{
    /// <summary>
    /// Localized resource entity base class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EntityLocalizedResource<T>
    {
        /// <summary>
        /// Identifier of entity to which the localizable resource belongs
        /// </summary>
        public long EntityId { get; set; }

        /// <summary>
        /// Reference of entity to which the localizable resource belongs
        /// </summary>
        public T Entity { get; set; }

        /// <summary>
        /// Resource locale
        /// </summary>
        public Locale Locale { get; set; }

        /// <summary>
        /// Resource text in locale language
        /// </summary>
        public string Text { get; set; }
    }
}
