namespace Taskill.Back.GetTasks;

public class GetTasksService(TaskillDbContext ctx)
{
    public async Task<List<TaskOut>> Get()
    {
        var tasks = await ctx.Tasks.ToListAsync();

        return tasks.ConvertAll(t => t.ToOut());
    }
}
