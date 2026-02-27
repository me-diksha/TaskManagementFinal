using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Model;
using TaskManagementAPI.Services.Implementation;
using TaskManagementAPI.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskservice;
        public TaskController(ITaskService taskservice)
        {
            _taskservice = taskservice;
        }
        [HttpGet("user/{userid}")]
        public IActionResult GetTasks(int userid)
        {
            var tasks = _taskservice.showtask_forUser(userid);
            return Ok(tasks);
        }

        [HttpGet("{userId}/{status}")]
        public IActionResult GetTasksByStatus(int userId, bool status)
        {
            var tasks = _taskservice.gettask_byStatus(userId, status);
            return Ok(tasks);
        }
        [HttpPost]
        public IActionResult AddTask([FromBody] TaskList task)
        {
            _taskservice.AddTask(task);
            return Ok(task);
        }

        // Update task
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] TaskList task)
        {
            if (id != task.TaskId)
                return BadRequest();

            _taskservice.updatetask(task);
            return Ok();
        }

        [HttpDelete("{taskId}/{userId}")]
        public IActionResult DeleteTask(int taskId, int userId)
        {
            _taskservice.deletetask(taskId, userId);
            return Ok();
        }


    }
}
