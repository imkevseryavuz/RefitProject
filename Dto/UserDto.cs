using RefitProject.Api.Models;
using System.Text.Json.Serialization;

namespace RefitProject.Api.Models.Dto
{
    public class UserDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("maidenName")]
        public string MaidenName { get; set; }

        [JsonPropertyName("age")]
        public double Age { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("birthDate")]
        public string BirthDate { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("bloodGroup")]
        public string BloodGroup { get; set; }

        [JsonPropertyName("height")]
        public double Height { get; set; }

        [JsonPropertyName("weight")]
        public double Weight { get; set; }

        [JsonPropertyName("eyeColor")]
        public string EyeColor { get; set; }

        [JsonPropertyName("hair")]
        public HairDto Hair { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("ip")]
        public string IP { get; set; }

        [JsonPropertyName("address")]
        public AddressDto Address { get; set; }

        [JsonPropertyName("macAddress")]
        public string MacAddress { get; set; }

        [JsonPropertyName("university")]
        public string University { get; set; }

        [JsonPropertyName("bank")]
        public BankDto Bank { get; set; }

        [JsonPropertyName("company")]
        public CompanyDto Company { get; set; }

        [JsonPropertyName("ein")]
        public string Ein { get; set; }

        [JsonPropertyName("ssn")]
        public string Ssn { get; set; }

        [JsonPropertyName("userAgent")]
        public string UserAgent { get; set; }

    }
}
