using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabs
{
    class TypesDemonstration
    {
        public static void InitVariables()
        {
            bool boolVar = false;
            byte byteVar = 102;
            sbyte sbyteVar = 102;
            short shortVar = 102;
            ushort ushortVar = 102;
            int intVar = 10;
            uint uintVar = 10;
            long longVar = -10;
            ulong unlongVar = 10;
            double doubleVar = 10.2;
            float floatVar = 3.14F;
            char charVar = 'A';
            string hello = "Hello";
            object a = 22;
        }

        public static void TypeCastVariablesImplicitly()
        {
            int intVar = 10;
            char charVar = 'A';

            double castedDouble = intVar;
            long castedLong = intVar;
            float castedFloat = intVar;
            double castedDoubleFromFloat = castedFloat;
            char castedInt = charVar;
        }

        public static void TypeCastVariablesExplicitly()
        {
            double doubleVar = 9.78;
            int intVar = (int)doubleVar;

            string castedString = Convert.ToString(doubleVar);
            double castedDouble = Convert.ToDouble(intVar);
            int castedInt = Convert.ToInt32(castedDouble);
            long castedLongInt = Convert.ToInt64(castedDouble);
        }

        public static void Pack()
        {
            int intVar = 10;

            object packedVar = intVar;
            int unpackedVar = (int)packedVar;
        }

        public static void InitImplicitVariables()
        {
            var i = 5;
            var s = "Hello";
        }

        public static void InitNullableVariables()
        {
            int? z = null;
            Nullable<int> z2 = 5;
            bool? enabled = null;
            Nullable<bool> enabled2 = null;
        }
    }
}
