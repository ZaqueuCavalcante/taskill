namespace Taskill.Back.CreateTask;

public class TaskillTaskConfig : IEntityTypeConfiguration<TaskillTask>
{
    public void Configure(EntityTypeBuilder<TaskillTask> task)
    {
        task.ToTable("tasks");

        task.HasKey(t => t.Id);
        task.Property(t => t.Id).ValueGeneratedNever();
    }
}
