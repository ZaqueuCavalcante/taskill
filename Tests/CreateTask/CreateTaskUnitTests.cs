using Taskill.Back.CreateTask;

namespace Taskill.Tests.Unit;

public class CreateTaskUnitTests
{
    [Test]
    public void Should_create_task()
    {
        // Arrange
        const string title = "Finish this app";

        // Act
        var task = new TaskillTask(title);

        // Assert
        task.Id.Should().NotBeEmpty();
        task.Title.Should().Be(title);
    }
}
