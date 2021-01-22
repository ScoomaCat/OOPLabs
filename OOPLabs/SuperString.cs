using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabs
{
    class SuperString
    {
        public readonly int Id;
        public string InitialString { get; private set; }
        public bool CanBeEqual { get; set; }
        private static int AmountOfSuperStrings { get; set; }

        public SuperString(bool isAllowed, string initialString)
        {
            CanBeEqual = isAllowed;
            InitialString = initialString;
            AmountOfSuperStrings++;
        }

        public SuperString(string initialString)
        {
            InitialString = initialString;
            CanBeEqual = false;
            AmountOfSuperStrings++;
        }

        public SuperString()
        {
            InitialString = "All I want for Christmas is you";
            CanBeEqual = true;
            AmountOfSuperStrings++;
        }

        static SuperString()
        {
            Console.WriteLine("Static construstor of SuperString called!");
        }

        public int GetStringLength()
        {
            return InitialString.Length;
        }

        public bool IsSymbolInString(char symbol)
        {
            int indexOfSubstring = InitialString.IndexOf(symbol);

            return indexOfSubstring >= 0;
        }

        public bool IsSubstringInString(string substring)
        {
            int indexOfSubstring = InitialString.IndexOf(substring);

            return indexOfSubstring >= 0;
        }

        public void ReplaceSymbol(char toReplace, char replacement)
        {
            InitialString = InitialString.Replace(toReplace, replacement);
        }

        public static void PrintInfo()
        {
            Console.WriteLine(AmountOfSuperStrings);
        }

        public override string ToString()
        {
            return "'" + InitialString + "'";
        }

        public override bool Equals(object obj)
        {
            var item = obj as SuperString;

            if (item == null)
            {
                return false;
            }

            return Equals(item.InitialString) && CanBeEqual;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + (int) (Math.PI * 1000);
        }
    }
}
