using System.Globalization;

namespace BookShop.Application.DtoModels
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string email { get; set; }
        public string ConfirmedEmail { get; set; }
        public string pasword { get; set; }
        public string username { get; set; }
    }
}
