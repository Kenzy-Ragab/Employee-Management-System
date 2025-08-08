using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Services;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class MainMenuScreen
    {
        public static void Show()
        {
            EmployeeServices services = new EmployeeServices();
            List<EmployeeModel> employees = services.GetAll();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║           MAIN MENU SCREEN           ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║[1] Add New Employee                  ║");
                Console.WriteLine("║[2] View Employess Menu               ║");
                Console.WriteLine("║[3] Update Employee                   ║");
                Console.WriteLine("║[4] Delete Employee                   ║");
                Console.WriteLine("║[5] View Total Salaries               ║");
                Console.WriteLine("║[6] Exit                              ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.Write("\n-> Select an option (1-6): ");
                var choice = InputHelper.ReadIntNumberBetween(1, 6).ToString();

                switch (choice)
                {
                    case "1": AddNewEmployeeScreen.Show(services); break;
                    case "2": ViewEmployeesMenuScreen.Show(services); break;
                    case "3": UpdateEmployeeScreen.Show(services); break;
                    case "4": DeleteEmployeeScreen.Show(services); break; ;
                    case "5": ViewTotalSalariesScreen.Show(employees); break;
                    case "6": Console.WriteLine("\n\nThanks for using Employee Management System!\nKeep Leading, Keep Improving.\nGoodBye."); return;
                    default: Console.WriteLine("\n\nError: Invalid Choice!"); break;
                }
                Console.WriteLine("\n\nPress any key to retrun to Main menu Screen...");
                Console.ReadKey();
            }
        }
    }
}

