using Application.Common.Interfaces;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new System.NotImplementedException();
        }
    }
}
