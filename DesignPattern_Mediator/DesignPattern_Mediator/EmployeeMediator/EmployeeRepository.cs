using DesignPattern_Mediator.EmployeeMediator.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern_Mediator.EmployeeMediator
{
    public static class EmployeeRepository
    {
        private static List<Employee> employees;
        static EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "CP", City = "Pune" }
            };
        }

        public static Employee Add(Employee newEmp)
        {
            if (newEmp.Id == 0)
            {
                newEmp.Id = employees.Max(x => x.Id) + 1;
            }
            employees.Add(newEmp);
            return newEmp;
        }

        public static List<Employee> GetAll()
        {
            return employees;
        }

        public static Employee GetById(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }
    }
}
