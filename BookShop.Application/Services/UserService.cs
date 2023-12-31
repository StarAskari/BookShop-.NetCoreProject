using BookShop.Application.FluentValidations;
using BookShop.Application.Interfaces;
using BookShop.Domain.Model;
using BookShop.Infrastructure;
using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Services
{
    internal class UserService:IUserService
    {
        private IUnitOfWork _unitOfWork;
        

        public UserService (IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<string> RegisterNewUser(User user)
        {
        
        }

        public void Save(User entity)
        {
            _unitOfWork.UserRepository.Save(entity);   
        }
        public User Get(int id, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll(string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }



        public void SaveList(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> FindWithIncludes(Expression<Func<User, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> FindWithIncludesAsync(Expression<Func<User, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

    }
}
