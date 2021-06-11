using Application.Employees.Queries.GetProfitSharingCalculation;
using Application.Employees.Queries.NewFolder;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLCalculatorDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController
    {
        // GET: api/<EmployeesController>
        [HttpGet("{value}")]
        public async Task<ProfitSharingVm> Get(int value)
        {
            return await Mediator.Send(new GetProfitSharingCalculationQuery(value));
        }
    }
}
