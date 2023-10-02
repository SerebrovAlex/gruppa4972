// // Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// // В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }


// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }

// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void TransponationMatrix(int[,] matrix)
// {
//     if(matrix.GetLength(0) == matrix.GetLength(1)){
//      for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i+1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[j,i];
//             matrix[j,i] = matrix[i,j];
//             matrix[i,j] = temp;
//         }

//     }
//     } else {
//         Console.WriteLine("Эту матрицу нельзя перевернуть");
//     }
// }

// Console.Clear();
// int n = ReadData("Количество строк: ");
// int m = ReadData("Количество столбцов: ");
// Console.WriteLine("Исходная матрица");
// int[,] array2D = Fill2DArray(n,m,10,1);
// Print2DArray(array2D);
// Console.WriteLine("________________");
// TransponationMatrix(array2D);
// Print2DArray(array2D);

using System;
namespace BabbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colCount = 6;//m
            int rowCount = 5;//n
            int[,] arr = GenerateArray(rowCount, colCount);
            Console.WriteLine("Исходный массив");
            PrintArray(arr);
            Console.WriteLine("Сортировка по строкам: ");
            int[] row = new int[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = arr[i, j];
                BubbleSort(row);
                Insert(true, i, row, arr);
            }

            static void Insert(bool isRow, int dim, int[] source, int[,] dest)
            {
                for (int k = 0; k < source.Length; k++)
                {
                    if (isRow)
                        dest[dim, k] = source[k];
                    else
                        dest[k, dim] = source[k];
                }
            }
            static int[,] GenerateArray(int t, int i)
            {
                int[,] table = new int[t, i];
                Random random = new Random();
                for (int a = 0; a < t; a++)
                {
                    for (int b = 0; b < i; b++)
                    {
                        table[a, b] = random.Next(0, 9);
                    }
                }
                return table;
            }
            static void PrintArray(int[,] array)
            {
                for (int a = 0; a < array.GetLength(0); a++)
                {
                    for (int b = 0; b < array.GetLength(1); b++)
                    {
                        Console.Write(array[a, b] + " ");
                    }
                    Console.WriteLine();
                }
            }
            static void BubbleSort(int[] inArray)
            {
                for (int i = 0; i < inArray.Length; i++)
                    for (int j = 0; j < inArray.Length - i - 1; j++)
                    {
                        if (inArray[j] > inArray[j + 1])
                        {
                            int temp = inArray[j];
                            inArray[j] = inArray[j + 1];
                            inArray[j + 1] = temp;
                        }
                    }
            }
        }
    }
}