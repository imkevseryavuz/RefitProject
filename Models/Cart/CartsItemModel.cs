using System.Text.Json.Serialization;

namespace RefitProject.Api.Models
{
    public class CartsItemModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("total")]
        public double Total { get; set; }

        [JsonPropertyName("discountPercentage")]
        public float DiscountPercentage { get; set; }

        [JsonPropertyName("discountedPrice")]
        public double DiscountedPrice { get; set; }




    }
}
