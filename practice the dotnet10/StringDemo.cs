using System;
using System.Collections.Generic;
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

                return ($" this is the count {vowelcount}");
            }

        }
    }
}
