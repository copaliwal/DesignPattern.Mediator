using DesignPattern_Mediator.EmployeeMediator.Models;
using MediatR;

namespace DesignPattern_Mediator.EmployeeMediator.GetEmployeeById
{
    public class GetEmployeeByIdCommand : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
