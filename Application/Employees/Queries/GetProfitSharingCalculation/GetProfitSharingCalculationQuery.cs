using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Employees.Queries.NewFolder
{
    public class GetProfitSharingCalculationQuery : IRequest<ProfitSharingVm>
    {
        public GetProfitSharingCalculationQuery(decimal total)
        {
            Total = total;
        }

        public decimal Total { get; }

        public class Handler : IRequestHandler<GetProfitSharingCalculationQuery, ProfitSharingVm>
        {
            private readonly IEmployeeRepository employeeRepository;
            private readonly ICalculatorService calculatorService;

            public Handler(IEmployeeRepository employeeRepository, ICalculatorService calculatorService)
            {
                this.employeeRepository = employeeRepository;
                this.calculatorService = calculatorService;
            }

            public async Task<ProfitSharingVm> Handle(GetProfitSharingCalculationQuery request, CancellationToken cancellationToken)
            {
                IEnumerable<Employee> employees = await employeeRepository.GetEmployees();

                List<ParticipantsDto> participantes = employees.Select(employee => new ParticipantsDto(employee.Registration, employee.Name, calculatorService.CalculateResult(employee)))
                                                               .ToList();

                return new ProfitSharingVm(request.Total, participantes);
            }
        }
    }
}
