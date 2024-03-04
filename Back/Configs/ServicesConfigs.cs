using Taskill.Back.GetTasks;
using Taskill.Back.CreateTask;

namespace Taskill.Back.Configs;

public static class ServicesConfigs
{
    public static void AddServicesConfigs(this IServiceCollection services)
    {
        services.AddScoped<CreateTaskService>();
        services.AddScoped<GetTasksService>();
    }
}
