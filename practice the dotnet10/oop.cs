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



        class ExpressionBodiedmembers()
        {

        }



        class SomeClass
        {
            public SomeClass() => SomeProperty = "Default Value";
            private string _someField = string.Empty;

            public string SomeProperty
            {
                get => _someField;
                set => _someField = value;
            }

            public string SomeReadOnlyProperty => "Defauly ReadOnly value";
            public string SomeMethod(string someParman) => $"Properties: {_someField} : {someParman}";

        }
        public static void ExpressionBodiesMembersDemo()
        {
            SomeClass some = new();
            Console.WriteLine(some.SomeMethod("khan"));
        }




        class Teacher
        {
            public Teacher() => Name = "khan";

            public string Name
            {
                get;
                set => field = string.IsNullOrWhiteSpace(value) ? field : value;
            }
        }
        public static void FeildBackProprty()
        {
            Teacher teacher = new();
            Console.WriteLine(teacher.Name);
            teacher.Name = "jano";
            Console.WriteLine(teacher.Name);
        }



        class Product()
        {
            public required string title {  get; set; }
            public required int price { get; set; }

            public string category { get; set; } = "Default";
        }
        public static void RequiredDemo()
        {
            Product product = new()
            {
                title = "book",
                price = 100,
                category = "new"
            };

            Console.WriteLine($"this is the object {product.title} : {product.price} : {product.category}");
        }



        static class ConsoleLogger
        {
            public static void LogInfo(string message) => Console.WriteLine($"[info] {message}");
            public static void LogWarning(string message) => Console.WriteLine($"[warning] {message}");
            public static void LogError(string message) => Console.WriteLine($"[Error] {message}");
        }
        public static void SaticModifierDemo()
        {
            ConsoleLogger.LogInfo("logger");
            ConsoleLogger.LogWarning("logger");
            ConsoleLogger.LogError("logger");
        }




        class Context
        {
            public const string constant = "constant value";
            public static readonly Guid SomeUniquId = Guid.NewGuid();

            private readonly Worker _worker;

            public Context(Worker worker) => _worker = worker;

            public void SartWork() => _worker.DoWork();


            public void PrintLocalConstant()
            {
                const string localValue = "123";
                Console.WriteLine($"this is the local values {localValue}");
            }
        }
        class Worker
        {
            public void DoWork() => Console.WriteLine("work done");
        }
        public static void ReadonlVsConstDemo()
        {
            Worker worker = new();
            Context context = new Context(worker);

            context.SartWork();
            context.PrintLocalConstant();
            Console.WriteLine($" const feild value: {Context.constant}");
            Console.WriteLine($" static readonly feild value: {Context.SomeUniquId}");
        }



        class SchoolMember
        {
            public string Name { get; set; }
            public string LastName { get; set; }

            protected SchoolMember(string name, string lastname)
            {
                Name = name;
                LastName = lastname;
            }

            public void Setinfo(string name, string lastname)
            {
                Name = name;
                LastName = lastname;
            }
        }

        class Student(string name, string lastname, decimal gpa) : SchoolMember(name, lastname) 
        {
            public decimal GPA { get; private set; } = gpa;
            public void SetGPA(decimal gpa) => GPA = gpa;
        }

        class newTeacher(string name, string lastname, string department) : SchoolMember(name, lastname)
        {
            public string Department { get; set; } = department;

            public void SetDepartment(string department) => Department = department;
        }

        public static void BaseAndDriveDemo()
        {
            Student student = new("khan", "jan", 3.5m);
            newTeacher teacher = new("kareem", "kaku", "it");

            Console.WriteLine($"student object {student.Name} - {student.LastName} - {student.GPA}");
            student.Setinfo("khan2", "jan2");
            Console.WriteLine($"student object {student.Name} - {student.LastName} - {student.GPA}");
            student.SetGPA(4);
            Console.WriteLine($"student object {student.Name} - {student.LastName} - {student.GPA}");



            Console.WriteLine($"teacher object {teacher.Name} - {teacher.LastName} - {teacher.Department}");
            teacher.Setinfo("kareem2", "kaku2");
            Console.WriteLine($"teacher object {teacher.Name} - {teacher.LastName} - {teacher.Department}");
            teacher.SetDepartment("dari");
            Console.WriteLine($"teacher object {teacher.Name} - {teacher.LastName} - {teacher.Department}");
        }
    }
}