using Microsoft.AspNetCore.Mvc;
using RefitProject.Api.Models;
using RefitProject.Api.Models.Dto;
using RefitProject.Api.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RefitProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IRefitService _cartServices;
        public CartController(IRefitService productServices)
        {
            _cartServices = productServices;
        }

        [HttpGet("GetCarts", Name = "GetCarts")]
        [ProducesResponseType(typeof(CartDto), 200)]
        [Produces("application/json")]
        public async Task<ActionResult> GetCarts()
        {

            return Ok(await _cartServices.GetCarts());
        }

        [HttpGet("GetCartById", Name = "GetCartById")]
        [ProducesResponseType(typeof(CartDto), 200)]
        [Produces("application/json")]
        public async Task<ActionResult> GetCartById(int id)
        {
            var response = await _cartServices.GetCartById(id);
            return Ok(response);
        }

    }
}
