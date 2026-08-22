using System;
using System.Collections.Generic;
using System.Text;

namespace practice_the_dotnet10
{
    public static class oop
    {
        public class Employee{}
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



        class Bus()
        {
            private string _name = "nb-1";

            public string Name
            {
                get { return _name; }
                set { _name = string.IsNullOrWhiteSpace(value) ? _name : value; }
            }

            public string Operator { get; set; } = string.Empty;
            public int Capacity { get; init; } = 50;
            public string Manaufacturer { get; } = "National bus Company";
        }
        public static void PerpertiesDemo()
        {
            Bus bus = new();
            Console.WriteLine($"default name {bus.Name}");
            Console.WriteLine($"--------------------");

            bus.Name = "bs-15";
            bus.Operator = "jan well";

            Console.WriteLine($"New Name : {bus.Name}");
            Console.WriteLine($"Operator : {bus.Operator}");
            Console.WriteLine($"Capacity : {bus.Capacity}");
            Console.WriteLine($"Capacity : {bus.Manaufacturer}");
        }



    }
}