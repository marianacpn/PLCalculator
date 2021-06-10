using Domain.Entities;
using Shared.Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Application.UnitTests.ClassDatas
{
    public class EmployeeDataForAdmissionShare : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage, DateTime.Now), 1
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage, DateTime.Now.AddYears(-2)), 2
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage, DateTime.Now.AddYears(-4)), 3
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage, DateTime.Now.AddYears(-9)), 5
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
