namespace Utilities
{
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}] {message}");
        }

        public static void LogError(string message, Exception ex)
        {
            Console.WriteLine($"[ERROR - {DateTime.Now}] {message}: {ex.Message}");
        }
    }
}
