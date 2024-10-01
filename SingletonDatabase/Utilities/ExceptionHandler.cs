using System;

namespace Utilities
{
    public static class ExceptionHandler
    {
        public static void HandleException(Exception ex)
        {
            Logger logger = Logger.GetInstance();
            logger.Log($"Exception occurred: {ex.Message}");

            Console.WriteLine("An error occurred. Please try again later.");
        }
    }
}
