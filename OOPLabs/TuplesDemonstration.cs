using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabs
{
    class TuplesDemonstration
    {
        public static void DemonstrateTuplesWorkflow()
        {
            (int number, string magic, char a, string wow, ulong longNumber) namedTuple = (1, "Magic", 'A', "Wow", 34059459684596);
            (int, string, char, string, ulong) tuple = (1, "Magic", 'A', "Wow", 34059459684596);

            Console.WriteLine(namedTuple.magic);
            Console.WriteLine(namedTuple.number);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(namedTuple.Item1);
            Console.WriteLine(namedTuple.Item3);
            Console.WriteLine(namedTuple.Item4);

            var unPacked = namedTuple.Item1;

            if (namedTuple == tuple)
            {
                Console.WriteLine("Tuples values are same.");
            }
            else
            {
                Console.WriteLine("Tuples values are different.");
            }
        }

    }
}
