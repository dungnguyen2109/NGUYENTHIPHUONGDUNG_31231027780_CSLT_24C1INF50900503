using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NGUYENTHIPHUONGDUNG_31231027780_24C1INF50900503
{
    internal class SESSION_04
    {
        static void Session04_mau()
        {
            do
            {
                //1. may nghi ngau nhien 1 so
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1; //lenh next(0,10) chi lay gia tri tu 0 den 9, cong 1 de lay dung gia tri
                                                    //2. keu ng dung dua 1 so
                                                    // doan den khi dung
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("ban doan so may? <1..10> ");
                    int user_num = int.Parse(Console.ReadLine());
                    //3. kiem tra ket qua
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"ban da doan trung sau {count} lan ");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("so ban nhap lon hon so may nghi");
                        else
                            Console.WriteLine("so ban nhap be hon so may nghi");
                    }
                }
                while (isContinue);
                Console.WriteLine("_______________________");
                Console.WriteLine("choi nua hog <C/K>: ");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("thang ma hog cho go. lan sau hog choi nua!");
                    return;
                }
            } while (true);
        }
        static void Session04_ex01()
        //Write a C# Sharp program to check whether a given number is even or odd
        {
            Console.WriteLine("Nhap vao 1 so:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine(" day la so chan");
            else Console.WriteLine(" day la so le ");
        }
        static void Session04_ex02()
        //Write a C# Sharp program to find the largest of three numbers
        {
            Console.Write("Nhap vao so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so c:");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
                Console.WriteLine($"so lon nhat la {a}");
            else
            {
                if (b >= a && b >= c)
                    Console.WriteLine($"so lon nhat la {b}");
                else Console.WriteLine($"so lon nhat la {c}");
            }
        }
        static void Session04_ex03()
        //Write a C# Sharp program to accept a coordinate point in an XY
        //coordinate system and determine in which quadrant the coordinate
        //point lies.
        {
            Console.WriteLine("nhap toa do X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do Y:");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0) { Console.WriteLine("Toa do thuoc phan tu thu nhat"); }
            else if (x < 0 && y > 0) { Console.WriteLine("Toa do thuoc phan tu thu hai"); }
            else if (x < 0 && y < 0) { Console.WriteLine("Toa do thuoc phan tu thu ba"); }
            else if (x > 0 && y < 0) { Console.WriteLine("Toa do thuoc phan tu thu bon"); }
        }
        static void Session04_ex04()
        //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        {
            Console.WriteLine(" nhap so do canh a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" nhap so do canh b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" nhap so do canh c:");
            int c = int.Parse(Console.ReadLine());
            // kiem tra co phai tam giac ko
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                Console.Write("Ba canh a,b,c la 3 canh cua tam giac");
                if (a == b && a == c && b == c) Console.WriteLine("day la tam giac deu");
                else if (a == b || a == c || c == b) Console.WriteLine("day la tam giac can");
                else if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
                    Console.WriteLine("day la tam giac vuong");
                else Console.WriteLine("day la tam giac thuong");
            }
            else
            {
                Console.WriteLine("Ba canh a,b,c khong la 3 canh cua tam giac");
                return;
            }
        }
        static void Session04_ex05()
        //Write a program to read 10 numbers and find their average and sum.
        {
            int sum = 0; int count = 0;
            do
            {
                count++;
                Console.WriteLine("Nhap vao 1 so:");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            while (count == 10);
            float aver = sum / count;
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"average = {aver}");
        }
        public static void Session04_ex06()
        //Write a program to display the multiplication table of a given integer.
        {
            Console.WriteLine(" nhap so can tao bang :");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int a = num * i;
                Console.WriteLine($"{num} x {i} = {a}");
            }
        }
        public static void Session04_ex07()
        //Write a program to display a pattern like triangles with a number
        {
            Console.WriteLine("Nhap 1 so:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void Session04_ex08()
        {
            Console.WriteLine("Nhap so hang:");
            int n = int.Parse(Console.ReadLine());
            int so = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{so} ");
                    so++;
                }
                Console.WriteLine();
            }
        }
        public static void Session04_ex09()
        {
            Console.Write("Nhap so hang: ");
            int n = int.Parse(Console.ReadLine());
            int so = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{so} ");
                    so++; 
                }
                Console.WriteLine();
            }
        }
        public static void Session04_ex10()
            //Write a program to display the n terms of harmonic series and their
            //sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        {
            Console.WriteLine("Nhap so n:");
            int n = int.Parse(Console.ReadLine());
            double tong = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");
                if (i < n )
                    Console.Write(" + ");
                tong += 1.0 / i;
            }
            Console.WriteLine($"tong day so la {tong}");
        }
        public static void Session04_ex11()
        //Write a program to find the ‘perfect’ numbers within a given number range.
        // la so cos tong cac uoc bang chinh no
        {
            Console.WriteLine("Nhap so bat dau");
            int sodau = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so ket thuc");
            int socuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cac so hoan hao tu {sodau} den {socuoi} gom:");
            for (int num = sodau;num <= socuoi; num++)
            {
                int tong = 0;
                for (int i = 1; i < num;i++)
                {
                    if (num % i == 0)
                        tong += i;
                }
                if (tong == num)
                    Console.Write($"{num}  ");
            }
        }
        public static void Session04_ex12()
        //Write a program to determine whether a given number is prime or not.
        {
            Console.WriteLine("Nhap so can kiem tra");
            int num = int.Parse(Console.ReadLine());
            if (num <= 1)
                Console.WriteLine($"{num} khong phai so nguyen to");
            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                    Console.WriteLine("khong phai so nguyen to");
                else Console.WriteLine($"{num} la so nguyen to");
            }
        }
    }
}
