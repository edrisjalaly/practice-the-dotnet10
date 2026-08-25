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



        class CloudProvider()
        {
            public void Saas(string config)
            {
                Console.WriteLine($"SaaS (Software as a Service) provides software applications over the internet {config}");
                Paas(config);
            }
            public void Paas(string config)
            {
                Console.WriteLine($"PaaS (Platform as a Service) provides a platform for developers to build, deploy {config}");
                IaaS(config);
            }
            public void IaaS(string config)
            {
                Console.WriteLine($"IaaS (Infrastructure as a Service) provides virtualized computing resources over the internet {config}");
                ProvideHardware();
            }
            public void ProvideHardware()
            {
                Console.WriteLine("IaaS providers offer virtualized hardware resources such as virtual machines, storage, and networking components");
            }
        }

        public static void MethodsDemo(string config)
        {
            CloudProvider cloudProvider = new();
            cloudProvider.Saas(config);
        }



        
        class Robot
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public Robot()
            {
                Description = "first object";
                Name = string.Empty;
            }

            public Robot(string name, string description)
            {
                Name = name;
                Description = description;
            }
        }
        public static void ConstrucorDemo()
        {
            Robot robot1 = new Robot();
            Robot robot2 = new Robot("khan", "jan");


            Console.WriteLine($"robot1 : {robot1.Name} - {robot1.Description}");
            Console.WriteLine($"robot2 : {robot2.Name} - {robot2.Description}");
        }




        class Phone
        {
            public string Modal {  get; init; }
            public string Color { get; init; }
            public int Capacity { get; set; }


            public Phone() : this ("standard")
            {
            }

            public Phone(string modal) : this(modal, "red")
            {
            }

            public Phone(string modal, string color) : this (modal, color, 64)
            {
            }

            public Phone(string modal, string color, int capacity)
            {
                Modal = modal;
                Color = color;
                Capacity = capacity;
            }
        }
        public static void ConstructorChainingDemo()
        {
            Phone phone = new Phone();            
            Console.WriteLine($"phone1 {phone.Modal} - {phone.Color} - {phone.Capacity}");

            Phone phon2 = new Phone("pro");            
            Console.WriteLine($"phone2 {phon2.Modal} - {phon2.Color} - {phon2.Capacity}");

            Phone phone3 = new Phone("pro", "silver");            
            Console.WriteLine($"phone3 {phone3.Modal} - {phone3.Color} - {phone3.Capacity}");

            Phone phone4 = new Phone("pro", "silver", 512);            
            Console.WriteLine($"phone4 {phone4.Modal} - {phone4.Color} - {phone4.Capacity}");
        }


        public class Employee2(string firstName, string lastName, DateTime hireDate, decimal salary)
        {
            public string FirstName { get; init; } = firstName;
            public string LastName { get; init; } = lastName;
            public DateTime HireDate { get; init; } = hireDate;
            public decimal Salary { get; init; } = salary;
        }

        public static void PrimaryConsrcutorDemo()
        {
            Employee2 emp2 = new("jan", "khan", DateTime.Now, 400);

            Console.WriteLine($" new emp with primary constructor {emp2.FirstName} - {emp2.LastName} - {emp2.HireDate} - {emp2.Salary}");
        }
    }
}