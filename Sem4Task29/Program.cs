// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] GenArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    Random rnd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}
int length = ReadData("Введите размер массива");
int min = ReadData("Минимальное значение массива");
int max = ReadData("Максимальное значение массива");
int[] array = GenArray(length, min, max);
PrintArray(array);

