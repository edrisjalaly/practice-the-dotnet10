using System;
using System.Collections.Generic;
using System.Text;

namespace practice_the_dotnet10
{
    internal static class csFundamentals
    {
        public static void bigO()
        {

        }

        class Element(int value)
        {
            public int value { get; set; } = value;
        }
        public static void arrayDemo()
        {
            //1 
            int[] abc = new int[10];
            abc[0] = 100;

            // 2
            int[] numbers = [1, 2, 3, 4];
            numbers[1] = 5;

            Element[] elements = [new Element(10), new Element(20)];

            foreach (Element element in elements)
            {
                Console.WriteLine(element.value);
            }
        }





        public static void arrayIteraion()
        {
            int[] abc = [1, 2, 3, 4];

            // 1
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }
            // 2
            foreach (int a in abc)
            {
                Console.WriteLine(a);
            }
            //3
            int x = 0;
            while(x < abc.Length)
            {
                Console.WriteLine(abc[x]);
                x++;
            }
        }
    }
}
