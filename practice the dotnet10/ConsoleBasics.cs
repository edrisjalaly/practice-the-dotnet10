using System;

namespace Examples
{
    public static class ConsoleBasics
    {
        public static void PrintPrimitiveSizes()
        {
            Console.WriteLine("size of sbyte: " + sizeof(sbyte));
            Console.WriteLine("size of byte: " + sizeof(byte));
            Console.WriteLine("size of short: " + sizeof(short));
            Console.WriteLine("size of ushort: " + sizeof(ushort));
            Console.WriteLine("size of int: " + sizeof(int));
            Console.WriteLine("size of uint: " + sizeof(uint));
            Console.WriteLine("size of long: " + sizeof(long));
            Console.WriteLine("size of ulong: " + sizeof(ulong));
        }

        public static void VariablesDemo()
        {
            int totalProducts = 100;
            long views = 500;
            float price = 19.99f;
            double result = 15000.80002;
            decimal balance = 100000.50m;
            bool isActive = true;
            char grade = 'A';
            string message = "Hello, World!";
            var name = "i well call you latter";

            Console.WriteLine(message);
        }

        public static void ReadUserAndPassword()
        {
            Console.Write("Enter user name: ");
            var userName = Console.ReadLine();

            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            Console.WriteLine($"User name: {userName}, Password: {password}");
        }

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

        public static void TernaryOperatorDemo()
        {
            int score = 10;
            string result = score > 10 ? "Pass" : "Fail";
            Console.WriteLine(result);
        }

        public static void IfStatement()
        {
            int number = 10;

            if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else if (number == 11)
            {
                Console.WriteLine("select from 1 to 10");
            }
            else { Console.WriteLine("Number is not zero or eleven"); }
        }

        public static void SwitchStatement()
        {
            var number = 2;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }

        public static void ForStatement()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }
        }

        public static void WhileStatement()
        {
            var input = Console.ReadLine();
            while (input != "quit")
            {
                input = Console.ReadLine();
                Console.WriteLine("you typed:" + input);
            }
        }

        public static void DoWhileStatement()
        {
            var input = Console.ReadLine();
            do
            {
                input = Console.ReadLine();
                Console.WriteLine("you typed:" + input);
            } while (input != "quit");
        }

        public static void BreakStatement()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Breaking the loop at iteration: " + i);
                    break;
                }
                Console.WriteLine($"Iteration: {i}");
            }
        }


        public static void ContinueStatement()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Skipping iteration: " + i);
                    continue;
                }
                Console.WriteLine($"Iteration: {i}");
            }
        }
    }
}