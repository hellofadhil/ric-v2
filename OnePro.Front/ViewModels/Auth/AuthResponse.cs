using Newtonsoft.Json;
using OnePro.Front.ViewModels.Shared;

namespace OnePro.Front.ViewModels.Auth
{
    public class AuthResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("user")]
        public UserResponse User { get; set; }
    }
}
