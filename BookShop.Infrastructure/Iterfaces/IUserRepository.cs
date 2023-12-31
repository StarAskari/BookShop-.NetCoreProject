using BookShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Iterfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
