using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHIPHUONGDUNG_31231027780_24C1INF50900503
{
    internal class SESSION_01
    {
        public static void Question_01()
        // to Add / Sum Two Numbers
        {
            Console.Write("Nhap so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b:");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"Tong cua hai so la {a} + {b} = {c}");
        }
        public static void Question_02()
        //to Swap Values of Two Variables
        {
            Console.Write("Nhap so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b:");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"So a va b lan luot la {a} , {b}");
        }
        /*public static void Question_03()
        //to Multiply two Floating Point Numbers
        {
            Console.Write("Nhap so a:");
            float a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b:");
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine($" {a} * {b} = {a*b}");
        }*/
        public static void Question_04()
        //convert feet to meter
        {
            Console.WriteLine("Nhap vao so feet");
            float f = float.Parse(Console.ReadLine());
            double m = 0.3048;
            double feet = f * m;
            Console.WriteLine($"{f} feet = {feet} meter");
        }
        public static void Question_05()
        //to convert Celsius to Fahrenheit and vice versa
        {
            Console.WriteLine("Nhap vao so C");
            float c = float.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine($"{c} do C = {f} do F");
        }
        public static void Question_06()
        //to find the Size of data types
        {
            int s = sizeof(int);
            Console.WriteLine($"{s}");
        }
        public static void Question_07()
        //7. to Print ASCII Value (tip: read character, print number of this char)
        {
            char c = 'a';
            int num = c;
            Console.WriteLine($"{c} in ASCII = {num}");
        }
        public static void Question_08()
        //Calculate Area of Circle
        {
            Console.Write("Nhap vao ban kinh:");
            int r = int.Parse(Console.ReadLine());
            double area = 2 * r * Math.PI;
            Console.WriteLine($"Dien tich hinh tron có ban kinh {r} la {area}");
        }
        public static void Question_09()
        //Calculate Area of Square 
        {
            Console.Write("Nhap vao do dai canh :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh vuông có canh {a} la {a * a}");
        }
        public static void Question_10()
        //to convert days to years, weeks and days
        {
            Console.WriteLine("Nhap so ngay: ");
            int a = int.Parse(Console.ReadLine());
            int y = a / 365;
            int m = (a % 365) / 30;
            int d = (a % 365) % 30;
            Console.WriteLine($"So ngay {a} bang {y} nam, {m} thang, {d} ngay");
        }
    }
}
