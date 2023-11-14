using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "php", "javascript", "python", "java", "kotlin", "c#", "c", "c++", "assembler", "ruby"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public TodoItemController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTodoItem")]
        public IEnumerable<TodoItem> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new TodoItem
            {
                Id = Random.Shared.Next(1, 55),
                Name = Names[Random.Shared.Next(Names.Length)],
                IsComplete = true
            })
            .ToArray();
        }
    }
}