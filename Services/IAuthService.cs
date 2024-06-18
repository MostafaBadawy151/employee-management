using EmployeeManagement.Dtos;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IAuthService
    {
        Task<User> RegisterAsync(UserRegisterDto request);
        Task<string> LoginAsync(UserLoginDto request);
    }
}
