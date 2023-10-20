using System.Text.Json.Serialization;

namespace RefitProject.Api.Models.Dto
{
    public class CartDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("products")]
        public List<CartsItemModel>  Products { get; set;}

    }
}
