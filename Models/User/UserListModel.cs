using Microsoft.AspNetCore.Identity;
using RefitProject.Api.Models.Dto;
using System.Text.Json.Serialization;

namespace RefitProject.Api.Models.User
{
    public class UserListModel
    {
        [JsonPropertyName("users")]
        public List<UserDto> Users { get; set; }
    }
}
