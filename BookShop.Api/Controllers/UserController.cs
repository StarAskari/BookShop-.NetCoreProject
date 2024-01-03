using BookShop.Application.Interfaces;
using BookShop.Domain.Model;
using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BookShop.Application.DtoModels;

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

        [HttpPost(Name = "RegisterNewUser")]
       
        public async Task<IActionResult> Register(UserDTO userDto)
        {
            int userId = 0;
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }
            try
            {
               userId= await _userService.RegisterNewUser(userDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return StatusCode(StatusCodes.Status200OK, userId);
        }
    }
}
