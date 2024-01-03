using BookShop.Domain.Context;
using BookShop.Domain.Model;
using BookShop.Infrastructure.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Repositories
{
    public class RoleRepository : Repository<Role>,IRoleRepository
    {
        private BookShopDbContext _dbContext;
        public RoleRepository(BookShopDbContext dbContext) :base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
