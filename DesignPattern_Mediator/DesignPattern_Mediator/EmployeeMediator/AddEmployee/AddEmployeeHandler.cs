using DesignPattern_Mediator.EmployeeMediator.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern_Mediator.EmployeeMediator.AddEmployee
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        public Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(EmployeeRepository.Add(request.NewEmployee));
        }
    }
}
