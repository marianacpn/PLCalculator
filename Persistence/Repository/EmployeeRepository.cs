using Application.Common.Interfaces;
using Domain.Entities;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Extensions.Options;
using Persistence.Repository.Dto;
using Shared.Configurations;
using Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Persistence.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FirebaseConfiguration _dbConnection;
        private readonly IFirebaseConfig _firebaseConfig;
        private readonly IFirebaseClient _firebaseClient;

        public EmployeeRepository(IOptionsSnapshot<FirebaseConfiguration> options)
        {
            _dbConnection = options.Value;

            _firebaseConfig = new FirebaseConfig
            {
                BasePath = _dbConnection.BasePath
            };

            _firebaseClient = new FirebaseClient(_firebaseConfig);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            FirebaseResponse response = await _firebaseClient.GetAsync(SystemConst.EmployeeChild);

            IEnumerable<Employee> employees = response.ResultAs<IEnumerable<EmployeeDto>>()
                                                      .Select(e => new Employee(e.nome,
                                                                                e.matricula,
                                                                                e.area,
                                                                                Convert.ToDecimal(e.salario_bruto),
                                                                                DateTime.Parse(e.data_de_admissao)));
            return employees;
        }
    }
}
