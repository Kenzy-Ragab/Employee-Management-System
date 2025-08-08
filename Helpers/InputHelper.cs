using System;

namespace EmployeeManagementSystem.Helpers
{
    public static class InputHelper
    {
        public static bool IsNumberBetween(int num, int from, int to)
        {
            return !(num < from || num > to);
        }
        public static  int ReadInt(string prompotMessage = "", string invalidInputMessage = "Invalid Number, Enter again:\n")
        {
            Console.Write(prompotMessage);

            int Num = 0;
            while (!int.TryParse(Console.ReadLine(), out Num))
                Console.WriteLine(invalidInputMessage);

            return Num;
        }
        public static  int ReadIntNumberBetween(int from, int to, string outOfRangeMessage = "Number is not within range, enter again:\n")
        {
            int Num = ReadInt();
            while (!IsNumberBetween(Num, from, to))
            {
                Console.WriteLine(outOfRangeMessage);
                Num = ReadInt();
            }
            return Num;
        }
        public static int? ReadOptionalIntBetween(int from, int to,string prompotMessage = "")
        {
            while(true)
            {
                Console.WriteLine(prompotMessage);
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    return null;

                if(int.TryParse(input, out var result) && result >= from && result <= to)
                    return result;

                Console.WriteLine($"Invalid input. Please enter a number between {from} and {to}, or leave empty to skip.");
            }
        }

        public static TEnum? ReadOptionalEnumBetween<TEnum>(int from, int to, string prompotMessage = "")
          where TEnum : struct, Enum
        {
           while(true)
           {
                Console.WriteLine(prompotMessage);
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    return null;

                if(int.TryParse(input, out var result))
                {
                    if (result >= from && result <= to && Enum.IsDefined(typeof(TEnum), result))
                        return (TEnum)(object)result;
                }

                Console.WriteLine($"Invalid input, Enter a number between {from} and {to}, or leave empty to skip.");
           }
        }

        public static DateTime ReadDate(string message = "")
        {
            Console.Write(message);
            DateTime result;
            while (!DateTime.TryParse(Console.ReadLine(), out result))
                Console.Write("Invalid date, try again: ");
            return result;
        }

        public static string ReadString(string prompotMessage = "", string InvalidInputMessage = "Invalid String, Enter again:\n")
        {
            Console.Write(prompotMessage);
            string? input = Console.ReadLine();

            while (int.TryParse(input, out _))
            {
                Console.WriteLine(InvalidInputMessage);
                Console.Write(prompotMessage);
                input = Console.ReadLine();
            }
            return input ?? "";
        }

    }
}
