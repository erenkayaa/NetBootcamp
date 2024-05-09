using Microsoft.AspNetCore.Mvc;
using NetBootcamp.API.Controllers;
using NetBootcamp.API.DTOs;
using NetBootcamp.API.Users.DTOs;

namespace NetBootcamp.API.Users
{
    public class UserController : CustomBaseController
    {
       

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


       
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("{userId}")]
        public IActionResult GetById(int userId)
        {
            return CreateActionResult(_userService.GetById(userId));
        }


        [HttpPost]
        public IActionResult Create(UserCreateRequestDto request)
        {
            var result = _userService.Create(request);

            return CreateActionResult(result, nameof(GetById), new { userId = result.Data });
        }

        
        [HttpPut("{userId}")]
        public IActionResult Update(int userId, UserUpdateRequestDto request)
        {
            return CreateActionResult(_userService.Update(userId, request));
        }


        [HttpDelete("{userId}")]
        public IActionResult Delete(int userId)
        {
            return CreateActionResult(_userService.Delete(userId));
        }
    }
}