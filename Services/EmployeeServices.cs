using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Model;
using System;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeServices
    {
        private List<EmployeeModel> _employees;
        public EmployeeServices() => _employees = EmployeeStorageServices.LoadEmployeesFromFile();
        public List<EmployeeModel> GetAll() => _employees;

        public void FillEmployeeData(EmployeeModel employee, bool isUpdate = false)
        {
            if(isUpdate)
            {
                Console.WriteLine("\n\n------------------------------------");
                Console.WriteLine("        Current Employee Data         ");
                Console.WriteLine("\n------------------------------------");
                Console.WriteLine($"ID: {employee.ID}" +
                                  $"\nFull Name: {employee.FullName}" +
                                  $"\nAge: {employee.Age}" +
                                  $"\nDepartment: {employee.Department}" +
                                  $"\nPosition: {employee.Position}" +
                                  $"\nWork Schedule: {employee.WorkSchedule}" +
                                  $"\nSalary: {employee.Salary}" +
                                  $"\nCity: {employee.Address.City}" +
                                  $"\nRegion: {employee.Address.Region}" +
                                  $"\nStreet: {employee.Address.Street}" +
                                  $"\nBuilding: {employee.Address.Building}");
                Console.WriteLine("\n------------------------------------");
            }

            //Full Name
            var fullName = InputHelper.ReadString($"-> Enter FullName{(isUpdate? $" (Leave empty to keep \"{employee.FullName}\")" : "")}: ");
            if (!string.IsNullOrWhiteSpace(fullName))
            employee.FullName = fullName;

            //Age
            Console.Write($"-> Enter Age{(isUpdate? $" (Leave empty to keep \"{employee.Age}\")" : "")}: ");
            var age = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(age) && int.TryParse(age,out int ageOutput))
                employee.Age = ageOutput;

            //Department
            Console.WriteLine($"\n-> Enter Department:\n   [1] HR\n   [2] IT\n   [3] Finance\n   [4] Marketing\n   [5] Sales\n   [6] Manager\n   [7] Operations\n   [8] CustomerService\n   [9] RD\n   [10] Logistics");
            var departInput = InputHelper.ReadOptionalEnumBetween<EmployeeModel.enDepartment>(1, 10, $"{(isUpdate ? $" (Leave empty to keep \"{employee.Department}\")" : "")}: ");
            if(departInput.HasValue)
                employee.Department = departInput.Value;

            //Position
            Console.WriteLine($"\n-> Enter Position:\n   [1] Employee\n   [2] Manager");
            var positionInput = InputHelper.ReadOptionalEnumBetween<EmployeeModel.enPosition>(1, 2, $"{(isUpdate ? $" (Leave empty to keep \"{employee.Position}\")" : "")}: ");
            if (positionInput.HasValue)
                employee.Position = positionInput.Value;

            //Work Schedule
            Console.WriteLine($"\n-> Enter Work Schedule:\n   [1] Full Time\n   [2] Part Time");
            var scheduleInpuit = InputHelper.ReadOptionalEnumBetween<EmployeeModel.enWorkSchedule>(1, 2, $"{(isUpdate ? $" (Leave empty to keep \"{employee.WorkSchedule}\")" : "")}: ");
            if (scheduleInpuit.HasValue)
                employee.WorkSchedule = scheduleInpuit.Value;

            //Salary
            Console.Write($"\n-> Enter Salary{(isUpdate? $" (Leave empty to keep \"{employee.Salary}\")" : "")}: ");
            var salary = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(salary) && int.TryParse(salary, out var salaryOutput))
                employee.Salary = salaryOutput;

            //City
            var city = InputHelper.ReadString($"-> Enter City{(isUpdate? $" (Leave empty to keep \"{employee.Address.City}\")" : "")}: ");
            if (!string.IsNullOrWhiteSpace(city))
                employee.Address.City = city;

            //Region 
            var region = InputHelper.ReadString($"-> Enter Region{(isUpdate? $" (Leave empty to keep \"{employee.Address.Region}\")" : "")}: ");
            if (!string.IsNullOrWhiteSpace(region))
                employee.Address.Region = region;

            //Street
            var street = InputHelper.ReadString($"-> Enter Street{(isUpdate? $" (Leave empty to keep \"{employee.Address.Street}\")" : "")}: ");
            if(!string.IsNullOrWhiteSpace(street))
                employee.Address.Street = street;

            //Building
            Console.Write($"-> Enter Building{(isUpdate? $" (Leave empty to keep \"{employee.Address.Building}\")" : "")}: ");
            var building = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(building) && int.TryParse(building, out var buildingOutput))
                employee.Address.Building = buildingOutput;
        }
        public void Add(EmployeeModel employee) => _employees.Add(employee);
        public void Update(EmployeeModel updateEmployee)
        {
            var employee = _employees.FirstOrDefault(t => t.ID == updateEmployee.ID);
            if (employee != null)
            {
                employee.ID = updateEmployee.ID;
                employee.FullName = updateEmployee.FullName;
                employee.Age = updateEmployee.Age;
                employee.Department = updateEmployee.Department;
                employee.Position = updateEmployee.Position;
                employee.WorkSchedule = updateEmployee.WorkSchedule;
                employee.Salary = updateEmployee.Salary;

                if (employee.Address != null)
                {
                    employee.Address.City = updateEmployee.Address.City;
                    employee.Address.Region = updateEmployee.Address.Region;
                    employee.Address.Street = updateEmployee.Address.Street;
                    employee.Address.Building = updateEmployee.Address.Building;
                }
            }
        }
        public void Delete(int id)
        {
            var employee = _employees.FirstOrDefault(t => t.ID == id);
            if (employee != null)
                _employees.Remove(employee);
        }

        public EmployeeModel? GetByID(int id) => _employees.FirstOrDefault(t => t.ID == id);
        public int GetNextID() => _employees.Count == 0 ? 1 : _employees.Max(t => t.ID) + 1;
    }
}
