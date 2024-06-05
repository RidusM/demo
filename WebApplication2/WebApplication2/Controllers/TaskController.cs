using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ApiContext _context;
        public TaskController(ApiContext context)
        {
            _context = context;
        }
        [HttpPatch("/staff/{task_id}")]
        public JsonResult AssignStaff(int task_id, int staff_id)
        {
            var taskInDb = _context.Tasks.Find(task_id);
            var staffInDb = _context.Staffs.Find(staff_id);
            if (taskInDb == null) return new JsonResult(NotFound());
            if (staffInDb == null) return new JsonResult(NotFound());
            _context.Entry(taskInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            taskInDb.staff_id = staff_id;
            _context.Update(taskInDb);
            _context.SaveChanges();
            return new JsonResult(Ok(taskInDb));
        }
        [HttpGet("/{status_id}")]
        public JsonResult GetTasksByStatus(int status_id)
        {
            var tasks = _context.Tasks.Where(x => x.status_id == status_id);
            if (tasks == null) return new JsonResult(NotFound());
            return new JsonResult(Ok(tasks));
        }
        [HttpPost]
        public JsonResult CreateNewTask(Tasks task)
        {
            if (task.Id == 0)
            {
                _context.Tasks.Add(task);
            }
            else
            {
                var tasksInDb = _context.Tasks.Find(task.Id);
                if (tasksInDb == null) new JsonResult(NotFound());
                _context.Entry(tasksInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _context.Update(tasksInDb);
            }
            _context.SaveChanges();
            return new JsonResult(Ok(task));
        }
        [HttpPatch]
        public JsonResult UpdateStatus(int task_id, int status_id)
        {
            var tasksInDb = _context.Tasks.Find(task_id);
            var statusInDb = _context.Statuses.Find(status_id);
            if (tasksInDb == null) return new JsonResult(NotFound());
            if (statusInDb == null) return new JsonResult(NotFound());
            _context.Entry(tasksInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            tasksInDb.status_id = status_id;
            _context.Update(tasksInDb);
            _context.SaveChanges();

            return new JsonResult(Ok(tasksInDb));
        }
        [HttpDelete] // 5
        public JsonResult DeleteTask(int id)
        {
            var result = _context.Tasks.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Tasks.Remove(result);
            _context.SaveChanges();

            return new JsonResult(Ok(result));
        }
        [HttpGet("{task_id}")] // 6
        public JsonResult GetTaskById(int task_id)
        {
            var taskInDb = _context.Tasks.Find(task_id);
            if (taskInDb == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(taskInDb));
        }
        [HttpGet("api/GetReport/{start_date}/{end_date}")]
        public JsonResult GetTasksReport(DateTime start_date, DateTime end_date)
        {
            IEnumerable<double> daysToAdd = Enumerable.Range(0,
                                                (end_date - start_date).Days + 1)
                                            .ToList().ConvertAll(d => (double)d);
            IEnumerable<DateTime> ListOfDates = daysToAdd.Select(start_date.AddDays).ToList();
            var tasksToCount = _context.Tasks.Where(x => ListOfDates.Select(x2 => x2.Date).Contains(x.date_time_task.Date));
            var tasks_count = tasksToCount.ToList().Count();
            decimal income = 0;
            foreach (var task in tasksToCount)
            {
                income += task.cost;
            }
            var result = new { tasks_count, income };
            if (tasks_count == 0)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }
        [HttpPost("/login")]
        public JsonResult Loggining(int id, string name)
        {
            var user_id = _context.Staffs.Where(x => x.Id == id && x.Name == name);
            if (user_id is null) return new JsonResult(Unauthorized());
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, name) };
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)), // время действия 2 минуты
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                access_token = encodedJwt,
                username = name
            };
            return new JsonResult(response);
        }
        [HttpPost("/api/Staff")]
        public JsonResult CreateNewStaff(Staffs staff)
        {
            if (staff.Id == 0)
            {
                _context.Staffs.Add(staff);
            }
            else
            {
                var staffsInDb = _context.Staffs.Find(staff.Id);
                if (staffsInDb == null) new JsonResult(NotFound());
                _context.Entry(staffsInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _context.Update(staffsInDb);
            }
            _context.SaveChanges();
            return new JsonResult(Ok(staff));
        }
        [HttpPost("/api/Statuses")]
        public JsonResult CreateNewStatus(Statuses status)
        {
            if (status.Id == 0)
            {
                _context.Statuses.Add(status);
            }
            else
            {
                var staffsInDb = _context.Staffs.Find(status.Id);
                if (staffsInDb == null) new JsonResult(NotFound());
                _context.Entry(staffsInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _context.Update(staffsInDb);
            }
            _context.SaveChanges();
            return new JsonResult(Ok(status));
        }
    }
}
