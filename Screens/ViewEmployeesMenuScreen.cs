using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Services;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class ViewEmployeesMenuScreen
    {
        public static void Show(EmployeeServices services)
        {
            var employees = services.GetAll();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║         VIEW EMPLOYEES MENU          ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║[1] View All Employess                ║");
                Console.WriteLine("║[2] View Employess By Department      ║");
                Console.WriteLine("║[3] Main Menu                         ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.Write("\n-> Select an option (1-3): ");
                var choice = InputHelper.ReadIntNumberBetween(1, 3).ToString();
                switch (choice)
                {
                    case "1": ViewAllEmployeesScreen.Show(employees); break;
                    case "2": ViewEmployessByDepartmentScreen.Show(employees); break;
                    case "3": MainMenuScreen.Show();break;
                    default: Console.WriteLine("\n\nError: Invalid Choice!"); break;
                }
                Console.WriteLine("Press any key to return to View Employees Menu ...");
                Console.ReadKey();
            }
        }
        
    }
}



