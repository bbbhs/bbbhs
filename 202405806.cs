using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
 
        static void print_info_primitive_variable()
        {
            Console.WriteLine("bool => 사이즈:{0}, 기본값:{1}"
                , sizeof(bool), default(bool));
            Console.WriteLine("\n\nbyte => 사이즈:{0}, 기본값:{1}, 최솟값: {2}, 최대값:{3}"
                , sizeof(byte), default(byte), byte.MinValue, byte.MaxValue);

            Console.WriteLine("\n\nchar => 사이즈: {0}, 기본값: 0x{1:X4}, 최솟값: 0x{2:X4}, 최대값: 0x{3:X4}"
                , sizeof(char), (ushort)default(char), (ushort)char.MinValue,(ushort)char.MaxValue);

            Console.WriteLine("\n\nshort => 사이즈:{0}, 기본값:{1}, 최솟값: {2}, 최대값:{3}"
                , sizeof(short), default(short), short.MinValue, short.MaxValue);

            Console.WriteLine("\n\nint => 사이즈:{0}, 기본값:{1}, 최솟값: {2}, 최대값:{3}"
                , sizeof(int), default(int), int.MinValue, int.MaxValue);
            Console.WriteLine("\n\nlong => 사이즈:{0}, 기본값:{1}, 최솟값: {2}, 최대값:{3}"
                , sizeof(long), default(long), long.MinValue, long.MaxValue);
            Console.WriteLine("\n\nfloat => 사이즈:{0}, 기본값:{1}, 최솟값: {2}, 최대값:{3}"
                , sizeof(float), default(float), float.MinValue, float.MaxValue);
            Console.WriteLine("\n\ndouble => 사이즈:{0}, 기본값:{1}, 최솟값: {2}, 최대값:{3}"
                , sizeof(double), default(double), double.MinValue, double.MaxValue);

            Console.WriteLine("\n\ndecimal => 사이즈:{0}, 기본값:{1}, 최솟값: {2}, 최대값:{3}"
                , sizeof(decimal), default(decimal), decimal.MinValue, decimal.MaxValue);

            const decimal dc = 1234567890123456789012345678.19M;
            Console.WriteLine($"decimal => {dc}");

        }
        static void Main(string[] args)
        {
            print_info_primitive_variable();
            //Console.WriteLine("HEllo World!");
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //var currentDate = DateTime.Now;
            //Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            //Console.Write($"{ Environment.NewLine}Press any key to exit...");
            //Console.ReadKey(true);
        }
    }
}

