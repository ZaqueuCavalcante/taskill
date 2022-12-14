using Task = Taskill.Domain.Task;

namespace Taskill.Extensions;

public static class ProjectExtensions
{
    public const string DefaultProjectName = "Inbox";

    public static List<Task> MoveTask(this List<Task> tasks, int startIndex, int endIndex)
    {
        if (endIndex == startIndex || tasks.Count == 1) return tasks;

        tasks = tasks.OrderBy(t => t.Index).ToList();

        var task = tasks[startIndex];
        task.SetIndex(endIndex);
        tasks.RemoveAt(startIndex);
        tasks.Insert(endIndex, task);

        for (int i = 0; i < tasks.Count; i++)
        {
            tasks[i].SetIndex(i);
        }

        return tasks.OrderBy(t => t.Index).ToList();
    }
}
