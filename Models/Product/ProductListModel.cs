using System.Text.Json.Serialization;

namespace RefitProject.Api.Models
{
    public class ProductListModel
    {
        [JsonPropertyName("products")] 
        public List<ProductDto> Products { get; set; }

    }
}
