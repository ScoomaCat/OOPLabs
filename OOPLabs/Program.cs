using System;
using System.Linq;

namespace OOPLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            InitLabOne();
            InitLab2();
            InitLab3();
        }

        private static void InitLabOne()
        {
            TypesDemonstration.InitVariables();
            TypesDemonstration.TypeCastVariablesExplicitly();
            TypesDemonstration.TypeCastVariablesImplicitly();
            TypesDemonstration.Pack();
            TypesDemonstration.InitImplicitVariables();
            TypesDemonstration.InitNullableVariables();

            StringsDemonstration.InitAndCompareStringLiterals();
            StringsDemonstration.InitStringFunctions();
            StringsDemonstration.InitEmptyStrings();
            StringsDemonstration.UseStringBuilder();

            ArraysDemonstration.PrintMatrix();
            ArraysDemonstration.PrintStringArray();
            ArraysDemonstration.CreateWeirdArray();
            ArraysDemonstration.InitializeImplicitArrays();

            TuplesDemonstration.DemonstrateTuplesWorkflow();

            Tuple<int, int, int, char> convertToTuple(int[] intArray, string str)
            {
                return Tuple.Create(intArray.Max(), intArray.Min(), intArray.Sum(), str[0]);
            }

            var result = convertToTuple(new int[] { 2, 4, 6, 8, 10 }, "String to pass");

            Console.WriteLine(result.ToString());
        }

        private static void InitLab2()
        {
            var superString = new SuperString();
            var superString1 = new SuperString(true, "String!");
            var superString2 = new SuperString("Object with some new string lol");
            var superString3 = new SuperString();

            SuperString.PrintInfo();

            Console.WriteLine(superString1.Equals(superString3));
            Console.WriteLine(superString1.Equals(superString2));
            Console.WriteLine(superString2.IsSymbolInString('o'));

            superString1.ReplaceSymbol('a', '1');
            Console.WriteLine(superString1);

            Console.WriteLine(superString3.GetStringLength());
            Console.WriteLine(superString3.GetHashCode());

            SuperString[] superStrings = new SuperString[3];

            for (int i = 0; i < superStrings.Length; i++)
            {
                superStrings[i] = new SuperString();
            }

            Console.WriteLine("All strings bigger than 5: ");
            foreach (SuperString super in superStrings)
            {
                if (super.GetStringLength() > 5)
                {
                    Console.WriteLine(super);
                }
            }

            Console.WriteLine("All strings containing you: ");
            foreach (SuperString super in superStrings)
            {
                if (super.IsSubstringInString("you"))
                {
                    Console.WriteLine(super);
                }
            }

            var AnonimousType = new { InitialString = "That is the initial string", CanBeEqual = true };
        }

        private static void InitLab3()
        {
            try
            {
                ThrowException();
            } 
            catch (WrongNeighbourhoodException e)
            {
                Console.WriteLine("I caught you a nice exception!");
                Console.WriteLine(e);
            }
            catch
            {
                Console.WriteLine("Wow some stuff happened!");
            }

        }

        private static void ThrowException()
        {
            throw new WrongNeighbourhoodException();
        }
    }
}
