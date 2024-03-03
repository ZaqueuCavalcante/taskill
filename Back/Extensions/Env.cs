namespace Taskill.Back.Extensions;

public static class Env
{
    private static readonly string Testing = nameof(Testing);
    private static readonly string Development = nameof(Development);

    public static void SetAsTesting()
    {
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", Testing);
    }

    public static bool IsTesting()
    {
        return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == Testing;
    }

    public static bool IsDevelopment()
    {
        return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == Development;
    }
}
