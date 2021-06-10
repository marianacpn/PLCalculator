using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface ICalculatorService
    {
        decimal CalculateResult(Employee employee);
    }
}
