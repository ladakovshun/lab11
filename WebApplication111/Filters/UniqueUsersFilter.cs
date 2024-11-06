using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication111.Services;

namespace WebApplication111.Filters
{
    public class UniqueUsersFilter : IActionFilter
    {
        private readonly ILogService _logService;
        private static HashSet<string> uniqueUsers = new HashSet<string>();

        public UniqueUsersFilter(ILogService logService)
        {
            _logService = logService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string userIp = context.HttpContext.Connection.RemoteIpAddress?.ToString() ?? "Unknown";

            if (uniqueUsers.Add(userIp))
            {
                string message = $"User IP: {userIp}, Request Time: {DateTime.Now}";
                _logService.LogUniqueUser(message);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //
        }
    }
}