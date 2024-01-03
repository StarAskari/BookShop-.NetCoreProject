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
    internal class UserService:IUserService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IRoleService _roleService;
        private IUserRoleService _userRoleService;


        public UserService (IUnitOfWork unitOfWork,IMapper mapper,IRoleService roleService,IUserRoleService userRoleService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _roleService = roleService;
            _userRoleService = userRoleService;

        }


        public async Task<int> RegisterNewUser(UserDTO DtoUser)
        {
            var UserId = 0;
            try
            {
                var user = _mapper.Map<User>(DtoUser);
                user.NoeUser = EnumNoeUser.User;
                user.PasswordHash = user.PasswordHash.GetHashCode().ToString();
                await _unitOfWork.UserRepository.AsyncSave(user);
                 UserId = _unitOfWork.UserRepository.GetAutoGenaretedID(user);
                var role = _roleService.Find(r => r.RoleName == "User").FirstOrDefault();
                var RoleId = role.Id;
                var userRole = _mapper.Map<UserRole>((user, role));
                userRole.IsActive = EnumActiveOrNot.Active;
                await _userRoleService.SaveAsync(userRole);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            return UserId;
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
            return _unitOfWork.UserRepository.Find(predicate);
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

        public Task SaveAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
