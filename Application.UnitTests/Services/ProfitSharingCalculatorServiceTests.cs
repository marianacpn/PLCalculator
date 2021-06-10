using Application.Services;
using Domain.Entities;
using FluentAssertions;
using Shared.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Application.UnitTests.Services
{
    public class ProfitSharingCalculatorServiceTests
    {
        private readonly ProfitSharingCalculatorService _stu;

        public ProfitSharingCalculatorServiceTests()
        {
            _stu = new ProfitSharingCalculatorService();
        }

        //TODO:dar nome
        [Fact()]
        [Trait("Shared", "StringExtensions")]
        public void CalculateResult_ShouldReturnProfitSharingValue()
        {
            // Arrange
            Employee employee = new Employee("Flossie Wilson", "0004468", "Diretoria", SystemConst.MinimumWage, DateTime.Now);

            // Act
            var result = _stu.CalculateResult(employee);

            // Assert
            result.Should().Be(24);
        }
    }
}
