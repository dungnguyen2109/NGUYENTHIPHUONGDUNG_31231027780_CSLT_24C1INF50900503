using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NGUYENTHIPHUONGDUNG_31231027780_24C1INF50900503
{
    internal class SESSION_05
    {
        //Giai va bien luan phuong trinh bac 1: ax + b = 0
        static void Phuong_trinh()
        {
            Console.Write("Nhap he so a:"); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so b:"); int b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("X tuy y");
                else Console.WriteLine("Vo ly");
            else
                if (b == 0)
                Console.WriteLine("X=0");
            else Console.WriteLine($"X={-b / (float)a}");
        }
        static void Doanso()
        {
            do
            {
                //may nghi 1 so tu 1 den 10
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1; //next(0,10) la tu 0 den 9
                //ng doan
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.WriteLine("Ban doan so may? <1..10>");
                    int user_num = int.Parse(Console.ReadLine());
                    if (comp_num == user_num)
                    {
                        Console.WriteLine($"ban da doan trung sau {count} lan");
                        isContinue = false;
                    }
                    else
                    {
                        if (comp_num > user_num)
                            Console.WriteLine("so ban nghi nho hon so may cho");
                        else
                            Console.WriteLine("so ban nghi lon hon so may cho");
                    }
                } while (isContinue);
                Console.WriteLine("==============================================");
                Console.Write("choi nua hog? <C/K>");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Thua ma hog cho go. Doi");
                    return;
                }
            } while (true);
        }
        //Write a C# function to find the maximum of three numbers.
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap 3 so can tim max");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            int max = Timmax(1, 2, 3);
            Console.WriteLine($"So lon nhat la {max}");
        }
        static int Timmax(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            { max = b; }
            if (c > max)
            { max = c; }
            return max;
        }
        //Write a C# function to calculate the factorial of a number (a non-negative
        //integer). The function accepts the number as an argument.
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 1 so:");
            int num = int.Parse(Console.ReadLine());
            int Giaithua = Factor(num);
            Console.WriteLine($"Giai thua cua {num} la {Giaithua}");
        }
        static int Factor(int a)
        {
            int fac = 1;
            for (int i = 1; i <= a; i++ )
            {
                fac *= i;
                if (i == a)
                    Console.WriteLine($"{i}");
                else
                Console.Write($"{i}*");
            } while (true) ;
            Console.WriteLine();
            return (fac);
        }
        //Write a C# function that takes a number as a parameter and checks whether
        //the number is prime or not.
        static void Main(string[] args)
        {
            Console.Write("Nhap so can kiem tra:");
            int a = int.Parse(Console.ReadLine());
            bool IsPrime = Kt_songuyento(a);
            if (IsPrime)
                Console.WriteLine($"{a} la so nguyen to");
            else
            {
                Console.WriteLine($"{a} khong la so nguyen to");
            }
        }
        static bool Kt_songuyento(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2;i< num; i++)
            {
                if ((num % i) == 0);
                    return false;
            }
            return true;
        }
        //Write a C# function to print
        //1. all prime numbers that less than a number(enter prompt keyboard).
        //2. the first N prime numbers. N so nguyen to dau
        static void Main(string[] args)
        {
            Console.Write("Nhap so can kiem tra:");
            int x = int.Parse(Console.ReadLine());
            Cacsonguyentonhohon(x);
            Console.Write("Nhap so N:");
            int y = int.Parse(Console.ReadLine());
            PrimeDauSauN(y);
        }
        static void Cacsonguyentonhohon(int number)
        {
            for (int i=2; i < number;i++)
            {
                if (Kt_songuyento(i))
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void PrimeDauSauN(int num)
        {
            int count = 0;
            int a = 2;
            while (count < num)
            {
                if (Kt_songuyento(a))
                {
                    Console.Write($"{a} ");
                    count++;
                }
                a++;
            }
        }
        //Write a C# function to check whether a number is "Perfect" or not. Then print
        //all perfect number that less than 1000.
        static void Main(string[] args)
        {
        Console.WriteLine("Cac so hoan hao den 1000 gom:");
            Perfect(1000);
        }
        static void Perfect(int a)
        {
            
            for (int i = 0;i <= a; i++)
            {
                int tong = 0;
                for (int j = 1; j < i;j++)
                {
                    if (i % j == 0)
                        tong += j;
                }
                if (tong == i)
                    Console.Write($"{i}  ");
            }
        }
        //Write a C# function to check whether a string is a pangram or not
    }
}

