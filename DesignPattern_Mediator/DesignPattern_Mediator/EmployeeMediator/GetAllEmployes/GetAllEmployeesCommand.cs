using DesignPattern_Mediator.EmployeeMediator.Models;
using MediatR;
using System.Collections.Generic;

namespace DesignPattern_Mediator.EmployeeMediator.GetAllEmployes
{
    public class GetAllEmployeesCommand : IRequest<List<Employee>>
    {
    }
}
