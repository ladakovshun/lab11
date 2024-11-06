using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication111.Services;

namespace WebApplication111.Filters
{
    public class ActionLoggingFilter : IActionFilter
    {
        private readonly ILogService _logService;

        public ActionLoggingFilter(ILogService logService)
        {
            _logService = logService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string message = $"Method: {context.ActionDescriptor.DisplayName}, Time: {DateTime.Now}";
            _logService.LogAction(message);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //
        }
    }
}