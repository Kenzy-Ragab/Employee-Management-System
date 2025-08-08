using EmployeeManagementSystem.Model;
using System;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeStorageServices
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.txt");
        public static List<EmployeeModel> LoadEmployeesFromFile()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            try
            {
                if (!File.Exists(FilePath))
                    return employees;

                using StreamReader reader = new StreamReader(FilePath);
                string? line ;
                while((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length != 11)
                    {
                        Console.WriteLine($"Error: Invalid data -> {line}");
                        continue;
                    }
                    employees.Add(new EmployeeModel
                    {
                        ID = int.TryParse(parts[0], out var id) ? id : 0,
                        FullName = parts[1],
                        Age = int.TryParse(parts[2], out var age) ? age : 0,
                        Department = Enum.TryParse<EmployeeModel.enDepartment>(parts[3], out var department) ? department : EmployeeModel.enDepartment.UnKnown,
                        Position = Enum.TryParse<EmployeeModel.enPosition>(parts[4], out var position) ? position : EmployeeModel.enPosition.UnKnown,
                        WorkSchedule = Enum.TryParse<EmployeeModel.enWorkSchedule>(parts[5], out var workSechedule) ? workSechedule : EmployeeModel.enWorkSchedule.UnKnown,
                        Salary = int.TryParse(parts[6], out var salary) ? salary : 0,

                        Address = new AddressModel
                        {
                            City = parts[7],
                            Region = parts[8],
                            Street = parts[9],
                            Building = int.TryParse(parts[10], out var building) ? building : 0
                        }
                    });
                    
                }
                Console.WriteLine("\n\nEmployees Loaded From File Successfully!");
            }
            catch(Exception ex) { Console.WriteLine("\n\nError: Loading Employees From File!" + ex.Message); };
            
            return employees;
        }
        public static void SaveEmployeesToFile(List<EmployeeModel> employees)
        {
            try
            {
                using StreamWriter writer = new StreamWriter(FilePath);
                foreach(var employee in employees)
                {
                    var addr = employee.Address ?? new AddressModel();
                    string line = $"{employee.ID}|{employee.FullName}|{employee.Age}|{employee.Department}|{employee.Position}|{employee.WorkSchedule}|{employee.Salary}|{employee.Address.City}|{employee.Address.Region}|{employee.Address.Street}|{employee.Address.Building}";
                    writer.WriteLine(line);
                }
                Console.WriteLine("\n\nEmployees Saved To File Successfully!");
            }
            catch(Exception ex) { Console.WriteLine("\n\nError: Saving Empolyees To File!" + ex.Message); };
        }
    }
}
