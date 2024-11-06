namespace WebApplication111.Services
{
    public class LogService : ILogService
    {
        private readonly string actionLogPath = "ActionLog.txt";
        private readonly string uniqueUserLogPath = "UniqueUsersLog.txt";

        public void LogAction(string message)
        {
            File.AppendAllText(actionLogPath, $"{message}\n");
        }

        public void LogUniqueUser(string message)
        {
            File.AppendAllText(uniqueUserLogPath, $"{message}\n");
        }
    }
}