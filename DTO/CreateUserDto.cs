
namespace EfCoreLearning.DTO
{
    public class CreateUserDto
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int MobileNo { get; set; }
        public string? EmailId { get; set; }
        
    }
}
