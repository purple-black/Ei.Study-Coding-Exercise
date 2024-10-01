namespace Utilities
{
    public static class ExceptionHandling
    {
        public static void HandleException(Exception ex)
        {
            Logger.LogError("An error occurred", ex);
        }
    }
}
