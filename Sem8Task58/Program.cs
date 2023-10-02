// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// ввод массива
int ReadData(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// заполнение массива рандомными числами
void GenArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// вывод двумерного массива в терминал 
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resArray = new int[rows, columns];

GenArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

GenArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resArray);
