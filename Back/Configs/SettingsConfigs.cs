namespace Taskill.Back.Configs;

public static class SettingsConfigs
{
    public static void AddSettingsConfigs(this IServiceCollection services)
    {
        services.AddSingleton<AuthSettings>();
        services.AddSingleton<DatabaseSettings>();
    }
}
