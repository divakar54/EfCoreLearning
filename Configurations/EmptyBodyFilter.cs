using EfCoreLearning.DTO;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EfCoreLearning.Configurations
{
    public class EmptyBodyFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var contentLength = context.HttpContext.Request.ContentLength;
           
            if(contentLength < 3)
            {
                var serviceResponse = new ServiceResponse<object>
                {
                    Data = null,
                    responseMessage = "Empty Json Body"
                };
                context.Result = new BadRequestObjectResult(serviceResponse);
                return;
            }
        }
    }
}
