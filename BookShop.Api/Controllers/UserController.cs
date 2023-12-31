using BookShop.Application.Interfaces;
using BookShop.Domain.Model;
using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace BookShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        //public async Task<IActionResult> Register(UserDTO userDto)
        //{
        //    var user = _mapper.Map<User>(userDto);
        //    user.PasswordHash = userDto.pasword.GetHashCode().ToString();
        //    if (!ModelState.IsValid)
        //    {
        //        return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        //    }
        //    try
        //    {
        //        await _userService.RegisterNewUser(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //  return RedirectToAction("Index", "Home");
        //}
    }
}
