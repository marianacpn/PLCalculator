using Application.Common.Interfaces;
using Application.Extensions;
using System;

namespace Application.Services
{
    public class ProfitSharingCalculatorService : IProfitSharingCalculatorService
    {
        public int AreaShare { get; private set; }

        public int SalaryShare { get; private set; }

        public int AdmissionShare { get; private set; }

        public long CalculateProfitSharingBonus(string area, long salaryRange, long salary, DateTime admissionDate)
        {
            AreaShare = ProfitSharingRuleExtension.CalculateAreaShare(area);
            SalaryShare = ProfitSharingRuleExtension.CalculateSalaryShare(salaryRange);
            AdmissionShare = ProfitSharingRuleExtension.CalculateAdmissionShare(admissionDate.Year);

            return CalculateBonus(salary);
        }

        private long CalculateBonus(long salary) => (salary * AdmissionShare + salary * AreaShare / (salary * SalaryShare)) * 12;
    }
}
