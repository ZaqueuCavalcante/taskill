namespace Taskill.Back.CreateTask;

[ApiController]
public class CreateTaskController(CreateTaskService service) : ControllerBase
{
    [HttpPost("tasks")]
    public async Task<IActionResult> Create([FromBody] CreateTaskIn data)
    {
        var task = await service.Create(data);

        return Ok(task);
    }
}
