namespace WebApplication111.Services
{
    public interface ILogService
    {
        void LogAction(string message);
        void LogUniqueUser(string message);
    }
}