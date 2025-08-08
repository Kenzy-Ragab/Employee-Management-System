using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Services;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class UpdateEmployeeScreen
    {
        public static void Show(EmployeeServices services)
        {
            Console.Clear();
            Console.WriteLine("┌───────────────────────────────────┐");
            Console.WriteLine("│       UPDATE EMPLOYEE SCREEN      │");
            Console.WriteLine("└───────────────────────────────────┘");
            var id = InputHelper.ReadInt("-> Enter Employee ID: ");
            var employee = services.GetByID(id);
            if(employee == null )
            {
                Console.WriteLine("\n\nError: Employee Not Found!");
                return;
            }

            var confirmation = InputHelper.ReadString("Are you sure you want to update this employee? (y/n): ").Trim().ToLower();
            if (confirmation != "y")
            {
                Console.WriteLine("\n\nError: Update Cancelled!");
                return;
            }

            var updateEmployee = new EmployeeModel();
            updateEmployee.Address = new AddressModel();

            updateEmployee.ID = id;
            services.FillEmployeeData(updateEmployee, true);

            //updating
            services.Update(updateEmployee);
            EmployeeStorageServices.SaveEmployeesToFile(services.GetAll());
            Console.WriteLine("\n\nEmployee updated successfully!");
        }
    }
}
