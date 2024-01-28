using System.Net;

namespace EfCoreLearning.DTO
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public string responseMessage { get; set; } = string.Empty;
        public HttpStatusCode? statusCode { get; set; }
    }
}
