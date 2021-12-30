using DesignPattern_Mediator.EmployeeMediator.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern_Mediator.EmployeeMediator.GetEmployeeById
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdCommand, Employee>
    {
        public Task<Employee> Handle(GetEmployeeByIdCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(EmployeeRepository.GetById(request.Id));
        }
    }
}
