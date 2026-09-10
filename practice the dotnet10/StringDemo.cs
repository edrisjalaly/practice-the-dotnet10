using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace practice_the_dotnet10
{
    internal static class StringDemo
    {
        public static void stringStructure()
        {
            string text = "sometext";

            // 1
            //for(int i=0; i< text.Length; i++)
            //{
            //    Console.WriteLine(text[i]);
            //}


            // 2
            foreach(char value in text)
            {
                Console.WriteLine(value);
            }
        }

        public static string build(string[] phrases)
        {
            int totalPhrases = phrases.Length;

            int totalVowelCount = 0;
            int maxVowelCount = 0;

            string maxVowelPhrases = string.Empty;


            foreach(string currentPhrases in phrases)
            {
                int vowelcount = 0;

                foreach(var item in currentPhrases)
                {
                    if(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    {
                        vowelcount++;
                        totalVowelCount++;
                    }
                }

                if (vowelcount > maxVowelCount)
                {
                    maxVowelCount = vowelcount;
                    maxVowelPhrases = currentPhrases;
                }

                // string interpolation
                return ($" this is the count {vowelcount}");
            }

            return maxVowelPhrases;
        }



        public static void escapeSequences()
        {
            Console.WriteLine("this is text c:\\ doc\\ file");
            Console.WriteLine("this is text \"hello\"");
            Console.WriteLine("this is text \n this");
            Console.WriteLine(" \u2713 this is text ");
        }



        public static void verbatim()
        {
            string file = string.Empty;
            string size = "4KB";


            string fileDetaild = @"file location is "" c:\document""  files size is 4kb ";
            Console.WriteLine(fileDetaild);

        }




        public static void stringRaw()
        {
            string filedetail = string.Empty;
            string fileSize = "4 kb";

            filedetail = """ 
                   File location is : C:\document\file.txt
                   File size is 4kb
                   """;


            Console.WriteLine(filedetail);
        }
    }
}
