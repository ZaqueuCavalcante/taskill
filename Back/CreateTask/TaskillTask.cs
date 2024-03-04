namespace Taskill.Back.CreateTask;

public class TaskillTask
{
    public Guid Id { get; }
    public string Title { get; set; }

    public TaskillTask(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
    }

    public TaskOut ToOut()
    {
        return new TaskOut
        {
            Id = Id,
            Title = Title,
        };
    }
}
