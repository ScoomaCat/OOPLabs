using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabs
{
    class ArraysDemonstration
    {
        public static void PrintMatrix()
        {
            int[,] arr = new int[5, 4] { { 1, 1, 1, 1 }, { 0, 1, 0, 1 }, { 0, 0, 0, 0 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };

            PrintArray(arr);
        }

        private static void PrintArray(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public static void PrintStringArray()
        {
            string[] stringArray = new string[] { "I", "need", "some", "sleep" };

            Console.WriteLine(stringArray.Length);
            Console.WriteLine("[{0}]", string.Join(", ", stringArray));

            Console.WriteLine("Postion");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("New Value");
            var newValue = Console.ReadLine();

            stringArray[position] = newValue;

            Console.WriteLine("[{0}]", string.Join(", ", stringArray));
        }

        public static void CreateWeirdArray()
        {
            int[][] weirdArray = new int[3][];
            weirdArray[0] = new int[2];
            weirdArray[1] = new int[3];
            weirdArray[2] = new int[4];

            foreach (int[] weirdElement in weirdArray)
            {
                for (int i = 0; i < weirdElement.Length; i++)
                {
                    Console.WriteLine("Gimme array element value");
                    weirdElement[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            foreach (int[] weirdElement in weirdArray)
            {
                for (int i = 0; i < weirdElement.Length; i++)
                {
                    Console.Write(weirdElement[i] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void InitializeImplicitArrays()
        {
            var a = new[] { 1, 10, 100, 1000 };
            var b = "Imma string";
        }
    }
}
