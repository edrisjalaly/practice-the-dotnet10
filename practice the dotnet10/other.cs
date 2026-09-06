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



        readonly struct ReadOnlyPoint
        {
            public int x { get; }
            public int y { get;}
            public ReadOnlyPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public string Info()
            {
                return $"ReadOnlyPoint({x}, {y})";
            }
        }
        public static void readonlystructsDemo()
        {
            ReadOnlyPoint p = new ReadOnlyPoint(10, 5);
            //p.y = 10;
            //p.x = 10;

            Console.WriteLine($"this is the points {p.Info()}");

        }




        public static void withExpressionDemo()
        {
            Point point = new Point(10, 5);
            Point point1 = point with { x = 20 };

            Console.WriteLine($"this is the points {point1.Info()}");
        }





        struct conrnerPoint
        {
            public int x { get; set; }
            public int y { get; set; }
            public conrnerPoint()
            {
                x = 5;
                y = 10;
            }
        }
        public static void ExplicitParameterlessConstructorDemo()
        {
            conrnerPoint conrnerPoint = new conrnerPoint();

            Console.WriteLine($"this is the points {conrnerPoint.x}, {conrnerPoint.y}");
        }




        struct AutoDefault
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }

            public AutoDefault()
            {
                x = 10;
                y = 5;
            }
        }
        public static void autoDefaultStructDemo()
        {
            AutoDefault autoDefault = new();
            Console.WriteLine($" this is the points {autoDefault.x} - {autoDefault.y} - {autoDefault.z} ");
        }



        struct PrimaryContructor(int x, int y)
        {
            public int x { get; set; } = x;
            public int y { get; set; } = y;
        }
        public static void primaryConstructorDemo()
        {
            PrimaryContructor primaryContructor = new(50, 20);
            Console.WriteLine($" this is the points {primaryContructor.x} - {primaryContructor.y} ");
        }





    }
}
