namespace Taskill.Back.CreateTask;

public class CreateTaskService(TaskillDbContext ctx)
{
    public async Task<TaskOut> Create(CreateTaskIn data)
    {
        var task = new TaskillTask(data.Title);
        ctx.Add(task);
        await ctx.SaveChangesAsync();

        return task.ToOut();
    }
}
