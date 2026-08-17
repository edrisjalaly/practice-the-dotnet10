using System;

namespace Examples
{
    public static class Expression
    {
        public static void Expression1()
        {
            // Expression -> oprand operator operand -> value
            int sum = 10 + 20;
            Console.WriteLine($"Sum: {sum}");
        }
        public static void Expression2()
        {
            // Expression -> operator oprand   or   oprand operator -> value
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);

            bool isEnabled = true;
            Console.WriteLine(isEnabled);
        }
        public static void Expression3()
        {
            // Expression -> Expression operator Expression -> value
            var result = 10 + 20 * 2;
            Console.WriteLine($"Result: {result}");
        }
    }
}