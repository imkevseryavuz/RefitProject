using System.Text.Json.Serialization;

namespace RefitProject.Api.Models.Dto
{
    public class CompanyDto
    {
        [JsonPropertyName("address")]
        public AddressDto Address { get; set; }

        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
