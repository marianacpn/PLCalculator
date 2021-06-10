using Domain.Entities;
using Shared.Constants;
using System;

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

            //if (workingYears > 1 && workingYears < 3)
            //    return 2;
            //if (workingYears > 3 && workingYears < 8)
            //    return 3;
            //if (workingYears > 8)
            //    return 5;

            //return 1;
        }

        public static int CalculateSalaryShare(this Employee employee)
        {
            return (employee.GrossWage, employee.Area) switch
            {
                (var wage, var y) when wage > 8 * SystemConst.MinimumWage => 5,
                (var wage, var y) when wage > 5 * SystemConst.MinimumWage && wage < 8 * SystemConst.MinimumWage => 3,
                (var wage, var y) when wage > 3 * SystemConst.MinimumWage && wage < 5 * SystemConst.MinimumWage => 2,
                _ => 1,
            };

            //if (employee.GrossWage > 8 * SystemConst.MinimumWage)
            //    return 5;
            //if (employee.GrossWage > 5 * SystemConst.MinimumWage && employee.GrossWage < 8 * SystemConst.MinimumWage)
            //    return 3;
            //if (employee.GrossWage > 3 * SystemConst.MinimumWage && employee.GrossWage < 5 * SystemConst.MinimumWage)
            //    return 2;

            //return 1;
        }

        public static int CalculateAreaShare(this Employee employee)
        {
            return employee.Area switch
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
