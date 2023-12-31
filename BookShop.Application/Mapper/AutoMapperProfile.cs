using AutoMapper;
using BookShop.Domain.Model;
using BookShop.Application.DtoModels;

namespace BookShop.Application.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            CreateMap<User, UserDTO>();
        
        }
    }
}
