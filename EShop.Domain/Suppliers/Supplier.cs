using EShop.Domain.Products;
using EShop.Domain.Shared;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace EShop.Domain.Suppliers
{
    /// <summary>
    /// Supplier of products
    /// </summary>
    public class Supplier : BaseEntity
    {
        /// <summary>
        /// Name of supplier
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Code of supplier
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Products supplied by this supplier
        /// </summary>
        public IEnumerable<SupplierProduct> Products {get;set;}
    }
}
