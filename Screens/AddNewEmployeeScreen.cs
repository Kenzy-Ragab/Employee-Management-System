using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Services;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class AddNewEmployeeScreen
    {
        public static void Show(EmployeeServices services)
        {
            Console.Clear();
            Console.WriteLine("┌───────────────────────────────────┐");
            Console.WriteLine("│      ADD NEW EMPLOYEE SCREEN      │");
            Console.WriteLine("└───────────────────────────────────┘");
            var employee = new EmployeeModel();
            employee.Address = new AddressModel();

            employee.ID = services.GetNextID();
            services.FillEmployeeData(employee,false);

            //adding
            services.Add(employee);
            EmployeeStorageServices.SaveEmployeesToFile(services.GetAll());
            Console.WriteLine($"\n\nEmployee Added Successfully!, Employee ID: {employee.ID}");
        }
    }
}
