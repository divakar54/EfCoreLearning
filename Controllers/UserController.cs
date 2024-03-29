﻿using EfCoreLearning.Configurations;
using EfCoreLearning.DTO;
using EfCoreLearning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;

namespace EfCoreLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowEmptyJsonBody]
        [HttpPost("createUser")]
        public async Task<ActionResult<ServiceResponse<UserDto>>> CreateUser([FromBody]CreateUserDto? createUserDto = null)
        {
            
            var userCreationResponse = await _userService.CreateUser(createUserDto);
            if(userCreationResponse.statusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest(userCreationResponse);
            }
            return Ok(userCreationResponse);
        }
    }
}
