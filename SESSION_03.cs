using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHIPHUONGDUNG_31231027780_24C1INF50900503
{
    internal class SESSION_03
    {
        public static void Vidu()
        {
            int sum = 0;
            do
            {
                Console.WriteLine("Enter a integal number (-1 -exit):");
                int num;
                do
                {
                    bool isDigit = int.TryParse(Console.ReadLine(), out num);
                    if (!isDigit)
                        Console.WriteLine("Please enter a number again!");
                }
                while (true);
                sum += num;
                if (num == -1) break;
            } while (true);
            Console.WriteLine($"Sum = {sum}");
        }
        public static void Question_01()
            //Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit
        {
            Console.WriteLine("Nhap do C:");
            int c = int.Parse(Console.ReadLine());
            int k = c + 273;
            float f = c * 18/10 + 32;
            Console.WriteLine($"Kelvin = {k}");
            Console.WriteLine($"Fahrenheint = {f}");
        }
        public static void Question_02()
            //Create a program in C# for calculate the surface and volume of a sphere, given itsradius.
        {
            Console.WriteLine("Nhap vao ban kinh:");
            int r = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double s = 4 * pi * r;
            double v = 4/3 * pi * r;
            Console.WriteLine($"surface = {s}");
            Console.WriteLine($"volume = {v}");
        }
        public static void Question_03()
            //Write a program in C# that calculates the result of adding, subtracting,
            //multiplying and dividing two numbers entered by the user.
        {
            Console.WriteLine("Nhap so a,b:");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }
    }
}
