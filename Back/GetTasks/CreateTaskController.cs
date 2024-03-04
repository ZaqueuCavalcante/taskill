namespace Taskill.Back.GetTasks;

[ApiController]
public class GetTasksController(GetTasksService service) : ControllerBase
{
    [HttpGet("tasks")]
    public async Task<IActionResult> Get()
    {
        var tasks = await service.Get();

        return Ok(tasks);
    }
}
