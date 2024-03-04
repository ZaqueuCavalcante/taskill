namespace Taskill.Back;

public class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddSettingsConfigs();
        services.AddServicesConfigs();

        services.AddControllers();
        services.AddHttpConfigs();

        services.AddEfCoreConfigs();

        services.AddSwaggerConfigs();
        services.AddCorsConfigs();
    }

    public static void Configure(IApplicationBuilder app, TaskillDbContext ctx)
    {
        // ctx.ResetDb();

        app.UseCors();
        app.UseRouting();

        app.UseSwaggerThings();
        app.UseDomainExceptions();

        app.UseControllers();
    }
}
