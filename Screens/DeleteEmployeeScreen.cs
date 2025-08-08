using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Services;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class DeleteEmployeeScreen
    {
        public static void Show(EmployeeServices services)
        {
            Console.Clear();
            Console.WriteLine("┌───────────────────────────────────┐");
            Console.WriteLine("│       DELETE EMPLOYEE SCREEN      │");
            Console.WriteLine("└───────────────────────────────────┘");
            var id = InputHelper.ReadInt("-> Enter Employee ID: ");
            var employee = services.GetByID(id);
            if (employee == null)
            {
                Console.WriteLine("\n\nError: Employee Not Found!");
                return;
            }

            var confirmation = InputHelper.ReadString("Are you sure you want to delete this employee? (y/n): ").Trim().ToLower();
            if(confirmation != "y")
            {
                Console.WriteLine("\n\nError: Deletion Cancelled!");
                return;
            }

            services.Delete(id);
            EmployeeStorageServices.SaveEmployeesToFile(services.GetAll());
            Console.WriteLine("\n\nEmployee deleted successfully!");
        }
    }
}
