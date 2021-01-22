using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabs
{
    class StringsDemonstration
    {
        public static void InitAndCompareStringLiterals()
        {
            string people = "people";
            string crap = "crap";

            if (people.Equals(crap)) 
            {
                Console.WriteLine(people + " equals " + crap);
            } else
            {
                Console.WriteLine(people + " are actually nice and not " + crap);
            }
        }

        public static void InitStringFunctions()
        {
            String friendship = "friendship";
            String magic = "magic";

            string conjoinedString = friendship + magic;
            string copiedString = String.Copy(conjoinedString);

            int indexOfSubstring = copiedString.IndexOf(magic);
            string substring = copiedString.Substring(indexOfSubstring);

            Console.WriteLine(substring);

            string textToSplit = "Split me to words";
            string[] words = textToSplit.Split(new char[] { ' ' });
            
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            string textToInsertTo = "What a day";
            string subString = " terrible";
            textToInsertTo = textToInsertTo.Insert(6, subString);
            Console.WriteLine(textToInsertTo);

            conjoinedString = conjoinedString.Remove(1, 10);
            Console.WriteLine(conjoinedString);
        }

        public static void InitEmptyStrings()
        {
            string emptyString = "";
            string nullString = null;

            Console.WriteLine(string.IsNullOrEmpty(emptyString));
            Console.WriteLine(string.IsNullOrEmpty(nullString));

            Console.WriteLine(emptyString.Length);

            try
            {
                Console.WriteLine(nullString.Length);
            }
            catch
            {
                Console.WriteLine("Nope can't do that lol!");
            }
        }

        public static void UseStringBuilder()
        {
            StringBuilder helloWorldStringBuilder = new StringBuilder("I Say Hello World");

            helloWorldStringBuilder.Append("!");
            helloWorldStringBuilder.Remove(0, 2);
            helloWorldStringBuilder.Insert(0, "You ");

            Console.WriteLine(helloWorldStringBuilder);
        }
    }
}
