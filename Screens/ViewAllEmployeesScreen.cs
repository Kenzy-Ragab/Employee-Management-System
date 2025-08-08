using EmployeeManagementSystem.Model;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class ViewAllEmployeesScreen
    {
        public static void Show(List<EmployeeModel> employees)
        {
            Console.Clear();
            Console.WriteLine("┌──┬──────────────────┬───┬───────────┬──────────┬───────────┬───────┬───────┬─────────────┬───────────────────┬───┐");
            Console.WriteLine("│ID│ Full Name        │Age│ Department│ Position │ WorkSched │Salary │ City  │ Region      │ Street            │Bld│");
            Console.WriteLine("├──┼──────────────────┼───┼───────────┼──────────┼───────────┼───────┼───────┼─────────────┼───────────────────┼───┤");

            foreach (var emp in employees)
            {
                Console.WriteLine($"│{emp.ID.ToString().PadLeft(2)}" +
                                  $"│{emp.FullName.PadRight(18)}" +
                                  $"│{emp.Age.ToString().PadLeft(3)}" +
                                  $"│{emp.Department.ToString().PadRight(11)}" +
                                  $"│{emp.Position.ToString().PadRight(10)}" +
                                  $"│{emp.WorkSchedule.ToString().PadRight(11)}" +
                                  $"│{emp.Salary.ToString().PadLeft(7)}" +
                                  $"│{emp.Address.City.PadRight(7)}" +
                                  $"│{emp.Address.Region.PadRight(13)}" +
                                  $"│{emp.Address.Street.PadRight(19)}" +
                                  $"│{emp.Address.Building.ToString().PadLeft(3)}│");
            }
            Console.WriteLine("└──┴──────────────────┴───┴───────────┴──────────┴───────────┴───────┴───────┴─────────────┴───────────────────┴───┘");
        }                                                                                                                                   
    }                                                                                                                                      
}
