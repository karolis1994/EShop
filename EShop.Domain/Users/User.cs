using EShop.Domain.Shared;

namespace EShop.Domain.Users
{
    /// <summary>
    /// Shop user
    /// </summary>
    public class User : BaseEntity
    {
        public User(UserType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Type of user
        /// </summary>
        public UserType Type { get; set; }
    }
}
