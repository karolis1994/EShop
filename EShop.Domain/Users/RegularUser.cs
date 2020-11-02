namespace EShop.Domain.Users
{
    /// <summary>
    /// Regular user of eshop
    /// </summary>
    public class RegularUser : User
    {
        public RegularUser() : base(UserType.Regular)
        {
        }

        /// <summary>
        /// Is email of user confirmed
        /// </summary>
        public bool IsEmailConfirmed { get; set; }

        /// <summary>
        /// Name of user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Surname of user
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Billing information identifier
        /// </summary>
        public long? BillingInformationId { get; set; }
        /// <summary>
        /// Billing information reference
        /// </summary>
        public RegularUserBillingInformation BillingInformation { get; set; }
    }
}
