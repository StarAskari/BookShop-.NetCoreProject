using System.Globalization;

namespace BookShop.Application.DtoModels
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ConfirmedEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string UserName { get; set; }
    }
}
