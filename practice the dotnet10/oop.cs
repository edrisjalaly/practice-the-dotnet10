using System;
using System.Collections.Generic;
using System.Text;

namespace practice_the_dotnet10
{
    public static class oop
    {
        public class Employee
        {

        }

        public static void classDeclaration()
        {
            Employee employee = new Employee();
        }

        public class Person()
        {
            public string name = string.Empty;
            private string _ssn = string.Empty;
        }

        public static void FeildsDemo()
        {
            Person person = new();
            person.name = "John Doe";
            Console.WriteLine($"person name {person.name}");
        }
    }
}