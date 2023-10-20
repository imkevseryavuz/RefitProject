using Microsoft.AspNetCore.Mvc;
using RefitProject.Api.Models;
using RefitProject.Api.Service;

namespace RefitProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRefitService _productServices;
        public ProductController(IRefitService productServices)
        {
            _productServices = productServices;
        }

        [HttpGet("GetProducts", Name = "GetProducts")]
        [ProducesResponseType(typeof(ProductDto), 200)]
        [Produces("application/json")]
        public async Task<ActionResult> GetProducts()
        {
           
            return Ok(await _productServices.GetProducts());
        }

        [HttpGet("GetProductById", Name = "GetProductById")]
        [ProducesResponseType(typeof(ProductDto), 200)]
        [Produces("application/json")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var response=await _productServices.GetProductById(id);
            return Ok(response);
        }

    }
}
