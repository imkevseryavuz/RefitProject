using System.Text.Json.Serialization;

namespace RefitProject.Api.Models.Dto
{
    public class CoordinateDto
    {
        [JsonPropertyName("lat")]
        public float Lat { get; set; }

        [JsonPropertyName("lng")]
        public float Lng { get; set; }
    }
}
