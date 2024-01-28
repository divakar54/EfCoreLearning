using EfCoreLearning.DTO;

namespace EfCoreLearning.Services
{
    public interface IUserService
    {
        public Task<ServiceResponse<UserDto>> CreateUser(CreateUserDto createUserDto);
        
    }
}
