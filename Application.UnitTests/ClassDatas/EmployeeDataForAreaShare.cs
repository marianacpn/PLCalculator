using Domain.Entities;
using Shared.Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Application.UnitTests.ClassDatas
{
    public class EmployeeDataForAreaShare : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Employee("Teste", "11111", "Diretoria", SystemConst.MinimumWage, DateTime.Now), 1
            };
            yield return new object[]
            {
                new Employee("Teste", "11111", "diretoria", SystemConst.MinimumWage, DateTime.Now), 1
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Contabilidade", SystemConst.MinimumWage, DateTime.Now), 2
            };
            yield return new object[]
            {
                new Employee("Teste", "11111", "contabilidade", SystemConst.MinimumWage, DateTime.Now), 2
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Financeiro", SystemConst.MinimumWage, DateTime.Now), 2
            };
            yield return new object[]
            {
                new Employee("Teste", "11111", "financeiro", SystemConst.MinimumWage, DateTime.Now), 2
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Tecnologia", SystemConst.MinimumWage, DateTime.Now), 2
            };
            yield return new object[]
            {
                new Employee("Teste", "11111", "tecnologia", SystemConst.MinimumWage, DateTime.Now), 2
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Serviços Gerais", SystemConst.MinimumWage, DateTime.Now), 3
            };
            yield return new object[]
            {
                new Employee("Teste", "11111", "serviços gerais", SystemConst.MinimumWage, DateTime.Now), 3
            };

            yield return new object[]
            {
                new Employee("Teste", "11111", "Relacionamento com o Cliente", SystemConst.MinimumWage, DateTime.Now), 5
            };
            yield return new object[]
            {
                new Employee("Teste", "11111", "relacionamento com o cliente", SystemConst.MinimumWage, DateTime.Now), 5
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
