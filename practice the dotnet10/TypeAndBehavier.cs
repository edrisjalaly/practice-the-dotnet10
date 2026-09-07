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



    }
}
