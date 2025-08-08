using System;

namespace EmployeeManagementSystem.Model
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string FullName {  get; set; }
        public int Age { get; set; }
        public enum enDepartment {  HR = 1, IT = 2, Finance = 3, Marketing = 4, Sales = 5, Operations = 6, CustomerService = 7,  RD = 8, Logistics = 9, UnKnown = 10  }
        public enDepartment Department { get; set; }
        public enum enPosition { Employee = 1, Manager = 2, UnKnown = 4 }
        public enPosition Position { get; set; }
        public enum enWorkSchedule { FullTime = 1, PartTime = 2 , UnKnown = 3}
        public enWorkSchedule WorkSchedule { get; set; }
        public int Salary { get; set; }
        public AddressModel Address { get; set; }
    }
}
