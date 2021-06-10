using Application.Extensions;
using Application.UnitTests.ClassDatas;
using Domain.Entities;
using FluentAssertions;
using Shared.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Application.UnitTests.Extensions
{
    public class EmployeeExtensionTests
    {
        //TODO:dar nome
        [Theory(DisplayName = "")]
        [Trait("Application", "EmployeeExtension")]
        [ClassData(typeof(EmployeeDataForAreaShare))]  
        public void CalculateAreaShare_ValidData_ShouldReturnExpectedValue(Employee employee, int expectedResult)
        {
            // Arrange & Act
            var result = employee.CalculateAreaShare();

            // Assert
            result.Should().Be(expectedResult);
        }

        //TODO:dar nome
        [Fact()]
        [Trait("Application", "EmployeeExtension")]
        public void CalculateAreaShare_InvalidData_ShouldThrowException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee("teste", "1111", "teste", SystemConst.MinimumWage, DateTime.Now).CalculateAreaShare());
        }

        //TODO:dar nome
        [Theory(DisplayName = "")]
        [Trait("Application", "EmployeeExtension")]
        [ClassData(typeof(EmployeeDataForSalaryShare))]
        public void CalculateSalaryShare_ValidData_ShouldReturnExpectedValue(Employee employee, int expectedResult)
        {
            // Arrange & Act
            var result = employee.CalculateSalaryShare();

            // Assert
            result.Should().Be(expectedResult);
        }


        [Theory(DisplayName = "")]
        [Trait("Application", "EmployeeExtension")]
        [ClassData(typeof(EmployeeDataForAdmissionShare))]
        public void CalculateAdmissionShare_ValidData_ShouldReturnExpectedValue(Employee employee, int expectedResult)
        {
            // Arrange & Act
            var result = employee.CalculateAdmissionShare();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
