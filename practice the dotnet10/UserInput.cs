using System;

namespace Examples
{
    public static class UserInput
    {
        public static void ReadUserAndPassword()
        {
            Console.Write("Enter user name: ");
            var userName = Console.ReadLine();

            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            Console.WriteLine($"User name: {userName}, Password: {password}");
        }
    }
}