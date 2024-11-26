using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace NGUYENTHIPHUONGDUNG_31231027780_24C1INF50900503
{
    internal class SESSION_06
    {
        static void Main(string[] args)
        //Create a random integer values array, then create functions that:
        {
            Console.WriteLine("Nhap vao so n:"); int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next();
            }
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Ques_01(a);
            TimKiem(a, 4);
            Console.WriteLine("Nhap so can tim vi tri:");
            int number = int.Parse(Console.ReadLine());//find index
            int index = FindIndex(a,number);
            if (index!= -1)
                Console.WriteLine($"Giá trị {number} có chỉ số {index} trong mảng.");
            else
                Console.WriteLine($"Giá trị {number} không có trong mảng.");
          
            Console.ReadKey();
        }
        static void Ques_01(int[] a)
        //1. to calculate the average value of array elements.
        {
            float aver = 0;
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            aver = tong / a.Length;
            Console.WriteLine($"Gia tri trung binh la {aver}");
        }
        static int TimKiem(int[] array, int num)
        //to test if an array contains a specific value.
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (max + min) / 2;
                if (num == array[mid])
                {
                    return ++mid;
                }
                else if (num < array[mid])
                { max = mid - 1; }
                else { min = mid + 1; }
            }
            return -1;
        }
        static int FindIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }
    }
}
