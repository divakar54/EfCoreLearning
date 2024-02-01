using EfCoreLearning.DTO;
using System.Net;

namespace EfCoreLearning.Services
{
    public class UserService : IUserService
    {
        private readonly EfCoreDbContext _efCoreDbContext;

        public UserService(EfCoreDbContext efCoreDbContext)
        {
            _efCoreDbContext = efCoreDbContext;
        }
        public async Task<ServiceResponse<UserDto>> CreateUser(CreateUserDto createUserDto)
        {
            var serviceResponse = new ServiceResponse<UserDto>();
            if(createUserDto.Id == 0)
            {
                serviceResponse.responseMessage = "Empty User Body";
                serviceResponse.statusCode = HttpStatusCode.BadRequest;
                return serviceResponse;
            }
            return serviceResponse;
        }
    }
}
