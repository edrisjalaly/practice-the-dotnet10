using System;
using System.Collections.Generic;
using System.Text;

namespace practice_the_dotnet10
{
    public static class other
    {

        struct Point
        {
            public int x { get; set; }
            public int y { get; set; }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public string Info()
            {
                return $"Point({x}, {y})";
            }
        }
        public static void structsDemo()
        {
            Point p = new Point(10, 5);
            Console.WriteLine($"this is the points {p.Info()}");
        }





    }
}
