using System.Text.Json.Serialization;

namespace RefitProject.Api.Models
{
    public class ProductDto
    {
        [JsonPropertyName("id")] 
        public int Id { get; set; }
        [JsonPropertyName("title")] 

        public string Title { get; set; }
        [JsonPropertyName("description")] 

        public string Description { get; set; }
        [JsonPropertyName("price")] 
        public decimal Price { get; set; }

        [JsonPropertyName("discountPercentage")] 
        public float DiscountPercentage { get; set; }

        [JsonPropertyName("rating")] 
        public float Rating { get; set; }

        [JsonPropertyName("stock")] 
        public double Stock { get; set; }

        [JsonPropertyName("brand")] 
        public string Brand { get; set; }

        [JsonPropertyName("category")] 
        public string Category { get; set; }

        [JsonPropertyName("thumbnail")] 
        public string Thumbnail { get; set; }

        [JsonPropertyName("images")] 
        public List<string> Images { get; set; }


    }
}
