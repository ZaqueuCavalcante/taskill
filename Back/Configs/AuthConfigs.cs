namespace Taskill.Back.Configs;

public static class AuthConfigs
{
    public static void AddAuthConfigs(this IServiceCollection services)
    {
        var serviceProvider = services.BuildServiceProvider();
        var settings = serviceProvider.GetService<AuthSettings>();

        // https://dev.to/mohammedahmed/build-your-own-oauth-20-server-and-openid-connect-provider-in-aspnet-core-60-1g1m

        services.AddAuthentication(options =>
        {
            options.DefaultScheme = "Cookies";
            options.DefaultChallengeScheme = "Google";
        })
        .AddCookie()
        .AddGoogle(options =>
        {
            options.ClientId = settings.GoogleClientId;
            options.ClientSecret = settings.GoogleClientSecret;
        });
    }
}
