using Microsoft.AspNetCore.Mvc;
using RefitProject.Api.Models.Dto;
using RefitProject.Api.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RefitProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRefitService _userServices;
        public UserController(IRefitService productServices)
        {
            _userServices = productServices;
        }

        [HttpGet("GetUsers", Name = "GetUsers")]
        [ProducesResponseType(typeof(UserDto), 200)]
        [Produces("application/json")]
        public async Task<ActionResult> GetCarts()
        {

            return Ok(await _userServices.GetUsers());
        }

        [HttpGet("GetUserById", Name = "GetUserById")]
        [ProducesResponseType(typeof(CartDto), 200)]
        [Produces("application/json")]
        public async Task<ActionResult> GetUserById(int id)
        {
            var response = await _userServices.GetUserById(id);
            return Ok(response);
        }
    }
}
