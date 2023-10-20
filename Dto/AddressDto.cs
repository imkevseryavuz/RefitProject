using System.Text.Json.Serialization;

namespace RefitProject.Api.Models.Dto
{
    public class AddressDto
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("coordinates")]
        public CoordinateDto Coordinates {  get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
