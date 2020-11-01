namespace EShop.Domain.Users
{
    /// <summary>
    /// Administrator user
    /// </summary>
    public class AdministratorUser : User
    {
        public AdministratorUser() : base(UserType.Administrator) { }
    }
}
