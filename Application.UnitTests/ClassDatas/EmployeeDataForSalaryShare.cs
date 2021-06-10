using Domain.Entities;
using Shared.Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Application.UnitTests.ClassDatas
{
    public class EmployeeDataForSalaryShare : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage * 9, DateTime.Now), 5
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage * 6, DateTime.Now), 3
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage * 4, DateTime.Now), 2
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage, DateTime.Now), 1
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
