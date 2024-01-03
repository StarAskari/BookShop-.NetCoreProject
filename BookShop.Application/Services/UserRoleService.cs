using AutoMapper;
using BookShop.Application.DtoModels;
using BookShop.Application.FluentValidations;
using BookShop.Application.Interfaces;
using BookShop.Domain.Common;
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
using System.Web.Mvc;

namespace BookShop.Application.Services
{
    internal class UserRoleService : IUserRoleService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public UserRoleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public UserRole Get(int id, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserRole> GetAll(string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserRole> Find(Expression<Func<UserRole, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Save(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(UserRole entity)
        {
            await _unitOfWork.UserRoleRepository.AsyncSave(entity);
        }

        public void SaveList(IEnumerable<UserRole> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public List<UserRole> FindWithIncludes(Expression<Func<UserRole, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserRole>> FindWithIncludesAsync(Expression<Func<UserRole, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }
    }
}
