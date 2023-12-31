﻿using BookShop.Application.DtoModels;
using BookShop.Domain.Model;
using BookShop.Infrastructure;

namespace BookShop.Application.Interfaces
{
    public interface IUserService:IService<User>
    {

        Task<int> RegisterNewUser(UserDTO user);
    }
}
