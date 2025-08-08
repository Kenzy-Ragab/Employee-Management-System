using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Services;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class ViewEmployessByDepartmentScreen
    {
        public static void Show(List<EmployeeModel> employees)
        {
            EmployeeServices services = new EmployeeServices();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║          DEPARTMENTS MENU            ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║[1] HR                                ║");
                Console.WriteLine("║[2] IT                                ║");
                Console.WriteLine("║[3] Finance                           ║");
                Console.WriteLine("║[4] Marketing                         ║");
                Console.WriteLine("║[5] Sales                             ║");
                Console.WriteLine("║[6] Operations                        ║");
                Console.WriteLine("║[7] Customer Service                  ║");
                Console.WriteLine("║[8] R&D                               ║");
                Console.WriteLine("║[9] Logistics                         ║");
                Console.WriteLine("║[10] View Employee Menu               ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.WriteLine("-> Select an option (1-10): ");
                var choice = InputHelper.ReadIntNumberBetween(1, 10).ToString();

                switch (choice)
                {
                    case "1": ShowByDepartment(employees, EmployeeModel.enDepartment.HR); break;
                    case "2": ShowByDepartment(employees, EmployeeModel.enDepartment.IT); break;
                    case "3": ShowByDepartment(employees, EmployeeModel.enDepartment.Finance); break;
                    case "4": ShowByDepartment(employees, EmployeeModel.enDepartment.Marketing); break;
                    case "5": ShowByDepartment(employees, EmployeeModel.enDepartment.Sales); break;
                    case "6": ShowByDepartment(employees, EmployeeModel.enDepartment.Operations); break;
                    case "7": ShowByDepartment(employees, EmployeeModel.enDepartment.CustomerService); break;
                    case "8": ShowByDepartment(employees, EmployeeModel.enDepartment.RD); break;
                    case "9": ShowByDepartment(employees, EmployeeModel.enDepartment.Logistics); break;
                    case "10": ViewEmployeesMenuScreen.Show(services); break;
                    default: Console.WriteLine("\n\nError: Invalid Choice!"); break;
                }
                Console.WriteLine("Press any key to return to Department Menu Screen...");
                Console.ReadKey();
            }
        }

        public static void ShowByDepartment(List<EmployeeModel> employees, EmployeeModel.enDepartment Department)
        {
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine($"│                       DEPARTMENT: {Department.ToString().PadRight(33)}│");
            Console.WriteLine("├────┬────────────────────┬──────────────┬────────────────┬──────────┤");
            Console.WriteLine("│ ID │ Full Name          │ Position     │ Work Schedule  │  Salary  │");
            Console.WriteLine("├────┼────────────────────┼──────────────┼────────────────┼──────────┤");

            foreach (var employee in employees)
            {
                if (employee.Department == Department)
                {
                    Console.WriteLine($"|{employee.ID.ToString().PadLeft(4)}" +
                                      $"|{employee.FullName.ToString().PadLeft(20)}" +
                                      $"|{employee.Position.ToString().PadLeft(14)}" +
                                      $"|{employee.WorkSchedule.ToString().PadLeft(16)}" +
                                      $"|{employee.Salary.ToString().PadLeft(10)}|");
                }
            }
            Console.WriteLine("└────┴────────────────────┴──────────────┴────────────────┴──────────┘");
        }
    }
}


