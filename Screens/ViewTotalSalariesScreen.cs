using EmployeeManagementSystem.Model;
using System;

namespace EmployeeManagementSystem.Screens
{
    public static class ViewTotalSalariesScreen
    {
        public static void Show(List<EmployeeModel> employees)
        {
            Console.Clear();
            Console.WriteLine("┌───────────────────────────────────┐");
            Console.WriteLine("│         TOTAL SALARY SCREEN       │ ");
            Console.WriteLine("├───────────────────────────────────┤");
            var totalSalary = 0;
            foreach(var employee in employees)
            {
                totalSalary += employee.Salary;
            }
            var salaryText = totalSalary.ToString();
            var totalWidth = 33;
            var padding = (totalWidth - salaryText.Length) / 2;
            Console.WriteLine($"|{ salaryText.PadLeft(padding + salaryText.Length).PadRight(totalWidth)}  |");
            Console.WriteLine("└───────────────────────────────────┘");
        }
    }
}
