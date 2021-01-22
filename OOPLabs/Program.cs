using System;
using System.Linq;

namespace OOPLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            initLabOne();
        }

        private static void initLabOne()
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
    }
}
