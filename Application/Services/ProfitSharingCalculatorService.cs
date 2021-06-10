using Application.Common.Interfaces;
using Application.Extensions;
using Domain.Entities;

namespace Application.Services
{
    public class ProfitSharingCalculatorService : ICalculatorService
    {
        private int AreaShare;

        private int SalaryShare;

        private int AdmissionShare;

        public decimal CalculateResult(Employee employee)
        {
            AreaShare = employee.CalculateAreaShare();
            SalaryShare = employee.CalculateSalaryShare();
            AdmissionShare = employee.CalculateAdmissionShare();

            return CalculateBonus(employee.GrossWage);
        }

        private decimal CalculateBonus(decimal grossWage) => (((grossWage * AdmissionShare) + (grossWage * AreaShare)) / (grossWage * SalaryShare)) * 12;
    }
}
