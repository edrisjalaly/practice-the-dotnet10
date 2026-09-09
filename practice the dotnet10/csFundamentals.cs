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




        public static void twoSum()
        {
            int[] twoSum(int[] numbers, int target)
            {
                int start = 0;
                int end = numbers.Length - 1;

                while( start < end)
                {
                    var match = numbers[start] + numbers[end];

                    if( match == target)
                    {
                        return [numbers[start], numbers[end]]; 
                    }
                    else if(match < target)
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }

                return [];
            }

            int[] numbers = [1,2,3,4,4,5,6];

            int[] result = twoSum(numbers, 8);

            Console.WriteLine($"this is the result {string.Join(",", result)}");
        }




        public static void spreadElement()
        {
            decimal[] decimals = [123.45m, 45.20m];
            decimal[] decimals2 = {3, 4, 5, 6, 7, 8, 9 };



            //time and space O(n + m + K + 1)
            decimal[] combine(decimal[] decimals, decimal[] decimal2) => [..decimals, ..decimal2];
            decimal[] all = combine(decimals, decimals2);


            foreach (decimal number in all)
            {
                Console.WriteLine(number);
            }
        }





        public static void multiDimentionalArray()
        {
            int[,] matrix = new int[2, 2] { { 3, 4 }, { 5, 6 } };

            int first = matrix[0, 0];
            int second = matrix[0, 1];          
            int third = matrix[1, 0];
            int fourth = matrix[1, 1];

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);


            int[] firstArray = [first, second];

            Console.WriteLine(string.Join(",", firstArray));

        }



    }
}
