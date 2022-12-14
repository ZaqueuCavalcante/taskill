using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taskill.Domain;

namespace Taskill.Database;

public class TaskConfig : IEntityTypeConfiguration<Domain.Task>
{
    public void Configure(EntityTypeBuilder<Domain.Task> task)
    {
        task.ToTable("tasks");

        task.HasKey(t => t.Id);
        task.Property(t => t.Id).ValueGeneratedOnAdd();

        task.Property(t => t.UserId).IsRequired();
        task.Property(t => t.ProjectId).IsRequired();

        task.Property(t => t.Title).IsRequired();

        task.HasMany(t => t.Labels)
            .WithMany(l => l.Tasks)
            .UsingEntity<Dictionary<string, object>>(
                joinEntityName: "TasksLabels",
                configureRight: b => b.HasOne<Label>().WithMany().HasForeignKey("LabelId"),
                configureLeft: b => b.HasOne<Domain.Task>().WithMany().HasForeignKey("TaskId"));

        task.HasIndex(t => new { t.Title, t.Description })
            .HasMethod("GIN")
            .IsTsVectorExpressionIndex("portuguese");
    }
}
