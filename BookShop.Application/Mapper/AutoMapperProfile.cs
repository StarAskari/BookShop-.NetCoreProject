using AutoMapper;
using BookShop.Domain.Model;
using BookShop.Application.DtoModels;

namespace BookShop.Application.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            CreateMap<UserDTO, User>();
            CreateMap<(User, Role), UserRole>()
            .ForMember(ur => ur.UserId, map => map.MapFrom(t => t.Item1.Id))
            .ForMember(ur => ur.RoleId, map => map.MapFrom(t => t.Item2.Id));

        }
    }
}
