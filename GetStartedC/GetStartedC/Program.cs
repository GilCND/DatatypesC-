/*
Programmer: Felipe SG
Date: 12/01/2021
Program: GetStartedC
Objective: 
Declare several variables by selecting for each one of them the most
appropriate of the types sbyte, byte, short, ushort, int, uint, long
and ulong in order to assign them the following values: 52,130; -115;
4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
1990; 123456789123456789.
 */
using System;

namespace GetStartedC
{
    class Program
    {

        static void Main(string[] args)
        {
            // sbyte -128 to 127 (Signed 8 bit longer)
            sbyte Sbyte = -115;
            sbyte Sbyte2 = -44;
            // byte 0 to 255 (Unsigned 8 bit longer)
            byte Byte = 224;
            byte Byte2 = 97;
            byte Byte3 = 112;
            // short -32768 to 32767 (Signed 16 bit longer)
            short Short = -10000;
            short Short2 = -1990;
            // ushort 0 to 65535 (Unasigned 16 bit longer)
            ushort Ushort = 20000;
            ushort Ushort2 = 52130;
            // int -2147483648 to 2147483647 (Signed 32 bit longer) 
            int Int = 970700000;
            int Int2 = -1000000;
            // uint 0 to 4294967296 (Unsigned 32 bit longer)
            uint Uint = 4825932;
            // long -9233372036854775805 to 9223372036854775807 (Signed 64 bit longer) 
            long Long = 123456789123456789;

            // Print all information to the console
            Console.WriteLine("sbyte \n");
            Console.WriteLine("The sbyte variables: {0} and {1}", Sbyte, Sbyte2);
            Console.WriteLine("---------------------- \n");
            Console.WriteLine("byte \n");      
            Console.WriteLine("The byte variables: {0}, {1}, {2}", Byte, Byte2, Byte3);
            Console.WriteLine("---------------------- \n");
            Console.WriteLine("short \n");
            Console.WriteLine("The short variables: {0}", Short);
            Console.WriteLine("---------------------- \n");
            Console.WriteLine("ushort \n");
            Console.WriteLine("The ushort variables: {0} {1}", Ushort, Ushort2);
            Console.WriteLine("---------------------- \n");
            Console.WriteLine("int \n");
            Console.WriteLine("The int variables: {0} {1}", Int, Int2);
            Console.WriteLine("---------------------- \n");
            Console.WriteLine("uint \n");
            Console.WriteLine("The uint variables: {0}", Uint);
            Console.WriteLine("---------------------- \n");
            Console.WriteLine("long");
            Console.WriteLine("The long variables: {0} ", Long);
            Console.WriteLine("---------------------- \n");

        }
    }
}
