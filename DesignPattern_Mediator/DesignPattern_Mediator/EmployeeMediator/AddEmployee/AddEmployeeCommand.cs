using DesignPattern_Mediator.EmployeeMediator.Models;
using MediatR;

namespace DesignPattern_Mediator.EmployeeMediator.AddEmployee
{
    public class AddEmployeeCommand : IRequest<Employee>
    {
        public Employee NewEmployee { get; set; }
    }
}
