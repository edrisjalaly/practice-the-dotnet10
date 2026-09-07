using System;
using System.Collections.Generic;
using System.Text;

namespace practice_the_dotnet10
{
    internal static class TypeAndBehavier
    {

        class person(string name, string lastname)
        {
            public string Name { get; set; } = name;
            public string Lastname { get; set; } = lastname;
        }
        struct point(int x, int y)
        {
            public int X { get; set; } = x;
            public int Y { get; set; } = y;
        }
        public static void systemObject()
        {
            object number = 10;
            object text = "Hello World";
            object person = new person("John", "Doe");
            object point = new point(10, 20);

            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(person);
            Console.WriteLine(point);
        }




        public static void valueRefernceType()
        {

        }



        struct userStruct(int age)
        {
            public int Age { get; set; } = age;
        }
        class userClass(int age)
        {
            public int Age { get; set; } = age;
        }
        public static void valueRefernceTypeDemo()
        {
            userStruct userStruct1 = new userStruct(25);
            userClass userClass1 = new userClass(30);

            userStruct userStruct2 = userStruct1;
            userStruct2.Age = 35;

            userClass userClass2 = userClass1; 
            userClass2.Age = 40;

            Console.WriteLine($" this is struct {userStruct1.Age}");
            Console.WriteLine($" this is class {userClass1.Age}");

            Console.WriteLine($" this is struct 2 {userStruct2.Age}");
            Console.WriteLine($" this is class 2 {userClass2.Age}");
        }





        public static void stackVsHeapDemo()
        {

        }



        public static void refVsOutVsInDemo()
        {
            int number1 = 10;            
            ModifyValue( number1);
            void ModifyValue( int num)
            {
                num += 5;
            }
            Console.WriteLine(number1);



            var result = useingOut(out int number2);
            bool useingOut(out int number)
            {
                number = 6;
                return true;
            }            
            Console.WriteLine($"{ result} - {number2}");



            int number4 = 30;
            useIngIn(number4);
            void useIngIn(in int abc)
            {
                Console.WriteLine(abc);
            }


        }



        public static void boxingUnboxingDemo()
        {
            int number = 10;
            object boxedNumber = number; // Boxing

            Console.WriteLine($" boxed {boxedNumber}");


            int unboxedNumber = (int)boxedNumber; // Unboxing
            Console.WriteLine($" unboxed {unboxedNumber}");


        }
    }
}
