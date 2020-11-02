using EShop.Domain.Shared;

namespace EShop.Domain.Billing
{
    /// <summary>
    /// Billing information base class
    /// </summary>
    public abstract class BaseBillingInformation : BaseEntity
    {
        /// <summary>
        /// Country identifierr
        /// </summary>
        public long CountryId { get; set; }
        /// <summary>
        /// Country reference
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// House number
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Flat number
        /// </summary>
        public string FlatNumber { get; set; }

        /// <summary>
        /// Zip code of the address
        /// </summary>
        public string ZipCode { get; set; }
    }
}
