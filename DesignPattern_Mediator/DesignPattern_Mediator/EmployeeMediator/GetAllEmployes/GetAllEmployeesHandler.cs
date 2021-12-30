using DesignPattern_Mediator.EmployeeMediator.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern_Mediator.EmployeeMediator.GetAllEmployes
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesCommand, List<Employee>>
    {
        public Task<List<Employee>> Handle(GetAllEmployeesCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(EmployeeRepository.GetAll());
        }
    }
}
