using RefitProject.Api.Models.Dto;
using System.Text.Json.Serialization;

namespace RefitProject.Api.Models
{
    public class CartListModel
    {
        [JsonPropertyName("carts")]
        public List<CartDto> Carts { get; set; }
    }
}
