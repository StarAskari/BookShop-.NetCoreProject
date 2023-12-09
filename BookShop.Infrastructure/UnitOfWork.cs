using BookShop.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly BookShopDbContext _context;
        public UnitOfWork(BookShopDbContext context)
        {
            _context = context;
          

        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
