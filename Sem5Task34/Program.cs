// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Генерируем массив
int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return array;
}
// Печатаем результат
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine("");
}
int CountEvn(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(22, 100, 1000);
PrintArray(array);
int count = CountEvn(array);
PrintResult("Количество четных элементов в массиве: " + count);
