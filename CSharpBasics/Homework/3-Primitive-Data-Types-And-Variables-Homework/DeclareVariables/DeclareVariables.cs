// 01. Declare five variables choosing for each of them the most appropriate of the types 
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. 
using System;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            ushort ushortVar = 52130;
            sbyte sbyteVar = -115;
            int intVar = 4825932;
            byte byteVar = 97;
            short shortVar = -10000;

            Console.WriteLine("ushort number - {0}\nsbyte number - {1}\nint number - {2}", ushortVar, sbyteVar, intVar);
            Console.WriteLine("byte number - {0}\nshort number - {1}", byteVar, shortVar);
        }
    }
}
