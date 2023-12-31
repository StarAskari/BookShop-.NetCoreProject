using BookShop.Domain.Model;
using BookShop.Infrastructure;

namespace BookShop.Application.Interfaces
{
    public interface IUserService:IService<User>
    {

        //Task<string> RegisterNewUser(User user);
    }
}
