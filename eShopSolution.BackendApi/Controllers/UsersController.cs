﻿using System.Threading.Tasks;
using eShopSolution.Application.System.Users;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody]LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resultToken = await _userService.Authencate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("Username or passwoed is incorrect.");
            }
            return Ok(resultToken);
        }

        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userService.Register(request);
            if (!result)
            {
                return BadRequest("Register is unsuccesssful.");
            }
            return Ok();
        }
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetUserPagingRequest request)
        {
            var users = await _userService.GetUsersPaging(request);
            return Ok(users);
        }
    }
}