using EShop.Domain.Pricing;
using System.Collections;

namespace EShop.Domain.Products
{
    /// <summary>
    /// The price of the product
    /// </summary>
    public class ProductPrice : BasePrice<Product> 
    { 
        public IEnumerable<ProductDiscount> SalesThatApp
    }
}
