using System.Text.Json.Serialization;

namespace RefitProject.Api.Models.Dto
{
    public class HairDto
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
