using DesignPattern_Mediator.EmployeeMediator.AddEmployee;
using DesignPattern_Mediator.EmployeeMediator.GetAllEmployes;
using DesignPattern_Mediator.EmployeeMediator.GetEmployeeById;
using DesignPattern_Mediator.EmployeeMediator.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPattern_Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _mediator.Send(new GetAllEmployeesCommand());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await _mediator.Send(new GetEmployeeByIdCommand() { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Employee newEmp)
        {
            var result = await _mediator.Send(new AddEmployeeCommand() { NewEmployee = newEmp });
            return Ok(result);
        }
    }
}
