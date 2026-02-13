using backened_for_intern.Models.DTOs;

namespace backened_for_intern.Interfaces
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginDto dto);
    }
}
