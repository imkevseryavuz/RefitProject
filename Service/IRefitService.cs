using Refit;
using RefitProject.Api.Models;
using RefitProject.Api.Models.Dto;
using RefitProject.Api.Models.User;

namespace RefitProject.Api.Service
{
    [Headers("Content-Type: application/json")]
    public interface IRefitService
    {
        //Product
        [Get("/products")]
        Task<ProductListModel> GetProducts();

        [Get("/products/{id}")]
        Task<ProductDto> GetProductById(int id);

        [Get("/carts")]
        Task<CartListModel> GetCarts();

        [Get("/carts/{id}")]
        Task<CartDto> GetCartById(int id);

        [Get("/users")]
        Task<UserListModel> GetUsers();

        [Get("/users/{id}")]
        Task<UserModel> GetUserById(int id);


    }
}
