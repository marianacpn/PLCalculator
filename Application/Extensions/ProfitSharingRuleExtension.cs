using Shared.Constants;
using System;

namespace Application.Extensions
{
    public static class ProfitSharingRuleExtension
    {
        public static int CalculateAdmissionShare(this int admissionDate)
        {
            int workingYears = DateTime.Now.Year - admissionDate;

            if (workingYears > 1 && workingYears < 3)
                return 2;
            if (workingYears > 3 && workingYears < 8)
                return 3;
            if (workingYears > 8)
                return 5;

            return 1;
        }

        public static int CalculateSalaryShare(this long salaryRange)
        {
            if (salaryRange > 8 * SystemConst.MinimumWage)
                return 5;
            if (salaryRange > 5 * SystemConst.MinimumWage && salaryRange < 8 * SystemConst.MinimumWage)
                return 3;
            if (salaryRange > 3 * SystemConst.MinimumWage && salaryRange < 5 * SystemConst.MinimumWage)
                return 2;

            return 1;
        }

        public static int CalculateAreaShare(string area)
        {
            return area switch
            {
                "Diretoria" => 1,
                "Contabilidade" => 2,
                "Financeiro" => 2,
                "Tecnologia" => 2,
                "Serviços Gerais" => 3,
                _ => 5,
            };
        }
    }
}
