using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHIPHUONGDUNG_31231027780_24C1INF50900503
{
    internal class SESSION_07
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so dong (N): ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot (M): ");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"a[{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            InMatran(matrix, N, M);
            Console.Write("Nhap so dong/cot : ");
            int iIndex = int.Parse(Console.ReadLine());
            Console.WriteLine($"Row {iIndex}:");
            Indong(matrix, iIndex, M);
            Console.WriteLine($"Column {iIndex}:");
            Incot(matrix, iIndex, N);
            int maxValue = TimMax(matrix, N, M);
            Console.WriteLine($"Gia tri lon nhat la: {maxValue}");
            int minRowValue = NhoNhatDong(matrix, iIndex, M);
            int minColValue = NhoNhatCot(matrix, iIndex, N);
            Console.WriteLine($"Gia tri nho nhat dong {iIndex}: {minRowValue}");
            Console.WriteLine($"Gia tri nho nhat cot {iIndex}: {minColValue}");

            if (N == M)
            {
                Console.WriteLine("duong cheo chinh:");
                DuongCheochinh(matrix, N);
                Console.WriteLine("duong cheo phu:");
                DuongCheoPhu(matrix, N);
            }
            else
            {
                Console.WriteLine("ma tran ko phai mtran vuong.");
            }
        }

        static void InMatran(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Indong(int[,] matrix, int row, int cols)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[row, j] + "\t");
            }
            Console.WriteLine();
        }

        static void Incot(int[,] matrix, int col, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(matrix[i, col]);
            }
        }

        static int TimMax(int[,] matrix, int rows, int cols)
        {
            int max = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        static int NhoNhatDong(int[,] matrix, int row, int cols)
        {
            int min = matrix[row, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[row, j] < min)
                {
                    min = matrix[row, j];
                }
            }
            return min;
        }

        static int NhoNhatCot(int[,] matrix, int col, int rows)
        {
            int min = matrix[0, col];
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, col] < min)
                {
                    min = matrix[i, col];
                }
            }
            return min;
        }

        static void DuongCheochinh(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(matrix[i, i] + "\t");
            }
            Console.WriteLine();
        }

        static void DuongCheoPhu(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(matrix[i, size - i - 1] + "\t");
            }
            Console.WriteLine();
        }
    }
}
