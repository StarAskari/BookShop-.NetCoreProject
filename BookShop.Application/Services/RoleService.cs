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
    internal class RoleService : IRoleService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public RoleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        

        public Role Get(int id, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAll(string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> Find(Expression<Func<Role, bool>> predicate)
        {
           return _unitOfWork.RoleRepository.Find(predicate);
        }

        public void Save(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public void SaveList(IEnumerable<Role> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Role entity)
        {
            throw new NotImplementedException();
        }

        public List<Role> FindWithIncludes(Expression<Func<Role, bool>> predicate, string[] includes)
        {
            return _unitOfWork.RoleRepository.FindWithIncludes(predicate, includes);
        }

        public async Task<List<Role>> FindWithIncludesAsync(Expression<Func<Role, bool>> predicate, string[] includes)
        {
            return await _unitOfWork.RoleRepository.FindWithIncludesASync(predicate, includes);
        }
    }
}
