using System;

namespace Domain.Entities
{
    public class Employee
    {
        public Employee(string name, string registration, string area, decimal grossWage, DateTime admissionDate)
        {
            Name = name;
            Registration = registration;
            Area = area;
            GrossWage = grossWage;
            AdmissionDate = admissionDate;
        }

        public string Name { get; }

        public string Registration { get; }

        public string Area { get; }

        public decimal GrossWage { get; }

        public DateTime AdmissionDate { get; }
    }
}
