namespace EShop.Domain.Shared
{
    /// <summary>
    /// Base class of an entity
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public virtual long Id { get; set; }
    }
}
