using EShop.CoreUtils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Domain
{
    /// <summary>
    /// Abstract class for localizable entities
    /// </summary>
    public class LocalizableResourceValueObject<T>
    {
        private HashSet<EntityLocalizedResource<T>> _resources { get; set; } = new HashSet<EntityLocalizedResource<T>>();
        /// <summary>
        /// Localized resources of the entity
        /// </summary>
        public IEnumerable<EntityLocalizedResource<T>> Resources => _resources;

        public void AddLocalizedResource(EntityLocalizedResource<T> item)
        {
            if (item == null)
                throw new ArgumentNullException();
            if (!_resources.Any(e => e.Locale == item.Locale))
                throw new ArgumentException("Cannot contain multiple resources of the same locale.");

            _resources.Add(item);
        }

        /// <summary>
        /// Remove localized resource
        /// </summary>
        /// <param name="item">Item to be removed</param>
        /// <returns></returns>
        public bool RemoveLocalizedResource(EntityLocalizedResource<T> item) => _resources.Remove(item);

        /// <summary>
        /// Remove localized resource
        /// </summary>
        /// <param name="locale">Locale of the item to be removed</param>
        /// <returns></returns>
        public bool RemoveLocalizedResource(Locale locale) => _resources.RemoveWhere(e => e.Locale == locale) > 0;
    }
}
