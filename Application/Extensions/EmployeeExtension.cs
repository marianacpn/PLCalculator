using Domain.Entities;
using Shared.Constants;
using System;
using Shared.Extensions;

namespace Application.Extensions
{
    public static class EmployeeExtension
    {
        public static int CalculateAdmissionShare(this Employee employee)
        {
            int workingYears = DateTime.Now.Year - employee.AdmissionDate.Year;

            return workingYears switch
            {
                var years when years > 1 && years < 3 => 2,
                var years when years > 3 && years < 8 => 3,
                var years when years > 8 => 5,
                _ => 1,
            };
        }

        public static int CalculateSalaryShare(this Employee employee)
        {
            return employee.GrossWage switch
            {
                var wage when wage > 8 * SystemConst.MinimumWage => 5,
                var wage when wage > 5 * SystemConst.MinimumWage && wage < 8 * SystemConst.MinimumWage => 3,
                var wage when wage > 3 * SystemConst.MinimumWage && wage < 5 * SystemConst.MinimumWage => 2,
                _ => 1,
            };
        }

        public static int CalculateAreaShare(this Employee employee)
        {
            return employee.Area.Normalize(StringFormatType.lower, true) switch
            {
                "diretoria" => 1,
                "contabilidade" => 2,
                "financeiro" => 2,
                "tecnologia" => 2,
                "servicosgerais" => 3,
                "relacionamentocomocliente" => 5,
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
