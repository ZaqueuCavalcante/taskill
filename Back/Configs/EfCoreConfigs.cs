namespace Taskill.Back.Configs;

public static class EfCoreConfigs
{
    public static void AddEfCoreConfigs(this IServiceCollection services)
    {
        services.AddDbContext<TaskillDbContext>();
    }
}
