using OnePro.Front.ViewModels.Auth;
using OnePro.Front.ViewModels.Shared;

namespace OnePro.Front.Services.Interfaces
{
    public interface IAuthService
    {
        Task<(bool success, string message, string token, UserResponse user)> LoginAsync(LoginRequest model);
        Task<(bool success, string message, string token, UserResponse user)> RegisterAsync(RegisterRequest model);
    }
}
