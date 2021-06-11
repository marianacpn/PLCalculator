using Application.Common.Interfaces;
using Domain.Entities;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Microsoft.Extensions.Options;
using Shared.Configurations;
using System.Collections.Generic;
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

        public Task<IEnumerable<Employee>> GetEmployees()
        {

            throw new System.NotImplementedException();
        }
    }
}
