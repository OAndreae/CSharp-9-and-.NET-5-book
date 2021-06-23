using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // alignment for byte column
            const int byteAl = -4;
            // alignment for min and max value columns
            const int valAl = 30;
            WriteLine("-------------------------------------------------------------------------------");
            WriteLine($"Type         Byte(s) of memory {"Minimum", valAl-13} {"Maximum", valAl}");
            WriteLine("-------------------------------------------------------------------------------");
            WriteLine($"sbyte        {sizeof(sbyte), byteAl} {sbyte.MinValue, valAl} {sbyte.MaxValue, valAl}");
            WriteLine($"byte         {sizeof(byte), byteAl} {byte.MinValue, valAl} {byte.MaxValue, valAl}");
            WriteLine($"short        {sizeof(short), byteAl} {short.MinValue, valAl} {short.MaxValue, valAl}");
            WriteLine($"ushort       {sizeof(ushort), byteAl} {ushort.MinValue, valAl} {ushort.MaxValue, valAl}");
            WriteLine($"int          {sizeof(int), byteAl} {int.MinValue, valAl} {int.MaxValue, valAl}");
            WriteLine($"uint         {sizeof(uint), byteAl} {uint.MinValue, valAl} {uint.MaxValue, valAl}");
            WriteLine($"long         {sizeof(long), byteAl} {long.MinValue, valAl} {long.MaxValue, valAl}");
            WriteLine($"ulong        {sizeof(ulong), byteAl} {ulong.MinValue, valAl} {ulong.MaxValue, valAl}");
            WriteLine($"float        {sizeof(float), byteAl} {float.MinValue, valAl} {float.MaxValue, valAl}");
            WriteLine($"double       {sizeof(double), byteAl} {double.MinValue, valAl} {double.MaxValue, valAl}");
            WriteLine($"decimal      {sizeof(decimal), byteAl} {decimal.MinValue, valAl} {decimal.MaxValue, valAl}");
            WriteLine("-------------------------------------------------------------------------------");
        }
    }
}
